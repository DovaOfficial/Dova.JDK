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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDValidator;", "public")]
public partial class XMLDTDValidator
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLComponent
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentFilter
	, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLDTDValidatorFilter
	, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.RevalidationHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLDTDValidator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDValidator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMESPACES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALIDATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DYNAMIC_VALIDATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BALANCE_SYNTAX_TREES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARN_ON_DUPLICATE_ATTDEF", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARSER_SETTINGS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYMBOL_TABLE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR_REPORTER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GRAMMAR_POOL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DATATYPE_VALIDATOR_FACTORY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALIDATION_MANAGER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECOGNIZED_FEATURES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FEATURE_DEFAULTS", "[Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECOGNIZED_PROPERTIES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPERTY_DEFAULTS", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_ATTRIBUTES", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_ELEMENT_CHILDREN", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidationManager", "Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidationState", "Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespaces", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDTDValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDynamicValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fBalanceSyntaxTrees", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fWarnDuplicateAttdef", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fErrorReporter", "Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarPool", "Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarBucket", "Lcom/sun/org/apache/xerces/internal/impl/dtd/DTDGrammarBucket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocLocation", "Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespaceContext", "Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDatatypeValidatorFactory", "Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocumentHandler", "Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocumentSource", "Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDTDGrammar", "Lcom/sun/org/apache/xerces/internal/impl/dtd/DTDGrammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSeenDoctypeDecl", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPerformValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSchemaType", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrentElement", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrentElementIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrentContentSpecType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRootElement", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fInCDATASection", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElementIndexStack", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fContentSpecTypeStack", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElementQNamePartsStack", "[Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElementChildren", "[Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElementChildrenLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElementChildrenOffsetStack", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElementDepth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSeenRootElement", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fInElementContent", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTempElementDecl", "Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLElementDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTempAttDecl", "Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLAttributeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEntityDecl", "Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLEntityDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTempQName", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fBuffer", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValID", "Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValIDRef", "Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValIDRefs", "Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValENTITY", "Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValENTITIES", "Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValNMTOKEN", "Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValNMTOKENS", "Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValNOTATION", "Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "comment", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLComponentManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSpace", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emptyElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "xmlDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doctypeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startGeneralEntity", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "textDecl", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endGeneralEntity", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentHandler", "()Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startNamespaceScope", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endNamespaceScope", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "charDataInContent", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExternalEntityRefInAttrValue", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateDTDattribute", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLAttributeDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rootElementSpecified", "(Lcom/sun/org/apache/xerces/internal/xni/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDTDDefaultAttrsAndValidate", "(Lcom/sun/org/apache/xerces/internal/xni/QName;ILcom/sun/org/apache/xerces/internal/xni/XMLAttributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkContent", "(I[Lcom/sun/org/apache/xerces/internal/xni/QName;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidStandaloneAttDef", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/QName;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammarBucket", "()Lcom/sun/org/apache/xerces/internal/impl/dtd/DTDGrammarBucket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startCDATA", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endCDATA", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocumentSource", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentSource", "()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characterData", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasGrammar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleStartElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeTypeName", "(Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLAttributeDecl;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizeAttrValue", "(Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureStackCapacity", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocumentHandler", "(Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecognizedFeatures", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecognizedProperties", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFeatureDefault", "(Ljava/lang/String;)Ljava/lang/Boolean;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyDefault", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeature", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDocument", "(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endDocument", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignorableWhitespace", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processingInstruction", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characters", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleEndElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;Z)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String NAMESPACES_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String VALIDATION_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String DYNAMIC_VALIDATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String BALANCE_SYNTAX_TREES_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String WARN_ON_DUPLICATE_ATTDEF_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String PARSER_SETTINGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String SYMBOL_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ERROR_REPORTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String GRAMMAR_POOL_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String DATATYPE_VALIDATOR_FACTORY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String VALIDATION_MANAGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> RECOGNIZED_FEATURES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Boolean;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.Boolean> FEATURE_DEFAULTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Boolean>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> RECOGNIZED_PROPERTIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.Object> PROPERTY_DEFAULTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_ATTRIBUTES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_ELEMENT_CHILDREN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationManager;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationManager fValidationManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationState;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationState fValidationState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fNamespaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fDTDValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fDynamicValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fBalanceSyntaxTrees_Property
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

	[JniSignatureAttribute("Z", "protected")]
	public bool fWarnDuplicateAttdef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter fErrorReporter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool fGrammarPool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/DTDGrammarBucket;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.DTDGrammarBucket fGrammarBucket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.DTDGrammarBucket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator fDocLocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext fNamespaceContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DTDDVFactory fDatatypeValidatorFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DTDDVFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler fDocumentHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource fDocumentSource_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/DTDGrammar;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.DTDGrammar fDTDGrammar_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.DTDGrammar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fSeenDoctypeDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fPerformValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fSchemaType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fCurrentElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fCurrentElementIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fCurrentContentSpecType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fRootElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fInCDATASection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> fElementIndexStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> fContentSpecTypeStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xni/QName;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName> fElementQNamePartsStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xni/QName;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName> fElementChildren_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fElementChildrenLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[47]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[47], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> fElementChildrenOffsetStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fElementDepth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fSeenRootElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[50]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[50], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fInElementContent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[51]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[51], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLElementDecl;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLElementDecl fTempElementDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLElementDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLAttributeDecl;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLAttributeDecl fTempAttDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLAttributeDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLEntityDecl;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLEntityDecl fEntityDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLEntityDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fTempQName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private final")]
	public Dova.JDK.java.lang.StringBuilder fBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator fValID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator fValIDRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator fValIDRefs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator fValENTITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator fValENTITIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator fValNMTOKEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator fValNMTOKENS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator fValNOTATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLDTDValidator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLDTDValidator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDValidator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public final")]
	public bool validate()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void init()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void comment(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLComponentManager;)V", "public")]
	public void reset(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLComponentManager arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(I)Z", "protected")]
	public bool isSpace(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void emptyElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void xmlDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void doctypeDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startGeneralEntity(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLResourceIdentifier arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void textDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endGeneralEntity(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler getDocumentHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "protected")]
	public void startNamespaceScope(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;Z)V", "protected")]
	public void endNamespaceScope(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "private")]
	public void charDataInContent()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getExternalEntityRefInAttrValue(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLAttributeDecl;)V", "protected")]
	public void validateDTDattribute(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLAttributeDecl arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;)V", "private final")]
	public void rootElementSpecified(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;ILcom/sun/org/apache/xerces/internal/xni/XMLAttributes;)V", "protected")]
	public void addDTDDefaultAttrsAndValidate(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, int arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I[Lcom/sun/org/apache/xerces/internal/xni/QName;II)I", "private")]
	public int checkContent(int arg0, JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/QName;)Z", "protected")]
	public bool invalidStandaloneAttDef(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/dtd/DTDGrammarBucket;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.DTDGrammarBucket getGrammarBucket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.DTDGrammarBucket>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startCDATA(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endCDATA(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
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

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Z", "public")]
	public bool characterData(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool hasGrammar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Z", "protected")]
	public bool handleStartElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLAttributeDecl;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getAttributeTypeName(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLAttributeDecl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;I)Z", "private")]
	public bool normalizeAttrValue(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void ensureStackCapacity(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;)V", "public")]
	public void setDocumentHandler(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getRecognizedFeatures()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getRecognizedProperties()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Boolean;", "public")]
	public Dova.JDK.java.lang.Boolean getFeatureDefault(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getPropertyDefault(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
	public void setFeature(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void ignorableWhitespace(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void processingInstruction(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void characters(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;Z)V", "protected")]
	public void handleEndElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}
}
