/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljavax/xml/xpath/XPath;", "public abstract interface")]
public partial interface XPath
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPath()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/xpath/XPath;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compile", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluate", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluate", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluateExpression", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluateExpression", "(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluateExpression", "(Ljava/lang/String;Ljava/lang/Object;)Ljavax/xml/xpath/XPathEvaluationResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluateExpression", "(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljavax/xml/xpath/XPathEvaluationResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getXPathVariableResolver", "()Ljavax/xml/xpath/XPathVariableResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getXPathFunctionResolver", "()Ljavax/xml/xpath/XPathFunctionResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNamespaceContext", "(Ljavax/xml/namespace/NamespaceContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/xpath/XPathExpression;", "public abstract")]
	Dova.JDK.javax.xml.xpath.XPathExpression compile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathExpression>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String evaluate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String evaluate(Dova.JDK.java.lang.String arg0, Dova.JDK.org.xml.sax.InputSource arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object evaluate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.xml.@namespace.QName arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object evaluate(Dova.JDK.java.lang.String arg0, Dova.JDK.org.xml.sax.InputSource arg1, Dova.JDK.javax.xml.@namespace.QName arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	Dova.JDK.java.lang.Object evaluateExpression(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	Dova.JDK.java.lang.Object evaluateExpression(Dova.JDK.java.lang.String arg0, Dova.JDK.org.xml.sax.InputSource arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljavax/xml/xpath/XPathEvaluationResult;", "public")]
	Dova.JDK.javax.xml.xpath.XPathEvaluationResult evaluateExpression(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljavax/xml/xpath/XPathEvaluationResult;", "public")]
	Dova.JDK.javax.xml.xpath.XPathEvaluationResult evaluateExpression(Dova.JDK.java.lang.String arg0, Dova.JDK.org.xml.sax.InputSource arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/xpath/XPathVariableResolver;)V", "public abstract")]
	void setXPathVariableResolver(Dova.JDK.javax.xml.xpath.XPathVariableResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/xpath/XPathVariableResolver;", "public abstract")]
	Dova.JDK.javax.xml.xpath.XPathVariableResolver getXPathVariableResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathVariableResolver>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/xpath/XPathFunctionResolver;)V", "public abstract")]
	void setXPathFunctionResolver(Dova.JDK.javax.xml.xpath.XPathFunctionResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/xpath/XPathFunctionResolver;", "public abstract")]
	Dova.JDK.javax.xml.xpath.XPathFunctionResolver getXPathFunctionResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathFunctionResolver>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/namespace/NamespaceContext;)V", "public abstract")]
	void setNamespaceContext(Dova.JDK.javax.xml.@namespace.NamespaceContext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/namespace/NamespaceContext;", "public abstract")]
	Dova.JDK.javax.xml.@namespace.NamespaceContext getNamespaceContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.@namespace.NamespaceContext>(ret);
	}
}
