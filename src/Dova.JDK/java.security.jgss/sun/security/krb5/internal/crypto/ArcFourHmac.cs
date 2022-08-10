/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Lsun/security/krb5/internal/crypto/ArcFourHmac;", "public")]
public partial class ArcFourHmac
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ArcFourHmac()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/crypto/ArcFourHmac;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CRYPTO", "Lsun/security/krb5/internal/crypto/dk/ArcFourCrypto;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ArcFourHmac", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "calculateChecksum", "([BI[BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "encryptSeq", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "decryptSeq", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "stringToKey", "([C)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "decrypt", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "encrypt", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "encryptRaw", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "decryptRaw", "([BI[B[BII[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getChecksumLength", "()I"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/crypto/dk/ArcFourCrypto;", "private static final")]
	public static Dova.JDK.sun.security.krb5.@internal.crypto.dk.ArcFourCrypto CRYPTO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.crypto.dk.ArcFourCrypto>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ArcFourHmac(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ArcFourHmac() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/crypto/ArcFourHmac;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BI[BII)[B", "public static")]
	public static JavaArray<byte> calculateChecksum(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> encryptSeq(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> decryptSeq(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([C)[B", "public static")]
	public static JavaArray<byte> stringToKey(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> decrypt(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> encrypt(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> encryptRaw(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII[B)[B", "public static")]
	public static JavaArray<byte> decryptRaw(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5, JavaArray<byte> arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getChecksumLength()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8]);
		return ret;
	}
}
