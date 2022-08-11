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

[JniSignatureAttribute("Lsun/security/ssl/AbstractTrustManagerWrapper;", "final")]
public partial class AbstractTrustManagerWrapper
	: Dova.JDK.javax.net.ssl.X509ExtendedTrustManager
	, Dova.JDK.javax.net.ssl.X509TrustManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractTrustManagerWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/AbstractTrustManagerWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tm", "Ljavax/net/ssl/X509TrustManager;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/X509TrustManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAdditionalTrust", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAdditionalTrust", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAlgorithmConstraints", "([Ljava/security/cert/X509Certificate;Ljava/security/AlgorithmConstraints;Z)V"));
	}

	[JniSignatureAttribute("Ljavax/net/ssl/X509TrustManager;", "private final")]
	public Dova.JDK.javax.net.ssl.X509TrustManager tm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractTrustManagerWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/X509TrustManager;)V", "")]
	public AbstractTrustManagerWrapper(Dova.JDK.javax.net.ssl.X509TrustManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/AbstractTrustManagerWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "public")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public")]
	public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public")]
	public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "public")]
	public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("()[Ljava/security/cert/X509Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.X509Certificate> getAcceptedIssuers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;Z)V", "private")]
	public void checkAdditionalTrust(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;Z)V", "private")]
	public void checkAdditionalTrust(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/security/AlgorithmConstraints;Z)V", "private")]
	public void checkAlgorithmConstraints(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.security.AlgorithmConstraints arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}
}
