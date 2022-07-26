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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public abstract interface")]
public partial interface Grammar
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Grammar()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammarDescription", "()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;"));
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription getGrammarDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription>(ret);
	}
}
