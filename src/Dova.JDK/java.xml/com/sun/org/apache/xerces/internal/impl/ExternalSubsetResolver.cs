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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/ExternalSubsetResolver;", "public abstract interface")]
public partial interface ExternalSubsetResolver
	: IJavaObject
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExternalSubsetResolver()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/ExternalSubsetResolver;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExternalSubset", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLDTDDescription;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLDTDDescription;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource getExternalSubset(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLDTDDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource>(ret);
	}
}
