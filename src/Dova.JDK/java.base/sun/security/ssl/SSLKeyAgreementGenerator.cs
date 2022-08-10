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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/SSLKeyAgreementGenerator;", "abstract interface")]
public partial interface SSLKeyAgreementGenerator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLKeyAgreementGenerator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyAgreementGenerator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public abstract")]
	Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
	}
}
