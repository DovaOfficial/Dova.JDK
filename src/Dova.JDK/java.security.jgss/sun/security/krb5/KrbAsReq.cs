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

namespace Dova.JDK.sun.security.krb5;

[JniSignatureAttribute("Lsun/security/krb5/KrbAsReq;", "public")]
public partial class KrbAsReq
	: Dova.JDK.sun.security.krb5.KrbKdcReq
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KrbAsReq()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/KrbAsReq;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "asReqMessg", "Lsun/security/krb5/internal/ASReq;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "DEBUG", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "KrbAsReq", "(Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;[ILsun/security/krb5/internal/HostAddresses;[Lsun/security/krb5/internal/PAData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMessage", "()Lsun/security/krb5/internal/ASReq;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "encoding", "()[B"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/ASReq;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.ASReq asReqMessg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ASReq>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KrbAsReq(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;[ILsun/security/krb5/internal/HostAddresses;[Lsun/security/krb5/internal/PAData;)V", "public")]
	public KrbAsReq(Dova.JDK.sun.security.krb5.EncryptionKey arg0, Dova.JDK.sun.security.krb5.@internal.KDCOptions arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg4, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg5, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg6, JavaArray<int> arg7, Dova.JDK.sun.security.krb5.@internal.HostAddresses arg8, JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg9) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/KrbAsReq;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ASReq;", "")]
	public Dova.JDK.sun.security.krb5.@internal.ASReq getMessage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ASReq>(ret);
	}

	[JniSignatureAttribute("()[B", "public volatile")]
	public JavaArray<byte> encoding()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
