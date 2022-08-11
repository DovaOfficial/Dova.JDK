/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
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

[JniSignatureAttribute("Lsun/security/pkcs11/P11SecretKeyFactory;", "final")]
public partial class P11SecretKeyFactory
	: Dova.JDK.javax.crypto.SecretKeyFactorySpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static P11SecretKeyFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/P11SecretKeyFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lsun/security/pkcs11/Token;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "keyTypes", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/Token;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getKeyType", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertKey", "(Lsun/security/pkcs11/Token;Ljava/security/Key;Ljava/lang/String;)Lsun/security/pkcs11/P11Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertKey", "(Lsun/security/pkcs11/Token;Ljava/security/Key;Ljava/lang/String;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)Lsun/security/pkcs11/P11Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createKey", "(Lsun/security/pkcs11/Token;[BLjava/lang/String;J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)Lsun/security/pkcs11/P11Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyBytes", "(Ljavax/crypto/SecretKey;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineTranslateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addKeyType", "(Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPKCS11KeyType", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fixDESParity", "([BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGenerateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;"));
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/Token;", "private final")]
	public Dova.JDK.sun.security.pkcs11.Token token_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Token>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String algorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map keyTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public P11SecretKeyFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;Ljava/lang/String;)V", "")]
	public P11SecretKeyFactory(Dova.JDK.sun.security.pkcs11.Token arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/P11SecretKeyFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)J", "static")]
	public static long getKeyType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;Ljava/security/Key;Ljava/lang/String;)Lsun/security/pkcs11/P11Key;", "static")]
	public static Dova.JDK.sun.security.pkcs11.P11Key convertKey(Dova.JDK.sun.security.pkcs11.Token arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11Key>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;Ljava/security/Key;Ljava/lang/String;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)Lsun/security/pkcs11/P11Key;", "static")]
	public static Dova.JDK.sun.security.pkcs11.P11Key convertKey(Dova.JDK.sun.security.pkcs11.Token arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11Key>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;[BLjava/lang/String;J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)Lsun/security/pkcs11/P11Key;", "private static")]
	public static Dova.JDK.sun.security.pkcs11.P11Key createKey(Dova.JDK.sun.security.pkcs11.Token arg0, JavaArray<byte> arg1, Dova.JDK.java.lang.String arg2, long arg3, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11Key>(ret);
	}

	[JniSignatureAttribute("(Ljavax/crypto/SecretKey;)[B", "private")]
	public JavaArray<byte> getKeyBytes(Dova.JDK.javax.crypto.SecretKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", "protected")]
	public Dova.JDK.javax.crypto.SecretKey engineTranslateKey(Dova.JDK.javax.crypto.SecretKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;J)V", "private static")]
	public static void addKeyType(Dova.JDK.java.lang.String arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "static")]
	public static long getPKCS11KeyType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", "protected")]
	public Dova.JDK.java.security.spec.KeySpec engineGetKeySpec(Dova.JDK.javax.crypto.SecretKey arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.KeySpec>(ret);
	}

	[JniSignatureAttribute("([BI)V", "static")]
	public static void fixDESParity(JavaArray<byte> arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", "protected")]
	public Dova.JDK.javax.crypto.SecretKey engineGenerateSecret(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}
}
