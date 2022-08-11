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

[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "final")]
public partial class ProtocolVersion
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProtocolVersion()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ProtocolVersion;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS13", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS12", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS11", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS10", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL30", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL20Hello", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DTLS12", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DTLS10", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "id", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isDTLS", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "major", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minor", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isAvailable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LIMIT_MAX_VALUE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LIMIT_MIN_VALUE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_TO_10", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_TO_11", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_TO_12", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_TO_13", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_OF_NONE", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_OF_30", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_OF_11", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_OF_12", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_OF_13", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_10_11", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_11_12", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_12_13", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_10_12", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_TO_TLS12", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_TO_TLS11", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_TO_TLS10", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTOCOLS_EMPTY", "[Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/ProtocolVersion;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IILjava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/ProtocolVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Lsun/security/ssl/ProtocolVersion;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(BB)Lsun/security/ssl/ProtocolVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/ProtocolVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(I)Lsun/security/ssl/ProtocolVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/ProtocolVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameOf", "(BB)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameOf", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameOf", "(Ljava/lang/String;)Lsun/security/ssl/ProtocolVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useTLS13PlusSpec", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "useTLS13PlusSpec", "(IZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "useTLS10PlusSpec", "(IZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useTLS10PlusSpec", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isNegotiable", "(BBZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toStringArray", "(Ljava/util/List;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toStringArray", "([I)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "namesOf", "([Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "useTLS12PlusSpec", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useTLS12PlusSpec", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useTLS11PlusSpec", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "selectedFrom", "(Ljava/util/List;I)Lsun/security/ssl/ProtocolVersion;"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion TLS13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion TLS12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion TLS11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion TLS10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion SSL30_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion SSL20Hello_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion DTLS12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion DTLS10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "public static final")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion NONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int id_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool isDTLS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("B", "final")]
	public byte major_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("B", "final")]
	public byte minor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool isAvailable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int LIMIT_MAX_VALUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int LIMIT_MIN_VALUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_TO_10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_TO_11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_TO_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_TO_13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_OF_NONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_OF_30_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_OF_11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_OF_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_OF_13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_10_11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_11_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_12_13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_10_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_TO_TLS12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_TO_TLS11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_TO_TLS10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> PROTOCOLS_EMPTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/ProtocolVersion;", "private static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ProtocolVersion(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;Z)V", "private")]
	public ProtocolVersion(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/ProtocolVersion;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lsun/security/ssl/ProtocolVersion;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)I", "")]
	public int compare(Dova.JDK.sun.security.ssl.ProtocolVersion arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(BB)Lsun/security/ssl/ProtocolVersion;", "static")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion valueOf(byte arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/ProtocolVersion;", "public static")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/security/ssl/ProtocolVersion;", "static")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion valueOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/ProtocolVersion;", "private static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion>>(ret);
	}

	[JniSignatureAttribute("(BB)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String nameOf(byte arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String nameOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/ProtocolVersion;", "static")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion nameOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool useTLS13PlusSpec()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(IZ)Z", "static")]
	public static bool useTLS13PlusSpec(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IZ)Z", "static")]
	public static bool useTLS10PlusSpec(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool useTLS10PlusSpec()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(BBZZ)Z", "static")]
	public static bool isNegotiable(byte arg0, byte arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)[Ljava/lang/String;", "static")]
	public static JavaArray<Dova.JDK.java.lang.String> toStringArray(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("([I)[Ljava/lang/String;", "static")]
	public static JavaArray<Dova.JDK.java.lang.String> toStringArray(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/util/List;", "static")]
	public static Dova.JDK.java.util.List namesOf(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
	public static bool useTLS12PlusSpec(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool useTLS12PlusSpec()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool useTLS11PlusSpec()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;I)Lsun/security/ssl/ProtocolVersion;", "static")]
	public static Dova.JDK.sun.security.ssl.ProtocolVersion selectedFrom(Dova.JDK.java.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
	}
}
