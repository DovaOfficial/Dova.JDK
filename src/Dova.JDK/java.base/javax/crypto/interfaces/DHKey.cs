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

namespace Dova.JDK.javax.crypto.interfaces;

[JniSignatureAttribute("Ljavax/crypto/interfaces/DHKey;", "public abstract interface")]
public partial interface DHKey
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DHKey()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/crypto/interfaces/DHKey;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParams", "()Ljavax/crypto/spec/DHParameterSpec;"));
	}

	[JniSignatureAttribute("()Ljavax/crypto/spec/DHParameterSpec;", "public abstract")]
	Dova.JDK.javax.crypto.spec.DHParameterSpec getParams()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.spec.DHParameterSpec>(ret);
	}
}
