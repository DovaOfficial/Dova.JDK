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

[JniSignatureAttribute("Ljava/util/stream/ReferencePipeline;", "abstract")]
public partial class ReferencePipeline
	: Dova.JDK.java.util.stream.AbstractPipeline
	, Dova.JDK.java.util.stream.Stream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReferencePipeline()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReferencePipeline;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/AbstractPipeline;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;IZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Supplier;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "min", "(Ljava/util/Comparator;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "max", "(Ljava/util/Comparator;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljava/util/stream/PipelineHelper;Ljava/util/function/Supplier;Z)Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "(Ljava/util/function/IntFunction;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "map", "(Ljava/util/function/Function;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collect", "(Ljava/util/stream/Collector;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collect", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toList", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "limit", "(J)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "anyMatch", "(Ljava/util/function/Predicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flatMap", "(Ljava/util/function/Function;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAny", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peek", "(Ljava/util/function/Consumer;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(Ljava/util/function/BinaryOperator;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "distinct", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findFirst", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allMatch", "(Ljava/util/function/Predicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sorted", "(Ljava/util/Comparator;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sorted", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachOrdered", "(Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputShape", "()Ljava/util/stream/StreamShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySpliterator", "(Ljava/util/function/Supplier;)Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachWithCancel", "(Ljava/util/Spliterator;Ljava/util/stream/Sink;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "evaluateToNode", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;ZLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNodeBuilder", "(JLjava/util/function/IntFunction;)Ljava/util/stream/Node$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unordered_0", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unordered_1", "()Ljava/util/stream/BaseStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flatMapToInt", "(Ljava/util/function/Function;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flatMapToDouble", "(Ljava/util/function/Function;)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flatMapToLong", "(Ljava/util/function/Function;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapMulti", "(Ljava/util/function/BiConsumer;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapMultiToInt", "(Ljava/util/function/BiConsumer;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapMultiToLong", "(Ljava/util/function/BiConsumer;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapMultiToDouble", "(Ljava/util/function/BiConsumer;)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "takeWhile", "(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropWhile", "(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noneMatch", "(Ljava/util/function/Predicate;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ReferencePipeline(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;I)V", "")]
	public ReferencePipeline(Dova.JDK.java.util.stream.AbstractPipeline arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator;IZ)V", "")]
	public ReferencePipeline(Dova.JDK.java.util.Spliterator arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;IZ)V", "")]
	public ReferencePipeline(Dova.JDK.java.util.function.Supplier arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/stream/ReferencePipeline;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/Optional;", "public final")]
	public Dova.JDK.java.util.Optional min(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/Optional;", "public final")]
	public Dova.JDK.java.util.Optional max(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/function/Supplier;Z)Ljava/util/Spliterator;", "final")]
	public Dova.JDK.java.util.Spliterator wrap(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.function.Supplier arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", "public final")]
	public JavaArray<Dova.JDK.java.lang.Object> toArray(Dova.JDK.java.util.function.IntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public final")]
	public JavaArray<Dova.JDK.java.lang.Object> toArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public final")]
	public Dova.JDK.java.util.Iterator iterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream map(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Collector;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object collect(Dova.JDK.java.util.stream.Collector arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object collect(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.function.BiConsumer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List toList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()J", "public final")]
	public long count()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream limit(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream filter(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "public final")]
	public bool anyMatch(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream flatMap(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
	public void forEach(Dova.JDK.java.util.function.Consumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public final")]
	public Dova.JDK.java.util.Optional findAny()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream skip(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream peek(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object reduce(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.BinaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BinaryOperator;)Ljava/util/Optional;", "public final")]
	public Dova.JDK.java.util.Optional reduce(Dova.JDK.java.util.function.BinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object reduce(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.BiFunction arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream distinct()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public final")]
	public Dova.JDK.java.util.Optional findFirst()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "public final")]
	public bool allMatch(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream sorted(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream sorted()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
	public void forEachOrdered(Dova.JDK.java.util.function.Consumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/stream/StreamShape;", "final")]
	public Dova.JDK.java.util.stream.StreamShape getOutputShape()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.StreamShape>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/Spliterator;", "final")]
	public Dova.JDK.java.util.Spliterator lazySpliterator(Dova.JDK.java.util.function.Supplier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/Sink;)Z", "final")]
	public bool forEachWithCancel(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.Sink arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;ZLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "final")]
	public Dova.JDK.java.util.stream.Node evaluateToNode(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, bool arg2, Dova.JDK.java.util.function.IntFunction arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/function/IntFunction;)Ljava/util/stream/Node$Builder;", "final")]
	public Dova.JDK.java.util.stream.Node.Builder makeNodeBuilder(long arg0, Dova.JDK.java.util.function.IntFunction arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream unordered_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
	public Dova.JDK.java.util.stream.BaseStream unordered_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream mapToInt(Dova.JDK.java.util.function.ToIntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToLongFunction;)Ljava/util/stream/LongStream;", "public final")]
	public Dova.JDK.java.util.stream.LongStream mapToLong(Dova.JDK.java.util.function.ToLongFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/DoubleStream;", "public final")]
	public Dova.JDK.java.util.stream.DoubleStream mapToDouble(Dova.JDK.java.util.function.ToDoubleFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream flatMapToInt(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/stream/DoubleStream;", "public final")]
	public Dova.JDK.java.util.stream.DoubleStream flatMapToDouble(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/stream/LongStream;", "public final")]
	public Dova.JDK.java.util.stream.LongStream flatMapToLong(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream mapMulti(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/stream/IntStream;", "public final")]
	public Dova.JDK.java.util.stream.IntStream mapMultiToInt(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/stream/LongStream;", "public final")]
	public Dova.JDK.java.util.stream.LongStream mapMultiToLong(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiConsumer;)Ljava/util/stream/DoubleStream;", "public final")]
	public Dova.JDK.java.util.stream.DoubleStream mapMultiToDouble(Dova.JDK.java.util.function.BiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream takeWhile(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;", "public final")]
	public Dova.JDK.java.util.stream.Stream dropWhile(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "public final")]
	public bool noneMatch(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljava/util/stream/ReferencePipeline$StatefulOp;", "abstract static")]
	public partial class StatefulOp
		: Dova.JDK.java.util.stream.ReferencePipeline
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StatefulOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReferencePipeline$StatefulOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/StreamShape;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opIsStateful", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opEvaluateParallel", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;)Ljava/util/stream/Node;"));
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

		public override string GetJavaClassSignature() => "Ljava/util/stream/ReferencePipeline$StatefulOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "final")]
		public bool opIsStateful()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;)Ljava/util/stream/Node;", "abstract")]
		public Dova.JDK.java.util.stream.Node opEvaluateParallel(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
		public Dova.JDK.java.util.stream.BaseStream unordered()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/ReferencePipeline$StatelessOp;", "abstract static")]
	public partial class StatelessOp
		: Dova.JDK.java.util.stream.ReferencePipeline
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StatelessOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReferencePipeline$StatelessOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/StreamShape;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opIsStateful", "()Z"));
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

		public override string GetJavaClassSignature() => "Ljava/util/stream/ReferencePipeline$StatelessOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "final")]
		public bool opIsStateful()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
		public Dova.JDK.java.util.stream.BaseStream unordered()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/ReferencePipeline$Head;", "static")]
	public partial class Head
		: Dova.JDK.java.util.stream.ReferencePipeline
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Head()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReferencePipeline$Head;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Supplier;IZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachOrdered", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opIsStateful", "()Z"));
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

		public override string GetJavaClassSignature() => "Ljava/util/stream/ReferencePipeline$Head;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEachOrdered(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Z", "final")]
		public bool opIsStateful()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/util/stream/Sink;)Ljava/util/stream/Sink;", "final")]
		public Dova.JDK.java.util.stream.Sink opWrapSink(int arg0, Dova.JDK.java.util.stream.Sink arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Sink>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
		public Dova.JDK.java.util.stream.BaseStream unordered()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
		}
	}
}
