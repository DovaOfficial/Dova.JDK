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

namespace Dova.JDK.java.security.interfaces;

[JniSignatureAttribute("Ljava/security/interfaces/EdECPublicKey;", "public abstract interface")]
public partial interface EdECPublicKey
	: IJavaObject
	, Dova.JDK.java.security.interfaces.EdECKey
	, Dova.JDK.java.security.PublicKey
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EdECPublicKey()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/security/interfaces/EdECPublicKey;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPoint", "()Ljava/security/spec/EdECPoint;"));
	}

	[JniSignatureAttribute("()Ljava/security/spec/EdECPoint;", "public abstract")]
	Dova.JDK.java.security.spec.EdECPoint getPoint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.EdECPoint>(ret);
	}
}
