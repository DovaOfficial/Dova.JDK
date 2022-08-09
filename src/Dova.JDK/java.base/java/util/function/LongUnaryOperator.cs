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

[JniSignatureAttribute("Ljava/util/function/LongUnaryOperator;", "public abstract interface")]
public partial interface LongUnaryOperator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LongUnaryOperator()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/function/LongUnaryOperator;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "identity", "()Ljava/util/function/LongUnaryOperator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "applyAsLong", "(J)J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compose", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "andThen", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;"));
	}

	[JniSignatureAttribute("()Ljava/util/function/LongUnaryOperator;", "public static")]
	static Dova.JDK.java.util.function.LongUnaryOperator identity()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongUnaryOperator>(ret);
	}

	[JniSignatureAttribute("(J)J", "public abstract")]
	long applyAsLong(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", "public")]
	Dova.JDK.java.util.function.LongUnaryOperator compose(Dova.JDK.java.util.function.LongUnaryOperator arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongUnaryOperator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", "public")]
	Dova.JDK.java.util.function.LongUnaryOperator andThen(Dova.JDK.java.util.function.LongUnaryOperator arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongUnaryOperator>(ret);
	}
}
