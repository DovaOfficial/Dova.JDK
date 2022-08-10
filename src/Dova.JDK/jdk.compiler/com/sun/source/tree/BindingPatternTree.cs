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

namespace Dova.JDK.com.sun.source.tree;

[JniSignatureAttribute("Lcom/sun/source/tree/BindingPatternTree;", "public abstract interface")]
public partial interface BindingPatternTree
	: IJavaObject
	, Dova.JDK.com.sun.source.tree.PatternTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BindingPatternTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/BindingPatternTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVariable", "()Lcom/sun/source/tree/VariableTree;"));
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/VariableTree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.VariableTree getVariable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.VariableTree>(ret);
	}
}
