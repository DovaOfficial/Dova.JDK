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

[JniSignatureAttribute("Lsun/security/provider/certpath/CertPathHelper;", "public abstract")]
public partial class CertPathHelper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CertPathHelper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/CertPathHelper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/security/provider/certpath/CertPathHelper;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDateAndTime", "(Ljava/security/cert/X509CRLSelector;Ljava/util/Date;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implSetPathToNames", "(Ljava/security/cert/X509CertSelector;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implSetDateAndTime", "(Ljava/security/cert/X509CRLSelector;Ljava/util/Date;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implIsJdkCA", "(Ljava/security/cert/TrustAnchor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setPathToNames", "(Ljava/security/cert/X509CertSelector;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isJdkCA", "(Ljava/security/cert/TrustAnchor;)Z"));
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/CertPathHelper;", "protected static")]
	public static Dova.JDK.sun.security.provider.certpath.CertPathHelper instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.CertPathHelper>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CertPathHelper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public CertPathHelper() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/CertPathHelper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/cert/X509CRLSelector;Ljava/util/Date;J)V", "public static")]
	public static void setDateAndTime(Dova.JDK.java.security.cert.X509CRLSelector arg0, Dova.JDK.java.util.Date arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509CertSelector;Ljava/util/Set;)V", "protected abstract")]
	public void implSetPathToNames(Dova.JDK.java.security.cert.X509CertSelector arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509CRLSelector;Ljava/util/Date;J)V", "protected abstract")]
	public void implSetDateAndTime(Dova.JDK.java.security.cert.X509CRLSelector arg0, Dova.JDK.java.util.Date arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/security/cert/TrustAnchor;)Z", "protected abstract")]
	public bool implIsJdkCA(Dova.JDK.java.security.cert.TrustAnchor arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509CertSelector;Ljava/util/Set;)V", "static")]
	public static void setPathToNames(Dova.JDK.java.security.cert.X509CertSelector arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/cert/TrustAnchor;)Z", "public static")]
	public static bool isJdkCA(Dova.JDK.java.security.cert.TrustAnchor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}
}
