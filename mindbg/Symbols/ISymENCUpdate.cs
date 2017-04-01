//---------------------------------------------------------------------
//  This file is part of the CLR Managed Debugger (mdbg) Sample.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//---------------------------------------------------------------------


// These interfaces serve as an extension to the BCL's SymbolStore interfaces.
namespace Microsoft.Samples.Debugging.CorSymbolStore 
{
    using System.Diagnostics.SymbolStore;

    // Interface does not need to be marked with the serializable attribute
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.ComTypes;

    
    [StructLayout(LayoutKind.Sequential)]
    public struct SymbolLineDelta
    {
        SymbolToken mdMethod;
        int delta;
    };
    
    
    [
        ComVisible(false)
    ]
    public interface ISymbolEncUpdate
    {
        
   
        void UpdateSymbolStore(IStream stream, SymbolLineDelta[] symbolLineDeltas);
        
    
        int GetLocalVariableCount(SymbolToken mdMethodToken);
        
    
        ISymbolVariable[] GetLocalVariables(SymbolToken mdMethodToken);
    }
}
