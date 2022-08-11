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

[JniSignatureAttribute("Lcom/sun/tools/javac/tree/EndPosTable;", "public abstract interface")]
public partial interface EndPosTable
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EndPosTable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/EndPosTable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPos", "(Lcom/sun/tools/javac/tree/JCTree;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeEnd", "(Lcom/sun/tools/javac/tree/JCTree;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceTree", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;)I"));
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)I", "public abstract")]
	int getEndPos(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;I)V", "public abstract")]
	void storeEnd(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;)I", "public abstract")]
	int replaceTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}
}
