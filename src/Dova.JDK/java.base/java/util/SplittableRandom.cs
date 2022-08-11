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

[JniSignatureAttribute("Ljava/util/SplittableRandom;", "public final")]
public partial class SplittableRandom
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.util.random.RandomGenerator
	, Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SplittableRandom()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/SplittableRandom;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOLDEN_GAMMA", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "seed", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gamma", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxy", "Ljava/util/SplittableRandom$AbstractSplittableGeneratorProxy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultGen", "Ljava/util/concurrent/atomic/AtomicLong;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split_0", "()Ljava/util/SplittableRandom;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split_1", "()Ljava/util/random/RandomGenerator$SplittableGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split_0", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split_1", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/SplittableRandom;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextInt", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextBytes", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(II)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(JII)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(J)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(JJJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(J)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(JJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(DD)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(JDD)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(J)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "()Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextLong", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mix32", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextSeed", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mix64", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mixGamma", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splits", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splits", "(JLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splits", "(J)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splits", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long GOLDEN_GAMMA_Property
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

	[JniSignatureAttribute("J", "private")]
	public long seed_Property
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

	[JniSignatureAttribute("J", "private final")]
	public long gamma_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/SplittableRandom$AbstractSplittableGeneratorProxy;", "private")]
	public Dova.JDK.java.util.SplittableRandom.AbstractSplittableGeneratorProxy proxy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.SplittableRandom.AbstractSplittableGeneratorProxy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicLong defaultGen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SplittableRandom(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public SplittableRandom(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SplittableRandom() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	[JniSignatureAttribute("(JJ)V", "private")]
	public SplittableRandom(long arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/SplittableRandom;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/SplittableRandom;", "public")]
	public Dova.JDK.java.util.SplittableRandom split_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SplittableRandom>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$SplittableGenerator;", "public volatile")]
	public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;", "public volatile")]
	public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split_0(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/SplittableRandom;", "public")]
	public Dova.JDK.java.util.SplittableRandom split_1(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SplittableRandom>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int nextInt()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("([B)V", "public")]
	public void nextBytes(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(II)Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream ints(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(JII)Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream ints(long arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream ints(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream ints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public")]
	public Dova.JDK.java.util.stream.LongStream longs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(JJJ)Ljava/util/stream/LongStream;", "public")]
	public Dova.JDK.java.util.stream.LongStream longs(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/LongStream;", "public")]
	public Dova.JDK.java.util.stream.LongStream longs(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(JJ)Ljava/util/stream/LongStream;", "public")]
	public Dova.JDK.java.util.stream.LongStream longs(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(DD)Ljava/util/stream/DoubleStream;", "public")]
	public Dova.JDK.java.util.stream.DoubleStream doubles(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(JDD)Ljava/util/stream/DoubleStream;", "public")]
	public Dova.JDK.java.util.stream.DoubleStream doubles(long arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/DoubleStream;", "public")]
	public Dova.JDK.java.util.stream.DoubleStream doubles(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/DoubleStream;", "public")]
	public Dova.JDK.java.util.stream.DoubleStream doubles()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long nextLong()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "private static")]
	public static int mix32(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()J", "private")]
	public long nextSeed()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private static")]
	public static long mix64(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private static")]
	public static long mixGamma(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream splits()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream splits(long arg0, Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream splits(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream splits(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("Ljava/util/SplittableRandom$AbstractSplittableGeneratorProxy;", "private")]
	public partial class AbstractSplittableGeneratorProxy
		: Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractSplittableGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractSplittableGeneratorProxy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/SplittableRandom$AbstractSplittableGeneratorProxy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/util/SplittableRandom;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/SplittableRandom;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split_0", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/SplittableRandom;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split_1", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextInt", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextLong", "()J"));
		}

		[JniSignatureAttribute("Ljava/util/SplittableRandom;", "final")]
		public Dova.JDK.java.util.SplittableRandom this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.SplittableRandom>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractSplittableGeneratorProxy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/SplittableRandom;)V", "private")]
		public AbstractSplittableGeneratorProxy(Dova.JDK.java.util.SplittableRandom arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/SplittableRandom$AbstractSplittableGeneratorProxy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/SplittableRandom;", "public")]
		public Dova.JDK.java.util.SplittableRandom split_0(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.SplittableRandom>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;", "public volatile")]
		public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split_1(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int nextInt()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		public long nextLong()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}
}
