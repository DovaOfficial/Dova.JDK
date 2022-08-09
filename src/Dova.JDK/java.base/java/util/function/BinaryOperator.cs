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

[JniSignatureAttribute("Ljava/util/function/BinaryOperator;", "public abstract interface")]
public partial interface BinaryOperator
	: IJavaObject
	, Dova.JDK.java.util.function.BiFunction
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BinaryOperator()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/function/BinaryOperator;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "minBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "maxBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;"));
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", "public static")]
	static Dova.JDK.java.util.function.BinaryOperator minBy(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", "public static")]
	static Dova.JDK.java.util.function.BinaryOperator maxBy(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
	}
}