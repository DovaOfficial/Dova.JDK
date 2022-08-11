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

namespace Dova.JDK.javax.net.ssl;

[JniSignatureAttribute("Ljavax/net/ssl/X509ExtendedTrustManager;", "public abstract")]
public partial class X509ExtendedTrustManager
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.net.ssl.X509TrustManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static X509ExtendedTrustManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ssl/X509ExtendedTrustManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public X509ExtendedTrustManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public X509ExtendedTrustManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/net/ssl/X509ExtendedTrustManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public abstract")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public abstract")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public abstract")]
	public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public abstract")]
	public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}
}
