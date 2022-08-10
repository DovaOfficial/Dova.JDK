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

[JniSignatureAttribute("Ljava/util/function/UnaryOperator;", "public abstract interface")]
public partial interface UnaryOperator
	: IJavaObject
	, Dova.JDK.java.util.function.Function
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnaryOperator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/function/UnaryOperator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "identity", "()Ljava/util/function/UnaryOperator;"));
	}

	[JniSignatureAttribute("()Ljava/util/function/UnaryOperator;", "public static")]
	static Dova.JDK.java.util.function.UnaryOperator identity()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.UnaryOperator>(ret);
	}
}
