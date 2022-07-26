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

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/ExpressionNode;", "public abstract interface")]
public partial interface ExpressionNode
	: IJavaObject
	, Dova.JDK.javax.xml.transform.SourceLocator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExpressionNode()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/ExpressionNode;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exprGetParent", "()Lcom/sun/org/apache/xpath/internal/ExpressionNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exprSetParent", "(Lcom/sun/org/apache/xpath/internal/ExpressionNode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exprAddChild", "(Lcom/sun/org/apache/xpath/internal/ExpressionNode;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exprGetChild", "(I)Lcom/sun/org/apache/xpath/internal/ExpressionNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exprGetNumChildren", "()I"));
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/ExpressionNode;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionNode exprGetParent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionNode>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/ExpressionNode;)V", "public abstract")]
	void exprSetParent(Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionNode arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/ExpressionNode;I)V", "public abstract")]
	void exprAddChild(Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionNode arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/ExpressionNode;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionNode exprGetChild(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionNode>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int exprGetNumChildren()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}
}
