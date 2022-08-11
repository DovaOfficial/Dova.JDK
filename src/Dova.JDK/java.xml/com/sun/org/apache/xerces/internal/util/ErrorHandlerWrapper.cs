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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.util;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/ErrorHandlerWrapper;", "public")]
public partial class ErrorHandlerWrapper
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLErrorHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ErrorHandlerWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/util/ErrorHandlerWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fErrorHandler", "Lorg/xml/sax/ErrorHandler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/xml/sax/ErrorHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warning", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createXMLParseException", "(Lorg/xml/sax/SAXParseException;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSAXParseException", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;)Lorg/xml/sax/SAXParseException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createXNIException", "(Lorg/xml/sax/SAXException;)Lcom/sun/org/apache/xerces/internal/xni/XNIException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fatalError", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;"));
	}

	[JniSignatureAttribute("Lorg/xml/sax/ErrorHandler;", "protected")]
	public Dova.JDK.org.xml.sax.ErrorHandler fErrorHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.ErrorHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ErrorHandlerWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ErrorHandlerWrapper() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lorg/xml/sax/ErrorHandler;)V", "public")]
	public ErrorHandlerWrapper(Dova.JDK.org.xml.sax.ErrorHandler arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/util/ErrorHandlerWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;)V", "public")]
	public void error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLParseException arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;)V", "public")]
	public void warning(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLParseException arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/ErrorHandler;)V", "public")]
	public void setErrorHandler(Dova.JDK.org.xml.sax.ErrorHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/SAXParseException;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;", "protected static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLParseException createXMLParseException(Dova.JDK.org.xml.sax.SAXParseException arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLParseException>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;)Lorg/xml/sax/SAXParseException;", "protected static")]
	public static Dova.JDK.org.xml.sax.SAXParseException createSAXParseException(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLParseException arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.SAXParseException>(ret);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/SAXException;)Lcom/sun/org/apache/xerces/internal/xni/XNIException;", "protected static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XNIException createXNIException(Dova.JDK.org.xml.sax.SAXException arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XNIException>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;)V", "public")]
	public void fatalError(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLParseException arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Lorg/xml/sax/ErrorHandler;", "public")]
	public Dova.JDK.org.xml.sax.ErrorHandler getErrorHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.ErrorHandler>(ret);
	}
}
