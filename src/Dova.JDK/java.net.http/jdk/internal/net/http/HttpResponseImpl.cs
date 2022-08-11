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

namespace Dova.JDK.jdk.@internal.net.http;

[JniSignatureAttribute("Ljdk/internal/net/http/HttpResponseImpl;", "")]
public partial class HttpResponseImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.net.http.HttpResponse
	, Dova.JDK.jdk.@internal.net.http.websocket.RawChannel.Provider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpResponseImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/HttpResponseImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "responseCode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialRequest", "Ljava/net/http/HttpRequest;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousResponse", "Ljava/util/Optional;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "headers", "Ljava/net/http/HttpHeaders;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslSession", "Ljava/util/Optional;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uri", "Ljava/net/URI;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "Ljava/net/http/HttpClient$Version;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawChannelProvider", "Ljdk/internal/net/http/HttpResponseImpl$RawChannelProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/http/HttpRequest;Ljdk/internal/net/http/Response;Ljava/net/http/HttpResponse;Ljava/lang/Object;Ljdk/internal/net/http/Exchange;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "()Ljava/net/http/HttpClient$Version;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uri", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "statusCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "body", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previousResponse", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslSession", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rawChannel", "()Ljdk/internal/net/http/websocket/RawChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeRawChannel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "headers", "()Ljava/net/http/HttpHeaders;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "()Ljava/net/http/HttpRequest;"));
	}

	[JniSignatureAttribute("I", "final")]
	public int responseCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpRequest;", "final")]
	public Dova.JDK.java.net.http.HttpRequest initialRequest_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Optional;", "final")]
	public Dova.JDK.java.util.Optional previousResponse_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpHeaders;", "final")]
	public Dova.JDK.java.net.http.HttpHeaders headers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Optional;", "final")]
	public Dova.JDK.java.util.Optional sslSession_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/URI;", "final")]
	public Dova.JDK.java.net.URI uri_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpClient$Version;", "final")]
	public Dova.JDK.java.net.http.HttpClient.Version version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpResponseImpl$RawChannelProvider;", "final")]
	public Dova.JDK.jdk.@internal.net.http.HttpResponseImpl.RawChannelProvider rawChannelProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpResponseImpl.RawChannelProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object body_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpResponseImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljdk/internal/net/http/Response;Ljava/net/http/HttpResponse;Ljava/lang/Object;Ljdk/internal/net/http/Exchange;)V", "public")]
	public HttpResponseImpl(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.jdk.@internal.net.http.Response arg1, Dova.JDK.java.net.http.HttpResponse arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.jdk.@internal.net.http.Exchange arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/HttpResponseImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Version;", "public")]
	public Dova.JDK.java.net.http.HttpClient.Version version()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "public")]
	public Dova.JDK.java.net.URI uri()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int statusCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object body()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional previousResponse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional sslSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/websocket/RawChannel;", "public synchronized")]
	public Dova.JDK.jdk.@internal.net.http.websocket.RawChannel rawChannel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.RawChannel>(ret);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void closeRawChannel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "public")]
	public Dova.JDK.java.net.http.HttpHeaders headers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest;", "public")]
	public Dova.JDK.java.net.http.HttpRequest request()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpResponseImpl$RawChannelProvider;", "private static final")]
	public partial class RawChannelProvider
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.websocket.RawChannel.Provider
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RawChannelProvider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/HttpResponseImpl$RawChannelProvider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connection", "Ljdk/internal/net/http/HttpConnection;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exchange", "Ljdk/internal/net/http/Exchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawchan", "Ljdk/internal/net/http/websocket/RawChannel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/HttpConnection;Ljdk/internal/net/http/Exchange;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljdk/internal/net/http/Response;Ljdk/internal/net/http/Exchange;)Ljdk/internal/net/http/HttpResponseImpl$RawChannelProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "connection", "(Ljdk/internal/net/http/Response;Ljdk/internal/net/http/Exchange;)Ljdk/internal/net/http/HttpConnection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exchangeImpl", "()Ljdk/internal/net/http/ExchangeImpl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rawChannel", "()Ljdk/internal/net/http/websocket/RawChannel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeRawChannel", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/HttpConnection;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.HttpConnection connection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpConnection>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Exchange;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.Exchange exchange_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Exchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/RawChannel;", "private")]
		public Dova.JDK.jdk.@internal.net.http.websocket.RawChannel rawchan_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.RawChannel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RawChannelProvider(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/HttpConnection;Ljdk/internal/net/http/Exchange;)V", "")]
		public RawChannelProvider(Dova.JDK.jdk.@internal.net.http.HttpConnection arg0, Dova.JDK.jdk.@internal.net.http.Exchange arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/HttpResponseImpl$RawChannelProvider;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/net/http/Response;Ljdk/internal/net/http/Exchange;)Ljdk/internal/net/http/HttpResponseImpl$RawChannelProvider;", "static")]
		public static Dova.JDK.jdk.@internal.net.http.HttpResponseImpl.RawChannelProvider create(Dova.JDK.jdk.@internal.net.http.Response arg0, Dova.JDK.jdk.@internal.net.http.Exchange arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpResponseImpl.RawChannelProvider>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/Response;Ljdk/internal/net/http/Exchange;)Ljdk/internal/net/http/HttpConnection;", "private static")]
		public static Dova.JDK.jdk.@internal.net.http.HttpConnection connection(Dova.JDK.jdk.@internal.net.http.Response arg0, Dova.JDK.jdk.@internal.net.http.Exchange arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpConnection>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/ExchangeImpl;", "private")]
		public Dova.JDK.jdk.@internal.net.http.ExchangeImpl exchangeImpl()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ExchangeImpl>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/websocket/RawChannel;", "public synchronized")]
		public Dova.JDK.jdk.@internal.net.http.websocket.RawChannel rawChannel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.RawChannel>(ret);
		}

		[JniSignatureAttribute("()V", "public synchronized")]
		public void closeRawChannel()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}
	}
}
