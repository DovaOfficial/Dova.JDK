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

namespace Dova.JDK.com.sun.source.util;

[JniSignatureAttribute("Lcom/sun/source/util/DocSourcePositions;", "public abstract interface")]
public partial interface DocSourcePositions
	: IJavaObject
	, Dova.JDK.com.sun.source.util.SourcePositions
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocSourcePositions()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/DocSourcePositions;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPosition", "(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/doctree/DocTree;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPosition", "(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/doctree/DocTree;)J"));
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/doctree/DocTree;)J", "public abstract")]
	long getEndPosition(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.com.sun.source.doctree.DocCommentTree arg1, Dova.JDK.com.sun.source.doctree.DocTree arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/doctree/DocTree;)J", "public abstract")]
	long getStartPosition(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.com.sun.source.doctree.DocCommentTree arg1, Dova.JDK.com.sun.source.doctree.DocTree arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}
}
