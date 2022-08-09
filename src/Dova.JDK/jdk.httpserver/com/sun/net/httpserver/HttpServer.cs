/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/net/httpserver/HttpServer;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "HttpServer", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "start", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "stop", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAddress", "()Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "create", "()Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljava/net/InetSocketAddress;ILjava/lang/String;Lcom/sun/net/httpserver/HttpHandler;[Lcom/sun/net/httpserver/Filter;)Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "bind", "(Ljava/net/InetSocketAddress;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExecutor", "()Ljava/util/concurrent/Executor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setExecutor", "(Ljava/util/concurrent/Executor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeContext", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeContext", "(Lcom/sun/net/httpserver/HttpContext;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createContext", "(Ljava/lang/String;Lcom/sun/net/httpserver/HttpHandler;)Lcom/sun/net/httpserver/HttpContext;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createContext", "(Ljava/lang/String;)Lcom/sun/net/httpserver/HttpContext;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpServer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public HttpServer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/HttpServer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public abstract")]
	public void start()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	public void stop(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "public abstract")]
	public Dova.JDK.java.net.InetSocketAddress getAddress()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/HttpServer;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpServer create()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpServer;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpServer create(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;ILjava/lang/String;Lcom/sun/net/httpserver/HttpHandler;[Lcom/sun/net/httpserver/Filter;)Lcom/sun/net/httpserver/HttpServer;", "public static transient")]
	public static Dova.JDK.com.sun.net.httpserver.HttpServer create(Dova.JDK.java.net.InetSocketAddress arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.net.httpserver.HttpHandler arg3, JavaArray<Dova.JDK.com.sun.net.httpserver.Filter> arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)V", "public abstract")]
	public void bind(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/Executor;", "public abstract")]
	public Dova.JDK.java.util.concurrent.Executor getExecutor()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)V", "public abstract")]
	public void setExecutor(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	public void removeContext(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpContext;)V", "public abstract")]
	public void removeContext(Dova.JDK.com.sun.net.httpserver.HttpContext arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/net/httpserver/HttpHandler;)Lcom/sun/net/httpserver/HttpContext;", "public abstract")]
	public Dova.JDK.com.sun.net.httpserver.HttpContext createContext(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.net.httpserver.HttpHandler arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/net/httpserver/HttpContext;", "public abstract")]
	public Dova.JDK.com.sun.net.httpserver.HttpContext createContext(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpContext>(ret);
	}
}
