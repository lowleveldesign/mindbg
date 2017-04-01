using System;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using MinDbg.NativeApi;
using MinDbg.SourceBinding;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// Represents ICorDebugFunction interface.
    /// </summary>
    public sealed class CorFunction : WrapperBase
    {
        private readonly ICorDebugFunction cofunc;

        internal CorFunction(ICorDebugFunction cofunc, CorDebuggerOptions options)
            : base(cofunc, options)
        {
            this.cofunc = cofunc;
        }

        /// <summary>
        /// Creates the breakpoint.
        /// </summary>
        /// <returns>A function breakpoint instance.</returns>
        public CorFunctionBreakpoint CreateBreakpoint()
        {
            ICorDebugFunctionBreakpoint funcBreakpoint;
            cofunc.CreateBreakpoint(out funcBreakpoint);
            return new CorFunctionBreakpoint(funcBreakpoint, options);
        }

        /// <summary>
        /// Gets the module.
        /// </summary>
        /// <returns></returns>
        public CorModule GetModule()
        {
            ICorDebugModule comodule;
            cofunc.GetModule(out comodule);
            return new CorModule(comodule, options);
        }

        /// <summary>
        /// Gets the function token.
        /// </summary>
        /// <returns></returns>
        public UInt32 GetToken()
        {
            UInt32 token;
            cofunc.GetToken(out token);
            return token;
        }

        /// <summary>
        /// Gets the function version number.
        /// </summary>
        /// <returns>The function version number.</returns>
        public UInt32 GetVersionNumber()
        {
            UInt32 version;
            ((ICorDebugFunction2)cofunc).GetVersionNumber(out version);
            return version;
        }

        /// <summary>
        /// Gets the function IL code body.
        /// </summary>
        /// <returns>function's IL code representation</returns>
        public CorCode GetILCode()
        {
            ICorDebugCode cocode = null;
            cofunc.GetILCode(out cocode);
            return new CorCode(cocode, options);
        }

        /// <summary>
        /// Returns instruction pointer (sequence point) relevant to the given 
        /// line number.
        /// </summary>
        /// <param name="document">symbol document</param>
        /// <param name="lineNumber">line number</param>
        /// <returns>instruction pointer</returns>
        internal int GetIPFromPosition(ISymbolDocument document, int lineNumber)
        {
            SetupSymbolInformation();
            if (!p_hasSymbols)
                return -1;

            for (int i = 0; i < p_SPcount; i++)
            {
                if (document.URL.Equals(p_SPdocuments[i].URL) && lineNumber == p_SPstartLines[i])
                    return p_SPoffsets[i];
            }
            return -1;
        }

        /// <summary>
        /// Gets the source position from the instruction pointer.
        /// 
        /// This function is based on mdbg source.
        /// </summary>
        /// <param name="ip">The instruction pointer.</param>
        /// <returns></returns>
        public CorSourcePosition GetSourcePositionFromIP(Int32 ip)
        {
            SetupSymbolInformation();
            if (!p_hasSymbols)
                return null;

            if (p_SPcount > 0 && p_SPoffsets[0] <= ip)
            {
                Int32 i;
                // find a sequence point that the given instruction
                // pointer belongs to
                for (i = 0; i < p_SPcount; i++)
                {
                    if (p_SPoffsets[i] >= ip)
                        break;
                }

                // ip does not belong to any sequence point
                if (i == p_SPcount || p_SPoffsets[i] != ip)
                    i--;

                CorSourcePosition sp = null;
                if (p_SPstartLines[i] == SpecialSequencePoint)
                {
                    // special type of sequence point
                    // it indicates that the source code 
                    // for this part is hidden from the debugger

                    // search backward for the last known line 
                    // which is not a special sequence point
                    Int32 noSpecialSequencePointInd = i;
                    while (--noSpecialSequencePointInd >= 0)
                        if (p_SPstartLines[noSpecialSequencePointInd] != SpecialSequencePoint)
                            break;

                    if (noSpecialSequencePointInd < 0)
                    {
                        // if not found in backward search
                        // search forward for the first known line
                        // which is not a special sequence point
                        noSpecialSequencePointInd = i;
                        while (++noSpecialSequencePointInd < p_SPcount)
                            if (p_SPstartLines[noSpecialSequencePointInd] != SpecialSequencePoint)
                                break;
                    }

                    Debug.Assert(noSpecialSequencePointInd >= 0);
                    if (noSpecialSequencePointInd < p_SPcount)
                    {
                        sp = new CorSourcePosition(true,
                                                   p_SPdocuments[noSpecialSequencePointInd].URL,
                                                   p_SPstartLines[noSpecialSequencePointInd],
                                                   p_SPendLines[noSpecialSequencePointInd],
                                                   p_SPstartColumns[noSpecialSequencePointInd],
                                                   p_SPendColumns[noSpecialSequencePointInd]);
                    }
                }
                else
                {
                    sp = new CorSourcePosition(false, p_SPdocuments[i].URL, p_SPstartLines[i], p_SPendLines[i],
                                                p_SPstartColumns[i], p_SPendColumns[i]);
                }
                return sp;
            }
            return null;
        }

        /// <summary>
        /// Gets the source position from frame.
        /// </summary>
        /// <param name="frame">The frame.</param>
        /// <returns></returns>
        public CorSourcePosition GetSourcePositionFromFrame(CorFrame frame)
        {
            UInt32 ip;
            CorDebugMappingResult mappingResult;

            frame.GetIP(out ip, out mappingResult);

            if (mappingResult == CorDebugMappingResult.MAPPING_NO_INFO ||
                mappingResult == CorDebugMappingResult.MAPPING_UNMAPPED_ADDRESS)
                return null;

            return GetSourcePositionFromIP((Int32)ip);
        }

        /* *** SYMBOLS *** */

        private ISymbolMethod p_symMethod;
        private Int32[] p_SPoffsets;
        private ISymbolDocument[] p_SPdocuments;
        private Int32[] p_SPstartLines, p_SPendLines, p_SPstartColumns, p_SPendColumns;
        private Int32 p_SPcount;

        private bool p_symbolsInitialized;
        private bool p_hasSymbols;

        /// <summary>
        /// Constant to indicate if a Sequence Point is Special.
        /// </summary>
        public const int SpecialSequencePoint = 0xfeefee;

        // Initializes all private symbol variables
        private void SetupSymbolInformation()
        {
            if (p_symbolsInitialized)
                return;

            p_symbolsInitialized = true;
            CorModule module = GetModule();
            ISymbolReader symreader = module.GetSymbolReader();
            p_hasSymbols = symreader != null;
            if (p_hasSymbols)
            {
                ISymbolMethod sm = null;
                sm = symreader.GetMethod(new SymbolToken((Int32)GetToken())); // FIXME add version
                if (sm == null)
                {
                    p_hasSymbols = false;
                    return;
                }
                p_symMethod = sm;
                p_SPcount = p_symMethod.SequencePointCount;
                p_SPoffsets = new Int32[p_SPcount];
                p_SPdocuments = new ISymbolDocument[p_SPcount];
                p_SPstartLines = new Int32[p_SPcount];
                p_SPendLines = new Int32[p_SPcount];
                p_SPstartColumns = new Int32[p_SPcount];
                p_SPendColumns = new Int32[p_SPcount];

                p_symMethod.GetSequencePoints(p_SPoffsets, p_SPdocuments, p_SPstartLines,
                                                p_SPstartColumns, p_SPendLines, p_SPendColumns);
            }
        }
    }
}
