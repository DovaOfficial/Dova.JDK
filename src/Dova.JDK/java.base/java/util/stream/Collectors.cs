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

[JniSignatureAttribute("Ljava/util/stream/Collectors;", "public final")]
public partial class Collectors
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Collectors()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Collectors;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CH_CONCURRENT_ID", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CH_CONCURRENT_NOID", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CH_ID", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CH_UNORDERED_ID", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CH_NOID", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CH_UNORDERED_NOID", "Ljava/util/Set;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "joining", "()Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "joining", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "joining", "(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toList", "()Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toMap", "(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSet", "()Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mapping", "(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "groupingBy", "(Ljava/util/function/Function;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "groupingBy", "(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "groupingBy", "(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "minBy", "(Ljava/util/Comparator;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "maxBy", "(Ljava/util/Comparator;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toCollection", "(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "summingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reducing", "(Ljava/lang/Object;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reducing", "(Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reducing", "(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boxSupplier", "(Ljava/lang/Object;)Ljava/util/function/Supplier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mapMerger", "(Ljava/util/function/BinaryOperator;)Ljava/util/function/BinaryOperator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "groupingByConcurrent", "(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "groupingByConcurrent", "(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "groupingByConcurrent", "(Ljava/util/function/Function;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "partitioningBy", "(Ljava/util/function/Predicate;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "partitioningBy", "(Ljava/util/function/Predicate;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "uniqKeysMapAccumulator", "(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/function/BiConsumer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "uniqKeysMapMerger", "()Ljava/util/function/BinaryOperator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectingAndThen", "(Ljava/util/stream/Collector;Ljava/util/function/Function;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toConcurrentMap", "(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toConcurrentMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toConcurrentMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "teeing0", "(Ljava/util/stream/Collector;Ljava/util/stream/Collector;Ljava/util/function/BiFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeFinalSum", "([D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sumWithCompensation", "([DD)[D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "duplicateKeyException", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/IllegalStateException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "castingIdentity", "()Ljava/util/function/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnmodifiableList", "()Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnmodifiableSet", "()Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "flatMapping", "(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filtering", "(Ljava/util/function/Predicate;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "counting", "()Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "summingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "summingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "averagingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "averagingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "averagingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnmodifiableMap", "(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnmodifiableMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "summarizingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "summarizingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "summarizingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "teeing", "(Ljava/util/stream/Collector;Ljava/util/stream/Collector;Ljava/util/function/BiFunction;)Ljava/util/stream/Collector;"));
	}

	[JniSignatureAttribute("Ljava/util/Set;", "static final")]
	public static Dova.JDK.java.util.Set CH_CONCURRENT_ID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "static final")]
	public static Dova.JDK.java.util.Set CH_CONCURRENT_NOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "static final")]
	public static Dova.JDK.java.util.Set CH_ID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "static final")]
	public static Dova.JDK.java.util.Set CH_UNORDERED_ID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "static final")]
	public static Dova.JDK.java.util.Set CH_NOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "static final")]
	public static Dova.JDK.java.util.Set CH_UNORDERED_NOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Collectors(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Collectors() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/stream/Collectors;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector joining()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector joining(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.java.lang.CharSequence arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector joining(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toList()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toMap(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toMap(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toMap(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.function.BinaryOperator arg2, Dova.JDK.java.util.function.Supplier arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toSet()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector mapping(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.stream.Collector arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector groupingBy(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector groupingBy(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.stream.Collector arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector groupingBy(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Supplier arg1, Dova.JDK.java.util.stream.Collector arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector minBy(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector maxBy(Dova.JDK.java.util.Comparator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toCollection(Dova.JDK.java.util.function.Supplier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector summingLong(Dova.JDK.java.util.function.ToLongFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector reducing(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector reducing(Dova.JDK.java.util.function.BinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector reducing(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.BinaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/function/Supplier;", "private static")]
	public static Dova.JDK.java.util.function.Supplier boxSupplier(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BinaryOperator;)Ljava/util/function/BinaryOperator;", "private static")]
	public static Dova.JDK.java.util.function.BinaryOperator mapMerger(Dova.JDK.java.util.function.BinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector groupingByConcurrent(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.stream.Collector arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector groupingByConcurrent(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Supplier arg1, Dova.JDK.java.util.stream.Collector arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector groupingByConcurrent(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector partitioningBy(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector partitioningBy(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.java.util.stream.Collector arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/function/BiConsumer;", "private static")]
	public static Dova.JDK.java.util.function.BiConsumer uniqKeysMapAccumulator(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiConsumer>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/BinaryOperator;", "private static")]
	public static Dova.JDK.java.util.function.BinaryOperator uniqKeysMapMerger()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Collector;Ljava/util/function/Function;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector collectingAndThen(Dova.JDK.java.util.stream.Collector arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toConcurrentMap(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toConcurrentMap(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.function.BinaryOperator arg2, Dova.JDK.java.util.function.Supplier arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toConcurrentMap(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Collector;Ljava/util/stream/Collector;Ljava/util/function/BiFunction;)Ljava/util/stream/Collector;", "private static")]
	public static Dova.JDK.java.util.stream.Collector teeing0(Dova.JDK.java.util.stream.Collector arg0, Dova.JDK.java.util.stream.Collector arg1, Dova.JDK.java.util.function.BiFunction arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("([D)D", "static")]
	public static double computeFinalSum(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("([DD)[D", "static")]
	public static JavaArray<double> sumWithCompensation(JavaArray<double> arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/IllegalStateException;", "private static")]
	public static Dova.JDK.java.lang.IllegalStateException duplicateKeyException(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalStateException>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/Function;", "private static")]
	public static Dova.JDK.java.util.function.Function castingIdentity()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toUnmodifiableList()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toUnmodifiableSet()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector flatMapping(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.stream.Collector arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector filtering(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.java.util.stream.Collector arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector counting()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector summingInt(Dova.JDK.java.util.function.ToIntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector summingDouble(Dova.JDK.java.util.function.ToDoubleFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector averagingInt(Dova.JDK.java.util.function.ToIntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector averagingLong(Dova.JDK.java.util.function.ToLongFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector averagingDouble(Dova.JDK.java.util.function.ToDoubleFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toUnmodifiableMap(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector toUnmodifiableMap(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector summarizingInt(Dova.JDK.java.util.function.ToIntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector summarizingLong(Dova.JDK.java.util.function.ToLongFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector summarizingDouble(Dova.JDK.java.util.function.ToDoubleFunction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Collector;Ljava/util/stream/Collector;Ljava/util/function/BiFunction;)Ljava/util/stream/Collector;", "public static")]
	public static Dova.JDK.java.util.stream.Collector teeing(Dova.JDK.java.util.stream.Collector arg0, Dova.JDK.java.util.stream.Collector arg1, Dova.JDK.java.util.function.BiFunction arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/Collectors$CollectorImpl;", "static")]
	public partial class CollectorImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.Collector
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CollectorImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Collectors$CollectorImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supplier", "Ljava/util/function/Supplier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accumulator", "Ljava/util/function/BiConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "combiner", "Ljava/util/function/BinaryOperator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finisher", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "characteristics", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;Ljava/util/Set;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characteristics", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "combiner", "()Ljava/util/function/BinaryOperator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supplier", "()Ljava/util/function/Supplier;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accumulator", "()Ljava/util/function/BiConsumer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finisher", "()Ljava/util/function/Function;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Supplier;", "private final")]
		public Dova.JDK.java.util.function.Supplier supplier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/BiConsumer;", "private final")]
		public Dova.JDK.java.util.function.BiConsumer accumulator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/BinaryOperator;", "private final")]
		public Dova.JDK.java.util.function.BinaryOperator combiner_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
		public Dova.JDK.java.util.function.Function finisher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private final")]
		public Dova.JDK.java.util.Set characteristics_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CollectorImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;Ljava/util/Set;)V", "")]
		public CollectorImpl(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.function.BinaryOperator arg2, Dova.JDK.java.util.function.Function arg3, Dova.JDK.java.util.Set arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/Set;)V", "")]
		public CollectorImpl(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.function.BinaryOperator arg2, Dova.JDK.java.util.Set arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Collectors$CollectorImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set characteristics()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/function/BinaryOperator;", "public")]
		public Dova.JDK.java.util.function.BinaryOperator combiner()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/function/Supplier;", "public")]
		public Dova.JDK.java.util.function.Supplier supplier()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/function/BiConsumer;", "public")]
		public Dova.JDK.java.util.function.BiConsumer accumulator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiConsumer>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/function/Function;", "public")]
		public Dova.JDK.java.util.function.Function finisher()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Collectors$Partition;", "private static final")]
	public partial class Partition
		: Dova.JDK.java.util.AbstractMap
		, Dova.JDK.java.util.Map
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Partition()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Collectors$Partition;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forTrue", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forFalse", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "entrySet", "()Ljava/util/Set;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object forTrue_Property
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

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object forFalse_Property
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
		public Partition(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public Partition(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Collectors$Partition;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set entrySet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
	}
}
