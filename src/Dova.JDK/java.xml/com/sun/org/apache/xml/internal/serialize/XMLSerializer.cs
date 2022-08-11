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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.serialize;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serialize/XMLSerializer;", "public")]
public partial class XMLSerializer
	: Dova.JDK.com.sun.org.apache.xml.@internal.serialize.BaseMarkupSerializer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLSerializer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/serialize/XMLSerializer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNSBinder", "Lcom/sun/org/apache/xerces/internal/util/NamespaceSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocalNSBinder", "Lcom/sun/org/apache/xerces/internal/util/NamespaceSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespaces", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespacePrefixes", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPreserveSpace", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/OutputStream;Lcom/sun/org/apache/xml/internal/serialize/OutputFormat;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/Writer;Lcom/sun/org/apache/xml/internal/serialize/OutputFormat;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xml/internal/serialize/OutputFormat;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printEscaped", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutputFormat", "(Lcom/sun/org/apache/xml/internal/serialize/OutputFormat;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printAttribute", "(Ljava/lang/String;Ljava/lang/String;ZLorg/w3c/dom/Attr;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printText", "([CIIZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printText", "(Ljava/lang/String;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractNamespaces", "(Lorg/xml/sax/Attributes;)Lorg/xml/sax/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElementIO", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printNamespaceAttr", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printXMLChar", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkUnboundNamespacePrefixedNode", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNamespaces", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializeElement", "(Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntityRef", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDocument", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Z", "protected static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/NamespaceSupport;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.NamespaceSupport fNSBinder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.NamespaceSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/NamespaceSupport;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.NamespaceSupport fLocalNSBinder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.NamespaceSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String PREFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fNamespaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fNamespacePrefixes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fPreserveSpace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLSerializer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;Lcom/sun/org/apache/xml/internal/serialize/OutputFormat;)V", "public")]
	public XMLSerializer(Dova.JDK.java.io.OutputStream arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serialize.OutputFormat arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Lcom/sun/org/apache/xml/internal/serialize/OutputFormat;)V", "public")]
	public XMLSerializer(Dova.JDK.java.io.Writer arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serialize.OutputFormat arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/serialize/OutputFormat;)V", "public")]
	public XMLSerializer(Dova.JDK.com.sun.org.apache.xml.@internal.serialize.OutputFormat arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLSerializer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/serialize/XMLSerializer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool reset()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void printEscaped(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/serialize/OutputFormat;)V", "public")]
	public void setOutputFormat(Dova.JDK.com.sun.org.apache.xml.@internal.serialize.OutputFormat arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ZLorg/w3c/dom/Attr;)V", "private")]
	public void printAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.org.w3c.dom.Attr arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([CIIZZ)V", "protected")]
	public void printText(JavaArray<char> arg0, int arg1, int arg2, bool arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZZ)V", "protected")]
	public void printText(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/Attributes;)Lorg/xml/sax/Attributes;", "private")]
	public Dova.JDK.org.xml.sax.Attributes extractNamespaces(Dova.JDK.org.xml.sax.Attributes arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void endElementIO(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void printNamespaceAttr(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void printXMLChar(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "protected")]
	public void checkUnboundNamespacePrefixedNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setNamespaces(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "protected")]
	public void serializeElement(Dova.JDK.org.w3c.dom.Element arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getEntityRef(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void startDocument(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", "public")]
	public void startElement(Dova.JDK.java.lang.String arg0, Dova.JDK.org.xml.sax.AttributeList arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", "public")]
	public void startElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.org.xml.sax.Attributes arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void endElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void endElement(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}
}
