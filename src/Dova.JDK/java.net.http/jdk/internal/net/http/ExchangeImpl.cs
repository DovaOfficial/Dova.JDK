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

namespace Dova.JDK.jdk.@internal.net.http;

[JniSignatureAttribute("Ljdk/internal/net/http/ExchangeImpl;", "abstract")]
public partial class ExchangeImpl
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExchangeImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ExchangeImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exchange", "Ljdk/internal/net/http/Exchange;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExchangeImpl", "(Ljdk/internal/net/http/Exchange;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljdk/internal/net/http/Exchange;Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "connection", "()Ljdk/internal/net/http/HttpConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cancel", "(Ljava/io/IOException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cancel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "completed", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getExchange", "()Ljdk/internal/net/http/Exchange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ignoreBody", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCancelCause", "()Ljava/lang/Throwable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nullBody", "(Ljava/net/http/HttpResponse;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readBodyAsync", "(Ljava/net/http/HttpResponse$BodyHandler;ZLjava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "released", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResponseAsync", "(Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sendBodyAsync", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "upgraded", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sendHeadersAsync", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "client", "()Ljava/net/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isCanceled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createHttp1Exchange", "(Ljdk/internal/net/http/Exchange;Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createExchangeImpl", "(Ljdk/internal/net/http/Http2Connection;Ljava/lang/Throwable;Ljdk/internal/net/http/Exchange;Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/Logger;", "private static final")]
	public static Dova.JDK.jdk.@internal.net.http.common.Logger debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Exchange;", "final")]
	public Dova.JDK.jdk.@internal.net.http.Exchange exchange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Exchange>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExchangeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Exchange;)V", "")]
	public ExchangeImpl(Dova.JDK.jdk.@internal.net.http.Exchange arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ExchangeImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/net/http/Exchange;Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;", "static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture get(Dova.JDK.jdk.@internal.net.http.Exchange arg0, Dova.JDK.jdk.@internal.net.http.HttpConnection arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/HttpConnection;", "abstract")]
	public Dova.JDK.jdk.@internal.net.http.HttpConnection connection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/IOException;)V", "abstract")]
	public void cancel(Dova.JDK.java.io.IOException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()V", "abstract")]
	public void cancel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "abstract")]
	public void completed()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/Exchange;", "final")]
	public Dova.JDK.jdk.@internal.net.http.Exchange getExchange()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Exchange>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture ignoreBody()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Throwable;", "abstract")]
	public Dova.JDK.java.lang.Throwable getCancelCause()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse;Ljava/lang/Throwable;)V", "")]
	public void nullBody(Dova.JDK.java.net.http.HttpResponse arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodyHandler;ZLjava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture readBodyAsync(Dova.JDK.java.net.http.HttpResponse.BodyHandler arg0, bool arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()V", "abstract")]
	public void released()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture getResponseAsync(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture sendBodyAsync()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void upgraded()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture sendHeadersAsync()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient;", "")]
	public Dova.JDK.java.net.http.HttpClient client()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("()Z", "abstract")]
	public bool isCanceled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Exchange;Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;", "private static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture createHttp1Exchange(Dova.JDK.jdk.@internal.net.http.Exchange arg0, Dova.JDK.jdk.@internal.net.http.HttpConnection arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Http2Connection;Ljava/lang/Throwable;Ljdk/internal/net/http/Exchange;Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;", "private static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture createExchangeImpl(Dova.JDK.jdk.@internal.net.http.Http2Connection arg0, Dova.JDK.java.lang.Throwable arg1, Dova.JDK.jdk.@internal.net.http.Exchange arg2, Dova.JDK.jdk.@internal.net.http.HttpConnection arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}
}
