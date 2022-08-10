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

namespace Dova.JDK.java.net.http;

[JniSignatureAttribute("Ljava/net/http/WebSocket;", "public abstract interface")]
public partial interface WebSocket
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WebSocket()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/WebSocket;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NORMAL_CLOSURE", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "abort", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sendBinary", "(Ljava/nio/ByteBuffer;Z)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sendPing", "(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sendText", "(Ljava/lang/CharSequence;Z)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sendPong", "(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sendClose", "(ILjava/lang/String;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSubprotocol", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isOutputClosed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isInputClosed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "request", "(J)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int NORMAL_CLOSURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void abort()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Z)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletableFuture sendBinary(Dova.JDK.java.nio.ByteBuffer arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletableFuture sendPing(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Z)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletableFuture sendText(Dova.JDK.java.lang.CharSequence arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletableFuture sendPong(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletableFuture sendClose(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getSubprotocol()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isOutputClosed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isInputClosed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public abstract")]
	void request(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("Ljava/net/http/WebSocket$Listener;", "public abstract static interface")]
	public partial interface Listener
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Listener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/WebSocket$Listener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onClose", "(Ljava/net/http/WebSocket;ILjava/lang/String;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onError", "(Ljava/net/http/WebSocket;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onPing", "(Ljava/net/http/WebSocket;Ljava/nio/ByteBuffer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onPong", "(Ljava/net/http/WebSocket;Ljava/nio/ByteBuffer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onText", "(Ljava/net/http/WebSocket;Ljava/lang/CharSequence;Z)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onBinary", "(Ljava/net/http/WebSocket;Ljava/nio/ByteBuffer;Z)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onOpen", "(Ljava/net/http/WebSocket;)V"));
		}

		[JniSignatureAttribute("(Ljava/net/http/WebSocket;ILjava/lang/String;)Ljava/util/concurrent/CompletionStage;", "public")]
		Dova.JDK.java.util.concurrent.CompletionStage onClose(Dova.JDK.java.net.http.WebSocket arg0, int arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/WebSocket;Ljava/lang/Throwable;)V", "public")]
		void onError(Dova.JDK.java.net.http.WebSocket arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/net/http/WebSocket;Ljava/nio/ByteBuffer;)Ljava/util/concurrent/CompletionStage;", "public")]
		Dova.JDK.java.util.concurrent.CompletionStage onPing(Dova.JDK.java.net.http.WebSocket arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/WebSocket;Ljava/nio/ByteBuffer;)Ljava/util/concurrent/CompletionStage;", "public")]
		Dova.JDK.java.util.concurrent.CompletionStage onPong(Dova.JDK.java.net.http.WebSocket arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/WebSocket;Ljava/lang/CharSequence;Z)Ljava/util/concurrent/CompletionStage;", "public")]
		Dova.JDK.java.util.concurrent.CompletionStage onText(Dova.JDK.java.net.http.WebSocket arg0, Dova.JDK.java.lang.CharSequence arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/WebSocket;Ljava/nio/ByteBuffer;Z)Ljava/util/concurrent/CompletionStage;", "public")]
		Dova.JDK.java.util.concurrent.CompletionStage onBinary(Dova.JDK.java.net.http.WebSocket arg0, Dova.JDK.java.nio.ByteBuffer arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/WebSocket;)V", "public")]
		void onOpen(Dova.JDK.java.net.http.WebSocket arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/WebSocket$Builder;", "public abstract static interface")]
	public partial interface Builder
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/WebSocket$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "header", "(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/WebSocket$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "connectTimeout", "(Ljava/time/Duration;)Ljava/net/http/WebSocket$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subprotocols", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/net/http/WebSocket$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buildAsync", "(Ljava/net/URI;Ljava/net/http/WebSocket$Listener;)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/WebSocket$Builder;", "public abstract")]
		Dova.JDK.java.net.http.WebSocket.Builder header(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.WebSocket.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/net/http/WebSocket$Builder;", "public abstract")]
		Dova.JDK.java.net.http.WebSocket.Builder connectTimeout(Dova.JDK.java.time.Duration arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.WebSocket.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljava/net/http/WebSocket$Builder;", "public abstract transient")]
		Dova.JDK.java.net.http.WebSocket.Builder subprotocols(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.WebSocket.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/URI;Ljava/net/http/WebSocket$Listener;)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
		Dova.JDK.java.util.concurrent.CompletableFuture buildAsync(Dova.JDK.java.net.URI arg0, Dova.JDK.java.net.http.WebSocket.Listener arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}
}
