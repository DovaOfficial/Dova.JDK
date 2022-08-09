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

namespace Dova.JDK.sun.reflect.generics.visitor;

[JniSignatureAttribute("Lsun/reflect/generics/visitor/Reifier;", "public")]
public partial class Reifier
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.reflect.generics.visitor.TypeTreeVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Reifier()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/reflect/generics/visitor/Reifier;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "resultType", "Ljava/lang/reflect/Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "factory", "Lsun/reflect/generics/factory/GenericsFactory;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Reifier", "(Lsun/reflect/generics/factory/GenericsFactory;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFactory", "()Lsun/reflect/generics/factory/GenericsFactory;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "make", "(Lsun/reflect/generics/factory/GenericsFactory;)Lsun/reflect/generics/visitor/Reifier;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getResult_0", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getResult_1", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitFormalTypeParameter", "(Lsun/reflect/generics/tree/FormalTypeParameter;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitSimpleClassTypeSignature", "(Lsun/reflect/generics/tree/SimpleClassTypeSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitClassTypeSignature", "(Lsun/reflect/generics/tree/ClassTypeSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitBottomSignature", "(Lsun/reflect/generics/tree/BottomSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "reifyTypeArguments", "([Lsun/reflect/generics/tree/TypeArgument;)[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitArrayTypeSignature", "(Lsun/reflect/generics/tree/ArrayTypeSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitTypeVariableSignature", "(Lsun/reflect/generics/tree/TypeVariableSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitVoidDescriptor", "(Lsun/reflect/generics/tree/VoidDescriptor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitWildcard", "(Lsun/reflect/generics/tree/Wildcard;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitByteSignature", "(Lsun/reflect/generics/tree/ByteSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitBooleanSignature", "(Lsun/reflect/generics/tree/BooleanSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitShortSignature", "(Lsun/reflect/generics/tree/ShortSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitCharSignature", "(Lsun/reflect/generics/tree/CharSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitIntSignature", "(Lsun/reflect/generics/tree/IntSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitLongSignature", "(Lsun/reflect/generics/tree/LongSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitFloatSignature", "(Lsun/reflect/generics/tree/FloatSignature;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitDoubleSignature", "(Lsun/reflect/generics/tree/DoubleSignature;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Type;", "private")]
	public Dova.JDK.java.lang.reflect.Type resultType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/reflect/generics/factory/GenericsFactory;", "private final")]
	public Dova.JDK.sun.reflect.generics.factory.GenericsFactory factory_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.factory.GenericsFactory>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Reifier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/factory/GenericsFactory;)V", "private")]
	public Reifier(Dova.JDK.sun.reflect.generics.factory.GenericsFactory arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/visitor/Reifier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/reflect/generics/factory/GenericsFactory;", "private")]
	public Dova.JDK.sun.reflect.generics.factory.GenericsFactory getFactory()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.factory.GenericsFactory>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/factory/GenericsFactory;)Lsun/reflect/generics/visitor/Reifier;", "public static")]
	public static Dova.JDK.sun.reflect.generics.visitor.Reifier make(Dova.JDK.sun.reflect.generics.factory.GenericsFactory arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.visitor.Reifier>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object getResult_0()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public")]
	public Dova.JDK.java.lang.reflect.Type getResult_1()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/FormalTypeParameter;)V", "public")]
	public void visitFormalTypeParameter(Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/SimpleClassTypeSignature;)V", "public")]
	public void visitSimpleClassTypeSignature(Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ClassTypeSignature;)V", "public")]
	public void visitClassTypeSignature(Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/BottomSignature;)V", "public")]
	public void visitBottomSignature(Dova.JDK.sun.reflect.generics.tree.BottomSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/TypeArgument;)[Ljava/lang/reflect/Type;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> reifyTypeArguments(JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeArgument> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ArrayTypeSignature;)V", "public")]
	public void visitArrayTypeSignature(Dova.JDK.sun.reflect.generics.tree.ArrayTypeSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/TypeVariableSignature;)V", "public")]
	public void visitTypeVariableSignature(Dova.JDK.sun.reflect.generics.tree.TypeVariableSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/VoidDescriptor;)V", "public")]
	public void visitVoidDescriptor(Dova.JDK.sun.reflect.generics.tree.VoidDescriptor arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/Wildcard;)V", "public")]
	public void visitWildcard(Dova.JDK.sun.reflect.generics.tree.Wildcard arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ByteSignature;)V", "public")]
	public void visitByteSignature(Dova.JDK.sun.reflect.generics.tree.ByteSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/BooleanSignature;)V", "public")]
	public void visitBooleanSignature(Dova.JDK.sun.reflect.generics.tree.BooleanSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ShortSignature;)V", "public")]
	public void visitShortSignature(Dova.JDK.sun.reflect.generics.tree.ShortSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/CharSignature;)V", "public")]
	public void visitCharSignature(Dova.JDK.sun.reflect.generics.tree.CharSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/IntSignature;)V", "public")]
	public void visitIntSignature(Dova.JDK.sun.reflect.generics.tree.IntSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/LongSignature;)V", "public")]
	public void visitLongSignature(Dova.JDK.sun.reflect.generics.tree.LongSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/FloatSignature;)V", "public")]
	public void visitFloatSignature(Dova.JDK.sun.reflect.generics.tree.FloatSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/DoubleSignature;)V", "public")]
	public void visitDoubleSignature(Dova.JDK.sun.reflect.generics.tree.DoubleSignature arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}
}
