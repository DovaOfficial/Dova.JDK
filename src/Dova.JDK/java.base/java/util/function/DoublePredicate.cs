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

[JniSignatureAttribute("Ljava/util/function/DoublePredicate;", "public abstract interface")]
public partial interface DoublePredicate
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DoublePredicate()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/function/DoublePredicate;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "test", "(D)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "or", "(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "negate", "()Ljava/util/function/DoublePredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "and", "(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;"));
	}

	[JniSignatureAttribute("(D)Z", "public abstract")]
	bool test(double arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;", "public")]
	Dova.JDK.java.util.function.DoublePredicate or(Dova.JDK.java.util.function.DoublePredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoublePredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/DoublePredicate;", "public")]
	Dova.JDK.java.util.function.DoublePredicate negate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoublePredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;", "public")]
	Dova.JDK.java.util.function.DoublePredicate and(Dova.JDK.java.util.function.DoublePredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoublePredicate>(ret);
	}
}
