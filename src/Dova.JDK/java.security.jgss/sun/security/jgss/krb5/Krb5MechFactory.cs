/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:58)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.jgss.krb5;

[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5MechFactory;", "public final")]
public partial class Krb5MechFactory
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.jgss.spi.MechanismFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Krb5MechFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/krb5/Krb5MechFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROVIDER", "Ljava/security/Provider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GSS_KRB5_MECH_OID", "Lorg/ietf/jgss/Oid;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NT_GSS_KRB5_PRINCIPAL", "Lorg/ietf/jgss/Oid;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nameTypes", "[Lorg/ietf/jgss/Oid;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caller", "Lsun/security/jgss/GSSCaller;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSCaller;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvider", "()Ljava/security/Provider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createOid", "(Ljava/lang/String;)Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMechanismOid", "()Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCredFromSubject", "(Lsun/security/jgss/spi/GSSNameSpi;Z)Lsun/security/jgss/krb5/Krb5CredElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCredentialElement", "(Lsun/security/jgss/spi/GSSNameSpi;III)Lsun/security/jgss/spi/GSSCredentialSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameTypes", "()[Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameElement", "(Ljava/lang/String;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameElement", "([BLorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMechanismContext", "(Lsun/security/jgss/spi/GSSNameSpi;Lsun/security/jgss/spi/GSSCredentialSpi;I)Lsun/security/jgss/spi/GSSContextSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMechanismContext", "([B)Lsun/security/jgss/spi/GSSContextSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMechanismContext", "(Lsun/security/jgss/spi/GSSCredentialSpi;)Lsun/security/jgss/spi/GSSContextSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkInitCredPermission", "(Lsun/security/jgss/krb5/Krb5NameElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkAcceptCredPermission", "(Lsun/security/jgss/krb5/Krb5NameElement;Lsun/security/jgss/spi/GSSNameSpi;)V"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/security/Provider;", "static final")]
	public static Dova.JDK.java.security.Provider PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/ietf/jgss/Oid;", "static final")]
	public static Dova.JDK.org.ietf.jgss.Oid GSS_KRB5_MECH_OID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/ietf/jgss/Oid;", "static final")]
	public static Dova.JDK.org.ietf.jgss.Oid NT_GSS_KRB5_PRINCIPAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lorg/ietf/jgss/Oid;", "private static")]
	public static JavaArray<Dova.JDK.org.ietf.jgss.Oid> nameTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.ietf.jgss.Oid>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/GSSCaller;", "private final")]
	public Dova.JDK.sun.security.jgss.GSSCaller caller_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.GSSCaller>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Krb5MechFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;)V", "public")]
	public Krb5MechFactory(Dova.JDK.sun.security.jgss.GSSCaller arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Krb5MechFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/krb5/Krb5MechFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/security/Provider;", "public")]
	public Dova.JDK.java.security.Provider getProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lorg/ietf/jgss/Oid;", "private static")]
	public static Dova.JDK.org.ietf.jgss.Oid createOid(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/Oid;", "public final")]
	public Dova.JDK.org.ietf.jgss.Oid getMechanismOid()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSNameSpi;Z)Lsun/security/jgss/krb5/Krb5CredElement;", "private static")]
	public static Dova.JDK.sun.security.jgss.krb5.Krb5CredElement getCredFromSubject(Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.Krb5CredElement>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSNameSpi;III)Lsun/security/jgss/spi/GSSCredentialSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi getCredentialElement(Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi>(ret);
	}

	[JniSignatureAttribute("()[Lorg/ietf/jgss/Oid;", "public")]
	public JavaArray<Dova.JDK.org.ietf.jgss.Oid> getNameTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.ietf.jgss.Oid>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getNameElement(Dova.JDK.java.lang.String arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("([BLorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getNameElement(JavaArray<byte> arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSNameSpi;Lsun/security/jgss/spi/GSSCredentialSpi;I)Lsun/security/jgss/spi/GSSContextSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg0, Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/security/jgss/spi/GSSContextSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSCredentialSpi;)Lsun/security/jgss/spi/GSSContextSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5NameElement;)V", "public static")]
	public static void checkInitCredPermission(Dova.JDK.sun.security.jgss.krb5.Krb5NameElement arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5NameElement;Lsun/security/jgss/spi/GSSNameSpi;)V", "public static")]
	public static void checkAcceptCredPermission(Dova.JDK.sun.security.jgss.krb5.Krb5NameElement arg0, Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
	}
}
