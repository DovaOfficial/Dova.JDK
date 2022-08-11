/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.net.http.websocket;

[JniSignatureAttribute("Ljdk/internal/net/http/websocket/RawChannel;", "public abstract interface")]
public partial interface RawChannel
	: IJavaObject
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RawChannel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/websocket/RawChannel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "([Ljava/nio/ByteBuffer;II)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerEvent", "(Ljdk/internal/net/http/websocket/RawChannel$RawEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialByteBuffer", "()Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shutdownInput", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shutdownOutput", "()V"));
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)J", "public abstract")]
	long write(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/ByteBuffer;", "public abstract")]
	Dova.JDK.java.nio.ByteBuffer read()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/websocket/RawChannel$RawEvent;)V", "public abstract")]
	void registerEvent(Dova.JDK.jdk.@internal.net.http.websocket.RawChannel.RawEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Ljava/nio/ByteBuffer;", "public abstract")]
	Dova.JDK.java.nio.ByteBuffer initialByteBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void shutdownInput()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void shutdownOutput()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/RawChannel$RawEvent;", "public abstract static interface")]
	public partial interface RawEvent
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RawEvent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/websocket/RawChannel$RawEvent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handle", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interestOps", "()I"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void handle()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int interestOps()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/RawChannel$Provider;", "public abstract static interface")]
	public partial interface Provider
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Provider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/websocket/RawChannel$Provider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rawChannel", "()Ljdk/internal/net/http/websocket/RawChannel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeRawChannel", "()V"));
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/websocket/RawChannel;", "public abstract")]
		Dova.JDK.jdk.@internal.net.http.websocket.RawChannel rawChannel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.RawChannel>(ret);
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void closeRawChannel()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}
}
