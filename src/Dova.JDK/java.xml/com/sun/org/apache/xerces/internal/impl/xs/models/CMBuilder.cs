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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMBuilder;", "public")]
public partial class CMBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CMBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fDeclPool", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fEmptyCM", "Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSEmptyCM;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLeafCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fParticleCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fNodeFactory", "Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMNodeFactory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CMBuilder", "(Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMNodeFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createAllCM", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createDFACM", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Z)Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "useRepeatingLeafNodes", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buildCompactSyntaxTree", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "expandContentModel", "(Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;IIZ)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "multiNodes", "(Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;IZ)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyNode", "(Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buildCompactSyntaxTree2", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;II)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDeclPool", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getContentModel", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Z)Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buildSyntaxTree", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;ZZ)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool fDeclPool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSEmptyCM;", "private static")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSEmptyCM fEmptyCM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSEmptyCM>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fLeafCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int fParticleCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMNodeFactory;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.CMNodeFactory fNodeFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.CMNodeFactory>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CMBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMNodeFactory;)V", "public")]
	public CMBuilder(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.CMNodeFactory arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/models/CMBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator createAllCM(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;Z)Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator createDFACM(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Z", "private")]
	public bool useRepeatingLeafNodes(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode buildCompactSyntaxTree(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;IIZ)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode expandContentModel(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode arg0, int arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;IZ)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode multiNodes(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode copyNode(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;II)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode buildCompactSyntaxTree2(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;)V", "public")]
	public void setDeclPool(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDeclarationPool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;Z)Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator getContentModel(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models.XSCMValidator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;ZZ)Lcom/sun/org/apache/xerces/internal/impl/dtd/models/CMNode;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode buildSyntaxTree(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models.CMNode>(ret);
	}
}
