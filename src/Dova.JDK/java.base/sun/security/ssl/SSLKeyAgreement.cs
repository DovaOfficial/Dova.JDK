/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/SSLKeyAgreement;", "abstract interface")]
public partial interface SSLKeyAgreement
	: IJavaObject
	, Dova.JDK.sun.security.ssl.SSLPossessionGenerator
	, Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator
	, Dova.JDK.sun.security.ssl.SSLHandshakeBinding
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static SSLKeyAgreement()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/SSLKeyAgreement;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}
