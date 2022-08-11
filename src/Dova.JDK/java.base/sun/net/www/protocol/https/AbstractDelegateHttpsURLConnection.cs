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

namespace Dova.JDK.sun.net.www.protocol.https;

[JniSignatureAttribute("Lsun/net/www/protocol/https/AbstractDelegateHttpsURLConnection;", "public abstract")]
public partial class AbstractDelegateHttpsURLConnection
	: Dova.JDK.sun.net.www.protocol.http.HttpURLConnection
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractDelegateHttpsURLConnection()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/protocol/https/AbstractDelegateHttpsURLConnection;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;Lsun/net/www/protocol/http/Handler;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;Ljava/net/Proxy;Lsun/net/www/protocol/http/Handler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConnected", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConnected", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSSLSession", "()Ljavax/net/ssl/SSLSession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNewClient", "(Ljava/net/URL;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNewClient", "(Ljava/net/URL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProxiedClient", "(Ljava/net/URL;Ljava/lang/String;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProxiedClient", "(Ljava/net/URL;Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "proxiedConnect", "(Ljava/net/URL;Ljava/lang/String;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServerCertificates", "()[Ljava/security/cert/Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNewHttpClient", "(Ljava/net/URL;Ljava/net/Proxy;I)Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNewHttpClient", "(Ljava/net/URL;Ljava/net/Proxy;IZ)Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalCertificates", "()[Ljava/security/cert/Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeerPrincipal", "()Ljava/security/Principal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalPrincipal", "()Ljava/security/Principal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCipherSuite", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractDelegateHttpsURLConnection(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/URL;Lsun/net/www/protocol/http/Handler;)V", "protected")]
	public AbstractDelegateHttpsURLConnection(Dova.JDK.java.net.URL arg0, Dova.JDK.sun.net.www.protocol.http.Handler arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/net/Proxy;Lsun/net/www/protocol/http/Handler;)V", "protected")]
	public AbstractDelegateHttpsURLConnection(Dova.JDK.java.net.URL arg0, Dova.JDK.java.net.Proxy arg1, Dova.JDK.sun.net.www.protocol.http.Handler arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/protocol/https/AbstractDelegateHttpsURLConnection;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void connect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isConnected()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setConnected(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSession;", "")]
	public Dova.JDK.javax.net.ssl.SSLSession getSSLSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSession>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Z)V", "public")]
	public void setNewClient(Dova.JDK.java.net.URL arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)V", "public")]
	public void setNewClient(Dova.JDK.java.net.URL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSocketFactory;", "protected abstract")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory getSSLSocketFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/HostnameVerifier;", "protected abstract")]
	public Dova.JDK.javax.net.ssl.HostnameVerifier getHostnameVerifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.HostnameVerifier>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/lang/String;IZ)V", "public")]
	public void setProxiedClient(Dova.JDK.java.net.URL arg0, Dova.JDK.java.lang.String arg1, int arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/lang/String;I)V", "public")]
	public void setProxiedClient(Dova.JDK.java.net.URL arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/lang/String;IZ)V", "protected")]
	public void proxiedConnect(Dova.JDK.java.net.URL arg0, Dova.JDK.java.lang.String arg1, int arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()[Ljava/security/cert/Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.Certificate> getServerCertificates()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/net/Proxy;I)Lsun/net/www/http/HttpClient;", "protected")]
	public Dova.JDK.sun.net.www.http.HttpClient getNewHttpClient(Dova.JDK.java.net.URL arg0, Dova.JDK.java.net.Proxy arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/net/Proxy;IZ)Lsun/net/www/http/HttpClient;", "protected")]
	public Dova.JDK.sun.net.www.http.HttpClient getNewHttpClient(Dova.JDK.java.net.URL arg0, Dova.JDK.java.net.Proxy arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("()[Ljava/security/cert/Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.Certificate> getLocalCertificates()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Principal;", "")]
	public Dova.JDK.java.security.Principal getPeerPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Principal>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Principal;", "")]
	public Dova.JDK.java.security.Principal getLocalPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Principal>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getCipherSuite()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
