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

[JniSignatureAttribute("Ljdk/internal/net/http/Exchange;", "final")]
public partial class Exchange
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Exchange()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Exchange;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "request", "Ljdk/internal/net/http/HttpRequestImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "client", "Ljdk/internal/net/http/HttpClientImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exchImpl", "Ljdk/internal/net/http/ExchangeImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exchangeCF", "Ljava/util/concurrent/CompletableFuture;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bodyIgnored", "Ljava/util/concurrent/CompletableFuture;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "failed", "Ljava/io/IOException;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "multi", "Ljdk/internal/net/http/MultiExchange;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parentExecutor", "Ljava/util/concurrent/Executor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upgrading", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upgraded", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pushGroup", "Ljdk/internal/net/http/PushGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dbgTag", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectionAborter", "Ljdk/internal/net/http/Exchange$ConnectionAborter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/MultiExchange;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/MultiExchange;Ljava/security/AccessControlContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "()Ljava/net/http/HttpClient$Version;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executor", "()Ljava/util/concurrent/Executor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "(Ljava/io/IOException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dbgString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "responseAsyncImpl", "(Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreBody", "(Ljava/net/http/HttpResponse$ResponseInfo;)Ljava/net/http/HttpResponse$BodySubscriber;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreBody", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remainingConnectTimeout", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCancelled", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCancelled", "(Ljava/util/concurrent/CompletableFuture;Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCancelCause", "()Ljava/io/IOException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "permissionForServer", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/URLPermission;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectContinue", "(Ljdk/internal/net/http/ExchangeImpl;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nullBody", "(Ljava/net/http/HttpResponse;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBodyAsync", "(Ljava/net/http/HttpResponse$BodyHandler;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "released", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "responseAsyncImpl0", "(Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendRequestBody", "(Ljdk/internal/net/http/ExchangeImpl;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrapForUpgrade", "(Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrapForLog", "(Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "establishExchange", "(Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURIForSecurityCheck", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replaceHostInURI", "(Ljava/net/URI;Ljava/lang/String;)Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkForUpgradeAsync", "(Ljdk/internal/net/http/Response;Ljdk/internal/net/http/ExchangeImpl;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkFor407", "(Ljdk/internal/net/http/ExchangeImpl;Ljava/lang/Throwable;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPushGroup", "()Ljdk/internal/net/http/PushGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "h2Upgrade", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPermissions", "()Ljava/lang/SecurityException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "client", "()Ljdk/internal/net/http/HttpClientImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "responseAsync", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "()Ljdk/internal/net/http/HttpRequestImpl;"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/Logger;", "final")]
	public Dova.JDK.jdk.@internal.net.http.common.Logger debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpRequestImpl;", "final")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestImpl request_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpClientImpl;", "final")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientImpl client_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ExchangeImpl;", "volatile")]
	public Dova.JDK.jdk.@internal.net.http.ExchangeImpl exchImpl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ExchangeImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "volatile")]
	public Dova.JDK.java.util.concurrent.CompletableFuture exchangeCF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "volatile")]
	public Dova.JDK.java.util.concurrent.CompletableFuture bodyIgnored_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/IOException;", "private volatile")]
	public Dova.JDK.java.io.IOException failed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "final")]
	public Dova.JDK.java.security.AccessControlContext acc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/MultiExchange;", "final")]
	public Dova.JDK.jdk.@internal.net.http.MultiExchange multi_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.MultiExchange>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "final")]
	public Dova.JDK.java.util.concurrent.Executor parentExecutor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "volatile")]
	public bool upgrading_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Z", "volatile")]
	public bool upgraded_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/PushGroup;", "final")]
	public Dova.JDK.jdk.@internal.net.http.PushGroup pushGroup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.PushGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String dbgTag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Exchange$ConnectionAborter;", "final")]
	public Dova.JDK.jdk.@internal.net.http.Exchange.ConnectionAborter connectionAborter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Exchange.ConnectionAborter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Exchange(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/MultiExchange;)V", "")]
	public Exchange(Dova.JDK.jdk.@internal.net.http.HttpRequestImpl arg0, Dova.JDK.jdk.@internal.net.http.MultiExchange arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/MultiExchange;Ljava/security/AccessControlContext;)V", "")]
	public Exchange(Dova.JDK.jdk.@internal.net.http.HttpRequestImpl arg0, Dova.JDK.jdk.@internal.net.http.MultiExchange arg1, Dova.JDK.java.security.AccessControlContext arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Exchange;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Version;", "")]
	public Dova.JDK.java.net.http.HttpClient.Version version()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/Executor;", "")]
	public Dova.JDK.java.util.concurrent.Executor executor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/IOException;)V", "public")]
	public void cancel(Dova.JDK.java.io.IOException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void cancel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String dbgString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;", "")]
	public Dova.JDK.java.util.concurrent.CompletableFuture responseAsyncImpl(Dova.JDK.jdk.@internal.net.http.HttpConnection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse$ResponseInfo;)Ljava/net/http/HttpResponse$BodySubscriber;", "")]
	public Dova.JDK.java.net.http.HttpResponse.BodySubscriber ignoreBody(Dova.JDK.java.net.http.HttpResponse.ResponseInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture ignoreBody()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional remainingConnectTimeout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkCancelled()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;", "")]
	public Dova.JDK.java.util.concurrent.CompletableFuture checkCancelled(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.jdk.@internal.net.http.HttpConnection arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/IOException;", "synchronized")]
	public Dova.JDK.java.io.IOException getCancelCause()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/URLPermission;", "private static")]
	public static Dova.JDK.java.net.URLPermission permissionForServer(Dova.JDK.java.net.URI arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URLPermission>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/ExchangeImpl;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture expectContinue(Dova.JDK.jdk.@internal.net.http.ExchangeImpl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse;Ljava/lang/Throwable;)V", "")]
	public void nullBody(Dova.JDK.java.net.http.HttpResponse arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodyHandler;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture readBodyAsync(Dova.JDK.java.net.http.HttpResponse.BodyHandler arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void released()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;", "")]
	public Dova.JDK.java.util.concurrent.CompletableFuture responseAsyncImpl0(Dova.JDK.jdk.@internal.net.http.HttpConnection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/ExchangeImpl;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture sendRequestBody(Dova.JDK.jdk.@internal.net.http.ExchangeImpl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture wrapForUpgrade(Dova.JDK.java.util.concurrent.CompletableFuture arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture wrapForLog(Dova.JDK.java.util.concurrent.CompletableFuture arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpConnection;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture establishExchange(Dova.JDK.jdk.@internal.net.http.HttpConnection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "private")]
	public Dova.JDK.java.net.URI getURIForSecurityCheck()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;Ljava/lang/String;)Ljava/net/URI;", "private static")]
	public static Dova.JDK.java.net.URI replaceHostInURI(Dova.JDK.java.net.URI arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Response;Ljdk/internal/net/http/ExchangeImpl;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture checkForUpgradeAsync(Dova.JDK.jdk.@internal.net.http.Response arg0, Dova.JDK.jdk.@internal.net.http.ExchangeImpl arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/ExchangeImpl;Ljava/lang/Throwable;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture checkFor407(Dova.JDK.jdk.@internal.net.http.ExchangeImpl arg0, Dova.JDK.java.lang.Throwable arg1, Dova.JDK.java.util.function.Function arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/PushGroup;", "")]
	public Dova.JDK.jdk.@internal.net.http.PushGroup getPushGroup()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.PushGroup>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void h2Upgrade()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("()Ljava/lang/SecurityException;", "private")]
	public Dova.JDK.java.lang.SecurityException checkPermissions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.SecurityException>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/HttpClientImpl;", "")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientImpl client()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientImpl>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture responseAsync()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/HttpRequestImpl;", "public")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestImpl request()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestImpl>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Exchange$ConnectionAborter;", "static final")]
	public partial class ConnectionAborter
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConnectionAborter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Exchange$ConnectionAborter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connection", "Ljdk/internal/net/http/HttpConnection;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closeRequested", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connection", "(Ljdk/internal/net/http/HttpConnection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disable", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeConnection", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/HttpConnection;", "private volatile")]
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

		[JniSignatureAttribute("Z", "private volatile")]
		public bool closeRequested_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConnectionAborter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ConnectionAborter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Exchange$ConnectionAborter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/net/http/HttpConnection;)V", "")]
		public void connection(Dova.JDK.jdk.@internal.net.http.HttpConnection arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void disable()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()V", "")]
		public void closeConnection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}
	}
}
