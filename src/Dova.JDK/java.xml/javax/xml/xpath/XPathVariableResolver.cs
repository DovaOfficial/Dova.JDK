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

namespace Dova.JDK.javax.xml.xpath;

[JniSignatureAttribute("Ljavax/xml/xpath/XPathVariableResolver;", "public abstract interface")]
public partial interface XPathVariableResolver
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPathVariableResolver()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/xpath/XPathVariableResolver;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveVariable", "(Ljavax/xml/namespace/QName;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(Ljavax/xml/namespace/QName;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object resolveVariable(Dova.JDK.javax.xml.@namespace.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
