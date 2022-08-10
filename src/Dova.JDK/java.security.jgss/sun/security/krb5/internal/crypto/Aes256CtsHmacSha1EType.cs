/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.krb5.@internal.crypto;

[JniSignatureAttribute("Lsun/security/krb5/internal/crypto/Aes256CtsHmacSha1EType;", "public final")]
public partial class Aes256CtsHmacSha1EType
	: Dova.JDK.sun.security.krb5.@internal.crypto.EType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Aes256CtsHmacSha1EType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/crypto/Aes256CtsHmacSha1EType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Aes256CtsHmacSha1EType", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "keyType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "blockSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "keySize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "eType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "decrypt", "([B[BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "decrypt", "([B[B[BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "encrypt", "([B[BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "encrypt", "([B[B[BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "minimumPadSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "confounderSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checksumType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checksumSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "decryptedData", "([B)[B"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Aes256CtsHmacSha1EType(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Aes256CtsHmacSha1EType() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/crypto/Aes256CtsHmacSha1EType;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int keyType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int blockSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int keySize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int eType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("([B[BI)[B", "public")]
	public JavaArray<byte> decrypt(JavaArray<byte> arg0, JavaArray<byte> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B[B[BI)[B", "public")]
	public JavaArray<byte> decrypt(JavaArray<byte> arg0, JavaArray<byte> arg1, JavaArray<byte> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B[BI)[B", "public")]
	public JavaArray<byte> encrypt(JavaArray<byte> arg0, JavaArray<byte> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B[B[BI)[B", "public")]
	public JavaArray<byte> encrypt(JavaArray<byte> arg0, JavaArray<byte> arg1, JavaArray<byte> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int minimumPadSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int confounderSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int checksumType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int checksumSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("([B)[B", "public")]
	public JavaArray<byte> decryptedData(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
