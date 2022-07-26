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

namespace Dova.JDK.sun.security.validator;

[JniSignatureAttribute("Lsun/security/validator/SimpleValidator;", "public final")]
public partial class SimpleValidator
	: Dova.JDK.sun.security.validator.Validator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleValidator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/validator/SimpleValidator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OID_BASIC_CONSTRAINTS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OID_NETSCAPE_CERT_TYPE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OID_KEY_USAGE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OID_EXTENDED_KEY_USAGE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OID_EKU_ANY_USAGE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJID_NETSCAPE_CERT_TYPE", "Lsun/security/util/ObjectIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NSCT_SSL_CA", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NSCT_CODE_SIGNING_CA", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trustedX500Principals", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trustedCerts", "Ljava/util/Collection;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkKeyUsage", "(Ljava/security/cert/X509Certificate;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNetscapeCertTypeBit", "(Ljava/security/cert/X509Certificate;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildTrustedChain", "([Ljava/security/cert/X509Certificate;)[Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkExtensions", "(Ljava/security/cert/X509Certificate;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkBasicConstraints", "(Ljava/security/cert/X509Certificate;Ljava/util/Set;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkNetscapeCertType", "(Ljava/security/cert/X509Certificate;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrustedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrustedCertificates", "()Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineValidate", "([Ljava/security/cert/X509Certificate;Ljava/util/Collection;Ljava/util/List;Ljava/security/AlgorithmConstraints;Ljava/lang/Object;)[Ljava/security/cert/X509Certificate;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String OID_BASIC_CONSTRAINTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String OID_NETSCAPE_CERT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String OID_KEY_USAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String OID_EXTENDED_KEY_USAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String OID_EKU_ANY_USAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/ObjectIdentifier;", "static final")]
	public static Dova.JDK.sun.security.util.ObjectIdentifier OBJID_NETSCAPE_CERT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ObjectIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String NSCT_SSL_CA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String NSCT_CODE_SIGNING_CA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map trustedX500Principals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Collection;", "private final")]
	public Dova.JDK.java.util.Collection trustedCerts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleValidator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)V", "")]
	public SimpleValidator(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/validator/SimpleValidator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;Ljava/util/Set;)V", "private")]
	public void checkKeyUsage(Dova.JDK.java.security.cert.X509Certificate arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;Ljava/lang/String;)Z", "static")]
	public static bool getNetscapeCertTypeBit(Dova.JDK.java.security.cert.X509Certificate arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;)[Ljava/security/cert/X509Certificate;", "private")]
	public JavaArray<Dova.JDK.java.security.cert.X509Certificate> buildTrustedChain(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;I)I", "private")]
	public int checkExtensions(Dova.JDK.java.security.cert.X509Certificate arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;Ljava/util/Set;I)I", "private")]
	public int checkBasicConstraints(Dova.JDK.java.security.cert.X509Certificate arg0, Dova.JDK.java.util.Set arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;Ljava/util/Set;)V", "private")]
	public void checkNetscapeCertType(Dova.JDK.java.security.cert.X509Certificate arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;", "private")]
	public Dova.JDK.java.security.cert.X509Certificate getTrustedCertificate(Dova.JDK.java.security.cert.X509Certificate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection getTrustedCertificates()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/util/Collection;Ljava/util/List;Ljava/security/AlgorithmConstraints;Ljava/lang/Object;)[Ljava/security/cert/X509Certificate;", "")]
	public JavaArray<Dova.JDK.java.security.cert.X509Certificate> engineValidate(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.util.Collection arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.security.AlgorithmConstraints arg3, Dova.JDK.java.lang.Object arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
	}
}
