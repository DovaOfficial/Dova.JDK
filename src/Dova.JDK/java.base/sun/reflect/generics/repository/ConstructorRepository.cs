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

namespace Dova.JDK.sun.reflect.generics.repository;

[JniSignatureAttribute("Lsun/reflect/generics/repository/ConstructorRepository;", "public")]
public partial class ConstructorRepository
	: Dova.JDK.sun.reflect.generics.repository.GenericDeclRepository
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConstructorRepository()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/reflect/generics/repository/ConstructorRepository;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "parameterTypes", "[Ljava/lang/reflect/Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "exceptionTypes", "[Ljava/lang/reflect/Type;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstructorRepository", "(Ljava/lang/String;Lsun/reflect/generics/factory/GenericsFactory;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "make", "(Ljava/lang/String;Lsun/reflect/generics/factory/GenericsFactory;)Lsun/reflect/generics/repository/ConstructorRepository;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getParameterTypes", "()[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExceptionTypes", "()[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parse_0", "(Ljava/lang/String;)Lsun/reflect/generics/tree/Tree;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parse_1", "(Ljava/lang/String;)Lsun/reflect/generics/tree/MethodTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "computeParameterTypes", "()[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "computeExceptionTypes", "()[Ljava/lang/reflect/Type;"));
	}

	[JniSignatureAttribute("[Ljava/lang/reflect/Type;", "private volatile")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> parameterTypes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/reflect/Type;", "private volatile")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> exceptionTypes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConstructorRepository(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/reflect/generics/factory/GenericsFactory;)V", "protected")]
	public ConstructorRepository(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.reflect.generics.factory.GenericsFactory arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/repository/ConstructorRepository;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/reflect/generics/factory/GenericsFactory;)Lsun/reflect/generics/repository/ConstructorRepository;", "public static")]
	public static Dova.JDK.sun.reflect.generics.repository.ConstructorRepository make(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.reflect.generics.factory.GenericsFactory arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.repository.ConstructorRepository>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Type;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> getParameterTypes()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Type;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> getExceptionTypes()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/generics/tree/Tree;", "protected volatile")]
	public Dova.JDK.sun.reflect.generics.tree.Tree parse_0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.Tree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/generics/tree/MethodTypeSignature;", "protected")]
	public Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature parse_1(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Type;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> computeParameterTypes()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Type;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> computeExceptionTypes()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}
}