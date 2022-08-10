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

namespace Dova.JDK.com.sun.java_cup.@internal.runtime;

[JniSignatureAttribute("Lcom/sun/java_cup/internal/runtime/Scanner;", "public abstract interface")]
public partial interface Scanner
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Scanner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java_cup/internal/runtime/Scanner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next_token", "()Lcom/sun/java_cup/internal/runtime/Symbol;"));
	}

	[JniSignatureAttribute("()Lcom/sun/java_cup/internal/runtime/Symbol;", "public abstract")]
	Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol next_token()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
	}
}
