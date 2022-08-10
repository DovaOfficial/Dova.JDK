/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;", "public")]
public partial class XSDHandler
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSDHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VALIDATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "XMLSCHEMA_VALIDATION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ALLOW_JAVA_ENCODINGS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONTINUE_AFTER_FATAL_ERROR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STANDARD_URI_CONFORMANT_FEATURE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DISALLOW_DOCTYPE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GENERATE_SYNTHETIC_ANNOTATIONS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VALIDATE_ANNOTATIONS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HONOUR_ALL_SCHEMALOCATIONS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAMESPACE_GROWTH", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TOLERATE_DUPLICATES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAMESPACE_PREFIXES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STRING_INTERNING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ERROR_HANDLER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JAXP_SCHEMA_SOURCE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENTITY_RESOLVER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENTITY_MANAGER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ERROR_REPORTER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "XMLGRAMMAR_POOL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SYMBOL_TABLE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SECURITY_MANAGER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOCALE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "XML_SECURITY_PROPERTY_MANAGER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG_NODE_POOL", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ATTRIBUTE_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ATTRIBUTEGROUP_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ELEMENT_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GROUP_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IDENTITYCONSTRAINT_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOTATION_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPEDECL_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REDEF_IDENTIFIER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fDeclPool", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSecurityManager", "Lcom/sun/org/apache/xerces/internal/utils/XMLSecurityManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAccessExternalSchema", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAccessExternalDTD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "registryEmpty", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedAttributeRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedAttributeGroupRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedElementRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedGroupRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedIdentityConstraintRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedNotationRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedTypeRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedAttributeRegistrySub", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedAttributeGroupRegistrySub", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedElementRegistrySub", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedGroupRegistrySub", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedIdentityConstraintRegistrySub", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedNotationRegistrySub", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedTypeRegistrySub", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUnparsedRegistriesExt", "[Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fDependencyMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fImportMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAllTNSs", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLocationPairs", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fHiddenNodes", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fTraversed", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fDoc2SystemId", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fRoot", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fDoc2XSDocumentMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fRedefine2XSDMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fRedefine2NSSupport", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fRedefinedRestrictedAttributeGroupRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fRedefinedRestrictedGroupRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLastSchemaWasDuplicate", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fValidateAnnotations", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fHonourAllSchemaLocations", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fNamespaceGrowth", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fTolerateDuplicates", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fErrorReporter", "Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fErrorHandler", "Lcom/sun/org/apache/xerces/internal/xni/parser/XMLErrorHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLocale", "Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fEntityManager", "Lcom/sun/org/apache/xerces/internal/impl/XMLEntityManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAttributeChecker", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGrammarBucket", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSchemaGrammarDescription", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGrammarPool", "Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSecurityPropertyMgr", "Lcom/sun/org/apache/xerces/internal/utils/XMLSecurityPropertyManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUseCatalog", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fCatalogFile", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fDefer", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fPrefer", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fResolve", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fOverrideDefaultParser", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAttributeGroupTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAttributeGroupTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAttributeTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAttributeTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fComplexTypeTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDComplexTypeTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fElementTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDElementTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGroupTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDGroupTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fKeyrefTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDKeyrefTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fNotationTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDNotationTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSimpleTypeTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDSimpleTypeTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fUniqueOrKeyTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDUniqueOrKeyTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fWildCardTraverser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDWildcardTraverser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fDVFactory", "Lcom/sun/org/apache/xerces/internal/impl/dv/SchemaDVFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSchemaParser", "Lcom/sun/org/apache/xerces/internal/impl/xs/opti/SchemaDOMParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fXSContentHandler", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/SchemaContentHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fStAXSchemaParser", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/StAXSchemaParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAnnotationValidator", "Lcom/sun/org/apache/xerces/internal/parsers/XML11Configuration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGrammarBucketAdapter", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSAnnotationGrammarPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INIT_STACK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INC_STACK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLocalElemStackPos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fParticle", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLocalElementDecl", "[Lorg/w3c/dom/Element;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLocalElementDecl_schema", "[Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAllContext", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fParent", "[Lcom/sun/org/apache/xerces/internal/xs/XSObject;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLocalElemNamespaceContext", "[[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INIT_KEYREF_STACK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INC_KEYREF_STACK_AMOUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fKeyrefStackPos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fKeyrefs", "[Lorg/w3c/dom/Element;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fKeyrefsMapXSDocumentInfo", "[Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fKeyrefElems", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fKeyrefNamespaceContext", "[[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGlobalAttrDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGlobalAttrGrpDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGlobalElemDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGlobalGroupDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGlobalNotationDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGlobalIDConstraintDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGlobalTypeDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NS_ERROR_CODES", "[[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ELE_ERROR_CODES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fReportedTNS", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COMP_TYPE", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CIRCULAR_CODES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "xl", "Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XSDHandler", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XSDHandler", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reset", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLComponentManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalTypeDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalAttributeGroupDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalGroupDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalNotationDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIDConstraintDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalAttributeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalAttributeGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalElementDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalNotationDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalTypeDecl", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addIDConstraintDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addRelatedType", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addRelatedElement", "(Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedComplexTypeComponents", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedSimpleTypeComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSSimpleTypeDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedModelGroupComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSModelGroup;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedAttributeUsesComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedParticleComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSParticle;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedAttributeUseComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSAttributeUse;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addRelatedAttribute", "(Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findDependentNamespaces", "(Ljava/lang/String;Ljava/util/Map;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addNamespaceDependency", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalComponent", "(Lcom/sun/org/apache/xerces/internal/xs/XSObject;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateImportDependencies", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSchemaGrammar", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandImportList", "(Ljava/lang/String;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addImportList", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateImportList", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateImportList", "(Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFromMap", "(Ljava/util/Map;Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTraversers", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeParticle", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "changeRedefineGroup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findQName", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "element2Locator", "(Lorg/w3c/dom/Element;)Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "element2Locator", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reportSchemaErr", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;SLjava/lang/Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "schemaDocument2SystemId", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGrpOrAttrGrpRedefinedByRestriction", "(ILcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lorg/w3c/dom/Element;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIDRegistry", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIDRegistry_sub", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "storeKeyRef", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillInLocalElemInfo", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;ILcom/sun/org/apache/xerces/internal/xs/XSObject;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGrammar", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setGenerateSyntheticAnnotations", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseSchema", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Ljava/util/Map;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalAttributeDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDVFactory", "()Lcom/sun/org/apache/xerces/internal/impl/dv/SchemaDVFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDVFactory", "(Lcom/sun/org/apache/xerces/internal/impl/dv/SchemaDVFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDeclPool", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalElementDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isExistingGrammar", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findGrammar", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Z)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "prepareForParse", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSchemaDocument", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/StAXInputSource;ZSLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSchemaDocument", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;ZSLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSchemaDocument", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/SAXInputSource;ZSLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSchemaDocument", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/DOMInputSource;ZSLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSchemaDocument", "(Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSInputSource;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "prepareForTraverse", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "constructTrees", "(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Z)Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buildGlobalNameRegistries", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "traverseSchemas", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "traverseLocalElements", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveKeyRefs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "emptyString2Null", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createAnnotationValidator", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reportSchemaWarning", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;Ljava/lang/Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reportSchemaWarning", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reportSchemaError", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;Ljava/lang/Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reportSchemaError", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateImportListWith", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateImportListFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "null2EmptyString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doc2SystemId", "(Lorg/w3c/dom/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveSchema", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;ZLorg/w3c/dom/Element;Z)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveSchema", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;ZLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nonAnnotationContent", "(Lorg/w3c/dom/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveSchemaSource", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;ZLorg/w3c/dom/Element;Z)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkForDuplicateNames", "(Ljava/lang/String;ILorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkForDuplicateNames", "(Ljava/lang/String;ILjava/util/Map;Ljava/util/Map;Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "renameRedefiningComponents", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lorg/w3c/dom/Element;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSchemasVisible", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "needReportTNSError", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalDeclFromGrammar", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILjava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalDeclFromGrammar", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILjava/lang/String;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalDecl", "(Ljava/lang/String;I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGlobalDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;ILcom/sun/org/apache/xerces/internal/xni/QName;Lorg/w3c/dom/Element;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElementFromMap", "(Ljava/util/Map;Ljava/lang/String;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocInfoFromMap", "(Ljava/util/Map;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findXSDocumentForDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "traverseGlobalDecl", "(ILorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reportSchemaFatalError", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSchemaDocument0", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSDKey;Ljava/lang/String;Lorg/w3c/dom/Element;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSchemaDocument1", "(ZZLcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;Lorg/w3c/dom/Element;Ljava/io/IOException;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandGrammars", "([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "existingGrammars", "(Ljava/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGrammars", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandComponents", "([Lcom/sun/org/apache/xerces/internal/xs/XSObject;Ljava/util/Map;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "canAddComponents", "(Ljava/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalComponents", "(Ljava/util/List;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "canAddComponent", "(Lcom/sun/org/apache/xerces/internal/xs/XSObject;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGrammarComponents", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createGrammarFrom", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addNewGrammarLocations", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addNewImportedGrammars", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addNewGrammarComponents", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "containedImportedGrammar", "(Ljava/util/List;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalElementDecls", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalAttributeDecls", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalAttributeGroupDecls", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalGroupDecls", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalTypeDecls", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addGlobalNotationDecls", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reportSharingError", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSObject;Ljava/util/List;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedTypeComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedAttributeComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedAttributeGroupComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedElementComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandRelatedModelGroupDefinitionComponents", "(Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "validateAnnotations", "(Ljava/util/List;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String VALIDATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String XMLSCHEMA_VALIDATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ALLOW_JAVA_ENCODINGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String CONTINUE_AFTER_FATAL_ERROR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String STANDARD_URI_CONFORMANT_FEATURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String DISALLOW_DOCTYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String GENERATE_SYNTHETIC_ANNOTATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String VALIDATE_ANNOTATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String HONOUR_ALL_SCHEMALOCATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String NAMESPACE_GROWTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String TOLERATE_DUPLICATES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String NAMESPACE_PREFIXES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String STRING_INTERNING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ERROR_HANDLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String JAXP_SCHEMA_SOURCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ENTITY_RESOLVER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ENTITY_MANAGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ERROR_REPORTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String XMLGRAMMAR_POOL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String SYMBOL_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String SECURITY_MANAGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String LOCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String XML_SECURITY_PROPERTY_MANAGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "protected static final")]
	public static bool DEBUG_NODE_POOL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[23], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ATTRIBUTE_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ATTRIBUTEGROUP_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ELEMENT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int GROUP_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int IDENTITYCONSTRAINT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int NOTATION_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int TYPEDECL_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String REDEF_IDENTIFIER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool fDeclPool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/utils/XMLSecurityManager;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.utils.XMLSecurityManager fSecurityManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.utils.XMLSecurityManager>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fAccessExternalSchema_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fAccessExternalDTD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool registryEmpty_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[36], value);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedAttributeRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedAttributeGroupRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedElementRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedGroupRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedIdentityConstraintRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedNotationRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedTypeRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedAttributeRegistrySub_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedAttributeGroupRegistrySub_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[45], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedElementRegistrySub_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[46], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedGroupRegistrySub_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[47], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedIdentityConstraintRegistrySub_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedNotationRegistrySub_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fUnparsedTypeRegistrySub_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/util/Map;", "private")]
	public JavaArray<Dova.JDK.java.util.Map> fUnparsedRegistriesExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[51], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fDependencyMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fImportMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List fAllTNSs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fLocationPairs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[55], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map fHiddenNodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[56], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fTraversed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[57], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fDoc2SystemId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[58], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo fRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[59], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fDoc2XSDocumentMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[60], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fRedefine2XSDMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fRedefine2NSSupport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[62], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map fRedefinedRestrictedAttributeGroupRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[63], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map fRedefinedRestrictedGroupRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[64], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fLastSchemaWasDuplicate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[65]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[65], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fValidateAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[66]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[66], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fHonourAllSchemaLocations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[67]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[67], value);
	}

	[JniSignatureAttribute("Z", "")]
	public bool fNamespaceGrowth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[68]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[68], value);
	}

	[JniSignatureAttribute("Z", "")]
	public bool fTolerateDuplicates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[69]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[69], value);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter fErrorReporter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[70], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/parser/XMLErrorHandler;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLErrorHandler fErrorHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLErrorHandler>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[71], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "private")]
	public Dova.JDK.java.util.Locale fLocale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[72], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/XMLEntityManager;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLEntityManager fEntityManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLEntityManager>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[73], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSAttributeChecker fAttributeChecker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSAttributeChecker>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[74], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[75], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket fGrammarBucket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[76], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription fSchemaGrammarDescription_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[77], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool fGrammarPool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[78], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/utils/XMLSecurityPropertyManager;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.utils.XMLSecurityPropertyManager fSecurityPropertyMgr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.utils.XMLSecurityPropertyManager>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[79], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fUseCatalog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[80]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[80], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fCatalogFile_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[81], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fDefer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[82], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fPrefer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[83], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fResolve_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[84]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[84], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fOverrideDefaultParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[85]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[85], value);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAttributeGroupTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAttributeGroupTraverser fAttributeGroupTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAttributeGroupTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[86], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAttributeTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAttributeTraverser fAttributeTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[87]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAttributeTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[87], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDComplexTypeTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDComplexTypeTraverser fComplexTypeTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDComplexTypeTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[88], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDElementTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDElementTraverser fElementTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDElementTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[89], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDGroupTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDGroupTraverser fGroupTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDGroupTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[90], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDKeyrefTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDKeyrefTraverser fKeyrefTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDKeyrefTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[91], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDNotationTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDNotationTraverser fNotationTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDNotationTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[92], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDSimpleTypeTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDSimpleTypeTraverser fSimpleTypeTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDSimpleTypeTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[93], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDUniqueOrKeyTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDUniqueOrKeyTraverser fUniqueOrKeyTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[94]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDUniqueOrKeyTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[94], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDWildcardTraverser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDWildcardTraverser fWildCardTraverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDWildcardTraverser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[95], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/SchemaDVFactory;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.SchemaDVFactory fDVFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.SchemaDVFactory>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[96], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/opti/SchemaDOMParser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.opti.SchemaDOMParser fSchemaParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[97]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.opti.SchemaDOMParser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[97], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/SchemaContentHandler;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.SchemaContentHandler fXSContentHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[98]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.SchemaContentHandler>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[98], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/StAXSchemaParser;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.StAXSchemaParser fStAXSchemaParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[99]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.StAXSchemaParser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[99], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/parsers/XML11Configuration;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.XML11Configuration fAnnotationValidator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[100]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.XML11Configuration>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[100], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSAnnotationGrammarPool;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler.XSAnnotationGrammarPool fGrammarBucketAdapter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[101]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler.XSAnnotationGrammarPool>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[101], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INIT_STACK_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[102]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[102], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INC_STACK_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[103]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[103], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int fLocalElemStackPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[104]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[104], value);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl> fParticle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[105]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[105], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lorg/w3c/dom/Element;", "private")]
	public JavaArray<Dova.JDK.org.w3c.dom.Element> fLocalElementDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[106]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.w3c.dom.Element>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[106], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo> fLocalElementDecl_schema_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[107]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[107], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> fAllContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[108]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[108], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xs/XSObject;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject> fParent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[109]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[109], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[[Ljava/lang/String;", "private")]
	public JavaArray<JavaArray<Dova.JDK.java.lang.String>> fLocalElemNamespaceContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[110]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.String>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[110], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INIT_KEYREF_STACK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[111]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[111], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INC_KEYREF_STACK_AMOUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[112]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[112], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int fKeyrefStackPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[113]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[113], value);
	}

	[JniSignatureAttribute("[Lorg/w3c/dom/Element;", "private")]
	public JavaArray<Dova.JDK.org.w3c.dom.Element> fKeyrefs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[114]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.w3c.dom.Element>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[114], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo> fKeyrefsMapXSDocumentInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[115]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[115], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl> fKeyrefElems_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[116]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[116], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[[Ljava/lang/String;", "private")]
	public JavaArray<JavaArray<Dova.JDK.java.lang.String>> fKeyrefNamespaceContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[117]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.String>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[117], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalAttrDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[118]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[118], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalAttrGrpDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[119]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[119], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalElemDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[120]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[120], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalGroupDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[121]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[121], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalNotationDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[122]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[122], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalIDConstraintDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[123]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[123], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalTypeDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[124]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[124], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[[Ljava/lang/String;", "private static final")]
	public static JavaArray<JavaArray<Dova.JDK.java.lang.String>> NS_ERROR_CODES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.String>>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> ELE_ERROR_CODES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List fReportedTNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[127]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[127], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> COMP_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> CIRCULAR_CODES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator xl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[130]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[130], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSDHandler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;)V", "public")]
	public XSDHandler(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XSDHandler() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLComponentManager;)V", "public")]
	public void reset(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLComponentManager arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition getGlobalTypeDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl getGlobalAttributeGroupDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl getGlobalGroupDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl getGlobalNotationDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint getIDConstraintDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;)V", "")]
	public void addGlobalAttributeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V", "")]
	public void addGlobalAttributeGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "")]
	public void addGlobalElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;)V", "")]
	public void addGlobalGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;)V", "")]
	public void addGlobalNotationDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)V", "")]
	public void addGlobalTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V", "")]
	public void addIDConstraintDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void addRelatedType(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void addRelatedElement(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedComplexTypeComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSSimpleTypeDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedSimpleTypeComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSSimpleTypeDefinition arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSModelGroup;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedModelGroupComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroup arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedAttributeUsesComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSParticle;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedParticleComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSParticle arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSAttributeUse;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedAttributeUseComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeUse arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void addRelatedAttribute(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List findDependentNamespaces(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "private")]
	public void addNamespaceDependency(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSObject;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;)V", "private")]
	public void addGlobalComponent(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "private")]
	public void updateImportDependencies(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar getSchemaGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)V", "private")]
	public void expandImportList(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Ljava/util/List;Ljava/util/List;)V", "private")]
	public void addImportList(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Ljava/util/List;Ljava/util/List;)V", "private")]
	public void updateImportList(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)V", "private")]
	public void updateImportList(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/String;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getFromMap(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void createTraversers()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Z", "private")]
	public bool removeParticle(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelGroupImpl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)I", "private")]
	public int changeRedefineGroup(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.org.w3c.dom.Element arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String findQName(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator element2Locator(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)Z", "public")]
	public bool element2Locator(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;SLjava/lang/Exception;)V", "")]
	public void reportSchemaErr(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2, short arg3, Dova.JDK.java.lang.Exception arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String schemaDocument2SystemId(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lorg/w3c/dom/Element;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object getGrpOrAttrGrpRedefinedByRestriction(int arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg2, Dova.JDK.org.w3c.dom.Element arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "protected")]
	public Dova.JDK.java.util.Map getIDRegistry()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "protected")]
	public Dova.JDK.java.util.Map getIDRegistry_sub()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "protected")]
	public void storeKeyRef(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;ILcom/sun/org/apache/xerces/internal/xs/XSObject;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)V", "")]
	public void fillInLocalElemInfo(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar getGrammar(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setGenerateSyntheticAnnotations(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Ljava/util/Map;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar parseSchema(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl getGlobalAttributeDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/dv/SchemaDVFactory;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.SchemaDVFactory getDVFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.SchemaDVFactory>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/SchemaDVFactory;)V", "public")]
	public void setDVFactory(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.SchemaDVFactory arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;)V", "public")]
	public void setDeclPool(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl getGlobalElementDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Z)Z", "private")]
	public bool isExistingGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Z)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar findGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void prepareForParse()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/StAXInputSource;ZSLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element getSchemaDocument(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.util.StAXInputSource arg1, bool arg2, short arg3, Dova.JDK.org.w3c.dom.Element arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;ZSLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element getSchemaDocument(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource arg1, bool arg2, short arg3, Dova.JDK.org.w3c.dom.Element arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/SAXInputSource;ZSLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element getSchemaDocument(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.util.SAXInputSource arg1, bool arg2, short arg3, Dova.JDK.org.w3c.dom.Element arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/DOMInputSource;ZSLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element getSchemaDocument(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.util.DOMInputSource arg1, bool arg2, short arg3, Dova.JDK.org.w3c.dom.Element arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSInputSource;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element getSchemaDocument(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.XSInputSource arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void prepareForTraverse()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61]);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Z)Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo constructTrees(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void buildGlobalNameRegistries()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63]);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
	public void traverseSchemas(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void traverseLocalElements()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void resolveKeyRefs()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String emptyString2Null(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void createAnnotationValidator()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;Ljava/lang/Exception;)V", "")]
	public void reportSchemaWarning(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2, Dova.JDK.java.lang.Exception arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V", "")]
	public void reportSchemaWarning(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;Ljava/lang/Exception;)V", "")]
	public void reportSchemaError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2, Dova.JDK.java.lang.Exception arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V", "")]
	public void reportSchemaError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void updateImportListWith(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void updateImportListFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String null2EmptyString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String doc2SystemId(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;ZLorg/w3c/dom/Element;Z)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element resolveSchema(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg0, bool arg1, Dova.JDK.org.w3c.dom.Element arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;ZLorg/w3c/dom/Element;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element resolveSchema(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg1, bool arg2, Dova.JDK.org.w3c.dom.Element arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Z", "private")]
	public bool nonAnnotationContent(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;ZLorg/w3c/dom/Element;Z)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource resolveSchemaSource(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg0, bool arg1, Dova.JDK.org.w3c.dom.Element arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILorg/w3c/dom/Element;)V", "")]
	public void checkForDuplicateNames(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/Map;Ljava/util/Map;Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)V", "")]
	public void checkForDuplicateNames(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.org.w3c.dom.Element arg4, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lorg/w3c/dom/Element;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void renameRedefiningComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg0, Dova.JDK.org.w3c.dom.Element arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)V", "private")]
	public void setSchemasVisible(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private final")]
	public bool needReportTNSError(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILjava/lang/String;)Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object getGlobalDeclFromGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILjava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object getGlobalDeclFromGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object getGlobalDecl(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;ILcom/sun/org/apache/xerces/internal/xni/QName;Lorg/w3c/dom/Element;)Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object getGlobalDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg0, int arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg2, Dova.JDK.org.w3c.dom.Element arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/String;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element getElementFromMap(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo getDocInfoFromMap(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo findXSDocumentForDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg0, Dova.JDK.org.w3c.dom.Element arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo>(ret);
	}

	[JniSignatureAttribute("(ILorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object traverseGlobalDecl(int arg0, Dova.JDK.org.w3c.dom.Element arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V", "")]
	public void reportSchemaFatalError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSDKey;Ljava/lang/String;Lorg/w3c/dom/Element;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element getSchemaDocument0(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler.XSDKey arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(ZZLcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;Lorg/w3c/dom/Element;Ljava/io/IOException;)Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element getSchemaDocument1(bool arg0, bool arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource arg2, Dova.JDK.org.w3c.dom.Element arg3, Dova.JDK.java.io.IOException arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List expandGrammars(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Z", "private")]
	public bool existingGrammars(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void addGrammars(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/xs/XSObject;Ljava/util/Map;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List expandComponents(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject> arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Z", "private")]
	public bool canAddComponents(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[101], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/Map;)V", "private")]
	public void addGlobalComponents(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.Map arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[102], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSObject;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;)Z", "private")]
	public bool canAddComponent(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addGrammarComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar createGrammarFrom(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addNewGrammarLocations(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[106], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addNewImportedGrammars(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addNewGrammarComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Z", "private")]
	public bool containedImportedGrammar(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[109], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addGlobalElementDecls(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[110], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addGlobalAttributeDecls(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[111], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addGlobalAttributeGroupDecls(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[112], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addGlobalGroupDecls(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[113], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addGlobalTypeDecls(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[114], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void addGlobalNotationDecls(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void reportSharingError(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSObject;Ljava/util/List;Ljava/util/Map;)V", "private")]
	public void expandRelatedComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedTypeComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedAttributeComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[119], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedAttributeGroupComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedElementComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "private")]
	public void expandRelatedModelGroupDefinitionComponents(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void validateAnnotations(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[123], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSDKey;", "private static")]
	public partial class XSDKey
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XSDKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSDKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "systemId", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "referType", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "referNS", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XSDKey", "(Ljava/lang/String;SLjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String systemId_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("S", "")]
		public short referType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String referNS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XSDKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;SLjava/lang/String;)V", "")]
		public XSDKey(Dova.JDK.java.lang.String arg0, short arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSDKey;";
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

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSAnnotationGrammarPool;", "private static")]
	public partial class XSAnnotationGrammarPool
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XSAnnotationGrammarPool()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSAnnotationGrammarPool;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGrammarBucket", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fInitialGrammarSet", "[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XSAnnotationGrammarPool", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "retrieveInitialGrammarSet", "(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cacheGrammars", "(Ljava/lang/String;[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "retrieveGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lockPool", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unlockPool", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "refreshGrammars", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket fGrammarBucket_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "private")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> fInitialGrammarSet_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XSAnnotationGrammarPool(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public XSAnnotationGrammarPool() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$XSAnnotationGrammarPool;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> retrieveInitialGrammarSet(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V", "public")]
		public void cacheGrammars(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar retrieveGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void lockPool()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void unlockPool()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;)V", "public")]
		public void refreshGrammars(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$SAX2XNIUtil;", "private static final")]
	public partial class SAX2XNIUtil
		: Dova.JDK.com.sun.org.apache.xerces.@internal.util.ErrorHandlerWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SAX2XNIUtil()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$SAX2XNIUtil;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SAX2XNIUtil", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createXMLParseException0", "(Lorg/xml/sax/SAXParseException;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createXNIException0", "(Lorg/xml/sax/SAXException;)Lcom/sun/org/apache/xerces/internal/xni/XNIException;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SAX2XNIUtil(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SAX2XNIUtil() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler$SAX2XNIUtil;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lorg/xml/sax/SAXParseException;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLParseException;", "public static")]
		public static Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLParseException createXMLParseException0(Dova.JDK.org.xml.sax.SAXParseException arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLParseException>(ret);
		}

		[JniSignatureAttribute("(Lorg/xml/sax/SAXException;)Lcom/sun/org/apache/xerces/internal/xni/XNIException;", "public static")]
		public static Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XNIException createXNIException0(Dova.JDK.org.xml.sax.SAXException arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XNIException>(ret);
		}
	}
}
