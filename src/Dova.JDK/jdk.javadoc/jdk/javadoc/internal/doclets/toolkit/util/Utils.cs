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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "public")]
public partial class Utils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Utils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljdk/javadoc/internal/doclets/toolkit/BaseOptions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resources", "Ljdk/javadoc/internal/doclets/toolkit/Resources;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docTrees", "Lcom/sun/source/util/DocTrees;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elementUtils", "Ljavax/lang/model/util/Elements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeUtils", "Ljavax/lang/model/util/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "comparators", "Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javaScriptScanner", "Ljdk/javadoc/internal/doclets/toolkit/util/JavaScriptScanner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symtab", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kindNameMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tertiaryCollator", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DocCollator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "secondaryCollator", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DocCollator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modulePackageMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedClasses", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shouldDocumentVisitor", "Ljavax/lang/model/util/SimpleElementVisitor14;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameCache", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "snvisitor", "Ljavax/lang/model/util/SimpleElementVisitor14;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cve", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ConstantValueExpression;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "specifiedVisitor", "Ljavax/lang/model/util/SimpleElementVisitor14;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "commentHelperCache", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$CommentHelperCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dcTreeCache", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signature", "(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "(Ljavax/lang/model/element/ModuleElement$RequiresDirective;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInterface", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toLowerCase", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnum", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "(Ljavax/lang/model/element/TypeParameterElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMethod", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConstructor", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName0", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName", "(Ljavax/lang/model/element/PackageElement;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStatic", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "(Ljavax/lang/model/type/TypeMirror;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClasses", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFields", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethods", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructors", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnumConstants", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljavax/lang/model/element/Element;Ljava/lang/String;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPublic", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProtected", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubclassOf", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnumConstant", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefault", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinal", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAbstract", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isField", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrivate", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPackage", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParam", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVoid", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineNumber", "(Ljavax/lang/model/element/Element;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleName", "(Ljavax/lang/model/element/ModuleElement;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "quote", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSerializable", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOther", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "(Ljava/lang/String;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isText", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeprecated", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeprecated", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyName", "(Ljavax/lang/model/element/ExecutableElement;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectType", "()Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAttribute", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperType", "(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLiteral", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErroneous", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeprecatedForRemoval", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationType", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotated", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotated", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReference", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isThrowable", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArrayType", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDimension", "(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTreePath", "(Ljavax/lang/model/element/Element;)Lcom/sun/source/util/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstSentenceTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParamTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCanonicalRecordConstructor", "(Ljavax/lang/model/element/ExecutableElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isClass", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljavax/lang/model/element/ModuleElement;)Ljavax/tools/JavaFileManager$Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIdentifier", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileObject", "(Ljavax/lang/model/element/TypeElement;)Ljavax/tools/FileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredType", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredType", "(Ljava/util/Collection;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIncluded", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValue", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllClasses", "(Ljavax/lang/model/element/PackageElement;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFunctionalInterface", "(Ljavax/lang/model/element/AnnotationMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPackagePrivate", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllInterfaces", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllInterfaces", "(Ljavax/lang/model/type/TypeMirror;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocCommentTree", "(Ljavax/lang/model/element/Element;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFullBody", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "(Ljavax/lang/model/element/Element;Ljava/util/function/Predicate;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/taglets/Taglet;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "(Lcom/sun/source/doctree/DocCommentTree;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;Lcom/sun/source/doctree/DocTree$Kind;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "(Ljavax/lang/model/element/Element;Ljava/util/function/Predicate;Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreamble", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findMethod", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/element/ExecutableElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containingPackage", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/PackageElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFullyQualifiedName", "(Ljavax/lang/model/element/Element;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFullyQualifiedName", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executableMembersEqual", "(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/ExecutableElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTypeVariable", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingTypeElement", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultLocation", "()Ljavax/tools/JavaFileManager$Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProperty", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSerializableType", "()Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExternalizableType", "()Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "definesSerializableFields", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunctionalInterface", "()Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasHiddenTag", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLinkable", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLinkable", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrowableType", "()Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSignature", "(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;ZZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSignature", "(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asInstantiatedMethodType", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/type/ExecutableType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeSignature", "(Ljavax/lang/model/type/TypeMirror;ZZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreBounds", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldInstantiate", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overriddenType", "(Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNoType", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeElement", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSimpleOverride", "(Ljavax/lang/model/element/ExecutableElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTypeElement", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUndocumentedEnclosure", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstVisibleSuperClass", "(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstVisibleSuperClass", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeprecatedElement", "(Ljavax/lang/model/element/Element;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeprecatedType", "()Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasBlockTagUnchecked", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasBlockTag", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasBlockTag", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareStrings", "(ZLjava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareStrings", "(Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItems", "(Ljavax/lang/model/element/Element;ZLjava/util/function/Predicate;Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentedItems", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/ElementKind;Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllItems", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/ElementKind;Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recursiveGetItems", "(Ljava/util/Collection;Ljavax/lang/model/element/Element;ZLjava/util/function/Predicate;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItems0", "(Ljavax/lang/model/element/Element;ZLjava/util/function/Predicate;Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModule", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isKind", "(Lcom/sun/source/doctree/DocTree;Lcom/sun/source/doctree/DocTree$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasDocCommentTree", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommentHelper", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocCommentInfo", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocCommentInfo0", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOverviewElement", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocCommentTree0", "(Ljavax/lang/model/element/Element;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParamTrees", "(Ljavax/lang/model/element/Element;Z)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParamTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotations2Classes", "(Ljavax/lang/model/AnnotatedConstruct;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "types2Classes", "(Ljava/util/List;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotationValue2Classes", "(Ljavax/lang/model/element/AnnotationValue;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPreviewAPI", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReflectivePreviewAPI", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previewLanguageFeaturesUsed", "(Ljavax/lang/model/element/Element;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotation2Classes", "(Ljavax/lang/model/element/AnnotationMirror;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredUsingPreviewAPIs", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/Utils$PreviewSummary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNoProviewAnnotation", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifiedTypeName", "(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldDocument", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIllegalArgumentExceptionType", "()Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNullPointerExceptionType", "()Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "excludeDeprecatedMembers", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCoreClass", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForPackage", "(Ljavax/lang/model/element/PackageElement;)Ljavax/tools/JavaFileManager$Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyLabel", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializableFields", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializationMethods", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOrdinaryClass", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExecutableElement", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVariableElement", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flatSignature", "(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeclaredType", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErrorType", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIntersectionType", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTypeParameterElement", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWildCard", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asInstantiatedFieldType", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/VariableElement;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overriddenClass", "(Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overriddenMethod", "(Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/element/ExecutableElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeElementsAsSortedSet", "(Ljava/lang/Iterable;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSerialDataTrees", "(Ljavax/lang/model/element/ExecutableElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClassInPackageElement", "(Ljavax/lang/model/element/PackageElement;Ljava/lang/String;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isGenericType", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parsePackageName", "(Ljavax/lang/model/element/PackageElement;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDocumentedAnnotation", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstVisibleSuperClassAsTypeElement", "(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeElementKindName", "(Ljavax/lang/model/element/TypeElement;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceTabs", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizeNewlines", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeprecatedSince", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filterOutPrivateClasses", "(Ljava/lang/Iterable;Z)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elementsEqual", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareCaseCompare", "(Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHTMLTitle", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosedTypeElements", "(Ljavax/lang/model/element/PackageElement;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMembers", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationTypes", "(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecords", "(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldsUnfiltered", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrdinalValue", "(Ljavax/lang/model/element/VariableElement;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModulePackageMap", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDependentModules", "(Ljavax/lang/model/element/ModuleElement;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnums", "(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllClassesUnfiltered", "(Ljavax/lang/model/element/PackageElement;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constantValueExpression", "(Ljavax/lang/model/element/VariableElement;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnclosingPackageIncluded", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSpecified", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAuthor", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isComment", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDocComment", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDocRoot", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEndElement", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEntity", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isException", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInheritDoc", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLinkPlain", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReturn", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSee", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSerial", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSerialData", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSerialField", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSince", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStartElement", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isThrows", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnknownBlockTag", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnknownInlineTag", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVersion", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeCommentHelper", "(Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkJavaScriptInOption", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeprecatedTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvidesTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeeTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSerialTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSerialFieldTrees", "(Ljavax/lang/model/element/VariableElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrowsTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUsesTrees", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containingModule", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/ModuleElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTopMostContainingTypeElement", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elementFlags", "(Ljavax/lang/model/element/Element;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLink", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExternalizable", "(Ljavax/lang/model/element/TypeElement;)Z"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/BaseOptions;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseOptions options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseOptions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Resources;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources resources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/util/DocTrees;", "public final")]
	public Dova.JDK.com.sun.source.util.DocTrees docTrees_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTrees>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/Elements;", "public final")]
	public Dova.JDK.javax.lang.model.util.Elements elementUtils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/Types;", "public final")]
	public Dova.JDK.javax.lang.model.util.Types typeUtils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators comparators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/JavaScriptScanner;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.JavaScriptScanner javaScriptScanner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.JavaScriptScanner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private")]
	public Dova.JDK.java.util.HashMap symtab_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map kindNameMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DocCollator;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DocCollator tertiaryCollator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DocCollator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DocCollator;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DocCollator secondaryCollator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DocCollator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map modulePackageMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private final")]
	public Dova.JDK.java.util.HashMap cachedClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/SimpleElementVisitor14;", "private")]
	public Dova.JDK.javax.lang.model.util.SimpleElementVisitor14 shouldDocumentVisitor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.SimpleElementVisitor14>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map nameCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/SimpleElementVisitor14;", "private")]
	public Dova.JDK.javax.lang.model.util.SimpleElementVisitor14 snvisitor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.SimpleElementVisitor14>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ConstantValueExpression;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ConstantValueExpression cve_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ConstantValueExpression>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/SimpleElementVisitor14;", "private")]
	public Dova.JDK.javax.lang.model.util.SimpleElementVisitor14 specifiedVisitor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.SimpleElementVisitor14>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$CommentHelperCache;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.CommentHelperCache commentHelperCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.CommentHelperCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map dcTreeCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Utils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V", "public")]
	public Utils(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String signature(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$RequiresDirective;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getModifiers(Dova.JDK.javax.lang.model.element.ModuleElement.RequiresDirective arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isInterface(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isPrimitive(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toLowerCase(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getComponentType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isEnum(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isRecord(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeParameterElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBounds(Dova.JDK.javax.lang.model.element.TypeParameterElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getInterfaces(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isMethod(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getReturnType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.ExecutableElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isConstructor(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getSimpleName0(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSimpleName(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPackageName(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isStatic(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTypeName(Dova.JDK.javax.lang.model.type.TypeMirror arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getClasses(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFields(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getMethods(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getConstructors(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getEnumConstants(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/String;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement findClass(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isPublic(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isProtected(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isSubclassOf(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;", "private")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "")]
	public bool isEnumConstant(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isDefault(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isFinal(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isAbstract(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isField(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isPrivate(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isPackage(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isParam(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isVoid(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)J", "public")]
	public long getLineNumber(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getModuleName(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String quote(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isSerializable(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isOther(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getSymbol(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isText(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isDeprecated(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isDeprecated(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String propertyName(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getObjectType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isAttribute(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getSuperType(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isLiteral(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isErroneous(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isDeprecatedForRemoval(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isAnnotationType(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isAnnotated(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isAnnotated(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isReference(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isThrowable(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isArrayType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDimension(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Lcom/sun/source/util/TreePath;", "public")]
	public Dova.JDK.com.sun.source.util.TreePath getTreePath(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFirstSentenceTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getTypeParamTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Z", "public")]
	public bool isCanonicalRecordConstructor(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isClass(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljavax/tools/JavaFileManager$Location;", "public")]
	public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isIdentifier(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljavax/tools/FileObject;", "public")]
	public Dova.JDK.javax.tools.FileObject getFileObject(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getDeclaredType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getDeclaredType(Dova.JDK.java.util.Collection arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.type.TypeMirror arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isIncluded(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isValue(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet getAllClasses(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/AnnotationMirror;)Z", "public")]
	public bool isFunctionalInterface(Dova.JDK.javax.lang.model.element.AnnotationMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isPackagePrivate(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getAllInterfaces(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljava/util/Set;)V", "private")]
	public void getAllInterfaces(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Lcom/sun/source/doctree/DocCommentTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree getDocCommentTree(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBody(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFullBody(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/function/Predicate;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBlockTags(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.function.Predicate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBlockTags(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/taglets/Taglet;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBlockTags(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.Taglet arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocCommentTree;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBlockTags(Dova.JDK.com.sun.source.doctree.DocCommentTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBlockTags(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;Lcom/sun/source/doctree/DocTree$Kind;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBlockTags(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/function/Predicate;Ljava/lang/Class;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBlockTags(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;Ljava/lang/Class;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBlockTags(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getPreamble(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPropertyName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/element/ExecutableElement;", "public")]
	public Dova.JDK.javax.lang.model.element.ExecutableElement findMethod(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.ExecutableElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.ExecutableElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/PackageElement;", "public")]
	public Dova.JDK.javax.lang.model.element.PackageElement containingPackage(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFullyQualifiedName(Dova.JDK.javax.lang.model.element.Element arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFullyQualifiedName(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/ExecutableElement;)Z", "public")]
	public bool executableMembersEqual(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.javax.lang.model.element.ExecutableElement arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isTypeVariable(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getEnclosingTypeElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("()Ljavax/tools/JavaFileManager$Location;", "private")]
	public Dova.JDK.javax.tools.JavaFileManager.Location defaultLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool isProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getSerializableType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[99]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getExternalizableType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool definesSerializableFields(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[101], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getFunctionalInterface()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool hasHiddenTag(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[103], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isLinkable(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isLinkable(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[105], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getThrowableType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;ZZ)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String makeSignature(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String makeSignature(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/type/ExecutableType;", "public")]
	public Dova.JDK.javax.lang.model.type.ExecutableType asInstantiatedMethodType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.ExecutableElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.ExecutableType>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;ZZ)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTypeSignature(Dova.JDK.javax.lang.model.type.TypeMirror arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool ignoreBounds(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[111], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;)Z", "private")]
	public bool shouldInstantiate(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[112], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror overriddenType(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isNoType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[114], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement asTypeElement(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[115], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Z", "public")]
	public bool isSimpleOverride(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[116], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isTypeElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[117], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isUndocumentedEnclosure(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[118], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getFirstVisibleSuperClass(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[119], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getFirstVisibleSuperClass(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[120], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/String;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getDeprecatedElement(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getDeprecatedType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[122]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;)Z", "")]
	public bool hasBlockTagUnchecked(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;Ljava/lang/String;)Z", "public")]
	public bool hasBlockTag(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[124], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree$Kind;)Z", "public")]
	public bool hasBlockTag(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[125], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ZLjava/lang/String;Ljava/lang/String;)I", "")]
	public int compareStrings(bool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[126], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int compareStrings(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[127], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;ZLjava/util/function/Predicate;Ljava/lang/Class;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getItems(Dova.JDK.javax.lang.model.element.Element arg0, bool arg1, Dova.JDK.java.util.function.Predicate arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[128], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/ElementKind;Ljava/lang/Class;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getDocumentedItems(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.ElementKind arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[129], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/ElementKind;Ljava/lang/Class;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getAllItems(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.ElementKind arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Ljavax/lang/model/element/Element;ZLjava/util/function/Predicate;Ljava/lang/Class;)V", "private")]
	public void recursiveGetItems(Dova.JDK.java.util.Collection arg0, Dova.JDK.javax.lang.model.element.Element arg1, bool arg2, Dova.JDK.java.util.function.Predicate arg3, Dova.JDK.java.lang.Class arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[131], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;ZLjava/util/function/Predicate;Ljava/lang/Class;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getItems0(Dova.JDK.javax.lang.model.element.Element arg0, bool arg1, Dova.JDK.java.util.function.Predicate arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isModule(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[133], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Lcom/sun/source/doctree/DocTree$Kind;)Z", "private")]
	public bool isKind(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool hasDocCommentTree(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[135], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper getCommentHelper(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[136], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo getDocCommentInfo(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[137], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo getDocCommentInfo0(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[138], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isOverviewElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[139], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Lcom/sun/source/doctree/DocCommentTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree getDocCommentTree0(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[140], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Z)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getParamTrees(Dova.JDK.javax.lang.model.element.Element arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[141], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getParamTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[142], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/AnnotatedConstruct;)Ljava/util/Collection;", "private")]
	public Dova.JDK.java.util.Collection annotations2Classes(Dova.JDK.javax.lang.model.AnnotatedConstruct arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[143], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/Collection;", "private")]
	public Dova.JDK.java.util.Collection types2Classes(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[144], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/AnnotationValue;)Ljava/util/Collection;", "private")]
	public Dova.JDK.java.util.Collection annotationValue2Classes(Dova.JDK.javax.lang.model.element.AnnotationValue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[145], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isPreviewAPI(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[146], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isReflectivePreviewAPI(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[147], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set previewLanguageFeaturesUsed(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[148], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/AnnotationMirror;)Ljava/util/Collection;", "private")]
	public Dova.JDK.java.util.Collection annotation2Classes(Dova.JDK.javax.lang.model.element.AnnotationMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[149], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/Utils$PreviewSummary;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.PreviewSummary declaredUsingPreviewAPIs(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[150], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.PreviewSummary>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "private")]
	public bool hasNoProviewAnnotation(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[151], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getQualifiedTypeName(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[152], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool shouldDocument(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[153], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getIllegalArgumentExceptionType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[154]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getNullPointerExceptionType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[155]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List excludeDeprecatedMembers(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[156], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isCoreClass(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[157], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljavax/tools/JavaFileManager$Location;", "public")]
	public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForPackage(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[158], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPropertyLabel(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[159], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet serializableFields(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[160], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet serializationMethods(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[161], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isOrdinaryClass(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[162], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isExecutableElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[163], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isVariableElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[164], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String flatSignature(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[165], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isDeclaredType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[166], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isErrorType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[167], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isIntersectionType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[168], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isTypeParameterElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[169], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isWildCard(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[170], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/VariableElement;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror asInstantiatedFieldType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.VariableElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[171], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement overriddenClass(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[172], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/element/ExecutableElement;", "public")]
	public Dova.JDK.javax.lang.model.element.ExecutableElement overriddenMethod(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[173], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.ExecutableElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet getTypeElementsAsSortedSet(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[174], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getSerialDataTrees(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[175], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljava/lang/String;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement findClassInPackageElement(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[176], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "public")]
	public bool isGenericType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[177], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String parsePackageName(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[178], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isDocumentedAnnotation(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[179], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getSuperClass(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[180], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getFirstVisibleSuperClassAsTypeElement(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[181], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTypeElementKindName(Dova.JDK.javax.lang.model.element.TypeElement arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[182], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replaceTabs(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[183], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "public")]
	public Dova.JDK.java.lang.CharSequence normalizeNewlines(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[184], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDeprecatedSince(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[185], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;Z)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet filterOutPrivateClasses(Dova.JDK.java.lang.Iterable arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[186], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)Z", "public")]
	public bool elementsEqual(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[187], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int compareCaseCompare(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[188], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getHTMLTitle(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[189], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable getEnclosedTypeElements(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[190], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getAnnotationMembers(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[191], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getAnnotationTypes(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[192], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getRecords(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[193], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFieldsUnfiltered(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[194], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;)I", "public")]
	public int getOrdinalValue(Dova.JDK.javax.lang.model.element.VariableElement arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[195], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getModulePackageMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[196]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getDependentModules(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[197], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getEnums(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[198], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet getAllClassesUnfiltered(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[199], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String constantValueExpression(Dova.JDK.javax.lang.model.element.VariableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[200], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isEnclosingPackageIncluded(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[201], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public")]
	public bool isSpecified(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[202], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isAuthor(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[203], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isComment(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[204], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isDocComment(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[205], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isDocRoot(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[206], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isEndElement(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[207], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isEntity(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[208], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isException(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[209], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isInheritDoc(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[210], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isLinkPlain(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[211], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isReturn(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[212], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isSee(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[213], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isSerial(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[214], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isSerialData(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[215], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isSerialField(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[216], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isSince(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[217], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isStartElement(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[218], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isThrows(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[219], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isUnknownBlockTag(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[220], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isUnknownInlineTag(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[221], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isVersion(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[222], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)V", "public")]
	public void removeCommentHelper(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[223], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void checkJavaScriptInOption(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[224], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getDeprecatedTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[225], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getProvidesTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[226], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getSeeTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[227], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getSerialTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[228], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getSerialFieldTrees(Dova.JDK.javax.lang.model.element.VariableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[229], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getThrowsTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[230], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getReturnTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[231], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getUsesTrees(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[232], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/ModuleElement;", "public")]
	public Dova.JDK.javax.lang.model.element.ModuleElement containingModule(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[233], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.ModuleElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getTopMostContainingTypeElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[234], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set elementFlags(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[235], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isLink(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[236], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isExternalizable(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[237], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DocCollator;", "private static")]
	public partial class DocCollator
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DocCollator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DocCollator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keys", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instance", "Ljava/text/Collator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "MAX_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Locale;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/String;Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "(Ljava/lang/String;)Ljava/text/CollationKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCollator", "(Ljava/util/Locale;)Ljava/text/Collator;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map keys_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/text/Collator;", "private final")]
		public Dova.JDK.java.text.Collator instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.text.Collator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int MAX_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DocCollator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Locale;I)V", "private")]
		public DocCollator(Dova.JDK.java.util.Locale arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DocCollator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
		public int compare(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/text/CollationKey;", "")]
		public Dova.JDK.java.text.CollationKey getKey(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.CollationKey>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/text/Collator;", "private")]
		public Dova.JDK.java.text.Collator createCollator(Dova.JDK.java.util.Locale arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.Collator>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ConstantValueExpression;", "private static")]
	public partial class ConstantValueExpression
		: Dova.JDK.javax.lang.model.util.TypeKindVisitor9
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConstantValueExpression()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ConstantValueExpression;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultAction_0", "(Ljavax/lang/model/type/TypeMirror;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultAction_1", "(Ljavax/lang/model/type/TypeMirror;Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsBoolean_0", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsBoolean_1", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sourceChar", "(CLjava/lang/StringBuilder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sourceForm", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sourceForm", "(DC)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unicodeEscape", "(CLjava/lang/StringBuilder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsDouble_0", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsDouble_1", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsFloat_0", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsFloat_1", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsChar_0", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsChar_1", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsLong_0", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsLong_1", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsByte_0", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveAsByte_1", "(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrintableAscii", "(C)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConstantValueExpression(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ConstantValueExpression() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ConstantValueExpression;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljava/lang/Object;)Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object defaultAction_0(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljava/lang/Object;)Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String defaultAction_1(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitPrimitiveAsBoolean_0(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPrimitiveAsBoolean_1(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(CLjava/lang/StringBuilder;)V", "private")]
		public void sourceChar(char arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String sourceForm(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(DC)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String sourceForm(double arg0, char arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(CLjava/lang/StringBuilder;)V", "private")]
		public void unicodeEscape(char arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPrimitiveAsDouble_0(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitPrimitiveAsDouble_1(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPrimitiveAsFloat_0(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitPrimitiveAsFloat_1(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitPrimitiveAsChar_0(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPrimitiveAsChar_1(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitPrimitiveAsLong_0(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPrimitiveAsLong_1(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitPrimitiveAsByte_0(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPrimitiveAsByte_1(Dova.JDK.javax.lang.model.type.PrimitiveType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(C)Z", "private")]
		public bool isPrintableAscii(char arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$CommentHelperCache;", "private static")]
	public partial class CommentHelperCache
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CommentHelperCache()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$CommentHelperCache;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "map", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/Object;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeIfAbsent", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map map_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "private final")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CommentHelperCache(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)V", "public")]
		public CommentHelperCache(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$CommentHelperCache;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;", "public")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper remove(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;", "public")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper get(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;", "public")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper put(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;", "public")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper computeIfAbsent(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.CommentHelper>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$PreviewSummary;", "public static final")]
	public partial class PreviewSummary
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PreviewSummary()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$PreviewSummary;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previewAPI", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reflectivePreviewAPI", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredUsingPreviewFeature", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "public final")]
		public Dova.JDK.java.util.Set previewAPI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "public final")]
		public Dova.JDK.java.util.Set reflectivePreviewAPI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "public final")]
		public Dova.JDK.java.util.Set declaredUsingPreviewFeature_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PreviewSummary(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;)V", "public")]
		public PreviewSummary(Dova.JDK.java.util.Set arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.java.util.Set arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$PreviewSummary;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;", "public static final")]
	public partial class ElementFlag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ElementFlag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEPRECATED", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREVIEW", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag DEPRECATED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag PREVIEW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ElementFlag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ElementFlag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$ElementFlag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.ElementFlag>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;", "public static final")]
	public partial class DeclarationPreviewLanguageFeatures
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DeclarationPreviewLanguageFeatures()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "features", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List features_Property
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

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DeclarationPreviewLanguageFeatures(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/List;)V", "private")]
		public DeclarationPreviewLanguageFeatures(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/util/Utils$DeclarationPreviewLanguageFeatures;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils.DeclarationPreviewLanguageFeatures>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$Pair;", "public static")]
	public partial class Pair
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Pair()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Utils$Pair;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "first", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "second", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object first_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object second_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Pair(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
		public Pair(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Utils$Pair;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
