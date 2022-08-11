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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;", "public")]
public partial class XMLSchemaValidator
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLComponent
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentFilter
	, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.FieldActivator
	, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.RevalidationHandler
	, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDeclHelper
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLSchemaValidator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALIDATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEMA_VALIDATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEMA_FULL_CHECKING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DYNAMIC_VALIDATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMALIZE_DATA", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEMA_ELEMENT_DEFAULT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEMA_AUGMENT_PSVI", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALLOW_JAVA_ENCODINGS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STANDARD_URI_CONFORMANT_FEATURE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERATE_SYNTHETIC_ANNOTATIONS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALIDATE_ANNOTATIONS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HONOUR_ALL_SCHEMALOCATIONS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USE_GRAMMAR_POOL_ONLY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTINUE_AFTER_FATAL_ERROR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARSER_SETTINGS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMESPACE_GROWTH", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOLERATE_DUPLICATES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_XSI_TYPE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID_IDREF_CHECKING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNPARSED_ENTITY_CHECKING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDENTITY_CONSTRAINT_CHECKING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REPORT_WHITESPACE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYMBOL_TABLE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR_REPORTER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENTITY_RESOLVER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XMLGRAMMAR_POOL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALIDATION_MANAGER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENTITY_MANAGER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEMA_LOCATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEMA_NONS_LOCATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAXP_SCHEMA_SOURCE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAXP_SCHEMA_LANGUAGE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROOT_TYPE_DEF", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROOT_ELEMENT_DECL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEMA_DV_FACTORY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XML_SECURITY_PROPERTY_MANAGER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OVERRIDE_PARSER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USE_CATALOG", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECOGNIZED_FEATURES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FEATURE_DEFAULTS", "[Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECOGNIZED_PROPERTIES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPERTY_DEFAULTS", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID_CONSTRAINT_NUM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSI_TYPE", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSI_NIL", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSI_SCHEMALOCATION", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSI_NONAMESPACESCHEMALOCATION", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrentPSVI", "Lcom/sun/org/apache/xerces/internal/impl/xs/ElementPSVImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAugmentations", "Lcom/sun/org/apache/xerces/internal/util/AugmentationsImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDefaultValue", "Lcom/sun/org/apache/xerces/internal/xni/XMLString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDynamicValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSchemaDynamicValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDoValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fFullChecking", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNormalizeData", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSchemaElementDefault", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAugPSVI", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIdConstraint", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fUseGrammarPoolOnly", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespaceGrowth", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSchemaType", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEntityRef", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fInCDATA", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSawOnlyWhitespaceInElementContent", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocator", "Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fXSIErrorReporter", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XSIErrorReporter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEntityResolver", "Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidationManager", "Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidationState", "Lcom/sun/org/apache/xerces/internal/impl/validation/ConfigurableValidationState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarPool", "Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fExternalSchemas", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fExternalNoNamespaceSchema", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fJaxpSchemaSource", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fXSDDescription", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocationPairs", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocumentHandler", "Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocumentSource", "Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reportWhitespace", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIAL_STACK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INC_STACK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_NORMALIZATION", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEmptyXMLStr", "Lcom/sun/org/apache/xerces/internal/xni/XMLString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUFFER_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNormalizedStr", "Lcom/sun/org/apache/xerces/internal/xni/XMLString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fFirstChunk", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTrailing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fWhiteSpace", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fUnionType", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarBucket", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSubGroupHandler", "Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fQNameDV", "Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nodeFactory", "Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMNodeFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCMBuilder", "Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSchemaLoader", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidationRoot", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSkipValidationDepth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNFullValidationDepth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNNoneValidationDepth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElementDepth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSubElement", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSubElementStack", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrentElemDecl", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fElemDeclStack", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNil", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNilStack", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNotation", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNotationStack", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrentType", "Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTypeStack", "[Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrentCM", "Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCMStack", "[Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCurrCMState", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCMStateStack", "[[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fStrictAssess", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fStrictAssessStack", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fBuffer", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAppendBuffer", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSawText", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSawTextStack", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSawCharacters", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fStringContent", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTempQName", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRootTypeQName", "Ljavax/xml/namespace/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRootTypeDefinition", "Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRootElementDeclQName", "Ljavax/xml/namespace/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRootElementDeclaration", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIgnoreXSITypeDepth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIDCChecking", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidatedInfo", "Lcom/sun/org/apache/xerces/internal/impl/dv/ValidatedInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fState4XsiType", "Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fState4ApplyDefault", "Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fMatcherStack", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XPathMatcherStack;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValueStoreCache", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreCache;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "comment", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLComponentManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emptyElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "xmlDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doctypeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startGeneralEntity", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "textDecl", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endGeneralEntity", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentHandler", "()Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processAttributes", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startCDATA", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endCDATA", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocumentSource", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentSource", "()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSchemaGrammar", "(SLjava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeLocations", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEmptyAugs", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectedStr", "(Ljava/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkElementMatchesRootElementDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/xni/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processRootElementDeclQName", "(Ljavax/xml/namespace/QName;Lcom/sun/org/apache/xerces/internal/xni/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processRootTypeQName", "(Ljavax/xml/namespace/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndCheckXsiType", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXsiNil", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDefaultAttributes", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processElementContent", "(Lcom/sun/org/apache/xerces/internal/xni/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElementPSVI", "(Z[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSchemaComponent", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;SLcom/sun/org/apache/xerces/internal/xni/QName;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processOneAttribute", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;ILcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;Lcom/sun/org/apache/xerces/internal/impl/xs/AttributePSVImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elementLocallyValidType", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elementLocallyValidComplexType", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characterData", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elementDefault", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startValueScopeFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "activateField", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;I)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endValueScopeFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "activateSelectorFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleStartElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureStackCapacity", "()V"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalElementDecl", "(Lcom/sun/org/apache/xerces/internal/xni/QName;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characters", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportSchemaError", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocationHints", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;[Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocationHints", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;[Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xs/StringList;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleStartDocument", "(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleCharacters", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;)Lcom/sun/org/apache/xerces/internal/xni/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleIgnorableWhitespace", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleEndDocument", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizeWhitespace", "(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizeWhitespace", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleEndElement", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
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
	public static Dova.JDK.java.lang.String SCHEMA_VALIDATION_Property
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
	public static Dova.JDK.java.lang.String SCHEMA_FULL_CHECKING_Property
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
	public static Dova.JDK.java.lang.String DYNAMIC_VALIDATION_Property
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
	public static Dova.JDK.java.lang.String NORMALIZE_DATA_Property
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
	public static Dova.JDK.java.lang.String SCHEMA_ELEMENT_DEFAULT_Property
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
	public static Dova.JDK.java.lang.String SCHEMA_AUGMENT_PSVI_Property
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
	public static Dova.JDK.java.lang.String ALLOW_JAVA_ENCODINGS_Property
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
	public static Dova.JDK.java.lang.String STANDARD_URI_CONFORMANT_FEATURE_Property
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
	public static Dova.JDK.java.lang.String GENERATE_SYNTHETIC_ANNOTATIONS_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String VALIDATE_ANNOTATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String HONOUR_ALL_SCHEMALOCATIONS_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String USE_GRAMMAR_POOL_ONLY_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String CONTINUE_AFTER_FATAL_ERROR_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String PARSER_SETTINGS_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String NAMESPACE_GROWTH_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String TOLERATE_DUPLICATES_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String IGNORE_XSI_TYPE_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ID_IDREF_CHECKING_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String UNPARSED_ENTITY_CHECKING_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String IDENTITY_CONSTRAINT_CHECKING_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String REPORT_WHITESPACE_Property
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
	public static Dova.JDK.java.lang.String SYMBOL_TABLE_Property
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
	public static Dova.JDK.java.lang.String ERROR_REPORTER_Property
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
	public static Dova.JDK.java.lang.String ENTITY_RESOLVER_Property
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
	public static Dova.JDK.java.lang.String XMLGRAMMAR_POOL_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String VALIDATION_MANAGER_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ENTITY_MANAGER_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String SCHEMA_LOCATION_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String SCHEMA_NONS_LOCATION_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String JAXP_SCHEMA_SOURCE_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String JAXP_SCHEMA_LANGUAGE_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ROOT_TYPE_DEF_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ROOT_ELEMENT_DECL_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String SCHEMA_DV_FACTORY_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String XML_SECURITY_PROPERTY_MANAGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String OVERRIDE_PARSER_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String USE_CATALOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> RECOGNIZED_FEATURES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Boolean;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.Boolean> FEATURE_DEFAULTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Boolean>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> RECOGNIZED_PROPERTIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.Object> PROPERTY_DEFAULTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int ID_CONSTRAINT_NUM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl XSI_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl XSI_NIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl XSI_SCHEMALOCATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl XSI_NONAMESPACESCHEMALOCATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/ElementPSVImpl;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.ElementPSVImpl fCurrentPSVI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.ElementPSVImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/AugmentationsImpl;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.AugmentationsImpl fAugmentations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.AugmentationsImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLString;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString fDefaultValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fDynamicValidation_Property
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

	[JniSignatureAttribute("Z", "protected")]
	public bool fSchemaDynamicValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[52]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[52], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fDoValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[53]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[53], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fFullChecking_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[54]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[54], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fNormalizeData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[55]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[55], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fSchemaElementDefault_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[56]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[56], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fAugPSVI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[57]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[57], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fIdConstraint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[58]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[58], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fUseGrammarPoolOnly_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[59]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[59], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fNamespaceGrowth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[60]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[60], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fSchemaType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fEntityRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[62]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[62], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fInCDATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[63]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[63], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fSawOnlyWhitespaceInElementContent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[64]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[64], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator fLocator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XSIErrorReporter;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.XSIErrorReporter fXSIErrorReporter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.XSIErrorReporter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver fEntityResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationManager;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationManager fValidationManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/validation/ConfigurableValidationState;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ConfigurableValidationState fValidationState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ConfigurableValidationState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool fGrammarPool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String fExternalSchemas_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String fExternalNoNamespaceSchema_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object fJaxpSchemaSource_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription fXSDDescription_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
	public Dova.JDK.java.util.Map fLocationPairs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler fDocumentHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource fDocumentSource_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool reportWhitespace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[79]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[79], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int INITIAL_STACK_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[80]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[80], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int INC_STACK_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[81]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[81], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_NORMALIZATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[82]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[82], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLString;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString fEmptyXMLStr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int BUFFER_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[84]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[84], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLString;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString fNormalizedStr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fFirstChunk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[86]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[86], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fTrailing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[87]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[87], value);
		}
	}

	[JniSignatureAttribute("S", "private")]
	public short fWhiteSpace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[88]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[88], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fUnionType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[89]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[89], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket fGrammarBucket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler fSubGroupHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType fQNameDV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMNodeFactory;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.CMNodeFactory nodeFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.CMNodeFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMBuilder;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.CMBuilder fCMBuilder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[94]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.CMBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaLoader;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaLoader fSchemaLoader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fValidationRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fSkipValidationDepth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[97]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[97], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fNFullValidationDepth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[98]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[98], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fNNoneValidationDepth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[99]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[99], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fElementDepth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[100]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[100], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fSubElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[101]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[101], value);
		}
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> fSubElementStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[102]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl fCurrentElemDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[103]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl> fElemDeclStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[104]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fNil_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[105]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[105], value);
		}
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> fNilStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[106]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl fNotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[107]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl> fNotationStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[108]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition fCurrentType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[109]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition> fTypeStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[110]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator fCurrentCM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[111]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator> fCMStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[112]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> fCurrCMState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[113]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[I", "private")]
	public JavaArray<JavaArray<int>> fCMStateStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[114]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fStrictAssess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[115]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[115], value);
		}
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> fStrictAssessStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[116]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private final")]
	public Dova.JDK.java.lang.StringBuilder fBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[117]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fAppendBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[118]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[118], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fSawText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[119]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[119], value);
		}
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> fSawTextStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[120]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fSawCharacters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[121]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[121], value);
		}
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> fStringContent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[122]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fTempQName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[123]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/namespace/QName;", "private")]
	public Dova.JDK.javax.xml.@namespace.QName fRootTypeQName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[124]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.@namespace.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition fRootTypeDefinition_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[125]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/namespace/QName;", "private")]
	public Dova.JDK.javax.xml.@namespace.QName fRootElementDeclQName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[126]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.@namespace.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl fRootElementDeclaration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[127]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fIgnoreXSITypeDepth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[128]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[128], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fIDCChecking_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[129]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[129], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/ValidatedInfo;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidatedInfo fValidatedInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[130]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidatedInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationState;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationState fState4XsiType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[131]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationState;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationState fState4ApplyDefault_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[132]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XPathMatcherStack;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.XPathMatcherStack fMatcherStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[133]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.XPathMatcherStack>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreCache;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreCache fValueStoreCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[134]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLSchemaValidator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLSchemaValidator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void comment(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLComponentManager;)V", "public")]
	public void reset(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLComponentManager arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void emptyElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void xmlDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void doctypeDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startGeneralEntity(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLResourceIdentifier arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void textDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endGeneralEntity(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler getDocumentHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V", "")]
	public void processAttributes(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startCDATA(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endCDATA(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;)V", "public")]
	public void setDocumentSource(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDocumentSource;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource getDocumentSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDocumentSource>(ret);
	}

	[JniSignatureAttribute("(SLjava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar findSchemaGrammar(short arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "")]
	public void storeLocations(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations getEmptyAugs(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String expectedStr(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/xni/QName;)V", "")]
	public void checkElementMatchesRootElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/xml/namespace/QName;Lcom/sun/org/apache/xerces/internal/xni/QName;)V", "")]
	public void processRootElementDeclQName(Dova.JDK.javax.xml.@namespace.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/xml/namespace/QName;)V", "")]
	public void processRootTypeQName(Dova.JDK.javax.xml.@namespace.QName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition getAndCheckXsiType(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/String;)Z", "")]
	public bool getXsiNil(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V", "")]
	public void addDefaultAttributes(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;)V", "")]
	public void processElementContent(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Z[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;", "final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations endElementPSVI(bool arg0, JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;SLcom/sun/org/apache/xerces/internal/xni/QName;)Z", "private")]
	public bool hasSchemaComponent(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, short arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;ILcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;Lcom/sun/org/apache/xerces/internal/impl/xs/AttributePSVImpl;)V", "")]
	public void processOneAttribute(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeUseImpl arg4, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.AttributePSVImpl arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/Object;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object elementLocallyValidType(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Ljava/lang/Object;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object elementLocallyValidComplexType(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Z", "public")]
	public bool characterData(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void elementDefault(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V", "public")]
	public void startValueScopeFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;I)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher activateField(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V", "public")]
	public void endValueScopeFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V", "private")]
	public void activateSelectorFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations handleStartElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void ensureStackCapacity()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLDocumentHandler;)V", "public")]
	public void setDocumentHandler(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getRecognizedFeatures()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getRecognizedProperties()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Boolean;", "public")]
	public Dova.JDK.java.lang.Boolean getFeatureDefault(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getPropertyDefault(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
	public void setFeature(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void startElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void endElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void ignorableWhitespace(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void processingInstruction(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl getGlobalElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public")]
	public void characters(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
	public void reportSchemaError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;[Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void setLocationHints(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg0, JavaArray<Dova.JDK.java.lang.String> arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;[Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xs/StringList;)V", "private")]
	public void setLocationHints(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg0, JavaArray<Dova.JDK.java.lang.String> arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;)V", "")]
	public void handleStartDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;)Lcom/sun/org/apache/xerces/internal/xni/XMLString;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString handleCharacters(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;)V", "")]
	public void handleIgnorableWhitespace(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void handleEndDocument()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLString;Z)V", "private")]
	public void normalizeWhitespace(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLString arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "private")]
	public void normalizeWhitespace(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)Lcom/sun/org/apache/xerces/internal/xni/Augmentations;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations handleEndElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XSIErrorReporter;", "protected final")]
	public partial class XSIErrorReporter
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XSIErrorReporter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XSIErrorReporter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fErrorReporter", "Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fErrors", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fContext", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fContextCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportError", "(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;S)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportError", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;S)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeContext", "()[Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushContext", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popContext", "()[Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;", "")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter fErrorReporter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "")]
		public Dova.JDK.java.util.Vector fErrors_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> fContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int fContextCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XSIErrorReporter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;)V", "protected")]
		public XSIErrorReporter(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XSIErrorReporter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;)V", "public")]
		public void reset(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;S)V", "public")]
		public void reportError(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, short arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;S)V", "public")]
		public void reportError(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, short arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
		public JavaArray<Dova.JDK.java.lang.String> mergeContext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void pushContext()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
		public JavaArray<Dova.JDK.java.lang.String> popContext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XPathMatcherStack;", "protected static")]
	public partial class XPathMatcherStack
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XPathMatcherStack()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XPathMatcherStack;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fMatchers", "[Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fMatchersCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fContextStack", "Lcom/sun/org/apache/xerces/internal/util/IntStack;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMatcher", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatcherCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatcherAt", "(I)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureMatcherCapacity", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushContext", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popContext", "()V"));
		}

		[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;", "protected")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher> fMatchers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "protected")]
		public int fMatchersCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/IntStack;", "protected")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.util.IntStack fContextStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.IntStack>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XPathMatcherStack(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public XPathMatcherStack() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$XPathMatcherStack;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;)V", "public")]
		public void addMatcher(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getMatcherCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher getMatcherAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void ensureMatcherCapacity()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void pushContext()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void popContext()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreCache;", "protected")]
	public partial class ValueStoreCache
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ValueStoreCache()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreCache;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocalId", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$LocalIDKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValueStores", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIdentityConstraint2ValueStoreMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalMapStack", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalIDConstraintMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValueStoreFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initValueStoresFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/FieldActivator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transplant", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalValueStoreFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDocument", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endDocument", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$LocalIDKey;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.LocalIDKey fLocalId_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.LocalIDKey>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "protected final")]
		public Dova.JDK.java.util.List fValueStores_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
		public Dova.JDK.java.util.Map fIdentityConstraint2ValueStoreMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "protected final")]
		public Dova.JDK.java.util.Stack fGlobalMapStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
		public Dova.JDK.java.util.Map fGlobalIDConstraintMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ValueStoreCache(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;)V", "public")]
		public ValueStoreCache(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreCache;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase getValueStoreFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/FieldActivator;)V", "public")]
		public void initValueStoresFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.FieldActivator arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V", "public")]
		public void transplant(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase getGlobalValueStoreFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void startDocument()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void endDocument()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void startElement()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void endElement()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;", "protected abstract")]
	public partial class ValueStoreBase
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.ValueStore
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ValueStoreBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIdentityConstraint", "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fFieldCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fFields", "[Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocalValues", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocalValueTypes", "[S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocalItemValueTypes", "[Lcom/sun/org/apache/xerces/internal/xs/ShortList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValuesCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fHasValue", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValues", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValueTypes", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ShortVector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fItemValueTypes", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fUseValueTypeVector", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValueTypesLength", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValueType", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fUseItemValueTypeVector", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fItemValueTypesLength", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fItemValueType", "Lcom/sun/org/apache/xerces/internal/xs/ShortList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTempBuffer", "Ljava/lang/StringBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Ljava/util/Vector;II)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "([Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportError", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addValue", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;ZLjava/lang/Object;SLcom/sun/org/apache/xerces/internal/xs/ShortList;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startValueScope", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endValueScope", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endDocumentFragment", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkDuplicateValues", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addValueType", "(S)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addItemValueType", "(Lcom/sun/org/apache/xerces/internal/xs/ShortList;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValueTypeAt", "(I)S"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItemValueTypeAt", "(I)Lcom/sun/org/apache/xerces/internal/xs/ShortList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueTypeContains", "(S)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemValueTypeContains", "(Lcom/sun/org/apache/xerces/internal/xs/ShortList;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endDocument", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;", "protected")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint fIdentityConstraint_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "protected")]
		public int fFieldCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;", "protected")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field> fFields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "protected")]
		public JavaArray<Dova.JDK.java.lang.Object> fLocalValues_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[S", "protected")]
		public JavaArray<short> fLocalValueTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xs/ShortList;", "protected")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList> fLocalItemValueTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "protected")]
		public int fValuesCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Z", "protected")]
		public bool fHasValue_Property
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

		[JniSignatureAttribute("Ljava/util/Vector;", "public final")]
		public Dova.JDK.java.util.Vector fValues_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ShortVector;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ShortVector fValueTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ShortVector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "public")]
		public Dova.JDK.java.util.Vector fItemValueTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool fUseValueTypeVector_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int fValueTypesLength_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("S", "private")]
		public short fValueType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool fUseItemValueTypeVector_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int fItemValueTypesLength_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/ShortList;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList fItemValueType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/StringBuilder;", "final")]
		public Dova.JDK.java.lang.StringBuilder fTempBuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ValueStoreBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V", "protected")]
		public ValueStoreBase(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Vector;II)Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String toString(Dova.JDK.java.util.Vector arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String toString(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;)V", "public")]
		public void append(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool contains()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;)I", "public")]
		public int contains(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public")]
		public void reportError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;ZLjava/lang/Object;SLcom/sun/org/apache/xerces/internal/xs/ShortList;)V", "public")]
		public void addValue(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field arg0, bool arg1, Dova.JDK.java.lang.Object arg2, short arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("()V", "public")]
		public void startValueScope()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void endValueScope()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void endDocumentFragment()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void checkDuplicateValues()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
		}

		[JniSignatureAttribute("(S)V", "private")]
		public void addValueType(short arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/ShortList;)V", "private")]
		public void addItemValueType(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(I)S", "private")]
		public short getValueTypeAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/xs/ShortList;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList getItemValueTypeAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList>(ret);
		}

		[JniSignatureAttribute("(S)Z", "private")]
		public bool valueTypeContains(short arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/ShortList;)Z", "private")]
		public bool itemValueTypeContains(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void endDocument()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ShortVector;", "protected static final")]
	public partial class ShortVector
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ShortVector()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ShortVector;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLength", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fData", "[S"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(S)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(S)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureCapacity", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueAt", "(I)S"));
		}

		[JniSignatureAttribute("I", "private")]
		public int fLength_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("[S", "private")]
		public JavaArray<short> fData_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ShortVector(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ShortVector() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(I)V", "public")]
		public ShortVector(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ShortVector;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(S)V", "public")]
		public void add(short arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int length()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(S)Z", "public")]
		public bool contains(short arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void ensureCapacity(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(I)S", "public")]
		public short valueAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$LocalIDKey;", "protected static final")]
	public partial class LocalIDKey
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocalIDKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$LocalIDKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fId", "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDepth", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint fId_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int fDepth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocalIDKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public LocalIDKey() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V", "public")]
		public LocalIDKey(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$LocalIDKey;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$KeyRefValueStore;", "protected")]
	public partial class KeyRefValueStore
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyRefValueStore()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$KeyRefValueStore;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fKeyValueStore", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/KeyRef;Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$KeyValueStore;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endDocumentFragment", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endDocument", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$ValueStoreBase;", "protected")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase fKeyValueStore_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyRefValueStore(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/KeyRef;Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$KeyValueStore;)V", "public")]
		public KeyRefValueStore(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.KeyRef arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.KeyValueStore arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$KeyRefValueStore;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void endDocumentFragment()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void endDocument()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$KeyValueStore;", "protected")]
	public partial class KeyValueStore
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyValueStore()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$KeyValueStore;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/UniqueOrKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkDuplicateValues", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyValueStore(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/UniqueOrKey;)V", "public")]
		public KeyValueStore(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.UniqueOrKey arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$KeyValueStore;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void checkDuplicateValues()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$UniqueValueStore;", "protected")]
	public partial class UniqueValueStore
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator.ValueStoreBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniqueValueStore()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$UniqueValueStore;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/UniqueOrKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkDuplicateValues", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniqueValueStore(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/UniqueOrKey;)V", "public")]
		public UniqueValueStore(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaValidator arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.UniqueOrKey arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaValidator$UniqueValueStore;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void checkDuplicateValues()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
