/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Lcom/sun/net/httpserver/HttpsServer;", "public abstract")]
public partial class HttpsServer
	: Dova.JDK.com.sun.net.httpserver.HttpServer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpsServer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/HttpsServer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HttpsServer", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljava/net/InetSocketAddress;ILjava/lang/String;Lcom/sun/net/httpserver/HttpHandler;[Lcom/sun/net/httpserver/Filter;)Lcom/sun/net/httpserver/HttpsServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpsServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "()Lcom/sun/net/httpserver/HttpsServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setHttpsConfigurator", "(Lcom/sun/net/httpserver/HttpsConfigurator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHttpsConfigurator", "()Lcom/sun/net/httpserver/HttpsConfigurator;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpsServer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public HttpsServer() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/HttpsServer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;ILjava/lang/String;Lcom/sun/net/httpserver/HttpHandler;[Lcom/sun/net/httpserver/Filter;)Lcom/sun/net/httpserver/HttpsServer;", "public static transient")]
	public static Dova.JDK.com.sun.net.httpserver.HttpsServer create(Dova.JDK.java.net.InetSocketAddress arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.net.httpserver.HttpHandler arg3, JavaArray<Dova.JDK.com.sun.net.httpserver.Filter> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpsServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpsServer;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpsServer create(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpsServer>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/HttpsServer;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpsServer create()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpsServer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpsConfigurator;)V", "public abstract")]
	public void setHttpsConfigurator(Dova.JDK.com.sun.net.httpserver.HttpsConfigurator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/HttpsConfigurator;", "public abstract")]
	public Dova.JDK.com.sun.net.httpserver.HttpsConfigurator getHttpsConfigurator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpsConfigurator>(ret);
	}
}
