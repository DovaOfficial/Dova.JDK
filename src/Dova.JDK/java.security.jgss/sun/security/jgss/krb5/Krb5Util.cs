/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5Util;", "public")]
public partial class Krb5Util
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Krb5Util()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/krb5/Krb5Util;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Krb5Util", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "credsToTicket", "(Lsun/security/krb5/Credentials;)Ljavax/security/auth/kerberos/KerberosTicket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getServiceCreds", "(Lsun/security/jgss/GSSCaller;Ljava/lang/String;)Lsun/security/jgss/krb5/ServiceCreds;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ticketToCreds", "(Ljavax/security/auth/kerberos/KerberosTicket;)Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "snapshotFromJavaxKeyTab", "(Ljavax/security/auth/kerberos/KeyTab;)Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getServiceTicket", "(Lsun/security/jgss/GSSCaller;Ljava/lang/String;Ljava/lang/String;)Ljavax/security/auth/kerberos/KerberosTicket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInitialTicket", "(Lsun/security/jgss/GSSCaller;Ljava/lang/String;)Ljavax/security/auth/kerberos/KerberosTicket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "keysFromJavaxKeyTab", "(Ljavax/security/auth/kerberos/KeyTab;Lsun/security/krb5/PrincipalName;)[Lsun/security/krb5/EncryptionKey;"));
	}

	[JniSignatureAttribute("Z", "static final")]
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Krb5Util(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Krb5Util() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/krb5/Krb5Util;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/krb5/Credentials;)Ljavax/security/auth/kerberos/KerberosTicket;", "public static")]
	public static Dova.JDK.javax.security.auth.kerberos.KerberosTicket credsToTicket(Dova.JDK.sun.security.krb5.Credentials arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosTicket>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;Ljava/lang/String;)Lsun/security/jgss/krb5/ServiceCreds;", "public static")]
	public static Dova.JDK.sun.security.jgss.krb5.ServiceCreds getServiceCreds(Dova.JDK.sun.security.jgss.GSSCaller arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.ServiceCreds>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosTicket;)Lsun/security/krb5/Credentials;", "public static")]
	public static Dova.JDK.sun.security.krb5.Credentials ticketToCreds(Dova.JDK.javax.security.auth.kerberos.KerberosTicket arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KeyTab;)Lsun/security/krb5/internal/ktab/KeyTab;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab snapshotFromJavaxKeyTab(Dova.JDK.javax.security.auth.kerberos.KeyTab arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;Ljava/lang/String;Ljava/lang/String;)Ljavax/security/auth/kerberos/KerberosTicket;", "static")]
	public static Dova.JDK.javax.security.auth.kerberos.KerberosTicket getServiceTicket(Dova.JDK.sun.security.jgss.GSSCaller arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosTicket>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;Ljava/lang/String;)Ljavax/security/auth/kerberos/KerberosTicket;", "static")]
	public static Dova.JDK.javax.security.auth.kerberos.KerberosTicket getInitialTicket(Dova.JDK.sun.security.jgss.GSSCaller arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosTicket>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KeyTab;Lsun/security/krb5/PrincipalName;)[Lsun/security/krb5/EncryptionKey;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.krb5.EncryptionKey> keysFromJavaxKeyTab(Dova.JDK.javax.security.auth.kerberos.KeyTab arg0, Dova.JDK.sun.security.krb5.PrincipalName arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.EncryptionKey>>(ret);
	}
}
