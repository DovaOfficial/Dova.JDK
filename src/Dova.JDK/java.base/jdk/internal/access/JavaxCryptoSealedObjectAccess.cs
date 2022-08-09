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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaxCryptoSealedObjectAccess;", "public abstract interface")]
public partial interface JavaxCryptoSealedObjectAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaxCryptoSealedObjectAccess()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/access/JavaxCryptoSealedObjectAccess;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExtObjectInputStream", "(Ljavax/crypto/SealedObject;Ljavax/crypto/Cipher;)Ljava/io/ObjectInputStream;"));
	}

	[JniSignatureAttribute("(Ljavax/crypto/SealedObject;Ljavax/crypto/Cipher;)Ljava/io/ObjectInputStream;", "public abstract")]
	Dova.JDK.java.io.ObjectInputStream getExtObjectInputStream(Dova.JDK.javax.crypto.SealedObject arg0, Dova.JDK.javax.crypto.Cipher arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputStream>(ret);
	}
}
