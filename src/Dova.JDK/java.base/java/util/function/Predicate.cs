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

namespace Dova.JDK.java.util.function;

[JniSignatureAttribute("Ljava/util/function/Predicate;", "public abstract interface")]
public partial interface Predicate
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Predicate()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/function/Predicate;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "or", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "negate", "()Ljava/util/function/Predicate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "and", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "not", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isEqual", "(Ljava/lang/Object;)Ljava/util/function/Predicate;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	bool test(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", "public")]
	Dova.JDK.java.util.function.Predicate or(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/Predicate;", "public")]
	Dova.JDK.java.util.function.Predicate negate()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", "public")]
	Dova.JDK.java.util.function.Predicate and(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", "public static")]
	static Dova.JDK.java.util.function.Predicate not(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/function/Predicate;", "public static")]
	static Dova.JDK.java.util.function.Predicate isEqual(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}
}