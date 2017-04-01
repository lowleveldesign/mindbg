using System;
using MinDbg.NativeApi;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// Represents a breakpoint in code. It is a base class
    /// for all types of breakpoints.
    /// </summary>
    public abstract class CorBreakpoint : WrapperBase
    {
        private readonly ICorDebugBreakpoint cobreakpoint;

        internal CorBreakpoint(ICorDebugBreakpoint cobreakpoint, CorDebuggerOptions options)
            : base(cobreakpoint, options)
        {
            this.cobreakpoint = cobreakpoint;
        }

        /// <summary>
        /// Activates the breakpoint.
        /// </summary>
        /// <param name="active">if set to <c>true</c> then breakpoint becomes active.</param>
        public void Activate(bool active)
        {
            cobreakpoint.Activate(active ? 1 : 0);
        }

        /// <summary>
        /// Determines whether the breakpoint is active.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if the breakpoint is active; otherwise, <c>false</c>.
        /// </returns>
        public bool IsActive()
        {
            Int32 active;
            cobreakpoint.IsActive(out active);
            return active != 0;
        }
    }

    /// <summary>
    /// Represents a function breakpoint.
    /// </summary>
    public sealed class CorFunctionBreakpoint : CorBreakpoint
    {
        private readonly ICorDebugFunctionBreakpoint p_cobreakpoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="CorFunctionBreakpoint"/> class.
        /// </summary>
        /// <param name="cobreakpoint">The cobreakpoint.</param>
        internal CorFunctionBreakpoint(ICorDebugFunctionBreakpoint cobreakpoint, CorDebuggerOptions options)
            : base(cobreakpoint, options)
        {
            this.p_cobreakpoint = cobreakpoint;
        }

        /// <summary>
        /// Gets the function that the breakpoint is set on.
        /// </summary>
        /// <returns></returns>
        public CorFunction GetFunction()
        {
            ICorDebugFunction cofunc;
            p_cobreakpoint.GetFunction(out cofunc);
            return new CorFunction(cofunc, options);
        }

        /// <summary>
        /// Gets the offset.
        /// </summary>
        /// <returns></returns>
        public UInt32 GetOffset()
        {
            UInt32 offset;
            p_cobreakpoint.GetOffset(out offset);
            return offset;
        }
    }
}
