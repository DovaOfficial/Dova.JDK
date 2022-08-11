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

namespace Dova.JDK.jdk.@internal.access.foreign;

[JniSignatureAttribute("Ljdk/internal/access/foreign/MemoryAddressProxy;", "public abstract interface")]
public partial interface MemoryAddressProxy
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MemoryAddressProxy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/foreign/MemoryAddressProxy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAccess", "(JJZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSmall", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "overflowException", "(JJ)Ljava/lang/IndexOutOfBoundsException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsafeGetOffset", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsafeGetBase", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addOffsets", "(JJLjdk/internal/access/foreign/MemoryAddressProxy;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "multiplyOffsets", "(JJLjdk/internal/access/foreign/MemoryAddressProxy;)J"));
	}

	[JniSignatureAttribute("(JJZ)V", "public abstract")]
	void checkAccess(long arg0, long arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isSmall()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(JJ)Ljava/lang/IndexOutOfBoundsException;", "private static")]
	static Dova.JDK.java.lang.IndexOutOfBoundsException overflowException(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IndexOutOfBoundsException>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long unsafeGetOffset()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object unsafeGetBase()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(JJLjdk/internal/access/foreign/MemoryAddressProxy;)J", "public static")]
	static long addOffsets(long arg0, long arg1, Dova.JDK.jdk.@internal.access.foreign.MemoryAddressProxy arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJLjdk/internal/access/foreign/MemoryAddressProxy;)J", "public static")]
	static long multiplyOffsets(long arg0, long arg1, Dova.JDK.jdk.@internal.access.foreign.MemoryAddressProxy arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}
}
