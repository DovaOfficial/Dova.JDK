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

namespace Dova.JDK.sun.security.krb5.@internal.crypto.dk;

[JniSignatureAttribute("Lsun/security/krb5/internal/crypto/dk/Des3DkCrypto;", "public")]
public partial class Des3DkCrypto
	: Dova.JDK.sun.security.krb5.@internal.crypto.dk.DkCrypto
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Des3DkCrypto()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/crypto/dk/Des3DkCrypto;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO_IV", "[B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "des3Expand", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setParityBit", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringToKey", "([C)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringToKey", "([B[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parityFix", "([B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySeedLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "randomToKey", "([B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCipher", "([B[BI)Ljavax/crypto/Cipher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHmac", "([B[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChecksumLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "keyCorrection", "([B)[B"));
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> ZERO_IV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Des3DkCrypto(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Des3DkCrypto() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/crypto/dk/Des3DkCrypto;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BII)[B", "private static")]
	public static JavaArray<byte> des3Expand(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)V", "private static")]
	public static void setParityBit(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("([C)[B", "public")]
	public JavaArray<byte> stringToKey(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B[B)[B", "private")]
	public JavaArray<byte> stringToKey(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)[B", "public")]
	public JavaArray<byte> parityFix(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getKeySeedLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("([B)[B", "protected")]
	public JavaArray<byte> randomToKey(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B[BI)Ljavax/crypto/Cipher;", "protected")]
	public Dova.JDK.javax.crypto.Cipher getCipher(JavaArray<byte> arg0, JavaArray<byte> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Cipher>(ret);
	}

	[JniSignatureAttribute("([B[B)[B", "protected")]
	public JavaArray<byte> getHmac(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getChecksumLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("([B)[B", "private static")]
	public static JavaArray<byte> keyCorrection(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
