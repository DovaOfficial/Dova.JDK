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

namespace Dova.JDK.sun.security.krb5.@internal.crypto;

[JniSignatureAttribute("Lsun/security/krb5/internal/crypto/Des3;", "public")]
public partial class Des3
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Des3()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/krb5/internal/crypto/Des3;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CRYPTO", "Lsun/security/krb5/internal/crypto/dk/Des3DkCrypto;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Des3", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "calculateChecksum", "([BI[BII)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "stringToKey", "([C)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "parityFix", "([B)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "decrypt", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "encrypt", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "encryptRaw", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "decryptRaw", "([BI[B[BII)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getChecksumLength", "()I"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/crypto/dk/Des3DkCrypto;", "private static final")]
	public static Dova.JDK.sun.security.krb5.@internal.crypto.dk.Des3DkCrypto CRYPTO_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.crypto.dk.Des3DkCrypto>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Des3(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Des3() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/crypto/Des3;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BI[BII)[B", "public static")]
	public static JavaArray<byte> calculateChecksum(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([C)[B", "public static")]
	public static JavaArray<byte> stringToKey(JavaArray<char> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)[B", "public static")]
	public static JavaArray<byte> parityFix(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> decrypt(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> encrypt(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> encryptRaw(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[B[BII)[B", "public static")]
	public static JavaArray<byte> decryptRaw(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getChecksumLength()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7]);
		return ret;
	}
}
