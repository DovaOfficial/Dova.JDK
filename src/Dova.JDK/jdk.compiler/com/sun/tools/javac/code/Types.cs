/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.code;

[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "public")]
public partial class Types
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Types()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "typesKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syms", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messages", "Lcom/sun/tools/javac/util/JavacMessages;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowDefaultMethods", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mapCapturesToBounds", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chk", "Lcom/sun/tools/javac/comp/Check;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enter", "Lcom/sun/tools/javac/comp/Enter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "warnStack", "Lcom/sun/tools/javac/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "capturedName", "Lcom/sun/tools/javac/util/Name;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noWarnings", "Lcom/sun/tools/javac/util/Warner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isUnbounded", "Lcom/sun/tools/javac/code/Types$UnaryVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asSub", "Lcom/sun/tools/javac/code/Types$SimpleVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descCache", "Lcom/sun/tools/javac/code/Types$DescriptorCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeFilter", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isSubtype", "Lcom/sun/tools/javac/code/Types$TypeRelation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isSameTypeVisitor", "Lcom/sun/tools/javac/code/Types$TypeRelation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "containsType", "Lcom/sun/tools/javac/code/Types$TypeRelation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isCastable", "Lcom/sun/tools/javac/code/Types$TypeRelation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "disjointType", "Lcom/sun/tools/javac/code/Types$TypeRelation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cvarLowerBoundMapping", "Lcom/sun/tools/javac/code/Types$TypeMapping;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isReifiable", "Lcom/sun/tools/javac/code/Types$UnaryVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elemTypeFun", "Lcom/sun/tools/javac/code/Types$TypeMapping;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asSuper", "Lcom/sun/tools/javac/code/Types$SimpleVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "memberType", "Lcom/sun/tools/javac/code/Types$SimpleVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "erasure", "Lcom/sun/tools/javac/code/Types$TypeMapping;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supertype", "Lcom/sun/tools/javac/code/Types$UnaryVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "Lcom/sun/tools/javac/code/Types$UnaryVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directSupertypes", "Lcom/sun/tools/javac/code/Types$UnaryVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isDerivedRawCache", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classBound", "Lcom/sun/tools/javac/code/Types$UnaryVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implCache", "Lcom/sun/tools/javac/code/Types$ImplementationCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "membersCache", "Lcom/sun/tools/javac/code/Types$MembersClosureCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "candidatesCache", "Lcom/sun/tools/javac/code/Types$CandidatesCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasSameArgs_strict", "Lcom/sun/tools/javac/code/Types$TypeRelation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasSameArgs_nonstrict", "Lcom/sun/tools/javac/code/Types$TypeRelation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "newInstanceFun", "Lcom/sun/tools/javac/code/Types$TypeMapping;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodWithParameters", "Lcom/sun/tools/javac/code/Types$MapVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodWithThrown", "Lcom/sun/tools/javac/code/Types$MapVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodWithReturn", "Lcom/sun/tools/javac/code/Types$MapVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closureCache", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "basicClosureSkip", "Ljava/util/function/BiPredicate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mergeCache", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arraySuperType", "Lcom/sun/tools/javac/code/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "hashCodeVisitor", "Lcom/sun/tools/javac/code/Types$HashCodeVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "hashCodeStrictVisitor", "Lcom/sun/tools/javac/code/Types$HashCodeVisitor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Lcom/sun/tools/javac/code/Symbol;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Lcom/sun/tools/javac/code/Type;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Lcom/sun/tools/javac/code/Type;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "(Lcom/sun/tools/javac/code/Type;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "(Lcom/sun/tools/javac/code/Type;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insert", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insert", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;Ljava/util/function/BiPredicate;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "(Lcom/sun/tools/javac/code/Type$TypeVar;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interfaces", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dimensions", "(Lcom/sun/tools/javac/code/Type;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "memberType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/code/Types;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implementation", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;ZLjava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adapt", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/ListBuffer;Lcom/sun/tools/javac/util/ListBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "union", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Ljava/util/function/BiPredicate;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "union", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closure", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "capture", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "capture", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supertype", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elemtype", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDescriptorType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createErrorType", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createErrorType", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createErrorType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignable", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignable", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "directSupertypes", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overrideEquivalent", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSuper", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cvarLowerBounds", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cvarUpperBound", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubSignature", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubSignature", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subst", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subst", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtypeUnchecked", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtypeUnchecked", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtypeUnchecked", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstances", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMethodTypeWithReturn", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirectSuperInterface", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtypeNoCapture", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtype", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtype", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asOuterSuper", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "erasure", "(Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "erasure", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "erasure", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firstUnimplementedAbstract", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeAbstracts", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;Z)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnTypeSubstitutable", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnTypeSubstitutable", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resultSubtype", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDerivedRaw", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDerivedRaw", "(Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipTypeVars", "(Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "substBounds", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disjointType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closureMin", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boxedClass", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Symbol$ClassSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unboxedType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intersect", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnbounded", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSub", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsType", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCastable", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCastable", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReifiable", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classBound", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wildUpperBound", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wildLowerBound", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cvarLowerBound", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boxedTypeOrType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConvertible", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConvertible", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDescriptorSymbol", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "glb", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "glb", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFunctionalInterface", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFunctionalInterface", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "membersClosure", "(Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/code/Scope$CompoundScope;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pendingBridges", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtypeUncheckedInternal", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;ZLcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkUnsafeVarargsConversion", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSuperType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameWildcard", "(Lcom/sun/tools/javac/code/Type$WildcardType;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsTypeEquivalent", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsTypeEquivalent", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "areDisjoint", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relaxBound", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rewriteQuantifiers", "(Lcom/sun/tools/javac/code/Type;ZZ)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eraseNotNeeded", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeIntersectionType", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type$IntersectionClassType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeIntersectionType", "(Lcom/sun/tools/javac/util/List;Z)Lcom/sun/tools/javac/code/Type$IntersectionClassType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDerivedRawInternal", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSameArgs", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSameArgs", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types$TypeRelation;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSameArgs", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameTypes", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMethodTypeWithThrown", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firstUnimplementedAbstractImpl", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interfaceCandidates", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prune", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typaramsString", "(Lcom/sun/tools/javac/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendTyparamString", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lub", "([Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lub", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arraySuperType", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "erasedSupertypes", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compoundMin", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "glbFlattened", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "covariantReturnType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freshTypeVariables", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "superClosure", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disjointTypes", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "giveWarning", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRetention", "(Lcom/sun/tools/javac/code/Attribute$Compound;)Lcom/sun/tools/javac/code/Attribute$RetentionPolicy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRetention", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/code/Attribute$RetentionPolicy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upward", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeWildcards", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeFunctionalInterfaceClass", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;J)Lcom/sun/tools/javac/code/Symbol$ClassSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "functionalInterfaceBridges", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtypes", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtypesUnchecked", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSignaturePolymorphic", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containedBy", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCaptureOf", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$WildcardType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notSoftSubtype", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elemtypeOrType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asEnclosingSuper", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "erasureRecursive", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "erasureRecursive", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overridesObjectMethod", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Symbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "substBound", "(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type$TypeVar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMethodTypeWithParameters", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closureCollector", "(ZLjava/util/function/BiPredicate;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unboxedTypeOrType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sideCast", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sideCastFinal", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adaptSelf", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/ListBuffer;Lcom/sun/tools/javac/util/ListBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeExtendsWildcard", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$TypeVar;)Lcom/sun/tools/javac/code/Type$WildcardType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSuperWildcard", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$TypeVar;)Lcom/sun/tools/javac/code/Type$WildcardType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newRound", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "captures", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSameBounds", "(Lcom/sun/tools/javac/code/Type$ForAll;Lcom/sun/tools/javac/code/Type$ForAll;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeArrayType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type$ArrayType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rank", "(Lcom/sun/tools/javac/code/Type;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constantType", "(Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/util/List;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/util/List;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key typesKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.Symtab syms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symtab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JavacMessages;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.JavacMessages messages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JavacMessages>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool allowDefaultMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool mapCapturesToBounds_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Check;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Check chk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Enter;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Enter enter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Enter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
	public Dova.JDK.com.sun.tools.javac.util.List warnStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.Name capturedName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Warner;", "public final")]
	public Dova.JDK.com.sun.tools.javac.util.Warner noWarnings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Warner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UnaryVisitor;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor isUnbounded_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$SimpleVisitor;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor asSub_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DescriptorCache;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache descCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private")]
	public Dova.JDK.java.util.function.Predicate bridgeFilter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeRelation;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation isSubtype_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeRelation;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation isSameTypeVisitor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeRelation;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation containsType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeRelation;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation isCastable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeRelation;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation disjointType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeMapping;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping cvarLowerBoundMapping_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UnaryVisitor;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor isReifiable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeMapping;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping elemTypeFun_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$SimpleVisitor;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor asSuper_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$SimpleVisitor;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor memberType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeMapping;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping erasure_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UnaryVisitor;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor supertype_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UnaryVisitor;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor interfaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UnaryVisitor;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor directSupertypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map isDerivedRawCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UnaryVisitor;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor classBound_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$ImplementationCache;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.ImplementationCache implCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.ImplementationCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MembersClosureCache;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types.MembersClosureCache membersCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.MembersClosureCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$CandidatesCache;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Types.CandidatesCache candidatesCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.CandidatesCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeRelation;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation hasSameArgs_strict_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeRelation;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation hasSameArgs_nonstrict_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeMapping;", "private static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping newInstanceFun_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MapVisitor;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor methodWithParameters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MapVisitor;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor methodWithThrown_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MapVisitor;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor methodWithReturn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map closureCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/BiPredicate;", "")]
	public Dova.JDK.java.util.function.BiPredicate basicClosureSkip_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiPredicate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set mergeCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type arraySuperType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$HashCodeVisitor;", "private static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Types.HashCodeVisitor hashCodeVisitor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.HashCodeVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$HashCodeVisitor;", "private static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Types.HashCodeVisitor hashCodeStrictVisitor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.HashCodeVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Types(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public Types(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)I", "public")]
	public int hashCode(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Z)I", "public")]
	public int hashCode(Dova.JDK.com.sun.tools.javac.code.Type arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isArray(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List insert(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;Ljava/util/function/BiPredicate;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List insert(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.java.util.function.BiPredicate arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List getBounds(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List interfaces(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type merge(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)I", "public")]
	public int dimensions(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type memberType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/code/Types;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.Types instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;ZLjava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol implementation(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, bool arg2, Dova.JDK.java.util.function.Predicate arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/ListBuffer;Lcom/sun/tools/javac/util/ListBuffer;)V", "public")]
	public void adapt(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg2, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Ljava/util/function/BiPredicate;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List union(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.java.util.function.BiPredicate arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List union(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List closure(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type capture(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List capture(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type supertype(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type elemtype(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type findDescriptorType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type createErrorType(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type createErrorType(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type createErrorType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isSameType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool isAssignable(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isAssignable(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List directSupertypes(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool overrideEquivalent(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type asSuper(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List cvarLowerBounds(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type cvarUpperBound(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Z)Z", "public")]
	public bool isSubSignature(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isSubSignature(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type subst(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List subst(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool isSubtypeUnchecked(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool isSubtypeUnchecked(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isSubtypeUnchecked(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List newInstances(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type createMethodTypeWithReturn(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Z", "public")]
	public bool isDirectSuperInterface(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public final")]
	public bool isSubtypeNoCapture(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Z)Z", "public")]
	public bool isSubtype(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public final")]
	public bool isSubtype(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type asOuterSuper(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type erasure(Dova.JDK.com.sun.tools.javac.code.Type arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type erasure(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List erasure(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol firstUnimplementedAbstract(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;Z)Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional mergeAbstracts(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool returnTypeSubstitutable(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.util.Warner arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool returnTypeSubstitutable(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool resultSubtype(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isDerivedRaw(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Z", "public")]
	public bool isDerivedRaw(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type skipTypeVars(Dova.JDK.com.sun.tools.javac.code.Type arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List substBounds(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool disjointType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List closureMin(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Symbol$ClassSymbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol boxedClass(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type unboxedType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List intersect(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isUnbounded(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type asSub(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool containsType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z", "")]
	public bool containsType(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isCastable(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool isCastable(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isReifiable(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type classBound(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type wildUpperBound(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type wildLowerBound(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type cvarLowerBound(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type boxedTypeOrType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool isConvertible(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isConvertible(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/code/Symbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol findDescriptorSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type glb(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type glb(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isFunctionalInterface(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Z", "public")]
	public bool isFunctionalInterface(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/code/Scope$CompoundScope;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope membersClosure(Dova.JDK.com.sun.tools.javac.code.Type arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Z", "private")]
	public bool pendingBridges(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;ZLcom/sun/tools/javac/util/Warner;)Z", "private")]
	public bool isSubtypeUncheckedInternal(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, bool arg2, Dova.JDK.com.sun.tools.javac.util.Warner arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)V", "private")]
	public void checkUnsafeVarargsConversion(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isSuperType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isSameWildcard(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "private")]
	public bool containsTypeEquivalent(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z", "public")]
	public bool containsTypeEquivalent(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Z", "private")]
	public bool areDisjoint(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[93], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type relaxBound(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;ZZ)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type rewriteQuantifiers(Dova.JDK.com.sun.tools.javac.code.Type arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "private")]
	public bool eraseNotNeeded(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type$IntersectionClassType;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type.IntersectionClassType makeIntersectionType(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.IntersectionClassType>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Z)Lcom/sun/tools/javac/code/Type$IntersectionClassType;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type.IntersectionClassType makeIntersectionType(Dova.JDK.com.sun.tools.javac.util.List arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[98], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.IntersectionClassType>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool isDerivedRawInternal(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[99], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Z)Z", "public")]
	public bool hasSameArgs(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types$TypeRelation;)Z", "private")]
	public bool hasSameArgs(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[101], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool hasSameArgs(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[102], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z", "public")]
	public bool isSameTypes(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type createMethodTypeWithThrown(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol firstUnimplementedAbstractImpl(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List interfaceCandidates(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List prune(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String typaramsString(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/StringBuilder;)V", "private")]
	public void appendTyparamString(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.StringBuilder arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[109], arg0, arg1);
	}

	[JniSignatureAttribute("([Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public transient")]
	public Dova.JDK.com.sun.tools.javac.code.Type lub(JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type lub(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[111], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type arraySuperType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[112]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "")]
	public Dova.JDK.com.sun.tools.javac.util.List erasedSupertypes(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type compoundMin(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type glbFlattened(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool covariantReturnType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List freshTypeVariables(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[117], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List superClosure(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z", "public")]
	public bool disjointTypes(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[119], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "private")]
	public bool giveWarning(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Compound;)Lcom/sun/tools/javac/code/Attribute$RetentionPolicy;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Attribute.RetentionPolicy getRetention(Dova.JDK.com.sun.tools.javac.code.Attribute.Compound arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[121], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Attribute.RetentionPolicy>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/code/Attribute$RetentionPolicy;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Attribute.RetentionPolicy getRetention(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[122], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Attribute.RetentionPolicy>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type upward(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type removeWildcards(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[124], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;J)Lcom/sun/tools/javac/code/Symbol$ClassSymbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol makeFunctionalInterfaceClass(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[125], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List functionalInterfaceBridges(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[126], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z", "public")]
	public bool isSubtypes(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[127], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
	public bool isSubtypesUnchecked(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[128], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)Z", "public")]
	public bool isSignaturePolymorphic(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[129], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool containedBy(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$WildcardType;)Z", "public")]
	public bool isCaptureOf(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[131], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool notSoftSubtype(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type elemtypeOrType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[133], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type asEnclosingSuper(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List erasureRecursive(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[135], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type erasureRecursive(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[136], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
	public bool overridesObjectMethod(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[137], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type$TypeVar;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type.TypeVar substBound(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[138], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.TypeVar>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type createMethodTypeWithParameters(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[139], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(ZLjava/util/function/BiPredicate;)Ljava/util/stream/Collector;", "public")]
	public Dova.JDK.java.util.stream.Collector closureCollector(bool arg0, Dova.JDK.java.util.function.BiPredicate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[140], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type unboxedTypeOrType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[141], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "private")]
	public bool sideCast(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[142], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "private")]
	public bool sideCastFinal(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[143], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/ListBuffer;Lcom/sun/tools/javac/util/ListBuffer;)V", "private")]
	public void adaptSelf(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg1, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[144], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$TypeVar;)Lcom/sun/tools/javac/code/Type$WildcardType;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type.WildcardType makeExtendsWildcard(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[145], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.WildcardType>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$TypeVar;)Lcom/sun/tools/javac/code/Type$WildcardType;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type.WildcardType makeSuperWildcard(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[146], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.WildcardType>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void newRound()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[147]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List captures(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[148], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Lcom/sun/tools/javac/code/Type$ForAll;)Z", "public")]
	public bool hasSameBounds(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[149], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type$ArrayType;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type.ArrayType makeArrayType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[150], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ArrayType>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)I", "public")]
	public int rank(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[151], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type constantType(Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[152], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/util/List;Z)V", "public")]
	public void setBounds(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[153], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/util/List;)V", "public")]
	public void setBounds(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[154], arg0, arg1);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UnaryVisitor;", "public abstract static")]
	public partial class UnaryVisitor
		: Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnaryVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$UnaryVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lcom/sun/tools/javac/code/Type;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnaryVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public UnaryVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$UnaryVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object visit(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$SimpleVisitor;", "public abstract static")]
	public partial class SimpleVisitor
		: Dova.JDK.com.sun.tools.javac.code.Types.DefaultTypeVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$SimpleVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUndetVar", "(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SimpleVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$SimpleVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitForAll(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitUndetVar(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DescriptorCache;", "")]
	public partial class DescriptorCache
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DescriptorCache()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$DescriptorCache;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_map", "Ljava/util/WeakHashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "failure", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "failure", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeDescriptors", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDescriptorInternal", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Scope$CompoundScope;)Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;"));
		}

		[JniSignatureAttribute("Ljava/util/WeakHashMap;", "private")]
		public Dova.JDK.java.util.WeakHashMap _map_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.WeakHashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DescriptorCache(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)V", "")]
		public DescriptorCache(Dova.JDK.com.sun.tools.javac.code.Types arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$DescriptorCache;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor get(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;", "transient")]
		public Dova.JDK.com.sun.tools.javac.code.Types.FunctionDescriptorLookupError failure(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.FunctionDescriptorLookupError>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Types.FunctionDescriptorLookupError failure(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.FunctionDescriptorLookupError>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor mergeDescriptors(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Scope$CompoundScope;)Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor findDescriptorInternal(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DescriptorCache$Entry;", "")]
		public partial class Entry
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Entry()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$DescriptorCache$Entry;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedDescRes", "Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevMark", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types$DescriptorCache;Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(I)Z"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor cachedDescRes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int prevMark_Property
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
			public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$DescriptorCache;Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;I)V", "public")]
			public Entry(Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache arg0, Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache.FunctionDescriptor arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$DescriptorCache$Entry;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Z", "")]
			public bool matches(int arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;", "")]
		public partial class FunctionDescriptor
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FunctionDescriptor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descSym", "Lcom/sun/tools/javac/code/Symbol;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/code/Types$DescriptorCache;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types$DescriptorCache;Lcom/sun/tools/javac/code/Symbol;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Lcom/sun/tools/javac/code/Symbol;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol descSym_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DescriptorCache;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FunctionDescriptor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$DescriptorCache;Lcom/sun/tools/javac/code/Symbol;)V", "")]
			public FunctionDescriptor(Dova.JDK.com.sun.tools.javac.code.Types.DescriptorCache arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$DescriptorCache$FunctionDescriptor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
			public Dova.JDK.com.sun.tools.javac.code.Type getType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Symbol;", "public")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol getSymbol()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeRelation;", "public abstract static")]
	public partial class TypeRelation
		: Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeRelation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$TypeRelation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeRelation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public TypeRelation() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$TypeRelation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeMapping;", "public static")]
	public partial class TypeMapping
		: Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor
		, Dova.JDK.java.util.function.Function
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeMapping()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$TypeMapping;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lcom/sun/tools/javac/util/List;Ljava/lang/Object;)Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType_0", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType_1", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeMapping(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public TypeMapping() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$TypeMapping;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object apply(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type apply(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Ljava/lang/Object;)Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List visit(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitCapturedType_0(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitCapturedType_1(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$ImplementationCache;", "")]
	public partial class ImplementationCache
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImplementationCache()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$ImplementationCache;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_map", "Ljava/util/WeakHashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;ZLjava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implementationInternal", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;ZLjava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
		}

		[JniSignatureAttribute("Ljava/util/WeakHashMap;", "private")]
		public Dova.JDK.java.util.WeakHashMap _map_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.WeakHashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImplementationCache(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)V", "")]
		public ImplementationCache(Dova.JDK.com.sun.tools.javac.code.Types arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$ImplementationCache;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;ZLjava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol get(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, bool arg2, Dova.JDK.java.util.function.Predicate arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;ZLjava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol implementationInternal(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, bool arg2, Dova.JDK.java.util.function.Predicate arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$ImplementationCache$Entry;", "")]
		public partial class Entry
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Entry()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$ImplementationCache$Entry;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedImpl", "Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implFilter", "Ljava/util/function/Predicate;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "checkResult", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevMark", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types$ImplementationCache;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Ljava/util/function/Predicate;ZI)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/util/function/Predicate;ZI)Z"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol cachedImpl_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/function/Predicate;", "final")]
			public Dova.JDK.java.util.function.Predicate implFilter_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool checkResult_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int prevMark_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$ImplementationCache;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Ljava/util/function/Predicate;ZI)V", "public")]
			public Entry(Dova.JDK.com.sun.tools.javac.code.Types.ImplementationCache arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg1, Dova.JDK.java.util.function.Predicate arg2, bool arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$ImplementationCache$Entry;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/Predicate;ZI)Z", "")]
			public bool matches(Dova.JDK.java.util.function.Predicate arg0, bool arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MembersClosureCache;", "")]
	public partial class MembersClosureCache
		: Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MembersClosureCache()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$MembersClosureCache;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_map", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "seenTypes", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nilScope", "Lcom/sun/tools/javac/code/Scope$CompoundScope;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Scope$CompoundScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Scope$CompoundScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Scope$CompoundScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map _map_Property
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

		[JniSignatureAttribute("Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set seenTypes_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$CompoundScope;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope nilScope_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MembersClosureCache(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)V", "")]
		public MembersClosureCache(Dova.JDK.com.sun.tools.javac.code.Types arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$MembersClosureCache;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Scope$CompoundScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Scope$CompoundScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Scope$CompoundScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MembersClosureCache$MembersScope;", "")]
		public partial class MembersScope
			: Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MembersScope()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$MembersClosureCache$MembersScope;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scope", "Lcom/sun/tools/javac/code/Scope$CompoundScope;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types$MembersClosureCache;Lcom/sun/tools/javac/code/Scope$CompoundScope;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "combine", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMark", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbols", "(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$CompoundScope;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope scope_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public MembersScope(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$MembersClosureCache;Lcom/sun/tools/javac/code/Scope$CompoundScope;)V", "public")]
			public MembersScope(Dova.JDK.com.sun.tools.javac.code.Types.MembersClosureCache arg0, Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$MembersClosureCache$MembersScope;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", "")]
			public Dova.JDK.java.util.function.Predicate combine(Dova.JDK.java.util.function.Predicate arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getMark()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
			public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
			public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$CandidatesCache;", "public")]
	public partial class CandidatesCache
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CandidatesCache()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$CandidatesCache;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cache", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Lcom/sun/tools/javac/code/Types$CandidatesCache$Entry;)Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Lcom/sun/tools/javac/code/Types$CandidatesCache$Entry;Lcom/sun/tools/javac/util/List;)V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map cache_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CandidatesCache(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)V", "public")]
		public CandidatesCache(Dova.JDK.com.sun.tools.javac.code.Types arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$CandidatesCache;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$CandidatesCache$Entry;)Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List get(Dova.JDK.com.sun.tools.javac.code.Types.CandidatesCache.Entry arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$CandidatesCache$Entry;Lcom/sun/tools/javac/util/List;)V", "public")]
		public void put(Dova.JDK.com.sun.tools.javac.code.Types.CandidatesCache.Entry arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$CandidatesCache$Entry;", "")]
		public partial class Entry
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Entry()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$CandidatesCache$Entry;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "site", "Lcom/sun/tools/javac/code/Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "msym", "Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/code/Types$CandidatesCache;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types$CandidatesCache;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Type site_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol msym_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$CandidatesCache;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Types.CandidatesCache this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.CandidatesCache>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$CandidatesCache;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)V", "")]
			public Entry(Dova.JDK.com.sun.tools.javac.code.Types.CandidatesCache arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$CandidatesCache$Entry;";
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
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$HasSameArgs;", "private")]
	public partial class HasSameArgs
		: Dova.JDK.com.sun.tools.javac.code.Types.TypeRelation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HasSameArgs()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$HasSameArgs;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strict", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll", "(Lcom/sun/tools/javac/code/Type$ForAll;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErrorType", "(Lcom/sun/tools/javac/code/Type$ErrorType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErrorType", "(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool strict_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HasSameArgs(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Z)V", "public")]
		public HasSameArgs(Dova.JDK.com.sun.tools.javac.code.Types arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$HasSameArgs;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean visitForAll(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitForAll(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean visitMethodType(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ErrorType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean visitErrorType(Dova.JDK.com.sun.tools.javac.code.Type.ErrorType arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitErrorType(Dova.JDK.com.sun.tools.javac.code.Type.ErrorType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MapVisitor;", "public static")]
	public partial class MapVisitor
		: Dova.JDK.com.sun.tools.javac.code.Types.DefaultTypeVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MapVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$MapVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType_0", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType_1", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MapVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public MapVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$MapVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public final")]
		public Dova.JDK.com.sun.tools.javac.code.Type visit(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType_0(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitType_1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeProjection;", "")]
	public partial class TypeProjection
		: Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeProjection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$TypeProjection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vars", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "seen", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapTypeArgument", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List vars_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set seen_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeProjection(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/util/List;)V", "public")]
		public TypeProjection(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$TypeProjection;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Type mapTypeArgument(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeProjection$TypeArgumentProjection;", "")]
		public partial class TypeArgumentProjection
			: Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeArgumentProjection()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$TypeProjection$TypeArgumentProjection;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "site", "Lcom/sun/tools/javac/code/Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredBound", "Lcom/sun/tools/javac/code/Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/code/Types$TypeProjection;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types$TypeProjection;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType_0", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType_1", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeWildcard", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;)Lcom/sun/tools/javac/code/Type;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Type site_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Type declaredBound_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeProjection;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Types.TypeProjection this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeProjection>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TypeArgumentProjection(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$TypeProjection;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V", "")]
			public TypeArgumentProjection(Dova.JDK.com.sun.tools.javac.code.Types.TypeProjection arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$TypeProjection$TypeArgumentProjection;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
			public Dova.JDK.com.sun.tools.javac.code.Type visitType_0(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitType_1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;", "public")]
			public Dova.JDK.com.sun.tools.javac.code.Type visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Lcom/sun/tools/javac/code/Types$ProjectionKind;)Lcom/sun/tools/javac/code/Type;", "public")]
			public Dova.JDK.com.sun.tools.javac.code.Type visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;)Lcom/sun/tools/javac/code/Type;", "private")]
			public Dova.JDK.com.sun.tools.javac.code.Type makeWildcard(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.BoundKind arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$ProjectionKind;", "abstract static")]
	public partial class ProjectionKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProjectionKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$ProjectionKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPWARDS", "Lcom/sun/tools/javac/code/Types$ProjectionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOWNWARDS", "Lcom/sun/tools/javac/code/Types$ProjectionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Types$ProjectionKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/code/Types$ProjectionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Types$ProjectionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complement", "()Lcom/sun/tools/javac/code/Types$ProjectionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/code/Types$ProjectionKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$ProjectionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind UPWARDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$ProjectionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind DOWNWARDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Types$ProjectionKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProjectionKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ProjectionKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$ProjectionKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Types$ProjectionKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Types$ProjectionKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Types$ProjectionKind;", "abstract")]
		public Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind complement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Types$ProjectionKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.ProjectionKind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$CaptureScanner;", "")]
	public partial class CaptureScanner
		: Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CaptureScanner()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$CaptureScanner;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/util/Set;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/util/Set;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/util/Set;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/util/Set;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/util/Set;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/util/Set;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CaptureScanner(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)V", "")]
		public CaptureScanner(Dova.JDK.com.sun.tools.javac.code.Types arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$CaptureScanner;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/util/Set;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/util/Set;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/util/Set;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/Set;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/util/Set;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/util/Set;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;", "public static")]
	public partial class FunctionDescriptorLookupError
		: Dova.JDK.java.lang.RuntimeException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FunctionDescriptorLookupError()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diagnostic", "Lcom/sun/tools/javac/util/JCDiagnostic;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMessage", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDiagnostic", "()Lcom/sun/tools/javac/util/JCDiagnostic;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic;", "transient")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic diagnostic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FunctionDescriptorLookupError(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public FunctionDescriptorLookupError() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/code/Types$FunctionDescriptorLookupError;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Types.FunctionDescriptorLookupError setMessage(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.FunctionDescriptorLookupError>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/JCDiagnostic;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic getDiagnostic()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;", "public abstract static")]
	public partial class MostSpecificReturnCheck
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MostSpecificReturnCheck()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASIC", "Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RTS", "Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck BASIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck RTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MostSpecificReturnCheck(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public MostSpecificReturnCheck(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck>>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)Z", "public abstract")]
		public bool test(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Types arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Types$MostSpecificReturnCheck;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Types.MostSpecificReturnCheck>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MethodFilter;", "private")]
	public partial class MethodFilter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.function.Predicate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$MethodFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "msym", "Lcom/sun/tools/javac/code/Symbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "site", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol msym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type site_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MethodFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)V", "")]
		public MethodFilter(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$MethodFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
		public bool test(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool test(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$Subst;", "private")]
	public partial class Subst
		: Dova.JDK.com.sun.tools.javac.code.Type.StructuralTypeMapping
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Subst()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$Subst;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "from", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "to", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll_0", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll_1", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType_0", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType_1", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType_0", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType_1", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List from_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List to_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Subst(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V", "public")]
		public Subst(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$Subst;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitForAll_0(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitForAll_1(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitForAll(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitClassType_0(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType_1(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitWildcardType_0(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitWildcardType_1(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypePair;", "")]
	public partial class TypePair
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypePair()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$TypePair;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "t1", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "t2", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Type t1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Type t2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypePair(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V", "")]
		public TypePair(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$TypePair;";
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$HashCodeVisitor;", "private static")]
	public partial class HashCodeVisitor
		: Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HashCodeVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$HashCodeVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Void;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Void;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUndetVar", "(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Void;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUndetVar", "(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Void;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Void;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErrorType", "(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErrorType", "(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Void;)Ljava/lang/Integer;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HashCodeVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public HashCodeVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$HashCodeVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Void;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Void;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Void;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitUndetVar(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitUndetVar(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Void;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Void;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitMethodType(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitErrorType(Dova.JDK.com.sun.tools.javac.code.Type.ErrorType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Void;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitErrorType(Dova.JDK.com.sun.tools.javac.code.Type.ErrorType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$Adapter;", "")]
	public partial class Adapter
		: Dova.JDK.com.sun.tools.javac.code.Types.SimpleVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Adapter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$Adapter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "from", "Lcom/sun/tools/javac/util/ListBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "to", "Lcom/sun/tools/javac/util/ListBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mapping", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cache", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/util/ListBuffer;Lcom/sun/tools/javac/util/ListBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adapt", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adaptRecursive", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adaptRecursive", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/ListBuffer;", "")]
		public Dova.JDK.com.sun.tools.javac.util.ListBuffer from_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ListBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/ListBuffer;", "")]
		public Dova.JDK.com.sun.tools.javac.util.ListBuffer to_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ListBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "")]
		public Dova.JDK.java.util.Map mapping_Property
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

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set cache_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/util/ListBuffer;Lcom/sun/tools/javac/util/ListBuffer;)V", "")]
		public Adapter(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg1, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$Adapter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public void adapt(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V", "private")]
		public void adaptRecursive(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V", "private")]
		public void adaptRecursive(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$AdaptFailure;", "public static")]
	public partial class AdaptFailure
		: Dova.JDK.java.lang.RuntimeException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AdaptFailure()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$AdaptFailure;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("J", "static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AdaptFailure(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AdaptFailure() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$AdaptFailure;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$Rewriter;", "")]
	public partial class Rewriter
		: Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Rewriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$Rewriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "high", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rewriteTypeVars", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "B", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rewriteAsWildcardType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/BoundKind;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool high_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool rewriteTypeVars_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Rewriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;ZZ)V", "")]
		public Rewriter(Dova.JDK.com.sun.tools.javac.code.Types arg0, bool arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$Rewriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type B(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/BoundKind;)Lcom/sun/tools/javac/code/Type;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Type rewriteAsWildcardType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg1, Dova.JDK.com.sun.tools.javac.code.BoundKind arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$ClosureHolder;", "")]
	public partial class ClosureHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClosureHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$ClosureHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closure", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minClosure", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shouldSkip", "Ljava/util/function/BiPredicate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;ZLjava/util/function/BiPredicate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lcom/sun/tools/javac/code/Types$ClosureHolder;)Lcom/sun/tools/javac/code/Types$ClosureHolder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closure", "()Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List closure_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool minClosure_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/BiPredicate;", "final")]
		public Dova.JDK.java.util.function.BiPredicate shouldSkip_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiPredicate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClosureHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;ZLjava/util/function/BiPredicate;)V", "")]
		public ClosureHolder(Dova.JDK.com.sun.tools.javac.code.Types arg0, bool arg1, Dova.JDK.java.util.function.BiPredicate arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$ClosureHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "")]
		public void add(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$ClosureHolder;)Lcom/sun/tools/javac/code/Types$ClosureHolder;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Types.ClosureHolder merge(Dova.JDK.com.sun.tools.javac.code.Types.ClosureHolder arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.ClosureHolder>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List closure()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$SignatureGenerator;", "public abstract static")]
	public partial class SignatureGenerator
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$SignatureGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lcom/sun/tools/javac/util/Name;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "([B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assembleParamsSig", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assembleClassSig", "(Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportIllegalSignature", "(Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classReference", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasTypeVar", "(Lcom/sun/tools/javac/util/List;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assembleSig", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assembleSig", "(Lcom/sun/tools/javac/code/Type;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Types types_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SignatureGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)V", "protected")]
		public SignatureGenerator(Dova.JDK.com.sun.tools.javac.code.Types arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$SignatureGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(C)V", "protected abstract")]
		public void append(char arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)V", "protected abstract")]
		public void append(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("([B)V", "protected abstract")]
		public void append(JavaArray<byte> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "public")]
		public void assembleParamsSig(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "public")]
		public void assembleClassSig(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "protected")]
		public void reportIllegalSignature(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "protected")]
		public void classReference(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Z", "public")]
		public bool hasTypeVar(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "public")]
		public void assembleSig(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "public")]
		public void assembleSig(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$SignatureGenerator$InvalidSignatureException;", "public static")]
		public partial class InvalidSignatureException
			: Dova.JDK.java.lang.RuntimeException
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InvalidSignatureException()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$SignatureGenerator$InvalidSignatureException;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/javac/code/Type;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Lcom/sun/tools/javac/code/Type;"));
			}

			[JniSignatureAttribute("J", "private static final")]
			public static long serialVersionUID_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "private final transient")]
			public Dova.JDK.com.sun.tools.javac.code.Type type_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InvalidSignatureException(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "")]
			public InvalidSignatureException(Dova.JDK.com.sun.tools.javac.code.Type arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$SignatureGenerator$InvalidSignatureException;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
			public Dova.JDK.com.sun.tools.javac.code.Type type()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DefaultSymbolVisitor;", "public abstract static")]
	public partial class DefaultSymbolVisitor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.code.Symbol.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultSymbolVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$DefaultSymbolVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeSymbol", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassSymbol", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackageSymbol", "(Lcom/sun/tools/javac/code/Symbol$PackageSymbol;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodSymbol", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarSymbol", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOperatorSymbol", "(Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultSymbolVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DefaultSymbolVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$DefaultSymbolVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object visit(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitTypeSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitClassSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$PackageSymbol;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitPackageSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.PackageSymbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitMethodSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitVarSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitOperatorSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.OperatorSymbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DefaultTypeVisitor;", "public abstract static")]
	public partial class DefaultTypeVisitor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.code.Type.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultTypeVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$DefaultTypeVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackageType", "(Lcom/sun/tools/javac/code/Type$PackageType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUndetVar", "(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleType", "(Lcom/sun/tools/javac/code/Type$ModuleType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErrorType", "(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultTypeVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DefaultTypeVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$DefaultTypeVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object visit(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$PackageType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitPackageType(Dova.JDK.com.sun.tools.javac.code.Type.PackageType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitForAll(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitUndetVar(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ModuleType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitModuleType(Dova.JDK.com.sun.tools.javac.code.Type.ModuleType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitErrorType(Dova.JDK.com.sun.tools.javac.code.Type.ErrorType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UniqueType;", "public static")]
	public partial class UniqueType
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniqueType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$UniqueType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public final")]
		public Dova.JDK.com.sun.tools.javac.code.Type type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types types_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniqueType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)V", "public")]
		public UniqueType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Types arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$UniqueType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DescriptorFilter;", "")]
	public partial class DescriptorFilter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.function.Predicate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DescriptorFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Types$DescriptorFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "Lcom/sun/tools/javac/code/Symbol$TypeSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/code/Types;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$TypeSymbol;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol origin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Types this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DescriptorFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V", "")]
		public DescriptorFilter(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Types$DescriptorFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
		public bool test(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool test(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}
}
