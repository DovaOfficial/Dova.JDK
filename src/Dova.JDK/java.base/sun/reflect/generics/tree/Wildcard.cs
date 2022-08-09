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

[JniSignatureAttribute("Lsun/reflect/generics/tree/Wildcard;", "public")]
public partial class Wildcard
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.reflect.generics.tree.TypeArgument
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Wildcard()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/reflect/generics/tree/Wildcard;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "upperBounds", "[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lowerBounds", "[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "emptyBounds", "[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Wildcard", "([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "make", "([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)Lsun/reflect/generics/tree/Wildcard;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lsun/reflect/generics/visitor/TypeTreeVisitor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getUpperBounds", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLowerBounds", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FieldTypeSignature;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> upperBounds_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FieldTypeSignature;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> lowerBounds_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FieldTypeSignature;", "private static final")]
	public static JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> emptyBounds_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Wildcard(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)V", "private")]
	public Wildcard(JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/tree/Wildcard;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)Lsun/reflect/generics/tree/Wildcard;", "public static")]
	public static Dova.JDK.sun.reflect.generics.tree.Wildcard make(JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.Wildcard>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/visitor/TypeTreeVisitor;)V", "public")]
	public void accept(Dova.JDK.sun.reflect.generics.visitor.TypeTreeVisitor arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> getUpperBounds()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> getLowerBounds()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}
}
