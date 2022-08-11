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

[JniSignatureAttribute("Lsun/security/provider/certpath/PolicyChecker;", "")]
public partial class PolicyChecker
	: Dova.JDK.java.security.cert.PKIXCertPathChecker
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PolicyChecker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/PolicyChecker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initPolicies", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "certPathLen", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expPolicyRequired", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "polMappingInhibited", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anyPolicyInhibited", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rejectPolicyQualifiers", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootNode", "Lsun/security/provider/certpath/PolicyNodeImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "explicitPolicy", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "policyMapping", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inhibitAnyPolicy", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "certIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportedExts", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Lsun/security/util/Debug;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANY_POLICY", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Set;IZZZZLsun/security/provider/certpath/PolicyNodeImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Ljava/security/cert/Certificate;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPolicyTree", "()Ljava/security/cert/PolicyNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "processPolicies", "(ILjava/util/Set;IIIZLsun/security/provider/certpath/PolicyNodeImpl;Lsun/security/x509/X509CertImpl;Z)Lsun/security/provider/certpath/PolicyNodeImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mergeExplicitPolicy", "(ILsun/security/x509/X509CertImpl;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mergePolicyMapping", "(ILsun/security/x509/X509CertImpl;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mergeInhibitAnyPolicy", "(ILsun/security/x509/X509CertImpl;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "processParents", "(IZZLsun/security/provider/certpath/PolicyNodeImpl;Ljava/lang/String;Ljava/util/Set;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "processPolicyMappings", "(Lsun/security/x509/X509CertImpl;IILsun/security/provider/certpath/PolicyNodeImpl;ZLjava/util/Set;)Lsun/security/provider/certpath/PolicyNodeImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeInvalidNodes", "(Lsun/security/provider/certpath/PolicyNodeImpl;ILjava/util/Set;Lsun/security/x509/CertificatePoliciesExtension;)Lsun/security/provider/certpath/PolicyNodeImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rewriteLeafNodes", "(ILjava/util/Set;Lsun/security/provider/certpath/PolicyNodeImpl;)Lsun/security/provider/certpath/PolicyNodeImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isForwardCheckingSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedExtensions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPolicy", "(Ljava/security/cert/X509Certificate;)V"));
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set initPolicies_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int certPathLen_Property
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

	[JniSignatureAttribute("Z", "private final")]
	public bool expPolicyRequired_Property
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

	[JniSignatureAttribute("Z", "private final")]
	public bool polMappingInhibited_Property
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

	[JniSignatureAttribute("Z", "private final")]
	public bool anyPolicyInhibited_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool rejectPolicyQualifiers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/PolicyNodeImpl;", "private")]
	public Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl rootNode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int explicitPolicy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int policyMapping_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int inhibitAnyPolicy_Property
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

	[JniSignatureAttribute("I", "private")]
	public int certIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set supportedExts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String ANY_POLICY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PolicyChecker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Set;IZZZZLsun/security/provider/certpath/PolicyNodeImpl;)V", "")]
	public PolicyChecker(Dova.JDK.java.util.Set arg0, int arg1, bool arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/PolicyChecker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Z)V", "public")]
	public void init(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/cert/Certificate;Ljava/util/Collection;)V", "public")]
	public void check(Dova.JDK.java.security.cert.Certificate arg0, Dova.JDK.java.util.Collection arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/security/cert/PolicyNode;", "")]
	public Dova.JDK.java.security.cert.PolicyNode getPolicyTree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PolicyNode>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Set;IIIZLsun/security/provider/certpath/PolicyNodeImpl;Lsun/security/x509/X509CertImpl;Z)Lsun/security/provider/certpath/PolicyNodeImpl;", "static")]
	public static Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl processPolicies(int arg0, Dova.JDK.java.util.Set arg1, int arg2, int arg3, int arg4, bool arg5, Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl arg6, Dova.JDK.sun.security.x509.X509CertImpl arg7, bool arg8)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl>(ret);
	}

	[JniSignatureAttribute("(ILsun/security/x509/X509CertImpl;Z)I", "static")]
	public static int mergeExplicitPolicy(int arg0, Dova.JDK.sun.security.x509.X509CertImpl arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/security/x509/X509CertImpl;)I", "static")]
	public static int mergePolicyMapping(int arg0, Dova.JDK.sun.security.x509.X509CertImpl arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/security/x509/X509CertImpl;)I", "static")]
	public static int mergeInhibitAnyPolicy(int arg0, Dova.JDK.sun.security.x509.X509CertImpl arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IZZLsun/security/provider/certpath/PolicyNodeImpl;Ljava/lang/String;Ljava/util/Set;Z)Z", "private static")]
	public static bool processParents(int arg0, bool arg1, bool arg2, Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.util.Set arg5, bool arg6)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/x509/X509CertImpl;IILsun/security/provider/certpath/PolicyNodeImpl;ZLjava/util/Set;)Lsun/security/provider/certpath/PolicyNodeImpl;", "private static")]
	public static Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl processPolicyMappings(Dova.JDK.sun.security.x509.X509CertImpl arg0, int arg1, int arg2, Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl arg3, bool arg4, Dova.JDK.java.util.Set arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/provider/certpath/PolicyNodeImpl;ILjava/util/Set;Lsun/security/x509/CertificatePoliciesExtension;)Lsun/security/provider/certpath/PolicyNodeImpl;", "private static")]
	public static Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl removeInvalidNodes(Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl arg0, int arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.sun.security.x509.CertificatePoliciesExtension arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Set;Lsun/security/provider/certpath/PolicyNodeImpl;)Lsun/security/provider/certpath/PolicyNodeImpl;", "private static")]
	public static Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl rewriteLeafNodes(int arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.PolicyNodeImpl>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isForwardCheckingSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getSupportedExtensions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;)V", "private")]
	public void checkPolicy(Dova.JDK.java.security.cert.X509Certificate arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}
}
