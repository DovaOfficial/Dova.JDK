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

namespace Dova.JDK.sun.security.pkcs11;

[JniSignatureAttribute("Lsun/security/pkcs11/P11ECKeyFactory;", "final")]
public partial class P11ECKeyFactory
	: Dova.JDK.sun.security.pkcs11.P11KeyFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static P11ECKeyFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/P11ECKeyFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "sunECprovider", "Ljava/security/Provider;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "P11ECKeyFactory", "(Lsun/security/pkcs11/Token;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSunECProvider", "()Ljava/security/Provider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getECParameterSpec", "(I)Ljava/security/spec/ECParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getECParameterSpec", "(Ljava/security/spec/ECParameterSpec;)Ljava/security/spec/ECParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getECParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/ECParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "decodePoint", "([BLjava/security/spec/EllipticCurve;)Ljava/security/spec/ECPoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "decodeParameters", "([B)Ljava/security/spec/ECParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "encodeParameters", "(Ljava/security/spec/ECParameterSpec;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "generatePublic", "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "generatePrivate", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "implTranslatePublicKey", "(Ljava/security/PublicKey;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "implTranslatePrivateKey", "(Ljava/security/PrivateKey;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "implGetPublicKeySpec", "(Lsun/security/pkcs11/P11Key;Ljava/lang/Class;[Lsun/security/pkcs11/Session;)Ljava/security/spec/KeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "implGetPrivateKeySpec", "(Lsun/security/pkcs11/P11Key;Ljava/lang/Class;[Lsun/security/pkcs11/Session;)Ljava/security/spec/KeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "implGetSoftwareFactory", "()Ljava/security/KeyFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getEncodedPublicValue", "(Ljava/security/PublicKey;)[B"));
	}

	[JniSignatureAttribute("Ljava/security/Provider;", "private static")]
	public static Dova.JDK.java.security.Provider sunECprovider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public P11ECKeyFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;Ljava/lang/String;)V", "")]
	public P11ECKeyFactory(Dova.JDK.sun.security.pkcs11.Token arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/P11ECKeyFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/security/Provider;", "private static")]
	public static Dova.JDK.java.security.Provider getSunECProvider()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/security/spec/ECParameterSpec;", "static")]
	public static Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/ECParameterSpec;)Ljava/security/spec/ECParameterSpec;", "static")]
	public static Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec(Dova.JDK.java.security.spec.ECParameterSpec arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/security/spec/ECParameterSpec;", "static")]
	public static Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
	}

	[JniSignatureAttribute("([BLjava/security/spec/EllipticCurve;)Ljava/security/spec/ECPoint;", "static")]
	public static Dova.JDK.java.security.spec.ECPoint decodePoint(JavaArray<byte> arg0, Dova.JDK.java.security.spec.EllipticCurve arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECPoint>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/security/spec/ECParameterSpec;", "static")]
	public static Dova.JDK.java.security.spec.ECParameterSpec decodeParameters(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/ECParameterSpec;)[B", "static")]
	public static JavaArray<byte> encodeParameters(Dova.JDK.java.security.spec.ECParameterSpec arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)Ljava/security/PublicKey;", "private")]
	public Dova.JDK.java.security.PublicKey generatePublic(Dova.JDK.java.security.spec.ECPoint arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)Ljava/security/PrivateKey;", "private")]
	public Dova.JDK.java.security.PrivateKey generatePrivate(Dova.JDK.java.math.BigInteger arg0, Dova.JDK.java.security.spec.ECParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)Ljava/security/PublicKey;", "")]
	public Dova.JDK.java.security.PublicKey implTranslatePublicKey(Dova.JDK.java.security.PublicKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivateKey;)Ljava/security/PrivateKey;", "")]
	public Dova.JDK.java.security.PrivateKey implTranslatePrivateKey(Dova.JDK.java.security.PrivateKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", "protected")]
	public Dova.JDK.java.security.PublicKey engineGeneratePublic(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", "protected")]
	public Dova.JDK.java.security.PrivateKey engineGeneratePrivate(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/P11Key;Ljava/lang/Class;[Lsun/security/pkcs11/Session;)Ljava/security/spec/KeySpec;", "")]
	public Dova.JDK.java.lang.Object implGetPublicKeySpec(Dova.JDK.sun.security.pkcs11.P11Key arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.sun.security.pkcs11.Session> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/P11Key;Ljava/lang/Class;[Lsun/security/pkcs11/Session;)Ljava/security/spec/KeySpec;", "")]
	public Dova.JDK.java.lang.Object implGetPrivateKeySpec(Dova.JDK.sun.security.pkcs11.P11Key arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.sun.security.pkcs11.Session> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/KeyFactory;", "")]
	public Dova.JDK.java.security.KeyFactory implGetSoftwareFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)[B", "static")]
	public static JavaArray<byte> getEncodedPublicValue(Dova.JDK.java.security.PublicKey arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
