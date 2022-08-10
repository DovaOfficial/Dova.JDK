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

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;", "public final")]
public partial class XSDeclarationPool
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSDeclarationPool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHUNK_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHUNK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHUNK_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_CHUNK_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fElementDecl", "[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fElementDeclIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fParticleDecl", "[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fParticleDeclIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fModelGroup", "[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fModelGroupIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAttrDecl", "[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAttrDeclIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fCTDecl", "[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fCTDeclIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSTDecl", "[[Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSTDeclIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAttributeUse", "[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fAttributeUseIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dvFactory", "Lcom/sun/org/apache/xerces/internal/impl/dv/xs/SchemaDVFactoryImpl;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XSDeclarationPool", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resize", "([[Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resize", "([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resize", "([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resize", "([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resize", "([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resize", "([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resize", "([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAttributeUse", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getComplexTypeDecl", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParticleDecl", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureAttrDeclCapacity", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureAttributeUseCapacity", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureCTDeclCapacity", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureSTDeclCapacity", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureParticleDeclCapacity", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureModelGroupCapacity", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDVFactory", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/SchemaDVFactoryImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAttributeDecl", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureElementDeclCapacity", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElementDecl", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getModelGroup", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSimpleTypeDecl", "()Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CHUNK_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CHUNK_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CHUNK_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INITIAL_CHUNK_COUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private")]
	public JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>> fElementDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fElementDeclIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
	public JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>> fParticleDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fParticleDeclIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;", "private")]
	public JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelGroupImpl>> fModelGroup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelGroupImpl>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fModelGroupIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "private")]
	public JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>> fAttrDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fAttrDeclIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "private")]
	public JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>> fCTDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fCTDeclIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("[[Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;", "private")]
	public JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl>> fSTDecl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fSTDeclIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;", "private")]
	public JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeUseImpl>> fAttributeUse_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeUseImpl>>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fAttributeUseIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/SchemaDVFactoryImpl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.SchemaDVFactoryImpl dvFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.SchemaDVFactoryImpl>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSDeclarationPool(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XSDeclarationPool() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XSDeclarationPool;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("([[Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl>> resize(JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl>> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl>>>(ret);
	}

	[JniSignatureAttribute("([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>> resize(JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>>>(ret);
	}

	[JniSignatureAttribute("([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>> resize(JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>>>(ret);
	}

	[JniSignatureAttribute("([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeUseImpl>> resize(JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeUseImpl>> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeUseImpl>>>(ret);
	}

	[JniSignatureAttribute("([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelGroupImpl>> resize(JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelGroupImpl>> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelGroupImpl>>>(ret);
	}

	[JniSignatureAttribute("([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>> resize(JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>>>(ret);
	}

	[JniSignatureAttribute("([[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;I)[[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>> resize(JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeUseImpl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeUseImpl getAttributeUse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeUseImpl>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSComplexTypeDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl getComplexTypeDecl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSComplexTypeDecl>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl getParticleDecl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool ensureAttrDeclCapacity(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool ensureAttributeUseCapacity(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool ensureCTDeclCapacity(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool ensureSTDeclCapacity(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool ensureParticleDeclCapacity(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool ensureModelGroupCapacity(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/SchemaDVFactoryImpl;)V", "public")]
	public void setDVFactory(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.SchemaDVFactoryImpl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSAttributeDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl getAttributeDecl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSAttributeDecl>(ret);
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool ensureElementDeclCapacity(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSElementDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl getElementDecl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSElementDecl>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelGroupImpl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelGroupImpl getModelGroup()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelGroupImpl>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/dv/xs/XSSimpleTypeDecl;", "public final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl getSimpleTypeDecl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.XSSimpleTypeDecl>(ret);
	}
}
