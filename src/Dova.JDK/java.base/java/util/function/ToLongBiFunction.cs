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

[JniSignatureAttribute("Ljava/util/function/ToLongBiFunction;", "public abstract interface")]
public partial interface ToLongBiFunction
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ToLongBiFunction()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/function/ToLongBiFunction;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAsLong", "(Ljava/lang/Object;Ljava/lang/Object;)J"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)J", "public abstract")]
	long applyAsLong(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}
}
