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

namespace Dova.JDK.java.util;

[JniSignatureAttribute("Ljava/util/Base64;", "public")]
public partial class Base64
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Base64()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Base64;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUrlEncoder", "()Ljava/util/Base64$Encoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMimeEncoder", "(I[B)Ljava/util/Base64$Encoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMimeEncoder", "()Ljava/util/Base64$Encoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUrlDecoder", "()Ljava/util/Base64$Decoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMimeDecoder", "()Ljava/util/Base64$Decoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDecoder", "()Ljava/util/Base64$Decoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEncoder", "()Ljava/util/Base64$Encoder;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Base64(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Base64() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/Base64;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/Base64$Encoder;", "public static")]
	public static Dova.JDK.java.util.Base64.Encoder getUrlEncoder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Encoder>(ret);
	}

	[JniSignatureAttribute("(I[B)Ljava/util/Base64$Encoder;", "public static")]
	public static Dova.JDK.java.util.Base64.Encoder getMimeEncoder(int arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Encoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Base64$Encoder;", "public static")]
	public static Dova.JDK.java.util.Base64.Encoder getMimeEncoder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Encoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Base64$Decoder;", "public static")]
	public static Dova.JDK.java.util.Base64.Decoder getUrlDecoder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Decoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Base64$Decoder;", "public static")]
	public static Dova.JDK.java.util.Base64.Decoder getMimeDecoder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Decoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Base64$Decoder;", "public static")]
	public static Dova.JDK.java.util.Base64.Decoder getDecoder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Decoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Base64$Encoder;", "public static")]
	public static Dova.JDK.java.util.Base64.Encoder getEncoder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Encoder>(ret);
	}

	[JniSignatureAttribute("Ljava/util/Base64$Encoder;", "public static")]
	public partial class Encoder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Encoder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Base64$Encoder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newline", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linemax", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isURL", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doPadding", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "toBase64", "[C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "toBase64URL", "[C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIMELINEMAX", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CRLF", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFC4648", "Ljava/util/Base64$Encoder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFC4648_URLSAFE", "Ljava/util/Base64$Encoder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFC2045", "Ljava/util/Base64$Encoder;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z[BIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeBlock", "([BII[BIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "([B)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "([B[B)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodedOutLength", "(IZ)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode0", "([BII[B)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutPadding", "()Ljava/util/Base64$Encoder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeToString", "([B)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> newline_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int linemax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isURL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool doPadding_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("[C", "private static final")]
		public static JavaArray<char> toBase64_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[C", "private static final")]
		public static JavaArray<char> toBase64URL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int MIMELINEMAX_Property
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

		[JniSignatureAttribute("[B", "private static final")]
		public static JavaArray<byte> CRLF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Base64$Encoder;", "static final")]
		public static Dova.JDK.java.util.Base64.Encoder RFC4648_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Encoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Base64$Encoder;", "static final")]
		public static Dova.JDK.java.util.Base64.Encoder RFC4648_URLSAFE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Encoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Base64$Encoder;", "static final")]
		public static Dova.JDK.java.util.Base64.Encoder RFC2045_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Encoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Encoder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Z[BIZ)V", "private")]
		public Encoder(bool arg0, JavaArray<byte> arg1, int arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Base64$Encoder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII[BIZ)V", "private")]
		public void encodeBlock(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, bool arg5)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		}

		[JniSignatureAttribute("(Ljava/io/OutputStream;)Ljava/io/OutputStream;", "public")]
		public Dova.JDK.java.io.OutputStream wrap(Dova.JDK.java.io.OutputStream arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "public")]
		public Dova.JDK.java.nio.ByteBuffer encode(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}

		[JniSignatureAttribute("([B)[B", "public")]
		public JavaArray<byte> encode(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([B[B)I", "public")]
		public int encode(JavaArray<byte> arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(IZ)I", "private final")]
		public int encodedOutLength(int arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([BII[B)I", "private")]
		public int encode0(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Base64$Encoder;", "public")]
		public Dova.JDK.java.util.Base64.Encoder withoutPadding()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Encoder>(ret);
		}

		[JniSignatureAttribute("([B)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String encodeToString(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/Base64$Decoder;", "public static")]
	public partial class Decoder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Decoder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Base64$Decoder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isURL", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isMIME", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fromBase64", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fromBase64URL", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFC4648", "Ljava/util/Base64$Decoder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFC4648_URLSAFE", "Ljava/util/Base64$Decoder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFC2045", "Ljava/util/Base64$Decoder;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeBlock", "([BII[BIZZ)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "(Ljava/lang/String;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "([B)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "([B[B)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljava/io/InputStream;)Ljava/io/InputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodedOutLength", "([BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode0", "([BII[B)I"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isURL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isMIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("[I", "private static final")]
		public static JavaArray<int> fromBase64_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "private static final")]
		public static JavaArray<int> fromBase64URL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Base64$Decoder;", "static final")]
		public static Dova.JDK.java.util.Base64.Decoder RFC4648_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Decoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Base64$Decoder;", "static final")]
		public static Dova.JDK.java.util.Base64.Decoder RFC4648_URLSAFE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Decoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Base64$Decoder;", "static final")]
		public static Dova.JDK.java.util.Base64.Decoder RFC2045_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Base64.Decoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Decoder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZZ)V", "private")]
		public Decoder(bool arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Base64$Decoder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII[BIZZ)I", "private")]
		public int decodeBlock(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, bool arg5, bool arg6)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)[B", "public")]
		public JavaArray<byte> decode(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([B)[B", "public")]
		public JavaArray<byte> decode(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "public")]
		public Dova.JDK.java.nio.ByteBuffer decode(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}

		[JniSignatureAttribute("([B[B)I", "public")]
		public int decode(JavaArray<byte> arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;)Ljava/io/InputStream;", "public")]
		public Dova.JDK.java.io.InputStream wrap(Dova.JDK.java.io.InputStream arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}

		[JniSignatureAttribute("([BII)I", "private")]
		public int decodedOutLength(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("([BII[B)I", "private")]
		public int decode0(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/Base64$DecInputStream;", "private static")]
	public partial class DecInputStream
		: Dova.JDK.java.io.InputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DecInputStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Base64$DecInputStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "is", "Ljava/io/InputStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isMIME", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "base64", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bits", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wpos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rpos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eof", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sbBuf", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;[IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "available", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eof", "([BIII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leftovers", "([BIII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "padding", "([BIII)I"));
		}

		[JniSignatureAttribute("Ljava/io/InputStream;", "private final")]
		public Dova.JDK.java.io.InputStream @is_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isMIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("[I", "private final")]
		public JavaArray<int> base64_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int bits_Property
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

		[JniSignatureAttribute("I", "private")]
		public int wpos_Property
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

		[JniSignatureAttribute("I", "private")]
		public int rpos_Property
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

		[JniSignatureAttribute("Z", "private")]
		public bool eof_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool closed_Property
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

		[JniSignatureAttribute("[B", "private")]
		public JavaArray<byte> sbBuf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DecInputStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;[IZ)V", "")]
		public DecInputStream(Dova.JDK.java.io.InputStream arg0, JavaArray<int> arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Base64$DecInputStream;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII)I", "public")]
		public int read(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int read()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int available()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("([BIII)I", "private")]
		public int eof(JavaArray<byte> arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("([BIII)I", "private")]
		public int leftovers(JavaArray<byte> arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("([BIII)I", "private")]
		public int padding(JavaArray<byte> arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/Base64$EncOutputStream;", "private static")]
	public partial class EncOutputStream
		: Dova.JDK.java.io.FilterOutputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EncOutputStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Base64$EncOutputStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leftover", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "b0", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "b1", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "b2", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "base64", "[C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newline", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linemax", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doPadding", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linepos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buf", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/OutputStream;[C[BIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "([BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkNewline", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeb4", "(CCCC)V"));
		}

		[JniSignatureAttribute("I", "private")]
		public int leftover_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int b0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int b1_Property
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

		[JniSignatureAttribute("I", "private")]
		public int b2_Property
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

		[JniSignatureAttribute("Z", "private")]
		public bool closed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("[C", "private final")]
		public JavaArray<char> base64_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> newline_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int linemax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool doPadding_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int linepos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("[B", "private")]
		public JavaArray<byte> buf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EncOutputStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/OutputStream;[C[BIZ)V", "")]
		public EncOutputStream(Dova.JDK.java.io.OutputStream arg0, JavaArray<char> arg1, JavaArray<byte> arg2, int arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Base64$EncOutputStream;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII)V", "public")]
		public void write(JavaArray<byte> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void write(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkNewline()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(CCCC)V", "private")]
		public void writeb4(char arg0, char arg1, char arg2, char arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		}
	}
}
