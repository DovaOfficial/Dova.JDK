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

[JniSignatureAttribute("Lorg/w3c/dom/DOMImplementationList;", "public abstract interface")]
public partial interface DOMImplementationList
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMImplementationList()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/DOMImplementationList;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "item", "(I)Lorg/w3c/dom/DOMImplementation;"));
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lorg/w3c/dom/DOMImplementation;", "public abstract")]
	Dova.JDK.org.w3c.dom.DOMImplementation item(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMImplementation>(ret);
	}
}
