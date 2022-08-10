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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSConstraints;", "public")]
public partial class XSConstraints
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSConstraints()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XSConstraints;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OCCURRENCE_UNKNOWN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STRING_TYPE", "Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fEmptyParticle", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ELEMENT_PARTICLE_COMPARATOR", "Ljava/util/Comparator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XSConstraints", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkSimpleDerivation", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;S)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkComplexDerivation", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;S)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "particleValidRestriction", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "particleValidRestriction", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkElementDeclsConsistent", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/util/SymbolHash;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "findElemInTable", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/util/SymbolHash;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNonUnaryGroup", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "removePointlessChildren", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "addElementToParticleVector", "(Ljava/util/List;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkNameAndTypeOK", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;IILcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkNSCompat", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;IILcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;IIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkRecurseLax", "(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkRecurse", "(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkNSSubset", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;IILcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkNSRecurseCheckCardinality", "(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;IIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkRecurseUnordered", "(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkMapAndSum", "(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "gatherChildren", "(ILcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkOccurrenceRange", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkIDConstraintRestriction", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "overlapUPA", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "overlapUPA", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "overlapUPA", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "overlapUPA", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getEmptySequence", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkComplexDerivationOk", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;S)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkTypeDerivationOk", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;S)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ElementDefaultValidImmediate", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidatedInfo;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fullSchemaChecking", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMBuilder;Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "reportSchemaError", "(Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkSimpleDerivationOk", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;S)Z"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int OCCURRENCE_UNKNOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType STRING_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl fEmptyParticle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private static final")]
	public static Dova.JDK.java.util.Comparator ELEMENT_PARTICLE_COMPARATOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSConstraints(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XSConstraints() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XSConstraints;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;S)Z", "private static")]
	public static bool checkSimpleDerivation(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;S)Z", "private static")]
	public static bool checkComplexDerivation(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Z)Z", "private static")]
	public static bool particleValidRestriction(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z", "private static")]
	public static bool particleValidRestriction(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Lcom/sun/org/apache/xerces/internal/util/SymbolHash;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V", "public static")]
	public static void checkElementDeclsConsistent(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/util/SymbolHash;)V", "public static")]
	public static void findElemInTable(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl getNonUnaryGroup(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List removePointlessChildren(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "private static")]
	public static void addElementToParticleVector(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;IILcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;II)V", "private static")]
	public static void checkNameAndTypeOK(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;IILcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;IIZ)V", "private static")]
	public static void checkNSCompat(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl arg3, int arg4, int arg5, bool arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V", "private static")]
	public static void checkRecurseLax(Dova.JDK.java.util.List arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg3, Dova.JDK.java.util.List arg4, int arg5, int arg6, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V", "private static")]
	public static void checkRecurse(Dova.JDK.java.util.List arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg3, Dova.JDK.java.util.List arg4, int arg5, int arg6, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;IILcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;II)V", "private static")]
	public static void checkNSSubset(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;IIZ)V", "private static")]
	public static void checkNSRecurseCheckCardinality(Dova.JDK.java.util.List arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg4, int arg5, int arg6, bool arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V", "private static")]
	public static void checkRecurseUnordered(Dova.JDK.java.util.List arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg3, Dova.JDK.java.util.List arg4, int arg5, int arg6, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Ljava/util/List;IILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)V", "private static")]
	public static void checkMapAndSum(Dova.JDK.java.util.List arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg3, Dova.JDK.java.util.List arg4, int arg5, int arg6, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Ljava/util/List;)V", "private static")]
	public static void gatherChildren(int arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIII)Z", "private static")]
	public static bool checkOccurrenceRange(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;)V", "private static")]
	public static void checkIDConstraintRestriction(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;)Z", "public static")]
	public static bool overlapUPA(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z", "public static")]
	public static bool overlapUPA(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z", "public static")]
	public static bool overlapUPA(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z", "public static")]
	public static bool overlapUPA(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl getEmptySequence()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;S)Z", "public static")]
	public static bool checkComplexDerivationOk(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;S)Z", "public static")]
	public static bool checkTypeDerivationOk(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidatedInfo;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object ElementDefaultValidImmediate(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidationContext arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidatedInfo arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMBuilder;Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;)V", "public static")]
	public static void fullSchemaChecking(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSGrammarBucket arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.CMBuilder arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;Lcom/sun/org/apache/xerces/internal/impl/xs/util/SimpleLocator;Ljava/lang/String;[Ljava/lang/Object;)V", "static")]
	public static void reportSchemaError(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.SimpleLocator arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;S)Z", "public static")]
	public static bool checkSimpleDerivationOk(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return ret;
	}
}
