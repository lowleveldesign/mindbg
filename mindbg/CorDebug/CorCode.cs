using System;
using MinDbg.NativeApi;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// Represents the MSIL code.
    /// </summary>
    public sealed class CorCode : WrapperBase
    {
        private ICorDebugCode cocode;

        internal CorCode(ICorDebugCode cocode, CorDebuggerOptions options)
            : base(cocode, options)
        {
            this.cocode = cocode;
        }

        /// <summary>
        /// Creates a new code breakpoint.
        /// </summary>
        /// <returns>A newly created code breakpoint.</returns>
        public CorBreakpoint CreateBreakpoint(Int32 iloffset)
        {
            ICorDebugFunctionBreakpoint cobreak;
            cocode.CreateBreakpoint((UInt32)iloffset, out cobreak);

            return new CorFunctionBreakpoint(cobreak, options);
        }
    }
}
