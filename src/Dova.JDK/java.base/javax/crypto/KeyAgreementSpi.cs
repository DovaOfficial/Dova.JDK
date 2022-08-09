/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.crypto;

[JniSignatureAttribute("Ljavax/crypto/KeyAgreementSpi;", "public abstract")]
public partial class KeyAgreementSpi
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyAgreementSpi()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/crypto/KeyAgreementSpi;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "KeyAgreementSpi", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineDoPhase", "(Ljava/security/Key;Z)Ljava/security/Key;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineGenerateSecret", "([BI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineGenerateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineGenerateSecret", "()[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineInit", "(Ljava/security/Key;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyAgreementSpi(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public KeyAgreementSpi() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/crypto/KeyAgreementSpi;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/Key;Z)Ljava/security/Key;", "protected abstract")]
	public Dova.JDK.java.security.Key engineDoPhase(Dova.JDK.java.security.Key arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
	}

	[JniSignatureAttribute("([BI)I", "protected abstract")]
	public int engineGenerateSecret(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/crypto/SecretKey;", "protected abstract")]
	public Dova.JDK.javax.crypto.SecretKey engineGenerateSecret(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("()[B", "protected abstract")]
	public JavaArray<byte> engineGenerateSecret()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/security/SecureRandom;)V", "protected abstract")]
	public void engineInit(Dova.JDK.java.security.Key arg0, Dova.JDK.java.security.SecureRandom arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "protected abstract")]
	public void engineInit(Dova.JDK.java.security.Key arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1, Dova.JDK.java.security.SecureRandom arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}
}