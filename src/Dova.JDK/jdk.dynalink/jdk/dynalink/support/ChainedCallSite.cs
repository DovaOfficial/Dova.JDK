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

namespace Dova.JDK.jdk.dynalink.support;

[JniSignatureAttribute("Ljdk/dynalink/support/ChainedCallSite;", "public")]
public partial class ChainedCallSite
	: Dova.JDK.jdk.dynalink.support.AbstractRelinkableCallSite
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ChainedCallSite()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/support/ChainedCallSite;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRUNE_CATCHES", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRUNE_SWITCHPOINTS", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invocations", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/dynalink/CallSiteDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMaxChainLength", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makePruneAndInvokeMethod", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relinkInternal", "(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;ZZ)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxChainLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prune", "(Ljava/lang/invoke/MethodHandle;Z)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetAndRelink", "(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relink", "(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle PRUNE_CATCHES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle PRUNE_SWITCHPOINTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object invocations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ChainedCallSite(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;)V", "public")]
	public ChainedCallSite(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/support/ChainedCallSite;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)I", "private static")]
	public static int checkMaxChainLength(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "private")]
	public Dova.JDK.java.lang.invoke.MethodHandle makePruneAndInvokeMethod(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;ZZ)Ljava/lang/invoke/MethodHandle;", "private")]
	public Dova.JDK.java.lang.invoke.MethodHandle relinkInternal(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getMaxChainLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Z)Ljava/lang/invoke/MethodHandle;", "private")]
	public Dova.JDK.java.lang.invoke.MethodHandle prune(Dova.JDK.java.lang.invoke.MethodHandle arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V", "public")]
	public void resetAndRelink(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/invoke/MethodHandle;)V", "public")]
	public void relink(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}
}
