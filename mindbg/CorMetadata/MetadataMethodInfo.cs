using System;
using System.Reflection;
using System.Text;
using MinDbg.NativeApi;

namespace MinDbg.CorMetadata
{
    internal sealed class MetadataMethodInfo : MethodInfo
    {
        private readonly Int32 p_methodToken;
        private readonly Int32 p_classToken;
        private readonly IMetadataImport p_importer;
        private readonly String p_name;

        internal MetadataMethodInfo(IMetadataImport importer, Int32 methodToken)
        {
            p_importer = importer;
            p_methodToken = methodToken;

            int size;
            uint pdwAttr;
            IntPtr ppvSigBlob;
            uint pulCodeRVA, pdwImplFlags;
            uint pcbSigBlob;

            p_importer.GetMethodProps((uint)methodToken,
                                      out p_classToken,
                                      null,
                                      0,
                                      out size,
                                      out pdwAttr,
                                      out ppvSigBlob,
                                      out pcbSigBlob,
                                      out pulCodeRVA,
                                      out pdwImplFlags);

            StringBuilder szMethodName = new StringBuilder(size);
            p_importer.GetMethodProps((uint)methodToken,
                                    out p_classToken,
                                    szMethodName,
                                    szMethodName.Capacity,
                                    out size,
                                    out pdwAttr,
                                    out ppvSigBlob,
                                    out pcbSigBlob,
                                    out pulCodeRVA,
                                    out pdwImplFlags);

            p_name = szMethodName.ToString();
            //m_methodAttributes = (MethodAttributes)pdwAttr;
        }

        public override string Name
        {
            get { return p_name; }
        }

        public override int MetadataToken
        {
            get { return this.p_methodToken; }
        }

        public override MethodInfo GetBaseDefinition()
        {
            throw new NotImplementedException();
        }

        public override ICustomAttributeProvider ReturnTypeCustomAttributes
        {
            get { throw new NotImplementedException(); }
        }

        public override MethodAttributes Attributes
        {
            get { throw new NotImplementedException(); }
        }

        public override MethodImplAttributes GetMethodImplementationFlags()
        {
            throw new NotImplementedException();
        }

        public override ParameterInfo[] GetParameters()
        {
            throw new NotImplementedException();
        }

        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override RuntimeMethodHandle MethodHandle
        {
            get { throw new NotImplementedException(); }
        }

        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    }
}
