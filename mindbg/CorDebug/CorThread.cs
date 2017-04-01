using MinDbg.NativeApi;
using MinDbg.SourceBinding;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// A class that represents the ICorDebugThread interface.
    /// </summary>
    public sealed class CorThread : WrapperBase
    {
        private readonly ICorDebugThread cothread;

        /// <summary>
        /// Initializes new instance of the thread object.
        /// </summary>
        /// <param name="cothread">COM thread representation.</param>
        /// <param name="options">The options.</param>
        internal CorThread(ICorDebugThread cothread, CorDebuggerOptions options) 
            : base(cothread, options)
        {
            this.cothread = cothread;
        }

        /// <summary>
        /// Gets the active stack frame.
        /// </summary>
        /// <returns>Active stack frame.</returns>
        public CorFrame GetActiveFrame()
        {
            ICorDebugFrame coframe;
            cothread.GetActiveFrame(out coframe);
            return new CorFrame(coframe, options);
        }

        /// <summary>
        /// Gets the current source position.
        /// </summary>
        /// <returns>The current source position.</returns>
        public CorSourcePosition GetCurrentSourcePosition()
        {
            return GetActiveFrame().GetSourcePosition();
        }
    }
}
