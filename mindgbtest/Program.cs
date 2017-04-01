using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using MinDbg;
using MinDbg.CorDebug;
using MinDbg.SourceBinding;

namespace mindgbtest
{
    class Program
    {
        static Regex methodBreakpointRegex = new Regex(@"^((?<module>[\.\w\d]*)!)?(?<class>[\w\d\.]+)\.(?<method>[\w\d]+)$");
        static Regex codeBreakpointRegex = new Regex(@"^(?<filepath>[\\\.\S]+)\:(?<linenum>\d+)$");

        static void PrintUsage()
        {
            Console.WriteLine("Usage: mindbgtest.exe { -p pid | appname }");
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
                return;
            }

            if (String.Equals(args[0], "-p", StringComparison.Ordinal))
            {
                // attaching to the process
                Int32 pid;
                if (args.Length != 2)
                {
                    PrintUsage();
                    return;
                }
                if (!Int32.TryParse(args[1], out pid))
                {
                    PrintUsage();
                    return;
                }
                var debugger = DebuggingFacility.CreateDebuggerForProcess(pid);
                debugger.DebugActiveProcess(pid);
            }
            else
            {
                var debugger = DebuggingFacility.CreateDebuggerForExecutable(args[0]);
                var process = debugger.CreateProcess(args[0]);

                process.OnBreakpoint += new MinDbg.CorDebug.CorProcess.CorBreakpointEventHandler(process_OnBreakpoint);
            }
            Console.ReadKey();
        }

        static void ProcessCommand(CorProcess process)
        {
            while (true)
            {
                Console.Write("> ");
                String command = Console.ReadLine();

                if (command.StartsWith("set-break", StringComparison.Ordinal))
                {
                    // setting breakpoint
                    command = command.Remove(0, "set-break".Length).Trim();

                    // try module!type.method location (simple regex used)
                    Match match = methodBreakpointRegex.Match(command);
                    if (match.Groups["method"].Length > 0)
                    {
                        Console.Write("Setting method breakpoint... ");

                        CorFunction func = process.ResolveFunctionName(match.Groups["module"].Value, match.Groups["class"].Value,
                                                                        match.Groups["method"].Value);
                        func.CreateBreakpoint().Activate(true);

                        Console.WriteLine("done.");
                        continue;
                    }
                    // try file code:line location
                    match = codeBreakpointRegex.Match(command);
                    if (match.Groups["filepath"].Length > 0)
                    {
                        Console.Write("Setting code breakpoint...");

                        int offset;
                        CorCode code = process.ResolveCodeLocation(match.Groups["filepath"].Value,
                                                                   Int32.Parse(match.Groups["linenum"].Value),
                                                                   out offset);
                        code.CreateBreakpoint(offset).Activate(true);

                        Console.WriteLine("done.");
                        continue;
                    }
                }
                else if (command.StartsWith("go", StringComparison.Ordinal))
                {
                    process.Continue(false);
                    break;
                }
            }
        }

        static void DisplayCurrentSourceCode(CorSourcePosition source)
        {
            SourceFileReader sourceReader = new SourceFileReader(source.Path);
            ConsoleColor oldcolor = Console.ForegroundColor;

            // Print three lines of code
            Debug.Assert(source.StartLine < sourceReader.LineCount && source.EndLine < sourceReader.LineCount);
            if (source.StartLine >= sourceReader.LineCount ||
                source.EndLine >= sourceReader.LineCount)
                return;

            for (Int32 i = source.StartLine; i <= source.EndLine; i++)
            {
                String line = sourceReader[i];
                bool highlightning = false;

                // for each line highlight the code
                for (Int32 col = 0; col < line.Length; col++)
                {
                    if (source.EndColumn == 0 || col >= source.StartColumn - 1 && col <= source.EndColumn)
                    {
                        // highlight
                        if (!highlightning)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            highlightning = true;
                        }
                        Console.Write(line[col]);
                    }
                    else
                    {
                        // normal display
                        if (highlightning)
                        {
                            Console.ForegroundColor = oldcolor;
                            highlightning = false;
                        }
                        Console.Write(line[col]);
                    }
                }
            }
            Console.ForegroundColor = oldcolor;
            Console.WriteLine();
        }

        static void process_OnBreakpoint(MinDbg.CorDebug.CorBreakpointEventArgs ev)
        {
            Console.WriteLine("Breakpoint hit.");

            var source = ev.Thread.GetCurrentSourcePosition();

            DisplayCurrentSourceCode(source);

            ProcessCommand((ev.Controller is CorProcess) ? (CorProcess)ev.Controller : ((CorAppDomain)ev.Controller).GetProcess());
        }
    }
}
