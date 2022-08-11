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

[JniSignatureAttribute("Lsun/security/krb5/KrbKdcRep;", "abstract")]
public partial class KrbKdcRep
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KrbKdcRep()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/KrbKdcRep;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "check", "(ZLsun/security/krb5/internal/KDCReq;Lsun/security/krb5/internal/KDCRep;Lsun/security/krb5/EncryptionKey;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KrbKdcRep(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public KrbKdcRep() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/KrbKdcRep;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ZLsun/security/krb5/internal/KDCReq;Lsun/security/krb5/internal/KDCRep;Lsun/security/krb5/EncryptionKey;)V", "static")]
	public static void check(bool arg0, Dova.JDK.sun.security.krb5.@internal.KDCReq arg1, Dova.JDK.sun.security.krb5.@internal.KDCRep arg2, Dova.JDK.sun.security.krb5.EncryptionKey arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}
}
