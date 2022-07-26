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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "final")]
public partial class SSLCipher
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLCipher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_NULL", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_RC4_40", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_RC2_40", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_DES_40", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_RC4_128", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_DES", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_3DES", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_IDEA", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_AES_128", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_AES_256", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_AES_128_GCM", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_AES_256_GCM", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_AES_128_GCM_IV", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_AES_256_GCM_IV", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B_CC20_P1305", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformation", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keySize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expandedKeySize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ivSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fixedIvSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exportable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipherType", "Lsun/security/ssl/CipherType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isAvailable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readCipherGenerators", "[Ljava/util/Map$Entry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeCipherGenerators", "[Ljava/util/Map$Entry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cipherLimits", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tag", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/SSLCipher;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Lsun/security/ssl/CipherType;IIIIZZ[Ljava/util/Map$Entry;[Ljava/util/Map$Entry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/SSLCipher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/SSLCipher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/SSLCipher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUnlimited", "(ILjava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isTransformationAvailable", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMacTags", "(BLjava/nio/ByteBuffer;Lsun/security/ssl/Authenticator$MAC;[BZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "calculateRemainingLen", "(Lsun/security/ssl/Authenticator$MAC;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareMacTags", "(Ljava/nio/ByteBuffer;[B)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkPadding", "(Ljava/nio/ByteBuffer;B)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createReadCipher", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljavax/crypto/SecretKey;Ljavax/crypto/spec/IvParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createWriteCipher", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljavax/crypto/SecretKey;Ljavax/crypto/spec/IvParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addMac", "(Lsun/security/ssl/Authenticator$MAC;Ljava/nio/ByteBuffer;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkStreamMac", "(Lsun/security/ssl/Authenticator$MAC;Ljava/nio/ByteBuffer;B[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkCBCMac", "(Lsun/security/ssl/Authenticator$MAC;Ljava/nio/ByteBuffer;BI[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addPadding", "(Ljava/nio/ByteBuffer;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removePadding", "(Ljava/nio/ByteBuffer;IILsun/security/ssl/ProtocolVersion;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_RC4_40_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_RC2_40_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_DES_40_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_RC4_128_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_DES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_3DES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_IDEA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_AES_128_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_AES_256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_AES_128_GCM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_AES_256_GCM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_AES_128_GCM_IV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_AES_256_GCM_IV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLCipher B_CC20_P1305_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String description_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String transformation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String algorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool allowed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int keySize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int expandedKeySize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int ivSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int fixedIvSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool exportable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherType;", "final")]
	public Dova.JDK.sun.security.ssl.CipherType cipherType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int tagSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool isAvailable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("[Ljava/util/Map$Entry;", "private final")]
	public JavaArray<Dova.JDK.java.util.Map.Entry> readCipherGenerators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/Map$Entry;", "private final")]
	public JavaArray<Dova.JDK.java.util.Map.Entry> writeCipherGenerators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap cipherLimits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "static final")]
	public static JavaArray<Dova.JDK.java.lang.String> tag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/SSLCipher;", "private static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SSLCipher> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLCipher>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLCipher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Lsun/security/ssl/CipherType;IIIIZZ[Ljava/util/Map$Entry;[Ljava/util/Map$Entry;)V", "private")]
	public SSLCipher(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.sun.security.ssl.CipherType arg3, int arg4, int arg5, int arg6, int arg7, bool arg8, bool arg9, JavaArray<Dova.JDK.java.util.Map.Entry> arg10, JavaArray<Dova.JDK.java.util.Map.Entry> arg11) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/SSLCipher;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SSLCipher> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLCipher>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/SSLCipher;", "public static")]
	public static Dova.JDK.sun.security.ssl.SSLCipher valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/SSLCipher;", "private static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SSLCipher> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLCipher>>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Z", "private static")]
	public static bool isUnlimited(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
	public static bool isTransformationAvailable(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(BLjava/nio/ByteBuffer;Lsun/security/ssl/Authenticator$MAC;[BZ)Z", "private static")]
	public static bool checkMacTags(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.sun.security.ssl.Authenticator.MAC arg2, JavaArray<byte> arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Authenticator$MAC;II)I", "private static")]
	public static int calculateRemainingLen(Dova.JDK.sun.security.ssl.Authenticator.MAC arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;[B)[I", "private static")]
	public static JavaArray<int> compareMacTags(Dova.JDK.java.nio.ByteBuffer arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;B)[I", "private static")]
	public static JavaArray<int> checkPadding(Dova.JDK.java.nio.ByteBuffer arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljavax/crypto/SecretKey;Ljavax/crypto/spec/IvParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "")]
	public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.javax.crypto.SecretKey arg2, Dova.JDK.javax.crypto.spec.IvParameterSpec arg3, Dova.JDK.java.security.SecureRandom arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljavax/crypto/SecretKey;Ljavax/crypto/spec/IvParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "")]
	public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createWriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.javax.crypto.SecretKey arg2, Dova.JDK.javax.crypto.spec.IvParameterSpec arg3, Dova.JDK.java.security.SecureRandom arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Authenticator$MAC;Ljava/nio/ByteBuffer;B)V", "private static")]
	public static void addMac(Dova.JDK.sun.security.ssl.Authenticator.MAC arg0, Dova.JDK.java.nio.ByteBuffer arg1, byte arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Authenticator$MAC;Ljava/nio/ByteBuffer;B[B)V", "private static")]
	public static void checkStreamMac(Dova.JDK.sun.security.ssl.Authenticator.MAC arg0, Dova.JDK.java.nio.ByteBuffer arg1, byte arg2, JavaArray<byte> arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Authenticator$MAC;Ljava/nio/ByteBuffer;BI[B)V", "private static")]
	public static void checkCBCMac(Dova.JDK.sun.security.ssl.Authenticator.MAC arg0, Dova.JDK.java.nio.ByteBuffer arg1, byte arg2, int arg3, JavaArray<byte> arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;I)I", "private static")]
	public static int addPadding(Dova.JDK.java.nio.ByteBuffer arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IILsun/security/ssl/ProtocolVersion;)I", "private static")]
	public static int removePadding(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, int arg2, Dova.JDK.sun.security.ssl.ProtocolVersion arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isAvailable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$ReadCipherGenerator;", "abstract static interface")]
	public partial interface ReadCipherGenerator
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$ReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public abstract")]
		Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$SSLReadCipher;", "abstract static")]
	public partial class SSLReadCipher
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLReadCipher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$SSLReadCipher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authenticator", "Lsun/security/ssl/Authenticator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protocolVersion", "Lsun/security/ssl/ProtocolVersion;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyLimitEnabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyLimitCountdown", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseSecret", "Ljavax/crypto/SecretKey;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nullDTlsReadCipher", "()Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nullTlsReadCipher", "()Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullCipher", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atKeyLimit", "()Z"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/Authenticator;", "final")]
		public Dova.JDK.sun.security.ssl.Authenticator authenticator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "final")]
		public Dova.JDK.sun.security.ssl.ProtocolVersion protocolVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool keyLimitEnabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("J", "")]
		public long keyLimitCountdown_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "")]
		public Dova.JDK.javax.crypto.SecretKey baseSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;)V", "")]
		public SSLReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$SSLReadCipher;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "abstract")]
		public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/SSLCipher$SSLReadCipher;", "static final")]
		public static Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher nullDTlsReadCipher()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("(II)I", "abstract")]
		public int estimateFragmentSize(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/security/ssl/SSLCipher$SSLReadCipher;", "static final")]
		public static Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher nullTlsReadCipher()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isNullCipher()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool atKeyLimit()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$WriteCipherGenerator;", "abstract static interface")]
	public partial interface WriteCipherGenerator
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$WriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public abstract")]
		Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "abstract static")]
	public partial class SSLWriteCipher
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLWriteCipher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$SSLWriteCipher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authenticator", "Lsun/security/ssl/Authenticator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protocolVersion", "Lsun/security/ssl/ProtocolVersion;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyLimitEnabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyLimitCountdown", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseSecret", "Ljavax/crypto/SecretKey;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nullTlsWriteCipher", "()Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCBCMode", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullCipher", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atKeyLimit", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nullDTlsWriteCipher", "()Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/Authenticator;", "final")]
		public Dova.JDK.sun.security.ssl.Authenticator authenticator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "final")]
		public Dova.JDK.sun.security.ssl.ProtocolVersion protocolVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool keyLimitEnabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("J", "")]
		public long keyLimitCountdown_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "")]
		public Dova.JDK.javax.crypto.SecretKey baseSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLWriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;)V", "")]
		public SSLWriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$SSLWriteCipher;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(II)I", "abstract")]
		public int calculatePacketSize(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "static final")]
		public static Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher nullTlsWriteCipher()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isCBCMode()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isNullCipher()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool atKeyLimit()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "static final")]
		public static Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher nullDTlsWriteCipher()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("(II)I", "abstract")]
		public int calculateFragmentSize(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()I", "abstract")]
		public int getExplicitNonceSize()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "abstract")]
		public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$NullReadCipherGenerator;", "private static final")]
	public partial class NullReadCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.ReadCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NullReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$NullReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NullReadCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public NullReadCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$NullReadCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$NullReadCipherGenerator$NullReadCipher;", "static final")]
		public partial class NullReadCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NullReadCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$NullReadCipherGenerator$NullReadCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullCipher", "()Z"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NullReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;)V", "")]
			public NullReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$NullReadCipherGenerator$NullReadCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "public")]
			public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int estimateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isNullCipher()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$NullWriteCipherGenerator;", "private static final")]
	public partial class NullWriteCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.WriteCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NullWriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$NullWriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NullWriteCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public NullWriteCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$NullWriteCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$NullWriteCipherGenerator$NullWriteCipher;", "static final")]
		public partial class NullWriteCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NullWriteCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$NullWriteCipherGenerator$NullWriteCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullCipher", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NullWriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;)V", "")]
			public NullWriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$NullWriteCipherGenerator$NullWriteCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(II)I", "")]
			public int calculatePacketSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isNullCipher()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getExplicitNonceSize()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "public")]
			public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$StreamReadCipherGenerator;", "private static final")]
	public partial class StreamReadCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.ReadCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StreamReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$StreamReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StreamReadCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public StreamReadCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$StreamReadCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$StreamReadCipherGenerator$StreamReadCipher;", "static final")]
		public partial class StreamReadCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static StreamReadCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$StreamReadCipherGenerator$StreamReadCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public StreamReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public StreamReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.security.Key arg3, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg4, Dova.JDK.java.security.SecureRandom arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$StreamReadCipherGenerator$StreamReadCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "public")]
			public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int estimateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$StreamWriteCipherGenerator;", "private static final")]
	public partial class StreamWriteCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.WriteCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StreamWriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$StreamWriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StreamWriteCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public StreamWriteCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$StreamWriteCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$StreamWriteCipherGenerator$StreamWriteCipher;", "static final")]
		public partial class StreamWriteCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static StreamWriteCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$StreamWriteCipherGenerator$StreamWriteCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public StreamWriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public StreamWriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.security.Key arg3, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg4, Dova.JDK.java.security.SecureRandom arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$StreamWriteCipherGenerator$StreamWriteCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculatePacketSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getExplicitNonceSize()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "public")]
			public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T10BlockReadCipherGenerator;", "private static final")]
	public partial class T10BlockReadCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.ReadCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T10BlockReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T10BlockReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T10BlockReadCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T10BlockReadCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T10BlockReadCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T10BlockReadCipherGenerator$BlockReadCipher;", "static final")]
		public partial class BlockReadCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BlockReadCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T10BlockReadCipherGenerator$BlockReadCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sanityCheck", "(II)Z"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BlockReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public BlockReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.security.Key arg3, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg4, Dova.JDK.java.security.SecureRandom arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T10BlockReadCipherGenerator$BlockReadCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "public")]
			public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int estimateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)Z", "private")]
			public bool sanityCheck(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T10BlockWriteCipherGenerator;", "private static final")]
	public partial class T10BlockWriteCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.WriteCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T10BlockWriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T10BlockWriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T10BlockWriteCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T10BlockWriteCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T10BlockWriteCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T10BlockWriteCipherGenerator$BlockWriteCipher;", "static final")]
		public partial class BlockWriteCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BlockWriteCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T10BlockWriteCipherGenerator$BlockWriteCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCBCMode", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BlockWriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public BlockWriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.security.Key arg3, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg4, Dova.JDK.java.security.SecureRandom arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T10BlockWriteCipherGenerator$BlockWriteCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculatePacketSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isCBCMode()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getExplicitNonceSize()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "public")]
			public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T11BlockReadCipherGenerator;", "private static final")]
	public partial class T11BlockReadCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.ReadCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T11BlockReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T11BlockReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T11BlockReadCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T11BlockReadCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T11BlockReadCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T11BlockReadCipherGenerator$BlockReadCipher;", "static final")]
		public partial class BlockReadCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BlockReadCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T11BlockReadCipherGenerator$BlockReadCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sanityCheck", "(II)Z"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BlockReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public BlockReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T11BlockReadCipherGenerator$BlockReadCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "public")]
			public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int estimateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)Z", "private")]
			public bool sanityCheck(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T11BlockWriteCipherGenerator;", "private static final")]
	public partial class T11BlockWriteCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.WriteCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T11BlockWriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T11BlockWriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T11BlockWriteCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T11BlockWriteCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T11BlockWriteCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T11BlockWriteCipherGenerator$BlockWriteCipher;", "static final")]
		public partial class BlockWriteCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BlockWriteCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T11BlockWriteCipherGenerator$BlockWriteCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCBCMode", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BlockWriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public BlockWriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T11BlockWriteCipherGenerator$BlockWriteCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculatePacketSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isCBCMode()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getExplicitNonceSize()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "public")]
			public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T12GcmReadCipherGenerator;", "private static final")]
	public partial class T12GcmReadCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.ReadCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12GcmReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T12GcmReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12GcmReadCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T12GcmReadCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T12GcmReadCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T12GcmReadCipherGenerator$GcmReadCipher;", "static final")]
		public partial class GcmReadCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GcmReadCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T12GcmReadCipherGenerator$GcmReadCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fixedIv", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordIvSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int tagSize_Property
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

			[JniSignatureAttribute("Ljava/security/Key;", "private final")]
			public Dova.JDK.java.security.Key key_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> fixedIv_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int recordIvSize_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GcmReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public GcmReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T12GcmReadCipherGenerator$GcmReadCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "public")]
			public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int estimateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T12GcmWriteCipherGenerator;", "private static final")]
	public partial class T12GcmWriteCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.WriteCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12GcmWriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T12GcmWriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12GcmWriteCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T12GcmWriteCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T12GcmWriteCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T12GcmWriteCipherGenerator$GcmWriteCipher;", "private static final")]
		public partial class GcmWriteCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GcmWriteCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T12GcmWriteCipherGenerator$GcmWriteCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fixedIv", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordIvSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int tagSize_Property
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

			[JniSignatureAttribute("Ljava/security/Key;", "private final")]
			public Dova.JDK.java.security.Key key_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> fixedIv_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int recordIvSize_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GcmWriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public GcmWriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T12GcmWriteCipherGenerator$GcmWriteCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculatePacketSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getExplicitNonceSize()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "public")]
			public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T13GcmReadCipherGenerator;", "private static final")]
	public partial class T13GcmReadCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.ReadCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13GcmReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T13GcmReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13GcmReadCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13GcmReadCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T13GcmReadCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T13GcmReadCipherGenerator$GcmReadCipher;", "static final")]
		public partial class GcmReadCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GcmReadCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T13GcmReadCipherGenerator$GcmReadCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iv", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int tagSize_Property
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

			[JniSignatureAttribute("Ljava/security/Key;", "private final")]
			public Dova.JDK.java.security.Key key_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> iv_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GcmReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public GcmReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T13GcmReadCipherGenerator$GcmReadCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "public")]
			public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int estimateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T13GcmWriteCipherGenerator;", "private static final")]
	public partial class T13GcmWriteCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.WriteCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13GcmWriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T13GcmWriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13GcmWriteCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13GcmWriteCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T13GcmWriteCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T13GcmWriteCipherGenerator$GcmWriteCipher;", "private static final")]
		public partial class GcmWriteCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GcmWriteCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T13GcmWriteCipherGenerator$GcmWriteCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iv", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int tagSize_Property
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

			[JniSignatureAttribute("Ljava/security/Key;", "private final")]
			public Dova.JDK.java.security.Key key_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> iv_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GcmWriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public GcmWriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T13GcmWriteCipherGenerator$GcmWriteCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculatePacketSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getExplicitNonceSize()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "public")]
			public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T12CC20P1305ReadCipherGenerator;", "private static final")]
	public partial class T12CC20P1305ReadCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.ReadCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12CC20P1305ReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T12CC20P1305ReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12CC20P1305ReadCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T12CC20P1305ReadCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T12CC20P1305ReadCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T12CC20P1305ReadCipherGenerator$CC20P1305ReadCipher;", "static final")]
		public partial class CC20P1305ReadCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CC20P1305ReadCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T12CC20P1305ReadCipherGenerator$CC20P1305ReadCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iv", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int tagSize_Property
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

			[JniSignatureAttribute("Ljava/security/Key;", "private final")]
			public Dova.JDK.java.security.Key key_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> iv_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CC20P1305ReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public CC20P1305ReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T12CC20P1305ReadCipherGenerator$CC20P1305ReadCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "public")]
			public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int estimateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T13CC20P1305ReadCipherGenerator;", "private static final")]
	public partial class T13CC20P1305ReadCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.ReadCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13CC20P1305ReadCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T13CC20P1305ReadCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13CC20P1305ReadCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13CC20P1305ReadCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T13CC20P1305ReadCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLReadCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T13CC20P1305ReadCipherGenerator$CC20P1305ReadCipher;", "static final")]
		public partial class CC20P1305ReadCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CC20P1305ReadCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T13CC20P1305ReadCipherGenerator$CC20P1305ReadCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iv", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(II)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int tagSize_Property
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

			[JniSignatureAttribute("Ljava/security/Key;", "private final")]
			public Dova.JDK.java.security.Key key_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> iv_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CC20P1305ReadCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public CC20P1305ReadCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T13CC20P1305ReadCipherGenerator$CC20P1305ReadCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[B)Lsun/security/ssl/Plaintext;", "public")]
			public Dova.JDK.sun.security.ssl.Plaintext decrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int estimateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T12CC20P1305WriteCipherGenerator;", "private static final")]
	public partial class T12CC20P1305WriteCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.WriteCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12CC20P1305WriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T12CC20P1305WriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12CC20P1305WriteCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T12CC20P1305WriteCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T12CC20P1305WriteCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T12CC20P1305WriteCipherGenerator$CC20P1305WriteCipher;", "private static final")]
		public partial class CC20P1305WriteCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CC20P1305WriteCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T12CC20P1305WriteCipherGenerator$CC20P1305WriteCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iv", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int tagSize_Property
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

			[JniSignatureAttribute("Ljava/security/Key;", "private final")]
			public Dova.JDK.java.security.Key key_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> iv_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CC20P1305WriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public CC20P1305WriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T12CC20P1305WriteCipherGenerator$CC20P1305WriteCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculatePacketSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getExplicitNonceSize()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "public")]
			public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T13CC20P1305WriteCipherGenerator;", "private static final")]
	public partial class T13CC20P1305WriteCipherGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCipher.WriteCipherGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13CC20P1305WriteCipherGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T13CC20P1305WriteCipherGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCipher", "(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13CC20P1305WriteCipherGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13CC20P1305WriteCipherGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T13CC20P1305WriteCipherGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher createCipher(Dova.JDK.sun.security.ssl.SSLCipher arg0, Dova.JDK.sun.security.ssl.Authenticator arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$T13CC20P1305WriteCipherGenerator$CC20P1305WriteCipher;", "private static final")]
		public partial class CC20P1305WriteCipher
			: Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CC20P1305WriteCipher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLCipher$T13CC20P1305WriteCipherGenerator$CC20P1305WriteCipher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Ljavax/crypto/Cipher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iv", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragmentSize", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitNonceSize", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encrypt", "(BLjava/nio/ByteBuffer;)I"));
			}

			[JniSignatureAttribute("Ljavax/crypto/Cipher;", "private final")]
			public Dova.JDK.javax.crypto.Cipher cipher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int tagSize_Property
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

			[JniSignatureAttribute("Ljava/security/Key;", "private final")]
			public Dova.JDK.java.security.Key key_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> iv_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/security/SecureRandom;", "private final")]
			public Dova.JDK.java.security.SecureRandom random_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CC20P1305WriteCipher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Ljava/lang/String;Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "")]
			public CC20P1305WriteCipher(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SSLCipher arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Key arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5, Dova.JDK.java.security.SecureRandom arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLCipher$T13CC20P1305WriteCipherGenerator$CC20P1305WriteCipher;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void dispose()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculatePacketSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "")]
			public int calculateFragmentSize(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getExplicitNonceSize()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)I", "public")]
			public int encrypt(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return ret;
			}
		}
	}
}
