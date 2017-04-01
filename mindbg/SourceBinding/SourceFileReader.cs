using System;
using System.Collections.Generic;
using System.IO;

namespace MinDbg.SourceBinding
{
    /// <summary>
    /// Contains method for reading source files 
    /// and find source code lines based on their
    /// numbers in the source code file.
    /// </summary>
    public sealed class SourceFileReader
    {
        private readonly String p_filePath;

        private List<String> p_lines;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFileReader"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public SourceFileReader(String filePath)
        {
            this.p_filePath = filePath;
        }

        /// <summary>
        /// Gets a line from the source code file with the specified line num.
        /// 
        /// Lines in file start from 1!
        /// </summary>
        /// <value></value>
        public String this[Int32 lineNum]
        {
            get
            {
                if (p_lines == null)
                    Initialize();
                if (lineNum < 1 || lineNum > p_lines.Count)
                    throw new ArgumentException();
                return p_lines[lineNum - 1];
            }
        }

        /// <summary>
        /// Gets the line count.
        /// </summary>
        /// <value>The line count.</value>
        public Int32 LineCount
        {
            get
            {
                if (p_lines == null)
                    Initialize();
                return p_lines.Count;
            }
        }

        // Initialization of the reader
        private void Initialize()
        {
            p_lines = new List<String>();

            using (StreamReader reader = new StreamReader(new FileStream(p_filePath, FileMode.Open, FileAccess.Read, FileShare.None)))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    p_lines.Add(line);
                }
            }
        }
    }
}
