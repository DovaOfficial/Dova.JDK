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

namespace Dova.JDK.jdk.dynalink.linker;

[JniSignatureAttribute("Ljdk/dynalink/linker/GuardingTypeConverterFactory;", "public abstract interface")]
public partial interface GuardingTypeConverterFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GuardingTypeConverterFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/linker/GuardingTypeConverterFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "convertToType", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/util/function/Supplier;)Ljdk/dynalink/linker/GuardedInvocation;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/util/function/Supplier;)Ljdk/dynalink/linker/GuardedInvocation;", "public abstract")]
	Dova.JDK.jdk.dynalink.linker.GuardedInvocation convertToType(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.util.function.Supplier arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
	}
}
