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

[JniSignatureAttribute("Ljavax/net/ssl/SSLContextSpi;", "public abstract")]
public partial class SSLContextSpi
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLContextSpi()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ssl/SSLContextSpi;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineCreateSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineCreateSSLEngine", "()Ljavax/net/ssl/SSLEngine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultSocket", "()Ljavax/net/ssl/SSLSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetDefaultSSLParameters", "()Ljavax/net/ssl/SSLParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetSupportedSSLParameters", "()Ljavax/net/ssl/SSLParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLContextSpi(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SSLContextSpi() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/net/ssl/SSLContextSpi;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSessionContext;", "protected abstract")]
	public Dova.JDK.javax.net.ssl.SSLSessionContext engineGetClientSessionContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSessionContext>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSessionContext;", "protected abstract")]
	public Dova.JDK.javax.net.ssl.SSLSessionContext engineGetServerSessionContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSessionContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", "protected abstract")]
	public Dova.JDK.javax.net.ssl.SSLEngine engineCreateSSLEngine(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngine>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLEngine;", "protected abstract")]
	public Dova.JDK.javax.net.ssl.SSLEngine engineCreateSSLEngine()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngine>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSocketFactory;", "protected abstract")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory engineGetSocketFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLServerSocketFactory;", "protected abstract")]
	public Dova.JDK.javax.net.ssl.SSLServerSocketFactory engineGetServerSocketFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLServerSocketFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSocket;", "private")]
	public Dova.JDK.javax.net.ssl.SSLSocket getDefaultSocket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocket>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLParameters;", "protected")]
	public Dova.JDK.javax.net.ssl.SSLParameters engineGetDefaultSSLParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLParameters>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLParameters;", "protected")]
	public Dova.JDK.javax.net.ssl.SSLParameters engineGetSupportedSSLParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLParameters>(ret);
	}

	[JniSignatureAttribute("([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V", "protected abstract")]
	public void engineInit(JavaArray<Dova.JDK.javax.net.ssl.KeyManager> arg0, JavaArray<Dova.JDK.javax.net.ssl.TrustManager> arg1, Dova.JDK.java.security.SecureRandom arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}
}
