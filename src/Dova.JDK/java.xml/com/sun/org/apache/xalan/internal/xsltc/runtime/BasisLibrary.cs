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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/runtime/BasisLibrary;", "public final")]
public partial class BasisLibrary
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasisLibrary()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/runtime/BasisLibrary;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTYSTRING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "threadLocalStringBuilder", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "threadLocalStringBuffer", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE_FRACTION_DIGITS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "lowerBounds", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "upperBounds", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultFormatter", "Ljava/text/DecimalFormat;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "xpathFormatter", "Ljava/text/DecimalFormat;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultPattern", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_fieldPosition", "Ljava/text/FieldPosition;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_characterArray", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "threadLocalPrefixIndex", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUN_TIME_INTERNAL_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUN_TIME_COPY_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DATA_CONVERSION_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTERNAL_FUNC_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQUALITY_EXPR_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_ARGUMENT_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORMAT_NUMBER_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITERATOR_CLONE_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AXIS_SUPPORT_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPED_AXIS_SUPPORT_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRAY_ATTRIBUTE_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRAY_NAMESPACE_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMESPACE_PREFIX_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOM_ADAPTER_INIT_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARSER_DTD_SUPPORT_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMESPACES_SUPPORT_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CANT_RESOLVE_RELATIVE_URI_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNSUPPORTED_XSL_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNSUPPORTED_EXT_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNKNOWN_TRANSLET_VERSION_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_QNAME_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_NCNAME_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNALLOWED_EXTENSION_FUNCTION_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNALLOWED_EXTENSION_ELEMENT_ERR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "m_bundle", "Ljava/util/ResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR_MESSAGES_KEY", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;DILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Ljava/lang/String;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(ILcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replace", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replace", "(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copy", "(Ljava/lang/Object;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isWhiteSpace", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generatePrefix", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runTimeError", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runTimeError", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runTimeError", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runTimeError", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringF", "(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringF", "(ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringF", "(Ljava/lang/Object;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStringLength", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalize_spaceF", "(ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalize_spaceF", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "namespace_uriF", "(ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "namespace_uriF", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "numberF", "(ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "numberF", "(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareStrings", "(Ljava/lang/String;Ljava/lang/String;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasSimpleType", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "booleanF", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "referenceToNodeSet", "(Ljava/lang/Object;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nodeList2Iterator", "(Lorg/w3c/dom/NodeList;Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countF", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "positionF", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sumF", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "roundF", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "substringF", "(Ljava/lang/String;DD)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "substringF", "(Ljava/lang/String;D)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "substring_afterF", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "substring_beforeF", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "translateF", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generate_idF", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unresolved_externalF", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unallowed_extension_functionF", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unallowed_extension_elementF", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unsupported_ElementF", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "system_propertyF", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "objectTypeF", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nodesetF", "(Ljava/lang/Object;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "testLanguage", "(Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "realToString", "(D)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "realToInt", "(D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "referenceToNodeList", "(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "referenceToNode", "(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "referenceToLong", "(Ljava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "referenceToDouble", "(Ljava/lang/Object;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "referenceToBoolean", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "referenceToString", "(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "node2Iterator", "(Lorg/w3c/dom/Node;Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nodeList2IteratorUsingHandleFromNode", "(Lorg/w3c/dom/NodeList;Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "referenceToResultTree", "(Ljava/lang/Object;)Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSingleNode", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkAttribQName", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkNCName", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "startXslElement", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resetPrefixIndex", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "consoleOutput", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mapQNameToJavaName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringToReal", "(Ljava/lang/String;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringToInt", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkQName", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "formatNumber", "(DLjava/lang/String;Ljava/text/DecimalFormat;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLocalName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPrefix", "(Ljava/lang/String;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String EMPTYSTRING_Property
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

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private static final")]
	public static Dova.JDK.java.lang.ThreadLocal threadLocalStringBuilder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private static final")]
	public static Dova.JDK.java.lang.ThreadLocal threadLocalStringBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DOUBLE_FRACTION_DIGITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double lowerBounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double upperBounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljava/text/DecimalFormat;", "private static")]
	public static Dova.JDK.java.text.DecimalFormat defaultFormatter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.DecimalFormat>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/DecimalFormat;", "private static")]
	public static Dova.JDK.java.text.DecimalFormat xpathFormatter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.DecimalFormat>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String defaultPattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/FieldPosition;", "private static")]
	public static Dova.JDK.java.text.FieldPosition _fieldPosition_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.FieldPosition>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[C", "private static")]
	public static JavaArray<char> _characterArray_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private static final")]
	public static Dova.JDK.java.lang.ThreadLocal threadLocalPrefixIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String RUN_TIME_INTERNAL_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String RUN_TIME_COPY_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DATA_CONVERSION_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String EXTERNAL_FUNC_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String EQUALITY_EXPR_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String INVALID_ARGUMENT_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String FORMAT_NUMBER_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ITERATOR_CLONE_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String AXIS_SUPPORT_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String TYPED_AXIS_SUPPORT_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String STRAY_ATTRIBUTE_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String STRAY_NAMESPACE_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NAMESPACE_PREFIX_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DOM_ADAPTER_INIT_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PARSER_DTD_SUPPORT_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NAMESPACES_SUPPORT_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String CANT_RESOLVE_RELATIVE_URI_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String UNSUPPORTED_XSL_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String UNSUPPORTED_EXT_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String UNKNOWN_TRANSLET_VERSION_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String INVALID_QNAME_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String INVALID_NCNAME_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String UNALLOWED_EXTENSION_FUNCTION_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String UNALLOWED_EXTENSION_ELEMENT_ERR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ResourceBundle;", "private static")]
	public static Dova.JDK.java.util.ResourceBundle m_bundle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ERROR_MESSAGES_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasisLibrary(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BasisLibrary() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/runtime/BasisLibrary;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;DILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z", "public static")]
	public static bool compare(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, double arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z", "public static")]
	public static bool compare(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Ljava/lang/String;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z", "public static")]
	public static bool compare(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z", "public static")]
	public static bool compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z", "public static")]
	public static bool compare(int arg0, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String replace(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String replace(Dova.JDK.java.lang.String arg0, char arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)V", "public static")]
	public static void copy(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(C)Z", "private static")]
	public static bool isWhiteSpace(char arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String generatePrefix()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public static")]
	public static void runTimeError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public static")]
	public static void runTimeError(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void runTimeError(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "public static")]
	public static void runTimeError(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String stringF(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String stringF(int arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String stringF(Dova.JDK.java.lang.Object arg0, int arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public static")]
	public static int getStringLength(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String normalize_spaceF(int arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String normalize_spaceF(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String namespace_uriF(int arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String namespace_uriF(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)D", "public static")]
	public static double numberF(int arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)D", "public static")]
	public static double numberF(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ILcom/sun/org/apache/xalan/internal/xsltc/DOM;)Z", "private static")]
	public static bool compareStrings(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "private static")]
	public static bool hasSimpleType(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public static")]
	public static bool booleanF(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator referenceToNodeSet(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator nodeList2Iterator(Dova.JDK.org.w3c.dom.NodeList arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)I", "public static")]
	public static int countF(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)I", "public static")]
	public static int positionF(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)D", "public static")]
	public static double sumF(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public static")]
	public static double roundF(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;DD)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String substringF(Dova.JDK.java.lang.String arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;D)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String substringF(Dova.JDK.java.lang.String arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String substring_afterF(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String substring_beforeF(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String translateF(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String generate_idF(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void unresolved_externalF(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void unallowed_extension_functionF(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void unallowed_extension_elementF(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public static")]
	public static void unsupported_ElementF(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String system_propertyF(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String objectTypeF(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator nodesetF(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;I)Z", "public static")]
	public static bool testLanguage(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(D)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String realToString(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(D)I", "public static")]
	public static int realToInt(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList referenceToNodeList(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lorg/w3c/dom/Node;", "public static")]
	public static Dova.JDK.org.w3c.dom.Node referenceToNode(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)J", "public static")]
	public static long referenceToLong(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[51], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)D", "public static")]
	public static double referenceToDouble(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[52], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public static")]
	public static bool referenceToBoolean(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[53], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String referenceToString(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator node2Iterator(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator nodeList2IteratorUsingHandleFromNode(Dova.JDK.org.w3c.dom.NodeList arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM referenceToResultTree(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getSingleNode(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void checkAttribQName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void checkNCName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String startXslElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void resetPrefixIndex()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[62]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void consoleOutput(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String mapQNameToJavaName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)D", "public static")]
	public static double stringToReal(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[65], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public static")]
	public static int stringToInt(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[66], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void checkQName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(DLjava/lang/String;Ljava/text/DecimalFormat;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String formatNumber(double arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.text.DecimalFormat arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getLocalName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[69], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getPrefix(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[70], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
