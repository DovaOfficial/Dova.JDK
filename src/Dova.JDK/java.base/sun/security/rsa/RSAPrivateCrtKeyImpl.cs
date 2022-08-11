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

namespace Dova.JDK.sun.security.rsa;

[JniSignatureAttribute("Lsun/security/rsa/RSAPrivateCrtKeyImpl;", "public final")]
public partial class RSAPrivateCrtKeyImpl
	: Dova.JDK.sun.security.pkcs.PKCS8Key
	, Dova.JDK.java.security.interfaces.RSAPrivateCrtKey
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RSAPrivateCrtKeyImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/rsa/RSAPrivateCrtKeyImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "n", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "e", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "d", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "p", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "q", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pe", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qe", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "coeff", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lsun/security/rsa/RSAUtil$KeyType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyParams", "Ljava/security/spec/AlgorithmParameterSpec;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/rsa/RSAUtil$KeyType;Ljava/security/spec/AlgorithmParameterSpec;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModulus", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrivateExponent", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimeP", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimeQ", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimeExponentP", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimeExponentQ", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCrtCoefficient", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newKey", "(Lsun/security/rsa/RSAUtil$KeyType;Ljava/lang/String;[B)Ljava/security/interfaces/RSAPrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newKey", "(Lsun/security/rsa/RSAUtil$KeyType;Ljava/security/spec/AlgorithmParameterSpec;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/security/interfaces/RSAPrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParams", "()Ljava/security/spec/AlgorithmParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlgorithm", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkComponents", "(Ljava/security/interfaces/RSAPrivateCrtKey;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseASN1", "([B)[Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseKeyBits", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPublicExponent", "()Ljava/math/BigInteger;"));
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

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger n_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger e_Property
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

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger d_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger p_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger q_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger pe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger qe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger coeff_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/rsa/RSAUtil$KeyType;", "private transient")]
	public Dova.JDK.sun.security.rsa.RSAUtil.KeyType type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.rsa.RSAUtil.KeyType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/spec/AlgorithmParameterSpec;", "private transient")]
	public Dova.JDK.java.security.spec.AlgorithmParameterSpec keyParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.AlgorithmParameterSpec>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RSAPrivateCrtKeyImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/rsa/RSAUtil$KeyType;Ljava/security/spec/AlgorithmParameterSpec;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", "")]
	public RSAPrivateCrtKeyImpl(Dova.JDK.sun.security.rsa.RSAUtil.KeyType arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1, Dova.JDK.java.math.BigInteger arg2, Dova.JDK.java.math.BigInteger arg3, Dova.JDK.java.math.BigInteger arg4, Dova.JDK.java.math.BigInteger arg5, Dova.JDK.java.math.BigInteger arg6, Dova.JDK.java.math.BigInteger arg7, Dova.JDK.java.math.BigInteger arg8, Dova.JDK.java.math.BigInteger arg9) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
	{
	}

	[JniSignatureAttribute("([B)V", "private")]
	public RSAPrivateCrtKeyImpl(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/rsa/RSAPrivateCrtKeyImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getModulus()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getPrivateExponent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getPrimeP()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getPrimeQ()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getPrimeExponentP()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getPrimeExponentQ()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getCrtCoefficient()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/rsa/RSAUtil$KeyType;Ljava/lang/String;[B)Ljava/security/interfaces/RSAPrivateKey;", "public static")]
	public static Dova.JDK.java.security.interfaces.RSAPrivateKey newKey(Dova.JDK.sun.security.rsa.RSAUtil.KeyType arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.RSAPrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/rsa/RSAUtil$KeyType;Ljava/security/spec/AlgorithmParameterSpec;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/security/interfaces/RSAPrivateKey;", "public static")]
	public static Dova.JDK.java.security.interfaces.RSAPrivateKey newKey(Dova.JDK.sun.security.rsa.RSAUtil.KeyType arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1, Dova.JDK.java.math.BigInteger arg2, Dova.JDK.java.math.BigInteger arg3, Dova.JDK.java.math.BigInteger arg4, Dova.JDK.java.math.BigInteger arg5, Dova.JDK.java.math.BigInteger arg6, Dova.JDK.java.math.BigInteger arg7, Dova.JDK.java.math.BigInteger arg8, Dova.JDK.java.math.BigInteger arg9)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.RSAPrivateKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/spec/AlgorithmParameterSpec;", "public")]
	public Dova.JDK.java.security.spec.AlgorithmParameterSpec getParams()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.AlgorithmParameterSpec>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getAlgorithm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/interfaces/RSAPrivateCrtKey;)Z", "static")]
	public static bool checkComponents(Dova.JDK.java.security.interfaces.RSAPrivateCrtKey arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("([B)[Ljava/math/BigInteger;", "private static")]
	public static JavaArray<Dova.JDK.java.math.BigInteger> parseASN1(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.math.BigInteger>>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void parseKeyBits()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getPublicExponent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}
}
