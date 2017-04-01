using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace MinDbg.NativeApi
{
#pragma warning disable 1591

    [Flags]
    internal enum CreateProcessFlags
    {
        CREATE_NEW_CONSOLE = 0x00000010
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8), ComVisible(false)]
    internal class PROCESS_INFORMATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible")]
        public IntPtr hProcess;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible")]
        public IntPtr hThread;
        public int dwProcessId;
        public int dwThreadId;
        public PROCESS_INFORMATION() { }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8), ComVisible(false)]
    internal class SECURITY_ATTRIBUTES
    {
        public int nLength;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible")]
        public IntPtr lpSecurityDescriptor;
        public bool bInheritHandle;
        public SECURITY_ATTRIBUTES() { }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 8), ComVisible(false)]
    internal class STARTUPINFO
    {
        public int cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public int dwX;
        public int dwY;
        public int dwXSize;
        public int dwYSize;
        public int dwXCountChars;
        public int dwYCountChars;
        public int dwFillAttribute;
        public int dwFlags;
        public short wShowWindow;
        public short cbReserved2;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible")]
        public IntPtr lpReserved2;
        public SafeFileHandle hStdInput;
        public SafeFileHandle hStdOutput;
        public SafeFileHandle hStdError;
        public STARTUPINFO() { }
    }

    internal class NativeMethods
    {
        [DllImport("mscoree.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern ICLRMetaHost CLRCreateInstance(ref Guid clsid, ref Guid riid);
    }
#pragma warning restore 1591
}
