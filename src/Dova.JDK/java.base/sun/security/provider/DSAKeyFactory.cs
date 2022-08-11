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

namespace Dova.JDK.sun.security.provider;

[JniSignatureAttribute("Lsun/security/provider/DSAKeyFactory;", "public")]
public partial class DSAKeyFactory
	: Dova.JDK.java.security.KeyFactorySpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DSAKeyFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/DSAKeyFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DSAKeyFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DSAKeyFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/DSAKeyFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", "protected")]
	public Dova.JDK.java.security.PublicKey engineGeneratePublic(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", "protected")]
	public Dova.JDK.java.security.PrivateKey engineGeneratePrivate(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)Ljava/security/Key;", "protected")]
	public Dova.JDK.java.security.Key engineTranslateKey(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", "protected")]
	public Dova.JDK.java.lang.Object engineGetKeySpec(Dova.JDK.java.security.Key arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
