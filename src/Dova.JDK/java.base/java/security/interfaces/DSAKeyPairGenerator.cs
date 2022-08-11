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

namespace Dova.JDK.java.security.interfaces;

[JniSignatureAttribute("Ljava/security/interfaces/DSAKeyPairGenerator;", "public abstract interface")]
public partial interface DSAKeyPairGenerator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DSAKeyPairGenerator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/security/interfaces/DSAKeyPairGenerator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/security/interfaces/DSAParams;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(IZLjava/security/SecureRandom;)V"));
	}

	[JniSignatureAttribute("(Ljava/security/interfaces/DSAParams;Ljava/security/SecureRandom;)V", "public abstract")]
	void initialize(Dova.JDK.java.security.interfaces.DSAParams arg0, Dova.JDK.java.security.SecureRandom arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(IZLjava/security/SecureRandom;)V", "public abstract")]
	void initialize(int arg0, bool arg1, Dova.JDK.java.security.SecureRandom arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}
}
