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

namespace Dova.JDK.org.w3c.dom;

[JniSignatureAttribute("Lorg/w3c/dom/ElementTraversal;", "public abstract interface")]
public partial interface ElementTraversal
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ElementTraversal()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/ElementTraversal;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstElementChild", "()Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastElementChild", "()Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreviousElementSibling", "()Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextElementSibling", "()Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildElementCount", "()I"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Element;", "public abstract")]
	Dova.JDK.org.w3c.dom.Element getFirstElementChild()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Element;", "public abstract")]
	Dova.JDK.org.w3c.dom.Element getLastElementChild()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Element;", "public abstract")]
	Dova.JDK.org.w3c.dom.Element getPreviousElementSibling()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Element;", "public abstract")]
	Dova.JDK.org.w3c.dom.Element getNextElementSibling()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getChildElementCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}
}
