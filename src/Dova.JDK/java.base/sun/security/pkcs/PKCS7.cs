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

namespace Dova.JDK.sun.security.pkcs;

[JniSignatureAttribute("Lsun/security/pkcs/PKCS7;", "public")]
public partial class PKCS7
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PKCS7()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs/PKCS7;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentType", "Lsun/security/util/ObjectIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "digestAlgorithmIds", "[Lsun/security/x509/AlgorithmId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentInfo", "Lsun/security/pkcs/ContentInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "certificates", "[Ljava/security/cert/X509Certificate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "crls", "[Ljava/security/cert/X509CRL;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signerInfos", "[Lsun/security/pkcs/SignerInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "oldStyle", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "certIssuerNames", "[Ljava/security/Principal;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lsun/security/x509/AlgorithmId;Lsun/security/pkcs/ContentInfo;[Ljava/security/cert/X509Certificate;[Lsun/security/pkcs/SignerInfo;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lsun/security/x509/AlgorithmId;Lsun/security/pkcs/ContentInfo;[Ljava/security/cert/X509Certificate;[Ljava/security/cert/X509CRL;[Lsun/security/pkcs/SignerInfo;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/util/DerInputStream;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCertificates", "()[Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Lsun/security/util/DerInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Lsun/security/util/DerInputStream;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "(Lsun/security/pkcs/SignerInfo;[B)Lsun/security/pkcs/SignerInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "([B)[Lsun/security/pkcs/SignerInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "()[Lsun/security/pkcs/SignerInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVersion", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCRLs", "()[Ljava/security/cert/X509CRL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignerInfos", "()[Lsun/security/pkcs/SignerInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCertificate", "(Ljava/math/BigInteger;Lsun/security/x509/X500Name;)Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentInfo", "()Lsun/security/pkcs/ContentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTimestampingURI", "(Ljava/security/cert/X509Certificate;)Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generateSignedData", "([B[Ljava/security/cert/X509Certificate;[BLjava/lang/String;Ljava/net/URI;Ljava/lang/String;Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generateNewSignedData", "(Ljava/lang/String;Ljava/security/Provider;Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;[BZZLjava/util/function/Function;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generateTimestampToken", "(Lsun/security/timestamp/Timestamper;Ljava/lang/String;Ljava/lang/String;[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOldStyle", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseSignedData", "(Lsun/security/util/DerValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseOldSignedData", "(Lsun/security/util/DerValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseNetscapeCertChain", "(Lsun/security/util/DerValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeSignedData", "(Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeSignedData", "(Lsun/security/util/DerOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "populateCertIssuerNames", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "constructToken", "([B[Ljava/security/cert/X509Certificate;[BLsun/security/pkcs/PKCS9Attributes;Lsun/security/pkcs/PKCS9Attributes;Lsun/security/x509/AlgorithmId;Lsun/security/x509/AlgorithmId;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDigestAlgorithmIds", "()[Lsun/security/x509/AlgorithmId;"));
	}

	[JniSignatureAttribute("Lsun/security/util/ObjectIdentifier;", "private")]
	public Dova.JDK.sun.security.util.ObjectIdentifier contentType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ObjectIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private")]
	public Dova.JDK.java.math.BigInteger version_Property
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

	[JniSignatureAttribute("[Lsun/security/x509/AlgorithmId;", "private")]
	public JavaArray<Dova.JDK.sun.security.x509.AlgorithmId> digestAlgorithmIds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.x509.AlgorithmId>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs/ContentInfo;", "private")]
	public Dova.JDK.sun.security.pkcs.ContentInfo contentInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs.ContentInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/security/cert/X509Certificate;", "private")]
	public JavaArray<Dova.JDK.java.security.cert.X509Certificate> certificates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/security/cert/X509CRL;", "private")]
	public JavaArray<Dova.JDK.java.security.cert.X509CRL> crls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509CRL>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/pkcs/SignerInfo;", "private")]
	public JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo> signerInfos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool oldStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("[Ljava/security/Principal;", "private")]
	public JavaArray<Dova.JDK.java.security.Principal> certIssuerNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.Principal>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PKCS7(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Lsun/security/x509/AlgorithmId;Lsun/security/pkcs/ContentInfo;[Ljava/security/cert/X509Certificate;[Lsun/security/pkcs/SignerInfo;)V", "public")]
	public PKCS7(JavaArray<Dova.JDK.sun.security.x509.AlgorithmId> arg0, Dova.JDK.sun.security.pkcs.ContentInfo arg1, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg2, JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("([Lsun/security/x509/AlgorithmId;Lsun/security/pkcs/ContentInfo;[Ljava/security/cert/X509Certificate;[Ljava/security/cert/X509CRL;[Lsun/security/pkcs/SignerInfo;)V", "public")]
	public PKCS7(JavaArray<Dova.JDK.sun.security.x509.AlgorithmId> arg0, Dova.JDK.sun.security.pkcs.ContentInfo arg1, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg2, JavaArray<Dova.JDK.java.security.cert.X509CRL> arg3, JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo> arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public PKCS7(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/security/util/DerInputStream;)V", "public")]
	public PKCS7(Dova.JDK.sun.security.util.DerInputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)V", "public")]
	public PKCS7(Dova.JDK.java.io.InputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs/PKCS7;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Ljava/security/cert/X509Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.X509Certificate> getCertificates()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/DerInputStream;)V", "private")]
	public void parse(Dova.JDK.sun.security.util.DerInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/util/DerInputStream;Z)V", "private")]
	public void parse(Dova.JDK.sun.security.util.DerInputStream arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs/SignerInfo;[B)Lsun/security/pkcs/SignerInfo;", "public")]
	public Dova.JDK.sun.security.pkcs.SignerInfo verify(Dova.JDK.sun.security.pkcs.SignerInfo arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs.SignerInfo>(ret);
	}

	[JniSignatureAttribute("([B)[Lsun/security/pkcs/SignerInfo;", "public")]
	public JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo> verify(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/pkcs/SignerInfo;", "public")]
	public JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo> verify()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo>>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()[Ljava/security/cert/X509CRL;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.X509CRL> getCRLs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509CRL>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/pkcs/SignerInfo;", "public")]
	public JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo> getSignerInfos()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs.SignerInfo>>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;Lsun/security/x509/X500Name;)Ljava/security/cert/X509Certificate;", "public")]
	public Dova.JDK.java.security.cert.X509Certificate getCertificate(Dova.JDK.java.math.BigInteger arg0, Dova.JDK.sun.security.x509.X500Name arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/pkcs/ContentInfo;", "public")]
	public Dova.JDK.sun.security.pkcs.ContentInfo getContentInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs.ContentInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;)Ljava/net/URI;", "public static")]
	public static Dova.JDK.java.net.URI getTimestampingURI(Dova.JDK.java.security.cert.X509Certificate arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("([B[Ljava/security/cert/X509Certificate;[BLjava/lang/String;Ljava/net/URI;Ljava/lang/String;Ljava/lang/String;)[B", "public static")]
	public static JavaArray<byte> generateSignedData(JavaArray<byte> arg0, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg1, JavaArray<byte> arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.net.URI arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/Provider;Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;[BZZLjava/util/function/Function;)[B", "public static")]
	public static JavaArray<byte> generateNewSignedData(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.Provider arg1, Dova.JDK.java.security.PrivateKey arg2, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg3, JavaArray<byte> arg4, bool arg5, bool arg6, Dova.JDK.java.util.function.Function arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/timestamp/Timestamper;Ljava/lang/String;Ljava/lang/String;[B)[B", "public static")]
	public static JavaArray<byte> generateTimestampToken(Dova.JDK.sun.security.timestamp.Timestamper arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, JavaArray<byte> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isOldStyle()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "private")]
	public void parseSignedData(Dova.JDK.sun.security.util.DerValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "private")]
	public void parseOldSignedData(Dova.JDK.sun.security.util.DerValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "private")]
	public void parseNetscapeCertChain(Dova.JDK.sun.security.util.DerValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "public")]
	public void encodeSignedData(Dova.JDK.java.io.OutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/util/DerOutputStream;)V", "public")]
	public void encodeSignedData(Dova.JDK.sun.security.util.DerOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void populateCertIssuerNames()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("([B[Ljava/security/cert/X509Certificate;[BLsun/security/pkcs/PKCS9Attributes;Lsun/security/pkcs/PKCS9Attributes;Lsun/security/x509/AlgorithmId;Lsun/security/x509/AlgorithmId;)[B", "private static")]
	public static JavaArray<byte> constructToken(JavaArray<byte> arg0, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg1, JavaArray<byte> arg2, Dova.JDK.sun.security.pkcs.PKCS9Attributes arg3, Dova.JDK.sun.security.pkcs.PKCS9Attributes arg4, Dova.JDK.sun.security.x509.AlgorithmId arg5, Dova.JDK.sun.security.x509.AlgorithmId arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/x509/AlgorithmId;", "public")]
	public JavaArray<Dova.JDK.sun.security.x509.AlgorithmId> getDigestAlgorithmIds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.x509.AlgorithmId>>(ret);
	}

	[JniSignatureAttribute("Lsun/security/pkcs/PKCS7$SecureRandomHolder;", "private static")]
	public partial class SecureRandomHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SecureRandomHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs/PKCS7$SecureRandomHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RANDOM", "Ljava/security/SecureRandom;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/security/SecureRandom;", "static final")]
		public static Dova.JDK.java.security.SecureRandom RANDOM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SecureRandomHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SecureRandomHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs/PKCS7$SecureRandomHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
