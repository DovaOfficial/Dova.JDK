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

namespace Dova.JDK.com.sun.crypto.provider;

[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher;", "abstract")]
public partial class ChaCha20Cipher
	: Dova.JDK.javax.crypto.CipherSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ChaCha20Cipher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/ChaCha20Cipher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODE_NONE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODE_AEAD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE_CONST_0", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE_CONST_1", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE_CONST_2", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE_CONST_3", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KEYSTREAM_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KS_SIZE_INTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CIPHERBUF_BASE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialized", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "direction", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aadDone", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyBytes", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nonce", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_UINT32", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finalCounterValue", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "counter", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startState", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyStream", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyStrOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TAG_LENGTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aadLen", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataLen", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "padBuf", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lenBuf", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authAlgName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authenticator", "Lcom/sun/crypto/provider/Poly1305;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "engine", "Lcom/sun/crypto/provider/ChaCha20Cipher$ChaChaEngine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "asIntLittleEndian", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "asLongLittleEndian", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "asLongView", "Ljava/lang/invoke/VarHandle;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(ILjava/security/Key;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "xor", "([BI[BI[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEncodedKey", "(Ljava/security/Key;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRandomNonce", "(Ljava/security/SecureRandom;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "authUpdate", "([BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkKeyAndNonce", "([B[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateKeystream", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "chaCha20Block", "([IJ[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "authPad16", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "authWriteLengths", "(JJ[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "chaCha20Transform", "([BII[BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initAuthenticator", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "authFinalizeData", "([BII[BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetBlockSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetOutputSize", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetIV", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetKeySize", "(Ljava/security/Key;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineWrap", "(Ljava/security/Key;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdateAAD", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdateAAD", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInitialState", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "([BII[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSetMode", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSetPadding", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineDoFinal", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineDoFinal", "([BII[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetParameters", "()Ljava/security/AlgorithmParameters;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MODE_NONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MODE_AEAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STATE_CONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STATE_CONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STATE_CONST_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STATE_CONST_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int KEYSTREAM_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int KS_SIZE_INTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CIPHERBUF_BASE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool initialized_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int mode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int direction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool aadDone_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> keyBytes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> nonce_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long MAX_UINT32_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long finalCounterValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long counter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("[I", "private final")]
	public JavaArray<int> startState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> keyStream_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int keyStrOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TAG_LENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long aadLen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long dataLen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> padBuf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> lenBuf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String authAlgName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/Poly1305;", "private")]
	public Dova.JDK.com.sun.crypto.provider.Poly1305 authenticator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.crypto.provider.Poly1305>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher$ChaChaEngine;", "private")]
	public Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher.ChaChaEngine engine_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher.ChaChaEngine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle asIntLittleEndian_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle asLongLittleEndian_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle asLongView_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ChaCha20Cipher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public ChaCha20Cipher() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/ChaCha20Cipher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILjava/security/Key;[B)V", "private")]
	public void init(int arg0, Dova.JDK.java.security.Key arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BI[BI[BII)V", "private static")]
	public static void xor(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, int arg3, JavaArray<byte> arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)[B", "private static")]
	public static JavaArray<byte> getEncodedKey(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/SecureRandom;)[B", "private static")]
	public static JavaArray<byte> createRandomNonce(Dova.JDK.java.security.SecureRandom arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BII)I", "private")]
	public int authUpdate(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([B[B)V", "private")]
	public void checkKeyAndNonce(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void generateKeystream()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("([IJ[B)V", "private static")]
	public static void chaCha20Block(JavaArray<int> arg0, long arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void authPad16(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(JJ[B)V", "private")]
	public void authWriteLengths(long arg0, long arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BII[BI)V", "private")]
	public void chaCha20Transform(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initAuthenticator()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("([BII[BI)V", "private")]
	public void authFinalizeData(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int engineGetBlockSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int engineGetOutputSize(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[B", "protected")]
	public JavaArray<byte> engineGetIV()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)I", "protected")]
	public int engineGetKeySize(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/Key;)[B", "protected")]
	public JavaArray<byte> engineWrap(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BLjava/lang/String;I)Ljava/security/Key;", "protected")]
	public Dova.JDK.java.security.Key engineUnwrap(JavaArray<byte> arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
	}

	[JniSignatureAttribute("([BII)V", "protected")]
	public void engineUpdateAAD(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "protected")]
	public void engineUpdateAAD(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void setInitialState()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("([BII[BI)I", "protected")]
	public int engineUpdate(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([BII)[B", "protected")]
	public JavaArray<byte> engineUpdate(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void engineSetMode(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void engineSetPadding(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.SecureRandom arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.AlgorithmParameters arg2, Dova.JDK.java.security.SecureRandom arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg2, Dova.JDK.java.security.SecureRandom arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([BII)[B", "protected")]
	public JavaArray<byte> engineDoFinal(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BII[BI)I", "protected")]
	public int engineDoFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/security/AlgorithmParameters;", "protected")]
	public Dova.JDK.java.security.AlgorithmParameters engineGetParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmParameters>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher$ChaChaEngine;", "abstract static interface")]
	public partial interface ChaChaEngine
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChaChaEngine()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/ChaCha20Cipher$ChaChaEngine;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doUpdate", "([BII[BI)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputSize", "(IZ)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFinal", "([BII[BI)I"));
		}

		[JniSignatureAttribute("([BII[BI)I", "public abstract")]
		int doUpdate(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(IZ)I", "public abstract")]
		int getOutputSize(int arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([BII[BI)I", "public abstract")]
		int doFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher$EngineStreamOnly;", "private final")]
	public partial class EngineStreamOnly
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher.ChaChaEngine
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EngineStreamOnly()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/ChaCha20Cipher$EngineStreamOnly;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/crypto/provider/ChaCha20Cipher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/crypto/provider/ChaCha20Cipher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doUpdate", "([BII[BI)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputSize", "(IZ)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFinal", "([BII[BI)I"));
		}

		[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher;", "final")]
		public Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EngineStreamOnly(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/crypto/provider/ChaCha20Cipher;)V", "private")]
		public EngineStreamOnly(Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/ChaCha20Cipher$EngineStreamOnly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII[BI)I", "public")]
		public int doUpdate(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(IZ)I", "public")]
		public int getOutputSize(int arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([BII[BI)I", "public")]
		public int doFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher$EngineAEADEnc;", "private final")]
	public partial class EngineAEADEnc
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher.ChaChaEngine
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EngineAEADEnc()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/ChaCha20Cipher$EngineAEADEnc;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/crypto/provider/ChaCha20Cipher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/crypto/provider/ChaCha20Cipher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doUpdate", "([BII[BI)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputSize", "(IZ)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFinal", "([BII[BI)I"));
		}

		[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher;", "final")]
		public Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EngineAEADEnc(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/crypto/provider/ChaCha20Cipher;)V", "private")]
		public EngineAEADEnc(Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/ChaCha20Cipher$EngineAEADEnc;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII[BI)I", "public")]
		public int doUpdate(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(IZ)I", "public")]
		public int getOutputSize(int arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([BII[BI)I", "public")]
		public int doFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher$EngineAEADDec;", "private final")]
	public partial class EngineAEADDec
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher.ChaChaEngine
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EngineAEADDec()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/ChaCha20Cipher$EngineAEADDec;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipherBuf", "Ljava/io/ByteArrayOutputStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/crypto/provider/ChaCha20Cipher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/crypto/provider/ChaCha20Cipher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doUpdate", "([BII[BI)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputSize", "(IZ)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFinal", "([BII[BI)I"));
		}

		[JniSignatureAttribute("Ljava/io/ByteArrayOutputStream;", "private final")]
		public Dova.JDK.java.io.ByteArrayOutputStream cipherBuf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ByteArrayOutputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher;", "final")]
		public Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EngineAEADDec(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/crypto/provider/ChaCha20Cipher;)V", "private")]
		public EngineAEADDec(Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/ChaCha20Cipher$EngineAEADDec;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII[BI)I", "public")]
		public int doUpdate(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(IZ)I", "public")]
		public int getOutputSize(int arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([BII[BI)I", "public")]
		public int doFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher$ChaCha20Poly1305;", "public static final")]
	public partial class ChaCha20Poly1305
		: Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChaCha20Poly1305()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/ChaCha20Cipher$ChaCha20Poly1305;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChaCha20Poly1305(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ChaCha20Poly1305() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/ChaCha20Cipher$ChaCha20Poly1305;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/ChaCha20Cipher$ChaCha20Only;", "public static final")]
	public partial class ChaCha20Only
		: Dova.JDK.com.sun.crypto.provider.ChaCha20Cipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChaCha20Only()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/ChaCha20Cipher$ChaCha20Only;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChaCha20Only(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ChaCha20Only() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/ChaCha20Cipher$ChaCha20Only;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
