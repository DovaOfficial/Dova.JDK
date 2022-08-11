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

[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "public")]
public partial class CompletableFuture
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.util.concurrent.Future
	, Dova.JDK.java.util.concurrent.CompletionStage
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompletableFuture()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack", "Ljava/util/concurrent/CompletableFuture$Completion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NIL", "Ljava/util/concurrent/CompletableFuture$AltResult;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USE_COMMON_POOL", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASYNC_POOL", "Ljava/util/concurrent/Executor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASYNC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NESTED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESULT", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STACK", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEXT", "Ljava/lang/invoke/VarHandle;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodeThrowable", "(Ljava/lang/Throwable;)Ljava/util/concurrent/CompletableFuture$AltResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodeThrowable", "(Ljava/lang/Throwable;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "join", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handle_0", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handle_1", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "allOf", "([Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDone", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCancelled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeExceptionally", "(Ljava/lang/Throwable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAccept_0", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAccept_1", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenCompleteAsync_0", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenCompleteAsync_1", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenCompleteAsync_0", "(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenCompleteAsync_1", "(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCompose_0", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCompose_1", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "failedFuture", "(Ljava/lang/Throwable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApply_0", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApply_1", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "completedFuture", "(Ljava/lang/Object;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenComplete_0", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenComplete_1", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeAsync", "(Ljava/util/function/Supplier;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeAsync", "(Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryPushStack", "(Ljava/util/concurrent/CompletableFuture$Completion;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodeRelay", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushStack", "(Ljava/util/concurrent/CompletableFuture$Completion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanStack", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postComplete", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniApplyNow", "(Ljava/lang/Object;Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newIncompleteFuture", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unipush", "(Ljava/util/concurrent/CompletableFuture$Completion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeValue", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniAcceptNow", "(Ljava/lang/Object;Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniRunNow", "(Ljava/lang/Object;Ljava/util/concurrent/Executor;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalComplete", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeThrowable", "(Ljava/lang/Throwable;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeThrowable", "(Ljava/lang/Throwable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniWhenComplete", "(Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture$UniWhenComplete;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeValue", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniHandle", "(Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/concurrent/CompletableFuture$UniHandle;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniExceptionally", "(Ljava/lang/Object;Ljava/util/function/Function;Ljava/util/concurrent/CompletableFuture$UniExceptionally;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCompletableFuture", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postFire", "(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;I)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postFire", "(Ljava/util/concurrent/CompletableFuture;I)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bipush", "(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture$BiCompletion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "biApply", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/concurrent/CompletableFuture$BiApply;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeNull", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "biAccept", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture$BiAccept;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "biRun", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Runnable;Ljava/util/concurrent/CompletableFuture$BiRun;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "andTree", "([Ljava/util/concurrent/CompletableFuture;II)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orpush", "(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture$BiCompletion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultExecutor", "()Ljava/util/concurrent/Executor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asyncSupplyStage", "(Ljava/util/concurrent/Executor;Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "screenExecutor", "(Ljava/util/concurrent/Executor;)Ljava/util/concurrent/Executor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asyncRunStage", "(Ljava/util/concurrent/Executor;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "waitingGet", "(Z)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reportGet", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timedGet", "(J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reportJoin", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniApplyStage", "(Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniAcceptStage", "(Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniRunStage", "(Ljava/util/concurrent/Executor;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "biApplyStage", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "biAcceptStage", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "biRunStage", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orApplyStage", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orAcceptStage", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orRunStage", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniComposeStage", "(Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniWhenCompleteStage", "(Ljava/util/concurrent/Executor;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniHandleStage", "(Ljava/util/concurrent/Executor;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniExceptionallyStage", "(Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniComposeExceptionallyStage", "(Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "uniCopyStage", "(Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uniAsMinimalStage", "()Ljava/util/concurrent/CompletableFuture$MinimalStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyComposeAsync_0", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyComposeAsync_1", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyComposeAsync_0", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyComposeAsync_1", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyCompose_0", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyCompose_1", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyAsync_0", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyAsync_1", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyAsync_0", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyAsync_1", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionally_0", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionally_1", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAsync_0", "(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAsync_1", "(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAsync_0", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAsync_1", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenComposeAsync_0", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenComposeAsync_1", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenComposeAsync_0", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenComposeAsync_1", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEitherAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEitherAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEitherAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEitherAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEither_0", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEither_1", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEitherAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEitherAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEitherAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEitherAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEither_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEither_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEitherAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEitherAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEitherAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEitherAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEither_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEither_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBothAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBothAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBothAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBothAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBoth_0", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBoth_1", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBothAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBothAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBothAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBothAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBoth_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBoth_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombineAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombineAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombineAsync_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombineAsync_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombine_0", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombine_1", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRunAsync_0", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRunAsync_1", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRunAsync_0", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRunAsync_1", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRun_0", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRun_1", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptAsync_0", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptAsync_1", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptAsync_0", "(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptAsync_1", "(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApplyAsync_0", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApplyAsync_1", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApplyAsync_0", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApplyAsync_1", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeOutcome", "(Ljava/lang/Object;Ljava/lang/Throwable;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeRelay", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "supplyAsync", "(Ljava/util/function/Supplier;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "supplyAsync", "(Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runAsync", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runAsync", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNow", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anyOf", "([Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompletedExceptionally", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "obtrudeValue", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "obtrudeException", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumberOfDependents", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minimalCompletionStage", "()Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orTimeout", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeOnTimeout", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "delayedExecutor", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Executor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "delayedExecutor", "(JLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/Executor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "completedStage", "(Ljava/lang/Object;)Ljava/util/concurrent/CompletionStage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "failedStage", "(Ljava/lang/Throwable;)Ljava/util/concurrent/CompletionStage;"));
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "volatile")]
	public Dova.JDK.java.lang.Object result_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$Completion;", "volatile")]
	public Dova.JDK.java.util.concurrent.CompletableFuture.Completion stack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture.Completion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$AltResult;", "static final")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture.AltResult NIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture.AltResult>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool USE_COMMON_POOL_Property
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

	[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "private static final")]
	public static Dova.JDK.java.util.concurrent.Executor ASYNC_POOL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SYNC_Property
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
	public static int ASYNC_Property
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
	public static int NESTED_Property
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

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle RESULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle STACK_Property
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
	public static Dova.JDK.java.lang.invoke.VarHandle NEXT_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CompletableFuture(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CompletableFuture() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
	public CompletableFuture(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Ljava/util/concurrent/CompletableFuture$AltResult;", "static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture.AltResult encodeThrowable(Dova.JDK.java.lang.Throwable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture.AltResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;Ljava/lang/Object;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object encodeThrowable(Dova.JDK.java.lang.Throwable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object get(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object get()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object join()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture copy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage handle_0(Dova.JDK.java.util.function.BiFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture handle_1(Dova.JDK.java.util.function.BiFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool complete(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;", "public static transient")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture allOf(JavaArray<Dova.JDK.java.util.concurrent.CompletableFuture> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDone()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Z", "public")]
	public bool cancel(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isCancelled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Z", "public")]
	public bool completeExceptionally(Dova.JDK.java.lang.Throwable arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenAccept_0(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenAccept_1(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture whenCompleteAsync_0(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage whenCompleteAsync_1(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture whenCompleteAsync_0(Dova.JDK.java.util.function.BiConsumer arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage whenCompleteAsync_1(Dova.JDK.java.util.function.BiConsumer arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenCompose_0(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenCompose_1(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Ljava/util/concurrent/CompletableFuture;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture failedFuture(Dova.JDK.java.lang.Throwable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenApply_0(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenApply_1(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/concurrent/CompletableFuture;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture completedFuture(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture whenComplete_0(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage whenComplete_1(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture completeAsync(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture completeAsync(Dova.JDK.java.util.function.Supplier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture$Completion;)Z", "final")]
	public bool tryPushStack(Dova.JDK.java.util.concurrent.CompletableFuture.Completion arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object encodeRelay(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture$Completion;)V", "final")]
	public void pushStack(Dova.JDK.java.util.concurrent.CompletableFuture.Completion arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()V", "final")]
	public void cleanStack()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("()V", "final")]
	public void postComplete()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniApplyNow(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.concurrent.Executor arg1, Dova.JDK.java.util.function.Function arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture newIncompleteFuture()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture$Completion;)V", "final")]
	public void unipush(Dova.JDK.java.util.concurrent.CompletableFuture.Completion arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object encodeValue(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniAcceptNow(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.concurrent.Executor arg1, Dova.JDK.java.util.function.Consumer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/concurrent/Executor;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniRunNow(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.concurrent.Executor arg1, Dova.JDK.java.lang.Runnable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "final")]
	public bool internalComplete(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;Ljava/lang/Object;)Z", "final")]
	public bool completeThrowable(Dova.JDK.java.lang.Throwable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Z", "final")]
	public bool completeThrowable(Dova.JDK.java.lang.Throwable arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture$UniWhenComplete;)Z", "final")]
	public bool uniWhenComplete(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.concurrent.CompletableFuture.UniWhenComplete arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "final")]
	public bool completeValue(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/concurrent/CompletableFuture$UniHandle;)Z", "final")]
	public bool uniHandle(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.BiFunction arg1, Dova.JDK.java.util.concurrent.CompletableFuture.UniHandle arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/Function;Ljava/util/concurrent/CompletableFuture$UniExceptionally;)Z", "final")]
	public bool uniExceptionally(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.concurrent.CompletableFuture.UniExceptionally arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture toCompletableFuture()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;I)Ljava/util/concurrent/CompletableFuture;", "final")]
	public Dova.JDK.java.util.concurrent.CompletableFuture postFire(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;I)Ljava/util/concurrent/CompletableFuture;", "final")]
	public Dova.JDK.java.util.concurrent.CompletableFuture postFire(Dova.JDK.java.util.concurrent.CompletableFuture arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture$BiCompletion;)V", "final")]
	public void bipush(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/concurrent/CompletableFuture$BiApply;)Z", "final")]
	public bool biApply(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BiFunction arg2, Dova.JDK.java.util.concurrent.CompletableFuture.BiApply arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Z", "final")]
	public bool completeNull()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture$BiAccept;)Z", "final")]
	public bool biAccept(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BiConsumer arg2, Dova.JDK.java.util.concurrent.CompletableFuture.BiAccept arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Runnable;Ljava/util/concurrent/CompletableFuture$BiRun;)Z", "final")]
	public bool biRun(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Runnable arg2, Dova.JDK.java.util.concurrent.CompletableFuture.BiRun arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/util/concurrent/CompletableFuture;II)Ljava/util/concurrent/CompletableFuture;", "static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture andTree(JavaArray<Dova.JDK.java.util.concurrent.CompletableFuture> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture$BiCompletion;)V", "final")]
	public void orpush(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/Executor;", "public")]
	public Dova.JDK.java.util.concurrent.Executor defaultExecutor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;", "static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture asyncSupplyStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.function.Supplier arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)Ljava/util/concurrent/Executor;", "static")]
	public static Dova.JDK.java.util.concurrent.Executor screenExecutor(Dova.JDK.java.util.concurrent.Executor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture asyncRunStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object waitingGet(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object reportGet(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object timedGet(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object reportJoin(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniApplyStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniAcceptStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniRunStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture biApplyStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletionStage arg1, Dova.JDK.java.util.function.BiFunction arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture biAcceptStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletionStage arg1, Dova.JDK.java.util.function.BiConsumer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture biRunStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletionStage arg1, Dova.JDK.java.lang.Runnable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture orApplyStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletionStage arg1, Dova.JDK.java.util.function.Function arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture orAcceptStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletionStage arg1, Dova.JDK.java.util.function.Consumer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture orRunStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletionStage arg1, Dova.JDK.java.lang.Runnable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniComposeStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniWhenCompleteStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.function.BiConsumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniHandleStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.function.BiFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniExceptionallyStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture uniComposeExceptionallyStage(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;", "private static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture uniCopyStage(Dova.JDK.java.util.concurrent.CompletableFuture arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture$MinimalStage;", "private")]
	public Dova.JDK.java.util.concurrent.CompletableFuture.MinimalStage uniAsMinimalStage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture.MinimalStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyComposeAsync_0(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture exceptionallyComposeAsync_1(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyComposeAsync_0(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture exceptionallyComposeAsync_1(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture exceptionallyCompose_0(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyCompose_1(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyAsync_0(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture exceptionallyAsync_1(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyAsync_0(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture exceptionallyAsync_1(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture exceptionally_0(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage exceptionally_1(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage handleAsync_0(Dova.JDK.java.util.function.BiFunction arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture handleAsync_1(Dova.JDK.java.util.function.BiFunction arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture handleAsync_0(Dova.JDK.java.util.function.BiFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage handleAsync_1(Dova.JDK.java.util.function.BiFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenComposeAsync_0(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenComposeAsync_1(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenComposeAsync_0(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[101], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenComposeAsync_1(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage runAfterEitherAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture runAfterEitherAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture runAfterEitherAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage runAfterEitherAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage runAfterEither_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture runAfterEither_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage acceptEitherAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture acceptEitherAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture acceptEitherAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[111], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage acceptEitherAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[112], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage acceptEither_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture acceptEither_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage applyToEitherAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture applyToEitherAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage applyToEitherAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture applyToEitherAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage applyToEither_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[119], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture applyToEither_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture runAfterBothAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage runAfterBothAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture runAfterBothAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage runAfterBothAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[124], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture runAfterBoth_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[125], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage runAfterBoth_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[126], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenAcceptBothAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[127], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBothAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[128], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenAcceptBothAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[129], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBothAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenAcceptBoth_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[131], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBoth_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenCombineAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[133], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenCombineAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenCombineAsync_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[135], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenCombineAsync_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[136], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenCombine_0(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[137], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenCombine_1(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[138], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenRunAsync_0(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[139], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenRunAsync_1(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[140], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenRunAsync_0(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[141], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenRunAsync_1(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[142], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenRun_0(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[143], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenRun_1(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[144], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenAcceptAsync_0(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[145], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptAsync_1(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[146], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptAsync_0(Dova.JDK.java.util.function.Consumer arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[147], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenAcceptAsync_1(Dova.JDK.java.util.function.Consumer arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[148], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenApplyAsync_0(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[149], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenApplyAsync_1(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[150], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
	public Dova.JDK.java.util.concurrent.CompletionStage thenApplyAsync_0(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[151], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture thenApplyAsync_1(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[152], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Throwable;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object encodeOutcome(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[153], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "final")]
	public bool completeRelay(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[154], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture supplyAsync(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[155], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture supplyAsync(Dova.JDK.java.util.function.Supplier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[156], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture runAsync(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.util.concurrent.Executor arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[157], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture runAsync(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[158], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getNow(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[159], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;", "public static transient")]
	public static Dova.JDK.java.util.concurrent.CompletableFuture anyOf(JavaArray<Dova.JDK.java.util.concurrent.CompletableFuture> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[160], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isCompletedExceptionally()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[161]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void obtrudeValue(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[162], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
	public void obtrudeException(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[163], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNumberOfDependents()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[164]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public")]
	public Dova.JDK.java.util.concurrent.CompletionStage minimalCompletionStage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[165]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture orTimeout(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[166], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/CompletableFuture;", "public")]
	public Dova.JDK.java.util.concurrent.CompletableFuture completeOnTimeout(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[167], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Executor;", "public static")]
	public static Dova.JDK.java.util.concurrent.Executor delayedExecutor(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[168], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/Executor;", "public static")]
	public static Dova.JDK.java.util.concurrent.Executor delayedExecutor(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1, Dova.JDK.java.util.concurrent.Executor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[169], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/concurrent/CompletionStage;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletionStage completedStage(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[170], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Ljava/util/concurrent/CompletionStage;", "public static")]
	public static Dova.JDK.java.util.concurrent.CompletionStage failedStage(Dova.JDK.java.lang.Throwable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[171], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$Completion;", "abstract static")]
	public partial class Completion
		: Dova.JDK.java.util.concurrent.ForkJoinTask
		, Dova.JDK.java.lang.Runnable
		, Dova.JDK.java.util.concurrent.CompletableFuture.AsynchronousCompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Completion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$Completion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Ljava/util/concurrent/CompletableFuture$Completion;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exec", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawResult", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawResult", "(Ljava/lang/Void;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawResult_0", "()Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawResult_1", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$Completion;", "volatile")]
		public Dova.JDK.java.util.concurrent.CompletableFuture.Completion next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture.Completion>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Completion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Completion() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$Completion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public final")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool exec()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "abstract")]
		public bool isLive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void setRawResult(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Void;)V", "public final")]
		public void setRawResult(Dova.JDK.java.lang.Void arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Void;", "public final")]
		public Dova.JDK.java.lang.Void getRawResult_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object getRawResult_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "abstract")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$AltResult;", "static final")]
	public partial class AltResult
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AltResult()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$AltResult;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ex", "Ljava/lang/Throwable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Throwable;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/Throwable;", "final")]
		public Dova.JDK.java.lang.Throwable ex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AltResult(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "")]
		public AltResult(Dova.JDK.java.lang.Throwable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$AltResult;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniApply;", "static final")]
	public partial class UniApply
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniApply()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniApply;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/Function;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "")]
		public Dova.JDK.java.util.function.Function fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniApply(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V", "")]
		public UniApply(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.function.Function arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniApply;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniAccept;", "static final")]
	public partial class UniAccept
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniAccept()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniAccept;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/Consumer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "")]
		public Dova.JDK.java.util.function.Consumer fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniAccept(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Consumer;)V", "")]
		public UniAccept(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.function.Consumer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniAccept;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniRun;", "static final")]
	public partial class UniRun
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniRun()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniRun;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/lang/Runnable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "")]
		public Dova.JDK.java.lang.Runnable fn_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniRun(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/lang/Runnable;)V", "")]
		public UniRun(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.lang.Runnable arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniRun;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniWhenComplete;", "static final")]
	public partial class UniWhenComplete
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniWhenComplete()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniWhenComplete;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/BiConsumer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/BiConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/BiConsumer;", "")]
		public Dova.JDK.java.util.function.BiConsumer fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniWhenComplete(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/BiConsumer;)V", "")]
		public UniWhenComplete(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.function.BiConsumer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniWhenComplete;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniHandle;", "static final")]
	public partial class UniHandle
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniHandle()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniHandle;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/BiFunction;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/BiFunction;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/BiFunction;", "")]
		public Dova.JDK.java.util.function.BiFunction fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniHandle(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/BiFunction;)V", "")]
		public UniHandle(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.function.BiFunction arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniHandle;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniExceptionally;", "static final")]
	public partial class UniExceptionally
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniExceptionally()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniExceptionally;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/Function;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "")]
		public Dova.JDK.java.util.function.Function fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniExceptionally(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V", "")]
		public UniExceptionally(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.function.Function arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniExceptionally;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniComposeExceptionally;", "static final")]
	public partial class UniComposeExceptionally
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniComposeExceptionally()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniComposeExceptionally;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/Function;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "")]
		public Dova.JDK.java.util.function.Function fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniComposeExceptionally(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V", "")]
		public UniComposeExceptionally(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.function.Function arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniComposeExceptionally;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniRelay;", "static final")]
	public partial class UniRelay
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniRelay()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniRelay;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniRelay(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;)V", "")]
		public UniRelay(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniRelay;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$MinimalStage;", "static final")]
	public partial class MinimalStage
		: Dova.JDK.java.util.concurrent.CompletableFuture
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MinimalStage()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$MinimalStage;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "join", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handle", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDone", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "(Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCancelled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeExceptionally", "(Ljava/lang/Throwable;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAccept", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenCompleteAsync", "(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenCompleteAsync", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCompose", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApply", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whenComplete", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeAsync", "(Ljava/util/function/Supplier;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeAsync", "(Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newIncompleteFuture", "()Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCompletableFuture", "()Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyComposeAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyComposeAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyCompose", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionallyAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionally", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAsync", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAsync", "(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenComposeAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenComposeAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterEither", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyToEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runAfterBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenCombine", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRunAsync", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRunAsync", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenRun", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptAsync", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenAcceptAsync", "(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApplyAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thenApplyAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNow", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompletedExceptionally", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "obtrudeValue", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "obtrudeException", "(Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumberOfDependents", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orTimeout", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeOnTimeout", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MinimalStage(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public MinimalStage() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
		public MinimalStage(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$MinimalStage;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object get()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object get(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object join()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage handle(Dova.JDK.java.util.function.BiFunction arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool complete(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDone()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Z)Z", "public")]
		public bool cancel(bool arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCancelled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)Z", "public")]
		public bool completeExceptionally(Dova.JDK.java.lang.Throwable arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenAccept(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage whenCompleteAsync(Dova.JDK.java.util.function.BiConsumer arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage whenCompleteAsync(Dova.JDK.java.util.function.BiConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenCompose(Dova.JDK.java.util.function.Function arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenApply(Dova.JDK.java.util.function.Function arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage whenComplete(Dova.JDK.java.util.function.BiConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", "public")]
		public Dova.JDK.java.util.concurrent.CompletableFuture completeAsync(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;", "public")]
		public Dova.JDK.java.util.concurrent.CompletableFuture completeAsync(Dova.JDK.java.util.function.Supplier arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
		public Dova.JDK.java.util.concurrent.CompletableFuture newIncompleteFuture()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
		public Dova.JDK.java.util.concurrent.CompletableFuture toCompletableFuture()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyComposeAsync(Dova.JDK.java.util.function.Function arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyComposeAsync(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyCompose(Dova.JDK.java.util.function.Function arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyAsync(Dova.JDK.java.util.function.Function arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage exceptionallyAsync(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage exceptionally(Dova.JDK.java.util.function.Function arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage handleAsync(Dova.JDK.java.util.function.BiFunction arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage handleAsync(Dova.JDK.java.util.function.BiFunction arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenComposeAsync(Dova.JDK.java.util.function.Function arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenComposeAsync(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage runAfterEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.concurrent.Executor arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage runAfterEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage runAfterEither(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage acceptEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage acceptEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1, Dova.JDK.java.util.concurrent.Executor arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage acceptEither(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Consumer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage applyToEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage applyToEitherAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.concurrent.Executor arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage applyToEither(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.Function arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage runAfterBothAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage runAfterBothAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1, Dova.JDK.java.util.concurrent.Executor arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage runAfterBoth(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.lang.Runnable arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBothAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.concurrent.Executor arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBothAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptBoth(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiConsumer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenCombineAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1, Dova.JDK.java.util.concurrent.Executor arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenCombineAsync(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenCombine(Dova.JDK.java.util.concurrent.CompletionStage arg0, Dova.JDK.java.util.function.BiFunction arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenRunAsync(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenRunAsync(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenRun(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptAsync(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenAcceptAsync(Dova.JDK.java.util.function.Consumer arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenApplyAsync(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.Executor arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", "public volatile")]
		public Dova.JDK.java.util.concurrent.CompletionStage thenApplyAsync(Dova.JDK.java.util.function.Function arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getNow(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompletedExceptionally()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void obtrudeValue(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public void obtrudeException(Dova.JDK.java.lang.Throwable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getNumberOfDependents()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[58]);
			return ret;
		}

		[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/CompletableFuture;", "public")]
		public Dova.JDK.java.util.concurrent.CompletableFuture orTimeout(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/CompletableFuture;", "public")]
		public Dova.JDK.java.util.concurrent.CompletableFuture completeOnTimeout(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniCompose;", "static final")]
	public partial class UniCompose
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniCompose()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniCompose;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/Function;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "")]
		public Dova.JDK.java.util.function.Function fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniCompose(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V", "")]
		public UniCompose(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.function.Function arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniCompose;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$CoCompletion;", "static final")]
	public partial class CoCompletion
		: Dova.JDK.java.util.concurrent.CompletableFuture.Completion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CoCompletion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$CoCompletion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "base", "Ljava/util/concurrent/CompletableFuture$BiCompletion;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/CompletableFuture$BiCompletion;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$BiCompletion;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion @base_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CoCompletion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture$BiCompletion;)V", "")]
		public CoCompletion(Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$CoCompletion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "final")]
		public bool isLive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$BiCompletion;", "abstract static")]
	public partial class BiCompletion
		: Dova.JDK.java.util.concurrent.CompletableFuture.UniCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BiCompletion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$BiCompletion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "snd", "Ljava/util/concurrent/CompletableFuture;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;)V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture snd_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BiCompletion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;)V", "")]
		public BiCompletion(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$BiCompletion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$BiApply;", "static final")]
	public partial class BiApply
		: Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BiApply()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$BiApply;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/BiFunction;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/BiFunction;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/BiFunction;", "")]
		public Dova.JDK.java.util.function.BiFunction fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BiApply(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/BiFunction;)V", "")]
		public BiApply(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3, Dova.JDK.java.util.function.BiFunction arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$BiApply;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$BiAccept;", "static final")]
	public partial class BiAccept
		: Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BiAccept()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$BiAccept;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/BiConsumer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/BiConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/BiConsumer;", "")]
		public Dova.JDK.java.util.function.BiConsumer fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BiAccept(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/BiConsumer;)V", "")]
		public BiAccept(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3, Dova.JDK.java.util.function.BiConsumer arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$BiAccept;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$BiRun;", "static final")]
	public partial class BiRun
		: Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BiRun()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$BiRun;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/lang/Runnable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "")]
		public Dova.JDK.java.lang.Runnable fn_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BiRun(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/lang/Runnable;)V", "")]
		public BiRun(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3, Dova.JDK.java.lang.Runnable arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$BiRun;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$BiRelay;", "static final")]
	public partial class BiRelay
		: Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BiRelay()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$BiRelay;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BiRelay(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;)V", "")]
		public BiRelay(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$BiRelay;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$OrApply;", "static final")]
	public partial class OrApply
		: Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OrApply()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$OrApply;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/Function;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "")]
		public Dova.JDK.java.util.function.Function fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OrApply(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Function;)V", "")]
		public OrApply(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3, Dova.JDK.java.util.function.Function arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$OrApply;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$OrAccept;", "static final")]
	public partial class OrAccept
		: Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OrAccept()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$OrAccept;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/Consumer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "")]
		public Dova.JDK.java.util.function.Consumer fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OrAccept(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Consumer;)V", "")]
		public OrAccept(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3, Dova.JDK.java.util.function.Consumer arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$OrAccept;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$OrRun;", "static final")]
	public partial class OrRun
		: Dova.JDK.java.util.concurrent.CompletableFuture.BiCompletion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OrRun()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$OrRun;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/lang/Runnable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "")]
		public Dova.JDK.java.lang.Runnable fn_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OrRun(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;Ljava/lang/Runnable;)V", "")]
		public OrRun(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3, Dova.JDK.java.lang.Runnable arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$OrRun;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$AsyncSupply;", "static final")]
	public partial class AsyncSupply
		: Dova.JDK.java.util.concurrent.ForkJoinTask
		, Dova.JDK.java.lang.Runnable
		, Dova.JDK.java.util.concurrent.CompletableFuture.AsynchronousCompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AsyncSupply()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$AsyncSupply;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dep", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/util/function/Supplier;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Supplier;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exec", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawResult", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawResult", "(Ljava/lang/Void;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawResult_0", "()Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawResult_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture dep_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Supplier;", "")]
		public Dova.JDK.java.util.function.Supplier fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AsyncSupply(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/util/function/Supplier;)V", "")]
		public AsyncSupply(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.util.function.Supplier arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$AsyncSupply;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool exec()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void setRawResult(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Void;)V", "public final")]
		public void setRawResult(Dova.JDK.java.lang.Void arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Void;", "public final")]
		public Dova.JDK.java.lang.Void getRawResult_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object getRawResult_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$AsyncRun;", "static final")]
	public partial class AsyncRun
		: Dova.JDK.java.util.concurrent.ForkJoinTask
		, Dova.JDK.java.lang.Runnable
		, Dova.JDK.java.util.concurrent.CompletableFuture.AsynchronousCompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AsyncRun()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$AsyncRun;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dep", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fn", "Ljava/lang/Runnable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/CompletableFuture;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exec", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawResult", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawResult", "(Ljava/lang/Void;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawResult_0", "()Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawResult_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture dep_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "")]
		public Dova.JDK.java.lang.Runnable fn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AsyncRun(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/lang/Runnable;)V", "")]
		public AsyncRun(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.lang.Runnable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$AsyncRun;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool exec()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void setRawResult(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Void;)V", "public final")]
		public void setRawResult(Dova.JDK.java.lang.Void arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Void;", "public final")]
		public Dova.JDK.java.lang.Void getRawResult_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object getRawResult_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$Signaller;", "static final")]
	public partial class Signaller
		: Dova.JDK.java.util.concurrent.CompletableFuture.Completion
		, Dova.JDK.java.util.concurrent.ForkJoinPool.ManagedBlocker
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Signaller()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$Signaller;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nanos", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deadline", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interruptible", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interrupted", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Ljava/lang/Thread;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZJJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "block", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReleasable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("J", "")]
		public long nanos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("J", "final")]
		public long deadline_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool interruptible_Property
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

		[JniSignatureAttribute("Z", "")]
		public bool interrupted_Property
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

		[JniSignatureAttribute("Ljava/lang/Thread;", "volatile")]
		public Dova.JDK.java.lang.Thread thread_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Signaller(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZJJ)V", "")]
		public Signaller(bool arg0, long arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$Signaller;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool block()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool isLive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isReleasable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$AnyOf;", "static")]
	public partial class AnyOf
		: Dova.JDK.java.util.concurrent.CompletableFuture.Completion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnyOf()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$AnyOf;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dep", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "src", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "srcs", "[Ljava/util/concurrent/CompletableFuture;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;[Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFire", "(I)Ljava/util/concurrent/CompletableFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture dep_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture src_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/util/concurrent/CompletableFuture;", "")]
		public JavaArray<Dova.JDK.java.util.concurrent.CompletableFuture> srcs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.concurrent.CompletableFuture>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnyOf(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;[Ljava/util/concurrent/CompletableFuture;)V", "")]
		public AnyOf(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, JavaArray<Dova.JDK.java.util.concurrent.CompletableFuture> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$AnyOf;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "final")]
		public bool isLive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tryFire(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$Canceller;", "static final")]
	public partial class Canceller
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.function.BiConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Canceller()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$Canceller;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "f", "Ljava/util/concurrent/Future;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Future;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Future;", "final")]
		public Dova.JDK.java.util.concurrent.Future f_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Canceller(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Future;)V", "")]
		public Canceller(Dova.JDK.java.util.concurrent.Future arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$Canceller;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Throwable;)V", "public")]
		public void accept(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public volatile")]
		public void accept(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$Timeout;", "static final")]
	public partial class Timeout
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Timeout()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$Timeout;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "f", "Ljava/util/concurrent/CompletableFuture;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture f_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Timeout(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;)V", "")]
		public Timeout(Dova.JDK.java.util.concurrent.CompletableFuture arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$Timeout;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$Delayer;", "static final")]
	public partial class Delayer
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Delayer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$Delayer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "delayer", "Ljava/util/concurrent/ScheduledThreadPoolExecutor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "delay", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ScheduledThreadPoolExecutor;", "static final")]
		public static Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor delayer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Delayer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Delayer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$Delayer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "static")]
		public static Dova.JDK.java.util.concurrent.ScheduledFuture delay(Dova.JDK.java.lang.Runnable arg0, long arg1, Dova.JDK.java.util.concurrent.TimeUnit arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$Delayer$DaemonThreadFactory;", "static final")]
		public partial class DaemonThreadFactory
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.concurrent.ThreadFactory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DaemonThreadFactory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$Delayer$DaemonThreadFactory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DaemonThreadFactory(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public DaemonThreadFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$Delayer$DaemonThreadFactory;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/lang/Thread;", "public")]
			public Dova.JDK.java.lang.Thread newThread(Dova.JDK.java.lang.Runnable arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$DelayedCompleter;", "static final")]
	public partial class DelayedCompleter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DelayedCompleter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$DelayedCompleter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "f", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "u", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/CompletableFuture;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture f_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object u_Property
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
		public DelayedCompleter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CompletableFuture;Ljava/lang/Object;)V", "")]
		public DelayedCompleter(Dova.JDK.java.util.concurrent.CompletableFuture arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$DelayedCompleter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$DelayedExecutor;", "static final")]
	public partial class DelayedExecutor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.Executor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DelayedExecutor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$DelayedExecutor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delay", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unit", "Ljava/util/concurrent/TimeUnit;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/Executor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/Executor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Ljava/lang/Runnable;)V"));
		}

		[JniSignatureAttribute("J", "final")]
		public long delay_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/TimeUnit;", "final")]
		public Dova.JDK.java.util.concurrent.TimeUnit unit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.TimeUnit>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "final")]
		public Dova.JDK.java.util.concurrent.Executor executor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DelayedExecutor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/Executor;)V", "")]
		public DelayedExecutor(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1, Dova.JDK.java.util.concurrent.Executor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$DelayedExecutor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public")]
		public void execute(Dova.JDK.java.lang.Runnable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$ThreadPerTaskExecutor;", "static final")]
	public partial class ThreadPerTaskExecutor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.Executor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ThreadPerTaskExecutor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$ThreadPerTaskExecutor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Ljava/lang/Runnable;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ThreadPerTaskExecutor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ThreadPerTaskExecutor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$ThreadPerTaskExecutor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public")]
		public void execute(Dova.JDK.java.lang.Runnable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$TaskSubmitter;", "static final")]
	public partial class TaskSubmitter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TaskSubmitter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$TaskSubmitter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/Executor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "action", "Ljava/lang/Runnable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "final")]
		public Dova.JDK.java.util.concurrent.Executor executor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "final")]
		public Dova.JDK.java.lang.Runnable action_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TaskSubmitter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/lang/Runnable;)V", "")]
		public TaskSubmitter(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.lang.Runnable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$TaskSubmitter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$UniCompletion;", "abstract static")]
	public partial class UniCompletion
		: Dova.JDK.java.util.concurrent.CompletableFuture.Completion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniCompletion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$UniCompletion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/Executor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dep", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "src", "Ljava/util/concurrent/CompletableFuture;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "claim", "()Z"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "")]
		public Dova.JDK.java.util.concurrent.Executor executor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture dep_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture src_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniCompletion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/CompletableFuture;)V", "")]
		public UniCompletion(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.java.util.concurrent.CompletableFuture arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/CompletableFuture$UniCompletion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "final")]
		public bool isLive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool claim()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture$AsynchronousCompletionTask;", "public abstract static interface")]
	public partial interface AsynchronousCompletionTask
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static AsynchronousCompletionTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/CompletableFuture$AsynchronousCompletionTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}
}
