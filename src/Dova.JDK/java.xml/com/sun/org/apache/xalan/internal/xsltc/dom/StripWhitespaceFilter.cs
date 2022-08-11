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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/StripWhitespaceFilter;", "public abstract interface")]
public partial interface StripWhitespaceFilter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StripWhitespaceFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/StripWhitespaceFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripSpace", "(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;II)Z"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;II)Z", "public abstract")]
	bool stripSpace(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}
}
