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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractTraverser;", "abstract")]
public partial class XSDAbstractTraverser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSDAbstractTraverser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractTraverser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_ALL_CONTEXT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROCESSING_ALL_EL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GROUP_REF_WITH_ALL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHILD_OF_GROUP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROCESSING_ALL_GP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSchemaHandler", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAttrChecker", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidateAnnotations", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fValidationState", "Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fQNameDV", "Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPattern", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xsFacets", "Lcom/sun/org/apache/xerces/internal/impl/dv/XSFacets;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;ZLjava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSchemaTypeName", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkOccurrences", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Ljava/lang/String;Lorg/w3c/dom/Element;IJ)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "processAttValue", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsQName", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkEnumerationAndLengthInconsistency", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/util/List;Lorg/w3c/dom/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkEnumerationAndMinLengthInconsistency", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/util/List;Lorg/w3c/dom/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkEnumerationAndMaxLengthInconsistency", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/util/List;Lorg/w3c/dom/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "escapeAttValue", "(Ljava/lang/String;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseFacets", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractTraverser$FacetInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseAttrsAndAttrGrps", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkNotationType", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportSchemaWarning", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportSchemaError", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseAnnotationDecl", "(Lorg/w3c/dom/Element;[Ljava/lang/Object;ZLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseSyntheticAnnotation", "(Lorg/w3c/dom/Element;Ljava/lang/String;[Ljava/lang/Object;ZLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String NO_NAME_Property
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

	[JniSignatureAttribute("I", "protected static final")]
	public static int NOT_ALL_CONTEXT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int PROCESSING_ALL_EL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int GROUP_REF_WITH_ALL_Property
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

	[JniSignatureAttribute("I", "protected static final")]
	public static int CHILD_OF_GROUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int PROCESSING_ALL_GP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler fSchemaHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSAttributeChecker fAttrChecker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSAttributeChecker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fValidateAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/validation/ValidationState;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationState fValidationState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.validation.ValidationState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "private static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType fQNameDV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private")]
	public Dova.JDK.java.lang.StringBuilder fPattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/XSFacets;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSFacets xsFacets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSFacets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSDAbstractTraverser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;)V", "")]
	public XSDAbstractTraverser(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSAttributeChecker arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractTraverser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;ZLjava/util/Locale;)V", "")]
	public void reset(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0, bool arg1, Dova.JDK.java.util.Locale arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getSchemaTypeName(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Ljava/lang/String;Lorg/w3c/dom/Element;IJ)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl checkOccurrences(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.org.w3c.dom.Element arg2, int arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String processAttValue(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)Z", "private")]
	public bool containsQName(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/util/List;Lorg/w3c/dom/Element;Ljava/lang/String;)V", "private")]
	public void checkEnumerationAndLengthInconsistency(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0, Dova.JDK.java.util.List arg1, Dova.JDK.org.w3c.dom.Element arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/util/List;Lorg/w3c/dom/Element;Ljava/lang/String;)V", "private")]
	public void checkEnumerationAndMinLengthInconsistency(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0, Dova.JDK.java.util.List arg1, Dova.JDK.org.w3c.dom.Element arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Ljava/util/List;Lorg/w3c/dom/Element;Ljava/lang/String;)V", "private")]
	public void checkEnumerationAndMaxLengthInconsistency(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0, Dova.JDK.java.util.List arg1, Dova.JDK.org.w3c.dom.Element arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String escapeAttValue(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractTraverser$FacetInfo;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAbstractTraverser.FacetInfo traverseFacets(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAbstractTraverser.FacetInfo>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;)Lorg/w3c/dom/Element;", "")]
	public Dova.JDK.org.w3c.dom.Element traverseAttrsAndAttrGrps(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;Lorg/w3c/dom/Element;)V", "")]
	public void checkNotationType(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V", "")]
	public void reportSchemaWarning(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V", "")]
	public void reportSchemaError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;[Ljava/lang/Object;ZLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl traverseAnnotationDecl(Dova.JDK.org.w3c.dom.Element arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, bool arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;[Ljava/lang/Object;ZLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl traverseSyntheticAnnotation(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, bool arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractTraverser$FacetInfo;", "static final")]
	public partial class FacetInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FacetInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractTraverser$FacetInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "facetdata", "Lcom/sun/org/apache/xerces/internal/impl/dv/XSFacets;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nodeAfterFacets", "Lorg/w3c/dom/Element;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPresentFacets", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fFixedFacets", "S"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSFacets;Lorg/w3c/dom/Element;SS)V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/XSFacets;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSFacets facetdata_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSFacets>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/w3c/dom/Element;", "final")]
		public Dova.JDK.org.w3c.dom.Element nodeAfterFacets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("S", "final")]
		public short fPresentFacets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("S", "final")]
		public short fFixedFacets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FacetInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSFacets;Lorg/w3c/dom/Element;SS)V", "")]
		public FacetInfo(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSFacets arg0, Dova.JDK.org.w3c.dom.Element arg1, short arg2, short arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractTraverser$FacetInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
