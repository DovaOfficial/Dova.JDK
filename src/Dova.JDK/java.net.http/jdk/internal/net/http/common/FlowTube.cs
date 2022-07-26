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

namespace Dova.JDK.jdk.@internal.net.http.common;

[JniSignatureAttribute("Ljdk/internal/net/http/common/FlowTube;", "public abstract interface")]
public partial interface FlowTube
	: IJavaObject
	, Dova.JDK.java.util.concurrent.Flow.Publisher
	, Dova.JDK.java.util.concurrent.Flow.Subscriber
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FlowTube()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/FlowTube;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinished", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connectFlows", "(Ljdk/internal/net/http/common/FlowTube$TubePublisher;Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asTubeSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;)Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asTubePublisher", "(Ljava/util/concurrent/Flow$Publisher;)Ljdk/internal/net/http/common/FlowTube$TubePublisher;"));
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isFinished()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/common/FlowTube$TubePublisher;Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;)V", "public")]
	void connectFlows(Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubePublisher arg0, Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;", "public static")]
	static Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber asTubeSubscriber(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Publisher;)Ljdk/internal/net/http/common/FlowTube$TubePublisher;", "public static")]
	static Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubePublisher asTubePublisher(Dova.JDK.java.util.concurrent.Flow.Publisher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubePublisher>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/FlowTube$TubePublisher;", "public abstract static interface")]
	public partial interface TubePublisher
		: IJavaObject
		, Dova.JDK.java.util.concurrent.Flow.Publisher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static TubePublisher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/FlowTube$TubePublisher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;", "public abstract static interface")]
	public partial interface TubeSubscriber
		: IJavaObject
		, Dova.JDK.java.util.concurrent.Flow.Subscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TubeSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/FlowTube$TubeSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsRecycling", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropSubscription", "()V"));
		}

		[JniSignatureAttribute("()Z", "public")]
		bool supportsRecycling()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		void dropSubscription()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/FlowTube$AbstractTubeSubscriber;", "public abstract static")]
	public partial class AbstractTubeSubscriber
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubeSubscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractTubeSubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/FlowTube$AbstractTubeSubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractTubeSubscriber(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractTubeSubscriber() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/FlowTube$AbstractTubeSubscriber;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Ljdk/internal/net/http/common/FlowTube$AbstractTubeSubscriber$TubeSubscriberWrapper;", "static final")]
		public partial class TubeSubscriberWrapper
			: Dova.JDK.jdk.@internal.net.http.common.FlowTube.AbstractTubeSubscriber
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TubeSubscriberWrapper()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/FlowTube$AbstractTubeSubscriber$TubeSubscriberWrapper;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Ljava/util/concurrent/Flow$Subscriber;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Flow$Subscriber;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropSubscription", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNext", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/lang/Throwable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			}

			[JniSignatureAttribute("Ljava/util/concurrent/Flow$Subscriber;", "final")]
			public Dova.JDK.java.util.concurrent.Flow.Subscriber @delegate_Property
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
			public TubeSubscriberWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)V", "")]
			public TubeSubscriberWrapper(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/FlowTube$AbstractTubeSubscriber$TubeSubscriberWrapper;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void dropSubscription()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscription;)V", "public")]
			public void onSubscribe(Dova.JDK.java.util.concurrent.Flow.Subscription arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
			public void onNext(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
			public void onNext(Dova.JDK.java.util.List arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
			public void onError(Dova.JDK.java.lang.Throwable arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("()V", "public")]
			public void onComplete()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/FlowTube$AbstractTubePublisher;", "public abstract static")]
	public partial class AbstractTubePublisher
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.common.FlowTube.TubePublisher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractTubePublisher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/FlowTube$AbstractTubePublisher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractTubePublisher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractTubePublisher() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/FlowTube$AbstractTubePublisher;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Ljdk/internal/net/http/common/FlowTube$AbstractTubePublisher$TubePublisherWrapper;", "static final")]
		public partial class TubePublisherWrapper
			: Dova.JDK.jdk.@internal.net.http.common.FlowTube.AbstractTubePublisher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TubePublisherWrapper()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/FlowTube$AbstractTubePublisher$TubePublisherWrapper;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Ljava/util/concurrent/Flow$Publisher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Flow$Publisher;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subscribe", "(Ljava/util/concurrent/Flow$Subscriber;)V"));
			}

			[JniSignatureAttribute("Ljava/util/concurrent/Flow$Publisher;", "final")]
			public Dova.JDK.java.util.concurrent.Flow.Publisher @delegate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Flow.Publisher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TubePublisherWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Publisher;)V", "public")]
			public TubePublisherWrapper(Dova.JDK.java.util.concurrent.Flow.Publisher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/FlowTube$AbstractTubePublisher$TubePublisherWrapper;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)V", "public")]
			public void subscribe(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}
		}
	}
}
