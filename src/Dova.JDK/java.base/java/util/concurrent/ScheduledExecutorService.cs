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

[JniSignatureAttribute("Ljava/util/concurrent/ScheduledExecutorService;", "public abstract interface")]
public partial interface ScheduledExecutorService
	: IJavaObject
	, Dova.JDK.java.util.concurrent.ExecutorService
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ScheduledExecutorService()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ScheduledExecutorService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.ScheduledFuture scheduleWithFixedDelay(Dova.JDK.java.lang.Runnable arg0, long arg1, long arg2, Dova.JDK.java.util.concurrent.TimeUnit arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.ScheduledFuture scheduleAtFixedRate(Dova.JDK.java.lang.Runnable arg0, long arg1, long arg2, Dova.JDK.java.util.concurrent.TimeUnit arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.ScheduledFuture schedule(Dova.JDK.java.util.concurrent.Callable arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.ScheduledFuture schedule(Dova.JDK.java.lang.Runnable arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
	}
}
