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

namespace Dova.JDK.jdk.@internal.util.xml.impl;

[JniSignatureAttribute("Ljdk/internal/util/xml/impl/SAXParserImpl;", "public")]
public partial class SAXParserImpl
	: Dova.JDK.jdk.@internal.util.xml.SAXParser
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SAXParserImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/xml/impl/SAXParserImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parser", "Ljdk/internal/util/xml/impl/ParserSAX;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/io/InputStream;Ljdk/internal/org/xml/sax/helpers/DefaultHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/internal/org/xml/sax/InputSource;Ljdk/internal/org/xml/sax/helpers/DefaultHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMLReader", "()Ljdk/internal/org/xml/sax/XMLReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValidating", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamespaceAware", "()Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/util/xml/impl/ParserSAX;", "private")]
	public Dova.JDK.jdk.@internal.util.xml.impl.ParserSAX parser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.util.xml.impl.ParserSAX>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SAXParserImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SAXParserImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/util/xml/impl/SAXParserImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljdk/internal/org/xml/sax/helpers/DefaultHandler;)V", "public")]
	public void parse(Dova.JDK.java.io.InputStream arg0, Dova.JDK.jdk.@internal.org.xml.sax.helpers.DefaultHandler arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/InputSource;Ljdk/internal/org/xml/sax/helpers/DefaultHandler;)V", "public")]
	public void parse(Dova.JDK.jdk.@internal.org.xml.sax.InputSource arg0, Dova.JDK.jdk.@internal.org.xml.sax.helpers.DefaultHandler arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/xml/sax/XMLReader;", "public")]
	public Dova.JDK.jdk.@internal.org.xml.sax.XMLReader getXMLReader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.xml.sax.XMLReader>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isValidating()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNamespaceAware()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}
}
