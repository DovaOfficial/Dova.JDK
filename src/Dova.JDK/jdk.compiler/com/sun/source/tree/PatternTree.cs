/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:22)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.source.tree;

[JniSignatureAttribute("Lcom/sun/source/tree/PatternTree;", "public abstract interface")]
public partial interface PatternTree
	: IJavaObject
	, Dova.JDK.com.sun.source.tree.Tree
	, Dova.JDK.com.sun.source.tree.CaseLabelTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static PatternTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/PatternTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
