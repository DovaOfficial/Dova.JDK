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

namespace Dova.JDK.org.w3c.dom;

[JniSignatureAttribute("Lorg/w3c/dom/DOMImplementationSource;", "public abstract interface")]
public partial interface DOMImplementationSource
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMImplementationSource()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/DOMImplementationSource;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDOMImplementation", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDOMImplementationList", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;", "public abstract")]
	Dova.JDK.org.w3c.dom.DOMImplementation getDOMImplementation(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMImplementation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;", "public abstract")]
	Dova.JDK.org.w3c.dom.DOMImplementationList getDOMImplementationList(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMImplementationList>(ret);
	}
}
