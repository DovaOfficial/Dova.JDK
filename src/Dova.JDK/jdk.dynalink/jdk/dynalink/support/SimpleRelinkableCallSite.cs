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

namespace Dova.JDK.jdk.dynalink.support;

[JniSignatureAttribute("Ljdk/dynalink/support/SimpleRelinkableCallSite;", "public")]
public partial class SimpleRelinkableCallSite
	: Dova.JDK.jdk.dynalink.support.AbstractRelinkableCallSite
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleRelinkableCallSite()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/support/SimpleRelinkableCallSite;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SimpleRelinkableCallSite", "(Ljdk/dynalink/CallSiteDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resetAndRelink", "(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "relink", "(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleRelinkableCallSite(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;)V", "public")]
	public SimpleRelinkableCallSite(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/support/SimpleRelinkableCallSite;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V", "public")]
	public void resetAndRelink(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V", "public")]
	public void relink(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}
}
