
namespace MinDbg.CorDebug
{
    /// <summary>
    /// A base class for all debugging events.
    /// </summary>
    public class CorEventArgs
    {
        private readonly CorController controller;

        /// <summary>
        /// Initializes the event instance.
        /// </summary>
        /// <param name="controller">Controller of the debugging process.</param>
        public CorEventArgs(CorController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Gets the controller.
        /// </summary>
        /// <value>The controller.</value>
        public CorController Controller { get { return this.controller;  } }

        /// <summary>
        /// Gets or sets a value indicating whether debugging process should continue.
        /// </summary>
        /// <value><c>true</c> if continue; otherwise, <c>false</c>.</value>
        public bool Continue { get; set; }
    }

    /// <summary>
    /// Event args for module load event.
    /// </summary>
    public sealed class CorModuleLoadEventArgs : CorEventArgs
    {
        private readonly CorModule module;

        /// <summary>
        /// Initializes a new instance of the <see cref="CorModuleLoadEventArgs"/> class.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <param name="module">The module.</param>
        public CorModuleLoadEventArgs(CorController controller, CorModule module)
            : base(controller)
        {
            this.module = module;
        }

        /// <summary>
        /// Gets the module.
        /// </summary>
        /// <value>The module.</value>
        public CorModule Module { get { return this.module; } }
    }

    /// <summary>
    /// Event args for breakpoint event.
    /// </summary>
    public sealed class CorBreakpointEventArgs : CorEventArgs
    {
        private readonly CorThread p_thread;
        private readonly CorBreakpoint p_breakpoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="CorBreakpointEventArgs"/> class.
        /// </summary>
        /// <param name="appdomain">The controller.</param>
        /// <param name="thread">The thread.</param>
        /// <param name="breakpoint">The breakpoint.</param>
        public CorBreakpointEventArgs(CorAppDomain appdomain, CorThread thread, CorBreakpoint breakpoint) 
            : base(appdomain)
        {
            this.p_thread = thread;
            this.p_breakpoint = breakpoint;
        }

        /// <summary>
        /// Gets the thread.
        /// </summary>
        /// <value>The thread.</value>
        public CorThread Thread
        {
            get { return p_thread; }
        }

        /// <summary>
        /// Gets the process that the breakpoint was hit on.
        /// </summary>
        /// <value>The app domain.</value>
        public CorProcess GetProcess()
        {
            return ((CorAppDomain)Controller).GetProcess();
        }

        /// <summary>
        /// Gets the breakpoint.
        /// </summary>
        /// <value>The breakpoint.</value>
        public CorBreakpoint Breakpoint
        {
            get { return p_breakpoint; }
        }
    }
}
