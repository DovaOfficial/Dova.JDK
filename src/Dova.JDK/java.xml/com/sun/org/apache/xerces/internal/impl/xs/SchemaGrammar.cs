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

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "public")]
public partial class SchemaGrammar
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XSGrammar
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SchemaGrammar()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTargetNamespace", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalAttrDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalAttrGrpDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalElemDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalGroupDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalNotationDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalIDConstraintDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalTypeDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalAttrDeclsExt", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalAttrGrpDeclsExt", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalElemDeclsExt", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalGroupDeclsExt", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalNotationDeclsExt", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalIDConstraintDeclsExt", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalTypeDeclsExt", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAllGlobalElemDecls", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarDescription", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAnnotations", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNumAnnotations", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSAXParser", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDOMParser", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIsImmutable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASICSET_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FULLSET_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GRAMMAR_XS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GRAMMAR_XSI", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fImported", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIAL_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INC_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCTCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fComplexTypeDecls", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCTLocators", "[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REDEFINED_GROUP_INIT_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRGCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRedefinedGroupDecls", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRGLocators", "[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fFullChecked", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSubGroupCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSubGroups", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fAnyType", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SG_SchemaNS", "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SG_SchemaNSExtended", "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fAnySimpleType", "Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SG_XSI", "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_COMP_IDX", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GLOBAL_COMP", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fComponents", "[Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fComponentsExt", "[Lcom/sun/org/apache/xerces/internal/xs/datatypes/ObjectList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocuments", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocations", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Lcom/sun/org/apache/xerces/internal/util/SymbolTable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resize", "([Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;I)[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resize", "([Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;I)[Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resize", "([Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;I)[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resize", "([Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;I)[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImmutable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalTypeDecl", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalTypeDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalAttributeGroupDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalAttributeGroupDecl", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalGroupDecl", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalGroupDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalNotationDecl", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalNotationDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIDConstraintDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIDConstraintDecl", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setImportedGrammars", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImportedGrammars", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDeclAll", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalNotationDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalNotationDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalTypeDecl", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalTypeDecl", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalSimpleTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalSimpleTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addIDConstraintDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addIDConstraintDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasIDConstraints", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRedefinedGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUncheckedComplexTypeDecls", "()[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUncheckedCTLocators", "()[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRedefinedGroupDecls", "()[Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRGLocators", "()[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUncheckedTypeNum", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubstitutionGroups", "()[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getS4SGrammar", "(S)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDocument", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchemaNamespace", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOMParser", "()Lcom/sun/org/apache/xerces/internal/parsers/DOMParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSAXParser", "()Lcom/sun/org/apache/xerces/internal/parsers/SAXParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentsExt", "(S)Lcom/sun/org/apache/xerces/internal/xs/datatypes/ObjectList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetComponents", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentLocations", "()Lcom/sun/org/apache/xerces/internal/xs/StringList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAnnotation", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamespaceAware", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDocument", "(Ljava/lang/Object;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammarDescription", "()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toXSModel", "()Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toXSModel", "([Lcom/sun/org/apache/xerces/internal/xni/grammars/XSGrammar;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementDeclaration", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeDeclaration", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDefinition", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeGroup", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModelGroupDefinition", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotationDeclaration", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNotationDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIDCDefinition", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSIDCDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetNamespace", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalAttributeDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalAttributeDecl", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalElementDecl", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalElementDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setImmutable", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponents", "(S)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String fTargetNamespace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalAttrDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalAttrGrpDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalElemDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalGroupDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalNotationDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalIDConstraintDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalTypeDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalAttrDeclsExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalAttrGrpDeclsExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalElemDeclsExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalGroupDeclsExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalNotationDeclsExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalIDConstraintDeclsExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGlobalTypeDeclsExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fAllGlobalElemDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription fGrammarDescription_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;", "")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl> fAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int fNumAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference fSAXParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference fDOMParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fIsImmutable_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int BASICSET_COUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FULLSET_COUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int GRAMMAR_XS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int GRAMMAR_XSI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List fImported_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INITIAL_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INC_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fCTCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl> fComplexTypeDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator> fCTLocators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int REDEFINED_GROUP_INIT_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fRGCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl> fRedefinedGroupDecls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator> fRGLocators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool fFullChecked_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fSubGroupCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl> fSubGroups_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl fAnyType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar.BuiltinSchemaGrammar SG_SchemaNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar.BuiltinSchemaGrammar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;", "private static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar.BuiltinSchemaGrammar SG_SchemaNSExtended_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar.BuiltinSchemaGrammar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType fAnySimpleType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar.BuiltinSchemaGrammar SG_XSI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar.BuiltinSchemaGrammar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short MAX_COMP_IDX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("[Z", "private static final")]
	public static JavaArray<bool> GLOBAL_COMP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap> fComponents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xs/datatypes/ObjectList;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.datatypes.ObjectList> fComponentsExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.datatypes.ObjectList>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List fDocuments_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List fLocations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SchemaGrammar(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "public")]
	public SchemaGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;Lcom/sun/org/apache/xerces/internal/util/SymbolTable;)V", "public")]
	public SchemaGrammar(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public SchemaGrammar() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList getAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;I)[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;", "static final")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator> resize(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator>>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;I)[Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;", "static final")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl> resize(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl>>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;I)[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "static final")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl> resize(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;I)[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "static final")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl> resize(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isImmutable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition getGlobalTypeDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition getGlobalTypeDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl getGlobalAttributeGroupDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl getGlobalAttributeGroupDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl getGlobalGroupDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl getGlobalGroupDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl getGlobalNotationDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl getGlobalNotationDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint getIDConstraintDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint getIDConstraintDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
	public void setImportedGrammars(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getImportedGrammars()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;)V", "public")]
	public void addGlobalAttributeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;Ljava/lang/String;)V", "public")]
	public void addGlobalAttributeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V", "public")]
	public void addGlobalAttributeGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;)V", "public")]
	public void addGlobalAttributeGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "public")]
	public void addGlobalElementDeclAll(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "public")]
	public void addGlobalElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Ljava/lang/String;)V", "public")]
	public void addGlobalElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Ljava/lang/String;)V", "public")]
	public void addGlobalGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;)V", "public")]
	public void addGlobalGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;Ljava/lang/String;)V", "public")]
	public void addGlobalNotationDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;)V", "public")]
	public void addGlobalNotationDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/lang/String;)V", "public")]
	public void addGlobalTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)V", "public")]
	public void addGlobalTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Ljava/lang/String;)V", "public")]
	public void addGlobalComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)V", "public")]
	public void addGlobalComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/lang/String;)V", "public")]
	public void addGlobalSimpleTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)V", "public")]
	public void addGlobalSimpleTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;Ljava/lang/String;)V", "public final")]
	public void addIDConstraintDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V", "public final")]
	public void addIDConstraintDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool hasIDConstraints()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V", "public")]
	public void addComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V", "public")]
	public void addRedefinedGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl> getUncheckedComplexTypeDecls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;", "final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator> getUncheckedCTLocators()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator>>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;", "final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl> getRedefinedGroupDecls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl>>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;", "final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator> getRGLocators()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator>>(ret);
	}

	[JniSignatureAttribute("(I)V", "final")]
	public void setUncheckedTypeNum(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl> getSubstitutionGroups()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>>(ret);
	}

	[JniSignatureAttribute("(S)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar getS4SGrammar(short arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
	}

	[JniSignatureAttribute("(I)V", "public synchronized")]
	public void removeDocument(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSchemaNamespace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/parsers/DOMParser;", "synchronized")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.DOMParser getDOMParser()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.DOMParser>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/parsers/SAXParser;", "synchronized")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.SAXParser getSAXParser()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.SAXParser>(ret);
	}

	[JniSignatureAttribute("(S)Lcom/sun/org/apache/xerces/internal/xs/datatypes/ObjectList;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.datatypes.ObjectList getComponentsExt(short arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.datatypes.ObjectList>(ret);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void resetComponents()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52]);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/StringList;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList getDocumentLocations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;)V", "public")]
	public void addAnnotation(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNamespaceAware()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)V", "public synchronized")]
	public void addDocument(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription getGrammarDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel toXSModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/xni/grammars/XSGrammar;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel toXSModel(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XSGrammar> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration getElementDeclaration(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration getAttributeDeclaration(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition getTypeDefinition(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition getAttributeGroup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition getModelGroupDefinition(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNotationDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNotationDeclaration getNotationDeclaration(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNotationDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSIDCDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSIDCDefinition getIDCDefinition(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSIDCDefinition>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getTargetNamespace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl getGlobalAttributeDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl getGlobalAttributeDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl getGlobalElementDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl getGlobalElementDecl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setImmutable(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("(S)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap getComponents(short arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;", "public static")]
	public partial class BuiltinSchemaGrammar
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BuiltinSchemaGrammar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTENDED_SCHEMA_FACTORY_CLASS", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IS)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setImportedGrammars", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDeclAll", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalNotationDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalNotationDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalTypeDecl", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalTypeDecl", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalSimpleTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalSimpleTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRedefinedGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOMParser", "()Lcom/sun/org/apache/xerces/internal/parsers/DOMParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSAXParser", "()Lcom/sun/org/apache/xerces/internal/parsers/SAXParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDocument", "(Ljava/lang/Object;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammarDescription", "()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String EXTENDED_SCHEMA_FACTORY_CLASS_Property
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
		public BuiltinSchemaGrammar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IS)V", "public")]
		public BuiltinSchemaGrammar(int arg0, short arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinSchemaGrammar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void setImportedGrammars(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalAttributeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;)V", "public")]
		public void addGlobalAttributeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalAttributeGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V", "public")]
		public void addGlobalAttributeGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "public")]
		public void addGlobalElementDeclAll(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "public")]
		public void addGlobalElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;)V", "public")]
		public void addGlobalGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;)V", "public")]
		public void addGlobalNotationDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalNotationDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/lang/String;)V", "public")]
		public void addGlobalTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)V", "public")]
		public void addGlobalTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)V", "public")]
		public void addGlobalComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)V", "public")]
		public void addGlobalSimpleTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/lang/String;)V", "public")]
		public void addGlobalSimpleTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V", "public")]
		public void addComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V", "public")]
		public void addRedefinedGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/parsers/DOMParser;", "synchronized")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.DOMParser getDOMParser()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.DOMParser>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/parsers/SAXParser;", "synchronized")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.SAXParser getSAXParser()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.SAXParser>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)V", "public synchronized")]
		public void addDocument(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription getGrammarDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$XSAnyType;", "private static")]
	public partial class XSAnyType
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XSAnyType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$XSAnyType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setName", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceItem", "()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createParticle", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAttrGrp", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIsAbstractType", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContainsTypeID", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIsAnonymous", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValues", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;SSSSZLcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XSAnyType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public XSAnyType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$XSAnyType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList getAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void setName(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem getNamespaceItem()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl createParticle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl createAttrGrp()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void setIsAbstractType()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void setContainsTypeID()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void setIsAnonymous()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;SSSSZLcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)V", "public")]
		public void setValues(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg2, short arg3, short arg4, short arg5, short arg6, bool arg7, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg8, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg9, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg10)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinAttrDecl;", "private static")]
	public partial class BuiltinAttrDecl
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BuiltinAttrDecl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinAttrDecl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;S)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotation", "()Lcom/sun/org/apache/xerces/internal/xs/XSAnnotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceItem", "()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValues", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;SSLcom/sun/org/apache/xerces/internal/impl/dv/ValidatedInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BuiltinAttrDecl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;S)V", "public")]
		public BuiltinAttrDecl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg2, short arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$BuiltinAttrDecl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSAnnotation;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAnnotation getAnnotation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAnnotation>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem getNamespaceItem()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;SSLcom/sun/org/apache/xerces/internal/impl/dv/ValidatedInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)V", "public")]
		public void setValues(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg2, short arg3, short arg4, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidatedInfo arg5, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$Schema4Annotations;", "public static final")]
	public partial class Schema4Annotations
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Schema4Annotations()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$Schema4Annotations;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$Schema4Annotations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setImportedGrammars", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalAttributeGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDeclAll", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalElementDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalNotationDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalNotationDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalTypeDecl", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalTypeDecl", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalSimpleTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGlobalSimpleTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addComplexTypeDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRedefinedGroupDecl", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOMParser", "()Lcom/sun/org/apache/xerces/internal/parsers/DOMParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSAXParser", "()Lcom/sun/org/apache/xerces/internal/parsers/SAXParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAnnotationElementDecl", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createUnboundedModelGroupParticle", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createChoiceElementParticle", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createUnboundedAnyWildcardSequenceParticle", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAnyLaxWildcardParticle", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDocument", "(Ljava/lang/Object;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammarDescription", "()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$Schema4Annotations;", "public static final")]
		public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar.Schema4Annotations INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar.Schema4Annotations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Schema4Annotations(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Schema4Annotations() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar$Schema4Annotations;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void setImportedGrammars(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalAttributeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;)V", "public")]
		public void addGlobalAttributeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalAttributeGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;)V", "public")]
		public void addGlobalAttributeGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "public")]
		public void addGlobalElementDeclAll(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "public")]
		public void addGlobalElementDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;)V", "public")]
		public void addGlobalGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalNotationDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSNotationDecl;)V", "public")]
		public void addGlobalNotationDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSNotationDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/lang/String;)V", "public")]
		public void addGlobalTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)V", "public")]
		public void addGlobalTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Ljava/lang/String;)V", "public")]
		public void addGlobalComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)V", "public")]
		public void addGlobalComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/lang/String;)V", "public")]
		public void addGlobalSimpleTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)V", "public")]
		public void addGlobalSimpleTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V", "public")]
		public void addComplexTypeDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;)V", "public")]
		public void addRedefinedGroupDecl(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGroupDecl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/parsers/DOMParser;", "synchronized")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.DOMParser getDOMParser()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.DOMParser>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/parsers/SAXParser;", "synchronized")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.SAXParser getSAXParser()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.parsers.SAXParser>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl createAnnotationElementDecl(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl createUnboundedModelGroupParticle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl createChoiceElementParticle(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl createUnboundedAnyWildcardSequenceParticle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl createAnyLaxWildcardParticle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)V", "public synchronized")]
		public void addDocument(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription getGrammarDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription>(ret);
		}
	}
}
