/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.pkcs11;

[JniSignatureAttribute("Lsun/security/pkcs11/P11TlsRsaPremasterSecretGenerator;", "final")]
public partial class P11TlsRsaPremasterSecretGenerator
	: Dova.JDK.javax.crypto.KeyGeneratorSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static P11TlsRsaPremasterSecretGenerator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/P11TlsRsaPremasterSecretGenerator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MSG", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lsun/security/pkcs11/Token;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mechanism", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spec", "Lsun/security/internal/spec/TlsRsaPremasterSecretParameterSpec;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportSSLv3", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/Token;Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGenerateKey", "()Ljavax/crypto/SecretKey;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String MSG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/Token;", "private final")]
	public Dova.JDK.sun.security.pkcs11.Token token_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Token>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String algorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long mechanism_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/internal/spec/TlsRsaPremasterSecretParameterSpec;", "private")]
	public Dova.JDK.sun.security.@internal.spec.TlsRsaPremasterSecretParameterSpec spec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.@internal.spec.TlsRsaPremasterSecretParameterSpec>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool supportSSLv3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public P11TlsRsaPremasterSecretGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;Ljava/lang/String;J)V", "")]
	public P11TlsRsaPremasterSecretGenerator(Dova.JDK.sun.security.pkcs11.Token arg0, Dova.JDK.java.lang.String arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/P11TlsRsaPremasterSecretGenerator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILjava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.SecureRandom arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(Dova.JDK.java.security.spec.AlgorithmParameterSpec arg0, Dova.JDK.java.security.SecureRandom arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(Dova.JDK.java.security.SecureRandom arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljavax/crypto/SecretKey;", "protected")]
	public Dova.JDK.javax.crypto.SecretKey engineGenerateKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}
}
