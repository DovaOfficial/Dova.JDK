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

namespace Dova.JDK.jdk.@internal.net.http;

[JniSignatureAttribute("Ljdk/internal/net/http/AsyncSSLConnection;", "")]
public partial class AsyncSSLConnection
	: Dova.JDK.jdk.@internal.net.http.AbstractAsyncSSLConnection
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AsyncSSLConnection()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/AsyncSSLConnection;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "plainConnection", "Ljdk/internal/net/http/PlainHttpConnection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writePublisher", "Ljdk/internal/net/http/HttpConnection$PlainHttpPublisher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flow", "Ljdk/internal/net/http/common/SSLTube;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/InetSocketAddress;Ljdk/internal/net/http/HttpClientImpl;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "proxy", "()Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "channel", "()Ljava/nio/channels/SocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheKey", "()Ljdk/internal/net/http/ConnectionPool$CacheKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectionFlow_0", "()Ljdk/internal/net/http/common/FlowTube;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectionFlow_1", "()Ljdk/internal/net/http/common/SSLTube;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connectAsync", "(Ljdk/internal/net/http/Exchange;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishConnect", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProxied", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "publisher", "()Ljdk/internal/net/http/HttpConnection$HttpPublisher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connected", "()Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/PlainHttpConnection;", "final")]
	public Dova.JDK.jdk.@internal.net.http.PlainHttpConnection plainConnection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.PlainHttpConnection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpConnection$PlainHttpPublisher;", "final")]
	public Dova.JDK.jdk.@internal.net.http.HttpConnection.PlainHttpPublisher writePublisher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpConnection.PlainHttpPublisher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SSLTube;", "private volatile")]
	public Dova.JDK.jdk.@internal.net.http.common.SSLTube flow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SSLTube>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AsyncSSLConnection(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;Ljdk/internal/net/http/HttpClientImpl;[Ljava/lang/String;)V", "")]
	public AsyncSSLConnection(Dova.JDK.java.net.InetSocketAddress arg0, Dova.JDK.jdk.@internal.net.http.HttpClientImpl arg1, JavaArray<Dova.JDK.java.lang.String> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/AsyncSSLConnection;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "")]
	public Dova.JDK.java.net.InetSocketAddress proxy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/SocketChannel;", "")]
	public Dova.JDK.java.nio.channels.SocketChannel channel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SocketChannel>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/ConnectionPool$CacheKey;", "")]
	public Dova.JDK.jdk.@internal.net.http.ConnectionPool.CacheKey cacheKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ConnectionPool.CacheKey>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/common/FlowTube;", "volatile")]
	public Dova.JDK.jdk.@internal.net.http.common.FlowTube getConnectionFlow_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.FlowTube>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/common/SSLTube;", "")]
	public Dova.JDK.jdk.@internal.net.http.common.SSLTube getConnectionFlow_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SSLTube>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Exchange;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture connectAsync(Dova.JDK.jdk.@internal.net.http.Exchange arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture finishConnect()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isProxied()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/HttpConnection$HttpPublisher;", "")]
	public Dova.JDK.jdk.@internal.net.http.HttpConnection.HttpPublisher publisher()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpConnection.HttpPublisher>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool connected()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}
}
