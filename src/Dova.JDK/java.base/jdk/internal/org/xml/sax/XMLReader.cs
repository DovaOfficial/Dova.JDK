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

namespace Dova.JDK.jdk.@internal.org.xml.sax;

[JniSignatureAttribute("Ljdk/internal/org/xml/sax/XMLReader;", "public abstract interface")]
public partial interface XMLReader
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/xml/sax/XMLReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/internal/org/xml/sax/InputSource;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setErrorHandler", "(Ljdk/internal/org/xml/sax/ErrorHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEntityResolver", "(Ljdk/internal/org/xml/sax/EntityResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntityResolver", "()Ljdk/internal/org/xml/sax/EntityResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeature", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContentHandler", "(Ljdk/internal/org/xml/sax/ContentHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentHandler", "()Ljdk/internal/org/xml/sax/ContentHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFeature", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorHandler", "()Ljdk/internal/org/xml/sax/ErrorHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDTDHandler", "(Ljdk/internal/org/xml/sax/DTDHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDTDHandler", "()Ljdk/internal/org/xml/sax/DTDHandler;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public abstract")]
	void setProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/InputSource;)V", "public abstract")]
	void parse(Dova.JDK.jdk.@internal.org.xml.sax.InputSource arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void parse(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/ErrorHandler;)V", "public abstract")]
	void setErrorHandler(Dova.JDK.jdk.@internal.org.xml.sax.ErrorHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/EntityResolver;)V", "public abstract")]
	void setEntityResolver(Dova.JDK.jdk.@internal.org.xml.sax.EntityResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/xml/sax/EntityResolver;", "public abstract")]
	Dova.JDK.jdk.@internal.org.xml.sax.EntityResolver getEntityResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.xml.sax.EntityResolver>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public abstract")]
	void setFeature(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/ContentHandler;)V", "public abstract")]
	void setContentHandler(Dova.JDK.jdk.@internal.org.xml.sax.ContentHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/xml/sax/ContentHandler;", "public abstract")]
	Dova.JDK.jdk.@internal.org.xml.sax.ContentHandler getContentHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.xml.sax.ContentHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public abstract")]
	bool getFeature(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/xml/sax/ErrorHandler;", "public abstract")]
	Dova.JDK.jdk.@internal.org.xml.sax.ErrorHandler getErrorHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.xml.sax.ErrorHandler>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/DTDHandler;)V", "public abstract")]
	void setDTDHandler(Dova.JDK.jdk.@internal.org.xml.sax.DTDHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/xml/sax/DTDHandler;", "public abstract")]
	Dova.JDK.jdk.@internal.org.xml.sax.DTDHandler getDTDHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.xml.sax.DTDHandler>(ret);
	}
}
