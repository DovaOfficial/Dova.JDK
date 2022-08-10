/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.util.random;

[JniSignatureAttribute("Ljava/util/random/RandomGenerator;", "public abstract interface")]
public partial interface RandomGenerator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RandomGenerator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/random/RandomGenerator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDefault", "()Ljava/util/random/RandomGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/String;)Ljava/util/random/RandomGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextDouble", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextDouble", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextDouble", "(DD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextInt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextInt", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextInt", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextBytes", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ints", "(II)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ints", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ints", "(J)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ints", "(JII)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "longs", "(JJJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "longs", "(JJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "longs", "()Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "longs", "(J)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doubles", "()Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doubles", "(JDD)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doubles", "(DD)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doubles", "(J)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextLong", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextLong", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextLong", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextBoolean", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextFloat", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextFloat", "(F)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextFloat", "(FF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextGaussian", "(DD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextGaussian", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDeprecated", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextExponential", "()D"));
	}

	[JniSignatureAttribute("()Ljava/util/random/RandomGenerator;", "public static")]
	static Dova.JDK.java.util.random.RandomGenerator getDefault()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/random/RandomGenerator;", "public static")]
	static Dova.JDK.java.util.random.RandomGenerator of(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator>(ret);
	}

	[JniSignatureAttribute("(D)D", "public")]
	double nextDouble(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	double nextDouble()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(DD)D", "public")]
	double nextDouble(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	int nextInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	int nextInt(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	int nextInt()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("([B)V", "public")]
	void nextBytes(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(II)Ljava/util/stream/IntStream;", "public")]
	Dova.JDK.java.util.stream.IntStream ints(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public")]
	Dova.JDK.java.util.stream.IntStream ints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/IntStream;", "public")]
	Dova.JDK.java.util.stream.IntStream ints(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(JII)Ljava/util/stream/IntStream;", "public")]
	Dova.JDK.java.util.stream.IntStream ints(long arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(JJJ)Ljava/util/stream/LongStream;", "public")]
	Dova.JDK.java.util.stream.LongStream longs(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(JJ)Ljava/util/stream/LongStream;", "public")]
	Dova.JDK.java.util.stream.LongStream longs(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public")]
	Dova.JDK.java.util.stream.LongStream longs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/LongStream;", "public")]
	Dova.JDK.java.util.stream.LongStream longs(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/DoubleStream;", "public")]
	Dova.JDK.java.util.stream.DoubleStream doubles()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(JDD)Ljava/util/stream/DoubleStream;", "public")]
	Dova.JDK.java.util.stream.DoubleStream doubles(long arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(DD)Ljava/util/stream/DoubleStream;", "public")]
	Dova.JDK.java.util.stream.DoubleStream doubles(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/DoubleStream;", "public")]
	Dova.JDK.java.util.stream.DoubleStream doubles(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(JJ)J", "public")]
	long nextLong(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long nextLong()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	long nextLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	bool nextBoolean()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public")]
	float nextFloat()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(F)F", "public")]
	float nextFloat(float arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(FF)F", "public")]
	float nextFloat(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DD)D", "public")]
	double nextGaussian(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	double nextGaussian()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	bool isDeprecated()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	double nextExponential()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "public abstract static interface")]
	public partial interface ArbitrarilyJumpableGenerator
		: IJavaObject
		, Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArbitrarilyJumpableGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/String;)Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copy_0", "()Ljava/util/random/RandomGenerator$LeapableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copy_1", "()Ljava/util/random/RandomGenerator$JumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copy_2", "()Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jump", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jump", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leap", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jumps", "(D)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jumps", "(JD)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyAndJump", "(D)Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jumpPowerOfTwo", "(I)V"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "public static")]
		static Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator of(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$LeapableGenerator;", "public volatile")]
		Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator copy_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$JumpableGenerator;", "public volatile")]
		Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator copy_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "public abstract")]
		Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator copy_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		void jump()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(D)V", "public abstract")]
		void jump(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		void leap()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(D)Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream jumps(double arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(JD)Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream jumps(long arg0, double arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(D)Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "public")]
		Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator copyAndJump(double arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
		}

		[JniSignatureAttribute("(I)V", "public abstract")]
		void jumpPowerOfTwo(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/util/random/RandomGenerator$LeapableGenerator;", "public abstract static interface")]
	public partial interface LeapableGenerator
		: IJavaObject
		, Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LeapableGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/random/RandomGenerator$LeapableGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/String;)Ljava/util/random/RandomGenerator$LeapableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copy_0", "()Ljava/util/random/RandomGenerator$JumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copy_1", "()Ljava/util/random/RandomGenerator$LeapableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leap", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leapDistance", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leaps", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leaps", "(J)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyAndLeap", "()Ljava/util/random/RandomGenerator$JumpableGenerator;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/random/RandomGenerator$LeapableGenerator;", "public static")]
		static Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator of(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$JumpableGenerator;", "public volatile")]
		Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator copy_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$LeapableGenerator;", "public abstract")]
		Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator copy_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator>(ret);
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void leap()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()D", "public abstract")]
		double leapDistance()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream leaps()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream leaps(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$JumpableGenerator;", "public")]
		Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator copyAndLeap()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/random/RandomGenerator$JumpableGenerator;", "public abstract static interface")]
	public partial interface JumpableGenerator
		: IJavaObject
		, Dova.JDK.java.util.random.RandomGenerator.StreamableGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JumpableGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/random/RandomGenerator$JumpableGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/String;)Ljava/util/random/RandomGenerator$JumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copy", "()Ljava/util/random/RandomGenerator$JumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jump", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rngs", "(J)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rngs", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jumpDistance", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jumps", "(J)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "jumps", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyAndJump", "()Ljava/util/random/RandomGenerator;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/random/RandomGenerator$JumpableGenerator;", "public static")]
		static Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator of(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$JumpableGenerator;", "public abstract")]
		Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator copy()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void jump()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream rngs(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream rngs()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()D", "public abstract")]
		double jumpDistance()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream jumps(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream jumps()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator;", "public")]
		Dova.JDK.java.util.random.RandomGenerator copyAndJump()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/random/RandomGenerator$SplittableGenerator;", "public abstract static interface")]
	public partial interface SplittableGenerator
		: IJavaObject
		, Dova.JDK.java.util.random.RandomGenerator.StreamableGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SplittableGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/random/RandomGenerator$SplittableGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "split", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "split", "()Ljava/util/random/RandomGenerator$SplittableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/String;)Ljava/util/random/RandomGenerator$SplittableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "splits", "(JLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "splits", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "splits", "(J)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "splits", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rngs", "(J)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rngs", "()Ljava/util/stream/Stream;"));
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;", "public abstract")]
		Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$SplittableGenerator;", "public abstract")]
		Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/random/RandomGenerator$SplittableGenerator;", "public static")]
		static Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator of(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
		}

		[JniSignatureAttribute("(JLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;", "public abstract")]
		Dova.JDK.java.util.stream.Stream splits(long arg0, Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;", "public abstract")]
		Dova.JDK.java.util.stream.Stream splits(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public abstract")]
		Dova.JDK.java.util.stream.Stream splits(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream splits()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream rngs(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream rngs()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/random/RandomGenerator$StreamableGenerator;", "public abstract static interface")]
	public partial interface StreamableGenerator
		: IJavaObject
		, Dova.JDK.java.util.random.RandomGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StreamableGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/random/RandomGenerator$StreamableGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/String;)Ljava/util/random/RandomGenerator$StreamableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rngs", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rngs", "(J)Ljava/util/stream/Stream;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/random/RandomGenerator$StreamableGenerator;", "public static")]
		static Dova.JDK.java.util.random.RandomGenerator.StreamableGenerator of(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.StreamableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public abstract")]
		Dova.JDK.java.util.stream.Stream rngs()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
		Dova.JDK.java.util.stream.Stream rngs(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}
	}
}
