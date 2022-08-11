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

[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher;", "abstract")]
public partial class KeyWrapCipher
	: Dova.JDK.javax.crypto.CipherSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyWrapCipher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipher", "Lcom/sun/crypto/provider/FeedbackCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "padding", "Lcom/sun/crypto/provider/Padding;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opmode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fixedKeySize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataBuf", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataIdx", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/crypto/provider/FeedbackCipher;Lcom/sun/crypto/provider/Padding;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implInit", "(ILjava/security/Key;[BLjava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetBlockSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetOutputSize", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetIV", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetKeySize", "(Ljava/security/Key;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineWrap", "(Ljava/security/Key;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "([BII[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSetMode", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSetPadding", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implUpdate", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implDoFinal", "([BII[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helperEncrypt", "([BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helperDecrypt", "([BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineDoFinal", "([BII[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineDoFinal", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetParameters", "()Ljava/security/AlgorithmParameters;"));
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/FeedbackCipher;", "private final")]
	public Dova.JDK.com.sun.crypto.provider.FeedbackCipher cipher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.crypto.provider.FeedbackCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/Padding;", "private final")]
	public Dova.JDK.com.sun.crypto.provider.Padding padding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.crypto.provider.Padding>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int opmode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int fixedKeySize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> dataBuf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int dataIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyWrapCipher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/crypto/provider/FeedbackCipher;Lcom/sun/crypto/provider/Padding;I)V", "public")]
	public KeyWrapCipher(Dova.JDK.com.sun.crypto.provider.FeedbackCipher arg0, Dova.JDK.com.sun.crypto.provider.Padding arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BII)V", "private")]
	public void store(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/security/Key;[BLjava/security/SecureRandom;)V", "private")]
	public void implInit(int arg0, Dova.JDK.java.security.Key arg1, JavaArray<byte> arg2, Dova.JDK.java.security.SecureRandom arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int engineGetBlockSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int engineGetOutputSize(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[B", "protected")]
	public JavaArray<byte> engineGetIV()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)I", "protected")]
	public int engineGetKeySize(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/Key;)[B", "protected")]
	public JavaArray<byte> engineWrap(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BLjava/lang/String;I)Ljava/security/Key;", "protected")]
	public Dova.JDK.java.security.Key engineUnwrap(JavaArray<byte> arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
	}

	[JniSignatureAttribute("([BII[BI)I", "protected")]
	public int engineUpdate(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([BII)[B", "protected")]
	public JavaArray<byte> engineUpdate(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void engineSetMode(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void engineSetPadding(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("([BII)V", "private")]
	public void implUpdate(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BII[B)I", "private")]
	public int implDoFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([BI)I", "private")]
	public int helperEncrypt(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BI)I", "private")]
	public int helperDecrypt(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.SecureRandom arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg2, Dova.JDK.java.security.SecureRandom arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInit(int arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.security.AlgorithmParameters arg2, Dova.JDK.java.security.SecureRandom arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([BII[BI)I", "protected")]
	public int engineDoFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([BII)[B", "protected")]
	public JavaArray<byte> engineDoFinal(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/AlgorithmParameters;", "protected")]
	public Dova.JDK.java.security.AlgorithmParameters engineGetParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmParameters>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KWP_NoPadding;", "public static final")]
	public partial class AES256_KWP_NoPadding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES256_KWP_NoPadding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KWP_NoPadding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES256_KWP_NoPadding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES256_KWP_NoPadding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KWP_NoPadding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KWP_NoPadding;", "public static final")]
	public partial class AES192_KWP_NoPadding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES192_KWP_NoPadding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KWP_NoPadding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES192_KWP_NoPadding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES192_KWP_NoPadding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KWP_NoPadding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KWP_NoPadding;", "public static final")]
	public partial class AES128_KWP_NoPadding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES128_KWP_NoPadding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KWP_NoPadding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES128_KWP_NoPadding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES128_KWP_NoPadding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KWP_NoPadding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES_KWP_NoPadding;", "public static final")]
	public partial class AES_KWP_NoPadding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES_KWP_NoPadding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES_KWP_NoPadding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES_KWP_NoPadding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES_KWP_NoPadding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES_KWP_NoPadding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KW_PKCS5Padding;", "public static final")]
	public partial class AES256_KW_PKCS5Padding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES256_KW_PKCS5Padding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KW_PKCS5Padding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES256_KW_PKCS5Padding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES256_KW_PKCS5Padding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KW_PKCS5Padding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KW_PKCS5Padding;", "public static final")]
	public partial class AES192_KW_PKCS5Padding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES192_KW_PKCS5Padding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KW_PKCS5Padding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES192_KW_PKCS5Padding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES192_KW_PKCS5Padding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KW_PKCS5Padding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KW_PKCS5Padding;", "public static final")]
	public partial class AES128_KW_PKCS5Padding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES128_KW_PKCS5Padding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KW_PKCS5Padding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES128_KW_PKCS5Padding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES128_KW_PKCS5Padding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KW_PKCS5Padding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES_KW_PKCS5Padding;", "public static final")]
	public partial class AES_KW_PKCS5Padding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES_KW_PKCS5Padding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES_KW_PKCS5Padding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES_KW_PKCS5Padding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES_KW_PKCS5Padding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES_KW_PKCS5Padding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KW_NoPadding;", "public static final")]
	public partial class AES256_KW_NoPadding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES256_KW_NoPadding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KW_NoPadding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES256_KW_NoPadding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES256_KW_NoPadding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES256_KW_NoPadding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KW_NoPadding;", "public static final")]
	public partial class AES192_KW_NoPadding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES192_KW_NoPadding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KW_NoPadding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES192_KW_NoPadding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES192_KW_NoPadding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES192_KW_NoPadding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KW_NoPadding;", "public static final")]
	public partial class AES128_KW_NoPadding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES128_KW_NoPadding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KW_NoPadding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES128_KW_NoPadding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES128_KW_NoPadding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES128_KW_NoPadding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/KeyWrapCipher$AES_KW_NoPadding;", "public static final")]
	public partial class AES_KW_NoPadding
		: Dova.JDK.com.sun.crypto.provider.KeyWrapCipher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AES_KW_NoPadding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/KeyWrapCipher$AES_KW_NoPadding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AES_KW_NoPadding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AES_KW_NoPadding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/KeyWrapCipher$AES_KW_NoPadding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
