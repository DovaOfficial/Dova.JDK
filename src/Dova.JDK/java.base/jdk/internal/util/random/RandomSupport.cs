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

namespace Dova.JDK.jdk.@internal.util.random;

[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport;", "public")]
public partial class RandomSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RandomSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_SIZE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_DISTANCE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_BOUND", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_FLOATING_BOUND", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_RANGE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "useSecureRandomSeed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOLDEN_RATIO_32", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOLDEN_RATIO_64", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SILVER_RATIO_32", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SILVER_RATIO_64", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkRange", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkRange", "(FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkRange", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkRange", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkStreamSize", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkBound", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkBound", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkBound", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkBound", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedNextFloat", "(Ljava/util/random/RandomGenerator;FF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedNextFloat", "(Ljava/util/random/RandomGenerator;F)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedNextDouble", "(Ljava/util/random/RandomGenerator;DD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedNextDouble", "(Ljava/util/random/RandomGenerator;D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedNextInt", "(Ljava/util/random/RandomGenerator;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedNextInt", "(Ljava/util/random/RandomGenerator;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedNextLong", "(Ljava/util/random/RandomGenerator;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedNextLong", "(Ljava/util/random/RandomGenerator;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeNextGaussian", "(Ljava/util/random/RandomGenerator;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeNextExponential", "(Ljava/util/random/RandomGenerator;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mixMurmur64", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mixMurmur32", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mixStafford13", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "secureRandomSeedRequested", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertSeedBytesToLongs", "([BII)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertSeedBytesToInts", "([BII)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initialSeed", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mixLea64", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mixLea32", "(I)I"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BAD_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BAD_DISTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BAD_BOUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BAD_FLOATING_BOUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BAD_RANGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool useSecureRandomSeed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int GOLDEN_RATIO_32_Property
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

	[JniSignatureAttribute("J", "public static final")]
	public static long GOLDEN_RATIO_64_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SILVER_RATIO_32_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("J", "public static final")]
	public static long SILVER_RATIO_64_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RandomSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public RandomSupport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(DD)V", "public static")]
	public static void checkRange(double arg0, double arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(FF)V", "public static")]
	public static void checkRange(float arg0, float arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "public static")]
	public static void checkRange(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public static")]
	public static void checkRange(int arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(J)V", "public static")]
	public static void checkStreamSize(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(F)V", "public static")]
	public static void checkBound(float arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(D)V", "public static")]
	public static void checkBound(double arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(I)V", "public static")]
	public static void checkBound(int arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(J)V", "public static")]
	public static void checkBound(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;FF)F", "public static")]
	public static float boundedNextFloat(Dova.JDK.java.util.random.RandomGenerator arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;F)F", "public static")]
	public static float boundedNextFloat(Dova.JDK.java.util.random.RandomGenerator arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;DD)D", "public static")]
	public static double boundedNextDouble(Dova.JDK.java.util.random.RandomGenerator arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;D)D", "public static")]
	public static double boundedNextDouble(Dova.JDK.java.util.random.RandomGenerator arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;I)I", "public static")]
	public static int boundedNextInt(Dova.JDK.java.util.random.RandomGenerator arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;II)I", "public static")]
	public static int boundedNextInt(Dova.JDK.java.util.random.RandomGenerator arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;J)J", "public static")]
	public static long boundedNextLong(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;JJ)J", "public static")]
	public static long boundedNextLong(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;)D", "public static")]
	public static double computeNextGaussian(Dova.JDK.java.util.random.RandomGenerator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;)D", "public static")]
	public static double computeNextExponential(Dova.JDK.java.util.random.RandomGenerator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public static")]
	public static long mixMurmur64(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int mixMurmur32(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public static")]
	public static long mixStafford13(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool secureRandomSeedRequested()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("([BII)[J", "public static")]
	public static JavaArray<long> convertSeedBytesToLongs(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([BII)[I", "public static")]
	public static JavaArray<int> convertSeedBytesToInts(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()J", "public static")]
	public static long initialSeed()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public static")]
	public static long mixLea64(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int mixLea32(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$DoubleZigguratTables;", "static final")]
	public partial class DoubleZigguratTables
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DoubleZigguratTables()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$DoubleZigguratTables;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialNumberOfLayers", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialLayerMask", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialAliasMask", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialSignCorrectionMask", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialX0", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialConvexMargin", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialX", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialY", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialAliasThreshold", "[J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exponentialAliasMap", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalNumberOfLayers", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalLayerMask", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalAliasMask", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalSignCorrectionMask", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalX0", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalInflectionIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalConvexMargin", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalConcaveMargin", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalX", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalY", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalAliasThreshold", "[J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "normalAliasMap", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int exponentialNumberOfLayers_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int exponentialLayerMask_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int exponentialAliasMask_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int exponentialSignCorrectionMask_Property
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

		[JniSignatureAttribute("D", "static final")]
		public static double exponentialX0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("J", "static final")]
		public static long exponentialConvexMargin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("[D", "static final")]
		public static JavaArray<double> exponentialX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[D", "static final")]
		public static JavaArray<double> exponentialY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[J", "static final")]
		public static JavaArray<long> exponentialAliasThreshold_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "static final")]
		public static JavaArray<byte> exponentialAliasMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int normalNumberOfLayers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int normalLayerMask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int normalAliasMask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int normalSignCorrectionMask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("D", "static final")]
		public static double normalX0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int normalInflectionIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("J", "static final")]
		public static long normalConvexMargin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("J", "static final")]
		public static long normalConcaveMargin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("[D", "static final")]
		public static JavaArray<double> normalX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[D", "static final")]
		public static JavaArray<double> normalY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[J", "static final")]
		public static JavaArray<long> normalAliasThreshold_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "static final")]
		public static JavaArray<byte> normalAliasMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DoubleZigguratTables(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public DoubleZigguratTables() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$DoubleZigguratTables;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator;", "public abstract static")]
	public partial class AbstractSplittableWithBrineGenerator
		: Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractSplittableGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractSplittableWithBrineGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SALT_SHIFT", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(Ljava/util/random/RandomGenerator$SplittableGenerator;J)Ljava/util/random/RandomGenerator$SplittableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(J)Ljava/util/random/RandomGenerator$SplittableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSplitsSpliterator", "(JJLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/Spliterator;"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int SALT_SHIFT_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractSplittableWithBrineGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public AbstractSplittableWithBrineGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;J)Ljava/util/random/RandomGenerator$SplittableGenerator;", "public abstract")]
		public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;", "public")]
		public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/random/RandomGenerator$SplittableGenerator;", "public")]
		public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/Spliterator;", "")]
		public Dova.JDK.java.util.Spliterator makeSplitsSpliterator(long arg0, long arg1, Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator$RandomSplitsSpliteratorWithSalt;", "static")]
		public partial class RandomSplitsSpliteratorWithSalt
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomSplitsSpliteratorWithSalt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator$RandomSplitsSpliteratorWithSalt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$SplittableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructingGenerator", "Ljdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "salt", "J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$SplittableGenerator;JJLjdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator;J)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$SplittableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator;", "final")]
			public Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractSplittableWithBrineGenerator constructingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractSplittableWithBrineGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("J", "")]
			public long salt_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomSplitsSpliteratorWithSalt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;JJLjdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator;J)V", "")]
			public RandomSplitsSpliteratorWithSalt(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0, long arg1, long arg2, Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractSplittableWithBrineGenerator arg3, long arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractSplittableWithBrineGenerator$RandomSplitsSpliteratorWithSalt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
			public Dova.JDK.java.util.Spliterator trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator;", "public abstract static")]
	public partial class AbstractSplittableGenerator
		: Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractSpliteratorGenerator
		, Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractSplittableGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "()Ljava/util/random/RandomGenerator$SplittableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splits", "(JLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splits", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splits", "(J)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splits", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSplitsSpliterator", "(JJLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/Spliterator;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractSplittableGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public AbstractSplittableGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$SplittableGenerator;", "public")]
		public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator split()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
		}

		[JniSignatureAttribute("(JLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream splits(long arg0, Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream splits(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream splits(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream splits()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/Spliterator;", "")]
		public Dova.JDK.java.util.Spliterator makeSplitsSpliterator(long arg0, long arg1, Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomSplitsSpliterator;", "static")]
		public partial class RandomSplitsSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomSplitsSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomSplitsSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$SplittableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructingGenerator", "Ljava/util/random/RandomGenerator$SplittableGenerator;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$SplittableGenerator;JJLjava/util/random/RandomGenerator$SplittableGenerator;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$SplittableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$SplittableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator constructingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomSplitsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;JJLjava/util/random/RandomGenerator$SplittableGenerator;)V", "")]
			public RandomSplitsSpliterator(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0, long arg1, long arg2, Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomSplitsSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
			public Dova.JDK.java.util.Spliterator trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomDoublesSpliterator;", "static")]
		public partial class RandomDoublesSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomDoublesSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomDoublesSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$SplittableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "D"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$SplittableGenerator;JJDD)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfDouble;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$SplittableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("D", "final")]
			public double origin_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("D", "final")]
			public double bound_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomDoublesSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;JJDD)V", "")]
			public RandomDoublesSpliterator(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0, long arg1, long arg2, double arg3, double arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomDoublesSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.DoubleConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.DoubleConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator trySplit_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public")]
			public Dova.JDK.java.util.Spliterator.OfDouble trySplit_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomLongsSpliterator;", "static")]
		public partial class RandomLongsSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomLongsSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomLongsSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$SplittableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$SplittableGenerator;JJJJ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/LongConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/LongConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfLong;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$SplittableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("J", "final")]
			public long origin_Property
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

			[JniSignatureAttribute("J", "final")]
			public long bound_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomLongsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;JJJJ)V", "")]
			public RandomLongsSpliterator(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0, long arg1, long arg2, long arg3, long arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomLongsSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.LongConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.LongConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator trySplit_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public")]
			public Dova.JDK.java.util.Spliterator.OfLong trySplit_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomIntsSpliterator;", "static")]
		public partial class RandomIntsSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomIntsSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomIntsSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$SplittableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$SplittableGenerator;JJII)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/IntConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/IntConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfInt;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$SplittableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int origin_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int bound_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomIntsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$SplittableGenerator;JJII)V", "")]
			public RandomIntsSpliterator(Dova.JDK.java.util.random.RandomGenerator.SplittableGenerator arg0, long arg1, long arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractSplittableGenerator$RandomIntsSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.IntConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.IntConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator trySplit_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public")]
			public Dova.JDK.java.util.Spliterator.OfInt trySplit_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator;", "public abstract static")]
	public partial class AbstractArbitrarilyJumpableGenerator
		: Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractSpliteratorGenerator
		, Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractArbitrarilyJumpableGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "(Ljava/util/Spliterator;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_0", "()Ljava/util/random/RandomGenerator$LeapableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_1", "()Ljava/util/random/RandomGenerator$JumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_2", "()Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_3", "()Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leap", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeJumpsSpliterator", "(JJD)Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeArbitraryJumpsSpliterator", "(JJD)Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeLeapsSpliterator", "(JJD)Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jumps", "(D)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jumps", "(J)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jumps", "(JD)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jumps", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leaps", "(J)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leaps", "()Ljava/util/stream/Stream;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractArbitrarilyJumpableGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public AbstractArbitrarilyJumpableGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/Stream;", "private static")]
		public static Dova.JDK.java.util.stream.Stream stream(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$LeapableGenerator;", "public volatile")]
		public Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator copy_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$JumpableGenerator;", "public volatile")]
		public Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator copy_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "public volatile")]
		public Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator copy_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator;", "public abstract")]
		public Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractArbitrarilyJumpableGenerator copy_3()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.util.random.RandomSupport.AbstractArbitrarilyJumpableGenerator>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void leap()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(JJD)Ljava/util/Spliterator;", "")]
		public Dova.JDK.java.util.Spliterator makeJumpsSpliterator(long arg0, long arg1, double arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(JJD)Ljava/util/Spliterator;", "")]
		public Dova.JDK.java.util.Spliterator makeArbitraryJumpsSpliterator(long arg0, long arg1, double arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(JJD)Ljava/util/Spliterator;", "")]
		public Dova.JDK.java.util.Spliterator makeLeapsSpliterator(long arg0, long arg1, double arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(D)Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream jumps(double arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream jumps(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(JD)Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream jumps(long arg0, double arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream jumps()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream leaps(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream leaps()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomJumpsSpliterator;", "static")]
		public partial class RandomJumpsSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomJumpsSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomJumpsSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "distance", "D"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJD)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "")]
			public Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("D", "final")]
			public double distance_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomJumpsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJD)V", "")]
			public RandomJumpsSpliterator(Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator arg0, long arg1, long arg2, double arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomJumpsSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
			public Dova.JDK.java.util.Spliterator trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomLeapsSpliterator;", "static")]
		public partial class RandomLeapsSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomLeapsSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomLeapsSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "distance", "D"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJD)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "")]
			public Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("D", "final")]
			public double distance_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomLeapsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJD)V", "")]
			public RandomLeapsSpliterator(Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator arg0, long arg1, long arg2, double arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomLeapsSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
			public Dova.JDK.java.util.Spliterator trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomArbitraryJumpsSpliterator;", "static")]
		public partial class RandomArbitraryJumpsSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomArbitraryJumpsSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomArbitraryJumpsSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "distance", "D"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJD)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "")]
			public Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("D", "final")]
			public double distance_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomArbitraryJumpsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJD)V", "")]
			public RandomArbitraryJumpsSpliterator(Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator arg0, long arg1, long arg2, double arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomArbitraryJumpsSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
			public Dova.JDK.java.util.Spliterator trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomDoublesSpliterator;", "static")]
		public partial class RandomDoublesSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomDoublesSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomDoublesSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "D"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJDD)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfDouble;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("D", "final")]
			public double origin_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("D", "final")]
			public double bound_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomDoublesSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJDD)V", "")]
			public RandomDoublesSpliterator(Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator arg0, long arg1, long arg2, double arg3, double arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomDoublesSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.DoubleConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.DoubleConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator trySplit_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public")]
			public Dova.JDK.java.util.Spliterator.OfDouble trySplit_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomLongsSpliterator;", "static")]
		public partial class RandomLongsSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomLongsSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomLongsSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJJJ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/LongConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/LongConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfLong;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("J", "final")]
			public long origin_Property
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

			[JniSignatureAttribute("J", "final")]
			public long bound_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomLongsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJJJ)V", "")]
			public RandomLongsSpliterator(Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator arg0, long arg1, long arg2, long arg3, long arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomLongsSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.LongConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.LongConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator trySplit_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public")]
			public Dova.JDK.java.util.Spliterator.OfLong trySplit_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomIntsSpliterator;", "static")]
		public partial class RandomIntsSpliterator
			: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
			, Dova.JDK.java.util.Spliterator.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RandomIntsSpliterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomIntsSpliterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJII)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/IntConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/IntConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfInt;"));
			}

			[JniSignatureAttribute("Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;", "final")]
			public Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator generatingGenerator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int origin_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int bound_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RandomIntsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/random/RandomGenerator$ArbitrarilyJumpableGenerator;JJII)V", "")]
			public RandomIntsSpliterator(Dova.JDK.java.util.random.RandomGenerator.ArbitrarilyJumpableGenerator arg0, long arg1, long arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractArbitrarilyJumpableGenerator$RandomIntsSpliterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.IntConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.IntConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator trySplit_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public")]
			public Dova.JDK.java.util.Spliterator.OfInt trySplit_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$AbstractSpliteratorGenerator;", "public abstract static")]
	public partial class AbstractSpliteratorGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.random.RandomGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractSpliteratorGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$AbstractSpliteratorGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "intStream", "(Ljava/util/Spliterator$OfInt;)Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longStream", "(Ljava/util/Spliterator$OfLong;)Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubleStream", "(Ljava/util/Spliterator$OfDouble;)Ljava/util/stream/DoubleStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(II)Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ints", "(Ljava/util/random/RandomGenerator;J)Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(JII)Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ints", "(Ljava/util/random/RandomGenerator;II)Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "()Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ints", "(J)Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ints", "(Ljava/util/random/RandomGenerator;)Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ints", "(Ljava/util/random/RandomGenerator;JII)Ljava/util/stream/IntStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(JJJ)Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longs", "(Ljava/util/random/RandomGenerator;JJ)Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(J)Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longs", "(Ljava/util/random/RandomGenerator;)Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "()Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longs", "(Ljava/util/random/RandomGenerator;JJJ)Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longs", "(JJ)Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longs", "(Ljava/util/random/RandomGenerator;J)Ljava/util/stream/LongStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(DD)Ljava/util/stream/DoubleStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubles", "(Ljava/util/random/RandomGenerator;J)Ljava/util/stream/DoubleStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(J)Ljava/util/stream/DoubleStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubles", "(Ljava/util/random/RandomGenerator;)Ljava/util/stream/DoubleStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "(JDD)Ljava/util/stream/DoubleStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubles", "(Ljava/util/random/RandomGenerator;DD)Ljava/util/stream/DoubleStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubles", "()Ljava/util/stream/DoubleStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubles", "(Ljava/util/random/RandomGenerator;JDD)Ljava/util/stream/DoubleStream;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractSpliteratorGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractSpliteratorGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$AbstractSpliteratorGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;)Ljava/util/stream/IntStream;", "private static")]
		public static Dova.JDK.java.util.stream.IntStream intStream(Dova.JDK.java.util.Spliterator.OfInt arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;)Ljava/util/stream/LongStream;", "private static")]
		public static Dova.JDK.java.util.stream.LongStream longStream(Dova.JDK.java.util.Spliterator.OfLong arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;)Ljava/util/stream/DoubleStream;", "private static")]
		public static Dova.JDK.java.util.stream.DoubleStream doubleStream(Dova.JDK.java.util.Spliterator.OfDouble arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}

		[JniSignatureAttribute("(II)Ljava/util/stream/IntStream;", "public")]
		public Dova.JDK.java.util.stream.IntStream ints(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;J)Ljava/util/stream/IntStream;", "public static")]
		public static Dova.JDK.java.util.stream.IntStream ints(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(JII)Ljava/util/stream/IntStream;", "public")]
		public Dova.JDK.java.util.stream.IntStream ints(long arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;II)Ljava/util/stream/IntStream;", "public static")]
		public static Dova.JDK.java.util.stream.IntStream ints(Dova.JDK.java.util.random.RandomGenerator arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public")]
		public Dova.JDK.java.util.stream.IntStream ints()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/IntStream;", "public")]
		public Dova.JDK.java.util.stream.IntStream ints(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;)Ljava/util/stream/IntStream;", "public static")]
		public static Dova.JDK.java.util.stream.IntStream ints(Dova.JDK.java.util.random.RandomGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;JII)Ljava/util/stream/IntStream;", "public static")]
		public static Dova.JDK.java.util.stream.IntStream ints(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
		}

		[JniSignatureAttribute("(JJJ)Ljava/util/stream/LongStream;", "public")]
		public Dova.JDK.java.util.stream.LongStream longs(long arg0, long arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;JJ)Ljava/util/stream/LongStream;", "public static")]
		public static Dova.JDK.java.util.stream.LongStream longs(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/LongStream;", "public")]
		public Dova.JDK.java.util.stream.LongStream longs(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;)Ljava/util/stream/LongStream;", "public static")]
		public static Dova.JDK.java.util.stream.LongStream longs(Dova.JDK.java.util.random.RandomGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/LongStream;", "public")]
		public Dova.JDK.java.util.stream.LongStream longs()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;JJJ)Ljava/util/stream/LongStream;", "public static")]
		public static Dova.JDK.java.util.stream.LongStream longs(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1, long arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("(JJ)Ljava/util/stream/LongStream;", "public")]
		public Dova.JDK.java.util.stream.LongStream longs(long arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;J)Ljava/util/stream/LongStream;", "public static")]
		public static Dova.JDK.java.util.stream.LongStream longs(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
		}

		[JniSignatureAttribute("(DD)Ljava/util/stream/DoubleStream;", "public")]
		public Dova.JDK.java.util.stream.DoubleStream doubles(double arg0, double arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;J)Ljava/util/stream/DoubleStream;", "public static")]
		public static Dova.JDK.java.util.stream.DoubleStream doubles(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/util/stream/DoubleStream;", "public")]
		public Dova.JDK.java.util.stream.DoubleStream doubles(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;)Ljava/util/stream/DoubleStream;", "public static")]
		public static Dova.JDK.java.util.stream.DoubleStream doubles(Dova.JDK.java.util.random.RandomGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}

		[JniSignatureAttribute("(JDD)Ljava/util/stream/DoubleStream;", "public")]
		public Dova.JDK.java.util.stream.DoubleStream doubles(long arg0, double arg1, double arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;DD)Ljava/util/stream/DoubleStream;", "public static")]
		public static Dova.JDK.java.util.stream.DoubleStream doubles(Dova.JDK.java.util.random.RandomGenerator arg0, double arg1, double arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/DoubleStream;", "public")]
		public Dova.JDK.java.util.stream.DoubleStream doubles()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;JDD)Ljava/util/stream/DoubleStream;", "public static")]
		public static Dova.JDK.java.util.stream.DoubleStream doubles(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1, double arg2, double arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$RandomDoublesSpliterator;", "public static")]
	public partial class RandomDoublesSpliterator
		: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
		, Dova.JDK.java.util.Spliterator.OfDouble
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RandomDoublesSpliterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$RandomDoublesSpliterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "D"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator;JJDD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfDouble;"));
		}

		[JniSignatureAttribute("Ljava/util/random/RandomGenerator;", "final")]
		public Dova.JDK.java.util.random.RandomGenerator generatingGenerator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("D", "final")]
		public double origin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("D", "final")]
		public double bound_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RandomDoublesSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;JJDD)V", "public")]
		public RandomDoublesSpliterator(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1, long arg2, double arg3, double arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$RandomDoublesSpliterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)V", "public")]
		public void forEachRemaining(Dova.JDK.java.util.function.DoubleConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)Z", "public")]
		public bool tryAdvance(Dova.JDK.java.util.function.DoubleConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator trySplit_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public")]
		public Dova.JDK.java.util.Spliterator.OfDouble trySplit_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$RandomLongsSpliterator;", "public static")]
	public partial class RandomLongsSpliterator
		: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
		, Dova.JDK.java.util.Spliterator.OfLong
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RandomLongsSpliterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$RandomLongsSpliterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator;JJJJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/LongConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/LongConsumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfLong;"));
		}

		[JniSignatureAttribute("Ljava/util/random/RandomGenerator;", "final")]
		public Dova.JDK.java.util.random.RandomGenerator generatingGenerator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "final")]
		public long origin_Property
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

		[JniSignatureAttribute("J", "final")]
		public long bound_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RandomLongsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;JJJJ)V", "public")]
		public RandomLongsSpliterator(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1, long arg2, long arg3, long arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$RandomLongsSpliterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public")]
		public void forEachRemaining(Dova.JDK.java.util.function.LongConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)Z", "public")]
		public bool tryAdvance(Dova.JDK.java.util.function.LongConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator trySplit_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public")]
		public Dova.JDK.java.util.Spliterator.OfLong trySplit_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$RandomIntsSpliterator;", "public static")]
	public partial class RandomIntsSpliterator
		: Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomSpliterator
		, Dova.JDK.java.util.Spliterator.OfInt
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RandomIntsSpliterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$RandomIntsSpliterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatingGenerator", "Ljava/util/random/RandomGenerator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/random/RandomGenerator;JJII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/IntConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/IntConsumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit_2", "()Ljava/util/Spliterator$OfInt;"));
		}

		[JniSignatureAttribute("Ljava/util/random/RandomGenerator;", "final")]
		public Dova.JDK.java.util.random.RandomGenerator generatingGenerator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int origin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int bound_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RandomIntsSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/random/RandomGenerator;JJII)V", "public")]
		public RandomIntsSpliterator(Dova.JDK.java.util.random.RandomGenerator arg0, long arg1, long arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$RandomIntsSpliterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
		public void forEachRemaining(Dova.JDK.java.util.function.IntConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Z", "public")]
		public bool tryAdvance(Dova.JDK.java.util.function.IntConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator trySplit_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public")]
		public Dova.JDK.java.util.Spliterator.OfInt trySplit_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$RandomSpliterator;", "public abstract static")]
	public partial class RandomSpliterator
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RandomSpliterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$RandomSpliterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fence", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characteristics", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateSize", "()J"));
		}

		[JniSignatureAttribute("J", "public")]
		public long index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("J", "public final")]
		public long fence_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RandomSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JJ)V", "public")]
		public RandomSpliterator(long arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/util/random/RandomSupport$RandomSpliterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int characteristics()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		public long estimateSize()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$RandomGeneratorProperties;", "public abstract static interface")]
	public partial interface RandomGeneratorProperties
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RandomGeneratorProperties()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/random/RandomSupport$RandomGeneratorProperties;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "i", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "k", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "j", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equidistribution", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStochastic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isHardware", "()Z"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String name()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String group()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int i()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int k()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int j()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int equidistribution()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isStochastic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isHardware()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}
	}
}
