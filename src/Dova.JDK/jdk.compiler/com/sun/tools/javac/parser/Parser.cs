/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.parser;

[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Parser;", "public abstract interface")]
public partial interface Parser
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Parser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Parser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseType", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseCompilationUnit", "()Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseExpression", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseStatement", "()Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression parseType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit parseCompilationUnit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression parseExpression()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement parseStatement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
	}
}
