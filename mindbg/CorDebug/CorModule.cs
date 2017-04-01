using System;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;
using Microsoft.Samples.Debugging.CorSymbolStore;
using MinDbg.NativeApi;

namespace MinDbg.CorDebug
{
    /// <summary>
    /// Represents ICorDebugModule interface.
    /// </summary>
    public sealed class CorModule : WrapperBase
    {
        private readonly ICorDebugModule comodule;
        private ISymbolReader symbolReader;
        private bool isSymbolReaderInitialized;
        
        private static ISymbolBinder1 symbolBinder;

        /// <summary>
        /// Creates new instance of the CorModule class.
        /// </summary>
        /// <param name="comodule">ICorDebugModule instance</param>
        internal CorModule(ICorDebugModule comodule, CorDebuggerOptions options)
            : base(comodule, options)
        {
            this.comodule = comodule;
        }


        /// <summary>
        /// Gets the symbol reader for a given module.
        /// </summary>
        /// <returns>A symbol reader for a given module.</returns>
        public ISymbolReader GetSymbolReader()
        {
            if (!isSymbolReaderInitialized)
            {
                isSymbolReaderInitialized = true;
                symbolReader = (GetSymbolBinder() as ISymbolBinder2).GetReaderForFile(
                                        GetMetadataInterface<IMetadataImport>(),
                                        GetName(),
                                        options.SymbolPath);
            }
            return symbolReader;
        }

        private static ISymbolBinder1 GetSymbolBinder()
        {
            if (symbolBinder == null)
            {
                symbolBinder = new SymbolBinder();
                Debug.Assert(symbolBinder != null);
            }
            return symbolBinder;
        }

        /// <summary>
        /// Gets the process that has the module loaded.
        /// </summary>
        /// <returns>The process that hosts the module.</returns>
        public CorProcess GetProcess()
        {
            ICorDebugProcess coproc;
            comodule.GetProcess(out coproc);
            return CorProcess.GetOrCreateCorProcess(coproc, options);
        }

        /// <summary>
        /// Gets the function from token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public CorFunction GetFunctionFromToken(Int32 token)
        {
            ICorDebugFunction cofunc;
            comodule.GetFunctionFromToken((UInt32)token, out cofunc);
            return new CorFunction(cofunc, options);
        }

        /// <summary>
        /// Gets the module's name.
        /// </summary>
        /// <returns></returns>
        public String GetName()
        {
            Char[] name = new Char[300];
            UInt32 fetched;
            comodule.GetName((UInt32)name.Length, out fetched, name);

            // fetched - 1 because of the ending 0
            return new String(name, 0, (Int32)fetched - 1);
        }

        /// <summary>
        /// Returns a requested metadata interface instance.
        /// </summary>
        /// <typeparam name="T">Metadata interface</typeparam>
        /// <returns>Metadata interface instance</returns>
        public T GetMetadataInterface<T>()
        {
            Object res;
            Guid guid = typeof(T).GUID;
            comodule.GetMetaDataInterface(ref guid, out res);
            return (T)res;
        }

        // Brilliantly written taken from mdbg source code.
        // returns a type token from name
        // when the function fails, we return token TokenNotFound value.
        public int GetTypeTokenFromName(string name)
        {
            IMetadataImport importer = GetMetadataInterface<IMetadataImport>();

            int token = CorConstants.TokenNotFound;
            if (name.Length == 0)
                // this is special global type (we'll return token 0)
                token = CorConstants.TokenGlobalNamespace;
            else
            {
                try
                {
                    importer.FindTypeDefByName(name, 0, out token);
                }
                catch (COMException e)
                {
                    token = CorConstants.TokenNotFound;
                    if ((HResult)e.ErrorCode == HResult.CLDB_E_RECORD_NOTFOUND)
                    {
                        int i = name.LastIndexOf('.');
                        if (i > 0)
                        {
                            int parentToken = GetTypeTokenFromName(name.Substring(0, i));
                            if (parentToken != CorConstants.TokenNotFound)
                            {
                                try
                                {
                                    importer.FindTypeDefByName(name.Substring(i + 1), parentToken, out token);
                                }
                                catch (COMException e2)
                                {
                                    token = CorConstants.TokenNotFound;
                                    if ((HResult)e2.ErrorCode != HResult.CLDB_E_RECORD_NOTFOUND)
                                        throw;
                                }
                            }
                        }
                    }
                    else
                        throw;
                }
            }
            return token;
        }

    }
}
