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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/XPathFactory;", "public abstract interface")]
public partial interface XPathFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPathFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/XPathFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;I)Lcom/sun/org/apache/xpath/internal/XPath;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;I)Lcom/sun/org/apache/xpath/internal/XPath;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xpath.@internal.XPath create(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.transform.SourceLocator arg1, Dova.JDK.com.sun.org.apache.xml.@internal.utils.PrefixResolver arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.XPath>(ret);
	}
}
