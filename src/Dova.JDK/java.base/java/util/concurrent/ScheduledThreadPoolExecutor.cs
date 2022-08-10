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

namespace Dova.JDK.java.util.concurrent;

[JniSignatureAttribute("Ljava/util/concurrent/ScheduledThreadPoolExecutor;", "public")]
public partial class ScheduledThreadPoolExecutor
	: Dova.JDK.java.util.concurrent.ThreadPoolExecutor
	, Dova.JDK.java.util.concurrent.ScheduledExecutorService
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ScheduledThreadPoolExecutor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ScheduledThreadPoolExecutor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "continueExistingPeriodicTasksAfterShutdown", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "executeExistingDelayedTasksAfterShutdown", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "removeOnCancel", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "sequencer", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_KEEPALIVE_MILLIS", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScheduledThreadPoolExecutor", "(ILjava/util/concurrent/ThreadFactory;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScheduledThreadPoolExecutor", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScheduledThreadPoolExecutor", "(ILjava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScheduledThreadPoolExecutor", "(ILjava/util/concurrent/RejectedExecutionHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "shutdown", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "execute", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getQueue", "()Ljava/util/concurrent/BlockingQueue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "shutdownNow", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onShutdown", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "canRunInCurrentRunState", "(Ljava/util/concurrent/RunnableScheduledFuture;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getExecuteExistingDelayedTasksAfterShutdownPolicy", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getContinueExistingPeriodicTasksAfterShutdownPolicy", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "triggerTime", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "triggerTime", "(JLjava/util/concurrent/TimeUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "overflowFree", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "decorateTask", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "decorateTask", "(Ljava/lang/Runnable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "delayedExecute", "(Ljava/util/concurrent/RunnableScheduledFuture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reExecutePeriodic", "(Ljava/util/concurrent/RunnableScheduledFuture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setContinueExistingPeriodicTasksAfterShutdownPolicy", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setExecuteExistingDelayedTasksAfterShutdownPolicy", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setRemoveOnCancelPolicy", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRemoveOnCancelPolicy", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool continueExistingPeriodicTasksAfterShutdown_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool executeExistingDelayedTasksAfterShutdown_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Z", "volatile")]
	public bool removeOnCancel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicLong sequencer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long DEFAULT_KEEPALIVE_MILLIS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ScheduledThreadPoolExecutor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/util/concurrent/ThreadFactory;)V", "public")]
	public ScheduledThreadPoolExecutor(int arg0, Dova.JDK.java.util.concurrent.ThreadFactory arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public ScheduledThreadPoolExecutor(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(ILjava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V", "public")]
	public ScheduledThreadPoolExecutor(int arg0, Dova.JDK.java.util.concurrent.ThreadFactory arg1, Dova.JDK.java.util.concurrent.RejectedExecutionHandler arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(ILjava/util/concurrent/RejectedExecutionHandler;)V", "public")]
	public ScheduledThreadPoolExecutor(int arg0, Dova.JDK.java.util.concurrent.RejectedExecutionHandler arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/ScheduledThreadPoolExecutor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void shutdown()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public")]
	public void execute(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/BlockingQueue;", "public")]
	public Dova.JDK.java.util.concurrent.BlockingQueue getQueue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.BlockingQueue>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", "public")]
	public Dova.JDK.java.util.concurrent.Future submit(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", "public")]
	public Dova.JDK.java.util.concurrent.Future submit(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", "public")]
	public Dova.JDK.java.util.concurrent.Future submit(Dova.JDK.java.util.concurrent.Callable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List shutdownNow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "public")]
	public Dova.JDK.java.util.concurrent.ScheduledFuture schedule(Dova.JDK.java.util.concurrent.Callable arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "public")]
	public Dova.JDK.java.util.concurrent.ScheduledFuture schedule(Dova.JDK.java.lang.Runnable arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void onShutdown()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "public")]
	public Dova.JDK.java.util.concurrent.ScheduledFuture scheduleWithFixedDelay(Dova.JDK.java.lang.Runnable arg0, long arg1, long arg2, Dova.JDK.java.util.concurrent.TimeUnit arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/RunnableScheduledFuture;)Z", "")]
	public bool canRunInCurrentRunState(Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getExecuteExistingDelayedTasksAfterShutdownPolicy()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getContinueExistingPeriodicTasksAfterShutdownPolicy()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "")]
	public long triggerTime(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)J", "private")]
	public long triggerTime(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private")]
	public long overflowFree(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;", "protected")]
	public Dova.JDK.java.util.concurrent.RunnableScheduledFuture decorateTask(Dova.JDK.java.util.concurrent.Callable arg0, Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;", "protected")]
	public Dova.JDK.java.util.concurrent.RunnableScheduledFuture decorateTask(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/RunnableScheduledFuture;)V", "private")]
	public void delayedExecute(Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/RunnableScheduledFuture;)V", "")]
	public void reExecutePeriodic(Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setContinueExistingPeriodicTasksAfterShutdownPolicy(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setExecuteExistingDelayedTasksAfterShutdownPolicy(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setRemoveOnCancelPolicy(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getRemoveOnCancelPolicy()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "public")]
	public Dova.JDK.java.util.concurrent.ScheduledFuture scheduleAtFixedRate(Dova.JDK.java.lang.Runnable arg0, long arg1, long arg2, Dova.JDK.java.util.concurrent.TimeUnit arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue;", "static")]
	public partial class DelayedWorkQueue
		: Dova.JDK.java.util.AbstractQueue
		, Dova.JDK.java.util.concurrent.BlockingQueue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DelayedWorkQueue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_CAPACITY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "queue", "[Ljava/util/concurrent/RunnableScheduledFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lock", "Ljava/util/concurrent/locks/ReentrantLock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "size", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "leader", "Ljava/lang/Thread;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "available", "Ljava/util/concurrent/locks/Condition;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DelayedWorkQueue", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljava/lang/Runnable;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "put", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "put", "(Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "indexOf", "(Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "size", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toArray", "()[Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "iterator", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "contains", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "poll_0", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/RunnableScheduledFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "poll_1", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "poll_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "poll_1", "()Ljava/util/concurrent/RunnableScheduledFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "peek_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "peek_1", "()Ljava/util/concurrent/RunnableScheduledFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "grow", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "offer", "(Ljava/lang/Runnable;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "offer", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "offer", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setIndex", "(Ljava/util/concurrent/RunnableScheduledFuture;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "take_0", "()Ljava/util/concurrent/RunnableScheduledFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "take_1", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "siftDown", "(ILjava/util/concurrent/RunnableScheduledFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "siftUp", "(ILjava/util/concurrent/RunnableScheduledFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finishPoll", "(Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drainTo", "(Ljava/util/Collection;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drainTo", "(Ljava/util/Collection;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remainingCapacity", "()I"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int INITIAL_CAPACITY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("[Ljava/util/concurrent/RunnableScheduledFuture;", "private")]
		public JavaArray<Dova.JDK.java.util.concurrent.RunnableScheduledFuture> queue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/ReentrantLock;", "private final")]
		public Dova.JDK.java.util.concurrent.locks.ReentrantLock @lock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReentrantLock>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Ljava/lang/Thread;", "private")]
		public Dova.JDK.java.lang.Thread leader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/Condition;", "private final")]
		public Dova.JDK.java.util.concurrent.locks.Condition available_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Condition>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DelayedWorkQueue(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public DelayedWorkQueue() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Z", "public")]
		public bool add(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool add(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool remove(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void put(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public")]
		public void put(Dova.JDK.java.lang.Runnable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "private")]
		public int indexOf(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> toArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> toArray(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
		public Dova.JDK.java.util.Iterator iterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool contains(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return ret;
		}

		[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/RunnableScheduledFuture;", "public")]
		public Dova.JDK.java.util.concurrent.RunnableScheduledFuture poll_0(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>(ret);
		}

		[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object poll_1(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object poll_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/RunnableScheduledFuture;", "public")]
		public Dova.JDK.java.util.concurrent.RunnableScheduledFuture poll_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object peek_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/RunnableScheduledFuture;", "public")]
		public Dova.JDK.java.util.concurrent.RunnableScheduledFuture peek_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void grow()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Z", "public")]
		public bool offer(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool offer(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Z", "public")]
		public bool offer(Dova.JDK.java.lang.Runnable arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", "public volatile")]
		public bool offer(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/RunnableScheduledFuture;I)V", "private static")]
		public static void setIndex(Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg0, int arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/RunnableScheduledFuture;", "public")]
		public Dova.JDK.java.util.concurrent.RunnableScheduledFuture take_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object take_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(ILjava/util/concurrent/RunnableScheduledFuture;)V", "private")]
		public void siftDown(int arg0, Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("(ILjava/util/concurrent/RunnableScheduledFuture;)V", "private")]
		public void siftUp(int arg0, Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;", "private")]
		public Dova.JDK.java.util.concurrent.RunnableScheduledFuture finishPoll(Dova.JDK.java.util.concurrent.RunnableScheduledFuture arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)I", "public")]
		public int drainTo(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Collection;I)I", "public")]
		public int drainTo(Dova.JDK.java.util.Collection arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int remainingCapacity()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32]);
			return ret;
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue$Itr;", "private")]
		public partial class Itr
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.Iterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Itr()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue$Itr;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "array", "[Ljava/util/concurrent/RunnableScheduledFuture;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cursor", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastRet", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Itr", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue;[Ljava/util/concurrent/RunnableScheduledFuture;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasNext", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next_1", "()Ljava/lang/Runnable;"));
			}

			[JniSignatureAttribute("[Ljava/util/concurrent/RunnableScheduledFuture;", "final")]
			public JavaArray<Dova.JDK.java.util.concurrent.RunnableScheduledFuture> array_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("I", "")]
			public int cursor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("I", "")]
			public int lastRet_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue;", "final")]
			public Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor.DelayedWorkQueue this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor.DelayedWorkQueue>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Itr(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue;[Ljava/util/concurrent/RunnableScheduledFuture;)V", "")]
			public Itr(Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor.DelayedWorkQueue arg0, JavaArray<Dova.JDK.java.util.concurrent.RunnableScheduledFuture> arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/concurrent/ScheduledThreadPoolExecutor$DelayedWorkQueue$Itr;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void remove()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool hasNext()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object next_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Runnable;", "public")]
			public Dova.JDK.java.lang.Runnable next_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ScheduledThreadPoolExecutor$ScheduledFutureTask;", "private")]
	public partial class ScheduledFutureTask
		: Dova.JDK.java.util.concurrent.FutureTask
		, Dova.JDK.java.util.concurrent.RunnableScheduledFuture
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ScheduledFutureTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ScheduledThreadPoolExecutor$ScheduledFutureTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sequenceNumber", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "time", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "period", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "outerTask", "Ljava/util/concurrent/RunnableScheduledFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "heapIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljava/util/concurrent/ScheduledThreadPoolExecutor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScheduledFutureTask", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/Callable;JJ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScheduledFutureTask", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/lang/Runnable;Ljava/lang/Object;JJJ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScheduledFutureTask", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/lang/Runnable;Ljava/lang/Object;JJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareTo", "(Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareTo", "(Ljava/util/concurrent/Delayed;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cancel", "(Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNextRunTime", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPeriodic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDelay", "(Ljava/util/concurrent/TimeUnit;)J"));
		}

		[JniSignatureAttribute("J", "private final")]
		public long sequenceNumber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("J", "private volatile")]
		public long time_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("J", "private final")]
		public long period_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/RunnableScheduledFuture;", "")]
		public Dova.JDK.java.util.concurrent.RunnableScheduledFuture outerTask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableScheduledFuture>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "")]
		public int heapIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ScheduledThreadPoolExecutor;", "final")]
		public Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ScheduledFutureTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/Callable;JJ)V", "")]
		public ScheduledFutureTask(Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor arg0, Dova.JDK.java.util.concurrent.Callable arg1, long arg2, long arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/lang/Runnable;Ljava/lang/Object;JJJ)V", "")]
		public ScheduledFutureTask(Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4, long arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/lang/Runnable;Ljava/lang/Object;JJ)V", "")]
		public ScheduledFutureTask(Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ScheduledThreadPoolExecutor$ScheduledFutureTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
		public int compareTo(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Delayed;)I", "public")]
		public int compareTo(Dova.JDK.java.util.concurrent.Delayed arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Z)Z", "public")]
		public bool cancel(bool arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void setNextRunTime()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPeriodic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/TimeUnit;)J", "public")]
		public long getDelay(Dova.JDK.java.util.concurrent.TimeUnit arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}
	}
}
