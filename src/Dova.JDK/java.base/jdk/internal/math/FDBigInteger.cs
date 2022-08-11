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

namespace Dova.JDK.jdk.@internal.math;

[JniSignatureAttribute("Ljdk/internal/math/FDBigInteger;", "public")]
public partial class FDBigInteger
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FDBigInteger()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/math/FDBigInteger;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SMALL_5_POW", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG_5_POW", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_FIVE_POW", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POW_5_CACHE", "[Ljdk/internal/math/FDBigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO", "Ljdk/internal/math/FDBigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "archivedCaches", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG_MASK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nWords", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isImmutable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J[CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljdk/internal/math/FDBigInteger;)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHexString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmp", "(Ljdk/internal/math/FDBigInteger;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toBigInteger", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leftShift", "(I)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "leftShift", "([II[IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mult", "([IIII[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mult", "([II[II[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mult", "(Ljdk/internal/math/FDBigInteger;)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mult", "(I)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mult", "([III[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trimLeadingZeros", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multAddMe", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "big5pow", "(I)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOfPow2", "(I)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "multAndCarryBy10", "([II[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multDiffMe", "(JLjdk/internal/math/FDBigInteger;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkZeroTail", "([II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "big5powRec", "(I)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeImmutable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOfPow52", "(II)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOfMulPow52", "(JII)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNormalizationBias", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "quoRemIteration", "(Ljdk/internal/math/FDBigInteger;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multBy10", "()Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multByPow52", "(II)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leftInplaceSub", "(Ljdk/internal/math/FDBigInteger;)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rightInplaceSub", "(Ljdk/internal/math/FDBigInteger;)Ljdk/internal/math/FDBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmpPow52", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAndCmp", "(Ljdk/internal/math/FDBigInteger;Ljdk/internal/math/FDBigInteger;)I"));
	}

	[JniSignatureAttribute("[I", "static final")]
	public static JavaArray<int> SMALL_5_POW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[J", "static final")]
	public static JavaArray<long> LONG_5_POW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_FIVE_POW_Property
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

	[JniSignatureAttribute("[Ljdk/internal/math/FDBigInteger;", "private static final")]
	public static JavaArray<Dova.JDK.jdk.@internal.math.FDBigInteger> POW_5_CACHE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.math.FDBigInteger>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/math/FDBigInteger;", "public static final")]
	public static Dova.JDK.jdk.@internal.math.FDBigInteger ZERO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.Object> archivedCaches_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long LONG_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> data_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int offset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int nWords_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isImmutable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FDBigInteger(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([II)V", "private")]
	public FDBigInteger(JavaArray<int> arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(J[CII)V", "public")]
	public FDBigInteger(long arg0, JavaArray<char> arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/math/FDBigInteger;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/math/FDBigInteger;)Ljdk/internal/math/FDBigInteger;", "private")]
	public Dova.JDK.jdk.@internal.math.FDBigInteger add(Dova.JDK.jdk.@internal.math.FDBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toHexString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/math/FDBigInteger;)I", "public")]
	public int cmp(Dova.JDK.jdk.@internal.math.FDBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger toBigInteger()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/math/FDBigInteger;", "public")]
	public Dova.JDK.jdk.@internal.math.FDBigInteger leftShift(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("([II[IIII)V", "private static")]
	public static void leftShift(JavaArray<int> arg0, int arg1, JavaArray<int> arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("([IIII[I)V", "private static")]
	public static void mult(JavaArray<int> arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("([II[II[I)V", "private static")]
	public static void mult(JavaArray<int> arg0, int arg1, JavaArray<int> arg2, int arg3, JavaArray<int> arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/math/FDBigInteger;)Ljdk/internal/math/FDBigInteger;", "private")]
	public Dova.JDK.jdk.@internal.math.FDBigInteger mult(Dova.JDK.jdk.@internal.math.FDBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/math/FDBigInteger;", "private")]
	public Dova.JDK.jdk.@internal.math.FDBigInteger mult(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("([III[I)V", "private static")]
	public static void mult(JavaArray<int> arg0, int arg1, int arg2, JavaArray<int> arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "private")]
	public void trimLeadingZeros()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void multAddMe(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/math/FDBigInteger;", "private static")]
	public static Dova.JDK.jdk.@internal.math.FDBigInteger big5pow(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/math/FDBigInteger;", "private static")]
	public static Dova.JDK.jdk.@internal.math.FDBigInteger valueOfPow2(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("([II[I)I", "private static")]
	public static int multAndCarryBy10(JavaArray<int> arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JLjdk/internal/math/FDBigInteger;)J", "private")]
	public long multDiffMe(long arg0, Dova.JDK.jdk.@internal.math.FDBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([II)I", "private static")]
	public static int checkZeroTail(JavaArray<int> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljdk/internal/math/FDBigInteger;", "private static")]
	public static Dova.JDK.jdk.@internal.math.FDBigInteger big5powRec(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void makeImmutable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("(II)Ljdk/internal/math/FDBigInteger;", "public static")]
	public static Dova.JDK.jdk.@internal.math.FDBigInteger valueOfPow52(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("(JII)Ljdk/internal/math/FDBigInteger;", "public static")]
	public static Dova.JDK.jdk.@internal.math.FDBigInteger valueOfMulPow52(long arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNormalizationBias()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/math/FDBigInteger;)I", "public")]
	public int quoRemIteration(Dova.JDK.jdk.@internal.math.FDBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/math/FDBigInteger;", "public")]
	public Dova.JDK.jdk.@internal.math.FDBigInteger multBy10()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("(II)Ljdk/internal/math/FDBigInteger;", "public")]
	public Dova.JDK.jdk.@internal.math.FDBigInteger multByPow52(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/math/FDBigInteger;)Ljdk/internal/math/FDBigInteger;", "public")]
	public Dova.JDK.jdk.@internal.math.FDBigInteger leftInplaceSub(Dova.JDK.jdk.@internal.math.FDBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/math/FDBigInteger;)Ljdk/internal/math/FDBigInteger;", "public")]
	public Dova.JDK.jdk.@internal.math.FDBigInteger rightInplaceSub(Dova.JDK.jdk.@internal.math.FDBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.math.FDBigInteger>(ret);
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int cmpPow52(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/math/FDBigInteger;Ljdk/internal/math/FDBigInteger;)I", "public")]
	public int addAndCmp(Dova.JDK.jdk.@internal.math.FDBigInteger arg0, Dova.JDK.jdk.@internal.math.FDBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return ret;
	}
}
