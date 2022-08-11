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

[JniSignatureAttribute("Ljava/util/Random;", "public")]
public partial class Random
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.util.random.RandomGenerator
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Random()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Random;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "seed", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "multiplier", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "addend", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mask", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE_UNIT", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "seedUniquifier", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextNextGaussian", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "haveNextNextGaussian", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialPersistentFields", "[Ljava/io/ObjectStreamField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "seedOffset", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextDouble", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextInt", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextInt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextBytes", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "seedUniquifier", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initialScramble", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSeed", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetSeed", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(J)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(JII)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(II)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(J)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(JJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(JJJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(J)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(JDD)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(DD)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "()Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextLong", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextBoolean", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextFloat", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextGaussian", "()D"));
	}

	[JniSignatureAttribute("J", "static final")]
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

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicLong seed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long multiplier_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long addend_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long mask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double DOUBLE_UNIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicLong seedUniquifier_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double nextNextGaussian_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool haveNextNextGaussian_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("[Ljava/io/ObjectStreamField;", "private static final")]
	public static JavaArray<Dova.JDK.java.io.ObjectStreamField> serialPersistentFields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.ObjectStreamField>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static final")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long seedOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Random(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Random() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public Random(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/Random;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)I", "protected")]
	public int next(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private synchronized")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()D", "public")]
	public double nextDouble()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int nextInt()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int nextInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("([B)V", "public")]
	public void nextBytes(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()J", "private static")]
	public static long seedUniquifier()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private static")]
	public static long initialScramble(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public synchronized")]
	public void setSeed(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void resetSeed(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream ints(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream ints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(JII)Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream ints(long arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream ints(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/LongStream;", "public")]
	public Dova.JDK.java.util.stream.LongStream longs(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(JJ)Ljava/util/stream/LongStream;", "public")]
	public Dova.JDK.java.util.stream.LongStream longs(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(JJJ)Ljava/util/stream/LongStream;", "public")]
	public Dova.JDK.java.util.stream.LongStream longs(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public")]
	public Dova.JDK.java.util.stream.LongStream longs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/DoubleStream;", "public")]
	public Dova.JDK.java.util.stream.DoubleStream doubles(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(JDD)Ljava/util/stream/DoubleStream;", "public")]
	public Dova.JDK.java.util.stream.DoubleStream doubles(long arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(DD)Ljava/util/stream/DoubleStream;", "public")]
	public Dova.JDK.java.util.stream.DoubleStream doubles(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/DoubleStream;", "public")]
	public Dova.JDK.java.util.stream.DoubleStream doubles()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long nextLong()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool nextBoolean()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public")]
	public float nextFloat()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public synchronized")]
	public double nextGaussian()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}
}
