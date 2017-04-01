using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace MinDbg.NativeApi
{
    [ComImport, Guid("00000100-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IEnumUnknown
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int Next([In] uint celt,  [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)] object[] rgelt, [Out] out uint pceltFetched);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumUnknown ppenum);
    }

    [ComImport, Guid("D332DB9E-B9B3-4125-8207-A14884F53216"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICLRMetaHost
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        IntPtr GetRuntime([In, MarshalAs(UnmanagedType.LPWStr)] string pwzVersion, [In] ref Guid riid);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetVersionFromFile([In, MarshalAs(UnmanagedType.LPWStr)] string pwzFilePath, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzBuffer, [In, Out] ref uint pcchBuffer);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        IEnumUnknown EnumerateInstalledRuntimes();
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        IEnumUnknown EnumerateLoadedRuntimes([In] IntPtr hndProcess);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RequestRuntimeLoadedNotification([In, MarshalAs(UnmanagedType.Interface)] ICLRMetaHost pCallbackFunction);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        IntPtr QueryLegacyV2RuntimeBinding([In] ref Guid riid);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ExitProcess([In] int iExitCode);
    }

    [ComImport, Guid("BD39D1D2-BA2F-486A-89B0-B4B0CB466891"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICLRRuntimeInfo
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetVersionString([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzBuffer, [In, Out] ref uint pcchBuffer);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRuntimeDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzBuffer, [In, Out] ref uint pcchBuffer);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int IsLoaded([In] IntPtr hndProcess);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), LCIDConversion(3)]
        void LoadErrorString([In] uint iResourceID, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzBuffer, [In, Out] ref uint pcchBuffer);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        IntPtr LoadLibrary([In, MarshalAs(UnmanagedType.LPWStr)] string pwzDllName);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        IntPtr GetProcAddress([In, MarshalAs(UnmanagedType.LPStr)] string pszProcName);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetInterface([In] ref Guid rclsid, [In] ref Guid riid, [Out, MarshalAs(UnmanagedType.Interface)] out Object ppObj);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int IsLoadable();
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetDefaultStartupFlags([In] uint dwStartupFlags, [In, MarshalAs(UnmanagedType.LPWStr)] string pwzHostConfigFile);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDefaultStartupFlags(out uint pdwStartupFlags, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzHostConfigFile, [In, Out] ref uint pcchHostConfigFile);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void BindAsLegacyV2Runtime();
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsStarted(out int pbStarted, out uint pdwStartupFlags);
    }
}
