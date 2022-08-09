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

namespace Dova.JDK.com.sun.crypto.provider;

[JniSignatureAttribute("Lcom/sun/crypto/provider/CipherForKeyProtector;", "final")]
public partial class CipherForKeyProtector
	: Dova.JDK.javax.crypto.Cipher
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CipherForKeyProtector()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/crypto/provider/CipherForKeyProtector;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CipherForKeyProtector", "(Ljavax/crypto/CipherSpi;Ljava/security/Provider;Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CipherForKeyProtector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/crypto/CipherSpi;Ljava/security/Provider;Ljava/lang/String;)V", "protected")]
	public CipherForKeyProtector(Dova.JDK.javax.crypto.CipherSpi arg0, Dova.JDK.java.security.Provider arg1, Dova.JDK.java.lang.String arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/CipherForKeyProtector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
