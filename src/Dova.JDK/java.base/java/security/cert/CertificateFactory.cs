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

namespace Dova.JDK.java.security.cert;

[JniSignatureAttribute("Ljava/security/cert/CertificateFactory;", "public")]
public partial class CertificateFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CertificateFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/security/cert/CertificateFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "provider", "Ljava/security/Provider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "certFacSpi", "Ljava/security/cert/CertificateFactorySpi;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/cert/CertificateFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertificateFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertificateFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvider", "()Ljava/security/Provider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCertPathEncodings", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/Provider;", "private")]
	public Dova.JDK.java.security.Provider provider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/cert/CertificateFactorySpi;", "private")]
	public Dova.JDK.java.security.cert.CertificateFactorySpi certFacSpi_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertificateFactorySpi>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CertificateFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/security/cert/CertificateFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V", "protected")]
	public CertificateFactory(Dova.JDK.java.security.cert.CertificateFactorySpi arg0, Dova.JDK.java.security.Provider arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/security/cert/CertificateFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertificateFactory;", "public static final")]
	public static Dova.JDK.java.security.cert.CertificateFactory getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.Provider arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertificateFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertificateFactory;", "public static final")]
	public static Dova.JDK.java.security.cert.CertificateFactory getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertificateFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;", "public static final")]
	public static Dova.JDK.java.security.cert.CertificateFactory getInstance(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertificateFactory>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", "public final")]
	public Dova.JDK.java.security.cert.Certificate generateCertificate(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.Certificate>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", "public final")]
	public Dova.JDK.java.security.cert.CertPath generateCertPath(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertPath>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/security/cert/CertPath;", "public final")]
	public Dova.JDK.java.security.cert.CertPath generateCertPath(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertPath>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;", "public final")]
	public Dova.JDK.java.security.cert.CertPath generateCertPath(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertPath>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Provider;", "public final")]
	public Dova.JDK.java.security.Provider getProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public final")]
	public Dova.JDK.java.util.Iterator getCertPathEncodings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljava/util/Collection;", "public final")]
	public Dova.JDK.java.util.Collection generateCertificates(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljava/security/cert/CRL;", "public final")]
	public Dova.JDK.java.security.cert.CRL generateCRL(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CRL>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljava/util/Collection;", "public final")]
	public Dova.JDK.java.util.Collection generateCRLs(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}
}
