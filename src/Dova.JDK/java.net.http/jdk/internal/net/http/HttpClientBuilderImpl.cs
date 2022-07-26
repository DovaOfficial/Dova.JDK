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

[JniSignatureAttribute("Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
public partial class HttpClientBuilderImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.net.http.HttpClient.Builder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpClientBuilderImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/HttpClientBuilderImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cookieHandler", "Ljava/net/CookieHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectTimeout", "Ljava/time/Duration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "followRedirects", "Ljava/net/http/HttpClient$Redirect;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxy", "Ljava/net/ProxySelector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authenticator", "Ljava/net/Authenticator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "Ljava/net/http/HttpClient$Version;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/Executor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslContext", "Ljavax/net/ssl/SSLContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslParams", "Ljavax/net/ssl/SSLParameters;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "priority", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "priority_0", "(I)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "priority_1", "(I)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version_0", "(Ljava/net/http/HttpClient$Version;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version_1", "(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "proxy_0", "(Ljava/net/ProxySelector;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "proxy_1", "(Ljava/net/ProxySelector;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/net/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executor_0", "(Ljava/util/concurrent/Executor;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executor_1", "(Ljava/util/concurrent/Executor;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslParameters_0", "(Ljavax/net/ssl/SSLParameters;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslParameters_1", "(Ljavax/net/ssl/SSLParameters;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cookieHandler_0", "(Ljava/net/CookieHandler;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cookieHandler_1", "(Ljava/net/CookieHandler;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connectTimeout_0", "(Ljava/time/Duration;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connectTimeout_1", "(Ljava/time/Duration;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "followRedirects_0", "(Ljava/net/http/HttpClient$Redirect;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "followRedirects_1", "(Ljava/net/http/HttpClient$Redirect;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslContext_0", "(Ljavax/net/ssl/SSLContext;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslContext_1", "(Ljavax/net/ssl/SSLContext;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "authenticator_0", "(Ljava/net/Authenticator;)Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "authenticator_1", "(Ljava/net/Authenticator;)Ljdk/internal/net/http/HttpClientBuilderImpl;"));
	}

	[JniSignatureAttribute("Ljava/net/CookieHandler;", "")]
	public Dova.JDK.java.net.CookieHandler cookieHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.CookieHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/Duration;", "")]
	public Dova.JDK.java.time.Duration connectTimeout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpClient$Redirect;", "")]
	public Dova.JDK.java.net.http.HttpClient.Redirect followRedirects_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/ProxySelector;", "")]
	public Dova.JDK.java.net.ProxySelector proxy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.ProxySelector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/Authenticator;", "")]
	public Dova.JDK.java.net.Authenticator authenticator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.Authenticator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpClient$Version;", "")]
	public Dova.JDK.java.net.http.HttpClient.Version version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "")]
	public Dova.JDK.java.util.concurrent.Executor executor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLContext;", "")]
	public Dova.JDK.javax.net.ssl.SSLContext sslContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLParameters;", "")]
	public Dova.JDK.javax.net.ssl.SSLParameters sslParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLParameters>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int priority_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpClientBuilderImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HttpClientBuilderImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/HttpClientBuilderImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder priority_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl priority_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpClient$Version;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl version_0(Dova.JDK.java.net.http.HttpClient.Version arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder version_1(Dova.JDK.java.net.http.HttpClient.Version arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/ProxySelector;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder proxy_0(Dova.JDK.java.net.ProxySelector arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/ProxySelector;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl proxy_1(Dova.JDK.java.net.ProxySelector arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient;", "public")]
	public Dova.JDK.java.net.http.HttpClient build()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder executor_0(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl executor_1(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLParameters;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl sslParameters_0(Dova.JDK.javax.net.ssl.SSLParameters arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLParameters;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder sslParameters_1(Dova.JDK.javax.net.ssl.SSLParameters arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/CookieHandler;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder cookieHandler_0(Dova.JDK.java.net.CookieHandler arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/CookieHandler;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl cookieHandler_1(Dova.JDK.java.net.CookieHandler arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder connectTimeout_0(Dova.JDK.java.time.Duration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Duration;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl connectTimeout_1(Dova.JDK.java.time.Duration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpClient$Redirect;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl followRedirects_0(Dova.JDK.java.net.http.HttpClient.Redirect arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpClient$Redirect;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder followRedirects_1(Dova.JDK.java.net.http.HttpClient.Redirect arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLContext;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder sslContext_0(Dova.JDK.javax.net.ssl.SSLContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLContext;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl sslContext_1(Dova.JDK.javax.net.ssl.SSLContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/Authenticator;)Ljava/net/http/HttpClient$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpClient.Builder authenticator_0(Dova.JDK.java.net.Authenticator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/Authenticator;)Ljdk/internal/net/http/HttpClientBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl authenticator_1(Dova.JDK.java.net.Authenticator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientBuilderImpl>(ret);
	}
}
