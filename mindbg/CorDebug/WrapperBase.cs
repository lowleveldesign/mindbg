using System;
using System.Diagnostics;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// A base class for all COM wrappers. 
    /// 
    /// Taken from MDBG source.
    /// </summary>
    public abstract class WrapperBase : MarshalByRefObject
    {
        private readonly Object coobject;

        protected readonly CorDebuggerOptions options;

        /// <summary>
        /// Initializes an instance of the Wrapper class.
        /// </summary>
        /// <param name="value">COM object to wrap</param>
        protected WrapperBase(Object value, CorDebuggerOptions options)
        {
            Debug.Assert(value != null);
            this.coobject = value;
            this.options = options;
        }

        /// <summary cref="System.Object.Equals(Object)">
        /// </summary>
        public override bool Equals(Object value)
        {
            if (!(value is WrapperBase))
                return false;
            return ((value as WrapperBase).coobject == this.coobject);
        }

        /// <summary cref="System.Object.GetHashCode">
        /// </summary>
        public override int GetHashCode()
        {
            return coobject.GetHashCode();
        }

        /// <summary>
        /// Override also equality operator so we compare 
        /// COM objects inside instead of wrapper references.
        /// </summary>
        /// <param name="operand">first operand</param>
        /// <param name="operand2">second operand</param>
        /// <returns>true if inner COM objects are the same, false otherwise</returns>
        public static bool operator ==(WrapperBase operand, WrapperBase operand2)
        {
            if (Object.ReferenceEquals(operand, operand2))
                return true;

            if (Object.ReferenceEquals(operand, null))               // this means that operand==null && operand2 is not null 
                return false;

            return operand.Equals(operand2);
        }

        /// <summary>
        /// Override also inequality operator so we compare 
        /// COM objects inside instead of wrapper references.
        /// </summary>
        /// <param name="operand">first operand</param>
        /// <param name="operand2">second operand</param>
        /// <returns>true if inner COM objects are different, true otherwise</returns>
        public static bool operator !=(WrapperBase operand, WrapperBase operand2)
        {
            return !(operand == operand2);
        }
    }
}
