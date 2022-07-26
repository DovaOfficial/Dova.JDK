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

[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "final")]
public partial class NamedGroup
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NamedGroup()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/NamedGroup;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT163_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT163_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT163_R2", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT193_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT193_R2", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT233_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT233_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT239_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT283_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT283_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT409_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT409_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT571_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECT571_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP160_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP160_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP160_R2", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP192_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP192_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP224_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP224_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP256_K1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP256_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP384_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP521_R1", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "X25519", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "X448", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FFDHE_2048", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FFDHE_3072", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FFDHE_4096", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FFDHE_6144", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FFDHE_8192", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARBITRARY_PRIME", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARBITRARY_CHAR2", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "id", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spec", "Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportedProtocols", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keAlgParamSpec", "Ljava/security/spec/AlgorithmParameterSpec;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keAlgParams", "Ljava/security/AlgorithmParameters;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isAvailable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KEY_AGREEMENT_PRIMITIVE_SET", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/NamedGroup;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IILjava/lang/String;Lsun/security/ssl/NamedGroup$NamedGroupSpec;[Lsun/security/ssl/ProtocolVersion;Ljava/security/spec/AlgorithmParameterSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/NamedGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/NamedGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljavax/crypto/spec/DHParameterSpec;)Lsun/security/ssl/NamedGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/security/spec/ECParameterSpec;)Lsun/security/ssl/NamedGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(I)Lsun/security/ssl/NamedGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/NamedGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodePossessionPublicKey", "(Lsun/security/ssl/NamedGroupPossession;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeCredentials", "([B)Lsun/security/ssl/SSLCredentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPermitted", "(Ljava/security/AlgorithmConstraints;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameOf", "(Ljava/lang/String;)Lsun/security/ssl/NamedGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameOf", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "(Lsun/security/ssl/ProtocolVersion;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "(Ljava/util/List;)Z"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT163_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT163_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT163_R2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT193_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT193_R2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT233_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT233_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT239_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT283_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT283_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT409_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT409_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT571_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECT571_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP160_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP160_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP160_R2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP192_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP192_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP224_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP224_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP256_K1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP256_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP384_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup SECP521_R1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup X25519_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup X448_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup FFDHE_2048_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup FFDHE_3072_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup FFDHE_4096_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup FFDHE_6144_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup FFDHE_8192_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup ARBITRARY_PRIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "public static final")]
	public static Dova.JDK.sun.security.ssl.NamedGroup ARBITRARY_CHAR2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "final")]
	public Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec spec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "final")]
	public JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> supportedProtocols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String algorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/spec/AlgorithmParameterSpec;", "final")]
	public Dova.JDK.java.security.spec.AlgorithmParameterSpec keAlgParamSpec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.AlgorithmParameterSpec>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmParameters;", "final")]
	public Dova.JDK.java.security.AlgorithmParameters keAlgParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmParameters>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool isAvailable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
	public static Dova.JDK.java.util.Set KEY_AGREEMENT_PRIMITIVE_SET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/NamedGroup;", "private static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.NamedGroup> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.NamedGroup>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NamedGroup(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;Lsun/security/ssl/NamedGroup$NamedGroupSpec;[Lsun/security/ssl/ProtocolVersion;Ljava/security/spec/AlgorithmParameterSpec;)V", "private")]
	public NamedGroup(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec arg4, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg5, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/NamedGroup;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lsun/security/ssl/NamedGroup;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.NamedGroup> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.NamedGroup>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/NamedGroup;", "public static")]
	public static Dova.JDK.sun.security.ssl.NamedGroup valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
	}

	[JniSignatureAttribute("(Ljavax/crypto/spec/DHParameterSpec;)Lsun/security/ssl/NamedGroup;", "static")]
	public static Dova.JDK.sun.security.ssl.NamedGroup valueOf(Dova.JDK.javax.crypto.spec.DHParameterSpec arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/ECParameterSpec;)Lsun/security/ssl/NamedGroup;", "static")]
	public static Dova.JDK.sun.security.ssl.NamedGroup valueOf(Dova.JDK.java.security.spec.ECParameterSpec arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/security/ssl/NamedGroup;", "static")]
	public static Dova.JDK.sun.security.ssl.NamedGroup valueOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Z", "")]
	public bool isSupported(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/NamedGroup;", "private static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.NamedGroup> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.NamedGroup>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/NamedGroupPossession;)[B", "")]
	public JavaArray<byte> encodePossessionPublicKey(Dova.JDK.sun.security.ssl.NamedGroupPossession arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/security/ssl/SSLCredentials;", "")]
	public Dova.JDK.sun.security.ssl.SSLCredentials decodeCredentials(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCredentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "")]
	public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/AlgorithmConstraints;)Z", "")]
	public bool isPermitted(Dova.JDK.java.security.AlgorithmConstraints arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/NamedGroup;", "static")]
	public static Dova.JDK.sun.security.ssl.NamedGroup nameOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String nameOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;", "")]
	public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.java.security.SecureRandom arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)Z", "")]
	public bool isAvailable(Dova.JDK.sun.security.ssl.ProtocolVersion arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)Z", "")]
	public bool isAvailable(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "static final")]
	public partial class NamedGroupSpec
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupScheme
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NamedGroupSpec()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/NamedGroup$NamedGroupSpec;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMED_GROUP_ECDHE", "Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMED_GROUP_FFDHE", "Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMED_GROUP_XDH", "Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMED_GROUP_ARBITRARY", "Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMED_GROUP_NONE", "Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithm", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scheme", "Lsun/security/ssl/NamedGroup$NamedGroupScheme;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Lsun/security/ssl/NamedGroup$NamedGroupScheme;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/util/List;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodePossessionPublicKey", "(Lsun/security/ssl/NamedGroupPossession;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeCredentials", "(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arrayContains", "([Lsun/security/ssl/NamedGroup$NamedGroupSpec;Lsun/security/ssl/NamedGroup$NamedGroupSpec;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "public static final")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec NAMED_GROUP_ECDHE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "public static final")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec NAMED_GROUP_FFDHE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "public static final")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec NAMED_GROUP_XDH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "public static final")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec NAMED_GROUP_ARBITRARY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "public static final")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec NAMED_GROUP_NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String algorithm_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupScheme;", "private final")]
		public Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupScheme scheme_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupScheme>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NamedGroupSpec(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Lsun/security/ssl/NamedGroup$NamedGroupScheme;)V", "private")]
		public NamedGroupSpec(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupScheme arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/NamedGroup$NamedGroupSpec;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "public static")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Z", "")]
		public bool isSupported(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroupPossession;)[B", "public")]
		public JavaArray<byte> encodePossessionPublicKey(Dova.JDK.sun.security.ssl.NamedGroupPossession arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCredentials decodeCredentials(Dova.JDK.sun.security.ssl.NamedGroup arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCredentials>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}

		[JniSignatureAttribute("([Lsun/security/ssl/NamedGroup$NamedGroupSpec;Lsun/security/ssl/NamedGroup$NamedGroupSpec;)Z", "static")]
		public static bool arrayContains(JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec> arg0, Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;", "public")]
		public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.NamedGroup arg0, Dova.JDK.java.security.SecureRandom arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$XDHScheme;", "private static")]
	public partial class XDHScheme
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupScheme
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XDHScheme()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/NamedGroup$XDHScheme;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/security/ssl/NamedGroup$XDHScheme;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodePossessionPublicKey", "(Lsun/security/ssl/NamedGroupPossession;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeCredentials", "(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$XDHScheme;", "private static final")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.XDHScheme instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.XDHScheme>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XDHScheme(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public XDHScheme() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/NamedGroup$XDHScheme;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroupPossession;)[B", "public")]
		public JavaArray<byte> encodePossessionPublicKey(Dova.JDK.sun.security.ssl.NamedGroupPossession arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCredentials decodeCredentials(Dova.JDK.sun.security.ssl.NamedGroup arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCredentials>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;", "public")]
		public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.NamedGroup arg0, Dova.JDK.java.security.SecureRandom arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$ECDHEScheme;", "private static")]
	public partial class ECDHEScheme
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupScheme
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ECDHEScheme()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/NamedGroup$ECDHEScheme;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/security/ssl/NamedGroup$ECDHEScheme;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodePossessionPublicKey", "(Lsun/security/ssl/NamedGroupPossession;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeCredentials", "(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$ECDHEScheme;", "private static final")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.ECDHEScheme instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.ECDHEScheme>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ECDHEScheme(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ECDHEScheme() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/NamedGroup$ECDHEScheme;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroupPossession;)[B", "public")]
		public JavaArray<byte> encodePossessionPublicKey(Dova.JDK.sun.security.ssl.NamedGroupPossession arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCredentials decodeCredentials(Dova.JDK.sun.security.ssl.NamedGroup arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCredentials>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;", "public")]
		public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.NamedGroup arg0, Dova.JDK.java.security.SecureRandom arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$FFDHEScheme;", "private static")]
	public partial class FFDHEScheme
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupScheme
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FFDHEScheme()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/NamedGroup$FFDHEScheme;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/security/ssl/NamedGroup$FFDHEScheme;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodePossessionPublicKey", "(Lsun/security/ssl/NamedGroupPossession;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeCredentials", "(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$FFDHEScheme;", "private static final")]
		public static Dova.JDK.sun.security.ssl.NamedGroup.FFDHEScheme instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup.FFDHEScheme>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FFDHEScheme(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public FFDHEScheme() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/NamedGroup$FFDHEScheme;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroupPossession;)[B", "public")]
		public JavaArray<byte> encodePossessionPublicKey(Dova.JDK.sun.security.ssl.NamedGroupPossession arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;", "public")]
		public Dova.JDK.sun.security.ssl.SSLCredentials decodeCredentials(Dova.JDK.sun.security.ssl.NamedGroup arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCredentials>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;", "public")]
		public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.NamedGroup arg0, Dova.JDK.java.security.SecureRandom arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup$NamedGroupScheme;", "private abstract static interface")]
	public partial interface NamedGroupScheme
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NamedGroupScheme()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/NamedGroup$NamedGroupScheme;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodePossessionPublicKey", "(Lsun/security/ssl/NamedGroupPossession;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeCredentials", "(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroupPossession;)[B", "public abstract")]
		JavaArray<byte> encodePossessionPublicKey(Dova.JDK.sun.security.ssl.NamedGroupPossession arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/SSLCredentials;", "public abstract")]
		Dova.JDK.sun.security.ssl.SSLCredentials decodeCredentials(Dova.JDK.sun.security.ssl.NamedGroup arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCredentials>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public abstract")]
		Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)Lsun/security/ssl/SSLPossession;", "public abstract")]
		Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.NamedGroup arg0, Dova.JDK.java.security.SecureRandom arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}
}
