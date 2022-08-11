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

namespace Dova.JDK.jdk.dynalink;

[JniSignatureAttribute("Ljdk/dynalink/RelinkableCallSite;", "public abstract interface")]
public partial interface RelinkableCallSite
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RelinkableCallSite()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/RelinkableCallSite;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljdk/dynalink/CallSiteDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetAndRelink", "(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relink", "(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V"));
	}

	[JniSignatureAttribute("()Ljdk/dynalink/CallSiteDescriptor;", "public abstract")]
	Dova.JDK.jdk.dynalink.CallSiteDescriptor getDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.CallSiteDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)V", "public abstract")]
	void initialize(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V", "public abstract")]
	void resetAndRelink(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V", "public abstract")]
	void relink(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}
}
