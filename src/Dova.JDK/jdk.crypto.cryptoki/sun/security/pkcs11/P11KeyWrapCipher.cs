/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.pkcs11;

[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyWrapCipher;", "final")]
public partial class P11KeyWrapCipher
	: Dova.JDK.javax.crypto.CipherSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static P11KeyWrapCipher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/P11KeyWrapCipher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lsun/security/pkcs11/Token;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mechanism", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fixedKeySize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "session", "Lsun/security/pkcs11/Session;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "p11Key", "Lsun/security/pkcs11/P11Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialized", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opmode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iv", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "random", "Ljava/security/SecureRandom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataBuffer", "Ljava/io/ByteArrayOutputStream;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/Token;Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureInitialized", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleEncException", "(Ljava/lang/String;Lsun/security/pkcs11/wrapper/PKCS11Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSetMode", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSetPadding", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFinalLength", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implInit", "(ILjava/security/Key;[BLjava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelOperation", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implUpdate", "(Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implUpdate", "([BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineDoFinal", "([BII[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineDoFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineDoFinal", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implDoFinal", "([BII[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implDoFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetBlockSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetOutputSize", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetIV", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetParameters", "()Ljava/security/AlgorithmParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "([BII[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineWrap", "(Ljava/security/Key;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetKeySize", "(Ljava/security/Key;)I"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int BLK_SIZE_Property
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

	[JniSignatureAttribute("Lsun/security/pkcs11/Token;", "private final")]
	public Dova.JDK.sun.security.pkcs11.Token token_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Token>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private final")]
	public long mechanism_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "private final")]
	public Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int fixedKeySize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/Session;", "private")]
	public Dova.JDK.sun.security.pkcs11.Session session_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11Key;", "private")]
	public Dova.JDK.sun.security.pkcs11.P11Key p11Key_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool initialized_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int opmode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> iv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/SecureRandom;", "private")]
	public Dova.JDK.java.security.SecureRandom random_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/ByteArrayOutputStream;", "private")]
	public Dova.JDK.java.io.ByteArrayOutputStream dataBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.ByteArrayOutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public P11KeyWrapCipher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;Ljava/lang/String;J)V", "")]
	public P11KeyWrapCipher(Dova.JDK.sun.security.pkcs11.Token arg0, Dova.JDK.java.lang.String arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/P11KeyWrapCipher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "private")]
	public void initialize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureInitialized()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void reset(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/pkcs11/wrapper/PKCS11Exception;)V", "private")]
	public void handleEncException(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void engineSetMode(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void engineSetPadding(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int doFinalLength(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/security/Key;[BLjava/security/SecureRandom;)V", "private")]
	public void implInit(int arg0, Dova.JDK.java.security.Key arg1, JavaArray<byte> arg2, Dova.JDK.java.security.SecureRandom arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.AlgorithmParameters arg2, Dova.JDK.java.security.SecureRandom arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg2, Dova.JDK.java.security.SecureRandom arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.SecureRandom arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "private")]
	public void cancelOperation()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)I", "private")]
	public int implUpdate(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("([BII)I", "private")]
	public int implUpdate(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([BII[BI)I", "protected")]
	public int engineDoFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", "protected")]
	public int engineDoFinal(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BII)[B", "protected")]
	public JavaArray<byte> engineDoFinal(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BII[BII)I", "private")]
	public int implDoFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", "private")]
	public int implDoFinal(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int engineGetBlockSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int engineGetOutputSize(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[B", "protected")]
	public JavaArray<byte> engineGetIV()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/AlgorithmParameters;", "protected")]
	public Dova.JDK.java.security.AlgorithmParameters engineGetParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmParameters>(ret);
	}

	[JniSignatureAttribute("([BII)[B", "protected")]
	public JavaArray<byte> engineUpdate(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BII[BI)I", "protected")]
	public int engineUpdate(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", "protected")]
	public int engineUpdate(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/Key;)[B", "protected")]
	public JavaArray<byte> engineWrap(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BLjava/lang/String;I)Ljava/security/Key;", "protected")]
	public Dova.JDK.java.security.Key engineUnwrap(JavaArray<byte> arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)I", "protected")]
	public int engineGetKeySize(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "private static final")]
	public partial class KeyWrapType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyWrapType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KW_NOPADDING", "Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KW_PKCS5PADDING", "Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KWP_NOPADDING", "Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mode", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "padding", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defIv", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;"));
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType KW_NOPADDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType KW_PKCS5PADDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType KWP_NOPADDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String mode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String padding_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> defIv_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyWrapType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "private")]
		public KeyWrapType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "public static")]
		public static Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/pkcs11/P11KeyWrapCipher$KeyWrapType;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.P11KeyWrapCipher.KeyWrapType>>(ret);
		}
	}
}
