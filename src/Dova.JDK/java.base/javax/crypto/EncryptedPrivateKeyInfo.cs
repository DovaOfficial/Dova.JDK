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

namespace Dova.JDK.javax.crypto;

[JniSignatureAttribute("Ljavax/crypto/EncryptedPrivateKeyInfo;", "public")]
public partial class EncryptedPrivateKeyInfo
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EncryptedPrivateKeyInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/crypto/EncryptedPrivateKeyInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algid", "Lsun/security/x509/AlgorithmId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyAlg", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encryptedData", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encoded", "[B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/AlgorithmParameters;[B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEncoded", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPKCS8Encoding", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySpecImpl", "(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkTag", "(Lsun/security/util/DerValue;BLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlgName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlgParameters", "()Ljava/security/AlgorithmParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEncryptedData", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySpec", "(Ljava/security/Key;Ljava/lang/String;)Ljava/security/spec/PKCS8EncodedKeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySpec", "(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySpec", "(Ljavax/crypto/Cipher;)Ljava/security/spec/PKCS8EncodedKeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySpec", "(Ljava/security/Key;)Ljava/security/spec/PKCS8EncodedKeySpec;"));
	}

	[JniSignatureAttribute("Lsun/security/x509/AlgorithmId;", "private")]
	public Dova.JDK.sun.security.x509.AlgorithmId algid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.x509.AlgorithmId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String keyAlg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> encryptedData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> encoded_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EncryptedPrivateKeyInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/security/AlgorithmParameters;[B)V", "public")]
	public EncryptedPrivateKeyInfo(Dova.JDK.java.security.AlgorithmParameters arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[B)V", "public")]
	public EncryptedPrivateKeyInfo(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public EncryptedPrivateKeyInfo(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/crypto/EncryptedPrivateKeyInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getEncoded()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)V", "private")]
	public void checkPKCS8Encoding(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeySpec;", "private")]
	public Dova.JDK.java.security.spec.PKCS8EncodedKeySpec getKeySpecImpl(Dova.JDK.java.security.Key arg0, Dova.JDK.java.security.Provider arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.PKCS8EncodedKeySpec>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/DerValue;BLjava/lang/String;)V", "private static")]
	public static void checkTag(Dova.JDK.sun.security.util.DerValue arg0, byte arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getAlgName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/AlgorithmParameters;", "public")]
	public Dova.JDK.java.security.AlgorithmParameters getAlgParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmParameters>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getEncryptedData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/lang/String;)Ljava/security/spec/PKCS8EncodedKeySpec;", "public")]
	public Dova.JDK.java.security.spec.PKCS8EncodedKeySpec getKeySpec(Dova.JDK.java.security.Key arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.PKCS8EncodedKeySpec>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeySpec;", "public")]
	public Dova.JDK.java.security.spec.PKCS8EncodedKeySpec getKeySpec(Dova.JDK.java.security.Key arg0, Dova.JDK.java.security.Provider arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.PKCS8EncodedKeySpec>(ret);
	}

	[JniSignatureAttribute("(Ljavax/crypto/Cipher;)Ljava/security/spec/PKCS8EncodedKeySpec;", "public")]
	public Dova.JDK.java.security.spec.PKCS8EncodedKeySpec getKeySpec(Dova.JDK.javax.crypto.Cipher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.PKCS8EncodedKeySpec>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)Ljava/security/spec/PKCS8EncodedKeySpec;", "public")]
	public Dova.JDK.java.security.spec.PKCS8EncodedKeySpec getKeySpec(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.PKCS8EncodedKeySpec>(ret);
	}
}
