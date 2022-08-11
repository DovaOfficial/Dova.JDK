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

namespace Dova.JDK.jdk.@internal.reflect;

[JniSignatureAttribute("Ljdk/internal/reflect/MethodAccessor;", "public abstract interface")]
public partial interface MethodAccessor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodAccessor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/MethodAccessor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Object arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Object arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
