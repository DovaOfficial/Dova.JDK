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

[JniSignatureAttribute("Lsun/net/www/protocol/https/DelegateHttpsURLConnection;", "public")]
public partial class DelegateHttpsURLConnection
	: Dova.JDK.sun.net.www.protocol.https.AbstractDelegateHttpsURLConnection
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DelegateHttpsURLConnection()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/protocol/https/DelegateHttpsURLConnection;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "httpsURLConnection", "Ljavax/net/ssl/HttpsURLConnection;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;Lsun/net/www/protocol/http/Handler;Ljavax/net/ssl/HttpsURLConnection;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;Ljava/net/Proxy;Lsun/net/www/protocol/http/Handler;Ljavax/net/ssl/HttpsURLConnection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;"));
	}

	[JniSignatureAttribute("Ljavax/net/ssl/HttpsURLConnection;", "public")]
	public Dova.JDK.javax.net.ssl.HttpsURLConnection httpsURLConnection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.HttpsURLConnection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DelegateHttpsURLConnection(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/URL;Lsun/net/www/protocol/http/Handler;Ljavax/net/ssl/HttpsURLConnection;)V", "")]
	public DelegateHttpsURLConnection(Dova.JDK.java.net.URL arg0, Dova.JDK.sun.net.www.protocol.http.Handler arg1, Dova.JDK.javax.net.ssl.HttpsURLConnection arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/net/Proxy;Lsun/net/www/protocol/http/Handler;Ljavax/net/ssl/HttpsURLConnection;)V", "")]
	public DelegateHttpsURLConnection(Dova.JDK.java.net.URL arg0, Dova.JDK.java.net.Proxy arg1, Dova.JDK.sun.net.www.protocol.http.Handler arg2, Dova.JDK.javax.net.ssl.HttpsURLConnection arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/protocol/https/DelegateHttpsURLConnection;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSocketFactory;", "protected")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory getSSLSocketFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/HostnameVerifier;", "protected")]
	public Dova.JDK.javax.net.ssl.HostnameVerifier getHostnameVerifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.HostnameVerifier>(ret);
	}
}
