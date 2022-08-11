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

namespace Dova.JDK.java.util.stream;

[JniSignatureAttribute("Ljava/util/stream/IntPipeline;", "abstract")]
public partial class IntPipeline
	: Dova.JDK.java.util.stream.AbstractPipeline
	, Dova.JDK.java.util.stream.IntStream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IntPipeline()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/IntPipeline;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/AbstractPipeline;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;IZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Supplier;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "min", "()Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "max", "()Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljava/util/stream/PipelineHelper;Ljava/util/function/Supplier;Z)Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator_0", "()Ljava/util/PrimitiveIterator$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator_1", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "map", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collect", "(Ljava/util/function/Supplier;Ljava/util/function/ObjIntConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "limit", "(J)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "anyMatch", "(Ljava/util/function/IntPredicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flatMap", "(Ljava/util/function/IntFunction;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/IntConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAny", "()Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peek", "(Ljava/util/function/IntConsumer;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sum", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(ILjava/util/function/IntBinaryOperator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(Ljava/util/function/IntBinaryOperator;)Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parallel", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "distinct", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findFirst", "()Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allMatch", "(Ljava/util/function/IntPredicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sorted", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToObj", "(Ljava/util/function/IntFunction;I)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToObj", "(Ljava/util/function/IntFunction;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequential", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "adapt", "(Ljava/util/Spliterator;)Ljava/util/Spliterator$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "adapt", "(Ljava/util/stream/Sink;)Ljava/util/function/IntConsumer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachOrdered", "(Ljava/util/function/IntConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputShape", "()Ljava/util/stream/StreamShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySpliterator_0", "(Ljava/util/function/Supplier;)Ljava/util/Spliterator$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySpliterator_1", "(Ljava/util/function/Supplier;)Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachWithCancel", "(Ljava/util/Spliterator;Ljava/util/stream/Sink;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "evaluateToNode", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;ZLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNodeBuilder", "(JLjava/util/function/IntFunction;)Ljava/util/stream/Node$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unordered_0", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unordered_1", "()Ljava/util/stream/BaseStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToLong", "(Ljava/util/function/IntToLongFunction;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToDouble", "(Ljava/util/function/IntToDoubleFunction;)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapMulti", "(Ljava/util/stream/IntStream$IntMapMultiConsumer;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "takeWhile", "(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropWhile", "(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noneMatch", "(Ljava/util/function/IntPredicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boxed", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asLongStream", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDoubleStream", "()Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "average", "()Ljava/util/OptionalDouble;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "summaryStatistics", "()Ljava/util/IntSummaryStatistics;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IntPipeline(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;I)V", "")]
	public IntPipeline(Dova.JDK.java.util.stream.AbstractPipeline arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator;IZ)V", "")]
	public IntPipeline(Dova.JDK.java.util.Spliterator arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;IZ)V", "")]
	public IntPipeline(Dova.JDK.java.util.function.Supplier arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/stream/IntPipeline;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/OptionalInt;", "public final")]
	public Dova.JDK.java.util.OptionalInt min()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalInt;", "public final")]
	public Dova.JDK.java.util.OptionalInt max()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/function/Supplier;Z)Ljava/util/Spliterator;", "final")]
	public Dova.JDK.java.util.Spliterator wrap(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.function.Supplier arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("()[I", "public final")]
	public JavaArray<int> toArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/PrimitiveIterator$OfInt;", "public final")]
	public Dova.JDK.java.util.PrimitiveIterator.OfInt iterator_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.PrimitiveIterator.OfInt>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public volatile")]
	public Dova.JDK.java.util.Iterator iterator_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream map(Dova.JDK.java.util.function.IntUnaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/ObjIntConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object collect(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.ObjIntConsumer arg1, Dova.JDK.java.util.function.BiConsumer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()J", "public final")]
	public long count()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream limit(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public final")]
	public Dova.JDK.java.util.Spliterator.OfInt spliterator_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
	public Dova.JDK.java.util.Spliterator spliterator_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream filter(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Z", "public final")]
	public bool anyMatch(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/IntFunction;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream flatMap(Dova.JDK.java.util.function.IntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
	public void forEach(Dova.JDK.java.util.function.IntConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalInt;", "public final")]
	public Dova.JDK.java.util.OptionalInt findAny()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream skip(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream peek(Dova.JDK.java.util.function.IntConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int sum()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/util/function/IntBinaryOperator;)I", "public final")]
	public int reduce(int arg0, Dova.JDK.java.util.function.IntBinaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/IntBinaryOperator;)Ljava/util/OptionalInt;", "public final")]
	public Dova.JDK.java.util.OptionalInt reduce(Dova.JDK.java.util.function.IntBinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
	public Dova.JDK.java.util.stream.IntStream parallel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream distinct()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalInt;", "public final")]
	public Dova.JDK.java.util.OptionalInt findFirst()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Z", "public final")]
	public bool allMatch(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream sorted()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntFunction;I)Ljava/util/stream/Stream;", "private")]
	public Dova.JDK.java.util.stream.Stream mapToObj(Dova.JDK.java.util.function.IntFunction arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntFunction;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream mapToObj(Dova.JDK.java.util.function.IntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
	public Dova.JDK.java.util.stream.IntStream sequential()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator$OfInt;", "private static")]
	public static Dova.JDK.java.util.Spliterator.OfInt adapt(Dova.JDK.java.util.Spliterator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Sink;)Ljava/util/function/IntConsumer;", "private static")]
	public static Dova.JDK.java.util.function.IntConsumer adapt(Dova.JDK.java.util.stream.Sink arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntConsumer>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
	public void forEachOrdered(Dova.JDK.java.util.function.IntConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/stream/StreamShape;", "final")]
	public Dova.JDK.java.util.stream.StreamShape getOutputShape()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.StreamShape>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/Spliterator$OfInt;", "final")]
	public Dova.JDK.java.util.Spliterator.OfInt lazySpliterator_0(Dova.JDK.java.util.function.Supplier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/Spliterator;", "volatile")]
	public Dova.JDK.java.util.Spliterator lazySpliterator_1(Dova.JDK.java.util.function.Supplier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/Sink;)Z", "final")]
	public bool forEachWithCancel(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.Sink arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;ZLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "final")]
	public Dova.JDK.java.util.stream.Node evaluateToNode(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, bool arg2, Dova.JDK.java.util.function.IntFunction arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/function/IntFunction;)Ljava/util/stream/Node$Builder;", "final")]
	public Dova.JDK.java.util.stream.Node.Builder makeNodeBuilder(long arg0, Dova.JDK.java.util.function.IntFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream unordered_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
	public Dova.JDK.java.util.stream.BaseStream unordered_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntToLongFunction;)Ljava/util/stream/LongStream;", "public final")]
	public Dova.JDK.java.util.stream.LongStream mapToLong(Dova.JDK.java.util.function.IntToLongFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntToDoubleFunction;)Ljava/util/stream/DoubleStream;", "public final")]
	public Dova.JDK.java.util.stream.DoubleStream mapToDouble(Dova.JDK.java.util.function.IntToDoubleFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/IntStream$IntMapMultiConsumer;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream mapMulti(Dova.JDK.java.util.stream.IntStream.IntMapMultiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream takeWhile(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream dropWhile(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Z", "public final")]
	public bool noneMatch(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream boxed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public final")]
	public Dova.JDK.java.util.stream.LongStream asLongStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/DoubleStream;", "public final")]
	public Dova.JDK.java.util.stream.DoubleStream asDoubleStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalDouble;", "public final")]
	public Dova.JDK.java.util.OptionalDouble average()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalDouble>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/IntSummaryStatistics;", "public final")]
	public Dova.JDK.java.util.IntSummaryStatistics summaryStatistics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.IntSummaryStatistics>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/IntPipeline$StatefulOp;", "abstract static")]
	public partial class StatefulOp
		: Dova.JDK.java.util.stream.IntPipeline
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StatefulOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/IntPipeline$StatefulOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/StreamShape;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parallel", "()Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequential", "()Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opIsStateful", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opEvaluateParallel", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;)Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySpliterator", "(Ljava/util/function/Supplier;)Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unordered", "()Ljava/util/stream/BaseStream;"));
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StatefulOp(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/StreamShape;I)V", "")]
		public StatefulOp(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.stream.StreamShape arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/IntPipeline$StatefulOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Iterator;", "public volatile")]
		public Dova.JDK.java.util.Iterator iterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
		public Dova.JDK.java.util.stream.IntStream parallel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
		public Dova.JDK.java.util.stream.IntStream sequential()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool opIsStateful()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;)Ljava/util/stream/Node;", "abstract")]
		public Dova.JDK.java.util.stream.Node opEvaluateParallel(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/Spliterator;", "volatile")]
		public Dova.JDK.java.util.Spliterator lazySpliterator(Dova.JDK.java.util.function.Supplier arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
		public Dova.JDK.java.util.stream.BaseStream unordered()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/IntPipeline$StatelessOp;", "abstract static")]
	public partial class StatelessOp
		: Dova.JDK.java.util.stream.IntPipeline
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StatelessOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/IntPipeline$StatelessOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/StreamShape;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parallel", "()Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequential", "()Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opIsStateful", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySpliterator", "(Ljava/util/function/Supplier;)Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unordered", "()Ljava/util/stream/BaseStream;"));
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StatelessOp(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/StreamShape;I)V", "")]
		public StatelessOp(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.stream.StreamShape arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/IntPipeline$StatelessOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Iterator;", "public volatile")]
		public Dova.JDK.java.util.Iterator iterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
		public Dova.JDK.java.util.stream.IntStream parallel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
		public Dova.JDK.java.util.stream.IntStream sequential()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool opIsStateful()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/Spliterator;", "volatile")]
		public Dova.JDK.java.util.Spliterator lazySpliterator(Dova.JDK.java.util.function.Supplier arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
		public Dova.JDK.java.util.stream.BaseStream unordered()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/IntPipeline$Head;", "static")]
	public partial class Head
		: Dova.JDK.java.util.stream.IntPipeline
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Head()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/IntPipeline$Head;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Supplier;IZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/IntConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parallel", "()Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequential", "()Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachOrdered", "(Ljava/util/function/IntConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opIsStateful", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySpliterator", "(Ljava/util/function/Supplier;)Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opWrapSink", "(ILjava/util/stream/Sink;)Ljava/util/stream/Sink;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unordered", "()Ljava/util/stream/BaseStream;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Head(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;IZ)V", "")]
		public Head(Dova.JDK.java.util.function.Supplier arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;IZ)V", "")]
		public Head(Dova.JDK.java.util.Spliterator arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/IntPipeline$Head;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Iterator;", "public volatile")]
		public Dova.JDK.java.util.Iterator iterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.IntConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
		public Dova.JDK.java.util.stream.IntStream parallel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
		public Dova.JDK.java.util.stream.IntStream sequential()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
		public void forEachOrdered(Dova.JDK.java.util.function.IntConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool opIsStateful()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/Spliterator;", "volatile")]
		public Dova.JDK.java.util.Spliterator lazySpliterator(Dova.JDK.java.util.function.Supplier arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(ILjava/util/stream/Sink;)Ljava/util/stream/Sink;", "final")]
		public Dova.JDK.java.util.stream.Sink opWrapSink(int arg0, Dova.JDK.java.util.stream.Sink arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Sink>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
		public Dova.JDK.java.util.stream.BaseStream unordered()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
		}
	}
}
