using System;
using System.Collections;
using System.Reflection;
using MinDbg.NativeApi;

namespace MinDbg.CorMetadata
{
    internal sealed class MetadataType : Type
    {
        private readonly IMetadataImport p_importer;
        private readonly Int32 p_typeToken;

        internal MetadataType(IMetadataImport importer, Int32 typeToken)
        {
            this.p_importer = importer;
            this.p_typeToken = typeToken;
        }

        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr)
        {
            IntPtr hEnum = new IntPtr();
            ArrayList methods = new ArrayList();

            Int32 methodToken;
            try
            {
                while (true)
                {
                    Int32 size;
                    p_importer.EnumMethods(ref hEnum, p_typeToken, out methodToken, 1, out size);
                    if (size == 0)
                        break;
                    methods.Add(new MetadataMethodInfo(p_importer, methodToken));
                }
            }
            finally
            {
                p_importer.CloseEnum(hEnum);
            }
            return (MethodInfo[])methods.ToArray(typeof(MethodInfo));
        }

        public override System.Reflection.Assembly Assembly
        {
            get { throw new NotImplementedException(); }
        }

        public override string AssemblyQualifiedName
        {
            get { throw new NotImplementedException(); }
        }

        public override Type BaseType
        {
            get { throw new NotImplementedException(); }
        }

        public override string FullName
        {
            get { throw new NotImplementedException(); }
        }

        public override Guid GUID
        {
            get { throw new NotImplementedException(); }
        }

        protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl()
        {
            throw new NotImplementedException();
        }

        protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetElementType()
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetInterface(string name, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetInterfaces()
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        public override Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type returnType, Type[] types, System.Reflection.ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override bool HasElementTypeImpl()
        {
            throw new NotImplementedException();
        }

        public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters)
        {
            throw new NotImplementedException();
        }

        protected override bool IsArrayImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsByRefImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsCOMObjectImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPointerImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPrimitiveImpl()
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.Module Module
        {
            get { throw new NotImplementedException(); }
        }

        public override string Namespace
        {
            get { throw new NotImplementedException(); }
        }

        public override Type UnderlyingSystemType
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

        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    }
}
