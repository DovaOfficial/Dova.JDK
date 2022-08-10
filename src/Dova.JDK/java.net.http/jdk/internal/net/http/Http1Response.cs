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

[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response;", "")]
public partial class Http1Response
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Http1Response()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1Response;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "content", "Ljdk/internal/net/http/ResponseContent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "request", "Ljdk/internal/net/http/HttpRequestImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "response", "Ljdk/internal/net/http/Response;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "connection", "Ljdk/internal/net/http/HttpConnection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "headers", "Ljava/net/http/HttpHeaders;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "responseCode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exchange", "Ljdk/internal/net/http/Http1Exchange;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "return2Cache", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "headersReader", "Ljdk/internal/net/http/Http1Response$HeadersReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bodyReader", "Ljdk/internal/net/http/Http1Response$BodyReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "asyncReceiver", "Ljdk/internal/net/http/Http1AsyncReceiver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "eof", "Ljava/io/EOFException;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bodyParser", "Ljdk/internal/net/http/ResponseContent$BodyParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_IGNORE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "readProgress", "Ljdk/internal/net/http/Http1Response$State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "responseCount", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "id", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hd", "Ljdk/internal/net/http/Http1HeaderParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dbgTag", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "firstTimeAround", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "finished", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOP", "Ljava/util/concurrent/Flow$Subscription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Http1Response", "(Ljdk/internal/net/http/HttpConnection;Ljdk/internal/net/http/Http1Exchange;Ljdk/internal/net/http/Http1AsyncReceiver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "receiver", "(Ljdk/internal/net/http/Http1Response$State;)Ljdk/internal/net/http/Http1Response$Receiver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "advance", "(Ljdk/internal/net/http/Http1Response$State;)Ljdk/internal/net/http/Http1Response$State;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "completed", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finished", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readHeadersAsync", "(Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onFinished", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixupContentLen", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onReadError", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dbgString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "responseCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "responseHeaders", "()Ljava/net/http/HttpHeaders;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readBody", "(Ljava/net/http/HttpResponse$BodySubscriber;ZLjava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ignoreBody", "(Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nullBody", "(Ljava/net/http/HttpResponse;Ljava/lang/Throwable;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent;", "private volatile")]
	public Dova.JDK.jdk.@internal.net.http.ResponseContent content_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpRequestImpl;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.HttpRequestImpl request_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestImpl>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Response;", "private")]
	public Dova.JDK.jdk.@internal.net.http.Response response_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Response>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpConnection;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.HttpConnection connection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpConnection>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/net/http/HttpHeaders;", "private")]
	public Dova.JDK.java.net.http.HttpHeaders headers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int responseCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Exchange;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.Http1Exchange exchange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Exchange>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool return2Cache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$HeadersReader;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.Http1Response.HeadersReader headersReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.HeadersReader>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$BodyReader;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.Http1Response.BodyReader bodyReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.BodyReader>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1AsyncReceiver;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver asyncReceiver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/EOFException;", "private volatile")]
	public Dova.JDK.java.io.EOFException eof_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.EOFException>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$BodyParser;", "private volatile")]
	public Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser bodyParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_IGNORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$State;", "private volatile")]
	public Dova.JDK.jdk.@internal.net.http.Http1Response.State readProgress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.State>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/Logger;", "final")]
	public Dova.JDK.jdk.@internal.net.http.common.Logger debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicLong responseCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "final")]
	public long id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[17], value);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1HeaderParser;", "private")]
	public Dova.JDK.jdk.@internal.net.http.Http1HeaderParser hd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1HeaderParser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String dbgTag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool firstTimeAround_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool finished_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "static final")]
	public static Dova.JDK.java.util.concurrent.Flow.Subscription NOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscription>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[23], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Http1Response(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpConnection;Ljdk/internal/net/http/Http1Exchange;Ljdk/internal/net/http/Http1AsyncReceiver;)V", "")]
	public Http1Response(Dova.JDK.jdk.@internal.net.http.HttpConnection arg0, Dova.JDK.jdk.@internal.net.http.Http1Exchange arg1, Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1Response;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/net/http/Http1Response$State;)Ljdk/internal/net/http/Http1Response$Receiver;", "")]
	public Dova.JDK.jdk.@internal.net.http.Http1Response.Receiver receiver(Dova.JDK.jdk.@internal.net.http.Http1Response.State arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.Receiver>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Http1Response$State;)Ljdk/internal/net/http/Http1Response$State;", "private")]
	public Dova.JDK.jdk.@internal.net.http.Http1Response.State advance(Dova.JDK.jdk.@internal.net.http.Http1Response.State arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.State>(ret);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void completed()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Z", "synchronized")]
	public bool finished()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture readHeadersAsync(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void onFinished()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(J)J", "")]
	public long fixupContentLen(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "")]
	public void onReadError(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String dbgString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int responseCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "")]
	public Dova.JDK.java.net.http.HttpHeaders responseHeaders()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodySubscriber;ZLjava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture readBody(Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg0, bool arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture ignoreBody(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse;Ljava/lang/Throwable;)V", "public")]
	public void nullBody(Dova.JDK.java.net.http.HttpResponse arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$State;", "static final")]
	public partial class State
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static State()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1Response$State;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL", "Ljdk/internal/net/http/Http1Response$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "READING_HEADERS", "Ljdk/internal/net/http/Http1Response$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "READING_BODY", "Ljdk/internal/net/http/Http1Response$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DONE", "Ljdk/internal/net/http/Http1Response$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljdk/internal/net/http/Http1Response$State;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "State", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljdk/internal/net/http/Http1Response$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/net/http/Http1Response$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljdk/internal/net/http/Http1Response$State;"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.Http1Response.State INITIAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.State>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.Http1Response.State READING_HEADERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.State>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.Http1Response.State READING_BODY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.State>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.Http1Response.State DONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.State>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljdk/internal/net/http/Http1Response$State;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.Http1Response.State> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.Http1Response.State>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public State(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public State(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1Response$State;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/net/http/Http1Response$State;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.Http1Response.State> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.Http1Response.State>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/net/http/Http1Response$State;", "public static")]
		public static Dova.JDK.jdk.@internal.net.http.Http1Response.State valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response.State>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/Http1Response$State;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.Http1Response.State> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.Http1Response.State>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$HeadersReader;", "final")]
	public partial class HeadersReader
		: Dova.JDK.jdk.@internal.net.http.Http1Response.Receiver
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HeadersReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1Response$HeadersReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "onComplete", "Ljava/util/function/Consumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parser", "Ljdk/internal/net/http/Http1HeaderParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cf", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "count", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "subscription", "Ljdk/internal/net/http/AbstractSubscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljdk/internal/net/http/Http1Response;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HeadersReader", "(Ljdk/internal/net/http/Http1Response;Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljdk/internal/net/http/Http1HeaderParser;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handle", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handle", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/Http1HeaderParser;Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "completion", "()Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onReadError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tryAsyncReceive", "(Ljava/nio/ByteBuffer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subscription", "()Ljdk/internal/net/http/AbstractSubscription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onSubscribe", "(Ljdk/internal/net/http/AbstractSubscription;)V"));
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "final")]
		public Dova.JDK.java.util.function.Consumer onComplete_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1HeaderParser;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.Http1HeaderParser parser_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1HeaderParser>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "volatile")]
		public Dova.JDK.java.util.concurrent.CompletableFuture cf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("J", "volatile")]
		public long count_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/AbstractSubscription;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.AbstractSubscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response;", "final")]
		public Dova.JDK.jdk.@internal.net.http.Http1Response this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HeadersReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/Http1Response;Ljava/util/function/Consumer;)V", "")]
		public HeadersReader(Dova.JDK.jdk.@internal.net.http.Http1Response arg0, Dova.JDK.java.util.function.Consumer arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1Response$HeadersReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "volatile")]
		public void start(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/Http1HeaderParser;)V", "final")]
		public void start(Dova.JDK.jdk.@internal.net.http.Http1HeaderParser arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void close(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/concurrent/CompletableFuture;)V", "volatile")]
		public void handle(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/Http1HeaderParser;Ljava/util/concurrent/CompletableFuture;)V", "final")]
		public void handle(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.Http1HeaderParser arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture completion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public final")]
		public void onReadError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Z", "public final")]
		public bool tryAsyncReceive(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/AbstractSubscription;", "public")]
		public Dova.JDK.jdk.@internal.net.http.AbstractSubscription subscription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/AbstractSubscription;)V", "public")]
		public void onSubscribe(Dova.JDK.jdk.@internal.net.http.AbstractSubscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$BodyReader;", "final")]
	public partial class BodyReader
		: Dova.JDK.jdk.@internal.net.http.Http1Response.Receiver
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodyReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1Response$BodyReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "onComplete", "Ljava/util/function/Consumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parser", "Ljdk/internal/net/http/ResponseContent$BodyParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cf", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "subscription", "Ljdk/internal/net/http/AbstractSubscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljdk/internal/net/http/Http1Response;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BodyReader", "(Ljdk/internal/net/http/Http1Response;Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljdk/internal/net/http/ResponseContent$BodyParser;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handle", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/ResponseContent$BodyParser;Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handle", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "completion", "()Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onReadError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onComplete", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tryAsyncReceive", "(Ljava/nio/ByteBuffer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subscription", "()Ljdk/internal/net/http/AbstractSubscription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onSubscribe", "(Ljdk/internal/net/http/AbstractSubscription;)V"));
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "final")]
		public Dova.JDK.java.util.function.Consumer onComplete_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$BodyParser;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser parser_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "volatile")]
		public Dova.JDK.java.util.concurrent.CompletableFuture cf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/AbstractSubscription;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.AbstractSubscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response;", "final")]
		public Dova.JDK.jdk.@internal.net.http.Http1Response this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BodyReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/Http1Response;Ljava/util/function/Consumer;)V", "")]
		public BodyReader(Dova.JDK.jdk.@internal.net.http.Http1Response arg0, Dova.JDK.java.util.function.Consumer arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1Response$BodyReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/ResponseContent$BodyParser;)V", "final")]
		public void start(Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "volatile")]
		public void start(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public final")]
		public void close(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/ResponseContent$BodyParser;Ljava/util/concurrent/CompletableFuture;)V", "final")]
		public void handle(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/concurrent/CompletableFuture;)V", "volatile")]
		public void handle(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture completion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public final")]
		public void onReadError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "final")]
		public void onComplete(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Z", "public final")]
		public bool tryAsyncReceive(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/AbstractSubscription;", "public")]
		public Dova.JDK.jdk.@internal.net.http.AbstractSubscription subscription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/AbstractSubscription;)V", "public")]
		public void onSubscribe(Dova.JDK.jdk.@internal.net.http.AbstractSubscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$Http1BodySubscriber;", "static final")]
	public partial class Http1BodySubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Http1BodySubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1Response$Http1BodySubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "userSubscriber", "Ljava/net/http/HttpResponse$BodySubscriber;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "completed", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "withError", "Ljava/lang/Throwable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "subscribed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Http1BodySubscriber", "(Ljava/net/http/HttpResponse$BodySubscriber;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "complete", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "needsExecutor", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "propagateError", "(Ljava/lang/Throwable;)V"));
		}

		[JniSignatureAttribute("Ljava/net/http/HttpResponse$BodySubscriber;", "final")]
		public Dova.JDK.java.net.http.HttpResponse.BodySubscriber userSubscriber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean completed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Throwable;", "volatile")]
		public Dova.JDK.java.lang.Throwable withError_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "volatile")]
		public bool subscribed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Http1BodySubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodySubscriber;)V", "")]
		public Http1BodySubscriber(Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1Response$Http1BodySubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "private")]
		public void complete(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void onNext(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void onNext(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void onError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void onComplete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
		public Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool needsExecutor()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "private")]
		public void propagateError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$ClientRefCountTracker;", "private final")]
	public partial class ClientRefCountTracker
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClientRefCountTracker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1Response$ClientRefCountTracker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "client", "Ljdk/internal/net/http/HttpClientImpl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "state", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljdk/internal/net/http/Http1Response;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ClientRefCountTracker", "(Ljdk/internal/net/http/Http1Response;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "acquire", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tryRelease", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/HttpClientImpl;", "final")]
		public Dova.JDK.jdk.@internal.net.http.HttpClientImpl client_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientImpl>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("B", "")]
		public byte state_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response;", "final")]
		public Dova.JDK.jdk.@internal.net.http.Http1Response this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Response>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClientRefCountTracker(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/Http1Response;)V", "private")]
		public ClientRefCountTracker(Dova.JDK.jdk.@internal.net.http.Http1Response arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1Response$ClientRefCountTracker;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public synchronized")]
		public void acquire()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public synchronized")]
		public void tryRelease()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Response$Receiver;", "abstract static")]
	public partial class Receiver
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver.Http1AsyncDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Receiver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1Response$Receiver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Receiver", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accept", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/concurrent/CompletableFuture;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handle", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "completion", "()Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onReadError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tryAsyncReceive", "(Ljava/nio/ByteBuffer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subscription", "()Ljdk/internal/net/http/AbstractSubscription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onSubscribe", "(Ljdk/internal/net/http/AbstractSubscription;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Receiver(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Receiver() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1Response$Receiver;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "abstract")]
		public void start(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/concurrent/CompletableFuture;)Z", "final")]
		public bool accept(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/concurrent/CompletableFuture;)V", "abstract")]
		public void handle(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "abstract")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "abstract")]
		public Dova.JDK.java.util.concurrent.CompletableFuture completion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public abstract")]
		public void onReadError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Z", "public abstract")]
		public bool tryAsyncReceive(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/AbstractSubscription;", "public abstract")]
		public Dova.JDK.jdk.@internal.net.http.AbstractSubscription subscription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/AbstractSubscription;)V", "public abstract")]
		public void onSubscribe(Dova.JDK.jdk.@internal.net.http.AbstractSubscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}
}
