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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.dom;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer;", "public")]
public partial class DOMNormalizer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMNormalizer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_ND", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_EVENTS", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fConfiguration", "Lcom/sun/org/apache/xerces/internal/dom/DOMConfigurationImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocument", "Lcom/sun/org/apache/xerces/internal/dom/CoreDocumentImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAttrProxy", "Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer$XMLAttributesProxy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fQName", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidationHandler", "Lcom/sun/org/apache/xerces/internal/impl/RevalidationHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fErrorHandler", "Lorg/w3c/dom/DOMErrorHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fError", "Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespaceValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPSVI", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespaceContext", "Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocalNSBinder", "Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAttributeList", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocator", "Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrentNode", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAttrQName", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNormalizedValue", "Lcom/sun/org/apache/xerces/internal/xni/XMLString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDTDValidator", "Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_STRING", "Lcom/sun/org/apache/xerces/internal/xni/XMLString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAllWhitespace", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "comment", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandEntityRef", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDTD", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizeNode", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reportDOMError", "(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Ljava/lang/String;SLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "namespaceFixUp", "(Lcom/sun/org/apache/xerces/internal/dom/ElementImpl;Lcom/sun/org/apache/xerces/internal/dom/AttributeMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAttrValueWF", "(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Lorg/w3c/dom/NamedNodeMap;Lorg/w3c/dom/Attr;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateQName", "(Lorg/w3c/dom/Node;Lcom/sun/org/apache/xerces/internal/xni/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isCommentWF", "(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isXMLCharWF", "(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isCDataWF", "(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNamespaceDecl", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/dom/ElementImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizeAttributeValue", "(Ljava/lang/String;Lorg/w3c/dom/Attr;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startGeneralEntity", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endGeneralEntity", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDocument", "(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emptyElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignorableWhitespace", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "xmlDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doctypeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startCDATA", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endCDATA", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endDocument", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocumentSource", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentSource", "()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizeDocument", "(Lcom/sun/org/apache/xerces/internal/dom/CoreDocumentImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMConfigurationImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characters", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "textDecl", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processingInstruction", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
	}

	[JniSignatureAttribute("Z", "protected static final")]
	public static bool DEBUG_ND_Property
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

	[JniSignatureAttribute("Z", "protected static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "protected static final")]
	public static bool DEBUG_EVENTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String PREFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DOMConfigurationImpl;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMConfigurationImpl fConfiguration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMConfigurationImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/CoreDocumentImpl;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.CoreDocumentImpl fDocument_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.CoreDocumentImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer$XMLAttributesProxy;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMNormalizer.XMLAttributesProxy fAttrProxy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMNormalizer.XMLAttributesProxy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fQName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/RevalidationHandler;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.RevalidationHandler fValidationHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.RevalidationHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/DOMErrorHandler;", "protected")]
	public Dova.JDK.org.w3c.dom.DOMErrorHandler fErrorHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMErrorHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMErrorImpl fError_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMErrorImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fNamespaceValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fPSVI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext fNamespaceContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext fLocalNSBinder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "protected final")]
	public Dova.JDK.java.util.List fAttributeList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMLocatorImpl fLocator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMLocatorImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "protected")]
	public Dova.JDK.org.w3c.dom.Node fCurrentNode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fAttrQName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLString;", "final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString fNormalizedValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDValidator;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLDTDValidator fDTDValidator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLDTDValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLString;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString EMPTY_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fAllWhitespace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DOMNormalizer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DOMNormalizer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void comment(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V", "protected final")]
	public void expandEntityRef(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Node arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void processDTD(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", "protected")]
	public Dova.JDK.org.w3c.dom.Node normalizeNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Ljava/lang/String;SLjava/lang/String;)V", "public static final")]
	public static void reportDOMError(Dova.JDK.org.w3c.dom.DOMErrorHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMErrorImpl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMLocatorImpl arg2, Dova.JDK.java.lang.String arg3, short arg4, Dova.JDK.java.lang.String arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/dom/ElementImpl;Lcom/sun/org/apache/xerces/internal/dom/AttributeMap;)V", "protected final")]
	public void namespaceFixUp(Dova.JDK.com.sun.org.apache.xerces.@internal.dom.ElementImpl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.AttributeMap arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Lorg/w3c/dom/NamedNodeMap;Lorg/w3c/dom/Attr;Ljava/lang/String;Z)V", "public static final")]
	public static void isAttrValueWF(Dova.JDK.org.w3c.dom.DOMErrorHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMErrorImpl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMLocatorImpl arg2, Dova.JDK.org.w3c.dom.NamedNodeMap arg3, Dova.JDK.org.w3c.dom.Attr arg4, Dova.JDK.java.lang.String arg5, bool arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lcom/sun/org/apache/xerces/internal/xni/QName;)V", "protected final")]
	public void updateQName(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Ljava/lang/String;Z)V", "public static final")]
	public static void isCommentWF(Dova.JDK.org.w3c.dom.DOMErrorHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMErrorImpl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMLocatorImpl arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Ljava/lang/String;Z)V", "public static final")]
	public static void isXMLCharWF(Dova.JDK.org.w3c.dom.DOMErrorHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMErrorImpl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMLocatorImpl arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DOMErrorHandler;Lcom/sun/org/apache/xerces/internal/dom/DOMErrorImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMLocatorImpl;Ljava/lang/String;Z)V", "public static final")]
	public static void isCDataWF(Dova.JDK.org.w3c.dom.DOMErrorHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMErrorImpl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMLocatorImpl arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/dom/ElementImpl;)V", "protected final")]
	public void addNamespaceDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.ElementImpl arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/w3c/dom/Attr;)Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String normalizeAttributeValue(Dova.JDK.java.lang.String arg0, Dova.JDK.org.w3c.dom.Attr arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startGeneralEntity(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLResourceIdentifier arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endGeneralEntity(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void emptyElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void ignorableWhitespace(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void xmlDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void doctypeDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startCDATA(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endCDATA(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;)V", "public")]
	public void setDocumentSource(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource getDocumentSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/dom/CoreDocumentImpl;Lcom/sun/org/apache/xerces/internal/dom/DOMConfigurationImpl;)V", "protected")]
	public void normalizeDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.dom.CoreDocumentImpl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMConfigurationImpl arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void characters(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void textDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void processingInstruction(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer$XMLAttributesProxy;", "protected final")]
	public partial class XMLAttributesProxy
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XMLAttributesProxy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer$XMLAttributesProxy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAttributes", "Lcom/sun/org/apache/xerces/internal/dom/AttributeMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocument", "Lcom/sun/org/apache/xerces/internal/dom/CoreDocumentImpl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElement", "Lcom/sun/org/apache/xerces/internal/dom/ElementImpl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDTDTypes", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAugmentations", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(ILcom/sun/org/apache/xerces/internal/xni/QName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setName", "(ILcom/sun/org/apache/xerces/internal/xni/QName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(ILjava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLString;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "(Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttribute", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/String;Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReportableType", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributes", "(Lcom/sun/org/apache/xerces/internal/dom/AttributeMap;Lcom/sun/org/apache/xerces/internal/dom/CoreDocumentImpl;Lcom/sun/org/apache/xerces/internal/dom/ElementImpl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalName", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrefix", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType", "(ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAugmentations", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAugmentations", "(I)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAugmentations", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAllAttributes", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAttributeAt", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURI", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQName", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifiedName", "(I)Lcom/sun/org/apache/xerces/internal/xni/QName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNonNormalizedValue", "(ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNonNormalizedValue", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSpecified", "(IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSpecified", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAugmentations", "(ILcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/AttributeMap;", "protected")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.AttributeMap fAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.AttributeMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/CoreDocumentImpl;", "protected")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.CoreDocumentImpl fDocument_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.CoreDocumentImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/ElementImpl;", "protected")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.ElementImpl fElement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.ElementImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "protected")]
		public Dova.JDK.java.util.Vector fDTDTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "protected")]
		public Dova.JDK.java.util.Vector fAugmentations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMNormalizer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMNormalizer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XMLAttributesProxy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer;)V", "protected")]
		public XMLAttributesProxy(Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DOMNormalizer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/dom/DOMNormalizer$XMLAttributesProxy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILcom/sun/org/apache/xerces/internal/xni/QName;)V", "public")]
		public void getName(int arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getValue(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getValue(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getValue(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/org/apache/xerces/internal/xni/QName;)V", "public")]
		public void setName(int arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLString;)V", "public")]
		public void setValue(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
		public void setValue(int arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getType(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getType(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
		public int getIndex(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
		public int getIndex(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/String;Ljava/lang/String;)I", "public")]
		public int addAttribute(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getReportableType(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/dom/AttributeMap;Lcom/sun/org/apache/xerces/internal/dom/CoreDocumentImpl;Lcom/sun/org/apache/xerces/internal/dom/ElementImpl;)V", "public")]
		public void setAttributes(Dova.JDK.com.sun.org.apache.xerces.@internal.dom.AttributeMap arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.CoreDocumentImpl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.ElementImpl arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getLocalName(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getPrefix(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
		public void setType(int arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations getAugmentations(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations getAugmentations(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations getAugmentations(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void removeAllAttributes()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void removeAttributeAt(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getURI(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getQName(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/xni/QName;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName getQualifiedName(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
		public void setNonNormalizedValue(int arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getNonNormalizedValue(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(IZ)V", "public")]
		public void setSpecified(int arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		}

		[JniSignatureAttribute("(I)Z", "public")]
		public bool isSpecified(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return ret;
		}

		[JniSignatureAttribute("(ILcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
		public void setAugmentations(int arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		}
	}
}
