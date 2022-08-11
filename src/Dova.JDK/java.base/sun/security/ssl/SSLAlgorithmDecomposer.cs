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

[JniSignatureAttribute("Lsun/security/ssl/SSLAlgorithmDecomposer;", "")]
public partial class SSLAlgorithmDecomposer
	: Dova.JDK.sun.security.util.AlgorithmDecomposer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLAlgorithmDecomposer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLAlgorithmDecomposer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onlyX509", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decomposes", "(Lsun/security/ssl/CipherSuite$MacAlg;Lsun/security/ssl/SSLCipher;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decomposes", "(Lsun/security/ssl/CipherSuite$HashAlg;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decomposes", "(Lsun/security/ssl/SSLCipher;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decomposes", "(Lsun/security/ssl/CipherSuite$KeyExchange;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decompose", "(Ljava/lang/String;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decompose", "(Lsun/security/ssl/CipherSuite$KeyExchange;Lsun/security/ssl/SSLCipher;Lsun/security/ssl/CipherSuite$MacAlg;Lsun/security/ssl/CipherSuite$HashAlg;)Ljava/util/Set;"));
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool onlyX509_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLAlgorithmDecomposer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Z)V", "")]
	public SSLAlgorithmDecomposer(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "")]
	public SSLAlgorithmDecomposer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLAlgorithmDecomposer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/ssl/CipherSuite$MacAlg;Lsun/security/ssl/SSLCipher;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set decomposes(Dova.JDK.sun.security.ssl.CipherSuite.MacAlg arg0, Dova.JDK.sun.security.ssl.SSLCipher arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/CipherSuite$HashAlg;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set decomposes(Dova.JDK.sun.security.ssl.CipherSuite.HashAlg arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set decomposes(Dova.JDK.sun.security.ssl.SSLCipher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/CipherSuite$KeyExchange;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set decomposes(Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set decompose(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/CipherSuite$KeyExchange;Lsun/security/ssl/SSLCipher;Lsun/security/ssl/CipherSuite$MacAlg;Lsun/security/ssl/CipherSuite$HashAlg;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set decompose(Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange arg0, Dova.JDK.sun.security.ssl.SSLCipher arg1, Dova.JDK.sun.security.ssl.CipherSuite.MacAlg arg2, Dova.JDK.sun.security.ssl.CipherSuite.HashAlg arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}
}
