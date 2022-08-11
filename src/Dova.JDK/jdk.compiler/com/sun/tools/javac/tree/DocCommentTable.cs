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

namespace Dova.JDK.com.sun.tools.javac.tree;

[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DocCommentTable;", "public abstract interface")]
public partial interface DocCommentTable
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocCommentTable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DocCommentTable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComment", "(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/parser/Tokens$Comment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommentText", "(Lcom/sun/tools/javac/tree/JCTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasComment", "(Lcom/sun/tools/javac/tree/JCTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommentTree", "(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/DCTree$DCDocComment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putComment", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/parser/Tokens$Comment;)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/parser/Tokens$Comment;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment getComment(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getCommentText(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Z", "public abstract")]
	bool hasComment(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/DCTree$DCDocComment;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment getCommentTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/parser/Tokens$Comment;)V", "public abstract")]
	void putComment(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}
}
