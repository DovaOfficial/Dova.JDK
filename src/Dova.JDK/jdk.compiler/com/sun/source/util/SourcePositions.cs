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

namespace Dova.JDK.com.sun.source.util;

[JniSignatureAttribute("Lcom/sun/source/util/SourcePositions;", "public abstract interface")]
public partial interface SourcePositions
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SourcePositions()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/SourcePositions;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEndPosition", "(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/Tree;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStartPosition", "(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/Tree;)J"));
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/Tree;)J", "public abstract")]
	long getEndPosition(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.com.sun.source.tree.Tree arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/Tree;)J", "public abstract")]
	long getStartPosition(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.com.sun.source.tree.Tree arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}
}
