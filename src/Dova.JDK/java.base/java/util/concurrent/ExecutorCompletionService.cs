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

[JniSignatureAttribute("Ljava/util/concurrent/ExecutorCompletionService;", "public")]
public partial class ExecutorCompletionService
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.util.concurrent.CompletionService
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExecutorCompletionService()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ExecutorCompletionService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "executor", "Ljava/util/concurrent/Executor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "aes", "Ljava/util/concurrent/AbstractExecutorService;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "completionQueue", "Ljava/util/concurrent/BlockingQueue;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExecutorCompletionService", "(Ljava/util/concurrent/Executor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExecutorCompletionService", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "poll", "()Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newTaskFor", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/RunnableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newTaskFor", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/RunnableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "take", "()Ljava/util/concurrent/Future;"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "private final")]
	public Dova.JDK.java.util.concurrent.Executor executor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/AbstractExecutorService;", "private final")]
	public Dova.JDK.java.util.concurrent.AbstractExecutorService aes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.AbstractExecutorService>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/BlockingQueue;", "private final")]
	public Dova.JDK.java.util.concurrent.BlockingQueue completionQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.BlockingQueue>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExecutorCompletionService(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)V", "public")]
	public ExecutorCompletionService(Dova.JDK.java.util.concurrent.Executor arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V", "public")]
	public ExecutorCompletionService(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.BlockingQueue arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/ExecutorCompletionService;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", "public")]
	public Dova.JDK.java.util.concurrent.Future poll(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/Future;", "public")]
	public Dova.JDK.java.util.concurrent.Future poll()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/RunnableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.RunnableFuture newTaskFor(Dova.JDK.java.util.concurrent.Callable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/RunnableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.RunnableFuture newTaskFor(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.RunnableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", "public")]
	public Dova.JDK.java.util.concurrent.Future submit(Dova.JDK.java.util.concurrent.Callable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", "public")]
	public Dova.JDK.java.util.concurrent.Future submit(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/Future;", "public")]
	public Dova.JDK.java.util.concurrent.Future take()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ExecutorCompletionService$QueueingFuture;", "private static")]
	public partial class QueueingFuture
		: Dova.JDK.java.util.concurrent.FutureTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static QueueingFuture()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ExecutorCompletionService$QueueingFuture;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "task", "Ljava/util/concurrent/Future;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "completionQueue", "Ljava/util/concurrent/BlockingQueue;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "QueueingFuture", "(Ljava/util/concurrent/RunnableFuture;Ljava/util/concurrent/BlockingQueue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "done", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Future;", "private final")]
		public Dova.JDK.java.util.concurrent.Future task_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/BlockingQueue;", "private final")]
		public Dova.JDK.java.util.concurrent.BlockingQueue completionQueue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.BlockingQueue>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public QueueingFuture(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/RunnableFuture;Ljava/util/concurrent/BlockingQueue;)V", "")]
		public QueueingFuture(Dova.JDK.java.util.concurrent.RunnableFuture arg0, Dova.JDK.java.util.concurrent.BlockingQueue arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ExecutorCompletionService$QueueingFuture;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void done()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
