/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.reflect.generics.tree;

[JniSignatureAttribute("Lsun/reflect/generics/tree/ClassSignature;", "public")]
public partial class ClassSignature
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.reflect.generics.tree.Signature
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassSignature()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/reflect/generics/tree/ClassSignature;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "formalTypeParams", "[Lsun/reflect/generics/tree/FormalTypeParameter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "superclass", "Lsun/reflect/generics/tree/ClassTypeSignature;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "superInterfaces", "[Lsun/reflect/generics/tree/ClassTypeSignature;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ClassSignature", "([Lsun/reflect/generics/tree/FormalTypeParameter;Lsun/reflect/generics/tree/ClassTypeSignature;[Lsun/reflect/generics/tree/ClassTypeSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSuperclass", "()Lsun/reflect/generics/tree/ClassTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSuperInterfaces", "()[Lsun/reflect/generics/tree/ClassTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "make", "([Lsun/reflect/generics/tree/FormalTypeParameter;Lsun/reflect/generics/tree/ClassTypeSignature;[Lsun/reflect/generics/tree/ClassTypeSignature;)Lsun/reflect/generics/tree/ClassSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lsun/reflect/generics/visitor/Visitor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFormalTypeParameters", "()[Lsun/reflect/generics/tree/FormalTypeParameter;"));
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FormalTypeParameter;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> formalTypeParams_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/reflect/generics/tree/ClassTypeSignature;", "private final")]
	public Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature superclass_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/ClassTypeSignature;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature> superInterfaces_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassSignature(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FormalTypeParameter;Lsun/reflect/generics/tree/ClassTypeSignature;[Lsun/reflect/generics/tree/ClassTypeSignature;)V", "private")]
	public ClassSignature(JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> arg0, Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature arg1, JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature> arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/tree/ClassSignature;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ClassTypeSignature;", "public")]
	public Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature getSuperclass()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/ClassTypeSignature;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature> getSuperInterfaces()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature>>(ret);
	}

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FormalTypeParameter;Lsun/reflect/generics/tree/ClassTypeSignature;[Lsun/reflect/generics/tree/ClassTypeSignature;)Lsun/reflect/generics/tree/ClassSignature;", "public static")]
	public static Dova.JDK.sun.reflect.generics.tree.ClassSignature make(JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> arg0, Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature arg1, JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassSignature>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/visitor/Visitor;)V", "public")]
	public void accept(Dova.JDK.sun.reflect.generics.visitor.Visitor arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FormalTypeParameter;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> getFormalTypeParameters()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
	}
}
