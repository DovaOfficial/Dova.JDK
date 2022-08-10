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

namespace Dova.JDK.org.w3c.dom.xpath;

[JniSignatureAttribute("Lorg/w3c/dom/xpath/XPathEvaluator;", "public abstract interface")]
public partial interface XPathEvaluator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPathEvaluator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/xpath/XPathEvaluator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluate", "(Ljava/lang/String;Lorg/w3c/dom/Node;Lorg/w3c/dom/xpath/XPathNSResolver;SLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createExpression", "(Ljava/lang/String;Lorg/w3c/dom/xpath/XPathNSResolver;)Lorg/w3c/dom/xpath/XPathExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createNSResolver", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/xpath/XPathNSResolver;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/w3c/dom/Node;Lorg/w3c/dom/xpath/XPathNSResolver;SLjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object evaluate(Dova.JDK.java.lang.String arg0, Dova.JDK.org.w3c.dom.Node arg1, Dova.JDK.org.w3c.dom.xpath.XPathNSResolver arg2, short arg3, Dova.JDK.java.lang.Object arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/w3c/dom/xpath/XPathNSResolver;)Lorg/w3c/dom/xpath/XPathExpression;", "public abstract")]
	Dova.JDK.org.w3c.dom.xpath.XPathExpression createExpression(Dova.JDK.java.lang.String arg0, Dova.JDK.org.w3c.dom.xpath.XPathNSResolver arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.xpath.XPathExpression>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Lorg/w3c/dom/xpath/XPathNSResolver;", "public abstract")]
	Dova.JDK.org.w3c.dom.xpath.XPathNSResolver createNSResolver(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.xpath.XPathNSResolver>(ret);
	}
}
