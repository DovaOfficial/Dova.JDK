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

[JniSignatureAttribute("Ljdk/internal/net/http/HttpRequestBuilderImpl;", "public")]
public partial class HttpRequestBuilderImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.net.http.HttpRequest.Builder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpRequestBuilderImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/HttpRequestBuilderImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "headersBuilder", "Ljdk/internal/net/http/common/HttpHeadersBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uri", "Ljava/net/URI;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expectContinue", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bodyPublisher", "Ljava/net/http/HttpRequest$BodyPublisher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "Ljava/util/Optional;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "duration", "Ljava/time/Duration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URI;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "(Ljava/lang/String;Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version_0", "(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version_1", "(Ljava/net/http/HttpClient$Version;)Ljdk/internal/net/http/HttpRequestBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uri", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uri_0", "(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uri_1", "(Ljava/net/URI;)Ljdk/internal/net/http/HttpRequestBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_0", "()Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_1", "()Ljdk/internal/net/http/HttpRequestBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "GET", "()Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timeout", "()Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timeout", "(Ljava/time/Duration;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/net/http/HttpRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "DELETE", "()Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "header_0", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/net/http/HttpRequestBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "header_1", "(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "HEAD", "()Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "POST", "(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "PUT", "(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "headersBuilder", "()Ljdk/internal/net/http/common/HttpHeadersBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectContinue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectContinue_0", "(Z)Ljdk/internal/net/http/HttpRequestBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectContinue_1", "(Z)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bodyPublisher", "()Ljava/net/http/HttpRequest$BodyPublisher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkURI", "(Ljava/net/URI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHeader_0", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/net/http/HttpRequestBuilderImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHeader_1", "(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkNameAndValue", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method0", "(Ljava/lang/String;Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildForWebSocket", "()Ljdk/internal/net/http/HttpRequestImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "headers_0", "([Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "headers_1", "([Ljava/lang/String;)Ljdk/internal/net/http/HttpRequestBuilderImpl;"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/HttpHeadersBuilder;", "private")]
	public Dova.JDK.jdk.@internal.net.http.common.HttpHeadersBuilder headersBuilder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.HttpHeadersBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/URI;", "private")]
	public Dova.JDK.java.net.URI uri_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String method_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool expectContinue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpRequest$BodyPublisher;", "private")]
	public Dova.JDK.java.net.http.HttpRequest.BodyPublisher bodyPublisher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Optional;", "private volatile")]
	public Dova.JDK.java.util.Optional version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/Duration;", "private")]
	public Dova.JDK.java.time.Duration duration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpRequestBuilderImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/URI;)V", "public")]
	public HttpRequestBuilderImpl(Dova.JDK.java.net.URI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HttpRequestBuilderImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/HttpRequestBuilderImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public")]
	public Dova.JDK.java.net.http.HttpRequest.Builder method(Dova.JDK.java.lang.String arg0, Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String method()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "")]
	public Dova.JDK.java.util.Optional version()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpRequest$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpRequest.Builder version_0(Dova.JDK.java.net.http.HttpClient.Version arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpClient$Version;)Ljdk/internal/net/http/HttpRequestBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl version_1(Dova.JDK.java.net.http.HttpClient.Version arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "")]
	public Dova.JDK.java.net.URI uri()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpRequest.Builder uri_0(Dova.JDK.java.net.URI arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;)Ljdk/internal/net/http/HttpRequestBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl uri_1(Dova.JDK.java.net.URI arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpRequest.Builder copy_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/HttpRequestBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl copy_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public")]
	public Dova.JDK.java.net.http.HttpRequest.Builder GET()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/Duration;", "")]
	public Dova.JDK.java.time.Duration timeout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/net/http/HttpRequest$Builder;", "public")]
	public Dova.JDK.java.net.http.HttpRequest.Builder timeout(Dova.JDK.java.time.Duration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest;", "public")]
	public Dova.JDK.java.net.http.HttpRequest build()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public")]
	public Dova.JDK.java.net.http.HttpRequest.Builder DELETE()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/net/http/HttpRequestBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl header_0(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpRequest.Builder header_1(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public")]
	public Dova.JDK.java.net.http.HttpRequest.Builder HEAD()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public")]
	public Dova.JDK.java.net.http.HttpRequest.Builder POST(Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public")]
	public Dova.JDK.java.net.http.HttpRequest.Builder PUT(Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/common/HttpHeadersBuilder;", "")]
	public Dova.JDK.jdk.@internal.net.http.common.HttpHeadersBuilder headersBuilder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.HttpHeadersBuilder>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool expectContinue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/net/http/HttpRequestBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl expectContinue_0(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/net/http/HttpRequest$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpRequest.Builder expectContinue_1(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest$BodyPublisher;", "")]
	public Dova.JDK.java.net.http.HttpRequest.BodyPublisher bodyPublisher()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;)V", "static")]
	public static void checkURI(Dova.JDK.java.net.URI arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/net/http/HttpRequestBuilderImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl setHeader_0(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpRequest.Builder setHeader_1(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void checkNameAndValue(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "private")]
	public Dova.JDK.java.net.http.HttpRequest.Builder method0(Dova.JDK.java.lang.String arg0, Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/HttpRequestImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestImpl buildForWebSocket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestImpl>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public volatile")]
	public Dova.JDK.java.net.http.HttpRequest.Builder headers_0(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljdk/internal/net/http/HttpRequestBuilderImpl;", "public transient")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl headers_1(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestBuilderImpl>(ret);
	}
}
