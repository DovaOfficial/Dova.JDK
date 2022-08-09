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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/net/http/HttpClient;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "HttpClient", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "version", "()Ljava/net/http/HttpClient$Version;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "proxy", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "executor", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sslParameters", "()Ljavax/net/ssl/SSLParameters;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newBuilder", "()Ljava/net/http/HttpClient$Builder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newHttpClient", "()Ljava/net/http/HttpClient;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "cookieHandler", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "connectTimeout", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "followRedirects", "()Ljava/net/http/HttpClient$Redirect;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sslContext", "()Ljavax/net/ssl/SSLContext;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sendAsync", "(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;Ljava/net/http/HttpResponse$PushPromiseHandler;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sendAsync", "(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newWebSocketBuilder", "()Ljava/net/http/WebSocket$Builder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "send", "(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;)Ljava/net/http/HttpResponse;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "authenticator", "()Ljava/util/Optional;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpClient(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public HttpClient() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/net/http/HttpClient;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Version;", "public abstract")]
	public Dova.JDK.java.net.http.HttpClient.Version version()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional proxy()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional executor()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLParameters;", "public abstract")]
	public Dova.JDK.javax.net.ssl.SSLParameters sslParameters()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLParameters>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Builder;", "public static")]
	public static Dova.JDK.java.net.http.HttpClient.Builder newBuilder()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient;", "public static")]
	public static Dova.JDK.java.net.http.HttpClient newHttpClient()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional cookieHandler()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional connectTimeout()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Redirect;", "public abstract")]
	public Dova.JDK.java.net.http.HttpClient.Redirect followRedirects()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLContext;", "public abstract")]
	public Dova.JDK.javax.net.ssl.SSLContext sslContext()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;Ljava/net/http/HttpResponse$PushPromiseHandler;)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture sendAsync(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.net.http.HttpResponse.BodyHandler arg1, Dova.JDK.java.net.http.HttpResponse.PushPromiseHandler arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;)Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	public Dova.JDK.java.util.concurrent.CompletableFuture sendAsync(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.net.http.HttpResponse.BodyHandler arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/WebSocket$Builder;", "public")]
	public Dova.JDK.java.net.http.WebSocket.Builder newWebSocketBuilder()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.WebSocket.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/net/http/HttpResponse$BodyHandler;)Ljava/net/http/HttpResponse;", "public abstract")]
	public Dova.JDK.java.net.http.HttpResponse send(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.net.http.HttpResponse.BodyHandler arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional authenticator()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/net/http/HttpClient$Builder;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NO_PROXY", "Ljava/net/ProxySelector;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "priority", "(I)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "version", "(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "proxy", "(Ljava/net/ProxySelector;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "build", "()Ljava/net/http/HttpClient;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "executor", "(Ljava/util/concurrent/Executor;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sslParameters", "(Ljavax/net/ssl/SSLParameters;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "cookieHandler", "(Ljava/net/CookieHandler;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "connectTimeout", "(Ljava/time/Duration;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "followRedirects", "(Ljava/net/http/HttpClient$Redirect;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sslContext", "(Ljavax/net/ssl/SSLContext;)Ljava/net/http/HttpClient$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "authenticator", "(Ljava/net/Authenticator;)Ljava/net/http/HttpClient$Builder;"));
		}

		[JniSignatureAttribute("Ljava/net/ProxySelector;", "public static final")]
		public static Dova.JDK.java.net.ProxySelector NO_PROXY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.ProxySelector>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(I)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder priority(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder version(Dova.JDK.java.net.http.HttpClient.Version arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/ProxySelector;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder proxy(Dova.JDK.java.net.ProxySelector arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpClient;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient build()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder executor(Dova.JDK.java.util.concurrent.Executor arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljavax/net/ssl/SSLParameters;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder sslParameters(Dova.JDK.javax.net.ssl.SSLParameters arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/CookieHandler;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder cookieHandler(Dova.JDK.java.net.CookieHandler arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder connectTimeout(Dova.JDK.java.time.Duration arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpClient$Redirect;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder followRedirects(Dova.JDK.java.net.http.HttpClient.Redirect arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljavax/net/ssl/SSLContext;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder sslContext(Dova.JDK.javax.net.ssl.SSLContext arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/Authenticator;)Ljava/net/http/HttpClient$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Builder authenticator(Dova.JDK.java.net.Authenticator arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/net/http/HttpClient$Redirect;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NEVER", "Ljava/net/http/HttpClient$Redirect;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ALWAYS", "Ljava/net/http/HttpClient$Redirect;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NORMAL", "Ljava/net/http/HttpClient$Redirect;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/net/http/HttpClient$Redirect;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Redirect", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/net/http/HttpClient$Redirect;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/net/http/HttpClient$Redirect;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/net/http/HttpClient$Redirect;"));
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Redirect;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Redirect NEVER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Redirect;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Redirect ALWAYS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Redirect;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Redirect NORMAL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/net/http/HttpClient$Redirect;", "private static final")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Redirect(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Redirect(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/net/http/HttpClient$Redirect;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/net/http/HttpClient$Redirect;", "public static")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/http/HttpClient$Redirect;", "public static")]
		public static Dova.JDK.java.net.http.HttpClient.Redirect valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Redirect>(ret);
		}

		[JniSignatureAttribute("()[Ljava/net/http/HttpClient$Redirect;", "private static")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Redirect> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/net/http/HttpClient$Version;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HTTP_1_1", "Ljava/net/http/HttpClient$Version;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HTTP_2", "Ljava/net/http/HttpClient$Version;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/net/http/HttpClient$Version;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Version", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/net/http/HttpClient$Version;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/net/http/HttpClient$Version;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/net/http/HttpClient$Version;"));
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Version;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Version HTTP_1_1_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/net/http/HttpClient$Version;", "public static final")]
		public static Dova.JDK.java.net.http.HttpClient.Version HTTP_2_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/net/http/HttpClient$Version;", "private static final")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Version> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Version>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Version(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Version(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/net/http/HttpClient$Version;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/net/http/HttpClient$Version;", "public static")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Version> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Version>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/http/HttpClient$Version;", "public static")]
		public static Dova.JDK.java.net.http.HttpClient.Version valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
		}

		[JniSignatureAttribute("()[Ljava/net/http/HttpClient$Version;", "private static")]
		public static JavaArray<Dova.JDK.java.net.http.HttpClient.Version> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.http.HttpClient.Version>>(ret);
		}
	}
}
