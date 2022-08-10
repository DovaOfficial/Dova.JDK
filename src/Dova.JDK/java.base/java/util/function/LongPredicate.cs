/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljava/util/function/LongPredicate;", "public abstract interface")]
public partial interface LongPredicate
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LongPredicate()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/function/LongPredicate;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "test", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "or", "(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "negate", "()Ljava/util/function/LongPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "and", "(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;"));
	}

	[JniSignatureAttribute("(J)Z", "public abstract")]
	bool test(long arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;", "public")]
	Dova.JDK.java.util.function.LongPredicate or(Dova.JDK.java.util.function.LongPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/LongPredicate;", "public")]
	Dova.JDK.java.util.function.LongPredicate negate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;", "public")]
	Dova.JDK.java.util.function.LongPredicate and(Dova.JDK.java.util.function.LongPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongPredicate>(ret);
	}
}
