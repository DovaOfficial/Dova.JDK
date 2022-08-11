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

namespace Dova.JDK.org.w3c.dom.traversal;

[JniSignatureAttribute("Lorg/w3c/dom/traversal/DocumentTraversal;", "public abstract interface")]
public partial interface DocumentTraversal
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocumentTraversal()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/traversal/DocumentTraversal;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createNodeIterator", "(Lorg/w3c/dom/Node;ILorg/w3c/dom/traversal/NodeFilter;Z)Lorg/w3c/dom/traversal/NodeIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTreeWalker", "(Lorg/w3c/dom/Node;ILorg/w3c/dom/traversal/NodeFilter;Z)Lorg/w3c/dom/traversal/TreeWalker;"));
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;ILorg/w3c/dom/traversal/NodeFilter;Z)Lorg/w3c/dom/traversal/NodeIterator;", "public abstract")]
	Dova.JDK.org.w3c.dom.traversal.NodeIterator createNodeIterator(Dova.JDK.org.w3c.dom.Node arg0, int arg1, Dova.JDK.org.w3c.dom.traversal.NodeFilter arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.traversal.NodeIterator>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;ILorg/w3c/dom/traversal/NodeFilter;Z)Lorg/w3c/dom/traversal/TreeWalker;", "public abstract")]
	Dova.JDK.org.w3c.dom.traversal.TreeWalker createTreeWalker(Dova.JDK.org.w3c.dom.Node arg0, int arg1, Dova.JDK.org.w3c.dom.traversal.NodeFilter arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.traversal.TreeWalker>(ret);
	}
}
