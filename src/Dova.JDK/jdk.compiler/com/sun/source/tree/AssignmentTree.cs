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

namespace Dova.JDK.com.sun.source.tree;

[JniSignatureAttribute("Lcom/sun/source/tree/AssignmentTree;", "public abstract interface")]
public partial interface AssignmentTree
	: IJavaObject
	, Dova.JDK.com.sun.source.tree.ExpressionTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AssignmentTree()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/source/tree/AssignmentTree;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExpression", "()Lcom/sun/source/tree/ExpressionTree;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getVariable", "()Lcom/sun/source/tree/ExpressionTree;"));
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.ExpressionTree getExpression()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.ExpressionTree getVariable()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
	}
}
