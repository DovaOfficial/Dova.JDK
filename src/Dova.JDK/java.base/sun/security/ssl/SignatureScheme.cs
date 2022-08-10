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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "final")]
public partial class SignatureScheme
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SignatureScheme()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SignatureScheme;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ECDSA_SECP256R1_SHA256", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ECDSA_SECP384R1_SHA384", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ECDSA_SECP521R1_SHA512", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ED25519", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ED448", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_RSAE_SHA256", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_RSAE_SHA384", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_RSAE_SHA512", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_PSS_SHA256", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_PSS_SHA384", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_PSS_SHA512", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PKCS1_SHA256", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PKCS1_SHA384", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PKCS1_SHA512", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DSA_SHA256", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ECDSA_SHA224", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_SHA224", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DSA_SHA224", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ECDSA_SHA1", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PKCS1_SHA1", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DSA_SHA1", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_MD5", "Lsun/security/ssl/SignatureScheme;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "id", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "algorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "keyAlgorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "signAlgParams", "Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "namedGroup", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "minimalKeySize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "supportedProtocols", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "handshakeSupportedProtocols", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isAvailable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "hashAlgorithms", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "signatureAlgorithms", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SIGNATURE_PRIMITIVE_SET", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/security/ssl/SignatureScheme;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SignatureScheme", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lsun/security/ssl/NamedGroup;[Lsun/security/ssl/ProtocolVersion;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SignatureScheme", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;I[Lsun/security/ssl/ProtocolVersion;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SignatureScheme", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;Lsun/security/ssl/NamedGroup;I[Lsun/security/ssl/ProtocolVersion;[Lsun/security/ssl/ProtocolVersion;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SignatureScheme", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I[Lsun/security/ssl/ProtocolVersion;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SignatureScheme", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Lsun/security/ssl/ProtocolVersion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/security/ssl/SignatureScheme;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/SignatureScheme;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(I)Lsun/security/ssl/SignatureScheme;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/security/ssl/SignatureScheme;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSupportedAlgorithms", "(Lsun/security/ssl/SSLConfiguration;Ljava/security/AlgorithmConstraints;Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSupportedAlgorithms", "(Lsun/security/ssl/SSLConfiguration;Ljava/security/AlgorithmConstraints;Lsun/security/ssl/ProtocolVersion;[I)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSignerOfPreferableAlgorithm", "(Ljava/security/AlgorithmConstraints;Ljava/util/List;Lsun/security/ssl/X509Authentication$X509Possession;Lsun/security/ssl/ProtocolVersion;)Ljava/util/Map$Entry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVerifier", "(Ljava/security/PublicKey;)Ljava/security/Signature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPermitted", "(Ljava/security/AlgorithmConstraints;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "sizeInRecord", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAlgorithmNames", "(Ljava/util/Collection;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "nameOf", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "nameOf", "(Ljava/lang/String;)Lsun/security/ssl/SignatureScheme;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSigner", "(Ljava/security/PrivateKey;)Ljava/security/Signature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPreferableAlgorithm", "(Ljava/security/AlgorithmConstraints;Ljava/util/List;Lsun/security/ssl/SignatureScheme;Lsun/security/ssl/ProtocolVersion;)Lsun/security/ssl/SignatureScheme;"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme ECDSA_SECP256R1_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme ECDSA_SECP384R1_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme ECDSA_SECP521R1_SHA512_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme ED25519_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme ED448_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PSS_RSAE_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PSS_RSAE_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PSS_RSAE_SHA512_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PSS_PSS_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PSS_PSS_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PSS_PSS_SHA512_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PKCS1_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PKCS1_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PKCS1_SHA512_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme DSA_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme ECDSA_SHA224_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_SHA224_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme DSA_SHA224_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme ECDSA_SHA1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_PKCS1_SHA1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme DSA_SHA1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme RSA_MD5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "final")]
	public int id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[22], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String algorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String keyAlgorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "private final")]
	public Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec signAlgParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "private final")]
	public Dova.JDK.sun.security.ssl.NamedGroup namedGroup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "final")]
	public int minimalKeySize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[28], value);
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List supportedProtocols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List handshakeSupportedProtocols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "final")]
	public bool isAvailable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[31]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[31], value);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> hashAlgorithms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> signatureAlgorithms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
	public static Dova.JDK.java.util.Set SIGNATURE_PRIMITIVE_SET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lsun/security/ssl/SignatureScheme;", "private static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignatureScheme(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lsun/security/ssl/NamedGroup;[Lsun/security/ssl/ProtocolVersion;)V", "private")]
	public SignatureScheme(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.sun.security.ssl.NamedGroup arg6, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg7) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;I[Lsun/security/ssl/ProtocolVersion;)V", "private")]
	public SignatureScheme(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec arg6, int arg7, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg8) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;Lsun/security/ssl/NamedGroup;I[Lsun/security/ssl/ProtocolVersion;[Lsun/security/ssl/ProtocolVersion;)V", "private")]
	public SignatureScheme(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec arg6, Dova.JDK.sun.security.ssl.NamedGroup arg7, int arg8, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg9, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg10) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I[Lsun/security/ssl/ProtocolVersion;)V", "private")]
	public SignatureScheme(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, int arg6, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg7) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Lsun/security/ssl/ProtocolVersion;)V", "private")]
	public SignatureScheme(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SignatureScheme;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lsun/security/ssl/SignatureScheme;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/SignatureScheme;", "public static")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/security/ssl/SignatureScheme;", "static")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme valueOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/SignatureScheme;", "private static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLConfiguration;Ljava/security/AlgorithmConstraints;Ljava/util/List;)Ljava/util/List;", "static")]
	public static Dova.JDK.java.util.List getSupportedAlgorithms(Dova.JDK.sun.security.ssl.SSLConfiguration arg0, Dova.JDK.java.security.AlgorithmConstraints arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLConfiguration;Ljava/security/AlgorithmConstraints;Lsun/security/ssl/ProtocolVersion;[I)Ljava/util/List;", "static")]
	public static Dova.JDK.java.util.List getSupportedAlgorithms(Dova.JDK.sun.security.ssl.SSLConfiguration arg0, Dova.JDK.java.security.AlgorithmConstraints arg1, Dova.JDK.sun.security.ssl.ProtocolVersion arg2, JavaArray<int> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/AlgorithmConstraints;Ljava/util/List;Lsun/security/ssl/X509Authentication$X509Possession;Lsun/security/ssl/ProtocolVersion;)Ljava/util/Map$Entry;", "static")]
	public static Dova.JDK.java.util.Map.Entry getSignerOfPreferableAlgorithm(Dova.JDK.java.security.AlgorithmConstraints arg0, Dova.JDK.java.util.List arg1, Dova.JDK.sun.security.ssl.X509Authentication.X509Possession arg2, Dova.JDK.sun.security.ssl.ProtocolVersion arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map.Entry>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)Ljava/security/Signature;", "")]
	public Dova.JDK.java.security.Signature getVerifier(Dova.JDK.java.security.PublicKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Signature>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/AlgorithmConstraints;)Z", "private")]
	public bool isPermitted(Dova.JDK.java.security.AlgorithmConstraints arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "static")]
	public static int sizeInRecord()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)[Ljava/lang/String;", "static")]
	public static JavaArray<Dova.JDK.java.lang.String> getAlgorithmNames(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String nameOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/SignatureScheme;", "static")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme nameOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivateKey;)Ljava/security/Signature;", "private")]
	public Dova.JDK.java.security.Signature getSigner(Dova.JDK.java.security.PrivateKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Signature>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/AlgorithmConstraints;Ljava/util/List;Lsun/security/ssl/SignatureScheme;Lsun/security/ssl/ProtocolVersion;)Lsun/security/ssl/SignatureScheme;", "static")]
	public static Dova.JDK.sun.security.ssl.SignatureScheme getPreferableAlgorithm(Dova.JDK.java.security.AlgorithmConstraints arg0, Dova.JDK.java.util.List arg1, Dova.JDK.sun.security.ssl.SignatureScheme arg2, Dova.JDK.sun.security.ssl.ProtocolVersion arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "static final")]
	public partial class SigAlgParamSpec
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SigAlgParamSpec()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_SHA256", "Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_SHA384", "Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA_PSS_SHA512", "Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parameterSpec", "Ljava/security/spec/AlgorithmParameterSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parameters", "Ljava/security/AlgorithmParameters;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isAvailable", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SigAlgParamSpec", "(Ljava/lang/String;ILjava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec RSA_PSS_SHA256_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec RSA_PSS_SHA384_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec RSA_PSS_SHA512_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/security/spec/AlgorithmParameterSpec;", "private final")]
		public Dova.JDK.java.security.spec.AlgorithmParameterSpec parameterSpec_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.AlgorithmParameterSpec>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/security/AlgorithmParameters;", "private final")]
		public Dova.JDK.java.security.AlgorithmParameters parameters_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmParameters>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isAvailable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("[Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SigAlgParamSpec(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;I)V", "private")]
		public SigAlgParamSpec(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "public static")]
		public static Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/SignatureScheme$SigAlgParamSpec;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SignatureScheme.SigAlgParamSpec>>(ret);
		}
	}
}
