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

namespace Dova.JDK.sun.security.provider.certpath;

[JniSignatureAttribute("Lsun/security/provider/certpath/SunCertPathBuilder;", "public final")]
public partial class SunCertPathBuilder
	: Dova.JDK.java.security.cert.CertPathBuilderSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SunCertPathBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/SunCertPathBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Lsun/security/util/Debug;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buildParams", "Lsun/security/provider/certpath/PKIX$BuilderParams;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cf", "Ljava/security/cert/CertificateFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pathCompleted", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "policyTreeResult", "Ljava/security/cert/PolicyNode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trustAnchor", "Ljava/security/cert/TrustAnchor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finalPublicKey", "Ljava/security/PublicKey;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/security/cert/PKIXCertPathBuilderResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetRevocationChecker", "()Ljava/security/cert/CertPathChecker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildCertPath", "(ZLjava/util/List;)Ljava/security/cert/PKIXCertPathBuilderResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildForward", "(Ljava/util/List;Ljava/util/LinkedList;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "depthFirstSearchForward", "(Ljavax/security/auth/x500/X500Principal;Lsun/security/provider/certpath/ForwardState;Lsun/security/provider/certpath/ForwardBuilder;Ljava/util/List;Ljava/util/LinkedList;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addVertices", "(Ljava/util/Collection;Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineBuild", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anchorIsTarget", "(Ljava/security/cert/TrustAnchor;Ljava/security/cert/CertSelector;)Z"));
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/PKIX$BuilderParams;", "private")]
	public Dova.JDK.sun.security.provider.certpath.PKIX.BuilderParams buildParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.PKIX.BuilderParams>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/cert/CertificateFactory;", "private")]
	public Dova.JDK.java.security.cert.CertificateFactory cf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertificateFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool pathCompleted_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/security/cert/PolicyNode;", "private")]
	public Dova.JDK.java.security.cert.PolicyNode policyTreeResult_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PolicyNode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/cert/TrustAnchor;", "private")]
	public Dova.JDK.java.security.cert.TrustAnchor trustAnchor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.TrustAnchor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/PublicKey;", "private")]
	public Dova.JDK.java.security.PublicKey finalPublicKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SunCertPathBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SunCertPathBuilder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/SunCertPathBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/security/cert/PKIXCertPathBuilderResult;", "private")]
	public Dova.JDK.java.security.cert.PKIXCertPathBuilderResult build()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PKIXCertPathBuilderResult>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/cert/CertPathChecker;", "public")]
	public Dova.JDK.java.security.cert.CertPathChecker engineGetRevocationChecker()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertPathChecker>(ret);
	}

	[JniSignatureAttribute("(ZLjava/util/List;)Ljava/security/cert/PKIXCertPathBuilderResult;", "private")]
	public Dova.JDK.java.security.cert.PKIXCertPathBuilderResult buildCertPath(bool arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PKIXCertPathBuilderResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/LinkedList;Z)V", "private")]
	public void buildForward(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.LinkedList arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/x500/X500Principal;Lsun/security/provider/certpath/ForwardState;Lsun/security/provider/certpath/ForwardBuilder;Ljava/util/List;Ljava/util/LinkedList;)V", "private")]
	public void depthFirstSearchForward(Dova.JDK.javax.security.auth.x500.X500Principal arg0, Dova.JDK.sun.security.provider.certpath.ForwardState arg1, Dova.JDK.sun.security.provider.certpath.ForwardBuilder arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.LinkedList arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Ljava/util/List;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List addVertices(Dova.JDK.java.util.Collection arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResult;", "public")]
	public Dova.JDK.java.security.cert.CertPathBuilderResult engineBuild(Dova.JDK.java.security.cert.CertPathParameters arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertPathBuilderResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/TrustAnchor;Ljava/security/cert/CertSelector;)Z", "private static")]
	public static bool anchorIsTarget(Dova.JDK.java.security.cert.TrustAnchor arg0, Dova.JDK.java.security.cert.CertSelector arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}
}
