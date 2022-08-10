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

namespace Dova.JDK.sun.security.pkcs11.wrapper;

[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_MECHANISM;", "public")]
public partial class CK_MECHANISM
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CK_MECHANISM()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/wrapper/CK_MECHANISM;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "mechanism", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pParameter", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pHandle", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLjava/lang/Long;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_ECDH1_DERIVE_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_TLS_MAC_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_TLS_PRF_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_SALSA20_CHACHA20_POLY1305_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_CCM_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_GCM_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_AES_CTR_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_VERSION;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLjava/math/BigInteger;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(J[B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(J)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_TLS12_KEY_MAT_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_SSL3_KEY_MAT_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_TLS12_MASTER_KEY_DERIVE_PARAMS;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_MECHANISM", "(JLsun/security/pkcs11/wrapper/CK_SSL3_MASTER_KEY_DERIVE_PARAMS;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "init", "(JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "freeHandle", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setParameter", "(Lsun/security/pkcs11/wrapper/CK_RSA_PKCS_PSS_PARAMS;)V"));
	}

	[JniSignatureAttribute("J", "public")]
	public long mechanism_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object pParameter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private")]
	public long pHandle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CK_MECHANISM(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(JLjava/lang/Long;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.java.lang.Long arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_ECDH1_DERIVE_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_ECDH1_DERIVE_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_TLS_MAC_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_TLS_MAC_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_TLS_PRF_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_TLS_PRF_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_SALSA20_CHACHA20_POLY1305_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_SALSA20_CHACHA20_POLY1305_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_CCM_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_CCM_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_GCM_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_GCM_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[6], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_AES_CTR_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_AES_CTR_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[7], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_VERSION;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[8], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLjava/math/BigInteger;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.java.math.BigInteger arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[9], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(J[B)V", "public")]
	public CK_MECHANISM(long arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[10], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public CK_MECHANISM(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[11], arg0))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_TLS12_KEY_MAT_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_TLS12_KEY_MAT_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[12], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_SSL3_KEY_MAT_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_KEY_MAT_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[13], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_TLS12_MASTER_KEY_DERIVE_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_TLS12_MASTER_KEY_DERIVE_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[14], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_SSL3_MASTER_KEY_DERIVE_PARAMS;)V", "public")]
	public CK_MECHANISM(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_MASTER_KEY_DERIVE_PARAMS arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[15], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/CK_MECHANISM;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JLjava/lang/Object;)V", "private")]
	public void init(long arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void freeHandle()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/wrapper/CK_RSA_PKCS_PSS_PARAMS;)V", "public")]
	public void setParameter(Dova.JDK.sun.security.pkcs11.wrapper.CK_RSA_PKCS_PSS_PARAMS arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}
}
