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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaxCryptoSpecAccess;", "public abstract interface")]
public partial interface JavaxCryptoSpecAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaxCryptoSpecAccess()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/access/JavaxCryptoSpecAccess;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clearSecretKeySpec", "(Ljavax/crypto/spec/SecretKeySpec;)V"));
	}

	[JniSignatureAttribute("(Ljavax/crypto/spec/SecretKeySpec;)V", "public abstract")]
	void clearSecretKeySpec(Dova.JDK.javax.crypto.spec.SecretKeySpec arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
