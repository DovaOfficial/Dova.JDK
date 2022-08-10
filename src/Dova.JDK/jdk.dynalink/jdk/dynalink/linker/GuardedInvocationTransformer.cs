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

[JniSignatureAttribute("Ljdk/dynalink/linker/GuardedInvocationTransformer;", "public abstract interface")]
public partial interface GuardedInvocationTransformer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GuardedInvocationTransformer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/linker/GuardedInvocationTransformer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "filter", "(Ljdk/dynalink/linker/GuardedInvocation;Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;"));
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;", "public abstract")]
	Dova.JDK.jdk.dynalink.linker.GuardedInvocation filter(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.jdk.dynalink.linker.LinkRequest arg1, Dova.JDK.jdk.dynalink.linker.LinkerServices arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
	}
}
