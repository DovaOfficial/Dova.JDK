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

[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler;", "public final")]
public partial class SequentialScheduler
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SequentialScheduler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/SequentialScheduler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFLOAD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AGAIN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BEGIN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STOP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "END", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "Ljava/util/concurrent/atomic/AtomicInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "restartableTask", "Ljdk/internal/net/http/common/SequentialScheduler$RestartableTask;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completer", "Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "schedulableTask", "Ljdk/internal/net/http/common/SequentialScheduler$SchedulableTask;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/common/SequentialScheduler$RestartableTask;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runOrSchedule", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runOrSchedule", "(Ljdk/internal/net/http/common/SequentialScheduler$SchedulableTask;Ljava/util/concurrent/Executor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runOrSchedule", "(Ljava/util/concurrent/Executor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lockingScheduler", "(Ljava/lang/Runnable;)Ljdk/internal/net/http/common/SequentialScheduler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStopped", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "synchronizedScheduler", "(Ljava/lang/Runnable;)Ljdk/internal/net/http/common/SequentialScheduler;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int OFFLOAD_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int AGAIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int BEGIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int END_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicInteger;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicInteger state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$RestartableTask;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.RestartableTask restartableTask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.RestartableTask>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.DeferredCompleter completer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.DeferredCompleter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$SchedulableTask;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.SchedulableTask schedulableTask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.SchedulableTask>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SequentialScheduler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/common/SequentialScheduler$RestartableTask;)V", "public")]
	public SequentialScheduler(Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.RestartableTask arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/SequentialScheduler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void stop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void runOrSchedule()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/common/SequentialScheduler$SchedulableTask;Ljava/util/concurrent/Executor;)V", "private")]
	public void runOrSchedule(Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.SchedulableTask arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)V", "public")]
	public void runOrSchedule(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljdk/internal/net/http/common/SequentialScheduler;", "public static")]
	public static Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler lockingScheduler(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isStopped()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljdk/internal/net/http/common/SequentialScheduler;", "public static")]
	public static Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler synchronizedScheduler(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$RestartableTask;", "public abstract static interface")]
	public partial interface RestartableTask
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RestartableTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/SequentialScheduler$RestartableTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;)V"));
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;)V", "public abstract")]
		void run(Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.DeferredCompleter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$TryEndDeferredCompleter;", "private")]
	public partial class TryEndDeferredCompleter
		: Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.DeferredCompleter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TryEndDeferredCompleter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/SequentialScheduler$TryEndDeferredCompleter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/net/http/common/SequentialScheduler;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/common/SequentialScheduler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler;", "final")]
		public Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TryEndDeferredCompleter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/common/SequentialScheduler;)V", "private")]
		public TryEndDeferredCompleter(Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/SequentialScheduler$TryEndDeferredCompleter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void complete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;", "public abstract static")]
	public partial class DeferredCompleter
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DeferredCompleter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DeferredCompleter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DeferredCompleter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public abstract")]
		public void complete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$SchedulableTask;", "private final")]
	public partial class SchedulableTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SchedulableTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/SequentialScheduler$SchedulableTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/net/http/common/SequentialScheduler;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/common/SequentialScheduler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler;", "final")]
		public Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SchedulableTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/common/SequentialScheduler;)V", "private")]
		public SchedulableTask(Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/SequentialScheduler$SchedulableTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$SynchronizedRestartableTask;", "public static final")]
	public partial class SynchronizedRestartableTask
		: Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.CompleteRestartableTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SynchronizedRestartableTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/SequentialScheduler$SynchronizedRestartableTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainLoop", "Ljava/lang/Runnable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
		public Dova.JDK.java.lang.Runnable mainLoop_Property
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

		[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
		public Dova.JDK.java.lang.Object @lock_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SynchronizedRestartableTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public")]
		public SynchronizedRestartableTask(Dova.JDK.java.lang.Runnable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/SequentialScheduler$SynchronizedRestartableTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$LockingRestartableTask;", "public static final")]
	public partial class LockingRestartableTask
		: Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.CompleteRestartableTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LockingRestartableTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/SequentialScheduler$LockingRestartableTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainLoop", "Ljava/lang/Runnable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Ljava/util/concurrent/locks/Lock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
		public Dova.JDK.java.lang.Runnable mainLoop_Property
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
		public LockingRestartableTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public")]
		public LockingRestartableTask(Dova.JDK.java.lang.Runnable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/SequentialScheduler$LockingRestartableTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/SequentialScheduler$CompleteRestartableTask;", "public abstract static")]
	public partial class CompleteRestartableTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.RestartableTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompleteRestartableTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/common/SequentialScheduler$CompleteRestartableTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompleteRestartableTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public CompleteRestartableTask() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/common/SequentialScheduler$CompleteRestartableTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/net/http/common/SequentialScheduler$DeferredCompleter;)V", "public final")]
		public void run(Dova.JDK.jdk.@internal.net.http.common.SequentialScheduler.DeferredCompleter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "protected abstract")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}
}
