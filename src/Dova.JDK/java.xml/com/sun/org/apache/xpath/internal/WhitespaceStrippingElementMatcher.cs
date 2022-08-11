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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/WhitespaceStrippingElementMatcher;", "public abstract interface")]
public partial interface WhitespaceStrippingElementMatcher
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WhitespaceStrippingElementMatcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/WhitespaceStrippingElementMatcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldStripWhiteSpace", "(Lcom/sun/org/apache/xpath/internal/XPathContext;Lorg/w3c/dom/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canStripWhiteSpace", "()Z"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;Lorg/w3c/dom/Element;)Z", "public abstract")]
	bool shouldStripWhiteSpace(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, Dova.JDK.org.w3c.dom.Element arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool canStripWhiteSpace()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}
}
