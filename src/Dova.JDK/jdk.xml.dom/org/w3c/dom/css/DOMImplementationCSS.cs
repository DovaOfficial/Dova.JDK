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

namespace Dova.JDK.org.w3c.dom.css;

[JniSignatureAttribute("Lorg/w3c/dom/css/DOMImplementationCSS;", "public abstract interface")]
public partial interface DOMImplementationCSS
	: IJavaObject
	, Dova.JDK.org.w3c.dom.DOMImplementation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMImplementationCSS()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/css/DOMImplementationCSS;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCSSStyleSheet", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/css/CSSStyleSheet;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/css/CSSStyleSheet;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSStyleSheet createCSSStyleSheet(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSStyleSheet>(ret);
	}
}
