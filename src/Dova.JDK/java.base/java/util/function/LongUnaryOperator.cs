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
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/function/LongUnaryOperator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity", "()Ljava/util/function/LongUnaryOperator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAsLong", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compose", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;"));
	}

	[JniSignatureAttribute("()Ljava/util/function/LongUnaryOperator;", "public static")]
	static Dova.JDK.java.util.function.LongUnaryOperator identity()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongUnaryOperator>(ret);
	}

	[JniSignatureAttribute("(J)J", "public abstract")]
	long applyAsLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", "public")]
	Dova.JDK.java.util.function.LongUnaryOperator compose(Dova.JDK.java.util.function.LongUnaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongUnaryOperator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", "public")]
	Dova.JDK.java.util.function.LongUnaryOperator andThen(Dova.JDK.java.util.function.LongUnaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongUnaryOperator>(ret);
	}
}
