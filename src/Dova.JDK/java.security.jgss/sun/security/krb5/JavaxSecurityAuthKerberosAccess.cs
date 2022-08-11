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

namespace Dova.JDK.sun.security.krb5;

[JniSignatureAttribute("Lsun/security/krb5/JavaxSecurityAuthKerberosAccess;", "public abstract interface")]
public partial interface JavaxSecurityAuthKerberosAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaxSecurityAuthKerberosAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/JavaxSecurityAuthKerberosAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kerberosTicketGetClientAlias", "(Ljavax/security/auth/kerberos/KerberosTicket;)Ljavax/security/auth/kerberos/KerberosPrincipal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kerberosTicketSetClientAlias", "(Ljavax/security/auth/kerberos/KerberosTicket;Ljavax/security/auth/kerberos/KerberosPrincipal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "keyTabTakeSnapshot", "(Ljavax/security/auth/kerberos/KeyTab;)Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kerberosTicketGetServerAlias", "(Ljavax/security/auth/kerberos/KerberosTicket;)Ljavax/security/auth/kerberos/KerberosPrincipal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kerberosTicketSetServerAlias", "(Ljavax/security/auth/kerberos/KerberosTicket;Ljavax/security/auth/kerberos/KerberosPrincipal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kerberosTicketGetProxy", "(Ljavax/security/auth/kerberos/KerberosTicket;)Ljavax/security/auth/kerberos/KerberosTicket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kerberosTicketSetProxy", "(Ljavax/security/auth/kerberos/KerberosTicket;Ljavax/security/auth/kerberos/KerberosTicket;)V"));
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosTicket;)Ljavax/security/auth/kerberos/KerberosPrincipal;", "public abstract")]
	Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal kerberosTicketGetClientAlias(Dova.JDK.javax.security.auth.kerberos.KerberosTicket arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosTicket;Ljavax/security/auth/kerberos/KerberosPrincipal;)V", "public abstract")]
	void kerberosTicketSetClientAlias(Dova.JDK.javax.security.auth.kerberos.KerberosTicket arg0, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KeyTab;)Lsun/security/krb5/internal/ktab/KeyTab;", "public abstract")]
	Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab keyTabTakeSnapshot(Dova.JDK.javax.security.auth.kerberos.KeyTab arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosTicket;)Ljavax/security/auth/kerberos/KerberosPrincipal;", "public abstract")]
	Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal kerberosTicketGetServerAlias(Dova.JDK.javax.security.auth.kerberos.KerberosTicket arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosTicket;Ljavax/security/auth/kerberos/KerberosPrincipal;)V", "public abstract")]
	void kerberosTicketSetServerAlias(Dova.JDK.javax.security.auth.kerberos.KerberosTicket arg0, Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosTicket;)Ljavax/security/auth/kerberos/KerberosTicket;", "public abstract")]
	Dova.JDK.javax.security.auth.kerberos.KerberosTicket kerberosTicketGetProxy(Dova.JDK.javax.security.auth.kerberos.KerberosTicket arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosTicket>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosTicket;Ljavax/security/auth/kerberos/KerberosTicket;)V", "public abstract")]
	void kerberosTicketSetProxy(Dova.JDK.javax.security.auth.kerberos.KerberosTicket arg0, Dova.JDK.javax.security.auth.kerberos.KerberosTicket arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}
}
