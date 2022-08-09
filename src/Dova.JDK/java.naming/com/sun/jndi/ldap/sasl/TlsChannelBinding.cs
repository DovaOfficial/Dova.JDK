/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.jndi.ldap.sasl;

[JniSignatureAttribute("Lcom/sun/jndi/ldap/sasl/TlsChannelBinding;", "public")]
public partial class TlsChannelBinding
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TlsChannelBinding()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jndi/ldap/sasl/TlsChannelBinding;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHANNEL_BINDING_TYPE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHANNEL_BINDING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "cbType", "Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "cbData", "[B"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TlsChannelBinding", "(Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;[B)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getType", "()Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljava/security/cert/X509Certificate;)Lcom/sun/jndi/ldap/sasl/TlsChannelBinding;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "parseType", "(Ljava/lang/String;)Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getData", "()[B"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String CHANNEL_BINDING_TYPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String CHANNEL_BINDING_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "private final")]
	public Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType cbType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> cbData_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TlsChannelBinding(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;[B)V", "private")]
	public TlsChannelBinding(Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType arg0, JavaArray<byte> arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/ldap/sasl/TlsChannelBinding;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "public")]
	public Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType getType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;)Lcom/sun/jndi/ldap/sasl/TlsChannelBinding;", "public static")]
	public static Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding create(Dova.JDK.java.security.cert.X509Certificate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "public static")]
	public static Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType parseType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getData()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "public static final")]
	public partial class TlsChannelBindingType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TlsChannelBindingType()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TLS_UNIQUE", "Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TLS_SERVER_END_POINT", "Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TlsChannelBindingType", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;"));
		}

		[JniSignatureAttribute("Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "public static final")]
		public static Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType TLS_UNIQUE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "public static final")]
		public static Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType TLS_SERVER_END_POINT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TlsChannelBindingType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public TlsChannelBindingType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "public static")]
		public static Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/jndi/ldap/sasl/TlsChannelBinding$TlsChannelBindingType;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jndi.ldap.sasl.TlsChannelBinding.TlsChannelBindingType>>(ret);
		}
	}
}