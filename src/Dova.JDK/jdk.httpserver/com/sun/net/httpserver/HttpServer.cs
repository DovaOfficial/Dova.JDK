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

namespace Dova.JDK.com.sun.net.httpserver;

[JniSignatureAttribute("Lcom/sun/net/httpserver/HttpServer;", "public abstract")]
public partial class HttpServer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpServer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/HttpServer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAddress", "()Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "()Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/net/InetSocketAddress;ILjava/lang/String;Lcom/sun/net/httpserver/HttpHandler;[Lcom/sun/net/httpserver/Filter;)Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/net/InetSocketAddress;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExecutor", "()Ljava/util/concurrent/Executor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExecutor", "(Ljava/util/concurrent/Executor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeContext", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeContext", "(Lcom/sun/net/httpserver/HttpContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createContext", "(Ljava/lang/String;Lcom/sun/net/httpserver/HttpHandler;)Lcom/sun/net/httpserver/HttpContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createContext", "(Ljava/lang/String;)Lcom/sun/net/httpserver/HttpContext;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpServer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public HttpServer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/HttpServer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public abstract")]
	public void start()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	public void stop(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "public abstract")]
	public Dova.JDK.java.net.InetSocketAddress getAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/HttpServer;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpServer create()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpServer;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpServer create(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;ILjava/lang/String;Lcom/sun/net/httpserver/HttpHandler;[Lcom/sun/net/httpserver/Filter;)Lcom/sun/net/httpserver/HttpServer;", "public static transient")]
	public static Dova.JDK.com.sun.net.httpserver.HttpServer create(Dova.JDK.java.net.InetSocketAddress arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.net.httpserver.HttpHandler arg3, JavaArray<Dova.JDK.com.sun.net.httpserver.Filter> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)V", "public abstract")]
	public void bind(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/Executor;", "public abstract")]
	public Dova.JDK.java.util.concurrent.Executor getExecutor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)V", "public abstract")]
	public void setExecutor(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	public void removeContext(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpContext;)V", "public abstract")]
	public void removeContext(Dova.JDK.com.sun.net.httpserver.HttpContext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/net/httpserver/HttpHandler;)Lcom/sun/net/httpserver/HttpContext;", "public abstract")]
	public Dova.JDK.com.sun.net.httpserver.HttpContext createContext(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.net.httpserver.HttpHandler arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/net/httpserver/HttpContext;", "public abstract")]
	public Dova.JDK.com.sun.net.httpserver.HttpContext createContext(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpContext>(ret);
	}
}
