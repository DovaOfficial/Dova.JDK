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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/ref/CoroutineParser;", "public abstract interface")]
public partial interface CoroutineParser
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CoroutineParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/dtm/ref/CoroutineParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lcom/sun/org/apache/xml/internal/dtm/ref/CoroutineManager;ILorg/xml/sax/XMLReader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLexHandler", "(Lorg/xml/sax/ext/LexicalHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doParse", "(Lorg/xml/sax/InputSource;I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParserCoroutineID", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCoroutineManager", "()Lcom/sun/org/apache/xml/internal/dtm/ref/CoroutineManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMore", "(ZI)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doTerminate", "(I)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/ref/CoroutineManager;ILorg/xml/sax/XMLReader;)V", "public abstract")]
	void init(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref.CoroutineManager arg0, int arg1, Dova.JDK.org.xml.sax.XMLReader arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/ContentHandler;)V", "public abstract")]
	void setContentHandler(Dova.JDK.org.xml.sax.ContentHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/ext/LexicalHandler;)V", "public abstract")]
	void setLexHandler(Dova.JDK.org.xml.sax.ext.LexicalHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/InputSource;I)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object doParse(Dova.JDK.org.xml.sax.InputSource arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getParserCoroutineID()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/dtm/ref/CoroutineManager;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref.CoroutineManager getCoroutineManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref.CoroutineManager>(ret);
	}

	[JniSignatureAttribute("(ZI)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object doMore(bool arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void doTerminate(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}
}
