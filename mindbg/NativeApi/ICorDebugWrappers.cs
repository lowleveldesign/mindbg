using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MinDbg.NativeApi
{

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    internal struct COR_IL_MAP
    {
        public uint oldOffset;
        public uint newOffset;
        public int fAccurate;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    internal struct COR_VERSION
    {
        public uint dwMajor;
        public uint dwMinor;
        public uint dwBuild;
        public uint dwSubBuild;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    internal struct FILETIME
    {
        public uint dwLowDateTime;
        public uint dwHighDateTime;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    internal struct LARGE_INTEGER
    {
        public long QuadPart;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    internal struct ULARGE_INTEGER
    {
        public ulong QuadPart;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    internal struct COR_DEBUG_STEP_RANGE
    {
        public uint startOffset;
        public uint endOffset;
    }

    internal enum CorDebugChainReason
    {
        CHAIN_CLASS_INIT = 1,
        CHAIN_CONTEXT_POLICY = 8,
        CHAIN_CONTEXT_SWITCH = 0x400,
        CHAIN_DEBUGGER_EVAL = 0x200,
        CHAIN_ENTER_MANAGED = 0x80,
        CHAIN_ENTER_UNMANAGED = 0x100,
        CHAIN_EXCEPTION_FILTER = 2,
        CHAIN_FUNC_EVAL = 0x800,
        CHAIN_INTERCEPTION = 0x10,
        CHAIN_NONE = 0,
        CHAIN_PROCESS_START = 0x20,
        CHAIN_SECURITY = 4,
        CHAIN_THREAD_START = 0x40
    }

    internal enum CorDebugCreateProcessFlags
    {
        DEBUG_NO_SPECIAL_OPTIONS
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    internal enum CorDebugExceptionCallbackType
    {
        DEBUG_EXCEPTION_CATCH_HANDLER_FOUND = 3,
        DEBUG_EXCEPTION_FIRST_CHANCE = 1,
        DEBUG_EXCEPTION_UNHANDLED = 4,
        DEBUG_EXCEPTION_USER_FIRST_CHANCE = 2
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    internal enum CorDebugExceptionUnwindCallbackType
    {
        DEBUG_EXCEPTION_INTERCEPTED = 2,
        DEBUG_EXCEPTION_UNWIND_BEGIN = 1
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    internal enum CorDebugHandleType
    {
        HANDLE_STRONG = 1,
        HANDLE_WEAK_TRACK_RESURRECTION = 2
    }

    internal enum CorDebugIntercept
    {
        INTERCEPT_ALL = 0xffff,
        INTERCEPT_CLASS_INIT = 1,
        INTERCEPT_CONTEXT_POLICY = 8,
        INTERCEPT_EXCEPTION_FILTER = 2,
        INTERCEPT_INTERCEPTION = 0x10,
        INTERCEPT_NONE = 0,
        INTERCEPT_SECURITY = 4
    }

    internal enum CorDebugInternalFrameType
    {
        STUBFRAME_NONE,
        STUBFRAME_M2U,
        STUBFRAME_U2M,
        STUBFRAME_APPDOMAIN_TRANSITION,
        STUBFRAME_LIGHTWEIGHT_FUNCTION,
        STUBFRAME_FUNC_EVAL,
        STUBFRAME_INTERNALCALL,
        STUBFRAME_CLASS_INIT,
        STUBFRAME_EXCEPTION,
        STUBFRAME_SECURITY,
        STUBFRAME_JIT_COMPILATION
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    public enum CorDebugMappingResult
    {
        MAPPING_APPROXIMATE = 0x20,
        MAPPING_EPILOG = 2,
        MAPPING_EXACT = 0x10,
        MAPPING_NO_INFO = 4,
        MAPPING_PROLOG = 1,
        MAPPING_UNMAPPED_ADDRESS = 8
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    internal enum CorDebugMDAFlags
    {
        MDA_FLAG_SLIP = 2
    }

    internal enum CorDebugRegister
    {
        REGISTER_AMD64_R10 = 11,
        REGISTER_AMD64_R11 = 12,
        REGISTER_AMD64_R12 = 13,
        REGISTER_AMD64_R13 = 14,
        REGISTER_AMD64_R14 = 15,
        REGISTER_AMD64_R15 = 0x10,
        REGISTER_AMD64_R8 = 9,
        REGISTER_AMD64_R9 = 10,
        REGISTER_AMD64_RAX = 3,
        REGISTER_AMD64_RBP = 2,
        REGISTER_AMD64_RBX = 6,
        REGISTER_AMD64_RCX = 4,
        REGISTER_AMD64_RDI = 8,
        REGISTER_AMD64_RDX = 5,
        REGISTER_AMD64_RIP = 0,
        REGISTER_AMD64_RSI = 7,
        REGISTER_AMD64_RSP = 1,
        REGISTER_AMD64_XMM0 = 0x11,
        REGISTER_AMD64_XMM1 = 0x12,
        REGISTER_AMD64_XMM10 = 0x1b,
        REGISTER_AMD64_XMM11 = 0x1c,
        REGISTER_AMD64_XMM12 = 0x1d,
        REGISTER_AMD64_XMM13 = 30,
        REGISTER_AMD64_XMM14 = 0x1f,
        REGISTER_AMD64_XMM15 = 0x20,
        REGISTER_AMD64_XMM2 = 0x13,
        REGISTER_AMD64_XMM3 = 20,
        REGISTER_AMD64_XMM4 = 0x15,
        REGISTER_AMD64_XMM5 = 0x16,
        REGISTER_AMD64_XMM6 = 0x17,
        REGISTER_AMD64_XMM7 = 0x18,
        REGISTER_AMD64_XMM8 = 0x19,
        REGISTER_AMD64_XMM9 = 0x1a,
        REGISTER_FRAME_POINTER = 2,
        REGISTER_IA64_BSP = 2,
        REGISTER_IA64_F0 = 0x83,
        REGISTER_IA64_R0 = 3,
        REGISTER_INSTRUCTION_POINTER = 0,
        REGISTER_STACK_POINTER = 1,
        REGISTER_X86_EAX = 3,
        REGISTER_X86_EBP = 2,
        REGISTER_X86_EBX = 6,
        REGISTER_X86_ECX = 4,
        REGISTER_X86_EDI = 8,
        REGISTER_X86_EDX = 5,
        REGISTER_X86_EIP = 0,
        REGISTER_X86_ESI = 7,
        REGISTER_X86_ESP = 1,
        REGISTER_X86_FPSTACK_0 = 9,
        REGISTER_X86_FPSTACK_1 = 10,
        REGISTER_X86_FPSTACK_2 = 11,
        REGISTER_X86_FPSTACK_3 = 12,
        REGISTER_X86_FPSTACK_4 = 13,
        REGISTER_X86_FPSTACK_5 = 14,
        REGISTER_X86_FPSTACK_6 = 15,
        REGISTER_X86_FPSTACK_7 = 0x10
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    internal enum CorDebugSetContextFlag
    {
        SET_CONTEXT_FLAG_ACTIVE_FRAME = 1,
        SET_CONTEXT_FLAG_UNWIND_FRAME = 2
    }

    internal enum CorDebugStepReason
    {
        STEP_NORMAL,
        STEP_RETURN,
        STEP_CALL,
        STEP_EXCEPTION_FILTER,
        STEP_EXCEPTION_HANDLER,
        STEP_INTERCEPT,
        STEP_EXIT
    }

    internal enum CorDebugThreadState
    {
        THREAD_RUN,
        THREAD_SUSPEND
    }

    internal enum CorDebugUnmappedStop
    {
        STOP_ALL = 0xffff,
        STOP_EPILOG = 2,
        STOP_NO_MAPPING_INFO = 4,
        STOP_NONE = 0,
        STOP_OTHER_UNMAPPED = 8,
        STOP_PROLOG = 1,
        STOP_UNMANAGED = 0x10
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    internal enum CorDebugUserState
    {
        USER_BACKGROUND = 4,
        USER_STOP_REQUESTED = 1,
        USER_STOPPED = 0x10,
        USER_SUSPEND_REQUESTED = 2,
        USER_SUSPENDED = 0x40,
        USER_UNSAFE_POINT = 0x80,
        USER_UNSTARTED = 8,
        USER_WAIT_SLEEP_JOIN = 0x20
    }

    [ComImport, Guid("3D6F5F61-7538-11D3-8D5B-00104B35E7EF"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebug
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Initialize();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Terminate();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetManagedHandler([In, MarshalAs(UnmanagedType.Interface)] ICorDebugManagedCallback pCallback);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetUnmanagedHandler([In, MarshalAs(UnmanagedType.Interface)] ICorDebugUnmanagedCallback pCallback);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateProcess([In, MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, [In, MarshalAs(UnmanagedType.LPWStr)] string lpCommandLine, [In] SECURITY_ATTRIBUTES lpProcessAttributes, [In] SECURITY_ATTRIBUTES lpThreadAttributes, [In] int bInheritHandles, [In] uint dwCreationFlags, [In] IntPtr lpEnvironment, [In, MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, [In] STARTUPINFO pStartupInfo, [In] PROCESS_INFORMATION pProcessInformation, [In] CorDebugCreateProcessFlags debuggingFlags, [MarshalAs(UnmanagedType.Interface)] out ICorDebugProcess ppProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void DebugActiveProcess([In] uint id, [In] int win32Attach, [MarshalAs(UnmanagedType.Interface)] out ICorDebugProcess ppProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateProcesses([MarshalAs(UnmanagedType.Interface)] out ICorDebugProcessEnum ppProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetProcess([In] uint dwProcessId, [MarshalAs(UnmanagedType.Interface)] out ICorDebugProcess ppProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CanLaunchOrAttach([In] uint dwProcessId, [In] int win32DebuggingEnabled);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("3D6F5F63-7538-11D3-8D5B-00104B35E7EF")]
    internal interface ICorDebugAppDomain : ICorDebugController
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Stop([In] uint dwTimeoutIgnored);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Continue([In] int fIsOutOfBand);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsRunning(out int pbRunning);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void HasQueuedCallbacks([In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, out int pbQueued);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void EnumerateThreads([MarshalAs(UnmanagedType.Interface)] out ICorDebugThreadEnum ppThreads);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void SetAllThreadsDebugState([In] CorDebugThreadState state, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pExceptThisThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Detach();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Terminate([In] uint exitCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CanCommitChanges([In] uint cSnapshots, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugEditAndContinueSnapshot pSnapshots, [MarshalAs(UnmanagedType.Interface)] out ICorDebugErrorInfoEnum pError);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CommitChanges([In] uint cSnapshots, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugEditAndContinueSnapshot pSnapshots, [MarshalAs(UnmanagedType.Interface)] out ICorDebugErrorInfoEnum pError);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetProcess([MarshalAs(UnmanagedType.Interface)] out ICorDebugProcess ppProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateAssemblies([MarshalAs(UnmanagedType.Interface)] out ICorDebugAssemblyEnum ppAssemblies);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetModuleFromMetaDataInterface([In, MarshalAs(UnmanagedType.IUnknown)] object pIMetaData, [MarshalAs(UnmanagedType.Interface)] out ICorDebugModule ppModule);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateBreakpoints([MarshalAs(UnmanagedType.Interface)] out ICorDebugBreakpointEnum ppBreakpoints);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateSteppers([MarshalAs(UnmanagedType.Interface)] out ICorDebugStepperEnum ppSteppers);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsAttached(out int pbAttached);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetName([In] uint cchName, out uint pcchName, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain szName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetObject([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppObject);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Attach();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetID(out uint pId);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("096E81D5-ECDA-4202-83F5-C65980A9EF75")]
    internal interface ICorDebugAppDomain2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetArrayOrPointerType([In] uint elementType, [In] uint nRank, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugType pTypeArg, [MarshalAs(UnmanagedType.Interface)] out ICorDebugType ppType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunctionPointerType([In] uint nTypeArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugType ppTypeArgs, [MarshalAs(UnmanagedType.Interface)] out ICorDebugType ppType);
    }

    [ComImport, Guid("63CA1B24-4359-4883-BD57-13F815F58744"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugAppDomainEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomainEnum values, out uint pceltFetched);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0405B0DF-A660-11D2-BD02-0000F80849BD")]
    internal interface ICorDebugArrayValue : ICorDebugHeapValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsValid(out int pbValid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateRelocBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetElementType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRank(out uint pnRank);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCount(out uint pnCount);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDimensions([In] uint cdim, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugArrayValue dims);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void HasBaseIndicies(out int pbHasBaseIndicies);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetBaseIndicies([In] uint cdim, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugArrayValue indicies);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetElement([In] uint cdim, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugArrayValue indices, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetElementAtPosition([In] uint nPosition, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
    }

    [ComImport, Guid("DF59507C-D47A-459E-BCE2-6427EAC8FD06"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugAssembly
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetProcess([MarshalAs(UnmanagedType.Interface)] out ICorDebugProcess ppProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAppDomain([MarshalAs(UnmanagedType.Interface)] out ICorDebugAppDomain ppAppDomain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateModules([MarshalAs(UnmanagedType.Interface)] out ICorDebugModuleEnum ppModules);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCodeBase([In] uint cchName, out uint pcchName, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugAssembly szName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetName([In] uint cchName, out uint pcchName, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugAssembly szName);
    }

    [ComImport, Guid("426D1F9E-6DD4-44C8-AEC7-26CDBAF4E398"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugAssembly2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsFullyTrusted(out int pbFullyTrusted);
    }

    [ComImport, Guid("4A2A1EC9-85EC-4BFB-9F15-A89FDFE0FE83"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugAssemblyEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugAssemblyEnum values, out uint pceltFetched);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAFC-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugBoxValue : ICorDebugHeapValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsValid(out int pbValid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateRelocBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetObject([MarshalAs(UnmanagedType.Interface)] out ICorDebugObjectValue ppObject);
    }

    [ComImport, Guid("CC7BCAE8-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugBreakpoint
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Activate([In] int bActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsActive(out int pbActive);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCB03-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugBreakpointEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugBreakpointEnum breakpoints, out uint pceltFetched);
    }

    [ComImport, Guid("CC7BCAEE-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugChain
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetThread([MarshalAs(UnmanagedType.Interface)] out ICorDebugThread ppThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStackRange(out ulong pStart, out ulong pEnd);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetContext([MarshalAs(UnmanagedType.Interface)] out ICorDebugContext ppContext);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCaller([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCallee([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetPrevious([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetNext([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsManaged(out int pManaged);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateFrames([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrameEnum ppFrames);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetActiveFrame([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRegisterSet([MarshalAs(UnmanagedType.Interface)] out ICorDebugRegisterSet ppRegisters);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetReason(out CorDebugChainReason pReason);
    }

    [ComImport, Guid("CC7BCB08-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugChainEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugChainEnum chains, out uint pceltFetched);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAF5-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugClass
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetModule([MarshalAs(UnmanagedType.Interface)] out ICorDebugModule pModule);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetToken(out uint pTypeDef);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStaticFieldValue([In] uint fieldDef, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugFrame pFrame, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
    }

    [ComImport, Guid("B008EA8D-7AB1-43F7-BB20-FBB5A04038AE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugClass2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetParameterizedType([In] uint elementType, [In] uint nTypeArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugType ppTypeArgs, [MarshalAs(UnmanagedType.Interface)] out ICorDebugType ppType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetJMCStatus([In] int bIsJustMyCode);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAF4-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugCode
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsIL(out int pbIL);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunction([MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAddress(out ulong pStart);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSize(out uint pcBytes);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateBreakpoint([In] uint offset, [MarshalAs(UnmanagedType.Interface)] out ICorDebugFunctionBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCode([In] uint startOffset, [In] uint endOffset, [In] uint cBufferAlloc, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugCode buffer, out uint pcBufferSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetVersionNumber(out uint nVersion);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetILToNativeMapping([In] uint cMap, out uint pcMap, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugCode map);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetEnCRemapSequencePoints([In] uint cMap, out uint pcMap, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugCode offsets);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("55E96461-9645-45E4-A2FF-0367877ABCDE")]
    internal interface ICorDebugCodeEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugCodeEnum values, out uint pceltFetched);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCB00-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugContext : ICorDebugObjectValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetClass([MarshalAs(UnmanagedType.Interface)] out ICorDebugClass ppClass);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFieldValue([In, MarshalAs(UnmanagedType.Interface)] ICorDebugClass pClass, [In] uint fieldDef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetVirtualMethod([In] uint memberRef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetContext([MarshalAs(UnmanagedType.Interface)] out ICorDebugContext ppContext);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsValueClass(out int pbIsValueClass);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetManagedCopy([MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void SetFromManagedCopy([In, MarshalAs(UnmanagedType.IUnknown)] object pObject);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("3D6F5F62-7538-11D3-8D5B-00104B35E7EF")]
    internal interface ICorDebugController
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Stop([In] uint dwTimeoutIgnored);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Continue([In] int fIsOutOfBand);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsRunning(out int pbRunning);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void HasQueuedCallbacks([In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, out int pbQueued);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateThreads([MarshalAs(UnmanagedType.Interface)] out ICorDebugThreadEnum ppThreads);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetAllThreadsDebugState([In] CorDebugThreadState state, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pExceptThisThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Detach();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Terminate([In] uint exitCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CanCommitChanges([In] uint cSnapshots, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugEditAndContinueSnapshot pSnapshots, [MarshalAs(UnmanagedType.Interface)] out ICorDebugErrorInfoEnum pError);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CommitChanges([In] uint cSnapshots, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugEditAndContinueSnapshot pSnapshots, [MarshalAs(UnmanagedType.Interface)] out ICorDebugErrorInfoEnum pError);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("6DC3FA01-D7CB-11D2-8A95-0080C792E5D8")]
    internal interface ICorDebugEditAndContinueSnapshot
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CopyMetaData([In, MarshalAs(UnmanagedType.Interface)] IStream pIStream, out Guid pMvid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetMvid(out Guid pMvid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRoDataRVA(out uint pRoDataRVA);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRwDataRVA(out uint pRwDataRVA);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetPEBytes([In, MarshalAs(UnmanagedType.Interface)] IStream pIStream);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetILMap([In] uint mdFunction, [In] uint cMapSize, [In] ref COR_IL_MAP map);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetPESymbolBytes([In, MarshalAs(UnmanagedType.Interface)] IStream pIStream);
    }

    [ComImport, Guid("CC7BCB01-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCount(out uint pcelt);
    }

    [ComImport, Guid("F0E18809-72B5-11D2-976F-00A0C9B4D50C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugErrorInfoEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugErrorInfoEnum errors, out uint pceltFetched);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAF6-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugEval
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CallFunction([In, MarshalAs(UnmanagedType.Interface)] ICorDebugFunction pFunction, [In] uint nArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugValue ppArgs);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NewObject([In, MarshalAs(UnmanagedType.Interface)] ICorDebugFunction pConstructor, [In] uint nArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugValue ppArgs);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NewObjectNoConstructor([In, MarshalAs(UnmanagedType.Interface)] ICorDebugClass pClass);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NewString([In, MarshalAs(UnmanagedType.LPWStr)] string @string);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NewArray([In] uint elementType, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugClass pElementClass, [In] uint rank, [In] ref uint dims, [In] ref uint lowBounds);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsActive(out int pbActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Abort();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetResult([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppResult);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetThread([MarshalAs(UnmanagedType.Interface)] out ICorDebugThread ppThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateValue([In] uint elementType, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugClass pElementClass, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("FB0D9CE7-BE66-4683-9D32-A42A04E2FD91")]
    internal interface ICorDebugEval2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CallParameterizedFunction([In, MarshalAs(UnmanagedType.Interface)] ICorDebugFunction pFunction, [In] uint nTypeArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugType ppTypeArgs, [In] uint nArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugValue ppArgs);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateValueForType([In, MarshalAs(UnmanagedType.Interface)] ICorDebugType pType, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NewParameterizedObject([In, MarshalAs(UnmanagedType.Interface)] ICorDebugFunction pConstructor, [In] uint nTypeArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugType ppTypeArgs, [In] uint nArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugValue ppArgs);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NewParameterizedObjectNoConstructor([In, MarshalAs(UnmanagedType.Interface)] ICorDebugClass pClass, [In] uint nTypeArgs, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugType ppTypeArgs);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NewParameterizedArray([In, MarshalAs(UnmanagedType.Interface)] ICorDebugType pElementType, [In] uint rank, [In] ref uint dims, [In] ref uint lowBounds);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NewStringWithLength([In, MarshalAs(UnmanagedType.LPWStr)] string @string, [In] uint uiLength);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RudeAbort();
    }

    [ComImport, Guid("CC7BCAEF-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugFrame
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetChain([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCode([MarshalAs(UnmanagedType.Interface)] out ICorDebugCode ppCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunction([MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunctionToken(out uint pToken);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStackRange(out ulong pStart, out ulong pEnd);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCaller([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCallee([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateStepper([MarshalAs(UnmanagedType.Interface)] out ICorDebugStepper ppStepper);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCB07-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugFrameEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugFrameEnum frames, out uint pceltFetched);
    }

    [ComImport, Guid("CC7BCAF3-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugFunction
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetModule([MarshalAs(UnmanagedType.Interface)] out ICorDebugModule ppModule);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetClass([MarshalAs(UnmanagedType.Interface)] out ICorDebugClass ppClass);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetToken(out uint pMethodDef);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetILCode([MarshalAs(UnmanagedType.Interface)] out ICorDebugCode ppCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetNativeCode([MarshalAs(UnmanagedType.Interface)] out ICorDebugCode ppCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugFunctionBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetLocalVarSigToken(out uint pmdSig);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCurrentVersionNumber(out uint pnCurrentVersion);
    }

    [ComImport, Guid("EF0C490B-94C3-4E4D-B629-DDC134C532D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugFunction2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetJMCStatus([In] int bIsJustMyCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetJMCStatus(out int pbIsJustMyCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateNativeCode([MarshalAs(UnmanagedType.Interface)] out ICorDebugCodeEnum ppCodeEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetVersionNumber(out uint pnVersion);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAE9-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugFunctionBreakpoint : ICorDebugBreakpoint
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Activate([In] int bActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsActive(out int pbActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunction([MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetOffset(out uint pnOffset);
    }

    [ComImport, Guid("CC7BCAF8-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugGenericValue : ICorDebugValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetValue([Out] IntPtr pTo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetValue([In] IntPtr pFrom);
    }

    [ComImport, Guid("029596E8-276B-46A1-9821-732E96BBB00B"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugHandleValue : ICorDebugReferenceValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsNull(out int pbNull);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetValue(out ulong pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void SetValue([In] ulong value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Dereference([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void DereferenceStrong([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetHandleType(out CorDebugHandleType pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Dispose();
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAFA-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugHeapValue : ICorDebugValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsValid(out int pbValid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateRelocBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
    }

    [ComImport, Guid("E3AC4D6C-9CB7-43E6-96CC-B21540E5083C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugHeapValue2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateHandle([In] CorDebugHandleType type, [MarshalAs(UnmanagedType.Interface)] out ICorDebugHandleValue ppHandle);
    }

    [ComImport, Guid("03E26311-4F76-11D3-88C6-006097945418"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugILFrame : ICorDebugFrame
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetChain([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCode([MarshalAs(UnmanagedType.Interface)] out ICorDebugCode ppCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFunction([MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFunctionToken(out uint pToken);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetStackRange(out ulong pStart, out ulong pEnd);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCaller([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCallee([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateStepper([MarshalAs(UnmanagedType.Interface)] out ICorDebugStepper ppStepper);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetIP(out uint pnOffset, out CorDebugMappingResult pMappingResult);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetIP([In] uint nOffset);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateLocalVariables([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueEnum ppValueEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetLocalVariable([In] uint dwIndex, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateArguments([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueEnum ppValueEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetArgument([In] uint dwIndex, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStackDepth(out uint pDepth);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStackValue([In] uint dwIndex, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CanSetIP([In] uint nOffset);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5D88A994-6C30-479B-890F-BCEF88B129A5")]
    internal interface ICorDebugILFrame2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemapFunction([In] uint newILOffset);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateTypeParameters([MarshalAs(UnmanagedType.Interface)] out ICorDebugTypeEnum ppTyParEnum);
    }

    [ComImport, Guid("B92CC7F7-9D2D-45C4-BC2B-621FCC9DFBF4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugInternalFrame : ICorDebugFrame
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetChain([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCode([MarshalAs(UnmanagedType.Interface)] out ICorDebugCode ppCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFunction([MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFunctionToken(out uint pToken);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetStackRange(out ulong pStart, out ulong pEnd);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCaller([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCallee([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateStepper([MarshalAs(UnmanagedType.Interface)] out ICorDebugStepper ppStepper);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFrameType(out CorDebugInternalFrameType pType);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("C0815BDC-CFAB-447E-A779-C116B454EB5B")]
    internal interface ICorDebugInternalFrame2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsCloserToLeaf([In, MarshalAs(UnmanagedType.Interface)] ICorDebugFrame pFrameToCompare, out int pIsCloser);
    }

    [ComImport, Guid("3D6F5F60-7538-11D3-8D5B-00104B35E7EF"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugManagedCallback
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Breakpoint([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugBreakpoint pBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void StepComplete([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugStepper pStepper, [In] CorDebugStepReason reason);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Break([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread thread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Exception([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In] int unhandled);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EvalComplete([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugEval pEval);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EvalException([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugEval pEval);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateProcess([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ExitProcess([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateThread([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread thread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ExitThread([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread thread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void LoadModule([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugModule pModule);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void UnloadModule([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugModule pModule);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void LoadClass([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugClass c);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void UnloadClass([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugClass c);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void DebuggerError([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess, [In, MarshalAs(UnmanagedType.Error)] int errorHR, [In] uint errorCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void LogMessage([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In] int lLevel, [In, MarshalAs(UnmanagedType.LPWStr)] string pLogSwitchName, [In, MarshalAs(UnmanagedType.LPWStr)] string pMessage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void LogSwitch([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In] int lLevel, [In] uint ulReason, [In, MarshalAs(UnmanagedType.LPWStr)] string pLogSwitchName, [In, MarshalAs(UnmanagedType.LPWStr)] string pParentName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateAppDomain([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ExitAppDomain([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void LoadAssembly([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugAssembly pAssembly);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void UnloadAssembly([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugAssembly pAssembly);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ControlCTrap([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NameChange([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void UpdateModuleSymbols([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugModule pModule, [In, MarshalAs(UnmanagedType.Interface)] System.Runtime.InteropServices.ComTypes.IStream pSymbolStream);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EditAndContinueRemap([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugFunction pFunction, [In] int fAccurate);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void BreakpointSetError([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugBreakpoint pBreakpoint, [In] uint dwError);
    }

    [ComImport, Guid("250E5EEA-DB5C-4C76-B6F3-8C46F12E3203"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugManagedCallback2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void FunctionRemapOpportunity([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugFunction pOldFunction, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugFunction pNewFunction, [In] uint oldILOffset);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateConnection([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess, [In] uint dwConnectionId, [In] ref ushort pConnName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ChangeConnection([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess, [In] uint dwConnectionId);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void DestroyConnection([In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess pProcess, [In] uint dwConnectionId);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Exception([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugFrame pFrame, [In] uint nOffset, [In] CorDebugExceptionCallbackType dwEventType, [In] uint dwFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ExceptionUnwind([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In] CorDebugExceptionUnwindCallbackType dwEventType, [In] uint dwFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void FunctionRemapComplete([In, MarshalAs(UnmanagedType.Interface)] ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugFunction pFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void MDANotification([In, MarshalAs(UnmanagedType.Interface)] ICorDebugController pController, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugMDA pMDA);
    }

    [ComImport, Guid("CC726F2F-1DB7-459B-B0EC-05F01D841B42"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugMDA
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetName([In] uint cchName, out uint pcchName, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugMDA szName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDescription([In] uint cchName, out uint pcchName, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugMDA szName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetXML([In] uint cchName, out uint pcchName, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugMDA szName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFlags([In] ref CorDebugMDAFlags pFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetOSThreadId(out uint pOsTid);
    }

    [ComImport, Guid("DBA2D8C1-E5C5-4069-8C13-10A7C6ABF43D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugModule
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetProcess([MarshalAs(UnmanagedType.Interface)] out ICorDebugProcess ppProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetBaseAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAssembly([MarshalAs(UnmanagedType.Interface)] out ICorDebugAssembly ppAssembly);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetName([In] uint cchName, out uint pcchName, [MarshalAs(UnmanagedType.LPArray)] char[] szName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnableJITDebugging([In] int bTrackJITInfo, [In] int bAllowJitOpts);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnableClassLoadCallbacks([In] int bClassLoadCallbacks);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunctionFromToken([In] uint methodDef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunctionFromRVA([In] ulong rva, [MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetClassFromToken([In] uint typeDef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugClass ppClass);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugModuleBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetEditAndContinueSnapshot([MarshalAs(UnmanagedType.Interface)] out ICorDebugEditAndContinueSnapshot ppEditAndContinueSnapshot);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetMetaDataInterface([In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppObj);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetToken(out uint pToken);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsDynamic(out int pDynamic);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetGlobalVariableValue([In] uint fieldDef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSize(out uint pcBytes);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsInMemory(out int pInMemory);
    }

    [ComImport, Guid("7FCC5FB5-49C0-41DE-9938-3B88B5B9ADD7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugModule2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetJMCStatus([In] int bIsJustMyCode, [In] uint cTokens, [In] ref uint pTokens);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ApplyChanges([In] uint cbMetadata, [In] ref byte pbMetadata, [In] uint cbIL, [In] ref byte pbIL);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetJITCompilerFlags([In] uint dwFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetJITCompilerFlags(out uint pdwFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ResolveAssembly([In] uint tkAssemblyRef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugAssembly ppAssembly);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("86F012BF-FF15-4372-BD30-B6F11CAAE1DD")]
    internal interface ICorDebugModule3
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateReaderForInMemorySymbols([In] ref Guid riid, out IntPtr ppObj);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAEA-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugModuleBreakpoint : ICorDebugBreakpoint
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Activate([In] int bActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsActive(out int pbActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetModule([MarshalAs(UnmanagedType.Interface)] out ICorDebugModule ppModule);
    }

    [ComImport, Guid("CC7BCB09-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugModuleEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugModuleEnum modules, out uint pceltFetched);
    }

    [ComImport, Guid("03E26314-4F76-11D3-88C6-006097945418"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugNativeFrame : ICorDebugFrame
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetChain([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCode([MarshalAs(UnmanagedType.Interface)] out ICorDebugCode ppCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFunction([MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFunctionToken(out uint pToken);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetStackRange(out ulong pStart, out ulong pEnd);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCaller([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCallee([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateStepper([MarshalAs(UnmanagedType.Interface)] out ICorDebugStepper ppStepper);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetIP(out uint pnOffset);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetIP([In] uint nOffset);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRegisterSet([MarshalAs(UnmanagedType.Interface)] out ICorDebugRegisterSet ppRegisters);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetLocalRegisterValue([In] CorDebugRegister reg, [In] uint cbSigBlob, [In, ComAliasName("CORDBLib.ULONG_PTR")] ulong pvSigBlob, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetLocalDoubleRegisterValue([In] CorDebugRegister highWordReg, [In] CorDebugRegister lowWordReg, [In] uint cbSigBlob, [In, ComAliasName("CORDBLib.ULONG_PTR")] ulong pvSigBlob, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetLocalMemoryValue([In] ulong address, [In] uint cbSigBlob, [In, ComAliasName("CORDBLib.ULONG_PTR")] ulong pvSigBlob, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetLocalRegisterMemoryValue([In] CorDebugRegister highWordReg, [In] ulong lowWordAddress, [In] uint cbSigBlob, [In, ComAliasName("CORDBLib.ULONG_PTR")] ulong pvSigBlob, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetLocalMemoryRegisterValue([In] ulong highWordAddress, [In] CorDebugRegister lowWordRegister, [In] uint cbSigBlob, [In, ComAliasName("CORDBLib.ULONG_PTR")] ulong pvSigBlob, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CanSetIP([In] uint nOffset);
    }

    [ComImport, Guid("35389FF1-3684-4C55-A2EE-210F26C60E5E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugNativeFrame2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsChild(out int pIsChild);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsMatchingParentFrame([In, MarshalAs(UnmanagedType.Interface)] ICorDebugNativeFrame2 pPotentialParentFrame, out int pIsParent);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStackParameterSize(out uint pSize);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCB02-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugObjectEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugObjectEnum objects, out uint pceltFetched);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("18AD3D6E-B7D2-11D2-BD04-0000F80849BD")]
    internal interface ICorDebugObjectValue : ICorDebugValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetClass([MarshalAs(UnmanagedType.Interface)] out ICorDebugClass ppClass);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFieldValue([In, MarshalAs(UnmanagedType.Interface)] ICorDebugClass pClass, [In] uint fieldDef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetVirtualMethod([In] uint memberRef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetContext([MarshalAs(UnmanagedType.Interface)] out ICorDebugContext ppContext);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsValueClass(out int pbIsValueClass);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetManagedCopy([MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetFromManagedCopy([In, MarshalAs(UnmanagedType.IUnknown)] object pObject);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("49E4A320-4A9B-4ECA-B105-229FB7D5009F")]
    internal interface ICorDebugObjectValue2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetVirtualMethodAndType([In] uint memberRef, [MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction, [MarshalAs(UnmanagedType.Interface)] out ICorDebugType ppType);
    }

    [ComImport, Guid("3D6F5F64-7538-11D3-8D5B-00104B35E7EF"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugProcess : ICorDebugController
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Stop([In] uint dwTimeoutIgnored);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Continue([In] int fIsOutOfBand);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsRunning(out int pbRunning);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void HasQueuedCallbacks([In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pThread, out int pbQueued);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void EnumerateThreads([MarshalAs(UnmanagedType.Interface)] out ICorDebugThreadEnum ppThreads);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void SetAllThreadsDebugState([In] CorDebugThreadState state, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugThread pExceptThisThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Detach();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Terminate([In] uint exitCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CanCommitChanges([In] uint cSnapshots, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugEditAndContinueSnapshot pSnapshots, [MarshalAs(UnmanagedType.Interface)] out ICorDebugErrorInfoEnum pError);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CommitChanges([In] uint cSnapshots, [In, MarshalAs(UnmanagedType.Interface)] ref ICorDebugEditAndContinueSnapshot pSnapshots, [MarshalAs(UnmanagedType.Interface)] out ICorDebugErrorInfoEnum pError);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetID(out uint pdwProcessId);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetHandle([ComAliasName("CORDBLib.long")] out uint phProcessHandle);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetThread([In] uint dwThreadId, [MarshalAs(UnmanagedType.Interface)] out ICorDebugThread ppThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateObjects([MarshalAs(UnmanagedType.Interface)] out ICorDebugObjectEnum ppObjects);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsTransitionStub([In] ulong address, out int pbTransitionStub);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsOSSuspended([In] uint threadID, out int pbSuspended);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetThreadContext([In] uint threadID, [In] uint contextSize, [In, Out, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess context);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetThreadContext([In] uint threadID, [In] uint contextSize, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess context);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ReadMemory([In] ulong address, [In] uint size, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess buffer, [ComAliasName("CORDBLib.ULONG_PTR")] out ulong read);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void WriteMemory([In] ulong address, [In] uint size, [In] ref byte buffer, [ComAliasName("CORDBLib.ULONG_PTR")] out ulong written);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ClearCurrentException([In] uint threadID);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnableLogMessages([In] int fOnOff);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ModifyLogSwitch([In] ref ushort pLogSwitchName, [In] int lLevel);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateAppDomains([MarshalAs(UnmanagedType.Interface)] out ICorDebugAppDomainEnum ppAppDomains);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetObject([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppObject);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ThreadForFiberCookie([In] uint fiberCookie, [MarshalAs(UnmanagedType.Interface)] out ICorDebugThread ppThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetHelperThreadID(out uint pThreadID);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AD1B3588-0EF0-4744-A496-AA09A9F80371")]
    internal interface ICorDebugProcess2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetThreadForTaskID([In] ulong taskid, [MarshalAs(UnmanagedType.Interface)] out ICorDebugThread2 ppThread);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetVersion(out COR_VERSION version);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetUnmanagedBreakpoint([In] ulong address, [In] uint bufsize, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugProcess2 buffer, out uint bufLen);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ClearUnmanagedBreakpoint([In] ulong address);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetDesiredNGENCompilerFlags([In] uint pdwFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDesiredNGENCompilerFlags(out uint pdwFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetReferenceValueFromGCHandle([In, ComAliasName("CORDBLib.UINT_PTR")] ulong handle, [MarshalAs(UnmanagedType.Interface)] out ICorDebugReferenceValue pOutValue);
    }

    [ComImport, Guid("CC7BCB05-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugProcessEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugProcessEnum processes, out uint pceltFetched);
    }

    [ComImport, Guid("CC7BCAF9-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugReferenceValue : ICorDebugValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsNull(out int pbNull);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetValue(out ulong pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetValue([In] ulong value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Dereference([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void DereferenceStrong([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCB0B-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugRegisterSet
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRegistersAvailable(out ulong pAvailable);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRegisters([In] ulong mask, [In] uint regCount, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugRegisterSet regBuffer);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetRegisters([In] ulong mask, [In] uint regCount, [In] ref ulong regBuffer);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetThreadContext([In] uint contextSize, [In, Out, MarshalAs(UnmanagedType.Interface)] ICorDebugRegisterSet context);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetThreadContext([In] uint contextSize, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugRegisterSet context);
    }

    [ComImport, Guid("879CAC0A-4A53-4668-B8E3-CB8473CB187F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugRuntimeUnwindableFrame : ICorDebugFrame
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetChain([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCode([MarshalAs(UnmanagedType.Interface)] out ICorDebugCode ppCode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFunction([MarshalAs(UnmanagedType.Interface)] out ICorDebugFunction ppFunction);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetFunctionToken(out uint pToken);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetStackRange(out ulong pStart, out ulong pEnd);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCaller([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCallee([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateStepper([MarshalAs(UnmanagedType.Interface)] out ICorDebugStepper ppStepper);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("A0647DE9-55DE-4816-929C-385271C64CF7")]
    internal interface ICorDebugStackWalk
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetContext([In] uint contextFlags, [In] uint contextBufSize, out uint contextSize, out byte contextBuf);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetContext([In] CorDebugSetContextFlag flag, [In] uint contextSize, [In] ref byte context);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFrame([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame pFrame);
    }

    [ComImport, Guid("CC7BCAEC-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugStepper
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void IsActive(out int pbActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Deactivate();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetInterceptMask([In] CorDebugIntercept mask);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetUnmappedStopMask([In] CorDebugUnmappedStop mask);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Step([In] int bStepIn);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void StepRange([In] int bStepIn, [In] ref COR_DEBUG_STEP_RANGE ranges, [In] uint cRangeCount);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void StepOut();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetRangeIL([In] int bIL);
    }

    [ComImport, Guid("C5B6E9C3-E7D1-4A8E-873B-7F047F0706F7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugStepper2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetJMC([In] int fIsJMCStepper);
    }

    [ComImport, Guid("CC7BCB04-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugStepperEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugStepperEnum steppers, out uint pceltFetched);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAFD-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugStringValue : ICorDebugHeapValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsValid(out int pbValid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateRelocBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetLength(out uint pcchString);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetString([In] uint cchString, out uint pcchString, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugStringValue szString);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("938C6D66-7FB6-4F69-B389-425B8987329B")]
    internal interface ICorDebugThread
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetProcess([MarshalAs(UnmanagedType.Interface)] out ICorDebugProcess ppProcess);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetID(out uint pdwThreadId);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetHandle([ComAliasName("CORDBLib.long")] out uint phThreadHandle);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAppDomain([MarshalAs(UnmanagedType.Interface)] out ICorDebugAppDomain ppAppDomain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetDebugState([In] CorDebugThreadState state);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDebugState(out CorDebugThreadState pState);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetUserState(out CorDebugUserState pState);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCurrentException([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppExceptionObject);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ClearCurrentException();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateStepper([MarshalAs(UnmanagedType.Interface)] out ICorDebugStepper ppStepper);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateChains([MarshalAs(UnmanagedType.Interface)] out ICorDebugChainEnum ppChains);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetActiveChain([MarshalAs(UnmanagedType.Interface)] out ICorDebugChain ppChain);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetActiveFrame([MarshalAs(UnmanagedType.Interface)] out ICorDebugFrame ppFrame);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRegisterSet([MarshalAs(UnmanagedType.Interface)] out ICorDebugRegisterSet ppRegisters);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateEval([MarshalAs(UnmanagedType.Interface)] out ICorDebugEval ppEval);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetObject([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppObject);
    }

    [ComImport, Guid("2BD956D9-7B07-4BEF-8A98-12AA862417C5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugThread2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetActiveFunctions([In] uint cFunctions, out uint pcFunctions, [In, Out, MarshalAs(UnmanagedType.Interface)] ICorDebugThread2 pFunctions);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetConnectionID(out uint pdwConnectionId);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetTaskID(out ulong pTaskId);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetVolatileOSThreadID(out uint pdwTid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void InterceptCurrentException([In, MarshalAs(UnmanagedType.Interface)] ICorDebugFrame pFrame);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("F8544EC3-5E4E-46C7-8D3E-A52B8405B1F5")]
    internal interface ICorDebugThread3
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateStackWalk([MarshalAs(UnmanagedType.Interface)] out ICorDebugStackWalk ppStackWalk);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetActiveInternalFrames([In] uint cInternalFrames, out uint pcInternalFrames, [In, Out, MarshalAs(UnmanagedType.Interface)] ICorDebugThread3 ppInternalFrames);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCB06-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugThreadEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugThreadEnum threads, out uint pceltFetched);
    }

    [ComImport, Guid("D613F0BB-ACE1-4C19-BD72-E4C08D5DA7F5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugType
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetType(out uint ty);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetClass([MarshalAs(UnmanagedType.Interface)] out ICorDebugClass ppClass);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumerateTypeParameters([MarshalAs(UnmanagedType.Interface)] out ICorDebugTypeEnum ppTyParEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFirstTypeParameter([MarshalAs(UnmanagedType.Interface)] out ICorDebugType value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetBase([MarshalAs(UnmanagedType.Interface)] out ICorDebugType pBase);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStaticFieldValue([In] uint fieldDef, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugFrame pFrame, [MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRank(out uint pnRank);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("10F27499-9DF2-43CE-8333-A321D7C99CB4")]
    internal interface ICorDebugTypeEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugTypeEnum values, out uint pceltFetched);
    }

    [ComImport, Guid("5263E909-8CB5-11D3-BD2F-0000F80849BD"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugUnmanagedCallback
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void DebugEvent([In, ComAliasName("CORDBLib.ULONG_PTR")] ulong pDebugEvent, [In] int fOutOfBand);
    }

    [ComImport, Guid("CC7BCAF7-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugValue
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetType(out uint pType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSize(out uint pSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAddress(out ulong pAddress);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateBreakpoint([MarshalAs(UnmanagedType.Interface)] out ICorDebugValueBreakpoint ppBreakpoint);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5E0B54E7-D88A-4626-9420-A691E0A78B49")]
    internal interface ICorDebugValue2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetExactType([MarshalAs(UnmanagedType.Interface)] out ICorDebugType ppType);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CC7BCAEB-8A68-11D2-983C-0000F808342D")]
    internal interface ICorDebugValueBreakpoint : ICorDebugBreakpoint
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Activate([In] int bActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void IsActive(out int pbActive);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetValue([MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
    }

    [ComImport, Guid("CC7BCB0A-8A68-11D2-983C-0000F808342D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ICorDebugValueEnum : ICorDebugEnum
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Clone([MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetCount(out uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint celt, [Out, MarshalAs(UnmanagedType.Interface)] ICorDebugValueEnum values, out uint pceltFetched);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
    internal interface ISequentialStream
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoteRead(out byte pv, [In] uint cb, out uint pcbRead);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoteWrite([In] ref byte pv, [In] uint cb, out uint pcbWritten);
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    internal struct tagSTATSTG
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwcsName;
        public uint type;
        public ULARGE_INTEGER cbSize;
        public FILETIME mtime;
        public FILETIME ctime;
        public FILETIME atime;
        public uint grfMode;
        public uint grfLocksSupported;
        public Guid clsid;
        public uint grfStateBits;
        public uint reserved;
    }
}