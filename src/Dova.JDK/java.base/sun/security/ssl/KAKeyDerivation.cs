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

[JniSignatureAttribute("Lsun/security/ssl/KAKeyDerivation;", "public")]
public partial class KAKeyDerivation
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.ssl.SSLKeyDerivation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KAKeyDerivation()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/KAKeyDerivation;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithmName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Lsun/security/ssl/HandshakeContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localPrivateKey", "Ljava/security/PrivateKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerPublicKey", "Ljava/security/PublicKey;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lsun/security/ssl/HandshakeContext;Ljava/security/PrivateKey;Ljava/security/PublicKey;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deriveKey", "(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "t12DeriveKey", "(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "t13DeriveKey", "(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String algorithmName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeContext;", "private final")]
	public Dova.JDK.sun.security.ssl.HandshakeContext context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/PrivateKey;", "private final")]
	public Dova.JDK.java.security.PrivateKey localPrivateKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/PublicKey;", "private final")]
	public Dova.JDK.java.security.PublicKey peerPublicKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KAKeyDerivation(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/ssl/HandshakeContext;Ljava/security/PrivateKey;Ljava/security/PublicKey;)V", "")]
	public KAKeyDerivation(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.ssl.HandshakeContext arg1, Dova.JDK.java.security.PrivateKey arg2, Dova.JDK.java.security.PublicKey arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/KAKeyDerivation;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;", "public")]
	public Dova.JDK.javax.crypto.SecretKey deriveKey(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;", "private")]
	public Dova.JDK.javax.crypto.SecretKey t12DeriveKey(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;", "private")]
	public Dova.JDK.javax.crypto.SecretKey t13DeriveKey(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}
}
