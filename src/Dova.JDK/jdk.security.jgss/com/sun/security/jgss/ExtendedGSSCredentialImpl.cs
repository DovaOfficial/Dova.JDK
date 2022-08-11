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

namespace Dova.JDK.com.sun.security.jgss;

[JniSignatureAttribute("Lcom/sun/security/jgss/ExtendedGSSCredentialImpl;", "")]
public partial class ExtendedGSSCredentialImpl
	: Dova.JDK.sun.security.jgss.GSSCredentialImpl
	, Dova.JDK.com.sun.security.jgss.ExtendedGSSCredential
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExtendedGSSCredentialImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/security/jgss/ExtendedGSSCredentialImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSCredentialImpl;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExtendedGSSCredentialImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCredentialImpl;)V", "public")]
	public ExtendedGSSCredentialImpl(Dova.JDK.sun.security.jgss.GSSCredentialImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/security/jgss/ExtendedGSSCredentialImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
