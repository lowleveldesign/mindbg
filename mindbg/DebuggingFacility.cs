using System;
using System.Diagnostics;
using System.Text;
using MinDbg.CorDebug;
using MinDbg.NativeApi;

namespace MinDbg
{
    /// <summary>
    /// Exception thrown by debugger initializer when desired runtime version was not found .
    /// </summary>
    public sealed class RuntimeNotFoundException : Exception
    {
        /// <summary>
        /// Constructs a new instance of the class.
        /// </summary>
        public RuntimeNotFoundException() { }
    }

    /// <summary>
    /// A static class that allows creation of the debugger instance.
    /// </summary>
    public static class DebuggingFacility
    {
        private static Guid IID_ICorDebug = new Guid("3D6F5F61-7538-11D3-8D5B-00104B35E7EF");
        private static Guid CLSID_ICorDebug = new Guid("DF8395B5-A4BA-450B-A77C-A9A47762C520");

        private static Guid IID_ICLRMetahost = new Guid("D332DB9E-B9B3-4125-8207-A14884F53216");
        private static Guid CLSID_ICLRMetahost = new Guid("9280188D-0E8E-4867-B30C-7FA83884E8DE");

        /// <summary>
        /// Steps through the enumerator and returns the ICLRRuntimeInfo instance 
        /// for the given version of the runtime.
        /// </summary>
        /// <param name="runtimes">runtimes enumerator (taken from Enumerate*Runtimes method)</param>
        /// <param name="version">
        /// the desired version of the runtime - you don't need to 
        /// provide the whole version string as only the first n letters
        /// are compared, for example version string: "v2.0" will match
        /// runtimes versioned "v2.0.1234" or "v2.0.50727". If <code>null</code>
        /// is given, the first found runtime will be returned.
        /// </param>
        /// <returns></returns>
        private static ICLRRuntimeInfo GetRuntime(IEnumUnknown runtimes, String version)
        {
            Object[] temparr = new Object[3];
            uint fetchedNum;
            String highestVersion = null;
            ICLRRuntimeInfo result = null;
            do
            {
                runtimes.Next(Convert.ToUInt32(temparr.Length), temparr, out fetchedNum);

                for (int i = 0; i < fetchedNum; i++)
                {
                    ICLRRuntimeInfo t = (ICLRRuntimeInfo)temparr[i];

                    // initialize buffer for the runtime version string
                    StringBuilder sb = new StringBuilder(16);
                    UInt32 len = Convert.ToUInt32(sb.Capacity);
                    t.GetVersionString(sb, ref len);

                    // version not specified we return the first one
                    if (!String.IsNullOrEmpty(version))
                    {
                        if (sb.ToString().StartsWith(version, StringComparison.Ordinal))
                            return t;
                    }
                    else
                    {
                        if (highestVersion == null || String.CompareOrdinal(version, highestVersion) > 0)
                        {
                            highestVersion = version;
                            result = t;
                        }
                    }
                }
            } while (fetchedNum == temparr.Length);

            return result;
        }

        // creates ICorDebug instance from ICLRRuntimeInfo
        private static CorDebugger CreateDebugger(ICLRRuntimeInfo runtime, CorDebuggerOptions options)
        {
            Object res;
            runtime.GetInterface(ref CLSID_ICorDebug, ref IID_ICorDebug, out res);

            return new CorDebugger((ICorDebug)res, options);
        }

        /// <summary>
        /// Creates new process under the debugger.
        /// </summary>
        /// <param name="exepath">executable path</param>
        /// <param name="desiredVersion">the desired version of the runtime - you don't need to
        /// provide the whole version string as only the first n letters
        /// are compared, for example version string: "v2.0" will match
        /// runtimes versioned "v2.0.1234" or "v2.0.50727". If <code>null</code>
        /// is given, the first found runtime will be returned.</param>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static CorDebugger CreateDebuggerForExecutable(String exepath, String desiredVersion = null, CorDebuggerOptions options = null)
        {
            ICLRMetaHost metahost = NativeMethods.CLRCreateInstance(ref CLSID_ICLRMetahost, ref IID_ICLRMetahost);

            IEnumUnknown runtimes = metahost.EnumerateInstalledRuntimes();
            ICLRRuntimeInfo runtime = GetRuntime(runtimes, desiredVersion);
            if (runtime == null)
            {
                throw new RuntimeNotFoundException();
            }

            return CreateDebugger(runtime, options ?? new CorDebuggerOptions());
        }

        /// <summary>
        /// Attaches debugger to the running process.
        /// </summary>
        /// <param name="pid">Process id</param>
        /// <param name="desiredVersion">the desired version of the runtime - you don't need to
        /// provide the whole version string as only the first n letters
        /// are compared, for example version string: "v2.0" will match
        /// runtimes versioned "v2.0.1234" or "v2.0.50727". If <code>null</code>
        /// is given, the first found runtime will be returned.</param>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static CorDebugger CreateDebuggerForProcess(Int32 pid, String desiredVersion = null, CorDebuggerOptions options = null)
        {
            ICLRMetaHost metahost = NativeMethods.CLRCreateInstance(ref CLSID_ICLRMetahost, ref IID_ICLRMetahost);

            Process proc = Process.GetProcessById(pid);
            IEnumUnknown runtimes = metahost.EnumerateLoadedRuntimes(proc.Handle);
            ICLRRuntimeInfo runtime = GetRuntime(runtimes, desiredVersion);
            if (runtime == null)
            {
                throw new RuntimeNotFoundException();
            }

            return CreateDebugger(runtime, options ?? new CorDebuggerOptions());
        }
    }
}
