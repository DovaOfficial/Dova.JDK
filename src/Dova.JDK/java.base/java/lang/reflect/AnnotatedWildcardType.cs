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

namespace Dova.JDK.java.lang.reflect;

[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedWildcardType;", "public abstract interface")]
public partial interface AnnotatedWildcardType
	: IJavaObject
	, Dova.JDK.java.lang.reflect.AnnotatedType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotatedWildcardType()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/reflect/AnnotatedWildcardType;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedLowerBounds", "()[Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedUpperBounds", "()[Ljava/lang/reflect/AnnotatedType;"));
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public abstract")]
	Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedOwnerType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/AnnotatedType;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedLowerBounds()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/AnnotatedType;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedUpperBounds()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
	}
}
