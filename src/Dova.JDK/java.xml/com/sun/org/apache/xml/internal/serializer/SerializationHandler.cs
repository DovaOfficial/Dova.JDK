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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.serializer;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;", "public abstract interface")]
public partial interface SerializationHandler
	: IJavaObject
	, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.ExtendedContentHandler
	, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.ExtendedLexicalHandler
	, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.XSLOutputAttributes
	, Dova.JDK.org.xml.sax.ext.DeclHandler
	, Dova.JDK.org.xml.sax.DTDHandler
	, Dova.JDK.org.xml.sax.ErrorHandler
	, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.DOMSerializer
	, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.Serializer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SerializationHandler()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "serialize", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTransformer", "()Ljavax/xml/transform/Transformer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setEscaping", "(Z)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setIndentAmount", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setIsStandalone", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setTransformer", "(Ljavax/xml/transform/Transformer;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "flushPending", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setNamespaceMappings", "(Lcom/sun/org/apache/xml/internal/serializer/NamespaceMappings;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDTDEntityExpansion", "(Z)V"));
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void close()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void serialize(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/ContentHandler;)V", "public abstract")]
	void setContentHandler(Dova.JDK.org.xml.sax.ContentHandler arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/transform/Transformer;", "public abstract")]
	Dova.JDK.javax.xml.transform.Transformer getTransformer()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.Transformer>(ret);
	}

	[JniSignatureAttribute("(Z)Z", "public abstract")]
	bool setEscaping(bool arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void setIndentAmount(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public abstract")]
	void setIsStandalone(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Transformer;)V", "public abstract")]
	void setTransformer(Dova.JDK.javax.xml.transform.Transformer arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void flushPending()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/serializer/NamespaceMappings;)V", "public abstract")]
	void setNamespaceMappings(Dova.JDK.com.sun.org.apache.xml.@internal.serializer.NamespaceMappings arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public abstract")]
	void setDTDEntityExpansion(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}
}