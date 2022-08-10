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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/XSGrammar;", "public abstract interface")]
public partial interface XSGrammar
	: IJavaObject
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSGrammar()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/xni/grammars/XSGrammar;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toXSModel", "()Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toXSModel", "([Lcom/sun/org/apache/xerces/internal/xni/grammars/XSGrammar;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel toXSModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/xni/grammars/XSGrammar;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel toXSModel(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XSGrammar> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}
}
