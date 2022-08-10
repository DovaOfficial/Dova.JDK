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

namespace Dova.JDK.sun.net.httpserver;

[JniSignatureAttribute("Lsun/net/httpserver/HttpsServerImpl;", "public")]
public partial class HttpsServerImpl
	: Dova.JDK.com.sun.net.httpserver.HttpsServer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpsServerImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/httpserver/HttpsServerImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "server", "Lsun/net/httpserver/ServerImpl;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HttpsServerImpl", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HttpsServerImpl", "(Ljava/net/InetSocketAddress;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "stop", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAddress", "()Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bind", "(Ljava/net/InetSocketAddress;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getExecutor", "()Ljava/util/concurrent/Executor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setExecutor", "(Ljava/util/concurrent/Executor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeContext", "(Lcom/sun/net/httpserver/HttpContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeContext", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setHttpsConfigurator", "(Lcom/sun/net/httpserver/HttpsConfigurator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHttpsConfigurator", "()Lcom/sun/net/httpserver/HttpsConfigurator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createContext_0", "(Ljava/lang/String;Lcom/sun/net/httpserver/HttpHandler;)Lcom/sun/net/httpserver/HttpContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createContext_1", "(Ljava/lang/String;Lcom/sun/net/httpserver/HttpHandler;)Lsun/net/httpserver/HttpContextImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createContext_0", "(Ljava/lang/String;)Lcom/sun/net/httpserver/HttpContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createContext_1", "(Ljava/lang/String;)Lsun/net/httpserver/HttpContextImpl;"));
	}

	[JniSignatureAttribute("Lsun/net/httpserver/ServerImpl;", "")]
	public Dova.JDK.sun.net.httpserver.ServerImpl server_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.httpserver.ServerImpl>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpsServerImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public HttpsServerImpl() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)V", "")]
	public HttpsServerImpl(Dova.JDK.java.net.InetSocketAddress arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/httpserver/HttpsServerImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void start()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void stop(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "public")]
	public Dova.JDK.java.net.InetSocketAddress getAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)V", "public")]
	public void bind(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/Executor;", "public")]
	public Dova.JDK.java.util.concurrent.Executor getExecutor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)V", "public")]
	public void setExecutor(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpContext;)V", "public")]
	public void removeContext(Dova.JDK.com.sun.net.httpserver.HttpContext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void removeContext(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpsConfigurator;)V", "public")]
	public void setHttpsConfigurator(Dova.JDK.com.sun.net.httpserver.HttpsConfigurator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/HttpsConfigurator;", "public")]
	public Dova.JDK.com.sun.net.httpserver.HttpsConfigurator getHttpsConfigurator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpsConfigurator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/net/httpserver/HttpHandler;)Lcom/sun/net/httpserver/HttpContext;", "public volatile")]
	public Dova.JDK.com.sun.net.httpserver.HttpContext createContext_0(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.net.httpserver.HttpHandler arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/net/httpserver/HttpHandler;)Lsun/net/httpserver/HttpContextImpl;", "public")]
	public Dova.JDK.sun.net.httpserver.HttpContextImpl createContext_1(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.net.httpserver.HttpHandler arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.httpserver.HttpContextImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/net/httpserver/HttpContext;", "public volatile")]
	public Dova.JDK.com.sun.net.httpserver.HttpContext createContext_0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/httpserver/HttpContextImpl;", "public")]
	public Dova.JDK.sun.net.httpserver.HttpContextImpl createContext_1(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.httpserver.HttpContextImpl>(ret);
	}
}
