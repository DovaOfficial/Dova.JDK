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

[JniSignatureAttribute("Lsun/net/httpserver/HttpExchangeImpl;", "")]
public partial class HttpExchangeImpl
	: Dova.JDK.com.sun.net.httpserver.HttpExchange
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpExchangeImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/httpserver/HttpExchangeImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "impl", "Lsun/net/httpserver/ExchangeImpl;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/net/httpserver/ExchangeImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProtocol", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResponseCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrincipal", "()Lcom/sun/net/httpserver/HttpPrincipal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRequestBody", "()Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRequestHeaders", "()Lcom/sun/net/httpserver/Headers;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResponseHeaders", "()Lcom/sun/net/httpserver/Headers;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRequestURI", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRequestMethod", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResponseBody", "()Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRemoteAddress", "()Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStreams", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHttpContext_0", "()Lsun/net/httpserver/HttpContextImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHttpContext_1", "()Lcom/sun/net/httpserver/HttpContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExchangeImpl", "()Lsun/net/httpserver/ExchangeImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendResponseHeaders", "(IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalAddress", "()Ljava/net/InetSocketAddress;"));
	}

	[JniSignatureAttribute("Lsun/net/httpserver/ExchangeImpl;", "")]
	public Dova.JDK.sun.net.httpserver.ExchangeImpl impl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.httpserver.ExchangeImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpExchangeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/net/httpserver/ExchangeImpl;)V", "")]
	public HttpExchangeImpl(Dova.JDK.sun.net.httpserver.ExchangeImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/httpserver/HttpExchangeImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getProtocol()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getAttribute(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getResponseCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/HttpPrincipal;", "public")]
	public Dova.JDK.com.sun.net.httpserver.HttpPrincipal getPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpPrincipal>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getRequestBody()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/Headers;", "public")]
	public Dova.JDK.com.sun.net.httpserver.Headers getRequestHeaders()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.Headers>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/Headers;", "public")]
	public Dova.JDK.com.sun.net.httpserver.Headers getResponseHeaders()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.Headers>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "public")]
	public Dova.JDK.java.net.URI getRequestURI()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getRequestMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/OutputStream;", "public")]
	public Dova.JDK.java.io.OutputStream getResponseBody()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "public")]
	public Dova.JDK.java.net.InetSocketAddress getRemoteAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "public")]
	public void setStreams(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("()Lsun/net/httpserver/HttpContextImpl;", "public")]
	public Dova.JDK.sun.net.httpserver.HttpContextImpl getHttpContext_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.httpserver.HttpContextImpl>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/net/httpserver/HttpContext;", "public volatile")]
	public Dova.JDK.com.sun.net.httpserver.HttpContext getHttpContext_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpContext>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/httpserver/ExchangeImpl;", "")]
	public Dova.JDK.sun.net.httpserver.ExchangeImpl getExchangeImpl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.httpserver.ExchangeImpl>(ret);
	}

	[JniSignatureAttribute("(IJ)V", "public")]
	public void sendResponseHeaders(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "public")]
	public Dova.JDK.java.net.InetSocketAddress getLocalAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}
}
