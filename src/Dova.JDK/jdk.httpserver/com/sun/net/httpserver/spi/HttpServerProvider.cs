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

namespace Dova.JDK.com.sun.net.httpserver.spi;

[JniSignatureAttribute("Lcom/sun/net/httpserver/spi/HttpServerProvider;", "public abstract")]
public partial class HttpServerProvider
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpServerProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/spi/HttpServerProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "lock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "provider", "Lcom/sun/net/httpserver/spi/HttpServerProvider;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "provider", "()Lcom/sun/net/httpserver/spi/HttpServerProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createHttpServer", "(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createHttpsServer", "(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpsServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadProviderFromProperty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadProviderAsService", "()Z"));
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object @lock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/net/httpserver/spi/HttpServerProvider;", "private static")]
	public static Dova.JDK.com.sun.net.httpserver.spi.HttpServerProvider provider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.spi.HttpServerProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpServerProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public HttpServerProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/spi/HttpServerProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/spi/HttpServerProvider;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.spi.HttpServerProvider provider()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.spi.HttpServerProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpServer;", "public abstract")]
	public Dova.JDK.com.sun.net.httpserver.HttpServer createHttpServer(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)Lcom/sun/net/httpserver/HttpsServer;", "public abstract")]
	public Dova.JDK.com.sun.net.httpserver.HttpsServer createHttpsServer(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpsServer>(ret);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool loadProviderFromProperty()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool loadProviderAsService()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4]);
		return ret;
	}
}
