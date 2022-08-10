/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.krb5.@internal.ccache;

[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/CCacheOutputStream;", "public")]
public partial class CCacheOutputStream
	: Dova.JDK.sun.security.krb5.@internal.util.KrbDataOutputStream
	, Dova.JDK.sun.security.krb5.@internal.ccache.FileCCacheConstants
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CCacheOutputStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/ccache/CCacheOutputStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CCacheOutputStream", "(Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeFlags", "(Lsun/security/krb5/internal/TicketFlags;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeTicket", "(Lsun/security/krb5/internal/Ticket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeHeader", "(Lsun/security/krb5/PrincipalName;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addCreds", "(Lsun/security/krb5/internal/ccache/Credentials;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addConfigEntry", "(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CCacheOutputStream(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "public")]
	public CCacheOutputStream(Dova.JDK.java.io.OutputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/ccache/CCacheOutputStream;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/krb5/internal/TicketFlags;)V", "")]
	public void writeFlags(Dova.JDK.sun.security.krb5.@internal.TicketFlags arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/Ticket;)V", "")]
	public void writeTicket(Dova.JDK.sun.security.krb5.@internal.Ticket arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;I)V", "public")]
	public void writeHeader(Dova.JDK.sun.security.krb5.PrincipalName arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/ccache/Credentials;)V", "public")]
	public void addCreds(Dova.JDK.sun.security.krb5.@internal.ccache.Credentials arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;)V", "public")]
	public void addConfigEntry(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache.ConfigEntry arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}
}
