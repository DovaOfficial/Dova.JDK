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

namespace Dova.JDK.sun.nio.cs;

[JniSignatureAttribute("Lsun/nio/cs/UTF_8;", "public final")]
public partial class UTF_8
	: Dova.JDK.sun.nio.cs.Unicode
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UTF_8()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/cs/UTF_8;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lsun/nio/cs/UTF_8;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JLA", "Ljdk/internal/access/JavaLangAccess;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/charset/Charset;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "historicalName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "updatePositions", "(Ljava/nio/Buffer;ILjava/nio/Buffer;I)V"));
	}

	[JniSignatureAttribute("Lsun/nio/cs/UTF_8;", "public static final")]
	public static Dova.JDK.sun.nio.cs.UTF_8 INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.cs.UTF_8>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangAccess;", "private static final")]
	public static Dova.JDK.jdk.@internal.access.JavaLangAccess JLA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UTF_8(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public UTF_8() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/cs/UTF_8;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/nio/charset/CharsetDecoder;", "public")]
	public Dova.JDK.java.nio.charset.CharsetDecoder newDecoder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetDecoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/charset/CharsetEncoder;", "public")]
	public Dova.JDK.java.nio.charset.CharsetEncoder newEncoder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetEncoder>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;)Z", "public volatile")]
	public bool contains(Dova.JDK.java.nio.charset.Charset arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String historicalName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/Buffer;ILjava/nio/Buffer;I)V", "static final")]
	public static void updatePositions(Dova.JDK.java.nio.Buffer arg0, int arg1, Dova.JDK.java.nio.Buffer arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("Lsun/nio/cs/UTF_8$Decoder;", "private static")]
	public partial class Decoder
		: Dova.JDK.java.nio.charset.CharsetDecoder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Decoder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/cs/UTF_8$Decoder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isNotContinuation", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed3", "(III)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed3_2", "(II)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed4", "(III)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed4_2", "(II)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed4_3", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malformedForLength", "(Ljava/nio/ByteBuffer;ILjava/nio/CharBuffer;II)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malformedForLength", "(Ljava/nio/ByteBuffer;II)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malformed", "(Ljava/nio/ByteBuffer;II)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malformed", "(Ljava/nio/ByteBuffer;ILjava/nio/CharBuffer;II)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malformedN", "(Ljava/nio/ByteBuffer;I)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "xflow", "(Ljava/nio/Buffer;IILjava/nio/Buffer;II)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "xflow", "(Ljava/nio/Buffer;II)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeArrayLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeBufferLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;"));
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Decoder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/charset/Charset;)V", "private")]
		public Decoder(Dova.JDK.java.nio.charset.Charset arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/cs/UTF_8$Decoder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Z", "private static")]
		public static bool isNotContinuation(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(III)Z", "private static")]
		public static bool isMalformed3(int arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(II)Z", "private static")]
		public static bool isMalformed3_2(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(III)Z", "private static")]
		public static bool isMalformed4(int arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(II)Z", "private static")]
		public static bool isMalformed4_2(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(I)Z", "private static")]
		public static bool isMalformed4_3(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;ILjava/nio/CharBuffer;II)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult malformedForLength(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, Dova.JDK.java.nio.CharBuffer arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;II)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult malformedForLength(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;II)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult malformed(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;ILjava/nio/CharBuffer;II)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult malformed(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, Dova.JDK.java.nio.CharBuffer arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", "protected")]
		public Dova.JDK.java.nio.charset.CoderResult decodeLoop(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.CharBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;I)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult malformedN(Dova.JDK.java.nio.ByteBuffer arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/Buffer;IILjava/nio/Buffer;II)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult xflow(Dova.JDK.java.nio.Buffer arg0, int arg1, int arg2, Dova.JDK.java.nio.Buffer arg3, int arg4, int arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/Buffer;II)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult xflow(Dova.JDK.java.nio.Buffer arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", "private")]
		public Dova.JDK.java.nio.charset.CoderResult decodeArrayLoop(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.CharBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", "private")]
		public Dova.JDK.java.nio.charset.CoderResult decodeBufferLoop(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.CharBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/nio/cs/UTF_8$Encoder;", "private static final")]
	public partial class Encoder
		: Dova.JDK.java.nio.charset.CharsetEncoder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Encoder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/cs/UTF_8$Encoder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sgp", "Lsun/nio/cs/Surrogate$Parser;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canEncode", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLegalReplacement", "([B)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeArrayLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeBufferLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeArrayLoopSlow", "(Ljava/nio/CharBuffer;[CIILjava/nio/ByteBuffer;[BII)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "overflow", "(Ljava/nio/CharBuffer;I)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "overflow", "(Ljava/nio/CharBuffer;ILjava/nio/ByteBuffer;I)Ljava/nio/charset/CoderResult;"));
		}

		[JniSignatureAttribute("Lsun/nio/cs/Surrogate$Parser;", "private")]
		public Dova.JDK.sun.nio.cs.Surrogate.Parser sgp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.cs.Surrogate.Parser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Encoder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/charset/Charset;)V", "private")]
		public Encoder(Dova.JDK.java.nio.charset.Charset arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/cs/UTF_8$Encoder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(C)Z", "public")]
		public bool canEncode(char arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("([B)Z", "public")]
		public bool isLegalReplacement(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "private")]
		public Dova.JDK.java.nio.charset.CoderResult encodeArrayLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "private")]
		public Dova.JDK.java.nio.charset.CoderResult encodeBufferLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "protected final")]
		public Dova.JDK.java.nio.charset.CoderResult encodeLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;[CIILjava/nio/ByteBuffer;[BII)Ljava/nio/charset/CoderResult;", "private")]
		public Dova.JDK.java.nio.charset.CoderResult encodeArrayLoopSlow(Dova.JDK.java.nio.CharBuffer arg0, JavaArray<char> arg1, int arg2, int arg3, Dova.JDK.java.nio.ByteBuffer arg4, JavaArray<byte> arg5, int arg6, int arg7)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;I)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult overflow(Dova.JDK.java.nio.CharBuffer arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;ILjava/nio/ByteBuffer;I)Ljava/nio/charset/CoderResult;", "private static")]
		public static Dova.JDK.java.nio.charset.CoderResult overflow(Dova.JDK.java.nio.CharBuffer arg0, int arg1, Dova.JDK.java.nio.ByteBuffer arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}
	}
}
