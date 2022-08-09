/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.util;

[JniSignatureAttribute("Lsun/security/util/ECUtil;", "public final")]
public partial class ECUtil
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ECUtil()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/util/ECUtil;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ECUtil", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "equals", "(Ljava/security/spec/ECParameterSpec;Ljava/security/spec/ECParameterSpec;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "encodeECParameterSpec", "(Ljava/security/Provider;Ljava/security/spec/ECParameterSpec;)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getECParameterSpec", "(Ljava/security/Provider;Ljava/lang/String;)Ljava/security/spec/ECParameterSpec;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getECParameterSpec", "(Ljava/security/Provider;Ljava/security/spec/ECParameterSpec;)Ljava/security/spec/ECParameterSpec;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getECParameterSpec", "(Ljava/security/Provider;I)Ljava/security/spec/ECParameterSpec;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getECParameterSpec", "(Ljava/security/Provider;[B)Ljava/security/spec/ECParameterSpec;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "decodePoint", "([BLjava/security/spec/EllipticCurve;)Ljava/security/spec/ECPoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "encodePoint", "(Ljava/security/spec/ECPoint;Ljava/security/spec/EllipticCurve;)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "decodeX509ECPublicKey", "([B)Ljava/security/interfaces/ECPublicKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "decodePKCS8ECPrivateKey", "([B)Ljava/security/interfaces/ECPrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getCurveName", "(Ljava/security/Provider;Ljava/security/spec/ECParameterSpec;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "x509EncodeECPublicKey", "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "generateECPrivateKey", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)Ljava/security/interfaces/ECPrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyFactory", "()Ljava/security/KeyFactory;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "trimZeroes", "([B)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "checkPrivateKey", "(Ljava/security/interfaces/ECPrivateKey;)Ljava/security/interfaces/ECPrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "sArray", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "encodeSignature", "([B)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "decodeSignature", "([B)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getECParameters", "(Ljava/security/Provider;)Ljava/security/AlgorithmParameters;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ECUtil(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ECUtil() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/util/ECUtil;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/spec/ECParameterSpec;Ljava/security/spec/ECParameterSpec;)Z", "public static")]
	public static bool equals(Dova.JDK.java.security.spec.ECParameterSpec arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/Provider;Ljava/security/spec/ECParameterSpec;)[B", "public static")]
	public static JavaArray<byte> encodeECParameterSpec(Dova.JDK.java.security.Provider arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Provider;Ljava/lang/String;)Ljava/security/spec/ECParameterSpec;", "public static")]
	public static Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec(Dova.JDK.java.security.Provider arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Provider;Ljava/security/spec/ECParameterSpec;)Ljava/security/spec/ECParameterSpec;", "public static")]
	public static Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec(Dova.JDK.java.security.Provider arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Provider;I)Ljava/security/spec/ECParameterSpec;", "public static")]
	public static Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec(Dova.JDK.java.security.Provider arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Provider;[B)Ljava/security/spec/ECParameterSpec;", "public static")]
	public static Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec(Dova.JDK.java.security.Provider arg0, JavaArray<byte> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
	}

	[JniSignatureAttribute("([BLjava/security/spec/EllipticCurve;)Ljava/security/spec/ECPoint;", "public static")]
	public static Dova.JDK.java.security.spec.ECPoint decodePoint(JavaArray<byte> arg0, Dova.JDK.java.security.spec.EllipticCurve arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECPoint>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/ECPoint;Ljava/security/spec/EllipticCurve;)[B", "public static")]
	public static JavaArray<byte> encodePoint(Dova.JDK.java.security.spec.ECPoint arg0, Dova.JDK.java.security.spec.EllipticCurve arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/security/interfaces/ECPublicKey;", "public static")]
	public static Dova.JDK.java.security.interfaces.ECPublicKey decodeX509ECPublicKey(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.ECPublicKey>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/security/interfaces/ECPrivateKey;", "public static")]
	public static Dova.JDK.java.security.interfaces.ECPrivateKey decodePKCS8ECPrivateKey(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.ECPrivateKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Provider;Ljava/security/spec/ECParameterSpec;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getCurveName(Dova.JDK.java.security.Provider arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)[B", "public static")]
	public static JavaArray<byte> x509EncodeECPublicKey(Dova.JDK.java.security.spec.ECPoint arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)Ljava/security/interfaces/ECPrivateKey;", "public static")]
	public static Dova.JDK.java.security.interfaces.ECPrivateKey generateECPrivateKey(Dova.JDK.java.math.BigInteger arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.ECPrivateKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/KeyFactory;", "private static")]
	public static Dova.JDK.java.security.KeyFactory getKeyFactory()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyFactory>(ret);
	}

	[JniSignatureAttribute("([B)[B", "public static")]
	public static JavaArray<byte> trimZeroes(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/interfaces/ECPrivateKey;)Ljava/security/interfaces/ECPrivateKey;", "public static")]
	public static Dova.JDK.java.security.interfaces.ECPrivateKey checkPrivateKey(Dova.JDK.java.security.interfaces.ECPrivateKey arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.ECPrivateKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)[B", "public static")]
	public static JavaArray<byte> sArray(Dova.JDK.java.math.BigInteger arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)[B", "public static")]
	public static JavaArray<byte> encodeSignature(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)[B", "public static")]
	public static JavaArray<byte> decodeSignature(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Provider;)Ljava/security/AlgorithmParameters;", "public static")]
	public static Dova.JDK.java.security.AlgorithmParameters getECParameters(Dova.JDK.java.security.Provider arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmParameters>(ret);
	}
}
