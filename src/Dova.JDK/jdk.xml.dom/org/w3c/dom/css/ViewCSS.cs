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

namespace Dova.JDK.org.w3c.dom.css;

[JniSignatureAttribute("Lorg/w3c/dom/css/ViewCSS;", "public abstract interface")]
public partial interface ViewCSS
	: IJavaObject
	, Dova.JDK.org.w3c.dom.views.AbstractView
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ViewCSS()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/css/ViewCSS;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getComputedStyle", "(Lorg/w3c/dom/Element;Ljava/lang/String;)Lorg/w3c/dom/css/CSSStyleDeclaration;"));
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;)Lorg/w3c/dom/css/CSSStyleDeclaration;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSStyleDeclaration getComputedStyle(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSStyleDeclaration>(ret);
	}
}
