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

namespace Dova.JDK.java.util;

[JniSignatureAttribute("Ljava/util/Arrays;", "public")]
public partial class Arrays
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Arrays()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Arrays;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIN_ARRAY_SORT_GRAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSERTIONSORT_THRESHOLD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([F[F)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([D[D)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([Z[Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([S[S)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([I[I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([J[J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([B[B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([C[C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([DII[DII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([ZII[ZII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([Ljava/lang/Object;II[Ljava/lang/Object;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([FII[FII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([III[III)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([JII[JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([BII[BII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([CII[CII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([SII[SII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([Ljava/lang/Object;II[Ljava/lang/Object;IILjava/util/Comparator;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([B)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([S)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([D)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([F)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([F)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([S)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCode", "([C)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([II)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([FI)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([JI)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([CI)[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([ZI)[Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([DI)[D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([Ljava/lang/Object;I)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([SI)[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([FII)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([CII)[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([JII)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([DII)[D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([ZII)[Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([Ljava/lang/Object;II)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([III)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([SII)[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOfRange", "([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([ZII[ZII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([BII[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([DII[DII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([Ljava/lang/Comparable;II[Ljava/lang/Comparable;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([III[III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([JII[JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([FII[FII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([SII[SII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([CII[CII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([B[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([Z[Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([Ljava/lang/Comparable;[Ljava/lang/Comparable;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([I[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([J[J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([F[F)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([D[D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([C[C)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([S[S)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([Ljava/lang/Object;II[Ljava/lang/Object;IILjava/util/Comparator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rangeCheck", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "([I)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "([J)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "([D)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "([Ljava/lang/Object;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "([III)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "([JII)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "([DII)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "([Ljava/lang/Object;II)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([SIIS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([FIIF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([BIIB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([CIIC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([ZIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([DIID)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([Ljava/lang/Object;IILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([JIIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([CC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([SS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([BB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spliterator", "([J)Ljava/util/Spliterator$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spliterator", "([D)Ljava/util/Spliterator$OfDouble;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spliterator", "([Ljava/lang/Object;)Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spliterator", "([I)Ljava/util/Spliterator$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spliterator", "([JII)Ljava/util/Spliterator$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spliterator", "([III)Ljava/util/Spliterator$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spliterator", "([DII)Ljava/util/Spliterator$OfDouble;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spliterator", "([Ljava/lang/Object;II)Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([Ljava/lang/Object;Ljava/util/Comparator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "([Ljava/lang/Object;IILjava/util/Comparator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asList", "([Ljava/lang/Object;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareUnsigned", "([B[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareUnsigned", "([J[J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareUnsigned", "([I[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareUnsigned", "([S[S)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareUnsigned", "([BII[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareUnsigned", "([III[III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareUnsigned", "([JII[JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareUnsigned", "([SII[SII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "deepEquals0", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "deepEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "legacyMergeSort", "([Ljava/lang/Object;IILjava/util/Comparator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "legacyMergeSort", "([Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "legacyMergeSort", "([Ljava/lang/Object;Ljava/util/Comparator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "legacyMergeSort", "([Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mergeSort", "([Ljava/lang/Object;[Ljava/lang/Object;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mergeSort", "([Ljava/lang/Object;[Ljava/lang/Object;IIILjava/util/Comparator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "swap", "([Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([SIIS)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([CIIC)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([JIIJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([Ljava/lang/Object;IILjava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([DIID)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([FIIF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([BIIB)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch0", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([I[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([J[J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([B[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([Z[Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([C[C)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([S[S)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([Ljava/lang/Object;[Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([F[F)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([D[D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([BII[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([SII[SII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([III[III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([JII[JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([ZII[ZII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([CII[CII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([Ljava/lang/Object;II[Ljava/lang/Object;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([FII[FII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([DII[DII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mismatch", "([Ljava/lang/Object;II[Ljava/lang/Object;IILjava/util/Comparator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "deepHashCode", "([Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "primitiveArrayHashCode", "(Ljava/lang/Object;Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "deepToString", "([Ljava/lang/Object;Ljava/lang/StringBuilder;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "deepToString", "([Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([Ljava/lang/Comparable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([Ljava/lang/Comparable;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([Ljava/lang/Object;IILjava/util/Comparator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSort", "([Ljava/lang/Object;Ljava/util/Comparator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelPrefix", "([ILjava/util/function/IntBinaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelPrefix", "([DLjava/util/function/DoubleBinaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelPrefix", "([JLjava/util/function/LongBinaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelPrefix", "([Ljava/lang/Object;Ljava/util/function/BinaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelPrefix", "([DIILjava/util/function/DoubleBinaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelPrefix", "([IIILjava/util/function/IntBinaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelPrefix", "([Ljava/lang/Object;IILjava/util/function/BinaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelPrefix", "([JIILjava/util/function/LongBinaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([FF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([JJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([SS)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([DD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([BB)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([CC)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([DIID)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([FIIF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([JIIJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([SIIS)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([BIIB)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([CIIC)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAll", "([DLjava/util/function/IntToDoubleFunction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAll", "([ILjava/util/function/IntUnaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAll", "([Ljava/lang/Object;Ljava/util/function/IntFunction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAll", "([JLjava/util/function/IntToLongFunction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSetAll", "([ILjava/util/function/IntUnaryOperator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSetAll", "([DLjava/util/function/IntToDoubleFunction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSetAll", "([Ljava/lang/Object;Ljava/util/function/IntFunction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parallelSetAll", "([JLjava/util/function/IntToLongFunction;)V"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MIN_ARRAY_SORT_GRAN_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int INSERTIONSORT_THRESHOLD_Property
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

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Arrays(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Arrays() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/Arrays;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([F[F)Z", "public static")]
	public static bool equals(JavaArray<float> arg0, JavaArray<float> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([D[D)Z", "public static")]
	public static bool equals(JavaArray<double> arg0, JavaArray<double> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Z[Z)Z", "public static")]
	public static bool equals(JavaArray<bool> arg0, JavaArray<bool> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;)Z", "public static")]
	public static bool equals(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([S[S)Z", "public static")]
	public static bool equals(JavaArray<short> arg0, JavaArray<short> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([I[I)Z", "public static")]
	public static bool equals(JavaArray<int> arg0, JavaArray<int> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([J[J)Z", "public static")]
	public static bool equals(JavaArray<long> arg0, JavaArray<long> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([B[B)Z", "public static")]
	public static bool equals(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([C[C)Z", "public static")]
	public static bool equals(JavaArray<char> arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([DII[DII)Z", "public static")]
	public static bool equals(JavaArray<double> arg0, int arg1, int arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([ZII[ZII)Z", "public static")]
	public static bool equals(JavaArray<bool> arg0, int arg1, int arg2, JavaArray<bool> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II[Ljava/lang/Object;II)Z", "public static")]
	public static bool equals(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([FII[FII)Z", "public static")]
	public static bool equals(JavaArray<float> arg0, int arg1, int arg2, JavaArray<float> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([III[III)Z", "public static")]
	public static bool equals(JavaArray<int> arg0, int arg1, int arg2, JavaArray<int> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([JII[JII)Z", "public static")]
	public static bool equals(JavaArray<long> arg0, int arg1, int arg2, JavaArray<long> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([BII[BII)Z", "public static")]
	public static bool equals(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([CII[CII)Z", "public static")]
	public static bool equals(JavaArray<char> arg0, int arg1, int arg2, JavaArray<char> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([SII[SII)Z", "public static")]
	public static bool equals(JavaArray<short> arg0, int arg1, int arg2, JavaArray<short> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II[Ljava/lang/Object;IILjava/util/Comparator;)Z", "public static")]
	public static bool equals(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, int arg4, int arg5, Dova.JDK.java.util.Comparator arg6)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Z", "public static")]
	public static bool equals(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.util.Comparator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Z)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<bool> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([C)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([S)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<short> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([J)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([D)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([F)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([F)I", "public static")]
	public static int hashCode(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("([B)I", "public static")]
	public static int hashCode(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("([D)I", "public static")]
	public static int hashCode(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)I", "public static")]
	public static int hashCode(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Z)I", "public static")]
	public static int hashCode(JavaArray<bool> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("([J)I", "public static")]
	public static int hashCode(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("([I)I", "public static")]
	public static int hashCode(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("([S)I", "public static")]
	public static int hashCode(JavaArray<short> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("([C)I", "public static")]
	public static int hashCode(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("([II)[I", "public static")]
	public static JavaArray<int> copyOf(JavaArray<int> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([BI)[B", "public static")]
	public static JavaArray<byte> copyOf(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([FI)[F", "public static")]
	public static JavaArray<float> copyOf(JavaArray<float> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([JI)[J", "public static")]
	public static JavaArray<long> copyOf(JavaArray<long> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([CI)[C", "public static")]
	public static JavaArray<char> copyOf(JavaArray<char> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("([ZI)[Z", "public static")]
	public static JavaArray<bool> copyOf(JavaArray<bool> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
	}

	[JniSignatureAttribute("([DI)[D", "public static")]
	public static JavaArray<double> copyOf(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;I)[Ljava/lang/Object;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.Object> copyOf(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([SI)[S", "public static")]
	public static JavaArray<short> copyOf(JavaArray<short> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.Object> copyOf(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([FII)[F", "public static")]
	public static JavaArray<float> copyOfRange(JavaArray<float> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([CII)[C", "public static")]
	public static JavaArray<char> copyOfRange(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("([JII)[J", "public static")]
	public static JavaArray<long> copyOfRange(JavaArray<long> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([DII)[D", "public static")]
	public static JavaArray<double> copyOfRange(JavaArray<double> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("([ZII)[Z", "public static")]
	public static JavaArray<bool> copyOfRange(JavaArray<bool> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II)[Ljava/lang/Object;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.Object> copyOfRange(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([BII)[B", "public static")]
	public static JavaArray<byte> copyOfRange(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([III)[I", "public static")]
	public static JavaArray<int> copyOfRange(JavaArray<int> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([SII)[S", "public static")]
	public static JavaArray<short> copyOfRange(JavaArray<short> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.Object> copyOfRange(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([ZII[ZII)I", "public static")]
	public static int compare(JavaArray<bool> arg0, int arg1, int arg2, JavaArray<bool> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([BII[BII)I", "public static")]
	public static int compare(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([DII[DII)I", "public static")]
	public static int compare(JavaArray<double> arg0, int arg1, int arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Comparable;II[Ljava/lang/Comparable;II)I", "public static")]
	public static int compare(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([III[III)I", "public static")]
	public static int compare(JavaArray<int> arg0, int arg1, int arg2, JavaArray<int> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([JII[JII)I", "public static")]
	public static int compare(JavaArray<long> arg0, int arg1, int arg2, JavaArray<long> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[63], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([FII[FII)I", "public static")]
	public static int compare(JavaArray<float> arg0, int arg1, int arg2, JavaArray<float> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([SII[SII)I", "public static")]
	public static int compare(JavaArray<short> arg0, int arg1, int arg2, JavaArray<short> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[65], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([CII[CII)I", "public static")]
	public static int compare(JavaArray<char> arg0, int arg1, int arg2, JavaArray<char> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[66], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([B[B)I", "public static")]
	public static int compare(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[67], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Z[Z)I", "public static")]
	public static int compare(JavaArray<bool> arg0, JavaArray<bool> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Comparable;[Ljava/lang/Comparable;)I", "public static")]
	public static int compare(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[69], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([I[I)I", "public static")]
	public static int compare(JavaArray<int> arg0, JavaArray<int> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[70], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([J[J)I", "public static")]
	public static int compare(JavaArray<long> arg0, JavaArray<long> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[71], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([F[F)I", "public static")]
	public static int compare(JavaArray<float> arg0, JavaArray<float> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[72], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([D[D)I", "public static")]
	public static int compare(JavaArray<double> arg0, JavaArray<double> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[73], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([C[C)I", "public static")]
	public static int compare(JavaArray<char> arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[74], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([S[S)I", "public static")]
	public static int compare(JavaArray<short> arg0, JavaArray<short> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II[Ljava/lang/Object;IILjava/util/Comparator;)I", "public static")]
	public static int compare(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, int arg4, int arg5, Dova.JDK.java.util.Comparator arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)I", "public static")]
	public static int compare(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.util.Comparator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(III)V", "static")]
	public static void rangeCheck(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[78], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([I)Ljava/util/stream/IntStream;", "public static")]
	public static Dova.JDK.java.util.stream.IntStream stream(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("([J)Ljava/util/stream/LongStream;", "public static")]
	public static Dova.JDK.java.util.stream.LongStream stream(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[80], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("([D)Ljava/util/stream/DoubleStream;", "public static")]
	public static Dova.JDK.java.util.stream.DoubleStream stream(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/util/stream/Stream;", "public static")]
	public static Dova.JDK.java.util.stream.Stream stream(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[82], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("([III)Ljava/util/stream/IntStream;", "public static")]
	public static Dova.JDK.java.util.stream.IntStream stream(JavaArray<int> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[83], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("([JII)Ljava/util/stream/LongStream;", "public static")]
	public static Dova.JDK.java.util.stream.LongStream stream(JavaArray<long> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[84], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("([DII)Ljava/util/stream/DoubleStream;", "public static")]
	public static Dova.JDK.java.util.stream.DoubleStream stream(JavaArray<double> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[85], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II)Ljava/util/stream/Stream;", "public static")]
	public static Dova.JDK.java.util.stream.Stream stream(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[86], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("([SIIS)V", "public static")]
	public static void fill(JavaArray<short> arg0, int arg1, int arg2, short arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[87], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([FIIF)V", "public static")]
	public static void fill(JavaArray<float> arg0, int arg1, int arg2, float arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[88], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([IIII)V", "public static")]
	public static void fill(JavaArray<int> arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[89], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([BIIB)V", "public static")]
	public static void fill(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[90], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([CIIC)V", "public static")]
	public static void fill(JavaArray<char> arg0, int arg1, int arg2, char arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[91], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([ZIIZ)V", "public static")]
	public static void fill(JavaArray<bool> arg0, int arg1, int arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[92], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([DIID)V", "public static")]
	public static void fill(JavaArray<double> arg0, int arg1, int arg2, double arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[93], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/lang/Object;)V", "public static")]
	public static void fill(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.lang.Object arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[94], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([JIIJ)V", "public static")]
	public static void fill(JavaArray<long> arg0, int arg1, int arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[95], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([CC)V", "public static")]
	public static void fill(JavaArray<char> arg0, char arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[96], arg0, arg1);
	}

	[JniSignatureAttribute("([FF)V", "public static")]
	public static void fill(JavaArray<float> arg0, float arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[97], arg0, arg1);
	}

	[JniSignatureAttribute("([II)V", "public static")]
	public static void fill(JavaArray<int> arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[98], arg0, arg1);
	}

	[JniSignatureAttribute("([SS)V", "public static")]
	public static void fill(JavaArray<short> arg0, short arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[99], arg0, arg1);
	}

	[JniSignatureAttribute("([ZZ)V", "public static")]
	public static void fill(JavaArray<bool> arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[100], arg0, arg1);
	}

	[JniSignatureAttribute("([BB)V", "public static")]
	public static void fill(JavaArray<byte> arg0, byte arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[101], arg0, arg1);
	}

	[JniSignatureAttribute("([DD)V", "public static")]
	public static void fill(JavaArray<double> arg0, double arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[102], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/lang/Object;)V", "public static")]
	public static void fill(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[103], arg0, arg1);
	}

	[JniSignatureAttribute("([JJ)V", "public static")]
	public static void fill(JavaArray<long> arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[104], arg0, arg1);
	}

	[JniSignatureAttribute("([J)Ljava/util/Spliterator$OfLong;", "public static")]
	public static Dova.JDK.java.util.Spliterator.OfLong spliterator(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[105], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
	}

	[JniSignatureAttribute("([D)Ljava/util/Spliterator$OfDouble;", "public static")]
	public static Dova.JDK.java.util.Spliterator.OfDouble spliterator(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[106], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/util/Spliterator;", "public static")]
	public static Dova.JDK.java.util.Spliterator spliterator(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[107], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("([I)Ljava/util/Spliterator$OfInt;", "public static")]
	public static Dova.JDK.java.util.Spliterator.OfInt spliterator(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[108], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
	}

	[JniSignatureAttribute("([JII)Ljava/util/Spliterator$OfLong;", "public static")]
	public static Dova.JDK.java.util.Spliterator.OfLong spliterator(JavaArray<long> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[109], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
	}

	[JniSignatureAttribute("([III)Ljava/util/Spliterator$OfInt;", "public static")]
	public static Dova.JDK.java.util.Spliterator.OfInt spliterator(JavaArray<int> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[110], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
	}

	[JniSignatureAttribute("([DII)Ljava/util/Spliterator$OfDouble;", "public static")]
	public static Dova.JDK.java.util.Spliterator.OfDouble spliterator(JavaArray<double> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[111], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II)Ljava/util/Spliterator;", "public static")]
	public static Dova.JDK.java.util.Spliterator spliterator(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[112], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("([S)V", "public static")]
	public static void sort(JavaArray<short> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[113], arg0);
	}

	[JniSignatureAttribute("([B)V", "public static")]
	public static void sort(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[114], arg0);
	}

	[JniSignatureAttribute("([C)V", "public static")]
	public static void sort(JavaArray<char> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[115], arg0);
	}

	[JniSignatureAttribute("([J)V", "public static")]
	public static void sort(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[116], arg0);
	}

	[JniSignatureAttribute("([D)V", "public static")]
	public static void sort(JavaArray<double> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[117], arg0);
	}

	[JniSignatureAttribute("([F)V", "public static")]
	public static void sort(JavaArray<float> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[118], arg0);
	}

	[JniSignatureAttribute("([I)V", "public static")]
	public static void sort(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[119], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "public static")]
	public static void sort(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[120], arg0);
	}

	[JniSignatureAttribute("([CII)V", "public static")]
	public static void sort(JavaArray<char> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[121], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([SII)V", "public static")]
	public static void sort(JavaArray<short> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[122], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([JII)V", "public static")]
	public static void sort(JavaArray<long> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[123], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([III)V", "public static")]
	public static void sort(JavaArray<int> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[124], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([FII)V", "public static")]
	public static void sort(JavaArray<float> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[125], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BII)V", "public static")]
	public static void sort(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[126], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([DII)V", "public static")]
	public static void sort(JavaArray<double> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[127], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II)V", "public static")]
	public static void sort(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[128], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/util/Comparator;)V", "public static")]
	public static void sort(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.util.Comparator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[129], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/util/Comparator;)V", "public static")]
	public static void sort(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.util.Comparator arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[130], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/util/List;", "public static transient")]
	public static Dova.JDK.java.util.List asList(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[131], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("([B[B)I", "public static")]
	public static int compareUnsigned(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[132], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([J[J)I", "public static")]
	public static int compareUnsigned(JavaArray<long> arg0, JavaArray<long> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[133], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([I[I)I", "public static")]
	public static int compareUnsigned(JavaArray<int> arg0, JavaArray<int> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[134], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([S[S)I", "public static")]
	public static int compareUnsigned(JavaArray<short> arg0, JavaArray<short> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[135], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BII[BII)I", "public static")]
	public static int compareUnsigned(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[136], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([III[III)I", "public static")]
	public static int compareUnsigned(JavaArray<int> arg0, int arg1, int arg2, JavaArray<int> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[137], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([JII[JII)I", "public static")]
	public static int compareUnsigned(JavaArray<long> arg0, int arg1, int arg2, JavaArray<long> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[138], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([SII[SII)I", "public static")]
	public static int compareUnsigned(JavaArray<short> arg0, int arg1, int arg2, JavaArray<short> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[139], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "static")]
	public static bool deepEquals0(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[140], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;)Z", "public static")]
	public static bool deepEquals(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[141], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/util/Comparator;)V", "private static")]
	public static void legacyMergeSort(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.util.Comparator arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[142], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "private static")]
	public static void legacyMergeSort(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[143], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/util/Comparator;)V", "private static")]
	public static void legacyMergeSort(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.util.Comparator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[144], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II)V", "private static")]
	public static void legacyMergeSort(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[145], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;III)V", "private static")]
	public static void mergeSort(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[146], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;IIILjava/util/Comparator;)V", "private static")]
	public static void mergeSort(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, int arg2, int arg3, int arg4, Dova.JDK.java.util.Comparator arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[147], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II)V", "private static")]
	public static void swap(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[148], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([SIIS)I", "private static")]
	public static int binarySearch0(JavaArray<short> arg0, int arg1, int arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[149], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([CIIC)I", "private static")]
	public static int binarySearch0(JavaArray<char> arg0, int arg1, int arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[150], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([JIIJ)I", "private static")]
	public static int binarySearch0(JavaArray<long> arg0, int arg1, int arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[151], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([IIII)I", "private static")]
	public static int binarySearch0(JavaArray<int> arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[152], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/lang/Object;)I", "private static")]
	public static int binarySearch0(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[153], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([DIID)I", "private static")]
	public static int binarySearch0(JavaArray<double> arg0, int arg1, int arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[154], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([FIIF)I", "private static")]
	public static int binarySearch0(JavaArray<float> arg0, int arg1, int arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[155], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([BIIB)I", "private static")]
	public static int binarySearch0(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[156], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I", "private static")]
	public static int binarySearch0(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.util.Comparator arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[157], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([I[I)I", "public static")]
	public static int mismatch(JavaArray<int> arg0, JavaArray<int> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[158], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([J[J)I", "public static")]
	public static int mismatch(JavaArray<long> arg0, JavaArray<long> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[159], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([B[B)I", "public static")]
	public static int mismatch(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[160], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Z[Z)I", "public static")]
	public static int mismatch(JavaArray<bool> arg0, JavaArray<bool> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[161], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([C[C)I", "public static")]
	public static int mismatch(JavaArray<char> arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[162], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([S[S)I", "public static")]
	public static int mismatch(JavaArray<short> arg0, JavaArray<short> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[163], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;)I", "public static")]
	public static int mismatch(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[164], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([F[F)I", "public static")]
	public static int mismatch(JavaArray<float> arg0, JavaArray<float> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[165], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([D[D)I", "public static")]
	public static int mismatch(JavaArray<double> arg0, JavaArray<double> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[166], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BII[BII)I", "public static")]
	public static int mismatch(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[167], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([SII[SII)I", "public static")]
	public static int mismatch(JavaArray<short> arg0, int arg1, int arg2, JavaArray<short> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[168], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([III[III)I", "public static")]
	public static int mismatch(JavaArray<int> arg0, int arg1, int arg2, JavaArray<int> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[169], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([JII[JII)I", "public static")]
	public static int mismatch(JavaArray<long> arg0, int arg1, int arg2, JavaArray<long> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[170], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([ZII[ZII)I", "public static")]
	public static int mismatch(JavaArray<bool> arg0, int arg1, int arg2, JavaArray<bool> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[171], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([CII[CII)I", "public static")]
	public static int mismatch(JavaArray<char> arg0, int arg1, int arg2, JavaArray<char> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[172], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II[Ljava/lang/Object;II)I", "public static")]
	public static int mismatch(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[173], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([FII[FII)I", "public static")]
	public static int mismatch(JavaArray<float> arg0, int arg1, int arg2, JavaArray<float> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[174], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([DII[DII)I", "public static")]
	public static int mismatch(JavaArray<double> arg0, int arg1, int arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[175], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)I", "public static")]
	public static int mismatch(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.util.Comparator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[176], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;II[Ljava/lang/Object;IILjava/util/Comparator;)I", "public static")]
	public static int mismatch(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, int arg4, int arg5, Dova.JDK.java.util.Comparator arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[177], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)I", "public static")]
	public static int deepHashCode(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[178], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)I", "private static")]
	public static int primitiveArrayHashCode(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[179], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/lang/StringBuilder;Ljava/util/Set;)V", "private static")]
	public static void deepToString(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.StringBuilder arg1, Dova.JDK.java.util.Set arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[180], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String deepToString(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[181], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([D)V", "public static")]
	public static void parallelSort(JavaArray<double> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[182], arg0);
	}

	[JniSignatureAttribute("([F)V", "public static")]
	public static void parallelSort(JavaArray<float> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[183], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/Comparable;)V", "public static")]
	public static void parallelSort(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[184], arg0);
	}

	[JniSignatureAttribute("([I)V", "public static")]
	public static void parallelSort(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[185], arg0);
	}

	[JniSignatureAttribute("([J)V", "public static")]
	public static void parallelSort(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[186], arg0);
	}

	[JniSignatureAttribute("([B)V", "public static")]
	public static void parallelSort(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[187], arg0);
	}

	[JniSignatureAttribute("([C)V", "public static")]
	public static void parallelSort(JavaArray<char> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[188], arg0);
	}

	[JniSignatureAttribute("([S)V", "public static")]
	public static void parallelSort(JavaArray<short> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[189], arg0);
	}

	[JniSignatureAttribute("([FII)V", "public static")]
	public static void parallelSort(JavaArray<float> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[190], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([DII)V", "public static")]
	public static void parallelSort(JavaArray<double> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[191], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([SII)V", "public static")]
	public static void parallelSort(JavaArray<short> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[192], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([III)V", "public static")]
	public static void parallelSort(JavaArray<int> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[193], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([JII)V", "public static")]
	public static void parallelSort(JavaArray<long> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[194], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BII)V", "public static")]
	public static void parallelSort(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[195], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/lang/Comparable;II)V", "public static")]
	public static void parallelSort(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[196], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([CII)V", "public static")]
	public static void parallelSort(JavaArray<char> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[197], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/util/Comparator;)V", "public static")]
	public static void parallelSort(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.util.Comparator arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[198], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/util/Comparator;)V", "public static")]
	public static void parallelSort(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.util.Comparator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[199], arg0, arg1);
	}

	[JniSignatureAttribute("([ILjava/util/function/IntBinaryOperator;)V", "public static")]
	public static void parallelPrefix(JavaArray<int> arg0, Dova.JDK.java.util.function.IntBinaryOperator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[200], arg0, arg1);
	}

	[JniSignatureAttribute("([DLjava/util/function/DoubleBinaryOperator;)V", "public static")]
	public static void parallelPrefix(JavaArray<double> arg0, Dova.JDK.java.util.function.DoubleBinaryOperator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[201], arg0, arg1);
	}

	[JniSignatureAttribute("([JLjava/util/function/LongBinaryOperator;)V", "public static")]
	public static void parallelPrefix(JavaArray<long> arg0, Dova.JDK.java.util.function.LongBinaryOperator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[202], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/util/function/BinaryOperator;)V", "public static")]
	public static void parallelPrefix(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.util.function.BinaryOperator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[203], arg0, arg1);
	}

	[JniSignatureAttribute("([DIILjava/util/function/DoubleBinaryOperator;)V", "public static")]
	public static void parallelPrefix(JavaArray<double> arg0, int arg1, int arg2, Dova.JDK.java.util.function.DoubleBinaryOperator arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[204], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([IIILjava/util/function/IntBinaryOperator;)V", "public static")]
	public static void parallelPrefix(JavaArray<int> arg0, int arg1, int arg2, Dova.JDK.java.util.function.IntBinaryOperator arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[205], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/util/function/BinaryOperator;)V", "public static")]
	public static void parallelPrefix(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.util.function.BinaryOperator arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[206], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([JIILjava/util/function/LongBinaryOperator;)V", "public static")]
	public static void parallelPrefix(JavaArray<long> arg0, int arg1, int arg2, Dova.JDK.java.util.function.LongBinaryOperator arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[207], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/lang/Object;)I", "public static")]
	public static int binarySearch(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[208], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([FF)I", "public static")]
	public static int binarySearch(JavaArray<float> arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[209], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([JJ)I", "public static")]
	public static int binarySearch(JavaArray<long> arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[210], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([II)I", "public static")]
	public static int binarySearch(JavaArray<int> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[211], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([SS)I", "public static")]
	public static int binarySearch(JavaArray<short> arg0, short arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[212], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([DD)I", "public static")]
	public static int binarySearch(JavaArray<double> arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[213], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BB)I", "public static")]
	public static int binarySearch(JavaArray<byte> arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[214], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([CC)I", "public static")]
	public static int binarySearch(JavaArray<char> arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[215], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([DIID)I", "public static")]
	public static int binarySearch(JavaArray<double> arg0, int arg1, int arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[216], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([FIIF)I", "public static")]
	public static int binarySearch(JavaArray<float> arg0, int arg1, int arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[217], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/lang/Object;)I", "public static")]
	public static int binarySearch(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[218], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([JIIJ)I", "public static")]
	public static int binarySearch(JavaArray<long> arg0, int arg1, int arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[219], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([SIIS)I", "public static")]
	public static int binarySearch(JavaArray<short> arg0, int arg1, int arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[220], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([IIII)I", "public static")]
	public static int binarySearch(JavaArray<int> arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[221], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([BIIB)I", "public static")]
	public static int binarySearch(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[222], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([CIIC)I", "public static")]
	public static int binarySearch(JavaArray<char> arg0, int arg1, int arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[223], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I", "public static")]
	public static int binarySearch(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, int arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.util.Comparator arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[224], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I", "public static")]
	public static int binarySearch(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.Comparator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[225], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([DLjava/util/function/IntToDoubleFunction;)V", "public static")]
	public static void setAll(JavaArray<double> arg0, Dova.JDK.java.util.function.IntToDoubleFunction arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[226], arg0, arg1);
	}

	[JniSignatureAttribute("([ILjava/util/function/IntUnaryOperator;)V", "public static")]
	public static void setAll(JavaArray<int> arg0, Dova.JDK.java.util.function.IntUnaryOperator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[227], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/util/function/IntFunction;)V", "public static")]
	public static void setAll(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.util.function.IntFunction arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[228], arg0, arg1);
	}

	[JniSignatureAttribute("([JLjava/util/function/IntToLongFunction;)V", "public static")]
	public static void setAll(JavaArray<long> arg0, Dova.JDK.java.util.function.IntToLongFunction arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[229], arg0, arg1);
	}

	[JniSignatureAttribute("([ILjava/util/function/IntUnaryOperator;)V", "public static")]
	public static void parallelSetAll(JavaArray<int> arg0, Dova.JDK.java.util.function.IntUnaryOperator arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[230], arg0, arg1);
	}

	[JniSignatureAttribute("([DLjava/util/function/IntToDoubleFunction;)V", "public static")]
	public static void parallelSetAll(JavaArray<double> arg0, Dova.JDK.java.util.function.IntToDoubleFunction arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[231], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/util/function/IntFunction;)V", "public static")]
	public static void parallelSetAll(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.util.function.IntFunction arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[232], arg0, arg1);
	}

	[JniSignatureAttribute("([JLjava/util/function/IntToLongFunction;)V", "public static")]
	public static void parallelSetAll(JavaArray<long> arg0, Dova.JDK.java.util.function.IntToLongFunction arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[233], arg0, arg1);
	}

	[JniSignatureAttribute("Ljava/util/Arrays$NaturalOrder;", "static final")]
	public partial class NaturalOrder
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Comparator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NaturalOrder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Arrays$NaturalOrder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljava/util/Arrays$NaturalOrder;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"));
		}

		[JniSignatureAttribute("Ljava/util/Arrays$NaturalOrder;", "static final")]
		public static Dova.JDK.java.util.Arrays.NaturalOrder INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Arrays.NaturalOrder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NaturalOrder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public NaturalOrder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Arrays$NaturalOrder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)I", "public")]
		public int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/Arrays$LegacyMergeSort;", "static final")]
	public partial class LegacyMergeSort
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LegacyMergeSort()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Arrays$LegacyMergeSort;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "userRequested", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool userRequested_Property
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
		public LegacyMergeSort(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public LegacyMergeSort() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Arrays$LegacyMergeSort;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/util/Arrays$ArrayList;", "private static")]
	public partial class ArrayList
		: Dova.JDK.java.util.AbstractList
		, Dova.JDK.java.util.RandomAccess
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayList()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Arrays$ArrayList;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "a", "[Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceAll", "(Ljava/util/function/UnaryOperator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "()[Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(ILjava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sort", "(Ljava/util/Comparator;)V"));
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

		[JniSignatureAttribute("[Ljava/lang/Object;", "private final")]
		public JavaArray<Dova.JDK.java.lang.Object> a_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayList(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)V", "")]
		public ArrayList(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Arrays$ArrayList;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object get(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "public")]
		public int indexOf(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/UnaryOperator;)V", "public")]
		public void replaceAll(Dova.JDK.java.util.function.UnaryOperator arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> toArray(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> toArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
		public Dova.JDK.java.util.Iterator iterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool contains(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
		public Dova.JDK.java.util.Spliterator spliterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object set(int arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/Comparator;)V", "public")]
		public void sort(Dova.JDK.java.util.Comparator arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/util/Arrays$ArrayItr;", "private static")]
	public partial class ArrayItr
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayItr()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Arrays$ArrayItr;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cursor", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "a", "[Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int cursor_Property
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

		[JniSignatureAttribute("[Ljava/lang/Object;", "private final")]
		public JavaArray<Dova.JDK.java.lang.Object> a_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayItr(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)V", "")]
		public ArrayItr(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Arrays$ArrayItr;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object next()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
