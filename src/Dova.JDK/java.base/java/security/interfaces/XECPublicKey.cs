/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljava/security/interfaces/XECPublicKey;", "public abstract interface")]
public partial interface XECPublicKey
	: IJavaObject
	, Dova.JDK.java.security.interfaces.XECKey
	, Dova.JDK.java.security.PublicKey
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XECPublicKey()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/security/interfaces/XECPublicKey;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getU", "()Ljava/math/BigInteger;"));
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public abstract")]
	Dova.JDK.java.math.BigInteger getU()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}
}
