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

namespace Dova.JDK.com.sun.jarsigner;

[JniSignatureAttribute("Lcom/sun/jarsigner/ContentSignerParameters;", "public abstract interface")]
public partial interface ContentSignerParameters
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ContentSignerParameters()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jarsigner/ContentSignerParameters;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignature", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContent", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSource", "()Ljava/util/zip/ZipFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestampingAuthority", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommandLine", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestampingAuthorityCertificate", "()Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTSAPolicyID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTSADigestAlg", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignatureAlgorithm", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignerCertificateChain", "()[Ljava/security/cert/X509Certificate;"));
	}

	[JniSignatureAttribute("()[B", "public abstract")]
	JavaArray<byte> getSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()[B", "public abstract")]
	JavaArray<byte> getContent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/zip/ZipFile;", "public abstract")]
	Dova.JDK.java.util.zip.ZipFile getSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.zip.ZipFile>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "public abstract")]
	Dova.JDK.java.net.URI getTimestampingAuthority()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.String> getCommandLine()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/cert/X509Certificate;", "public abstract")]
	Dova.JDK.java.security.cert.X509Certificate getTimestampingAuthorityCertificate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String getTSAPolicyID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String getTSADigestAlg()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getSignatureAlgorithm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Ljava/security/cert/X509Certificate;", "public abstract")]
	JavaArray<Dova.JDK.java.security.cert.X509Certificate> getSignerCertificateChain()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
	}
}
