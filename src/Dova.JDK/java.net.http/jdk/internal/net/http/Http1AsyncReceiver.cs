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

[JniSignatureAttribute("Ljdk/internal/net/http/Http1AsyncReceiver;", "")]
public partial class Http1AsyncReceiver
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Http1AsyncReceiver()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1AsyncReceiver;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "queue", "Ljava/util/concurrent/ConcurrentLinkedDeque;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scheduler", "Ljdk/internal/net/http/common/SequentialScheduler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "whenFinished", "Ljdk/internal/net/http/common/MinimalFuture;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/Executor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscriber", "Ljdk/internal/net/http/Http1AsyncReceiver$Http1TubeSubscriber;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pendingDelegateRef", "Ljava/util/concurrent/atomic/AtomicReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "received", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canRequestMore", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "error", "Ljava/lang/Throwable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owner", "Ljdk/internal/net/http/Http1Exchange;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "client", "Ljdk/internal/net/http/HttpClientImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retry", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stopRequested", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dbgTag", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljdk/internal/net/http/Http1Exchange;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remaining", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subscriber", "()Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasDemand", "(Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkForErrors", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkRequestMore", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onReadError", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debugQBB", "([Ljava/nio/ByteBuffer;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handlePendingDelegate", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dbgString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subscribe", "(Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsubscribe", "(Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asyncReceive", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRetryOnError", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describe", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drain", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;"));
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

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedDeque;", "private final")]
	public Dova.JDK.java.util.concurrent.ConcurrentLinkedDeque queue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedDeque>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler scheduler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/MinimalFuture;", "final")]
	public Dova.JDK.jdk.@internal.net.http.common.MinimalFuture whenFinished_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.MinimalFuture>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "private final")]
	public Dova.JDK.java.util.concurrent.Executor executor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1AsyncReceiver$Http1TubeSubscriber;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver.Http1TubeSubscriber subscriber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver.Http1TubeSubscriber>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReference;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicReference pendingDelegateRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicLong received_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean canRequestMore_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Throwable;", "private volatile")]
	public Dova.JDK.java.lang.Throwable error_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;", "private volatile")]
	public Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver.Http1AsyncDelegate @delegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver.Http1AsyncDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1Exchange;", "private volatile")]
	public Dova.JDK.jdk.@internal.net.http.Http1Exchange owner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1Exchange>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpClientImpl;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.HttpClientImpl client_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool retry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool stopRequested_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "volatile")]
	public Dova.JDK.java.lang.String dbgTag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Http1AsyncReceiver(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljdk/internal/net/http/Http1Exchange;)V", "public")]
	public Http1AsyncReceiver(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.jdk.@internal.net.http.Http1Exchange arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1AsyncReceiver;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void flush()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()J", "")]
	public long remaining()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void stop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;", "")]
	public Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber subscriber()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;)Z", "private")]
	public bool hasDemand(Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver.Http1AsyncDelegate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkForErrors()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkRequestMore()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "")]
	public void onReadError(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String debugQBB(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool handlePendingDelegate()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String dbgString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;)V", "")]
	public void subscribe(Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver.Http1AsyncDelegate arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;)V", "")]
	public void unsubscribe(Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver.Http1AsyncDelegate arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "private")]
	public void asyncReceive(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Z)V", "synchronized")]
	public void setRetryOnError(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String describe()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "")]
	public Dova.JDK.java.nio.ByteBuffer drain(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1AsyncReceiver$Http1TubeSubscriber;", "final")]
	public partial class Http1TubeSubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Http1TubeSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1AsyncReceiver$Http1TubeSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljava/util/concurrent/Flow$Subscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dropped", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/net/http/Http1AsyncReceiver;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/Http1AsyncReceiver;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestMore", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropSubscription", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "volatile")]
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

		[JniSignatureAttribute("Z", "volatile")]
		public bool completed_Property
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

		[JniSignatureAttribute("Z", "volatile")]
		public bool dropped_Property
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

		[JniSignatureAttribute("Ljdk/internal/net/http/Http1AsyncReceiver;", "final")]
		public Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Http1TubeSubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/Http1AsyncReceiver;)V", "")]
		public Http1TubeSubscriber(Dova.JDK.jdk.@internal.net.http.Http1AsyncReceiver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1AsyncReceiver$Http1TubeSubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "")]
		public void requestMore()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void dropSubscription()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
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
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;", "abstract static interface")]
	public partial interface Http1AsyncDelegate
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Http1AsyncDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAsyncReceive", "(Ljava/nio/ByteBuffer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onReadError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subscription", "()Ljdk/internal/net/http/AbstractSubscription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljdk/internal/net/http/AbstractSubscription;)V"));
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public abstract")]
		void close(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Z", "public abstract")]
		bool tryAsyncReceive(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public abstract")]
		void onReadError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/AbstractSubscription;", "public abstract")]
		Dova.JDK.jdk.@internal.net.http.AbstractSubscription subscription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/AbstractSubscription;)V", "public abstract")]
		void onSubscribe(Dova.JDK.jdk.@internal.net.http.AbstractSubscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegateSubscription;", "private static final")]
	public partial class Http1AsyncDelegateSubscription
		: Dova.JDK.jdk.@internal.net.http.AbstractSubscription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Http1AsyncDelegateSubscription()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegateSubscription;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onCancel", "Ljava/lang/Runnable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onError", "Ljava/util/function/Consumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scheduler", "Ljdk/internal/net/http/common/SequentialScheduler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cancelled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/common/SequentialScheduler;Ljava/lang/Runnable;Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "(J)V"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
		public Dova.JDK.java.lang.Runnable onCancel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "private final")]
		public Dova.JDK.java.util.function.Consumer onError_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler scheduler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private volatile")]
		public bool cancelled_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Http1AsyncDelegateSubscription(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/common/SequentialScheduler;Ljava/lang/Runnable;Ljava/util/function/Consumer;)V", "")]
		public Http1AsyncDelegateSubscription(Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.function.Consumer arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/Http1AsyncReceiver$Http1AsyncDelegateSubscription;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void cancel()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void request(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
