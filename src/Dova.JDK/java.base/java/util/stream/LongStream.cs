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

[JniSignatureAttribute("Ljava/util/stream/LongStream;", "public abstract interface")]
public partial interface LongStream
	: IJavaObject
	, Dova.JDK.java.util.stream.BaseStream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LongStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/LongStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "min", "()Ljava/util/OptionalLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "max", "()Ljava/util/OptionalLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "()[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator_0", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator_1", "()Ljava/util/PrimitiveIterator$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "map", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collect", "(Ljava/util/function/Supplier;Ljava/util/function/ObjLongConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(J)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "([J)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "builder", "()Ljava/util/stream/LongStream$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "concat", "(Ljava/util/stream/LongStream;Ljava/util/stream/LongStream;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "limit", "(J)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "empty", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "anyMatch", "(Ljava/util/function/LongPredicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flatMap", "(Ljava/util/function/LongFunction;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/LongConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAny", "()Ljava/util/OptionalLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peek", "(Ljava/util/function/LongConsumer;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sum", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(Ljava/util/function/LongBinaryOperator;)Ljava/util/OptionalLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(JLjava/util/function/LongBinaryOperator;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "range", "(JJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parallel_0", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parallel_1", "()Ljava/util/stream/BaseStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iterate", "(JLjava/util/function/LongPredicate;Ljava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iterate", "(JLjava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "distinct", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findFirst", "()Ljava/util/OptionalLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allMatch", "(Ljava/util/function/LongPredicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sorted", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generate", "(Ljava/util/function/LongSupplier;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToObj", "(Ljava/util/function/LongFunction;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rangeClosed", "(JJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequential_0", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequential_1", "()Ljava/util/stream/BaseStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachOrdered", "(Ljava/util/function/LongConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToInt", "(Ljava/util/function/LongToIntFunction;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToDouble", "(Ljava/util/function/LongToDoubleFunction;)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapMulti", "(Ljava/util/stream/LongStream$LongMapMultiConsumer;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "takeWhile", "(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropWhile", "(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noneMatch", "(Ljava/util/function/LongPredicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boxed", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDoubleStream", "()Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "average", "()Ljava/util/OptionalDouble;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "summaryStatistics", "()Ljava/util/LongSummaryStatistics;"));
	}

	[JniSignatureAttribute("()Ljava/util/OptionalLong;", "public abstract")]
	Dova.JDK.java.util.OptionalLong min()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalLong>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalLong;", "public abstract")]
	Dova.JDK.java.util.OptionalLong max()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalLong>(ret);
	}

	[JniSignatureAttribute("()[J", "public abstract")]
	JavaArray<long> toArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public volatile")]
	Dova.JDK.java.util.Iterator iterator_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/PrimitiveIterator$OfLong;", "public abstract")]
	Dova.JDK.java.util.PrimitiveIterator.OfLong iterator_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.PrimitiveIterator.OfLong>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream map(Dova.JDK.java.util.function.LongUnaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/ObjLongConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object collect(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.ObjLongConsumer arg1, Dova.JDK.java.util.function.BiConsumer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/LongStream;", "public static")]
	static Dova.JDK.java.util.stream.LongStream of(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("([J)Ljava/util/stream/LongStream;", "public static transient")]
	static Dova.JDK.java.util.stream.LongStream of(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long count()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream$Builder;", "public static")]
	static Dova.JDK.java.util.stream.LongStream.Builder builder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/LongStream;Ljava/util/stream/LongStream;)Ljava/util/stream/LongStream;", "public static")]
	static Dova.JDK.java.util.stream.LongStream concat(Dova.JDK.java.util.stream.LongStream arg0, Dova.JDK.java.util.stream.LongStream arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream limit(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public abstract")]
	Dova.JDK.java.util.Spliterator.OfLong spliterator_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
	Dova.JDK.java.util.Spliterator spliterator_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream filter(Dova.JDK.java.util.function.LongPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public static")]
	static Dova.JDK.java.util.stream.LongStream empty()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongPredicate;)Z", "public abstract")]
	bool anyMatch(Dova.JDK.java.util.function.LongPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/LongFunction;)Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream flatMap(Dova.JDK.java.util.function.LongFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public abstract")]
	void forEach(Dova.JDK.java.util.function.LongConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalLong;", "public abstract")]
	Dova.JDK.java.util.OptionalLong findAny()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalLong>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream skip(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream peek(Dova.JDK.java.util.function.LongConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long sum()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/LongBinaryOperator;)Ljava/util/OptionalLong;", "public abstract")]
	Dova.JDK.java.util.OptionalLong reduce(Dova.JDK.java.util.function.LongBinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalLong>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/function/LongBinaryOperator;)J", "public abstract")]
	long reduce(long arg0, Dova.JDK.java.util.function.LongBinaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJ)Ljava/util/stream/LongStream;", "public static")]
	static Dova.JDK.java.util.stream.LongStream range(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream parallel_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
	Dova.JDK.java.util.stream.BaseStream parallel_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/function/LongPredicate;Ljava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;", "public static")]
	static Dova.JDK.java.util.stream.LongStream iterate(long arg0, Dova.JDK.java.util.function.LongPredicate arg1, Dova.JDK.java.util.function.LongUnaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;", "public static")]
	static Dova.JDK.java.util.stream.LongStream iterate(long arg0, Dova.JDK.java.util.function.LongUnaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream distinct()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalLong;", "public abstract")]
	Dova.JDK.java.util.OptionalLong findFirst()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalLong>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongPredicate;)Z", "public abstract")]
	bool allMatch(Dova.JDK.java.util.function.LongPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream sorted()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongSupplier;)Ljava/util/stream/LongStream;", "public static")]
	static Dova.JDK.java.util.stream.LongStream generate(Dova.JDK.java.util.function.LongSupplier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongFunction;)Ljava/util/stream/Stream;", "public abstract")]
	Dova.JDK.java.util.stream.Stream mapToObj(Dova.JDK.java.util.function.LongFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(JJ)Ljava/util/stream/LongStream;", "public static")]
	static Dova.JDK.java.util.stream.LongStream rangeClosed(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream sequential_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
	Dova.JDK.java.util.stream.BaseStream sequential_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public abstract")]
	void forEachOrdered(Dova.JDK.java.util.function.LongConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongToIntFunction;)Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream mapToInt(Dova.JDK.java.util.function.LongToIntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongToDoubleFunction;)Ljava/util/stream/DoubleStream;", "public abstract")]
	Dova.JDK.java.util.stream.DoubleStream mapToDouble(Dova.JDK.java.util.function.LongToDoubleFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/LongStream$LongMapMultiConsumer;)Ljava/util/stream/LongStream;", "public")]
	Dova.JDK.java.util.stream.LongStream mapMulti(Dova.JDK.java.util.stream.LongStream.LongMapMultiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;", "public")]
	Dova.JDK.java.util.stream.LongStream takeWhile(Dova.JDK.java.util.function.LongPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;", "public")]
	Dova.JDK.java.util.stream.LongStream dropWhile(Dova.JDK.java.util.function.LongPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongPredicate;)Z", "public abstract")]
	bool noneMatch(Dova.JDK.java.util.function.LongPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public abstract")]
	Dova.JDK.java.util.stream.Stream boxed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/DoubleStream;", "public abstract")]
	Dova.JDK.java.util.stream.DoubleStream asDoubleStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalDouble;", "public abstract")]
	Dova.JDK.java.util.OptionalDouble average()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalDouble>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/LongSummaryStatistics;", "public abstract")]
	Dova.JDK.java.util.LongSummaryStatistics summaryStatistics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.LongSummaryStatistics>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/LongStream$LongMapMultiConsumer;", "public abstract static interface")]
	public partial interface LongMapMultiConsumer
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LongMapMultiConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/LongStream$LongMapMultiConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(JLjava/util/function/LongConsumer;)V"));
		}

		[JniSignatureAttribute("(JLjava/util/function/LongConsumer;)V", "public abstract")]
		void accept(long arg0, Dova.JDK.java.util.function.LongConsumer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/LongStream$Builder;", "public abstract static interface")]
	public partial interface Builder
		: IJavaObject
		, Dova.JDK.java.util.function.LongConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/LongStream$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(J)Ljava/util/stream/LongStream$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/util/stream/LongStream;"));
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/LongStream$Builder;", "public")]
		Dova.JDK.java.util.stream.LongStream.Builder add(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream.Builder>(ret);
		}

		[JniSignatureAttribute("(J)V", "public abstract")]
		void accept(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public abstract")]
		Dova.JDK.java.util.stream.LongStream build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}
	}
}
