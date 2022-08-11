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

[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinWorkerThread;", "public")]
public partial class ForkJoinWorkerThread
	: Dova.JDK.java.lang.Thread
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ForkJoinWorkerThread()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinWorkerThread;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pool", "Ljava/util/concurrent/ForkJoinPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "workQueue", "Ljava/util/concurrent/ForkJoinPool$WorkQueue;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/ForkJoinPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ThreadGroup;Ljava/util/concurrent/ForkJoinPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ThreadGroup;Ljava/util/concurrent/ForkJoinPool;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPool", "()Ljava/util/concurrent/ForkJoinPool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPoolIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onStart", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTermination", "(Ljava/lang/Throwable;)V"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool;", "final")]
	public Dova.JDK.java.util.concurrent.ForkJoinPool pool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinPool$WorkQueue;", "final")]
	public Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue workQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool.WorkQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ForkJoinWorkerThread(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool;)V", "protected")]
	public ForkJoinWorkerThread(Dova.JDK.java.util.concurrent.ForkJoinPool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ThreadGroup;Ljava/util/concurrent/ForkJoinPool;)V", "")]
	public ForkJoinWorkerThread(Dova.JDK.java.lang.ThreadGroup arg0, Dova.JDK.java.util.concurrent.ForkJoinPool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ThreadGroup;Ljava/util/concurrent/ForkJoinPool;ZZ)V", "")]
	public ForkJoinWorkerThread(Dova.JDK.java.lang.ThreadGroup arg0, Dova.JDK.java.util.concurrent.ForkJoinPool arg1, bool arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/ForkJoinWorkerThread;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void run()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ForkJoinPool;", "public")]
	public Dova.JDK.java.util.concurrent.ForkJoinPool getPool()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ForkJoinPool>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPoolIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void onStart()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "protected")]
	public void onTermination(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ForkJoinWorkerThread$InnocuousForkJoinWorkerThread;", "static final")]
	public partial class InnocuousForkJoinWorkerThread
		: Dova.JDK.java.util.concurrent.ForkJoinWorkerThread
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InnocuousForkJoinWorkerThread()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ForkJoinWorkerThread$InnocuousForkJoinWorkerThread;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "innocuousThreadGroup", "Ljava/lang/ThreadGroup;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/ForkJoinPool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/ThreadGroup;", "private static final")]
		public static Dova.JDK.java.lang.ThreadGroup innocuousThreadGroup_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InnocuousForkJoinWorkerThread(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ForkJoinPool;)V", "")]
		public InnocuousForkJoinWorkerThread(Dova.JDK.java.util.concurrent.ForkJoinPool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ForkJoinWorkerThread$InnocuousForkJoinWorkerThread;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "public")]
		public void setContextClassLoader(Dova.JDK.java.lang.ClassLoader arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Thread$UncaughtExceptionHandler;)V", "public")]
		public void setUncaughtExceptionHandler(Dova.JDK.java.lang.Thread.UncaughtExceptionHandler arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
