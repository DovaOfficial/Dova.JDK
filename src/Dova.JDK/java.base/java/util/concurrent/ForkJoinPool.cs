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

namespace Dova.JDK.java.util.concurrent;

[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool;", "public")]
public partial class ForkJoinPool
	: Dova.JDK.java.util.concurrent.AbstractExecutorService
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ForkJoinPool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinPool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SWIDTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SMASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_CAP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNSIGNALLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SS_SEQ", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIFO", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SRC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INNOCUOUS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUIET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHUTDOWN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TERMINATED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STOP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNCOMPENSATE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIAL_QUEUE_CAPACITY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultForkJoinWorkerThreadFactory", "Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "modifyThreadPermission", "Ljava/lang/RuntimePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "common", "Ljava/util/concurrent/ForkJoinPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMON_PARALLELISM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMON_MAX_SPARES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "poolIds", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_KEEPALIVE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TIMEOUT_SLOP", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMMON_MAX_SPARES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SP_MASK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UC_MASK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RC_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RC_UNIT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RC_MASK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TC_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TC_UNIT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TC_MASK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_WORKER", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keepAlive", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stealCount", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scanRover", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "threadIds", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bounds", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "queues", "[Ljava/util/concurrent/ForkJoinPool$WorkQueue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registrationLock", "Ljava/util/concurrent/locks/ReentrantLock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "termination", "Ljava/util/concurrent/locks/Condition;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "workerNamePrefix", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "factory", "Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ueh", "Ljava/lang/Thread$UncaughtExceptionHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "saturate", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctl", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CTL", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODE", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREADIDS", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POOLIDS", "Ljava/lang/invoke/VarHandle;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;Ljava/lang/Thread$UncaughtExceptionHandler;ZIIILjava/util/function/Predicate;JLjava/util/concurrent/TimeUnit;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;Ljava/lang/Thread$UncaughtExceptionHandler;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/util/concurrent/ForkJoinTask;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shutdown", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkPermission", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFactory", "()Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Ljava/util/concurrent/ForkJoinTask;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCommonPoolParallelism", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isShutdown", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Ljava/util/concurrent/ForkJoinPool$WorkQueue;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newTaskFor", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/RunnableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newTaskFor", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/RunnableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submit_0", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/ForkJoinTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submit_1", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submit_0", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ForkJoinTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submit_1", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submit", "(Ljava/util/concurrent/ForkJoinTask;)Ljava/util/concurrent/ForkJoinTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submit_0", "(Ljava/lang/Runnable;)Ljava/util/concurrent/ForkJoinTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submit_1", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shutdownNow", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTerminated", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "commonQueue", "()Ljava/util/concurrent/ForkJoinPool$WorkQueue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helpComplete", "(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinPool$WorkQueue;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "externalQueue", "()Ljava/util/concurrent/ForkJoinPool$WorkQueue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helpJoin", "(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinPool$WorkQueue;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uncompensate", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "externalPush", "(Ljava/util/concurrent/ForkJoinTask;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helpQuiescePool", "(Ljava/util/concurrent/ForkJoinPool$WorkQueue;JZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "externalHelpQuiescePool", "(JZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSurplusQueuedTaskCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextTaskFor", "(Ljava/util/concurrent/ForkJoinPool$WorkQueue;)Ljava/util/concurrent/ForkJoinTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pollSubmission", "()Ljava/util/concurrent/ForkJoinTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQueuedTaskCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deregisterWorker", "(Ljava/util/concurrent/ForkJoinWorkerThread;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddThreadIds", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeCtl", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryTerminate", "(ZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalWork", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createWorker", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "awaitWork", "(Ljava/util/concurrent/ForkJoinPool$WorkQueue;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetCtl", "(JJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddCtl", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryCompensate", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pollScan", "(Z)Ljava/util/concurrent/ForkJoinTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canStop", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submissionQueue", "()Ljava/util/concurrent/ForkJoinPool$WorkQueue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "helpAsyncBlocker", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrMode", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddPoolIds", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstanceFromSystemProperty", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "externalSubmit", "(Ljava/util/concurrent/ForkJoinTask;)Ljava/util/concurrent/ForkJoinTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compensatedBlock", "(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unmanagedBlock", "(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "contextWithPermissions", "([Ljava/security/Permission;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextWorkerThreadName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerWorker", "(Ljava/util/concurrent/ForkJoinPool$WorkQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runWorker", "(Ljava/util/concurrent/ForkJoinPool$WorkQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "commonPool", "()Ljava/util/concurrent/ForkJoinPool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParallelism", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPoolSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAsyncMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRunningThreadCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActiveThreadCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isQuiescent", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStealCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQueuedSubmissionCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasQueuedSubmissions", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drainTasksTo", "(Ljava/util/Collection;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTerminating", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "awaitQuiescence", "(JLjava/util/concurrent/TimeUnit;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "managedBlock", "(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SWIDTH_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int SMASK_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_CAP_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int UNSIGNALLED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int SS_SEQ_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FIFO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SRC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int INNOCUOUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int QUIET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SHUTDOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int TERMINATED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int STOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int UNCOMPENSATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int INITIAL_QUEUE_CAPACITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;", "public static final")]
	public static Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory defaultForkJoinWorkerThreadFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/RuntimePermission;", "static final")]
	public static Dova.JDK.java.lang.RuntimePermission modifyThreadPermission_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimePermission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool;", "static final")]
	public static Dova.JDK.java.util.concurrent.ForkJoinPool common_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int COMMON_PARALLELISM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int COMMON_MAX_SPARES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private static volatile")]
	public static int poolIds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long DEFAULT_KEEPALIVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long TIMEOUT_SLOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_COMMON_MAX_SPARES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long SP_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long UC_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int RC_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long RC_UNIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long RC_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TC_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long TC_UNIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long TC_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long ADD_WORKER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("J", "final")]
	public long keepAlive_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("J", "volatile")]
	public long stealCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int scanRover_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("I", "volatile")]
	public int threadIds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int bounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("I", "volatile")]
	public int mode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("[Ljava/util/concurrent/ForkJoinPool$WorkQueue;", "")]
	public JavaArray<Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue> queues_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/ReentrantLock;", "final")]
	public Dova.JDK.java.util.concurrent.locks.ReentrantLock registrationLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReentrantLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/Condition;", "")]
	public Dova.JDK.java.util.concurrent.locks.Condition termination_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Condition>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String workerNamePrefix_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;", "final")]
	public Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory factory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Thread$UncaughtExceptionHandler;", "final")]
	public Dova.JDK.java.lang.Thread.UncaughtExceptionHandler ueh_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread.UncaughtExceptionHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "final")]
	public Dova.JDK.java.util.function.Predicate saturate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "volatile")]
	public long ctl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle CTL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle MODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle THREADIDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle POOLIDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ForkJoinPool(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public ForkJoinPool(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ForkJoinPool() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	[JniSignatureAttribute("(ILjava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;Ljava/lang/Thread$UncaughtExceptionHandler;ZIIILjava/util/function/Predicate;JLjava/util/concurrent/TimeUnit;)V", "public")]
	public ForkJoinPool(int arg0, Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory arg1, Dova.JDK.java.lang.Thread.UncaughtExceptionHandler arg2, bool arg3, int arg4, int arg5, int arg6, Dova.JDK.java.util.function.Predicate arg7, long arg8, Dova.JDK.java.util.concurrent.TimeUnit arg9) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
	{
	}

	[JniSignatureAttribute("(ILjava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;Ljava/lang/Thread$UncaughtExceptionHandler;Z)V", "public")]
	public ForkJoinPool(int arg0, Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory arg1, Dova.JDK.java.lang.Thread.UncaughtExceptionHandler arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(B)V", "private")]
	public ForkJoinPool(byte arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/ForkJoinPool;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.util.concurrent.ForkJoinTask arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void shutdown()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void checkPermission()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;", "public")]
	public Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory getFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public")]
	public void execute(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;)V", "public")]
	public void execute(Dova.JDK.java.util.concurrent.ForkJoinTask arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Thread$UncaughtExceptionHandler;", "public")]
	public Dova.JDK.java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread.UncaughtExceptionHandler>(ret);
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getCommonPoolParallelism()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isShutdown()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$WorkQueue;II)I", "private")]
	public int scan(Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/RunnableFuture;", "protected")]
	public Dova.JDK.java.util.concurrent.RunnableFuture newTaskFor(Dova.JDK.java.util.concurrent.Callable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/RunnableFuture;", "protected")]
	public Dova.JDK.java.util.concurrent.RunnableFuture newTaskFor(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/ForkJoinTask;", "public")]
	public Dova.JDK.java.util.concurrent.ForkJoinTask submit_0(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", "public volatile")]
	public Dova.JDK.java.util.concurrent.Future submit_1(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ForkJoinTask;", "public")]
	public Dova.JDK.java.util.concurrent.ForkJoinTask submit_0(Dova.JDK.java.util.concurrent.Callable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", "public volatile")]
	public Dova.JDK.java.util.concurrent.Future submit_1(Dova.JDK.java.util.concurrent.Callable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;)Ljava/util/concurrent/ForkJoinTask;", "public")]
	public Dova.JDK.java.util.concurrent.ForkJoinTask submit(Dova.JDK.java.util.concurrent.ForkJoinTask arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/ForkJoinTask;", "public")]
	public Dova.JDK.java.util.concurrent.ForkJoinTask submit_0(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", "public volatile")]
	public Dova.JDK.java.util.concurrent.Future submit_1(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invokeAny(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invokeAny(Dova.JDK.java.util.Collection arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List invokeAll(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List invokeAll(Dova.JDK.java.util.Collection arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List shutdownNow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTerminated()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Z", "public")]
	public bool awaitTermination(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinPool$WorkQueue;", "static")]
	public static Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue commonQueue()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinPool$WorkQueue;Z)I", "final")]
	public int helpComplete(Dova.JDK.java.util.concurrent.ForkJoinTask arg0, Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinPool$WorkQueue;", "final")]
	public Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue externalQueue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinPool$WorkQueue;Z)I", "final")]
	public int helpJoin(Dova.JDK.java.util.concurrent.ForkJoinTask arg0, Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()V", "final")]
	public void uncompensate()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31]);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;)V", "final")]
	public void externalPush(Dova.JDK.java.util.concurrent.ForkJoinTask arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$WorkQueue;JZ)I", "final")]
	public int helpQuiescePool(Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JZ)I", "final")]
	public int externalHelpQuiescePool(long arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getSurplusQueuedTaskCount()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$WorkQueue;)Ljava/util/concurrent/ForkJoinTask;", "final")]
	public Dova.JDK.java.util.concurrent.ForkJoinTask nextTaskFor(Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinTask;", "protected")]
	public Dova.JDK.java.util.concurrent.ForkJoinTask pollSubmission()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getQueuedTaskCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinWorkerThread;Ljava/lang/Throwable;)V", "final")]
	public void deregisterWorker(Dova.JDK.java.util.concurrent.ForkJoinWorkerThread arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int getAndAddThreadIds(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "private")]
	public long compareAndExchangeCtl(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ZZ)Z", "private")]
	public bool tryTerminate(bool arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "final")]
	public void signalWork()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43]);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool createWorker()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$WorkQueue;)I", "private")]
	public int awaitWork(Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)Z", "private")]
	public bool compareAndSetCtl(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private")]
	public long getAndAddCtl(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "private")]
	public int tryCompensate(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Z)Ljava/util/concurrent/ForkJoinTask;", "private")]
	public Dova.JDK.java.util.concurrent.ForkJoinTask pollScan(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
	}

	[JniSignatureAttribute("()Z", "final")]
	public bool canStop()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[50]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinPool$WorkQueue;", "final")]
	public Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue submissionQueue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V", "static")]
	public static void helpAsyncBlocker(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.ForkJoinPool.ManagedBlocker arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1);
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int getAndBitwiseOrMode(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "private static")]
	public static int getAndAddPoolIds(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[54], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object newInstanceFromSystemProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;)Ljava/util/concurrent/ForkJoinTask;", "private")]
	public Dova.JDK.java.util.concurrent.ForkJoinTask externalSubmit(Dova.JDK.java.util.concurrent.ForkJoinTask arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V", "private")]
	public void compensatedBlock(Dova.JDK.java.util.concurrent.ForkJoinPool.ManagedBlocker arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V", "private static")]
	public static void unmanagedBlock(Dova.JDK.java.util.concurrent.ForkJoinPool.ManagedBlocker arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("([Ljava/security/Permission;)Ljava/security/AccessControlContext;", "static transient")]
	public static Dova.JDK.java.security.AccessControlContext contextWithPermissions(JavaArray<Dova.JDK.java.security.Permission> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String nextWorkerThreadName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$WorkQueue;)V", "final")]
	public void registerWorker(Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$WorkQueue;)V", "final")]
	public void runWorker(Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinPool;", "public static")]
	public static Dova.JDK.java.util.concurrent.ForkJoinPool commonPool()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getParallelism()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[64]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPoolSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[65]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getAsyncMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[66]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRunningThreadCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[67]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getActiveThreadCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[68]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isQuiescent()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getStealCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[70]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getQueuedSubmissionCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[71]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasQueuedSubmissions()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)I", "protected")]
	public int drainTasksTo(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTerminating()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[74]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Z", "public")]
	public bool awaitQuiescence(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V", "public static")]
	public static void managedBlock(Dova.JDK.java.util.concurrent.ForkJoinPool.ManagedBlocker arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;", "public abstract static interface")]
	public partial interface ForkJoinWorkerThreadFactory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForkJoinWorkerThreadFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newThread", "(Ljava/util/concurrent/ForkJoinPool;)Ljava/util/concurrent/ForkJoinWorkerThread;"));
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool;)Ljava/util/concurrent/ForkJoinWorkerThread;", "public abstract")]
		Dova.JDK.java.util.concurrent.ForkJoinWorkerThread newThread(Dova.JDK.java.util.concurrent.ForkJoinPool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinWorkerThread>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$WorkQueue;", "static final")]
	public partial class WorkQueue
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WorkQueue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinPool$WorkQueue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "phase", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackPred", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "config", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "base", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[Ljava/util/concurrent/ForkJoinTask;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owner", "Ljava/util/concurrent/ForkJoinWorkerThread;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "top", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nsteals", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QA", "Ljava/lang/invoke/VarHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOURCE", "Ljava/lang/invoke/VarHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASE", "Ljava/lang/invoke/VarHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INNOCUOUS_ACC", "Ljava/security/AccessControlContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/ForkJoinWorkerThread;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSlot", "([Ljava/util/concurrent/ForkJoinTask;I)Ljava/util/concurrent/ForkJoinTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peek", "()Ljava/util/concurrent/ForkJoinTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLock", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "push", "(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinPool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pop", "()Ljava/util/concurrent/ForkJoinTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helpComplete", "(Ljava/util/concurrent/ForkJoinTask;ZI)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "externalTryUnpush", "(Ljava/util/concurrent/ForkJoinTask;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryRemove", "(Ljava/util/concurrent/ForkJoinTask;Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryUnpush", "(Ljava/util/concurrent/ForkJoinTask;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queueSize", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextLocalTask", "()Ljava/util/concurrent/ForkJoinTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextLocalTask", "(I)Ljava/util/concurrent/ForkJoinTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeInnocuousWorker", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "casSlotToNull", "([Ljava/util/concurrent/ForkJoinTask;ILjava/util/concurrent/ForkJoinTask;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "topLevelExec", "(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinPool$WorkQueue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBaseOpaque", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lockedPush", "(Ljava/util/concurrent/ForkJoinTask;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helpAsyncBlocker", "(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isApparentlyUnblocked", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setSlotVolatile", "([Ljava/util/concurrent/ForkJoinTask;ILjava/util/concurrent/ForkJoinTask;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "growArray", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndClearSlot", "([Ljava/util/concurrent/ForkJoinTask;I)Ljava/util/concurrent/ForkJoinTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryPoll", "()Ljava/util/concurrent/ForkJoinTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPoolIndex", "()I"));
		}

		[JniSignatureAttribute("I", "volatile")]
		public int phase_Property
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

		[JniSignatureAttribute("I", "")]
		public int stackPred_Property
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

		[JniSignatureAttribute("I", "")]
		public int config_Property
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

		[JniSignatureAttribute("I", "")]
		public int @base_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("[Ljava/util/concurrent/ForkJoinTask;", "")]
		public JavaArray<Dova.JDK.java.util.concurrent.ForkJoinTask> array_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.concurrent.ForkJoinTask>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinWorkerThread;", "final")]
		public Dova.JDK.java.util.concurrent.ForkJoinWorkerThread owner_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinWorkerThread>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int top_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "volatile")]
		public int source_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int nsteals_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
		public static Dova.JDK.java.lang.invoke.VarHandle QA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
		public static Dova.JDK.java.lang.invoke.VarHandle SOURCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
		public static Dova.JDK.java.lang.invoke.VarHandle BASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private static")]
		public static Dova.JDK.java.security.AccessControlContext INNOCUOUS_ACC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WorkQueue(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinWorkerThread;Z)V", "")]
		public WorkQueue(Dova.JDK.java.util.concurrent.ForkJoinWorkerThread arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public WorkQueue(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ForkJoinPool$WorkQueue;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "final")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/util/concurrent/ForkJoinTask;I)Ljava/util/concurrent/ForkJoinTask;", "static final")]
		public static Dova.JDK.java.util.concurrent.ForkJoinTask getSlot(JavaArray<Dova.JDK.java.util.concurrent.ForkJoinTask> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinTask;", "final")]
		public Dova.JDK.java.util.concurrent.ForkJoinTask peek()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool tryLock()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinPool;)V", "final")]
		public void push(Dova.JDK.java.util.concurrent.ForkJoinTask arg0, Dova.JDK.java.util.concurrent.ForkJoinPool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinTask;", "private")]
		public Dova.JDK.java.util.concurrent.ForkJoinTask pop()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;ZI)I", "final")]
		public int helpComplete(Dova.JDK.java.util.concurrent.ForkJoinTask arg0, bool arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;)Z", "final")]
		public bool externalTryUnpush(Dova.JDK.java.util.concurrent.ForkJoinTask arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;Z)Z", "final")]
		public bool tryRemove(Dova.JDK.java.util.concurrent.ForkJoinTask arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;)Z", "final")]
		public bool tryUnpush(Dova.JDK.java.util.concurrent.ForkJoinTask arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "final")]
		public int queueSize()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinTask;", "final")]
		public Dova.JDK.java.util.concurrent.ForkJoinTask nextLocalTask()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/util/concurrent/ForkJoinTask;", "final")]
		public Dova.JDK.java.util.concurrent.ForkJoinTask nextLocalTask(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
		}

		[JniSignatureAttribute("()V", "final")]
		public void initializeInnocuousWorker()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
		}

		[JniSignatureAttribute("([Ljava/util/concurrent/ForkJoinTask;ILjava/util/concurrent/ForkJoinTask;)Z", "static final")]
		public static bool casSlotToNull(JavaArray<Dova.JDK.java.util.concurrent.ForkJoinTask> arg0, int arg1, Dova.JDK.java.util.concurrent.ForkJoinTask arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinPool$WorkQueue;)V", "final")]
		public void topLevelExec(Dova.JDK.java.util.concurrent.ForkJoinTask arg0, Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		}

		[JniSignatureAttribute("(I)V", "final")]
		public void setBaseOpaque(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinTask;)Z", "final")]
		public bool lockedPush(Dova.JDK.java.util.concurrent.ForkJoinTask arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V", "final")]
		public void helpAsyncBlocker(Dova.JDK.java.util.concurrent.ForkJoinPool.ManagedBlocker arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool isApparentlyUnblocked()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/util/concurrent/ForkJoinTask;ILjava/util/concurrent/ForkJoinTask;)V", "static final")]
		public static void setSlotVolatile(JavaArray<Dova.JDK.java.util.concurrent.ForkJoinTask> arg0, int arg1, Dova.JDK.java.util.concurrent.ForkJoinTask arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "final")]
		public void growArray()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
		}

		[JniSignatureAttribute("([Ljava/util/concurrent/ForkJoinTask;I)Ljava/util/concurrent/ForkJoinTask;", "static final")]
		public static Dova.JDK.java.util.concurrent.ForkJoinTask getAndClearSlot(JavaArray<Dova.JDK.java.util.concurrent.ForkJoinTask> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinTask;", "final")]
		public Dova.JDK.java.util.concurrent.ForkJoinTask tryPoll()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinTask>(ret);
		}

		[JniSignatureAttribute("()I", "final")]
		public int getPoolIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;", "public abstract static interface")]
	public partial interface ManagedBlocker
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ManagedBlocker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "block", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReleasable", "()Z"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool block()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isReleasable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$DefaultCommonPoolForkJoinWorkerThreadFactory;", "static final")]
	public partial class DefaultCommonPoolForkJoinWorkerThreadFactory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultCommonPoolForkJoinWorkerThreadFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinPool$DefaultCommonPoolForkJoinWorkerThreadFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC", "Ljava/security/AccessControlContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newThread", "(Ljava/util/concurrent/ForkJoinPool;)Ljava/util/concurrent/ForkJoinWorkerThread;"));
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private static final")]
		public static Dova.JDK.java.security.AccessControlContext ACC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultCommonPoolForkJoinWorkerThreadFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public DefaultCommonPoolForkJoinWorkerThreadFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ForkJoinPool$DefaultCommonPoolForkJoinWorkerThreadFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool;)Ljava/util/concurrent/ForkJoinWorkerThread;", "public final")]
		public Dova.JDK.java.util.concurrent.ForkJoinWorkerThread newThread(Dova.JDK.java.util.concurrent.ForkJoinPool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinWorkerThread>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$InvokeAnyRoot;", "static final")]
	public partial class InvokeAnyRoot
		: Dova.JDK.java.util.concurrent.ForkJoinTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvokeAnyRoot()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinPool$InvokeAnyRoot;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "Ljava/util/concurrent/atomic/AtomicInteger;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pool", "Ljava/util/concurrent/ForkJoinPool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/util/concurrent/ForkJoinPool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exec", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawResult", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryComplete", "(Ljava/util/concurrent/Callable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawResult", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "volatile")]
		public Dova.JDK.java.lang.Object result_Property
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

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicInteger;", "final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicInteger count_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicInteger>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool;", "final")]
		public Dova.JDK.java.util.concurrent.ForkJoinPool pool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InvokeAnyRoot(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/util/concurrent/ForkJoinPool;)V", "")]
		public InvokeAnyRoot(int arg0, Dova.JDK.java.util.concurrent.ForkJoinPool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ForkJoinPool$InvokeAnyRoot;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public final")]
		public bool exec()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public final")]
		public void setRawResult(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)V", "final")]
		public void tryComplete(Dova.JDK.java.util.concurrent.Callable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object getRawResult()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$InvokeAnyTask;", "static final")]
	public partial class InvokeAnyTask
		: Dova.JDK.java.util.concurrent.ForkJoinTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvokeAnyTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinPool$InvokeAnyTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "root", "Ljava/util/concurrent/ForkJoinPool$InvokeAnyRoot;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "callable", "Ljava/util/concurrent/Callable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "runner", "Ljava/lang/Thread;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/ForkJoinPool$InvokeAnyRoot;Ljava/util/concurrent/Callable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exec", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "(Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawResult", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawResult", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$InvokeAnyRoot;", "final")]
		public Dova.JDK.java.util.concurrent.ForkJoinPool.InvokeAnyRoot root_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool.InvokeAnyRoot>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Callable;", "final")]
		public Dova.JDK.java.util.concurrent.Callable callable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Callable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Thread;", "transient volatile")]
		public Dova.JDK.java.lang.Thread runner_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InvokeAnyTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool$InvokeAnyRoot;Ljava/util/concurrent/Callable;)V", "")]
		public InvokeAnyTask(Dova.JDK.java.util.concurrent.ForkJoinPool.InvokeAnyRoot arg0, Dova.JDK.java.util.concurrent.Callable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ForkJoinPool$InvokeAnyTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public final")]
		public bool exec()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Z)Z", "public final")]
		public bool cancel(bool arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public final")]
		public void setRawResult(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object getRawResult()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$DefaultForkJoinWorkerThreadFactory;", "static final")]
	public partial class DefaultForkJoinWorkerThreadFactory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultForkJoinWorkerThreadFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinPool$DefaultForkJoinWorkerThreadFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC", "Ljava/security/AccessControlContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newThread", "(Ljava/util/concurrent/ForkJoinPool;)Ljava/util/concurrent/ForkJoinWorkerThread;"));
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private static final")]
		public static Dova.JDK.java.security.AccessControlContext ACC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultForkJoinWorkerThreadFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public DefaultForkJoinWorkerThreadFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ForkJoinPool$DefaultForkJoinWorkerThreadFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool;)Ljava/util/concurrent/ForkJoinWorkerThread;", "public final")]
		public Dova.JDK.java.util.concurrent.ForkJoinWorkerThread newThread(Dova.JDK.java.util.concurrent.ForkJoinPool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinWorkerThread>(ret);
		}
	}
}
