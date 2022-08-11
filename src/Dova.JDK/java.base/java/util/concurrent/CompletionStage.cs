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

[JniSignatureAttribute("Ljava/util/concurrent/CompletionStage;", "public abstract interface")]
public partial interface CompletionStage
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompletionStage()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletionStage;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handle", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCompose", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAsync", "(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAsync", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApply", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApplyAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApplyAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAccept", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptAsync", "(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptAsync", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRun", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRunAsync", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRunAsync", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombine", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEither", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenComposeAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenComposeAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenComplete", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenCompleteAsync", "(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenCompleteAsync", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionally", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyCompose", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyComposeAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyComposeAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCompletableFuture", "()Ljava/util/concurrent/CompletableFuture;"));
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage handle(Dova.JDK.java.util.function.BiFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenCompose(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage handleAsync(Dova.JDK.java.util.function.BiFunction arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage handleAsync(Dova.JDK.java.util.function.BiFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenApply(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenApplyAsync(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenApplyAsync(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenAccept(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenAcceptAsync(Dova.JDK.java.util.function.Consumer arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenAcceptAsync(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenRun(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenRunAsync(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenRunAsync(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenCombine(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenCombineAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenCombineAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBoth(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBothAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBothAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage runAfterBoth(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage runAfterBothAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage runAfterBothAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage applyToEither(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage applyToEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage applyToEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage acceptEither(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage acceptEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage acceptEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage runAfterEither(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage runAfterEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage runAfterEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenComposeAsync(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage thenComposeAsync(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage whenComplete(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage whenCompleteAsync(Dova.JDK.java.util.function.BiConsumer arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage whenCompleteAsync(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletionStage exceptionally(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public")]
	Dova.JDK.java.util.concurrent.CompletionStage exceptionallyAsync(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public")]
	Dova.JDK.java.util.concurrent.CompletionStage exceptionallyAsync(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public")]
	Dova.JDK.java.util.concurrent.CompletionStage exceptionallyCompose(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public")]
	Dova.JDK.java.util.concurrent.CompletionStage exceptionallyComposeAsync(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public")]
	Dova.JDK.java.util.concurrent.CompletionStage exceptionallyComposeAsync(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public abstract")]
	Dova.JDK.java.util.concurrent.CompletableFuture toCompletableFuture()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}
}
