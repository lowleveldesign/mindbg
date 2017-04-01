using System;

namespace MinDbg.SourceBinding
{
    /// <summary>
    /// Represents a portion of the source code.
    /// </summary>
    public sealed class CorSourcePosition
    {
        private readonly bool p_isSpecial;
        private readonly String p_path;
        private readonly Int32 p_startLine, p_endLine, p_startColumn, p_endColumn;

        internal CorSourcePosition(bool isSpecial, String path, Int32 startLine, Int32 endLine,
                                    Int32 startColumn, Int32 endColumn)
        {
            this.p_isSpecial = isSpecial;
            this.p_path = path;
            this.p_startLine = startLine;
            this.p_endLine = endLine;
            this.p_startColumn = startColumn;
            this.p_endColumn = endColumn;
        }

        /// <summary>
        /// Gets the path to the source file.
        /// </summary>
        /// <value>The path to the source file.</value>
        public String Path
        {
            get { return p_path;  }
        }

        /// <summary>
        /// Gets a value indicating whether this source position is connected with a special 
        /// sequence point.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is special; otherwise, <c>false</c>.
        /// </value>
        public bool IsSpecial
        {
            get { return p_isSpecial; }
        }

        /// <summary>
        /// Gets the start line.
        /// </summary>
        /// <value>The start line.</value>
        public Int32 StartLine
        {
            get { return p_startLine; }
        }

        /// <summary>
        /// Gets the end line.
        /// </summary>
        /// <value>The end line.</value>
        public Int32 EndLine
        {
            get { return p_endLine; }
        }

        /// <summary>
        /// Gets the start column.
        /// </summary>
        /// <value>The start column.</value>
        public Int32 StartColumn
        {
            get { return p_startColumn; }
        }

        /// <summary>
        /// Gets the end column.
        /// </summary>
        /// <value>The end column.</value>
        public Int32 EndColumn
        {
            get { return p_endColumn;  }
        }
    }
}
