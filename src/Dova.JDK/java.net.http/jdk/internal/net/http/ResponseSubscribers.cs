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

[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers;", "public")]
public partial class ResponseSubscribers
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ResponseSubscribers()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBodyAsync", "(Ljava/util/concurrent/Executor;Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBodyAsync", "(Ljava/util/concurrent/Executor;Ljava/net/http/HttpResponse$BodySubscriber;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBodyAsync", "(Ljava/util/concurrent/Executor;Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLineStream", "(Ljava/nio/charset/Charset;)Ljava/net/http/HttpResponse$BodySubscriber;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLineStream", "()Ljava/net/http/HttpResponse$BodySubscriber;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createPublisher", "()Ljava/net/http/HttpResponse$BodySubscriber;"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ResponseSubscribers(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ResponseSubscribers() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture getBodyAsync(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/net/http/HttpResponse$BodySubscriber;)Ljava/util/concurrent/CompletionStage;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletionStage getBodyAsync(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture getBodyAsync(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.function.Consumer arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
	public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber createLineStream(Dova.JDK.java.nio.charset.Charset arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
	public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber createLineStream()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
	public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber createPublisher()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$HttpResponseInputStream;", "public static")]
	public partial class HttpResponseInputStream
		: Dova.JDK.java.io.InputStream
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HttpResponseInputStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$HttpResponseInputStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_BUFFERS_IN_QUEUE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAST_BUFFER", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAST_LIST", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffers", "Ljava/util/concurrent/BlockingQueue;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljava/util/concurrent/Flow$Subscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "failed", "Ljava/lang/Throwable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentListItr", "Ljava/util/Iterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentBuffer", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribed", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "current", "()Ljava/nio/ByteBuffer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "available", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MAX_BUFFERS_IN_QUEUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "private static final")]
		public static Dova.JDK.java.nio.ByteBuffer LAST_BUFFER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private static final")]
		public static Dova.JDK.java.util.List LAST_LIST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/Logger;", "private static final")]
		public static Dova.JDK.jdk.@internal.net.http.common.Logger debug_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/BlockingQueue;", "private final")]
		public Dova.JDK.java.util.concurrent.BlockingQueue buffers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.BlockingQueue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "private volatile")]
		public Dova.JDK.java.util.concurrent.Flow.Subscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private volatile")]
		public bool closed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Throwable;", "private volatile")]
		public Dova.JDK.java.lang.Throwable failed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Iterator;", "private volatile")]
		public Dova.JDK.java.util.Iterator currentListItr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "private volatile")]
		public Dova.JDK.java.nio.ByteBuffer currentBuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean subscribed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HttpResponseInputStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public HttpResponseInputStream() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public HttpResponseInputStream(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$HttpResponseInputStream;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/nio/ByteBuffer;", "private")]
		public Dova.JDK.java.nio.ByteBuffer current()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int read()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("([BII)I", "public")]
		public int read(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int available()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void onNext(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void onNext(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void onError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void onComplete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
		public Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$MappingSubscriber;", "public static")]
	public partial class MappingSubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MappingSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$MappingSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upstream", "Ljava/net/http/HttpResponse$BodySubscriber;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mapper", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trusted", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/function/Function;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/function/Function;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsExecutor", "()Z"));
		}

		[JniSignatureAttribute("Ljava/net/http/HttpResponse$BodySubscriber;", "private final")]
		public Dova.JDK.java.net.http.HttpResponse.BodySubscriber upstream_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
		public Dova.JDK.java.util.function.Function mapper_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool trusted_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MappingSubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/function/Function;)V", "public")]
		public MappingSubscriber(Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg0, Dova.JDK.java.util.function.Function arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/function/Function;Z)V", "")]
		public MappingSubscriber(Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg0, Dova.JDK.java.util.function.Function arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$MappingSubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void onNext(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void onNext(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void onError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void onComplete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
		public Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool needsExecutor()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber;", "static")]
	public partial class PublishingBodySubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PublishingBodySubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscriptionCF", "Ljdk/internal/net/http/common/MinimalFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribedCF", "Ljdk/internal/net/http/common/MinimalFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscriberRef", "Ljava/util/concurrent/atomic/AtomicReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/util/concurrent/CompletionStage;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completionCF", "Ljdk/internal/net/http/common/MinimalFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribed", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suppress", "(ZLjava/lang/String;Ljava/lang/Throwable;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subscribe", "(Ljava/util/concurrent/Flow$Subscriber;)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/MinimalFuture;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.common.MinimalFuture subscriptionCF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.MinimalFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/MinimalFuture;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.common.MinimalFuture subscribedCF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.MinimalFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReference;", "private")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicReference subscriberRef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletionStage;", "private final")]
		public Dova.JDK.java.util.concurrent.CompletionStage body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/MinimalFuture;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.common.MinimalFuture completionCF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.MinimalFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean subscribed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PublishingBodySubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PublishingBodySubscriber() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;Ljava/lang/Throwable;)V", "private")]
		public void complete(Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.PublishingBodySubscriber.SubscriberRef arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
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

		[JniSignatureAttribute("(ZLjava/lang/String;Ljava/lang/Throwable;)Z", "private")]
		public bool suppress(bool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Throwable arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void signalComplete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "private")]
		public void signalError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
		public Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)V", "private")]
		public void subscribe(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;", "static final")]
		public partial class SubscriberRef
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SubscriberRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ref", "Ljava/util/concurrent/Flow$Subscriber;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Flow$Subscriber;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "()Ljava/util/concurrent/Flow$Subscriber;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()Ljava/util/concurrent/Flow$Subscriber;"));
			}

			[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscriber;", "volatile")]
			public Dova.JDK.java.util.concurrent.Flow.Subscriber @ref_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscriber>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SubscriberRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)V", "")]
			public SubscriberRef(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/concurrent/Flow$Subscriber;", "")]
			public Dova.JDK.java.util.concurrent.Flow.Subscriber get()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscriber>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/concurrent/Flow$Subscriber;", "")]
			public Dova.JDK.java.util.concurrent.Flow.Subscriber clear()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscriber>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriptionRef;", "static final")]
		public partial class SubscriptionRef
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.concurrent.Flow.Subscription
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SubscriptionRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriptionRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljava/util/concurrent/Flow$Subscription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscriberRef", "Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Flow$Subscription;Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "(J)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subscribe", "()V"));
			}

			[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "final")]
			public Dova.JDK.java.util.concurrent.Flow.Subscription subscription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;", "final")]
			public Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.PublishingBodySubscriber.SubscriberRef subscriberRef_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.PublishingBodySubscriber.SubscriberRef>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SubscriptionRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriberRef;)V", "")]
			public SubscriptionRef(Dova.JDK.java.util.concurrent.Flow.Subscription arg0, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.PublishingBodySubscriber.SubscriberRef arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$PublishingBodySubscriber$SubscriptionRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void cancel()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("(J)V", "public")]
			public void request(long arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("()V", "")]
			public void subscribe()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$TrustedSubscriber;", "public abstract static interface")]
	public partial interface TrustedSubscriber
		: IJavaObject
		, Dova.JDK.java.net.http.HttpResponse.BodySubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TrustedSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$TrustedSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsExecutor", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "needsExecutor", "(Ljava/net/http/HttpResponse$BodySubscriber;)Z"));
		}

		[JniSignatureAttribute("()Z", "public")]
		bool needsExecutor()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodySubscriber;)Z", "public static")]
		static bool needsExecutor(Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$SubscriberAdapter;", "public static final")]
	public partial class SubscriberAdapter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SubscriberAdapter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$SubscriberAdapter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cf", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscriber", "Ljava/util/concurrent/Flow$Subscriber;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finisher", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljava/util/concurrent/Flow$Subscription;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "private final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture cf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscriber;", "private final")]
		public Dova.JDK.java.lang.Object subscriber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
		public Dova.JDK.java.util.function.Function finisher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "private volatile")]
		public Dova.JDK.java.util.concurrent.Flow.Subscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SubscriberAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;)V", "public")]
		public SubscriberAdapter(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Function arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$SubscriberAdapter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void onNext(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void onNext(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void onError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void onComplete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
		public Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$NullSubscriber;", "public static")]
	public partial class NullSubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NullSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$NullSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cf", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Ljava/util/Optional;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribed", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Optional;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "private final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture cf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Optional;", "private final")]
		public Dova.JDK.java.util.Optional result_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean subscribed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NullSubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Optional;)V", "public")]
		public NullSubscriber(Dova.JDK.java.util.Optional arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$NullSubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void onNext(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void onNext(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void onError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void onComplete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
		public Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$ByteArraySubscriber;", "public static")]
	public partial class ByteArraySubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ByteArraySubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$ByteArraySubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finisher", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "received", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljava/util/concurrent/Flow$Subscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Function;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "join", "(Ljava/util/List;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
		public Dova.JDK.java.util.function.Function finisher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "private final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture result_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List received_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "private volatile")]
		public Dova.JDK.java.util.concurrent.Flow.Subscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ByteArraySubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)V", "public")]
		public ByteArraySubscriber(Dova.JDK.java.util.function.Function arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$ByteArraySubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;)[B", "private static")]
		public static JavaArray<byte> join(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
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
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$PathSubscriber;", "public static")]
	public partial class PathSubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PathSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$PathSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_FILE_PERMISSIONS", "[Ljava/io/FilePermission;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "[Ljava/nio/file/OpenOption;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filePermissions", "[Ljava/io/FilePermission;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isDefaultFS", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribed", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljava/util/concurrent/Flow$Subscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "out", "Ljava/nio/channels/FileChannel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;Ljava/util/List;Ljava/security/AccessControlContext;[Ljava/io/FilePermission;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/nio/file/Path;Ljava/util/List;)Ljdk/internal/net/http/ResponseSubscribers$PathSubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDefaultFS", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pathForSecurityCheck", "(Ljava/nio/file/Path;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("[Ljava/io/FilePermission;", "private static final")]
		public static JavaArray<Dova.JDK.java.io.FilePermission> EMPTY_FILE_PERMISSIONS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.FilePermission>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path file_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/nio/file/OpenOption;", "private final")]
		public JavaArray<Dova.JDK.java.nio.file.OpenOption> options_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.OpenOption>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private final")]
		public Dova.JDK.java.security.AccessControlContext acc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/io/FilePermission;", "private final")]
		public JavaArray<Dova.JDK.java.io.FilePermission> filePermissions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.FilePermission>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isDefaultFS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "private final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture result_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean subscribed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "private volatile")]
		public Dova.JDK.java.util.concurrent.Flow.Subscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/channels/FileChannel;", "private volatile")]
		public Dova.JDK.java.nio.channels.FileChannel @out_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.FileChannel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PathSubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/util/List;Ljava/security/AccessControlContext;[Ljava/io/FilePermission;)V", "transient")]
		public PathSubscriber(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.security.AccessControlContext arg2, JavaArray<Dova.JDK.java.io.FilePermission> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$PathSubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "private")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/util/List;)Ljdk/internal/net/http/ResponseSubscribers$PathSubscriber;", "public static")]
		public static Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.PathSubscriber create(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.PathSubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "private static")]
		public static bool isDefaultFS(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void onNext(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void onNext(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void onError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void onComplete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
		public Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String pathForSecurityCheck(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseSubscribers$ConsumerSubscriber;", "public static")]
	public partial class ConsumerSubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseSubscribers.TrustedSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConsumerSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseSubscribers$ConsumerSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "consumer", "Ljava/util/function/Consumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljava/util/concurrent/Flow$Subscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribed", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "private final")]
		public Dova.JDK.java.util.function.Consumer consumer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "private")]
		public Dova.JDK.java.util.concurrent.Flow.Subscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Subscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "private final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture result_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean subscribed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConsumerSubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public ConsumerSubscriber(Dova.JDK.java.util.function.Consumer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseSubscribers$ConsumerSubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void onNext(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void onNext(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void onError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void onComplete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
		public Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}
	}
}
