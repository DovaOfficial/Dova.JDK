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

[JniSignatureAttribute("Ljava/util/function/DoubleUnaryOperator;", "public abstract interface")]
public partial interface DoubleUnaryOperator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DoubleUnaryOperator()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/function/DoubleUnaryOperator;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "identity", "()Ljava/util/function/DoubleUnaryOperator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "applyAsDouble", "(D)D"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compose", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "andThen", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;"));
	}

	[JniSignatureAttribute("()Ljava/util/function/DoubleUnaryOperator;", "public static")]
	static Dova.JDK.java.util.function.DoubleUnaryOperator identity()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoubleUnaryOperator>(ret);
	}

	[JniSignatureAttribute("(D)D", "public abstract")]
	double applyAsDouble(double arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;", "public")]
	Dova.JDK.java.util.function.DoubleUnaryOperator compose(Dova.JDK.java.util.function.DoubleUnaryOperator arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoubleUnaryOperator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;", "public")]
	Dova.JDK.java.util.function.DoubleUnaryOperator andThen(Dova.JDK.java.util.function.DoubleUnaryOperator arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoubleUnaryOperator>(ret);
	}
}
