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

namespace Dova.JDK.java.math;

[JniSignatureAttribute("Ljava/math/MutableBigInteger;", "")]
public partial class MutableBigInteger
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MutableBigInteger()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/math/MutableBigInteger;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "intLen", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONE", "Ljava/math/MutableBigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KNUTH_POW2_THRESH_LEN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KNUTH_POW2_THRESH_ZEROS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/math/MutableBigInteger;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/math/BigInteger;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/math/MutableBigInteger;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sqrt", "()Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/math/MutableBigInteger;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "([II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInt", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureCapacity", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multiply", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bitLength", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subtract", "(Ljava/math/MutableBigInteger;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowestSetBit", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLower", "(I)Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "primitiveLeftShift", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divideKnuth", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;Z)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divideKnuth", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toBigInteger", "(I)Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toBigInteger", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divideAndRemainderBurnikelZiegler", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isZero", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hybridGCD", "(Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "primitiveRightShift", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modInverse", "(Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divide", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divide", "(JLjava/math/MutableBigInteger;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divide", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;Z)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inverseMod64", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leftShift", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toIntArray", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutableModInverse", "(Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "difference", "(Ljava/math/MutableBigInteger;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mul", "(ILjava/math/MutableBigInteger;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlock", "(III)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLong", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toBigDecimal", "(II)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCompactValue", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOdd", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareHalf", "(Ljava/math/MutableBigInteger;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsignedLongCompare", "(JJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mulsub", "([I[IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMagnitudeArray", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rightShift", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyValue", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyValue", "(Ljava/math/MutableBigInteger;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "divWord", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divideOneWord", "(ILjava/math/MutableBigInteger;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divideMagnitude", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;Z)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "safeLeftShift", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDisjoint", "(Ljava/math/MutableBigInteger;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divide2n1n", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addShifted", "(Ljava/math/MutableBigInteger;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "safeRightShift", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "keepLower", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divide3n2n", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareShifted", "(Ljava/math/MutableBigInteger;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ones", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLower", "(Ljava/math/MutableBigInteger;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divideLongMagnitude", "(JLjava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyAndShift", "([III[III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divadd", "([I[II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mulsubBorrow", "([I[IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mulsubLong", "([IIIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "divaddLong", "(II[II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "binaryGCD", "(Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binaryGcd", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEven", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOne", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modInverseMP2", "(I)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "modInverseBP2", "(Ljava/math/MutableBigInteger;I)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "euclidModInverse", "(I)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inverseMod32", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fixup", "(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;I)Ljava/math/MutableBigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNormal", "()Z"));
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int intLen_Property
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

	[JniSignatureAttribute("I", "")]
	public int offset_Property
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

	[JniSignatureAttribute("Ljava/math/MutableBigInteger;", "static final")]
	public static Dova.JDK.java.math.MutableBigInteger ONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int KNUTH_POW2_THRESH_LEN_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int KNUTH_POW2_THRESH_ZEROS_Property
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

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MutableBigInteger(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)V", "")]
	public MutableBigInteger(Dova.JDK.java.math.MutableBigInteger arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;)V", "")]
	public MutableBigInteger(Dova.JDK.java.math.BigInteger arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("([I)V", "")]
	public MutableBigInteger(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(I)V", "")]
	public MutableBigInteger(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("()V", "")]
	public MutableBigInteger() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/math/MutableBigInteger;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)V", "")]
	public void add(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger sqrt()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(I)I", "private final")]
	public int getInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "private final")]
	public long getLong(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)I", "final")]
	public int compare(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("([II)V", "")]
	public void setValue(JavaArray<int> arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "")]
	public void setInt(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "final")]
	public void normalize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(I)V", "private final")]
	public void ensureCapacity(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)V", "")]
	public void multiply(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("()J", "")]
	public long bitLength()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)I", "")]
	public int subtract(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "private final")]
	public int getLowestSetBit()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger getLower(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("(I)V", "private final")]
	public void primitiveLeftShift(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;Z)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger divideKnuth(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger divideKnuth(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/math/BigInteger;", "")]
	public Dova.JDK.java.math.BigInteger toBigInteger(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "")]
	public Dova.JDK.java.math.BigInteger toBigInteger()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger divideAndRemainderBurnikelZiegler(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isZero()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger hybridGCD(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(I)V", "private final")]
	public void primitiveRightShift(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "private")]
	public Dova.JDK.java.math.MutableBigInteger modInverse(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger divide(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(JLjava/math/MutableBigInteger;)J", "")]
	public long divide(long arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;Z)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger divide(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(J)J", "static")]
	public static long inverseMod64(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "")]
	public void leftShift(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("()[I", "")]
	public JavaArray<int> toIntArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger mutableModInverse(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)I", "private")]
	public int difference(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/math/MutableBigInteger;)V", "")]
	public void mul(int arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(III)Ljava/math/MutableBigInteger;", "private")]
	public Dova.JDK.java.math.MutableBigInteger getBlock(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("()J", "private")]
	public long toLong()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/math/BigDecimal;", "")]
	public Dova.JDK.java.math.BigDecimal toBigDecimal(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(I)J", "")]
	public long toCompactValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isOdd()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)I", "final")]
	public int compareHalf(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)Z", "private")]
	public bool unsignedLongCompare(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([I[IIII)I", "private")]
	public int mulsub(JavaArray<int> arg0, JavaArray<int> arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("()[I", "private")]
	public JavaArray<int> getMagnitudeArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void rightShift(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("([I)V", "")]
	public void copyValue(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)V", "")]
	public void copyValue(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(JI)J", "static")]
	public static long divWord(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/math/MutableBigInteger;)I", "")]
	public int divideOneWord(int arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;Z)Ljava/math/MutableBigInteger;", "private")]
	public Dova.JDK.java.math.MutableBigInteger divideMagnitude(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void safeLeftShift(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;I)V", "")]
	public void addDisjoint(Dova.JDK.java.math.MutableBigInteger arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "private")]
	public Dova.JDK.java.math.MutableBigInteger divide2n1n(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;I)V", "")]
	public void addShifted(Dova.JDK.java.math.MutableBigInteger arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void safeRightShift(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void keepLower(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "private")]
	public Dova.JDK.java.math.MutableBigInteger divide3n2n(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;I)I", "private")]
	public int compareShifted(Dova.JDK.java.math.MutableBigInteger arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void ones(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;I)V", "")]
	public void addLower(Dova.JDK.java.math.MutableBigInteger arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
	}

	[JniSignatureAttribute("(JLjava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "private")]
	public Dova.JDK.java.math.MutableBigInteger divideLongMagnitude(long arg0, Dova.JDK.java.math.MutableBigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("([III[III)V", "private static")]
	public static void copyAndShift(JavaArray<int> arg0, int arg1, int arg2, JavaArray<int> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("([I[II)I", "private")]
	public int divadd(JavaArray<int> arg0, JavaArray<int> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([I[IIII)I", "private")]
	public int mulsubBorrow(JavaArray<int> arg0, JavaArray<int> arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([IIIII)I", "private")]
	public int mulsubLong(JavaArray<int> arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(II[II)I", "private")]
	public int divaddLong(int arg0, int arg1, JavaArray<int> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;)Ljava/math/MutableBigInteger;", "private")]
	public Dova.JDK.java.math.MutableBigInteger binaryGCD(Dova.JDK.java.math.MutableBigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(II)I", "static")]
	public static int binaryGcd(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isEven()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isOne()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[70]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger modInverseMP2(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;I)Ljava/math/MutableBigInteger;", "static")]
	public static Dova.JDK.java.math.MutableBigInteger modInverseBP2(Dova.JDK.java.math.MutableBigInteger arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/math/MutableBigInteger;", "")]
	public Dova.JDK.java.math.MutableBigInteger euclidModInverse(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("(I)I", "static")]
	public static int inverseMod32(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[74], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/MutableBigInteger;Ljava/math/MutableBigInteger;I)Ljava/math/MutableBigInteger;", "static")]
	public static Dova.JDK.java.math.MutableBigInteger fixup(Dova.JDK.java.math.MutableBigInteger arg0, Dova.JDK.java.math.MutableBigInteger arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.MutableBigInteger>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isNormal()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[76]);
		return ret;
	}
}
