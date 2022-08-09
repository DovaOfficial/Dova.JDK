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

[JniSignatureAttribute("Ljava/util/function/IntPredicate;", "public abstract interface")]
public partial interface IntPredicate
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IntPredicate()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/function/IntPredicate;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "or", "(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "negate", "()Ljava/util/function/IntPredicate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "and", "(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;"));
	}

	[JniSignatureAttribute("(I)Z", "public abstract")]
	bool test(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;", "public")]
	Dova.JDK.java.util.function.IntPredicate or(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/IntPredicate;", "public")]
	Dova.JDK.java.util.function.IntPredicate negate()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;", "public")]
	Dova.JDK.java.util.function.IntPredicate and(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntPredicate>(ret);
	}
}
