using System;
using MinDbg.NativeApi;
using MinDbg.SourceBinding;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// Represents an ICorDebugFrame.
    /// </summary>
    public sealed class CorFrame : WrapperBase
    {
        private readonly ICorDebugFrame coframe;

        internal CorFrame(ICorDebugFrame coframe, CorDebuggerOptions options)
            : base(coframe, options)
        {
            this.coframe = coframe;
        }

        private ICorDebugILFrame GetILFrame()
        {
            // FIXME why this frame should be cached
            return coframe as ICorDebugILFrame;
        }

        /// <summary>
        /// Gets the IP.
        /// </summary>
        /// <param name="offset">The offset.</param>
        /// <param name="mappingResult">The mapping result.</param>
        public void GetIP(out UInt32 offset, out CorDebugMappingResult mappingResult)
        {
            ICorDebugILFrame ilframe = GetILFrame();
            if (ilframe == null)
            {
                offset = 0;
                mappingResult = CorDebugMappingResult.MAPPING_NO_INFO;
            }
            else
            {
                ilframe.GetIP(out offset, out mappingResult);
            }
        }

        /// <summary>
        /// Gets the currently executing function.
        /// </summary>
        /// <returns></returns>
        public CorFunction GetFunction()
        {
            ICorDebugFunction cofunc;
            coframe.GetFunction(out cofunc);
            return cofunc == null ? null : new CorFunction(cofunc, options);
        }

        /// <summary>
        /// Gets the currently executed function token.
        /// </summary>
        /// <returns></returns>
        public UInt32 GetFunctionToken()
        {
            UInt32 token;
            coframe.GetFunctionToken(out token);
            return token;
        }

        /// <summary>
        /// Gets the source position.
        /// </summary>
        /// <returns>The source position.</returns>
        public CorSourcePosition GetSourcePosition()
        {
            return GetFunction().GetSourcePositionFromFrame(this);
        }
    }
}
