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

namespace Dova.JDK.sun.net.httpserver;

[JniSignatureAttribute("Lsun/net/httpserver/DefaultHttpServerProvider;", "public")]
public partial class DefaultHttpServerProvider
	: Dova.JDK.com.sun.net.httpserver.spi.HttpServerProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultHttpServerProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/httpserver/DefaultHttpServerProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createHttpServer", "(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createHttpsServer", "(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpsServer;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultHttpServerProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultHttpServerProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/httpserver/DefaultHttpServerProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpServer;", "public")]
	public Dova.JDK.com.sun.net.httpserver.HttpServer createHttpServer(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpsServer;", "public")]
	public Dova.JDK.com.sun.net.httpserver.HttpsServer createHttpsServer(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpsServer>(ret);
	}
}
