/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.util.math.intpoly;

[JniSignatureAttribute("Lsun/security/util/math/intpoly/IntegerPolynomial;", "public abstract")]
public partial class IntegerPolynomial
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.util.math.IntegerFieldModuloP
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IntegerPolynomial()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/math/intpoly/IntegerPolynomial;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TWO", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "numLimbs", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "modulus", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bitsPerLimb", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "posModLimbs", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maxAdds", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "IntegerPolynomial", "(IIILjava/math/BigInteger;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "decode", "([J[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "encode", "(Ljava/nio/ByteBuffer;IB[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "encode", "([BIIB[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSize", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reduce", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "square", "([J[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "carry", "([JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "carry", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mult", "([J[J[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get0_0", "()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get0_1", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluate", "([J)Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement_0", "(Ljava/math/BigInteger;)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement_1", "(Ljava/math/BigInteger;)Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement_0", "([BIIB)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement_1", "([BIIB)Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reduceIn", "([JJI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finalCarryReduceLast", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPosModLimbs", "()[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLimbsValuePositive", "(Ljava/math/BigInteger;[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "encodeSmall", "(Ljava/nio/ByteBuffer;IB[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reduceHigh", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "postEncodeCarry", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "carryOut", "([JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "carryValue", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "conditionalSwap", "(I[J[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finalReduce", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addLimbs", "([J[J[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "multByInt", "([JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNumLimbs", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMaxAdds", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLimbsValue", "(Ljava/math/BigInteger;[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "conditionalAssign", "(I[J[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "limbsToByteArray", "([J[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addLimbsModPowerTwo", "([J[J[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSmallValue", "(I)Lsun/security/util/math/SmallValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get1_0", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get1_1", "()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "protected static final")]
	public static Dova.JDK.java.math.BigInteger TWO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected final")]
	public int numLimbs_Property
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

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private final")]
	public Dova.JDK.java.math.BigInteger modulus_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected final")]
	public int bitsPerLimb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("[J", "private final")]
	public JavaArray<long> posModLimbs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int maxAdds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IntegerPolynomial(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IIILjava/math/BigInteger;)V", "")]
	public IntegerPolynomial(int arg0, int arg1, int arg2, Dova.JDK.java.math.BigInteger arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/util/math/intpoly/IntegerPolynomial;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([J[BII)V", "protected")]
	public void decode(JavaArray<long> arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IB[J)V", "protected")]
	public void encode(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, byte arg2, JavaArray<long> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([BIIB[J)V", "protected")]
	public void encode(JavaArray<byte> arg0, int arg1, int arg2, byte arg3, JavaArray<long> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("([J)V", "protected abstract")]
	public void reduce(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("([J[J)V", "protected abstract")]
	public void square(JavaArray<long> arg0, JavaArray<long> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("([JII)V", "protected")]
	public void carry(JavaArray<long> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([J)V", "protected")]
	public void carry(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("([J[J[J)V", "protected abstract")]
	public void mult(JavaArray<long> arg0, JavaArray<long> arg1, JavaArray<long> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
	public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement get0_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP get0_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("([J)Ljava/math/BigInteger;", "protected")]
	public Dova.JDK.java.math.BigInteger evaluate(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;)Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP getElement_0(Dova.JDK.java.math.BigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;)Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
	public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement getElement_1(Dova.JDK.java.math.BigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
	}

	[JniSignatureAttribute("([BIIB)Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP getElement_0(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("([BIIB)Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
	public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement getElement_1(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
	}

	[JniSignatureAttribute("([JJI)V", "protected abstract")]
	public void reduceIn(JavaArray<long> arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([J)V", "protected abstract")]
	public void finalCarryReduceLast(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()[J", "private")]
	public JavaArray<long> setPosModLimbs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;[J)V", "protected")]
	public void setLimbsValuePositive(Dova.JDK.java.math.BigInteger arg0, JavaArray<long> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IB[J)V", "protected")]
	public void encodeSmall(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, byte arg2, JavaArray<long> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([J)V", "private")]
	public void reduceHigh(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("([J)V", "protected")]
	public void postEncodeCarry(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("([JI)J", "protected")]
	public long carryOut(JavaArray<long> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "protected")]
	public long carryValue(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I[J[J)V", "protected static")]
	public static void conditionalSwap(int arg0, JavaArray<long> arg1, JavaArray<long> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([J)V", "protected")]
	public void finalReduce(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("([J[J[J)V", "protected")]
	public void addLimbs(JavaArray<long> arg0, JavaArray<long> arg1, JavaArray<long> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([JJ)V", "protected")]
	public void multByInt(JavaArray<long> arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getNumLimbs()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaxAdds()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;[J)V", "private")]
	public void setLimbsValue(Dova.JDK.java.math.BigInteger arg0, JavaArray<long> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(I[J[J)V", "protected static")]
	public static void conditionalAssign(int arg0, JavaArray<long> arg1, JavaArray<long> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([J[B)V", "protected")]
	public void limbsToByteArray(JavaArray<long> arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("([J[J[B)V", "protected")]
	public void addLimbsModPowerTwo(JavaArray<long> arg0, JavaArray<long> arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)Lsun/security/util/math/SmallValue;", "public")]
	public Dova.JDK.sun.security.util.math.SmallValue getSmallValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.SmallValue>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP get1_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
	public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement get1_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
	}

	[JniSignatureAttribute("Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "")]
	public partial class ImmutableElement
		: Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.Element
		, Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImmutableElement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ImmutableElement", "(Lsun/security/util/math/intpoly/IntegerPolynomial;[JI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ImmutableElement", "(Lsun/security/util/math/intpoly/IntegerPolynomial;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ImmutableElement", "(Lsun/security/util/math/intpoly/IntegerPolynomial;Ljava/math/BigInteger;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed_0", "()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed_1", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImmutableElement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/intpoly/IntegerPolynomial;[JI)V", "protected")]
		public ImmutableElement(Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial arg0, JavaArray<long> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/intpoly/IntegerPolynomial;Z)V", "protected")]
		public ImmutableElement(Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/intpoly/IntegerPolynomial;Ljava/math/BigInteger;)V", "protected")]
		public ImmutableElement(Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial arg0, Dova.JDK.java.math.BigInteger arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement fixed_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP fixed_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/intpoly/IntegerPolynomial$Limb;", "static")]
	public partial class Limb
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.util.math.SmallValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Limb()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/math/intpoly/IntegerPolynomial$Limb;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "value", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Limb", "(I)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int value_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Limb(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public Limb(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/math/intpoly/IntegerPolynomial$Limb;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "protected")]
	public partial class MutableElement
		: Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.Element
		, Dova.JDK.sun.security.util.math.MutableIntegerModuloP
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MutableElement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lsun/security/util/math/intpoly/IntegerPolynomial;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MutableElement", "(Lsun/security/util/math/intpoly/IntegerPolynomial;[JI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_0", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_1", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_0", "(Ljava/nio/ByteBuffer;IB)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_1", "(Ljava/nio/ByteBuffer;IB)Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_0", "([BIIB)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_1", "([BIIB)Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed_0", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed_1", "()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "conditionalSwapWith", "(Lsun/security/util/math/MutableIntegerModuloP;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setProduct_0", "(Lsun/security/util/math/SmallValue;)Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setProduct_1", "(Lsun/security/util/math/SmallValue;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setProduct_0", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setProduct_1", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setAdditiveInverse_0", "()Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setAdditiveInverse_1", "()Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "conditionalSet", "(Lsun/security/util/math/IntegerModuloP;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSum_0", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSum_1", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSquare_0", "()Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSquare_1", "()Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDifference_0", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDifference_1", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setReduced_0", "()Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setReduced_1", "()Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
		}

		[JniSignatureAttribute("Lsun/security/util/math/intpoly/IntegerPolynomial;", "final")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MutableElement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/intpoly/IntegerPolynomial;[JI)V", "protected")]
		public MutableElement(Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial arg0, JavaArray<long> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue_0(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setValue_1(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IB)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setValue_0(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IB)Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue_1(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("([BIIB)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setValue_0(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("([BIIB)Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue_1(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP fixed_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement fixed_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/MutableIntegerModuloP;I)V", "public")]
		public void conditionalSwapWith(Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/SmallValue;)Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setProduct_0(Dova.JDK.sun.security.util.math.SmallValue arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/SmallValue;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setProduct_1(Dova.JDK.sun.security.util.math.SmallValue arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setProduct_0(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setProduct_1(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setAdditiveInverse_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setAdditiveInverse_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;I)V", "public")]
		public void conditionalSet(Dova.JDK.sun.security.util.math.IntegerModuloP arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setSum_0(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setSum_1(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setSquare_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setSquare_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setDifference_0(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setDifference_1(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP setReduced_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement setReduced_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/intpoly/IntegerPolynomial$Element;", "private abstract")]
	public partial class Element
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.util.math.IntegerModuloP
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Element()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/math/intpoly/IntegerPolynomial$Element;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "limbs", "[J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "numAdds", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lsun/security/util/math/intpoly/IntegerPolynomial;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Element", "(Lsun/security/util/math/intpoly/IntegerPolynomial;[JI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Element", "(Lsun/security/util/math/intpoly/IntegerPolynomial;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Element", "(Lsun/security/util/math/intpoly/IntegerPolynomial;Ljava/math/BigInteger;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "add_0", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "add_1", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getField", "()Lsun/security/util/math/IntegerFieldModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue", "(Ljava/math/BigInteger;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "multiply_0", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "multiply_1", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "square_0", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "square_1", "()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asByteArray", "([B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSummand", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyLow", "([J[J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cloneLow", "([J)[J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addModPowerTwo", "(Lsun/security/util/math/IntegerModuloP;[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asBigInteger", "()Ljava/math/BigInteger;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "additiveInverse_0", "()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "additiveInverse_1", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mutable_0", "()Lsun/security/util/math/MutableIntegerModuloP;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mutable_1", "()Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;"));
		}

		[JniSignatureAttribute("[J", "protected")]
		public JavaArray<long> limbs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "protected")]
		public int numAdds_Property
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

		[JniSignatureAttribute("Lsun/security/util/math/intpoly/IntegerPolynomial;", "final")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Element(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/intpoly/IntegerPolynomial;[JI)V", "private")]
		public Element(Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial arg0, JavaArray<long> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/intpoly/IntegerPolynomial;Z)V", "public")]
		public Element(Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/intpoly/IntegerPolynomial;Ljava/math/BigInteger;)V", "public")]
		public Element(Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial arg0, Dova.JDK.java.math.BigInteger arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/math/intpoly/IntegerPolynomial$Element;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement add_0(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP add_1(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/IntegerFieldModuloP;", "public")]
		public Dova.JDK.sun.security.util.math.IntegerFieldModuloP getField()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
		}

		[JniSignatureAttribute("(Ljava/math/BigInteger;)V", "private")]
		public void setValue(Dova.JDK.java.math.BigInteger arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement multiply_0(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP multiply_1(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP square_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement square_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
		}

		[JniSignatureAttribute("([B)V", "public")]
		public void asByteArray(JavaArray<byte> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()Z", "protected")]
		public bool isSummand()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("([J[J)V", "protected")]
		public void copyLow(JavaArray<long> arg0, JavaArray<long> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("([J)[J", "protected")]
		public JavaArray<long> cloneLow(JavaArray<long> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;[B)V", "public")]
		public void addModPowerTwo(Dova.JDK.sun.security.util.math.IntegerModuloP arg0, JavaArray<byte> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
		public Dova.JDK.java.math.BigInteger asBigInteger()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$ImmutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement additiveInverse_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.ImmutableElement>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP additiveInverse_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public volatile")]
		public Dova.JDK.sun.security.util.math.MutableIntegerModuloP mutable_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/math/intpoly/IntegerPolynomial$MutableElement;", "public")]
		public Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement mutable_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.intpoly.IntegerPolynomial.MutableElement>(ret);
		}
	}
}
