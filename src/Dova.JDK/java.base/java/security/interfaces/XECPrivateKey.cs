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

[JniSignatureAttribute("Ljava/security/interfaces/XECPrivateKey;", "public abstract interface")]
public partial interface XECPrivateKey
	: IJavaObject
	, Dova.JDK.java.security.interfaces.XECKey
	, Dova.JDK.java.security.PrivateKey
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XECPrivateKey()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/security/interfaces/XECPrivateKey;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScalar", "()Ljava/util/Optional;"));
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	Dova.JDK.java.util.Optional getScalar()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}
}
