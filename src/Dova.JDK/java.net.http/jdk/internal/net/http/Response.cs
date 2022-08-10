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

[JniSignatureAttribute("Ljdk/internal/net/http/Response;", "")]
public partial class Response
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Response()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Response;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "headers", "Ljava/net/http/HttpHeaders;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "statusCode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "request", "Ljdk/internal/net/http/HttpRequestImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exchange", "Ljdk/internal/net/http/Exchange;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "version", "Ljava/net/http/HttpClient$Version;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isConnectResponse", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sslSession", "Ljavax/net/ssl/SSLSession;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "localAddress", "Ljava/net/InetSocketAddress;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Response", "(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/Exchange;Ljava/net/http/HttpHeaders;Ljdk/internal/net/http/HttpConnection;ILjava/net/http/HttpClient$Version;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Response", "(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/Exchange;Ljava/net/http/HttpHeaders;Ljdk/internal/net/http/HttpConnection;ILjava/net/http/HttpClient$Version;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "version", "()Ljava/net/http/HttpClient$Version;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "statusCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "headers", "()Ljava/net/http/HttpHeaders;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSSLSession", "()Ljavax/net/ssl/SSLSession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "request", "()Ljdk/internal/net/http/HttpRequestImpl;"));
	}

	[JniSignatureAttribute("Ljava/net/http/HttpHeaders;", "final")]
	public Dova.JDK.java.net.http.HttpHeaders headers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "final")]
	public int statusCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpRequestImpl;", "final")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestImpl request_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestImpl>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Exchange;", "final")]
	public Dova.JDK.jdk.@internal.net.http.Exchange exchange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Exchange>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/net/http/HttpClient$Version;", "final")]
	public Dova.JDK.java.net.http.HttpClient.Version version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "final")]
	public bool isConnectResponse_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLSession;", "final")]
	public Dova.JDK.javax.net.ssl.SSLSession sslSession_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSession>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/net/InetSocketAddress;", "final")]
	public Dova.JDK.java.net.InetSocketAddress localAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Response(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/Exchange;Ljava/net/http/HttpHeaders;Ljdk/internal/net/http/HttpConnection;ILjava/net/http/HttpClient$Version;)V", "")]
	public Response(Dova.JDK.jdk.@internal.net.http.HttpRequestImpl arg0, Dova.JDK.jdk.@internal.net.http.Exchange arg1, Dova.JDK.java.net.http.HttpHeaders arg2, Dova.JDK.jdk.@internal.net.http.HttpConnection arg3, int arg4, Dova.JDK.java.net.http.HttpClient.Version arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/Exchange;Ljava/net/http/HttpHeaders;Ljdk/internal/net/http/HttpConnection;ILjava/net/http/HttpClient$Version;Z)V", "")]
	public Response(Dova.JDK.jdk.@internal.net.http.HttpRequestImpl arg0, Dova.JDK.jdk.@internal.net.http.Exchange arg1, Dova.JDK.java.net.http.HttpHeaders arg2, Dova.JDK.jdk.@internal.net.http.HttpConnection arg3, int arg4, Dova.JDK.java.net.http.HttpClient.Version arg5, bool arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Response;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Version;", "")]
	public Dova.JDK.java.net.http.HttpClient.Version version()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int statusCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "")]
	public Dova.JDK.java.net.http.HttpHeaders headers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSession;", "")]
	public Dova.JDK.javax.net.ssl.SSLSession getSSLSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSession>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/HttpRequestImpl;", "")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestImpl request()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestImpl>(ret);
	}
}
