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

[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5InitCredential;", "public")]
public partial class Krb5InitCredential
	: Dova.JDK.javax.security.auth.kerberos.KerberosTicket
	, Dova.JDK.sun.security.jgss.krb5.Krb5CredElement
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Krb5InitCredential()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/krb5/Krb5InitCredential;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lsun/security/jgss/krb5/Krb5NameElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "krb5Credentials", "Lsun/security/krb5/Credentials;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxyTicket", "Ljavax/security/auth/kerberos/KerberosTicket;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/krb5/Krb5NameElement;[BLjavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;[BI[ZLjava/util/Date;Ljava/util/Date;Ljava/util/Date;Ljava/util/Date;[Ljava/net/InetAddress;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/krb5/Krb5NameElement;Lsun/security/krb5/Credentials;[BLjavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;[BI[ZLjava/util/Date;Ljava/util/Date;Ljava/util/Date;Ljava/util/Date;[Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Lsun/security/jgss/GSSCaller;Lsun/security/jgss/krb5/Krb5NameElement;I)Lsun/security/jgss/krb5/Krb5InitCredential;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Lsun/security/jgss/krb5/Krb5NameElement;Lsun/security/krb5/Credentials;)Lsun/security/jgss/krb5/Krb5InitCredential;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvider", "()Ljava/security/Provider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTgt", "(Lsun/security/jgss/GSSCaller;Lsun/security/jgss/krb5/Krb5NameElement;I)Ljavax/security/auth/kerberos/KerberosTicket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "impersonate", "(Lsun/security/jgss/spi/GSSNameSpi;)Lsun/security/jgss/spi/GSSCredentialSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitLifetime", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcceptLifetime", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInitiatorCredential", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAcceptorCredential", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMechanism", "()Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKrb5Credentials", "()Lsun/security/krb5/Credentials;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5NameElement;", "private")]
	public Dova.JDK.sun.security.jgss.krb5.Krb5NameElement name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.Krb5NameElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/Credentials;", "private")]
	public Dova.JDK.sun.security.krb5.Credentials krb5Credentials_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/security/auth/kerberos/KerberosTicket;", "public")]
	public Dova.JDK.javax.security.auth.kerberos.KerberosTicket proxyTicket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosTicket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Krb5InitCredential(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5NameElement;[BLjavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;[BI[ZLjava/util/Date;Ljava/util/Date;Ljava/util/Date;Ljava/util/Date;[Ljava/net/InetAddress;)V", "private")]
	public Krb5InitCredential(Dova.JDK.sun.security.jgss.krb5.Krb5NameElement arg0, JavaArray<byte> arg1, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg2, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg3, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg4, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg5, JavaArray<byte> arg6, int arg7, JavaArray<bool> arg8, Dova.JDK.java.util.Date arg9, Dova.JDK.java.util.Date arg10, Dova.JDK.java.util.Date arg11, Dova.JDK.java.util.Date arg12, JavaArray<Dova.JDK.java.net.InetAddress> arg13) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5NameElement;Lsun/security/krb5/Credentials;[BLjavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;Ljavax/security/auth/kerberos/KerberosPrincipal;[BI[ZLjava/util/Date;Ljava/util/Date;Ljava/util/Date;Ljava/util/Date;[Ljava/net/InetAddress;)V", "private")]
	public Krb5InitCredential(Dova.JDK.sun.security.jgss.krb5.Krb5NameElement arg0, Dova.JDK.sun.security.krb5.Credentials arg1, JavaArray<byte> arg2, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg3, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg4, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg5, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg6, JavaArray<byte> arg7, int arg8, JavaArray<bool> arg9, Dova.JDK.java.util.Date arg10, Dova.JDK.java.util.Date arg11, Dova.JDK.java.util.Date arg12, Dova.JDK.java.util.Date arg13, JavaArray<Dova.JDK.java.net.InetAddress> arg14) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/krb5/Krb5InitCredential;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/security/jgss/spi/GSSNameSpi;", "public final")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;Lsun/security/jgss/krb5/Krb5NameElement;I)Lsun/security/jgss/krb5/Krb5InitCredential;", "static")]
	public static Dova.JDK.sun.security.jgss.krb5.Krb5InitCredential getInstance(Dova.JDK.sun.security.jgss.GSSCaller arg0, Dova.JDK.sun.security.jgss.krb5.Krb5NameElement arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.Krb5InitCredential>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5NameElement;Lsun/security/krb5/Credentials;)Lsun/security/jgss/krb5/Krb5InitCredential;", "static")]
	public static Dova.JDK.sun.security.jgss.krb5.Krb5InitCredential getInstance(Dova.JDK.sun.security.jgss.krb5.Krb5NameElement arg0, Dova.JDK.sun.security.krb5.Credentials arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.Krb5InitCredential>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Provider;", "public final")]
	public Dova.JDK.java.security.Provider getProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;Lsun/security/jgss/krb5/Krb5NameElement;I)Ljavax/security/auth/kerberos/KerberosTicket;", "private static")]
	public static Dova.JDK.javax.security.auth.kerberos.KerberosTicket getTgt(Dova.JDK.sun.security.jgss.GSSCaller arg0, Dova.JDK.sun.security.jgss.krb5.Krb5NameElement arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosTicket>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSNameSpi;)Lsun/security/jgss/spi/GSSCredentialSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi impersonate(Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getInitLifetime()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAcceptLifetime()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInitiatorCredential()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAcceptorCredential()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/Oid;", "public final")]
	public Dova.JDK.org.ietf.jgss.Oid getMechanism()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "")]
	public Dova.JDK.sun.security.krb5.Credentials getKrb5Credentials()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}
}
