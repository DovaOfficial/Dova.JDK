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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/CurrentNodeListFilter;", "public abstract interface")]
public partial interface CurrentNodeListFilter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CurrentNodeListFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/CurrentNodeListFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(IIIILcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Z"));
	}

	[JniSignatureAttribute("(IIIILcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Z", "public abstract")]
	bool test(int arg0, int arg1, int arg2, int arg3, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet arg4, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg5)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}
}
