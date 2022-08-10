/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
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
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/function/BinaryOperator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "minBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "maxBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;"));
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", "public static")]
	static Dova.JDK.java.util.function.BinaryOperator minBy(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", "public static")]
	static Dova.JDK.java.util.function.BinaryOperator maxBy(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
	}
}
