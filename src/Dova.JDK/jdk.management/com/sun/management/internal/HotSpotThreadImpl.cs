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

namespace Dova.JDK.com.sun.management.@internal;

[JniSignatureAttribute("Lcom/sun/management/internal/HotSpotThreadImpl;", "public")]
public partial class HotSpotThreadImpl
	: Dova.JDK.sun.management.ThreadImpl
	, Dova.JDK.com.sun.management.ThreadMXBean
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HotSpotThreadImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/management/internal/HotSpotThreadImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/management/VMManagement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isThreadAllocatedMemorySupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isThreadAllocatedMemoryEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThreadCpuTime", "([J)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThreadUserTime", "([J)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThreadAllocatedBytes", "([J)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThreadAllocatedBytes", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentThreadAllocatedBytes", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setThreadAllocatedMemoryEnabled", "(Z)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HotSpotThreadImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/management/VMManagement;)V", "public")]
	public HotSpotThreadImpl(Dova.JDK.sun.management.VMManagement arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/management/internal/HotSpotThreadImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool isThreadAllocatedMemorySupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isThreadAllocatedMemoryEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("([J)[J", "public")]
	public JavaArray<long> getThreadCpuTime(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([J)[J", "public")]
	public JavaArray<long> getThreadUserTime(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([J)[J", "public")]
	public JavaArray<long> getThreadAllocatedBytes(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long getThreadAllocatedBytes(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCurrentThreadAllocatedBytes()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setThreadAllocatedMemoryEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}
}
