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

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDComplexTypeTraverser;", "")]
public partial class XSDComplexTypeTraverser
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAbstractParticleTraverser
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSDComplexTypeTraverser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDComplexTypeTraverser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GLOBAL_NUM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fErrorContent", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fErrorWildcard", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTargetNamespace", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDerivedBy", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fFinal", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fBlock", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fContentType", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fBaseType", "Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAttrGrp", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fXSSimpleType", "Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fParticle", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIsAbstract", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fComplexTypeDecl", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAnnotations", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalStore", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalStorePos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAnnotation", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseLocal", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeAttributes", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;ZLorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getErrorWildcard", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "genAnonTypeName", "(Lorg/w3c/dom/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentBackup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseComplexTypeDecl", "(Lorg/w3c/dom/Element;Ljava/lang/String;[Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentRestore", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processComplexContent", "(Lorg/w3c/dom/Element;ZZLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseSimpleContent", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseComplexContent", "(Lorg/w3c/dom/Element;ZLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleComplexTypeError", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAttrOrAttrGroup", "(Lorg/w3c/dom/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getErrorContent", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseSimpleContentDecl", "(Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseComplexContentDecl", "(Lorg/w3c/dom/Element;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseGlobal", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int GLOBAL_NUM_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl fErrorContent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl fErrorWildcard_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fTargetNamespace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("S", "private")]
	public short fDerivedBy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("S", "private")]
	public short fFinal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("S", "private")]
	public short fBlock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("S", "private")]
	public short fContentType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition fBaseType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl fAttrGrp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType fXSSimpleType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl fParticle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fIsAbstract_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl fComplexTypeDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl> fAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
	public JavaArray<Dova.JDK.java.lang.Object> fGlobalStore_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fGlobalStorePos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSDComplexTypeTraverser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;)V", "")]
	public XSDComplexTypeTraverser(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSAttributeChecker arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDComplexTypeTraverser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAnnotationImpl;)V", "private")]
	public void addAnnotation(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAnnotationImpl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl traverseLocal(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeGroupDecl;Ljava/lang/String;ZLorg/w3c/dom/Element;)V", "private")]
	public void mergeAttributes(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeGroupDecl arg1, Dova.JDK.java.lang.String arg2, bool arg3, Dova.JDK.org.w3c.dom.Element arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSWildcardDecl;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl getErrorWildcard()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSWildcardDecl>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String genAnonTypeName(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void contentBackup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;[Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl traverseComplexTypeDecl(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void contentRestore()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;ZZLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void processComplexContent(Dova.JDK.org.w3c.dom.Element arg0, bool arg1, bool arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void traverseSimpleContent(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;ZLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
	public void traverseComplexContent(Dova.JDK.org.w3c.dom.Element arg0, bool arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V", "private")]
	public void handleComplexTypeError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Z", "private")]
	public bool isAttrOrAttrGroup(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl getErrorContent()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "private")]
	public void traverseSimpleContentDecl(Dova.JDK.org.w3c.dom.Element arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Z)V", "private")]
	public void traverseComplexContentDecl(Dova.JDK.org.w3c.dom.Element arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl traverseGlobal(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDComplexTypeTraverser$ComplexTypeRecoverableError;", "private static final")]
	public partial class ComplexTypeRecoverableError
		: Dova.JDK.java.lang.Exception
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComplexTypeRecoverableError()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDComplexTypeTraverser$ComplexTypeRecoverableError;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorSubstText", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorElem", "Lorg/w3c/dom/Element;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V"));
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

		[JniSignatureAttribute("[Ljava/lang/Object;", "")]
		public JavaArray<Dova.JDK.java.lang.Object> errorSubstText_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/w3c/dom/Element;", "")]
		public Dova.JDK.org.w3c.dom.Element errorElem_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ComplexTypeRecoverableError(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ComplexTypeRecoverableError() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lorg/w3c/dom/Element;)V", "")]
		public ComplexTypeRecoverableError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.org.w3c.dom.Element arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDComplexTypeTraverser$ComplexTypeRecoverableError;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
