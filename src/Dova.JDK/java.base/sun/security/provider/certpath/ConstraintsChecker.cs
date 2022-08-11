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

[JniSignatureAttribute("Lsun/security/provider/certpath/ConstraintsChecker;", "")]
public partial class ConstraintsChecker
	: Dova.JDK.java.security.cert.PKIXCertPathChecker
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConstraintsChecker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/ConstraintsChecker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Lsun/security/util/Debug;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "certPathLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxPathLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "i", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevNC", "Lsun/security/x509/NameConstraintsExtension;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportedExts", "Ljava/util/Set;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Ljava/security/cert/Certificate;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkBasicConstraints", "(Ljava/security/cert/X509Certificate;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyNameConstraints", "(Ljava/security/cert/X509Certificate;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mergeNameConstraints", "(Ljava/security/cert/X509Certificate;Lsun/security/x509/NameConstraintsExtension;)Lsun/security/x509/NameConstraintsExtension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mergeBasicConstraints", "(Ljava/security/cert/X509Certificate;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isForwardCheckingSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedExtensions", "()Ljava/util/Set;"));
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

	[JniSignatureAttribute("I", "private final")]
	public int certPathLength_Property
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

	[JniSignatureAttribute("I", "private")]
	public int maxPathLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int i_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/x509/NameConstraintsExtension;", "private")]
	public Dova.JDK.sun.security.x509.NameConstraintsExtension prevNC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.x509.NameConstraintsExtension>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set supportedExts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConstraintsChecker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "")]
	public ConstraintsChecker(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/ConstraintsChecker;";
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

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;)V", "private")]
	public void checkBasicConstraints(Dova.JDK.java.security.cert.X509Certificate arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;)V", "private")]
	public void verifyNameConstraints(Dova.JDK.java.security.cert.X509Certificate arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;Lsun/security/x509/NameConstraintsExtension;)Lsun/security/x509/NameConstraintsExtension;", "static")]
	public static Dova.JDK.sun.security.x509.NameConstraintsExtension mergeNameConstraints(Dova.JDK.java.security.cert.X509Certificate arg0, Dova.JDK.sun.security.x509.NameConstraintsExtension arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.x509.NameConstraintsExtension>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;I)I", "static")]
	public static int mergeBasicConstraints(Dova.JDK.java.security.cert.X509Certificate arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isForwardCheckingSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getSupportedExtensions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}
}
