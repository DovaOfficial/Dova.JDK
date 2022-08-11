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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/AdaptiveResultTreeImpl;", "public")]
public partial class AdaptiveResultTreeImpl
	: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.SimpleResultTreeImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AdaptiveResultTreeImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/AdaptiveResultTreeImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_documentURIIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_STRING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_dom", "Lcom/sun/org/apache/xalan/internal/xsltc/dom/SAXImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_wsfilter", "Lcom/sun/org/apache/xml/internal/dtm/DTMWSFilter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_initSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_buildIdIndex", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_attributes", "Lorg/xml/sax/helpers/AttributesImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_openElementName", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/dom/XSLTCDTMManager;ILcom/sun/org/apache/xml/internal/dtm/DTMWSFilter;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParent", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "comment", "([CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "comment", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIterator", "()Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(ILcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "release", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLanguage", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNode", "(I)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLevel", "(I)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFilter", "(Lcom/sun/org/apache/xalan/internal/xsltc/StripFilter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildren", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAttribute", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "namespaceAfterStartElement", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addUniqueAttribute", "(Ljava/lang/String;Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupNamespace", "(ILjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEscaping", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentRoot", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceType", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeIdent", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeHandle", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isElement", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeature", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocument", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypedChildren", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNthDescendant", "(IIZ)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceAxisIterator", "(II)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeValueIterator", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;ILjava/lang/String;Z)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orderNodes", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shallowCopy", "(ILcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNode", "(I)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNode", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNodeList", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNodeList", "(I)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setupMapping", "([Ljava/lang/String;[Ljava/lang/String;[I[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResultTreeFrag", "(II)Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputDomBuilder", "()Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNSType", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementsWithIDs", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringValueX", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNodeAfter", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpandedTypeID", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpandedTypeID", "(Ljava/lang/String;Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAxisTraverser", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisTraverser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAxisIterator", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypedAxisIterator", "(II)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstAttribute", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstNamespaceNode", "(IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextAttribute", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextNamespaceNode", "(IIZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringValueChunkCount", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringValueChunk", "(II[I)[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalNameFromExpandedNameID", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceFromExpandedNameID", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocumentBaseURI", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentSystemIdentifier", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentEncoding", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentStandalone", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentVersion", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentAllDeclarationsProcessed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentTypeDeclarationSystemIdentifier", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentTypeDeclarationPublicIdentifier", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsPreStripping", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCharacterElementContentWhitespace", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDocumentAllDeclarationsProcessed", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAttributeSpecified", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchToEvents", "(ILorg/xml/sax/ContentHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsTwoThreads", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLexicalHandler", "()Lorg/xml/sax/ext/LexicalHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclHandler", "()Lorg/xml/sax/ext/DeclHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceLocatorFor", "(I)Ljavax/xml/transform/SourceLocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "documentRegistration", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "documentRelease", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDocument", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endDocument", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maybeEmitStartElement", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareNewDOM", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestedDOM", "()Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentURI", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentHandler", "()Lorg/xml/sax/ContentHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeNameX", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentBaseURI", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnparsedEntityURI", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendTextChild", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lessThan", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characters", "(ILcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characters", "([CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characters", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchCharactersEvents", "(ILorg/xml/sax/ContentHandler;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringValue", "(I)Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringValue", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeType", "(I)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastChild", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreviousSibling", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextSibling", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasChildNodes", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceURI", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrefix", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeNode", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeNode", "(ILjava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerDocument", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendChild", "(IZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstChild", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeValue", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementById", "(Ljava/lang/String;)I"));
	}

	[JniSignatureAttribute("I", "private static")]
	public static int _documentURIIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String EMPTY_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/SAXImpl;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.SAXImpl _dom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.SAXImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/DTMWSFilter;", "private")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMWSFilter _wsfilter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMWSFilter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int _initSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool _buildIdIndex_Property
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

	[JniSignatureAttribute("Lorg/xml/sax/helpers/AttributesImpl;", "private final")]
	public Dova.JDK.org.xml.sax.helpers.AttributesImpl _attributes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.helpers.AttributesImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String _openElementName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AdaptiveResultTreeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/dom/XSLTCDTMManager;ILcom/sun/org/apache/xml/internal/dtm/DTMWSFilter;IZ)V", "public")]
	public AdaptiveResultTreeImpl(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.XSLTCDTMManager arg0, int arg1, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMWSFilter arg2, int arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/AdaptiveResultTreeImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)I", "public")]
	public int getParent(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "public")]
	public bool isSupported(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([CII)V", "public")]
	public void comment(JavaArray<char> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void comment(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getIterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V", "public")]
	public void copy(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V", "public")]
	public void copy(int arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void release()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getLanguage(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node getNode(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void addAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void addAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(I)S", "public")]
	public short getLevel(int arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/StripFilter;)V", "public")]
	public void setFilter(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.StripFilter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getChildren(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isAttribute(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void namespaceAfterStartElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;I)V", "public")]
	public void addUniqueAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String lookupNamespace(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)Z", "public")]
	public bool setEscaping(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getDocumentRoot(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getNamespaceType(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public final")]
	public int getNodeIdent(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public final")]
	public int getNodeHandle(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isElement(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/xml/sax/ErrorHandler;", "public")]
	public Dova.JDK.org.xml.sax.ErrorHandler getErrorHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.ErrorHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
	public void setFeature(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDocument()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getTypedChildren(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(IIZ)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getNthDescendant(int arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(II)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getNamespaceAxisIterator(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;ILjava/lang/String;Z)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getNodeValueIterator(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, int arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator orderNodes(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNamespaceName(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String shallowCopy(int arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node makeNode(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node makeNode(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lorg/w3c/dom/NodeList;", "public")]
	public Dova.JDK.org.w3c.dom.NodeList makeNodeList(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(I)Lorg/w3c/dom/NodeList;", "public")]
	public Dova.JDK.org.w3c.dom.NodeList makeNodeList(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;[Ljava/lang/String;[I[Ljava/lang/String;)V", "public")]
	public void setupMapping(JavaArray<Dova.JDK.java.lang.String> arg0, JavaArray<Dova.JDK.java.lang.String> arg1, JavaArray<int> arg2, JavaArray<Dova.JDK.java.lang.String> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(II)Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM getResultTreeFrag(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler getOutputDomBuilder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getNSType(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getElementsWithIDs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getStringValueX(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool isNodeAfter(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getExpandedTypeID(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;I)I", "public")]
	public int getExpandedTypeID(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisTraverser;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisTraverser getAxisTraverser(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisTraverser>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getAxisIterator(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(II)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator getTypedAxisIterator(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getFirstAttribute(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IZ)I", "public")]
	public int getFirstNamespaceNode(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getNextAttribute(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IIZ)I", "public")]
	public int getNextNamespaceNode(int arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getStringValueChunkCount(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II[I)[C", "public")]
	public JavaArray<char> getStringValueChunk(int arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getLocalNameFromExpandedNameID(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNamespaceFromExpandedNameID(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setDocumentBaseURI(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDocumentSystemIdentifier(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDocumentEncoding(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDocumentStandalone(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDocumentVersion(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getDocumentAllDeclarationsProcessed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[66]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDocumentTypeDeclarationSystemIdentifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDocumentTypeDeclarationPublicIdentifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool supportsPreStripping()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isCharacterElementContentWhitespace(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isDocumentAllDeclarationsProcessed(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isAttributeSpecified(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILorg/xml/sax/ContentHandler;)V", "public")]
	public void dispatchToEvents(int arg0, Dova.JDK.org.xml.sax.ContentHandler arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool needsTwoThreads()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[74]);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/xml/sax/ext/LexicalHandler;", "public")]
	public Dova.JDK.org.xml.sax.ext.LexicalHandler getLexicalHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.ext.LexicalHandler>(ret);
	}

	[JniSignatureAttribute("()Lorg/xml/sax/EntityResolver;", "public")]
	public Dova.JDK.org.xml.sax.EntityResolver getEntityResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.EntityResolver>(ret);
	}

	[JniSignatureAttribute("()Lorg/xml/sax/ext/DeclHandler;", "public")]
	public Dova.JDK.org.xml.sax.ext.DeclHandler getDeclHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.ext.DeclHandler>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/xml/transform/SourceLocator;", "public")]
	public Dova.JDK.javax.xml.transform.SourceLocator getSourceLocatorFor(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.SourceLocator>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void documentRegistration()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void documentRelease()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void startDocument()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endDocument()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", "public")]
	public void startElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.org.xml.sax.Attributes arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void startElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void startElement(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void endElement(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[86], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void endElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void processingInstruction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void maybeEmitStartElement()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void prepareNewDOM()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90]);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM getNestedDOM()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDocumentURI(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lorg/xml/sax/ContentHandler;", "public")]
	public Dova.JDK.org.xml.sax.ContentHandler getContentHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.ContentHandler>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeNameX(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDocumentBaseURI()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUnparsedEntityURI(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void appendTextChild(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool lessThan(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[98], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V", "public")]
	public void characters(int arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1);
	}

	[JniSignatureAttribute("([CII)V", "public")]
	public void characters(JavaArray<char> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void characters(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[101], arg0);
	}

	[JniSignatureAttribute("(ILorg/xml/sax/ContentHandler;Z)V", "public")]
	public void dispatchCharactersEvents(int arg0, Dova.JDK.org.xml.sax.ContentHandler arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[102], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Lorg/xml/sax/DTDHandler;", "public")]
	public Dova.JDK.org.xml.sax.DTDHandler getDTDHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[103]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.DTDHandler>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString getStringValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getStringValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeName(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)S", "public")]
	public short getNodeType(int arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[107], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getLastChild(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[108], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getPreviousSibling(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[109], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getNextSibling(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool hasChildNodes(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[111], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNamespaceURI(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[112], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPrefix(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getLocalName(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int getAttributeNode(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;)I", "public")]
	public int getAttributeNode(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getOwnerDocument(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[117], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IZZ)V", "public")]
	public void appendChild(int arg0, bool arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getFirstChild(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[119], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[120], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int getElementById(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[121], arg0);
		return ret;
	}
}
