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

[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube;", "final")]
public partial class SocketTube
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.net.http.common.FlowTube
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SocketTube()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDS", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "client", "Ljdk/internal/net/http/HttpClientImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "channel", "Ljava/nio/channels/SocketChannel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sliceBuffersSource", "Ljdk/internal/net/http/SocketTube$SliceBufferSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorRef", "Ljava/util/concurrent/atomic/AtomicReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readPublisher", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeSubscriber", "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "id", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_BUFFERS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EOF", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOTHING", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/HttpClientImpl;Ljava/nio/channels/SocketChannel;Ljava/util/function/Supplier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinished", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dbgString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connectFlows", "(Ljdk/internal/net/http/common/FlowTube$TubePublisher;Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalClosed", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debugState", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAvailable", "(Ljdk/internal/net/http/SocketTube$BufferSource;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "listOf", "(Ljava/util/List;Ljava/lang/Object;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeAvailable", "(Ljava/util/List;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeEvent", "(Ljdk/internal/net/http/SocketTube$SocketFlowEvent;Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pauseEvent", "(Ljdk/internal/net/http/SocketTube$SocketFlowEvent;Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "channelDescr", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subscribe", "(Ljava/util/concurrent/Flow$Subscriber;)V"));
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

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicLong IDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/HttpClientImpl;", "private final")]
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

	[JniSignatureAttribute("Ljava/nio/channels/SocketChannel;", "private final")]
	public Dova.JDK.java.nio.channels.SocketChannel channel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SocketChannel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$SliceBufferSource;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.SocketTube.SliceBufferSource sliceBuffersSource_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.SliceBufferSource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object @lock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReference;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicReference errorRef_Property
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

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher readPublisher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber writeSubscriber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private final")]
	public long id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_BUFFERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "static final")]
	public static Dova.JDK.java.util.List EOF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "static final")]
	public static Dova.JDK.java.util.List NOTHING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SocketTube(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpClientImpl;Ljava/nio/channels/SocketChannel;Ljava/util/function/Supplier;)V", "public")]
	public SocketTube(Dova.JDK.jdk.@internal.net.http.HttpClientImpl arg0, Dova.JDK.java.nio.channels.SocketChannel arg1, Dova.JDK.java.util.function.Supplier arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
	public void onNext(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
	public void onNext(Dova.JDK.java.lang.Object arg0)
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

	[JniSignatureAttribute("()Z", "public")]
	public bool isFinished()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String dbgString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
	public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/common/FlowTube$TubePublisher;Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;)V", "public")]
	public void connectFlows(Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubePublisher arg0, Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void signalClosed()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void debugState(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube$BufferSource;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List readAvailable(Dova.JDK.jdk.@internal.net.http.SocketTube.BufferSource arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/Object;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List listOf(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)J", "private")]
	public long writeAvailable(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube$SocketFlowEvent;Ljava/util/function/Consumer;)V", "private")]
	public void resumeEvent(Dova.JDK.jdk.@internal.net.http.SocketTube.SocketFlowEvent arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube$SocketFlowEvent;Ljava/util/function/Consumer;)V", "private")]
	public void pauseEvent(Dova.JDK.jdk.@internal.net.http.SocketTube.SocketFlowEvent arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String channelDescr()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)V", "public")]
	public void subscribe(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$SliceBufferSource;", "private static final")]
	public partial class SliceBufferSource
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.SocketTube.BufferSource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SliceBufferSource()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$SliceBufferSource;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "factory", "Ljava/util/function/Supplier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Supplier;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/util/List;Ljava/nio/ByteBuffer;I)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuffer", "()Ljava/nio/ByteBuffer;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Supplier;", "private final")]
		public Dova.JDK.java.util.function.Supplier factory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "private volatile")]
		public Dova.JDK.java.nio.ByteBuffer current_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SliceBufferSource(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SliceBufferSource() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;)V", "public")]
		public SliceBufferSource(Dova.JDK.java.util.function.Supplier arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$SliceBufferSource;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;Ljava/nio/ByteBuffer;I)Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List append(Dova.JDK.java.util.List arg0, Dova.JDK.java.nio.ByteBuffer arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/ByteBuffer;", "public final")]
		public Dova.JDK.java.nio.ByteBuffer getBuffer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher;", "private final")]
	public partial class InternalReadPublisher
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.Flow.Publisher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InternalReadPublisher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$InternalReadPublisher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscriptionImpl", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pendingSubscription", "Ljava/util/concurrent/atomic/AtomicReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadSubscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/net/http/SocketTube;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/SocketTube;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subscribe", "(Ljava/util/concurrent/Flow$Subscriber;)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.InternalReadSubscription subscriptionImpl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.InternalReadSubscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReference;", "")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicReference pendingSubscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadSubscription;", "private volatile")]
		public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.ReadSubscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.ReadSubscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube;", "final")]
		public Dova.JDK.jdk.@internal.net.http.SocketTube this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InternalReadPublisher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube;)V", "private")]
		public InternalReadPublisher(Dova.JDK.jdk.@internal.net.http.SocketTube arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$InternalReadPublisher;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "")]
		public void signalError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)V", "public")]
		public void subscribe(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;", "final")]
		public partial class InternalReadSubscription
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.concurrent.Flow.Subscription
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InternalReadSubscription()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "demand", "Ljdk/internal/net/http/common/Demand;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readScheduler", "Ljdk/internal/net/http/common/SequentialScheduler;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completed", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readEvent", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadEvent;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribeEvent", "Ljdk/internal/net/http/AsyncEvent;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/SocketTube$InternalReadPublisher;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "(J)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalSubscribe", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handlePending", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalError", "(Ljava/lang/Throwable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeReadEvent", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pauseReadEvent", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleSubscribeEvent", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalReadable", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleError", "()V"));
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/common/Demand;", "private final")]
			public Dova.JDK.jdk.@internal.net.http.common.Demand demand_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Demand>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler;", "final")]
			public Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler readScheduler_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private volatile")]
			public bool completed_Property
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

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadEvent;", "private final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.ReadEvent readEvent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.ReadEvent>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/AsyncEvent;", "private final")]
			public Dova.JDK.jdk.@internal.net.http.AsyncEvent subscribeEvent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AsyncEvent>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "static final")]
			public static bool assertionsDisabled_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InternalReadSubscription(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube$InternalReadPublisher;)V", "")]
			public InternalReadSubscription(Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "final")]
			public void read()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("()V", "public final")]
			public void cancel()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("(J)V", "public final")]
			public void request(long arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("()V", "final")]
			public void signalSubscribe()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
			}

			[JniSignatureAttribute("()Z", "")]
			public bool handlePending()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "final")]
			public void signalError(Dova.JDK.java.lang.Throwable arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("()V", "private")]
			public void resumeReadEvent()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
			}

			[JniSignatureAttribute("()V", "private")]
			public void pauseReadEvent()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
			}

			[JniSignatureAttribute("()V", "final")]
			public void handleSubscribeEvent()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
			}

			[JniSignatureAttribute("()V", "final")]
			public void signalReadable()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
			}

			[JniSignatureAttribute("()V", "final")]
			public void handleError()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadSubscription;", "final")]
		public partial class ReadSubscription
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.concurrent.Flow.Subscription
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReadSubscription()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadSubscription;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "impl", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscriber", "Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorRef", "Ljava/util/concurrent/atomic/AtomicReference;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferSource", "Ljdk/internal/net/http/SocketTube$BufferSource;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribed", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cancelled", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completed", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/SocketTube$InternalReadPublisher;Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "(J)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalOnSubscribe", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalCompletion", "()V"));
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.InternalReadSubscription impl_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.InternalReadSubscription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;", "final")]
			public Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber subscriber_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReference;", "final")]
			public Dova.JDK.java.util.concurrent.atomic.AtomicReference errorRef_Property
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

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$BufferSource;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.BufferSource bufferSource_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.BufferSource>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "volatile")]
			public bool subscribed_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("Z", "volatile")]
			public bool cancelled_Property
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

			[JniSignatureAttribute("Z", "volatile")]
			public bool completed_Property
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

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReadSubscription(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube$InternalReadPublisher;Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;)V", "public")]
			public ReadSubscription(Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher arg0, Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.InternalReadSubscription arg1, Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadSubscription;";
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

			[JniSignatureAttribute("()V", "")]
			public void signalOnSubscribe()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("()V", "")]
			public void signalCompletion()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadEvent;", "final")]
		public partial class ReadEvent
			: Dova.JDK.jdk.@internal.net.http.SocketTube.SocketFlowEvent
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReadEvent()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadEvent;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sub", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljdk/internal/net/http/SocketTube$InternalReadPublisher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/SocketTube$InternalReadPublisher;Ljava/nio/channels/SocketChannel;Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "()Ljdk/internal/net/http/common/Logger;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalEvent", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalError", "(Ljava/lang/Throwable;)V"));
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.InternalReadSubscription sub_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.InternalReadSubscription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalReadPublisher;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReadEvent(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube$InternalReadPublisher;Ljava/nio/channels/SocketChannel;Ljdk/internal/net/http/SocketTube$InternalReadPublisher$InternalReadSubscription;)V", "")]
			public ReadEvent(Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher arg0, Dova.JDK.java.nio.channels.SocketChannel arg1, Dova.JDK.jdk.@internal.net.http.SocketTube.InternalReadPublisher.InternalReadSubscription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$InternalReadPublisher$ReadEvent;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljdk/internal/net/http/common/Logger;", "")]
			public Dova.JDK.jdk.@internal.net.http.common.Logger debug()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
			}

			[JniSignatureAttribute("()V", "protected final")]
			public void signalEvent()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "protected final")]
			public void signalError(Dova.JDK.java.lang.Throwable arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;", "private final")]
	public partial class InternalWriteSubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.Flow.Subscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InternalWriteSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscription", "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteSubscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startSubscription", "Ljdk/internal/net/http/AsyncTriggerEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeEvent", "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeDemand", "Ljdk/internal/net/http/common/Demand;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/net/http/SocketTube;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/SocketTube;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestMore", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startSubscription", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFlushCurrent", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeWriteEvent", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalWritable", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalError", "(Ljava/lang/Throwable;)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteSubscription;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber.WriteSubscription subscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber.WriteSubscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "volatile")]
		public Dova.JDK.java.util.List current_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "volatile")]
		public bool completed_Property
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

		[JniSignatureAttribute("Ljdk/internal/net/http/AsyncTriggerEvent;", "final")]
		public Dova.JDK.jdk.@internal.net.http.AsyncTriggerEvent startSubscription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AsyncTriggerEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteEvent;", "final")]
		public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber.WriteEvent writeEvent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber.WriteEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/Demand;", "final")]
		public Dova.JDK.jdk.@internal.net.http.common.Demand writeDemand_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Demand>(ret);
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

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube;", "final")]
		public Dova.JDK.jdk.@internal.net.http.SocketTube this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InternalWriteSubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube;)V", "private")]
		public InternalWriteSubscriber(Dova.JDK.jdk.@internal.net.http.SocketTube arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public void onNext(Dova.JDK.java.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void onNext(Dova.JDK.java.lang.Object arg0)
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

		[JniSignatureAttribute("()V", "")]
		public void requestMore()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
		public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void startSubscription()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(Z)V", "")]
		public void tryFlushCurrent(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Z)V", "")]
		public void resumeWriteEvent(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void signalWritable()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "")]
		public void signalError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteEvent;", "final")]
		public partial class WriteEvent
			: Dova.JDK.jdk.@internal.net.http.SocketTube.SocketFlowEvent
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static WriteEvent()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteEvent;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sub", "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;Ljava/nio/channels/SocketChannel;Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "()Ljdk/internal/net/http/common/Logger;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalEvent", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalError", "(Ljava/lang/Throwable;)V"));
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber sub_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public WriteEvent(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;Ljava/nio/channels/SocketChannel;Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;)V", "")]
			public WriteEvent(Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber arg0, Dova.JDK.java.nio.channels.SocketChannel arg1, Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteEvent;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljdk/internal/net/http/common/Logger;", "")]
			public Dova.JDK.jdk.@internal.net.http.common.Logger debug()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
			}

			[JniSignatureAttribute("()V", "protected final")]
			public void signalEvent()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "protected")]
			public void signalError(Dova.JDK.java.lang.Throwable arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteSubscription;", "final")]
		public partial class WriteSubscription
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.concurrent.Flow.Subscription
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static WriteSubscription()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteSubscription;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upstreamSubscription", "Ljava/util/concurrent/Flow$Subscription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cancelled", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;Ljava/util/concurrent/Flow$Subscription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "(J)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestMore", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropSubscription", "()V"));
			}

			[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscription;", "final")]
			public Dova.JDK.java.util.concurrent.Flow.Subscription upstreamSubscription_Property
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
			public bool cancelled_Property
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

			[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;", "final")]
			public Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public WriteSubscription(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber;Ljava/util/concurrent/Flow$Subscription;)V", "")]
			public WriteSubscription(Dova.JDK.jdk.@internal.net.http.SocketTube.InternalWriteSubscriber arg0, Dova.JDK.java.util.concurrent.Flow.Subscription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$InternalWriteSubscriber$WriteSubscription;";
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

			[JniSignatureAttribute("()V", "")]
			public void requestMore()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("()V", "")]
			public void dropSubscription()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$BufferSource;", "public abstract static interface")]
	public partial interface BufferSource
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BufferSource()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$BufferSource;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/util/List;Ljava/nio/ByteBuffer;I)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuffer", "()Ljava/nio/ByteBuffer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnUnused", "(Ljava/nio/ByteBuffer;)V"));
		}

		[JniSignatureAttribute("(Ljava/util/List;Ljava/nio/ByteBuffer;I)Ljava/util/List;", "public abstract")]
		Dova.JDK.java.util.List append(Dova.JDK.java.util.List arg0, Dova.JDK.java.nio.ByteBuffer arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/ByteBuffer;", "public abstract")]
		Dova.JDK.java.nio.ByteBuffer getBuffer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
		void returnUnused(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$SocketFlowEvent;", "private abstract static")]
	public partial class SocketFlowEvent
		: Dova.JDK.jdk.@internal.net.http.AsyncEvent
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SocketFlowEvent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$SocketFlowEvent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "channel", "Ljava/nio/channels/SocketChannel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultInterest", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interestOps", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registered", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/nio/channels/SocketChannel;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "()Ljdk/internal/net/http/common/Logger;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resume", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handle", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "channel", "()Ljava/nio/channels/SelectableChannel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abort", "(Ljava/io/IOException;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interestOps", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalEvent", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalError", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pause", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registered", "()Z"));
		}

		[JniSignatureAttribute("Ljava/nio/channels/SocketChannel;", "final")]
		public Dova.JDK.java.nio.channels.SocketChannel channel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SocketChannel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int defaultInterest_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "volatile")]
		public int interestOps_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "volatile")]
		public bool registered_Property
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
		public SocketFlowEvent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/nio/channels/SocketChannel;)V", "")]
		public SocketFlowEvent(int arg0, Dova.JDK.java.nio.channels.SocketChannel arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$SocketFlowEvent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/internal/net/http/common/Logger;", "abstract")]
		public Dova.JDK.jdk.@internal.net.http.common.Logger debug()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
		}

		[JniSignatureAttribute("()V", "final")]
		public void resume()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()V", "public final")]
		public void handle()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()Ljava/nio/channels/SelectableChannel;", "public final")]
		public Dova.JDK.java.nio.channels.SelectableChannel channel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SelectableChannel>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/IOException;)V", "public final")]
		public void abort(Dova.JDK.java.io.IOException arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()I", "public final")]
		public int interestOps()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()V", "protected abstract")]
		public void signalEvent()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "protected abstract")]
		public void signalError(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()V", "final")]
		public void pause()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool registered()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$SSLDirectBufferSource;", "private static final")]
	public partial class SSLDirectBufferSource
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.SocketTube.BufferSource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLDirectBufferSource()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$SSLDirectBufferSource;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "factory", "Ljdk/internal/net/http/common/BufferSupplier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "client", "Ljdk/internal/net/http/HttpClientImpl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/HttpClientImpl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/util/List;Ljava/nio/ByteBuffer;I)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuffer", "()Ljava/nio/ByteBuffer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnUnused", "(Ljava/nio/ByteBuffer;)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/BufferSupplier;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.common.BufferSupplier factory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.BufferSupplier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/HttpClientImpl;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.HttpClientImpl client_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpClientImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "private")]
		public Dova.JDK.java.nio.ByteBuffer current_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
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
		public SSLDirectBufferSource(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/HttpClientImpl;)V", "public")]
		public SSLDirectBufferSource(Dova.JDK.jdk.@internal.net.http.HttpClientImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$SSLDirectBufferSource;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;Ljava/nio/ByteBuffer;I)Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List append(Dova.JDK.java.util.List arg0, Dova.JDK.java.nio.ByteBuffer arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/ByteBuffer;", "public final")]
		public Dova.JDK.java.nio.ByteBuffer getBuffer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
		public void returnUnused(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/SocketTube$SocketFlowTask;", "private static")]
	public partial class SocketFlowTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.RestartableTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SocketFlowTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/SocketTube$SocketFlowTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "task", "Ljava/lang/Runnable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Ljava/util/concurrent/locks/Lock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "final")]
		public Dova.JDK.java.lang.Runnable task_Property
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

		[JniSignatureAttribute("Ljava/util/concurrent/locks/Lock;", "private final")]
		public Dova.JDK.java.util.concurrent.locks.Lock @lock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SocketFlowTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "")]
		public SocketFlowTask(Dova.JDK.java.lang.Runnable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/SocketTube$SocketFlowTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;)V", "public final")]
		public void run(Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.DeferredCompleter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
