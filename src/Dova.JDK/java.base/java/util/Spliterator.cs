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

[JniSignatureAttribute("Ljava/util/Spliterator;", "public abstract interface")]
public partial interface Spliterator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Spliterator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Spliterator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ORDERED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISTINCT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SORTED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONNULL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMMUTABLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONCURRENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUBSIZED", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characteristics", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateSize", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExactSizeIfKnown", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasCharacteristics", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComparator", "()Ljava/util/Comparator;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ORDERED_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int DISTINCT_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int SORTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SIZED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int NONNULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int IMMUTABLE_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int CONCURRENT_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int SUBSIZED_Property
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

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
	void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int characteristics()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public abstract")]
	bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator;", "public abstract")]
	Dova.JDK.java.util.Spliterator trySplit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long estimateSize()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	long getExactSizeIfKnown()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	bool hasCharacteristics(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	Dova.JDK.java.util.Comparator getComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("Ljava/util/Spliterator$OfDouble;", "public abstract static interface")]
	public partial interface OfDouble
		: IJavaObject
		, Dova.JDK.java.util.Spliterator.OfPrimitive
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfDouble()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Spliterator$OfDouble;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfDouble;"));
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		void forEachRemaining(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)V", "public")]
		void forEachRemaining(Dova.JDK.java.util.function.DoubleConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		bool tryAdvance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
		bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)Z", "public abstract")]
		bool tryAdvance(Dova.JDK.java.util.function.DoubleConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		Dova.JDK.java.util.Spliterator trySplit_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public abstract")]
		Dova.JDK.java.util.Spliterator.OfDouble trySplit_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/Spliterator$OfLong;", "public abstract static interface")]
	public partial interface OfLong
		: IJavaObject
		, Dova.JDK.java.util.Spliterator.OfPrimitive
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfLong()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Spliterator$OfLong;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/LongConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/LongConsumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfLong;"));
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		void forEachRemaining(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public")]
		void forEachRemaining(Dova.JDK.java.util.function.LongConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		bool tryAdvance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
		bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)Z", "public abstract")]
		bool tryAdvance(Dova.JDK.java.util.function.LongConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		Dova.JDK.java.util.Spliterator trySplit_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public abstract")]
		Dova.JDK.java.util.Spliterator.OfLong trySplit_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/Spliterator$OfInt;", "public abstract static interface")]
	public partial interface OfInt
		: IJavaObject
		, Dova.JDK.java.util.Spliterator.OfPrimitive
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfInt()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Spliterator$OfInt;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/IntConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/IntConsumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfInt;"));
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		void forEachRemaining(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
		void forEachRemaining(Dova.JDK.java.util.function.IntConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		bool tryAdvance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
		bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Z", "public abstract")]
		bool tryAdvance(Dova.JDK.java.util.function.IntConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		Dova.JDK.java.util.Spliterator trySplit_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public abstract")]
		Dova.JDK.java.util.Spliterator.OfInt trySplit_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/Spliterator$OfPrimitive;", "public abstract static interface")]
	public partial interface OfPrimitive
		: IJavaObject
		, Dova.JDK.java.util.Spliterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfPrimitive()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Spliterator$OfPrimitive;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		void forEachRemaining(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
		bool tryAdvance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		Dova.JDK.java.util.Spliterator trySplit_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public abstract")]
		Dova.JDK.java.lang.Object trySplit_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
