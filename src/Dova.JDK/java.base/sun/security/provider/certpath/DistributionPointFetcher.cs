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

namespace Dova.JDK.sun.security.provider.certpath;

[JniSignatureAttribute("Lsun/security/provider/certpath/DistributionPointFetcher;", "public")]
public partial class DistributionPointFetcher
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DistributionPointFetcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/DistributionPointFetcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "debug", "Lsun/security/util/Debug;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ALL_REASONS", "[Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DistributionPointFetcher", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getCRLs", "(Lsun/security/x509/X500Name;Ljavax/security/auth/x500/X500Principal;Ljava/util/List;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getCRLs", "(Ljava/security/cert/X509CRLSelector;ZLjava/security/PublicKey;Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/util/List;[ZLjava/util/Set;Ljava/util/Date;Ljava/lang/String;Ljava/security/cert/TrustAnchor;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getCRLs", "(Ljava/security/cert/X509CRLSelector;Lsun/security/x509/X509CertImpl;Lsun/security/x509/DistributionPoint;[ZZLjava/security/PublicKey;Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/util/List;Ljava/util/Set;Ljava/util/Date;Ljava/lang/String;Ljava/security/cert/TrustAnchor;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "verifyCRL", "(Lsun/security/x509/X509CertImpl;Lsun/security/x509/DistributionPoint;Ljava/security/cert/X509CRL;[ZZLjava/security/PublicKey;Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/util/Set;Ljava/util/List;Ljava/util/Date;Ljava/lang/String;Ljava/security/cert/TrustAnchor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getFullNames", "(Lsun/security/x509/X500Name;Lsun/security/x509/RDN;)Lsun/security/x509/GeneralNames;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getCRL", "(Lsun/security/x509/URIName;)Ljava/security/cert/X509CRL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "issues", "(Lsun/security/x509/X509CertImpl;Lsun/security/x509/X509CRLImpl;Ljava/lang/String;)Z"));
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Z", "private static final")]
	public static JavaArray<bool> ALL_REASONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DistributionPointFetcher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public DistributionPointFetcher() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/DistributionPointFetcher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/x509/X500Name;Ljavax/security/auth/x500/X500Principal;Ljava/util/List;)Ljava/util/Collection;", "private static")]
	public static Dova.JDK.java.util.Collection getCRLs(Dova.JDK.sun.security.x509.X500Name arg0, Dova.JDK.javax.security.auth.x500.X500Principal arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509CRLSelector;ZLjava/security/PublicKey;Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/util/List;[ZLjava/util/Set;Ljava/util/Date;Ljava/lang/String;Ljava/security/cert/TrustAnchor;)Ljava/util/Collection;", "public static")]
	public static Dova.JDK.java.util.Collection getCRLs(Dova.JDK.java.security.cert.X509CRLSelector arg0, bool arg1, Dova.JDK.java.security.PublicKey arg2, Dova.JDK.java.security.cert.X509Certificate arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.util.List arg5, JavaArray<bool> arg6, Dova.JDK.java.util.Set arg7, Dova.JDK.java.util.Date arg8, Dova.JDK.java.lang.String arg9, Dova.JDK.java.security.cert.TrustAnchor arg10)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509CRLSelector;Lsun/security/x509/X509CertImpl;Lsun/security/x509/DistributionPoint;[ZZLjava/security/PublicKey;Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/util/List;Ljava/util/Set;Ljava/util/Date;Ljava/lang/String;Ljava/security/cert/TrustAnchor;)Ljava/util/Collection;", "private static")]
	public static Dova.JDK.java.util.Collection getCRLs(Dova.JDK.java.security.cert.X509CRLSelector arg0, Dova.JDK.sun.security.x509.X509CertImpl arg1, Dova.JDK.sun.security.x509.DistributionPoint arg2, JavaArray<bool> arg3, bool arg4, Dova.JDK.java.security.PublicKey arg5, Dova.JDK.java.security.cert.X509Certificate arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.util.List arg8, Dova.JDK.java.util.Set arg9, Dova.JDK.java.util.Date arg10, Dova.JDK.java.lang.String arg11, Dova.JDK.java.security.cert.TrustAnchor arg12)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/x509/X509CertImpl;Lsun/security/x509/DistributionPoint;Ljava/security/cert/X509CRL;[ZZLjava/security/PublicKey;Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/util/Set;Ljava/util/List;Ljava/util/Date;Ljava/lang/String;Ljava/security/cert/TrustAnchor;)Z", "static")]
	public static bool verifyCRL(Dova.JDK.sun.security.x509.X509CertImpl arg0, Dova.JDK.sun.security.x509.DistributionPoint arg1, Dova.JDK.java.security.cert.X509CRL arg2, JavaArray<bool> arg3, bool arg4, Dova.JDK.java.security.PublicKey arg5, Dova.JDK.java.security.cert.X509Certificate arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.util.Set arg8, Dova.JDK.java.util.List arg9, Dova.JDK.java.util.Date arg10, Dova.JDK.java.lang.String arg11, Dova.JDK.java.security.cert.TrustAnchor arg12)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/x509/X500Name;Lsun/security/x509/RDN;)Lsun/security/x509/GeneralNames;", "private static")]
	public static Dova.JDK.sun.security.x509.GeneralNames getFullNames(Dova.JDK.sun.security.x509.X500Name arg0, Dova.JDK.sun.security.x509.RDN arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.x509.GeneralNames>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/x509/URIName;)Ljava/security/cert/X509CRL;", "private static")]
	public static Dova.JDK.java.security.cert.X509CRL getCRL(Dova.JDK.sun.security.x509.URIName arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509CRL>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/x509/X509CertImpl;Lsun/security/x509/X509CRLImpl;Ljava/lang/String;)Z", "private static")]
	public static bool issues(Dova.JDK.sun.security.x509.X509CertImpl arg0, Dova.JDK.sun.security.x509.X509CRLImpl arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}
}
