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

namespace Dova.JDK.java.net.http;

[JniSignatureAttribute("Ljava/net/http/HttpClient;", "public abstract")]
public partial class HttpClient
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpClient()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpClient;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "()Ljava/net/http/HttpClient$Version;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "proxy", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executor", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslParameters", "()Ljavax/net/ssl/SSLParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newBuilder", "()Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newHttpClient", "()Ljava/net/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cookieHandler", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connectTimeout", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "followRedirects", "()Ljava/net/http/HttpClient$Redirect;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslContext", "()Ljavax/net/ssl/SSLContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendAsync", "(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;Ljava/net/http/HttpResponse$PushPromiseHandler;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendAsync", "(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newWebSocketBuilder", "()Ljava/net/http/WebSocket$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;)Ljava/net/http/HttpResponse;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "authenticator", "()Ljava/util/Optional;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpClient(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public HttpClient() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/net/http/HttpClient;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Version;", "public abstract")]
	public Dova.JDK.java.net.http.HttpClient.Version version()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional proxy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional executor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLParameters;", "public abstract")]
	public Dova.JDK.javax.net.ssl.SSLParameters sslParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLParameters>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Builder;", "public static")]
	public static Dova.JDK.java.net.http.HttpClient.Builder newBuilder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient;", "public static")]
	public static Dova.JDK.java.net.http.HttpClient newHttpClient()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional cookieHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional connectTimeout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Redirect;", "public abstract")]
	public Dova.JDK.java.net.http.HttpClient.Redirect followRedirects()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLContext;", "public abstract")]
	public Dova.JDK.javax.net.ssl.SSLContext sslContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;Ljava/net/http/HttpResponse$PushPromiseHandler;)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture sendAsync(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.net.http.HttpResponse.BodyHandler arg1, Dova.JDK.java.net.http.HttpResponse.PushPromiseHandler arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture sendAsync(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.net.http.HttpResponse.BodyHandler arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/WebSocket$Builder;", "public")]
	public Dova.JDK.java.net.http.WebSocket.Builder newWebSocketBuilder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.WebSocket.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;)Ljava/net/http/HttpResponse;", "public abstract")]
	public Dova.JDK.java.net.http.HttpResponse send(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.net.http.HttpResponse.BodyHandler arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional authenticator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("Ljava/net/http/HttpClient$Builder;", "public abstract static interface")]
	public partial interface Builder
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpClient$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_PROXY", "Ljava/net/ProxySelector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "priority", "(I)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "proxy", "(Ljava/net/ProxySelector;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/net/http/HttpClient;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executor", "(Ljava/util/concurrent/Executor;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslParameters", "(Ljavax/net/ssl/SSLParameters;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cookieHandler", "(Ljava/net/CookieHandler;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connectTimeout", "(Ljava/time/Duration;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "followRedirects", "(Ljava/net/http/HttpClient$Redirect;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslContext", "(Ljavax/net/ssl/SSLContext;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "authenticator", "(Ljava/net/Authenticator;)Ljava/net/http/HttpClient$Builder;"));
		}

		[JniSignatureAttribute("Ljava/net/ProxySelector;", "public static final")]
		public static Dova.JDK.java.net.ProxySelector NO_PROXY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.ProxySelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(I)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder priority(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder version(Dova.JDK.java.net.http.HttpClient.Version arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/ProxySelector;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder proxy(Dova.JDK.java.net.ProxySelector arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpClient;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder executor(Dova.JDK.java.util.concurrent.Executor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljavax/net/ssl/SSLParameters;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder sslParameters(Dova.JDK.javax.net.ssl.SSLParameters arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/CookieHandler;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder cookieHandler(Dova.JDK.java.net.CookieHandler arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder connectTimeout(Dova.JDK.java.time.Duration arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpClient$Redirect;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder followRedirects(Dova.JDK.java.net.http.HttpClient.Redirect arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljavax/net/ssl/SSLContext;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder sslContext(Dova.JDK.javax.net.ssl.SSLContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/Authenticator;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder authenticator(Dova.JDK.java.net.Authenticator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpClient$Redirect;", "public static final")]
	public partial class Redirect
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Redirect()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpClient$Redirect;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEVER", "Ljava/net/http/HttpClient$Redirect;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALWAYS", "Ljava/net/http/HttpClient$Redirect;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Ljava/net/http/HttpClient$Redirect;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/net/http/HttpClient$Redirect;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/net/http/HttpClient$Redirect;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/net/http/HttpClient$Redirect;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/net/http/HttpClient$Redirect;"));
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Redirect;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Redirect NEVER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Redirect;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Redirect ALWAYS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Redirect;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Redirect NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/net/http/HttpClient$Redirect;", "private static final")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Redirect(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Redirect(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/net/http/HttpClient$Redirect;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/net/http/HttpClient$Redirect;", "public static")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/http/HttpClient$Redirect;", "public static")]
		public static Dova.JDK.java.net.http.HttpClient.Redirect valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
		}

		[JniSignatureAttribute("()[Ljava/net/http/HttpClient$Redirect;", "private static")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpClient$Version;", "public static final")]
	public partial class Version
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Version()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpClient$Version;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HTTP_1_1", "Ljava/net/http/HttpClient$Version;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HTTP_2", "Ljava/net/http/HttpClient$Version;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/net/http/HttpClient$Version;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/net/http/HttpClient$Version;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/net/http/HttpClient$Version;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/net/http/HttpClient$Version;"));
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Version;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Version HTTP_1_1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Version;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Version HTTP_2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/net/http/HttpClient$Version;", "private static final")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Version> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Version>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Version(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Version(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/net/http/HttpClient$Version;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/net/http/HttpClient$Version;", "public static")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Version> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Version>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/http/HttpClient$Version;", "public static")]
		public static Dova.JDK.java.net.http.HttpClient.Version valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
		}

		[JniSignatureAttribute("()[Ljava/net/http/HttpClient$Version;", "private static")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Version> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Version>>(ret);
		}
	}
}
