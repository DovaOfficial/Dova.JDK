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

[JniSignatureAttribute("Ljava/util/function/DoubleConsumer;", "public abstract interface")]
public partial interface DoubleConsumer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DoubleConsumer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/function/DoubleConsumer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Ljava/util/function/DoubleConsumer;)Ljava/util/function/DoubleConsumer;"));
	}

	[JniSignatureAttribute("(D)V", "public abstract")]
	void accept(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)Ljava/util/function/DoubleConsumer;", "public")]
	Dova.JDK.java.util.function.DoubleConsumer andThen(Dova.JDK.java.util.function.DoubleConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoubleConsumer>(ret);
	}
}
