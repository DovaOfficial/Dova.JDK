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

namespace Dova.JDK.sun.security.krb5.@internal;

[JniSignatureAttribute("Lsun/security/krb5/internal/EncASRepPart;", "public")]
public partial class EncASRepPart
	: Dova.JDK.sun.security.krb5.@internal.EncKDCRepPart
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EncASRepPart()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/EncASRepPart;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/util/DerValue;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/LastReq;ILsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/TicketFlags;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/HostAddresses;[Lsun/security/krb5/internal/PAData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lsun/security/util/DerValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asn1Encode", "()[B"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EncASRepPart(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "public")]
	public EncASRepPart(Dova.JDK.sun.security.util.DerValue arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public EncASRepPart(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/LastReq;ILsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/TicketFlags;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/HostAddresses;[Lsun/security/krb5/internal/PAData;)V", "public")]
	public EncASRepPart(Dova.JDK.sun.security.krb5.EncryptionKey arg0, Dova.JDK.sun.security.krb5.@internal.LastReq arg1, int arg2, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg3, Dova.JDK.sun.security.krb5.@internal.TicketFlags arg4, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg5, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg6, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg7, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg8, Dova.JDK.sun.security.krb5.PrincipalName arg9, Dova.JDK.sun.security.krb5.@internal.HostAddresses arg10, JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg11) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/EncASRepPart;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "private")]
	public void init(Dova.JDK.sun.security.util.DerValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> asn1Encode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
