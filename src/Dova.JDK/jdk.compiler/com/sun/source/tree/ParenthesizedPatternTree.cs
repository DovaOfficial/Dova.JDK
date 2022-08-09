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

[JniSignatureAttribute("Lcom/sun/source/tree/ParenthesizedPatternTree;", "public abstract interface")]
public partial interface ParenthesizedPatternTree
	: IJavaObject
	, Dova.JDK.com.sun.source.tree.PatternTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ParenthesizedPatternTree()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/source/tree/ParenthesizedPatternTree;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPattern", "()Lcom/sun/source/tree/PatternTree;"));
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/PatternTree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.PatternTree getPattern()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.PatternTree>(ret);
	}
}