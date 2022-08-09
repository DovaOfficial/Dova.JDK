/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.org.w3c.dom.css;

[JniSignatureAttribute("Lorg/w3c/dom/css/DocumentCSS;", "public abstract interface")]
public partial interface DocumentCSS
	: IJavaObject
	, Dova.JDK.org.w3c.dom.stylesheets.DocumentStyle
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocumentCSS()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/w3c/dom/css/DocumentCSS;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOverrideStyle", "(Lorg/w3c/dom/Element;Ljava/lang/String;)Lorg/w3c/dom/css/CSSStyleDeclaration;"));
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;)Lorg/w3c/dom/css/CSSStyleDeclaration;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSStyleDeclaration getOverrideStyle(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSStyleDeclaration>(ret);
	}
}
