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

namespace Dova.JDK.sun.nio.cs.ext;

[JniSignatureAttribute("Lsun/nio/cs/ext/ISO2022;", "abstract")]
public partial class ISO2022
	: Dova.JDK.java.nio.charset.Charset
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ISO2022()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/cs/ext/ISO2022;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ISO2022(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)V", "public")]
	public ISO2022(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/cs/ext/ISO2022;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/nio/charset/CharsetDecoder;", "public abstract")]
	public Dova.JDK.java.nio.charset.CharsetDecoder newDecoder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetDecoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/charset/CharsetEncoder;", "public abstract")]
	public Dova.JDK.java.nio.charset.CharsetEncoder newEncoder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetEncoder>(ret);
	}

	[JniSignatureAttribute("Lsun/nio/cs/ext/ISO2022$Encoder;", "protected static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/cs/ext/ISO2022$Encoder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_ESC", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_SI", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_SO", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_SS2_7", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_SS3_7", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sgp", "Lsun/nio/cs/Surrogate$Parser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SS2", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLANE2", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLANE3", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maximumDesignatorLength", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "SODesig", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "SS2Desig", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "SS3Desig", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ISOEncoder", "Ljava/nio/charset/CharsetEncoder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shiftout", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "SODesDefined", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "SS2DesDefined", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "SS3DesDefined", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newshiftout", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newSODesDefined", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newSS2DesDefined", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newSS3DesDefined", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canEncode", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeArrayLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeBufferLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implReset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unicodeToNative", "(C[B)I"));
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte ISO_ESC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte ISO_SI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte ISO_SO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte ISO_SS2_7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte ISO_SS3_7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Lsun/nio/cs/Surrogate$Parser;", "private final")]
		public Dova.JDK.sun.nio.cs.Surrogate.Parser sgp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.cs.Surrogate.Parser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte SS2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte PLANE2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte PLANE3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("B", "protected final")]
		public byte maximumDesignatorLength_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("[B", "protected")]
		public JavaArray<byte> SODesig_Property
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

		[JniSignatureAttribute("[B", "protected")]
		public JavaArray<byte> SS2Desig_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "protected")]
		public JavaArray<byte> SS3Desig_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/charset/CharsetEncoder;", "protected")]
		public Dova.JDK.java.nio.charset.CharsetEncoder ISOEncoder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetEncoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool shiftout_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool SODesDefined_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool SS2DesDefined_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool SS3DesDefined_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool newshiftout_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool newSODesDefined_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool newSS2DesDefined_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool newSS3DesDefined_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Encoder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/charset/Charset;)V", "protected")]
		public Encoder(Dova.JDK.java.nio.charset.Charset arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/cs/ext/ISO2022$Encoder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(C)Z", "public")]
		public bool canEncode(char arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "private")]
		public Dova.JDK.java.nio.charset.CoderResult encodeArrayLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "private")]
		public Dova.JDK.java.nio.charset.CoderResult encodeBufferLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "protected")]
		public Dova.JDK.java.nio.charset.CoderResult encodeLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void implReset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(C[B)I", "private")]
		public int unicodeToNative(char arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}
	}
}
