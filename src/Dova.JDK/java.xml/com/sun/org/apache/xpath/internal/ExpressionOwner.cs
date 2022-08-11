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

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/ExpressionOwner;", "public abstract interface")]
public partial interface ExpressionOwner
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExpressionOwner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/ExpressionOwner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExpression", "(Lcom/sun/org/apache/xpath/internal/Expression;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression", "()Lcom/sun/org/apache/xpath/internal/Expression;"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)V", "public abstract")]
	void setExpression(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/Expression;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xpath.@internal.Expression getExpression()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}
}
