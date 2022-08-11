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

namespace Dova.JDK.sun.reflect.generics.repository;

[JniSignatureAttribute("Lsun/reflect/generics/repository/MethodRepository;", "public")]
public partial class MethodRepository
	: Dova.JDK.sun.reflect.generics.repository.ConstructorRepository
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodRepository()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/repository/MethodRepository;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnType", "Ljava/lang/reflect/Type;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lsun/reflect/generics/factory/GenericsFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "(Ljava/lang/String;Lsun/reflect/generics/factory/GenericsFactory;)Lsun/reflect/generics/repository/MethodRepository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeReturnType", "()Ljava/lang/reflect/Type;"));
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Type;", "private volatile")]
	public Dova.JDK.java.lang.reflect.Type returnType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodRepository(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/reflect/generics/factory/GenericsFactory;)V", "private")]
	public MethodRepository(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.reflect.generics.factory.GenericsFactory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/repository/MethodRepository;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/reflect/generics/factory/GenericsFactory;)Lsun/reflect/generics/repository/MethodRepository;", "public static")]
	public static Dova.JDK.sun.reflect.generics.repository.MethodRepository make(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.reflect.generics.factory.GenericsFactory arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.repository.MethodRepository>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public")]
	public Dova.JDK.java.lang.reflect.Type getReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "private")]
	public Dova.JDK.java.lang.reflect.Type computeReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}
}
