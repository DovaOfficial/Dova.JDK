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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/XSLoader;", "public abstract interface")]
public partial interface XSLoader
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSLoader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/xs/XSLoader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Lorg/w3c/dom/ls/LSInput;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfig", "()Lorg/w3c/dom/DOMConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadURIList", "(Lcom/sun/org/apache/xerces/internal/xs/StringList;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadInputList", "(Lcom/sun/org/apache/xerces/internal/xs/LSInputList;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadURI", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/ls/LSInput;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel load(Dova.JDK.org.w3c.dom.ls.LSInput arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DOMConfiguration;", "public abstract")]
	Dova.JDK.org.w3c.dom.DOMConfiguration getConfig()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMConfiguration>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/StringList;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel loadURIList(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/LSInputList;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel loadInputList(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.LSInputList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel loadURI(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}
}
