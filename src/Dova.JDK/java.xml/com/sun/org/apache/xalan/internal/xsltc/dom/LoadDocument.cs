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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/LoadDocument;", "public final")]
public partial class LoadDocument
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LoadDocument()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/LoadDocument;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMESPACE_FEATURE", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "documentF", "(Ljava/lang/Object;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "documentF", "(Ljava/lang/Object;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "document", "(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "document", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "document", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "document", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Z)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String NAMESPACE_FEATURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LoadDocument(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LoadDocument() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/LoadDocument;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator documentF(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator documentF(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet arg3, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator document(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator document(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator document(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Z)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator document(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}
}
