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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaNioAccess;", "public abstract interface")]
public partial interface JavaNioAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaNioAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaNioAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(JZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pageSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLoaded", "(JZJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unload", "(JZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "force", "(Ljava/io/FileDescriptor;JZJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmapper", "(Ljava/nio/ByteBuffer;)Ljdk/internal/access/foreign/UnmapperProxy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reserveMemory", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreserveMemory", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectBufferPool", "()Ljdk/internal/misc/VM$BufferPool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDirectByteBuffer", "(JILjava/lang/Object;Ljdk/internal/access/foreign/MemorySegmentProxy;)Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newMappedByteBuffer", "(Ljdk/internal/access/foreign/UnmapperProxy;JILjava/lang/Object;Ljdk/internal/access/foreign/MemorySegmentProxy;)Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newHeapByteBuffer", "([BIILjdk/internal/access/foreign/MemorySegmentProxy;)Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferBase", "(Ljava/nio/ByteBuffer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferAddress", "(Ljava/nio/ByteBuffer;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bufferSegment", "(Ljava/nio/Buffer;)Ljdk/internal/access/foreign/MemorySegmentProxy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireScope", "(Ljava/nio/Buffer;Z)Ljava/lang/Runnable;"));
	}

	[JniSignatureAttribute("(JZJ)V", "public abstract")]
	void load(long arg0, bool arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int pageSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(JZJ)Z", "public abstract")]
	bool isLoaded(long arg0, bool arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JZJ)V", "public abstract")]
	void unload(long arg0, bool arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;JZJJ)V", "public abstract")]
	void force(Dova.JDK.java.io.FileDescriptor arg0, long arg1, bool arg2, long arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljdk/internal/access/foreign/UnmapperProxy;", "public abstract")]
	Dova.JDK.jdk.@internal.access.foreign.UnmapperProxy unmapper(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.foreign.UnmapperProxy>(ret);
	}

	[JniSignatureAttribute("(JJ)V", "public abstract")]
	void reserveMemory(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "public abstract")]
	void unreserveMemory(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/internal/misc/VM$BufferPool;", "public abstract")]
	Dova.JDK.jdk.@internal.misc.VM.BufferPool getDirectBufferPool()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.VM.BufferPool>(ret);
	}

	[JniSignatureAttribute("(JILjava/lang/Object;Ljdk/internal/access/foreign/MemorySegmentProxy;)Ljava/nio/ByteBuffer;", "public abstract")]
	Dova.JDK.java.nio.ByteBuffer newDirectByteBuffer(long arg0, int arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/foreign/UnmapperProxy;JILjava/lang/Object;Ljdk/internal/access/foreign/MemorySegmentProxy;)Ljava/nio/ByteBuffer;", "public abstract")]
	Dova.JDK.java.nio.ByteBuffer newMappedByteBuffer(Dova.JDK.jdk.@internal.access.foreign.UnmapperProxy arg0, long arg1, int arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("([BIILjdk/internal/access/foreign/MemorySegmentProxy;)Ljava/nio/ByteBuffer;", "public abstract")]
	Dova.JDK.java.nio.ByteBuffer newHeapByteBuffer(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getBufferBase(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)J", "public abstract")]
	long getBufferAddress(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/Buffer;)Ljdk/internal/access/foreign/MemorySegmentProxy;", "public abstract")]
	Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy bufferSegment(Dova.JDK.java.nio.Buffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/Buffer;Z)Ljava/lang/Runnable;", "public abstract")]
	Dova.JDK.java.lang.Runnable acquireScope(Dova.JDK.java.nio.Buffer arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
	}
}
