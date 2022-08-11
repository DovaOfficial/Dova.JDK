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

[JniSignatureAttribute("Ljava/util/stream/IntStream;", "public abstract interface")]
public partial interface IntStream
	: IJavaObject
	, Dova.JDK.java.util.stream.BaseStream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IntStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/IntStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "min", "()Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "max", "()Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator_0", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator_1", "()Ljava/util/PrimitiveIterator$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "map", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collect", "(Ljava/util/function/Supplier;Ljava/util/function/ObjIntConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(I)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "([I)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "builder", "()Ljava/util/stream/IntStream$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "concat", "(Ljava/util/stream/IntStream;Ljava/util/stream/IntStream;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "limit", "(J)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "empty", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "anyMatch", "(Ljava/util/function/IntPredicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flatMap", "(Ljava/util/function/IntFunction;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/IntConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAny", "()Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peek", "(Ljava/util/function/IntConsumer;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sum", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(ILjava/util/function/IntBinaryOperator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(Ljava/util/function/IntBinaryOperator;)Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "range", "(II)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parallel_0", "()Ljava/util/stream/BaseStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parallel_1", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iterate", "(ILjava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iterate", "(ILjava/util/function/IntPredicate;Ljava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "distinct", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findFirst", "()Ljava/util/OptionalInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allMatch", "(Ljava/util/function/IntPredicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sorted", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generate", "(Ljava/util/function/IntSupplier;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapToObj", "(Ljava/util/function/IntFunction;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rangeClosed", "(II)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequential_0", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequential_1", "()Ljava/util/stream/BaseStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachOrdered", "(Ljava/util/function/IntConsumer;)V"));
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

	[JniSignatureAttribute("()Ljava/util/OptionalInt;", "public abstract")]
	Dova.JDK.java.util.OptionalInt min()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalInt;", "public abstract")]
	Dova.JDK.java.util.OptionalInt max()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("()[I", "public abstract")]
	JavaArray<int> toArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public volatile")]
	Dova.JDK.java.util.Iterator iterator_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/PrimitiveIterator$OfInt;", "public abstract")]
	Dova.JDK.java.util.PrimitiveIterator.OfInt iterator_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.PrimitiveIterator.OfInt>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream map(Dova.JDK.java.util.function.IntUnaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/ObjIntConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object collect(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.ObjIntConsumer arg1, Dova.JDK.java.util.function.BiConsumer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/stream/IntStream;", "public static")]
	static Dova.JDK.java.util.stream.IntStream of(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("([I)Ljava/util/stream/IntStream;", "public static transient")]
	static Dova.JDK.java.util.stream.IntStream of(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long count()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream$Builder;", "public static")]
	static Dova.JDK.java.util.stream.IntStream.Builder builder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/IntStream;Ljava/util/stream/IntStream;)Ljava/util/stream/IntStream;", "public static")]
	static Dova.JDK.java.util.stream.IntStream concat(Dova.JDK.java.util.stream.IntStream arg0, Dova.JDK.java.util.stream.IntStream arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream limit(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public abstract")]
	Dova.JDK.java.util.Spliterator.OfInt spliterator_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
	Dova.JDK.java.util.Spliterator spliterator_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream filter(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public static")]
	static Dova.JDK.java.util.stream.IntStream empty()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Z", "public abstract")]
	bool anyMatch(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/IntFunction;)Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream flatMap(Dova.JDK.java.util.function.IntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public abstract")]
	void forEach(Dova.JDK.java.util.function.IntConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalInt;", "public abstract")]
	Dova.JDK.java.util.OptionalInt findAny()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream skip(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream peek(Dova.JDK.java.util.function.IntConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int sum()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/util/function/IntBinaryOperator;)I", "public abstract")]
	int reduce(int arg0, Dova.JDK.java.util.function.IntBinaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/IntBinaryOperator;)Ljava/util/OptionalInt;", "public abstract")]
	Dova.JDK.java.util.OptionalInt reduce(Dova.JDK.java.util.function.IntBinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/stream/IntStream;", "public static")]
	static Dova.JDK.java.util.stream.IntStream range(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
	Dova.JDK.java.util.stream.BaseStream parallel_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream parallel_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;", "public static")]
	static Dova.JDK.java.util.stream.IntStream iterate(int arg0, Dova.JDK.java.util.function.IntUnaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/function/IntPredicate;Ljava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;", "public static")]
	static Dova.JDK.java.util.stream.IntStream iterate(int arg0, Dova.JDK.java.util.function.IntPredicate arg1, Dova.JDK.java.util.function.IntUnaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream distinct()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalInt;", "public abstract")]
	Dova.JDK.java.util.OptionalInt findFirst()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalInt>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Z", "public abstract")]
	bool allMatch(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream sorted()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntSupplier;)Ljava/util/stream/IntStream;", "public static")]
	static Dova.JDK.java.util.stream.IntStream generate(Dova.JDK.java.util.function.IntSupplier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntFunction;)Ljava/util/stream/Stream;", "public abstract")]
	Dova.JDK.java.util.stream.Stream mapToObj(Dova.JDK.java.util.function.IntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/stream/IntStream;", "public static")]
	static Dova.JDK.java.util.stream.IntStream rangeClosed(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public abstract")]
	Dova.JDK.java.util.stream.IntStream sequential_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/BaseStream;", "public volatile")]
	Dova.JDK.java.util.stream.BaseStream sequential_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.BaseStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public abstract")]
	void forEachOrdered(Dova.JDK.java.util.function.IntConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntToLongFunction;)Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream mapToLong(Dova.JDK.java.util.function.IntToLongFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntToDoubleFunction;)Ljava/util/stream/DoubleStream;", "public abstract")]
	Dova.JDK.java.util.stream.DoubleStream mapToDouble(Dova.JDK.java.util.function.IntToDoubleFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/IntStream$IntMapMultiConsumer;)Ljava/util/stream/IntStream;", "public")]
	Dova.JDK.java.util.stream.IntStream mapMulti(Dova.JDK.java.util.stream.IntStream.IntMapMultiConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;", "public")]
	Dova.JDK.java.util.stream.IntStream takeWhile(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;", "public")]
	Dova.JDK.java.util.stream.IntStream dropWhile(Dova.JDK.java.util.function.IntPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntPredicate;)Z", "public abstract")]
	bool noneMatch(Dova.JDK.java.util.function.IntPredicate arg0)
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

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public abstract")]
	Dova.JDK.java.util.stream.LongStream asLongStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/DoubleStream;", "public abstract")]
	Dova.JDK.java.util.stream.DoubleStream asDoubleStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/OptionalDouble;", "public abstract")]
	Dova.JDK.java.util.OptionalDouble average()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.OptionalDouble>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/IntSummaryStatistics;", "public abstract")]
	Dova.JDK.java.util.IntSummaryStatistics summaryStatistics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.IntSummaryStatistics>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/IntStream$IntMapMultiConsumer;", "public abstract static interface")]
	public partial interface IntMapMultiConsumer
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntMapMultiConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/IntStream$IntMapMultiConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(ILjava/util/function/IntConsumer;)V"));
		}

		[JniSignatureAttribute("(ILjava/util/function/IntConsumer;)V", "public abstract")]
		void accept(int arg0, Dova.JDK.java.util.function.IntConsumer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/IntStream$Builder;", "public abstract static interface")]
	public partial interface Builder
		: IJavaObject
		, Dova.JDK.java.util.function.IntConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/IntStream$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(I)Ljava/util/stream/IntStream$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/util/stream/IntStream;"));
		}

		[JniSignatureAttribute("(I)Ljava/util/stream/IntStream$Builder;", "public")]
		Dova.JDK.java.util.stream.IntStream.Builder add(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream.Builder>(ret);
		}

		[JniSignatureAttribute("(I)V", "public abstract")]
		void accept(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public abstract")]
		Dova.JDK.java.util.stream.IntStream build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}
	}
}
