using MinDbg.NativeApi;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// A parent class for all debug controllers such as processes,
    /// appdomains.
    /// </summary>
    public abstract class CorController : WrapperBase
    {
        internal readonly ICorDebugController cocntrl;

        /// <summary>
        /// Creates an instance of the controller.
        /// </summary>
        /// <param name="cocntrl">ICorDebugController instance</param>
        internal CorController(ICorDebugController cocntrl, CorDebuggerOptions options) 
            : base(cocntrl, options)
        {
            this.cocntrl = cocntrl;
        }

        /// <summary>
        /// Continues the debugging.
        /// </summary>
        /// <param name="outOfBand">if set to <c>true</c> [out of band].</param>
        public virtual void Continue(bool outOfBand)
        {
            this.cocntrl.Continue(outOfBand ? 1 : 0);
        }
    }
}
