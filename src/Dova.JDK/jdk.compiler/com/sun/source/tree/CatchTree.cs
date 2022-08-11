/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
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

[JniSignatureAttribute("Lcom/sun/source/tree/CatchTree;", "public abstract interface")]
public partial interface CatchTree
	: IJavaObject
	, Dova.JDK.com.sun.source.tree.Tree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CatchTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/CatchTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameter", "()Lcom/sun/source/tree/VariableTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlock", "()Lcom/sun/source/tree/BlockTree;"));
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/VariableTree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.VariableTree getParameter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.VariableTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/BlockTree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.BlockTree getBlock()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.BlockTree>(ret);
	}
}
