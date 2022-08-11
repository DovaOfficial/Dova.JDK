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

[JniSignatureAttribute("Ljava/util/function/LongToDoubleFunction;", "public abstract interface")]
public partial interface LongToDoubleFunction
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LongToDoubleFunction()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/function/LongToDoubleFunction;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAsDouble", "(J)D"));
	}

	[JniSignatureAttribute("(J)D", "public abstract")]
	double applyAsDouble(long arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}
}
