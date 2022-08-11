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

namespace Dova.JDK.sun.reflect.generics.tree;

[JniSignatureAttribute("Lsun/reflect/generics/tree/MethodTypeSignature;", "public")]
public partial class MethodTypeSignature
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.reflect.generics.tree.Signature
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodTypeSignature()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/tree/MethodTypeSignature;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "formalTypeParams", "[Lsun/reflect/generics/tree/FormalTypeParameter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypes", "[Lsun/reflect/generics/tree/TypeSignature;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnType", "Lsun/reflect/generics/tree/ReturnType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionTypes", "[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lsun/reflect/generics/tree/FormalTypeParameter;[Lsun/reflect/generics/tree/TypeSignature;Lsun/reflect/generics/tree/ReturnType;[Lsun/reflect/generics/tree/FieldTypeSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "([Lsun/reflect/generics/tree/FormalTypeParameter;[Lsun/reflect/generics/tree/TypeSignature;Lsun/reflect/generics/tree/ReturnType;[Lsun/reflect/generics/tree/FieldTypeSignature;)Lsun/reflect/generics/tree/MethodTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lsun/reflect/generics/tree/ReturnType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()[Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lsun/reflect/generics/visitor/Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFormalTypeParameters", "()[Lsun/reflect/generics/tree/FormalTypeParameter;"));
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FormalTypeParameter;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> formalTypeParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/TypeSignature;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature> parameterTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/generics/tree/ReturnType;", "private final")]
	public Dova.JDK.sun.reflect.generics.tree.ReturnType returnType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ReturnType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FieldTypeSignature;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> exceptionTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodTypeSignature(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FormalTypeParameter;[Lsun/reflect/generics/tree/TypeSignature;Lsun/reflect/generics/tree/ReturnType;[Lsun/reflect/generics/tree/FieldTypeSignature;)V", "private")]
	public MethodTypeSignature(JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature> arg1, Dova.JDK.sun.reflect.generics.tree.ReturnType arg2, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/tree/MethodTypeSignature;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FormalTypeParameter;[Lsun/reflect/generics/tree/TypeSignature;Lsun/reflect/generics/tree/ReturnType;[Lsun/reflect/generics/tree/FieldTypeSignature;)Lsun/reflect/generics/tree/MethodTypeSignature;", "public static")]
	public static Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature make(JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature> arg1, Dova.JDK.sun.reflect.generics.tree.ReturnType arg2, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ReturnType;", "public")]
	public Dova.JDK.sun.reflect.generics.tree.ReturnType getReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ReturnType>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/TypeSignature;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature> getParameterTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature>>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/visitor/Visitor;)V", "public")]
	public void accept(Dova.JDK.sun.reflect.generics.visitor.Visitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> getExceptionTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FormalTypeParameter;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> getFormalTypeParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
	}
}
