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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.serializer;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/DOM3Serializer;", "public abstract interface")]
public partial interface DOM3Serializer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOM3Serializer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/serializer/DOM3Serializer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setErrorHandler", "(Lorg/w3c/dom/DOMErrorHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorHandler", "()Lorg/w3c/dom/DOMErrorHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializeDOM3", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNodeFilter", "(Lorg/w3c/dom/ls/LSSerializerFilter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeFilter", "()Lorg/w3c/dom/ls/LSSerializerFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNewLine", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DOMErrorHandler;)V", "public abstract")]
	void setErrorHandler(Dova.JDK.org.w3c.dom.DOMErrorHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DOMErrorHandler;", "public abstract")]
	Dova.JDK.org.w3c.dom.DOMErrorHandler getErrorHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMErrorHandler>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void serializeDOM3(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/ls/LSSerializerFilter;)V", "public abstract")]
	void setNodeFilter(Dova.JDK.org.w3c.dom.ls.LSSerializerFilter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ls/LSSerializerFilter;", "public abstract")]
	Dova.JDK.org.w3c.dom.ls.LSSerializerFilter getNodeFilter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ls.LSSerializerFilter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void setNewLine(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}
