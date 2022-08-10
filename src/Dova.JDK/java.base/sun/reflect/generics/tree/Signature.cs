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

namespace Dova.JDK.sun.reflect.generics.tree;

[JniSignatureAttribute("Lsun/reflect/generics/tree/Signature;", "public abstract interface")]
public partial interface Signature
	: IJavaObject
	, Dova.JDK.sun.reflect.generics.tree.Tree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Signature()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/tree/Signature;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFormalTypeParameters", "()[Lsun/reflect/generics/tree/FormalTypeParameter;"));
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FormalTypeParameter;", "public abstract")]
	JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> getFormalTypeParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
	}
}
