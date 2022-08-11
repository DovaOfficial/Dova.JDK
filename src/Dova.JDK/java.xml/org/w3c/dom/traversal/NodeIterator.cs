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

[JniSignatureAttribute("Lorg/w3c/dom/traversal/NodeIterator;", "public abstract interface")]
public partial interface NodeIterator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NodeIterator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/traversal/NodeIterator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRoot", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextNode", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFilter", "()Lorg/w3c/dom/traversal/NodeFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detach", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWhatToShow", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpandEntityReferences", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previousNode", "()Lorg/w3c/dom/Node;"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public abstract")]
	Dova.JDK.org.w3c.dom.Node getRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public abstract")]
	Dova.JDK.org.w3c.dom.Node nextNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/traversal/NodeFilter;", "public abstract")]
	Dova.JDK.org.w3c.dom.traversal.NodeFilter getFilter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.traversal.NodeFilter>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void detach()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getWhatToShow()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool getExpandEntityReferences()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public abstract")]
	Dova.JDK.org.w3c.dom.Node previousNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}
}
