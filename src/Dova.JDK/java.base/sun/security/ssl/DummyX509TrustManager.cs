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

[JniSignatureAttribute("Lsun/security/ssl/DummyX509TrustManager;", "final")]
public partial class DummyX509TrustManager
	: Dova.JDK.javax.net.ssl.X509ExtendedTrustManager
	, Dova.JDK.javax.net.ssl.X509TrustManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DummyX509TrustManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DummyX509TrustManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljavax/net/ssl/X509TrustManager;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;"));
	}

	[JniSignatureAttribute("Ljavax/net/ssl/X509TrustManager;", "static final")]
	public static Dova.JDK.javax.net.ssl.X509TrustManager INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DummyX509TrustManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public DummyX509TrustManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/DummyX509TrustManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
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
}
