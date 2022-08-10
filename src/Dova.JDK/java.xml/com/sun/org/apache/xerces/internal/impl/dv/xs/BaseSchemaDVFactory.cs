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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/BaseSchemaDVFactory;", "public abstract")]
public partial class BaseSchemaDVFactory
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.SchemaDVFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BaseSchemaDVFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/BaseSchemaDVFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "URI_SCHEMAFORSCHEMA", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fDeclPool", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BaseSchemaDVFactory", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDeclPool", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTypeList", "(Ljava/lang/String;Ljava/lang/String;SLcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTypeRestriction", "(Ljava/lang/String;Ljava/lang/String;SLcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTypeUnion", "(Ljava/lang/String;Ljava/lang/String;S[Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createBuiltInTypes", "(Lcom/sun/org/apache/xerces/internal/util/SymbolHash;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newXSSimpleTypeDecl", "()Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String URI_SCHEMAFORSCHEMA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool fDeclPool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BaseSchemaDVFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BaseSchemaDVFactory() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dv/xs/BaseSchemaDVFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;)V", "public")]
	public void setDeclPool(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;SLcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType createTypeList(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, short arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;SLcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType createTypeRestriction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, short arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;S[Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType createTypeUnion(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, short arg2, JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType> arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolHash;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;)V", "protected static")]
	public static void createBuiltInTypes(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl newXSSimpleTypeDecl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl>(ret);
	}
}
