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

[JniSignatureAttribute("Lsun/net/www/protocol/https/HttpsClient;", "final")]
public partial class HttpsClient
	: Dova.JDK.sun.net.www.http.HttpClient
	, Dova.JDK.javax.net.ssl.HandshakeCompletedListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpsClient()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/protocol/https/HttpsClient;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "httpsPortNumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultHVCanonicalName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hv", "Ljavax/net/ssl/HostnameVerifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslSocketFactory", "Ljavax/net/ssl/SSLSocketFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "session", "Ljavax/net/ssl/SSLSession;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljava/lang/String;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljava/net/Proxy;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultPort", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "New", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;ZLsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "New", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Ljava/lang/String;ILsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "New", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Ljava/lang/String;IZLsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "New", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Ljava/net/Proxy;ZILsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "New", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Ljava/lang/String;IZILsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "New", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Lsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProtocols", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeIdleConnection", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInKeepAliveCache", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkURLSpoofing", "(Ljavax/net/ssl/HostnameVerifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUserAgent", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSSLSession", "()Ljavax/net/ssl/SSLSession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCipherSuites", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "afterConnect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsTunneling", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServerCertificates", "()[Ljava/security/cert/Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyHostUsed", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyPortUsed", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSocket", "()Ljava/net/Socket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handshakeCompleted", "(Ljavax/net/ssl/HandshakeCompletedEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalCertificates", "()[Ljava/security/cert/Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeerPrincipal", "()Ljava/security/Principal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalPrincipal", "()Ljava/security/Principal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCipherSuite", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int httpsPortNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String defaultHVCanonicalName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/HostnameVerifier;", "private")]
	public Dova.JDK.javax.net.ssl.HostnameVerifier hv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.HostnameVerifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLSocketFactory;", "private")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory sslSocketFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLSession;", "private")]
	public Dova.JDK.javax.net.ssl.SSLSession session_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSession>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpsClient(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;)V", "private")]
	public HttpsClient(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljava/lang/String;I)V", "")]
	public HttpsClient(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.java.lang.String arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljava/net/Proxy;I)V", "")]
	public HttpsClient(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.java.net.Proxy arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljava/lang/String;II)V", "")]
	public HttpsClient(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/protocol/https/HttpsClient;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "protected")]
	public int getDefaultPort()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;ZLsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;", "static")]
	public static Dova.JDK.sun.net.www.http.HttpClient New(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.javax.net.ssl.HostnameVerifier arg2, bool arg3, Dova.JDK.sun.net.www.protocol.http.HttpURLConnection arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Ljava/lang/String;ILsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;", "static")]
	public static Dova.JDK.sun.net.www.http.HttpClient New(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.javax.net.ssl.HostnameVerifier arg2, Dova.JDK.java.lang.String arg3, int arg4, Dova.JDK.sun.net.www.protocol.http.HttpURLConnection arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Ljava/lang/String;IZLsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;", "static")]
	public static Dova.JDK.sun.net.www.http.HttpClient New(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.javax.net.ssl.HostnameVerifier arg2, Dova.JDK.java.lang.String arg3, int arg4, bool arg5, Dova.JDK.sun.net.www.protocol.http.HttpURLConnection arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Ljava/net/Proxy;ZILsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;", "static")]
	public static Dova.JDK.sun.net.www.http.HttpClient New(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.javax.net.ssl.HostnameVerifier arg2, Dova.JDK.java.net.Proxy arg3, bool arg4, int arg5, Dova.JDK.sun.net.www.protocol.http.HttpURLConnection arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Ljava/lang/String;IZILsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;", "static")]
	public static Dova.JDK.sun.net.www.http.HttpClient New(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.javax.net.ssl.HostnameVerifier arg2, Dova.JDK.java.lang.String arg3, int arg4, bool arg5, int arg6, Dova.JDK.sun.net.www.protocol.http.HttpURLConnection arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;Ljava/net/URL;Ljavax/net/ssl/HostnameVerifier;Lsun/net/www/protocol/http/HttpURLConnection;)Lsun/net/www/http/HttpClient;", "static")]
	public static Dova.JDK.sun.net.www.http.HttpClient New(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.javax.net.ssl.HostnameVerifier arg2, Dova.JDK.sun.net.www.protocol.http.HttpURLConnection arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;)V", "")]
	public void setSSLSocketFactory(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/HostnameVerifier;)V", "")]
	public void setHostnameVerifier(Dova.JDK.javax.net.ssl.HostnameVerifier arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> getProtocols()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void closeIdleConnection()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void putInKeepAliveCache()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/HostnameVerifier;)V", "private")]
	public void checkURLSpoofing(Dova.JDK.javax.net.ssl.HostnameVerifier arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getUserAgent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSession;", "")]
	public Dova.JDK.javax.net.ssl.SSLSession getSSLSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSession>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> getCipherSuites()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSocketFactory;", "")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory getSSLSocketFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void afterConnect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool needsTunneling()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/security/cert/Certificate;", "")]
	public JavaArray<Dova.JDK.java.security.cert.Certificate> getServerCertificates()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getProxyHostUsed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getProxyPortUsed()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/Socket;", "protected")]
	public Dova.JDK.java.net.Socket createSocket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/HandshakeCompletedEvent;)V", "public")]
	public void handshakeCompleted(Dova.JDK.javax.net.ssl.HandshakeCompletedEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()[Ljava/security/cert/Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.Certificate> getLocalCertificates()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Principal;", "")]
	public Dova.JDK.java.security.Principal getPeerPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Principal>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Principal;", "")]
	public Dova.JDK.java.security.Principal getLocalPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Principal>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getCipherSuite()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
