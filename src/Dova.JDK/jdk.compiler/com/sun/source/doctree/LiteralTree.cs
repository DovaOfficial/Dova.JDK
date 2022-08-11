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

namespace Dova.JDK.com.sun.source.doctree;

[JniSignatureAttribute("Lcom/sun/source/doctree/LiteralTree;", "public abstract interface")]
public partial interface LiteralTree
	: IJavaObject
	, Dova.JDK.com.sun.source.doctree.InlineTagTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LiteralTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/doctree/LiteralTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Lcom/sun/source/doctree/TextTree;"));
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/TextTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.TextTree getBody()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.TextTree>(ret);
	}
}
