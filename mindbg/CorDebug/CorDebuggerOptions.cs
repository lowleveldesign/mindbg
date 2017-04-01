using System;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// This class holds settings that control
    /// the debugging process.
    /// 
    /// TODO: events so components may subscribe to them
    /// and perform actions based on new settings
    /// </summary>
    public class CorDebuggerOptions
    {
        private String symbolPath;
        private Boolean symbolPathInitialized;

        private bool p_isAttaching;

        public String SymbolPath
        {
            get
            {
                if (!symbolPathInitialized)
                {
                    symbolPathInitialized = true;
                    // by default we extract the symbol path
                    // from environment variable
                    symbolPath = Environment.GetEnvironmentVariable("_NT_SYMBOL_PATH");
                }
                return symbolPath;
            }
            set
            {
                symbolPathInitialized = true;
                symbolPath = value;
                // TODO trigger on change event
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether debugger is attaching to the process.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if debugger is attaching to the process; otherwise, <c>false</c>.
        /// </value>
        internal bool IsAttaching
        {
            get { return p_isAttaching;  }
            set { p_isAttaching = value; }
        }
    }
}
