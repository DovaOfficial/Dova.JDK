/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:22)
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

[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11;", "public")]
public partial class PKCS11
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PKCS11()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/wrapper/PKCS11;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PKCS11_WRAPPER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pkcs11ModulePath", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "version", "Lsun/security/pkcs11/wrapper/CK_VERSION;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pNativeData", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "moduleMap", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PKCS11", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finalize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Ljava/lang/String;Ljava/lang/String;Lsun/security/pkcs11/wrapper/CK_C_INITIALIZE_ARGS;Z)Lsun/security/pkcs11/wrapper/PKCS11;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "connect", "(Ljava/lang/String;Ljava/lang/String;)Lsun/security/pkcs11/wrapper/CK_VERSION;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVersion", "()Lsun/security/pkcs11/wrapper/CK_VERSION;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyRecoverInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_WrapKey", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;JJ)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_UnwrapKey", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J[B[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetAttributeValue", "(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyFinal", "(J[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Verify", "(J[B[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyUpdate", "(JJ[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignUpdate", "(JJ[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignFinal", "(JI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GenerateKey", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DestroyObject", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNativeKeyInfo", "(JJJLsun/security/pkcs11/wrapper/CK_MECHANISM;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createNativeKey", "(J[BJLsun/security/pkcs11/wrapper/CK_MECHANISM;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "freeMechanism", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetTokenInfo", "(J)Lsun/security/pkcs11/wrapper/CK_TOKEN_INFO;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetSessionInfo", "(J)Lsun/security/pkcs11/wrapper/CK_SESSION_INFO;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetSlotInfo", "(J)Lsun/security/pkcs11/wrapper/CK_SLOT_INFO;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetMechanismInfo", "(JJ)Lsun/security/pkcs11/wrapper/CK_MECHANISM_INFO;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Sign", "(J[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyRecover", "(J[BII[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Encrypt", "(JJ[BIIJ[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Decrypt", "(JJ[BIIJ[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_EncryptInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DecryptInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SeedRandom", "(J[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GenerateRandom", "(J[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_EncryptFinal", "(JJ[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DecryptFinal", "(JJ[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_EncryptUpdate", "(JJ[BIIJ[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DecryptUpdate", "(JJ[BIIJ[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetInfo", "()Lsun/security/pkcs11/wrapper/CK_INFO;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Initialize", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestSingle", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[BII[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestUpdate", "(JJ[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestFinal", "(J[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestKey", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetOperationState", "(J)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SetOperationState", "(J[BJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "loadNative", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "initializeLibrary", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "finalizeLibrary", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Finalize", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetSlotList", "(Z)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetMechanismList", "(J)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_OpenSession", "(JJLjava/lang/Object;Lsun/security/pkcs11/wrapper/CK_NOTIFY;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_CloseSession", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Login", "(JJ[C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Logout", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignRecoverInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignRecover", "(J[BII[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_CreateObject", "(J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GenerateKeyPair", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DeriveKey", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SetAttributeValue", "(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_CopyObject", "(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_FindObjectsInit", "(J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_FindObjects", "(JJ)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_FindObjectsFinal", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "disconnect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SessionCancel", "(JJ)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PKCS11_WRAPPER_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String pkcs11ModulePath_Property
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

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_VERSION;", "private final")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long pNativeData_Property
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

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map moduleMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PKCS11(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "")]
	public PKCS11(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/PKCS11;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "protected")]
	public void finalize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lsun/security/pkcs11/wrapper/CK_C_INITIALIZE_ARGS;Z)Lsun/security/pkcs11/wrapper/PKCS11;", "public static synchronized")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11 getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.sun.security.pkcs11.wrapper.CK_C_INITIALIZE_ARGS arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lsun/security/pkcs11/wrapper/CK_VERSION;", "private native")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION connect(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/wrapper/CK_VERSION;", "public")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION getVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION>(ret);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public native")]
	public void C_VerifyRecoverInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;JJ)[B", "public native")]
	public JavaArray<byte> C_WrapKey(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J[B[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public native")]
	public long C_UnwrapKey(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2, JavaArray<byte> arg3, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V", "public native")]
	public void C_GetAttributeValue(long arg0, long arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J[B)V", "public native")]
	public void C_VerifyFinal(long arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(J[B[B)V", "public native")]
	public void C_Verify(long arg0, JavaArray<byte> arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public native")]
	public void C_VerifyInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ[BII)V", "public native")]
	public void C_VerifyUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(JJ[BII)V", "public native")]
	public void C_SignUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(JI)[B", "public native")]
	public JavaArray<byte> C_SignFinal(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public native")]
	public void C_SignInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public native")]
	public long C_GenerateKey(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "public native")]
	public void C_DestroyObject(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(JJJLsun/security/pkcs11/wrapper/CK_MECHANISM;)[B", "public native")]
	public JavaArray<byte> getNativeKeyInfo(long arg0, long arg1, long arg2, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(J[BJLsun/security/pkcs11/wrapper/CK_MECHANISM;)J", "public native")]
	public long createNativeKey(long arg0, JavaArray<byte> arg1, long arg2, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public static native")]
	public static long freeMechanism(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Lsun/security/pkcs11/wrapper/CK_TOKEN_INFO;", "public native")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_TOKEN_INFO C_GetTokenInfo(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_TOKEN_INFO>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/security/pkcs11/wrapper/CK_SESSION_INFO;", "public native")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_SESSION_INFO C_GetSessionInfo(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_SESSION_INFO>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/security/pkcs11/wrapper/CK_SLOT_INFO;", "public native")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_SLOT_INFO C_GetSlotInfo(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_SLOT_INFO>(ret);
	}

	[JniSignatureAttribute("(JJ)Lsun/security/pkcs11/wrapper/CK_MECHANISM_INFO;", "public native")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM_INFO C_GetMechanismInfo(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM_INFO>(ret);
	}

	[JniSignatureAttribute("(J[B)[B", "public native")]
	public JavaArray<byte> C_Sign(long arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(J[BII[BII)I", "public native")]
	public int C_VerifyRecover(long arg0, JavaArray<byte> arg1, int arg2, int arg3, JavaArray<byte> arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(JJ[BIIJ[BII)I", "public native")]
	public int C_Encrypt(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4, long arg5, JavaArray<byte> arg6, int arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(JJ[BIIJ[BII)I", "public native")]
	public int C_Decrypt(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4, long arg5, JavaArray<byte> arg6, int arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public native")]
	public void C_EncryptInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public native")]
	public void C_DecryptInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J[B)V", "public native")]
	public void C_SeedRandom(long arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(J[B)V", "public native")]
	public void C_GenerateRandom(long arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ[BII)I", "public native")]
	public int C_EncryptFinal(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(JJ[BII)I", "public native")]
	public int C_DecryptFinal(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(JJ[BIIJ[BII)I", "public native")]
	public int C_EncryptUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4, long arg5, JavaArray<byte> arg6, int arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(JJ[BIIJ[BII)I", "public native")]
	public int C_DecryptUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4, long arg5, JavaArray<byte> arg6, int arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/wrapper/CK_INFO;", "public native")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_INFO C_GetInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_INFO>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "native")]
	public void C_Initialize(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[BII[BII)I", "public native")]
	public int C_DigestSingle(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, JavaArray<byte> arg2, int arg3, int arg4, JavaArray<byte> arg5, int arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(JJ[BII)V", "public native")]
	public void C_DigestUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(J[BII)I", "public native")]
	public int C_DigestFinal(long arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;)V", "public native")]
	public void C_DigestInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "public native")]
	public void C_DigestKey(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
	}

	[JniSignatureAttribute("(J)[B", "public native")]
	public JavaArray<byte> C_GetOperationState(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(J[BJJ)V", "public native")]
	public void C_SetOperationState(long arg0, JavaArray<byte> arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void loadNative()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[46]);
	}

	[JniSignatureAttribute("(Z)V", "private static native")]
	public static void initializeLibrary(bool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void finalizeLibrary()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[48]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public native")]
	public void C_Finalize(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("(Z)[J", "public native")]
	public JavaArray<long> C_GetSlotList(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(J)[J", "public native")]
	public JavaArray<long> C_GetMechanismList(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(JJLjava/lang/Object;Lsun/security/pkcs11/wrapper/CK_NOTIFY;)J", "public native")]
	public long C_OpenSession(long arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.sun.security.pkcs11.wrapper.CK_NOTIFY arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public native")]
	public void C_CloseSession(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("(JJ[C)V", "public native")]
	public void C_Login(long arg0, long arg1, JavaArray<char> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)V", "public native")]
	public void C_Logout(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public native")]
	public void C_SignRecoverInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J[BII[BII)I", "public native")]
	public int C_SignRecover(long arg0, JavaArray<byte> arg1, int arg2, int arg3, JavaArray<byte> arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public native")]
	public long C_CreateObject(long arg0, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[J", "public native")]
	public JavaArray<long> C_GenerateKeyPair(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public native")]
	public long C_DeriveKey(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V", "public native")]
	public void C_SetAttributeValue(long arg0, long arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public native")]
	public long C_CopyObject(long arg0, long arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V", "public native")]
	public void C_FindObjectsInit(long arg0, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)[J", "public native")]
	public JavaArray<long> C_FindObjects(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(J)V", "public native")]
	public void C_FindObjectsFinal(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("()V", "private native")]
	public void disconnect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66]);
	}

	[JniSignatureAttribute("(JJ)V", "public native")]
	public void C_SessionCancel(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11$SynchronizedPKCS11;", "static")]
	public partial class SynchronizedPKCS11
		: Dova.JDK.sun.security.pkcs11.wrapper.PKCS11
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SynchronizedPKCS11()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/wrapper/PKCS11$SynchronizedPKCS11;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SynchronizedPKCS11", "(Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyRecoverInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_WrapKey", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;JJ)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_UnwrapKey", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J[B[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetAttributeValue", "(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyFinal", "(J[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Verify", "(J[B[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyUpdate", "(JJ[BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignUpdate", "(JJ[BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignFinal", "(JI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GenerateKey", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DestroyObject", "(JJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetTokenInfo", "(J)Lsun/security/pkcs11/wrapper/CK_TOKEN_INFO;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetSessionInfo", "(J)Lsun/security/pkcs11/wrapper/CK_SESSION_INFO;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetSlotInfo", "(J)Lsun/security/pkcs11/wrapper/CK_SLOT_INFO;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetMechanismInfo", "(JJ)Lsun/security/pkcs11/wrapper/CK_MECHANISM_INFO;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Sign", "(J[B)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_VerifyRecover", "(J[BII[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Encrypt", "(JJ[BIIJ[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Decrypt", "(JJ[BIIJ[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_EncryptInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DecryptInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SeedRandom", "(J[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GenerateRandom", "(J[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_EncryptFinal", "(JJ[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DecryptFinal", "(JJ[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_EncryptUpdate", "(JJ[BIIJ[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DecryptUpdate", "(JJ[BIIJ[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetInfo", "()Lsun/security/pkcs11/wrapper/CK_INFO;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Initialize", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestSingle", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[BII[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestUpdate", "(JJ[BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestFinal", "(J[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DigestKey", "(JJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Finalize", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetSlotList", "(Z)[J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GetMechanismList", "(J)[J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_OpenSession", "(JJLjava/lang/Object;Lsun/security/pkcs11/wrapper/CK_NOTIFY;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_CloseSession", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Login", "(JJ[C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_Logout", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignRecoverInit", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SignRecover", "(J[BII[BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_CreateObject", "(J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_GenerateKeyPair", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_DeriveKey", "(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SetAttributeValue", "(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_CopyObject", "(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_FindObjectsInit", "(J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_FindObjects", "(JJ)[J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_FindObjectsFinal", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "C_SessionCancel", "(JJ)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SynchronizedPKCS11(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public SynchronizedPKCS11(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/PKCS11$SynchronizedPKCS11;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public synchronized")]
		public void C_VerifyRecoverInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;JJ)[B", "public synchronized")]
		public JavaArray<byte> C_WrapKey(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J[B[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public synchronized")]
		public long C_UnwrapKey(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2, JavaArray<byte> arg3, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg4)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V", "public synchronized")]
		public void C_GetAttributeValue(long arg0, long arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(J[B)V", "public synchronized")]
		public void C_VerifyFinal(long arg0, JavaArray<byte> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(J[B[B)V", "public synchronized")]
		public void C_Verify(long arg0, JavaArray<byte> arg1, JavaArray<byte> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public synchronized")]
		public void C_VerifyInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(JJ[BII)V", "public synchronized")]
		public void C_VerifyUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(JJ[BII)V", "public synchronized")]
		public void C_SignUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(JI)[B", "public synchronized")]
		public JavaArray<byte> C_SignFinal(long arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public synchronized")]
		public void C_SignInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public synchronized")]
		public long C_GenerateKey(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(JJ)V", "public synchronized")]
		public void C_DestroyObject(long arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		}

		[JniSignatureAttribute("(J)Lsun/security/pkcs11/wrapper/CK_TOKEN_INFO;", "public synchronized")]
		public Dova.JDK.sun.security.pkcs11.wrapper.CK_TOKEN_INFO C_GetTokenInfo(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_TOKEN_INFO>(ret);
		}

		[JniSignatureAttribute("(J)Lsun/security/pkcs11/wrapper/CK_SESSION_INFO;", "public synchronized")]
		public Dova.JDK.sun.security.pkcs11.wrapper.CK_SESSION_INFO C_GetSessionInfo(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_SESSION_INFO>(ret);
		}

		[JniSignatureAttribute("(J)Lsun/security/pkcs11/wrapper/CK_SLOT_INFO;", "public synchronized")]
		public Dova.JDK.sun.security.pkcs11.wrapper.CK_SLOT_INFO C_GetSlotInfo(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_SLOT_INFO>(ret);
		}

		[JniSignatureAttribute("(JJ)Lsun/security/pkcs11/wrapper/CK_MECHANISM_INFO;", "public synchronized")]
		public Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM_INFO C_GetMechanismInfo(long arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM_INFO>(ret);
		}

		[JniSignatureAttribute("(J[B)[B", "public synchronized")]
		public JavaArray<byte> C_Sign(long arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(J[BII[BII)I", "public synchronized")]
		public int C_VerifyRecover(long arg0, JavaArray<byte> arg1, int arg2, int arg3, JavaArray<byte> arg4, int arg5, int arg6)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return ret;
		}

		[JniSignatureAttribute("(JJ[BIIJ[BII)I", "public synchronized")]
		public int C_Encrypt(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4, long arg5, JavaArray<byte> arg6, int arg7, int arg8)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return ret;
		}

		[JniSignatureAttribute("(JJ[BIIJ[BII)I", "public synchronized")]
		public int C_Decrypt(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4, long arg5, JavaArray<byte> arg6, int arg7, int arg8)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return ret;
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public synchronized")]
		public void C_EncryptInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public synchronized")]
		public void C_DecryptInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(J[B)V", "public synchronized")]
		public void C_SeedRandom(long arg0, JavaArray<byte> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		}

		[JniSignatureAttribute("(J[B)V", "public synchronized")]
		public void C_GenerateRandom(long arg0, JavaArray<byte> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		}

		[JniSignatureAttribute("(JJ[BII)I", "public synchronized")]
		public int C_EncryptFinal(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(JJ[BII)I", "public synchronized")]
		public int C_DecryptFinal(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(JJ[BIIJ[BII)I", "public synchronized")]
		public int C_EncryptUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4, long arg5, JavaArray<byte> arg6, int arg7, int arg8)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return ret;
		}

		[JniSignatureAttribute("(JJ[BIIJ[BII)I", "public synchronized")]
		public int C_DecryptUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4, long arg5, JavaArray<byte> arg6, int arg7, int arg8)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/security/pkcs11/wrapper/CK_INFO;", "public synchronized")]
		public Dova.JDK.sun.security.pkcs11.wrapper.CK_INFO C_GetInfo()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_INFO>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "synchronized")]
		public void C_Initialize(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[BII[BII)I", "public synchronized")]
		public int C_DigestSingle(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, JavaArray<byte> arg2, int arg3, int arg4, JavaArray<byte> arg5, int arg6, int arg7)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			return ret;
		}

		[JniSignatureAttribute("(JJ[BII)V", "public synchronized")]
		public void C_DigestUpdate(long arg0, long arg1, JavaArray<byte> arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(J[BII)I", "public synchronized")]
		public int C_DigestFinal(long arg0, JavaArray<byte> arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;)V", "public synchronized")]
		public void C_DigestInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		}

		[JniSignatureAttribute("(JJ)V", "public synchronized")]
		public void C_DigestKey(long arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public synchronized")]
		public void C_Finalize(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		}

		[JniSignatureAttribute("(Z)[J", "public synchronized")]
		public JavaArray<long> C_GetSlotList(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}

		[JniSignatureAttribute("(J)[J", "public synchronized")]
		public JavaArray<long> C_GetMechanismList(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}

		[JniSignatureAttribute("(JJLjava/lang/Object;Lsun/security/pkcs11/wrapper/CK_NOTIFY;)J", "public synchronized")]
		public long C_OpenSession(long arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.sun.security.pkcs11.wrapper.CK_NOTIFY arg3)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(J)V", "public synchronized")]
		public void C_CloseSession(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		}

		[JniSignatureAttribute("(JJ[C)V", "public synchronized")]
		public void C_Login(long arg0, long arg1, JavaArray<char> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(J)V", "public synchronized")]
		public void C_Logout(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J)V", "public synchronized")]
		public void C_SignRecoverInit(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(J[BII[BII)I", "public synchronized")]
		public int C_SignRecover(long arg0, JavaArray<byte> arg1, int arg2, int arg3, JavaArray<byte> arg4, int arg5, int arg6)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return ret;
		}

		[JniSignatureAttribute("(J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public synchronized")]
		public long C_CreateObject(long arg0, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg1)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[J", "public synchronized")]
		public JavaArray<long> C_GenerateKeyPair(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}

		[JniSignatureAttribute("(JLsun/security/pkcs11/wrapper/CK_MECHANISM;J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public synchronized")]
		public long C_DeriveKey(long arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM arg1, long arg2, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg3)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V", "public synchronized")]
		public void C_SetAttributeValue(long arg0, long arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)J", "public synchronized")]
		public long C_CopyObject(long arg0, long arg1, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg2)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(J[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V", "public synchronized")]
		public void C_FindObjectsInit(long arg0, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		}

		[JniSignatureAttribute("(JJ)[J", "public synchronized")]
		public JavaArray<long> C_FindObjects(long arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}

		[JniSignatureAttribute("(J)V", "public synchronized")]
		public void C_FindObjectsFinal(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		}

		[JniSignatureAttribute("(JJ)V", "public synchronized")]
		public void C_SessionCancel(long arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		}
	}
}
