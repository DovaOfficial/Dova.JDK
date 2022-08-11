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

namespace Dova.JDK.com.sun.media.sound;

[JniSignatureAttribute("Lcom/sun/media/sound/PCMtoPCMCodec;", "public final")]
public partial class PCMtoPCMCodec
	: Dova.JDK.javax.sound.sampled.spi.FormatConversionProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PCMtoPCMCodec()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/PCMtoPCMCodec;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioInputStream", "(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioInputStream", "(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetEncodings", "(Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat$Encoding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetEncodings", "()[Ljavax/sound/sampled/AudioFormat$Encoding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetFormats", "(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceEncodings", "()[Ljavax/sound/sampled/AudioFormat$Encoding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputFormats", "(Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConvertedStream", "(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PCMtoPCMCodec(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PCMtoPCMCodec() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/PCMtoPCMCodec;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;", "public")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;", "public")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat$Encoding;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> getTargetEncodings(Dova.JDK.javax.sound.sampled.AudioFormat arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/AudioFormat$Encoding;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> getTargetEncodings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat> getTargetFormats(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/AudioFormat$Encoding;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> getSourceEncodings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat;", "private")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat> getOutputFormats(Dova.JDK.javax.sound.sampled.AudioFormat arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;", "private")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getConvertedStream(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/PCMtoPCMCodec$PCMtoPCMCodecStream;", "")]
	public partial class PCMtoPCMCodecStream
		: Dova.JDK.javax.sound.sampled.AudioInputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PCMtoPCMCodecStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/PCMtoPCMCodec$PCMtoPCMCodecStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "PCM_SWITCH_SIGNED_8BIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "PCM_SWITCH_ENDIAN", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "PCM_SWITCH_SIGNED_LE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "PCM_SWITCH_SIGNED_BE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "PCM_UNSIGNED_LE2SIGNED_BE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "PCM_SIGNED_LE2UNSIGNED_BE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "PCM_UNSIGNED_BE2SIGNED_LE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "PCM_SIGNED_BE2UNSIGNED_LE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sampleSizeInBytes", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "conversionType", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/PCMtoPCMCodec;Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFormat;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([B)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "switchSigned8bit", "([BIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "switchEndian", "([BIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "switchSignedLE", "([BIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "switchSignedBE", "([BIII)V"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int PCM_SWITCH_SIGNED_8BIT_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int PCM_SWITCH_ENDIAN_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int PCM_SWITCH_SIGNED_LE_Property
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
		public int PCM_SWITCH_SIGNED_BE_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int PCM_UNSIGNED_LE2SIGNED_BE_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int PCM_SIGNED_LE2UNSIGNED_BE_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int PCM_UNSIGNED_BE2SIGNED_LE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int PCM_SIGNED_BE2UNSIGNED_LE_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int sampleSizeInBytes_Property
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

		[JniSignatureAttribute("I", "private")]
		public int conversionType_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PCMtoPCMCodecStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/PCMtoPCMCodec;Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFormat;)V", "")]
		public PCMtoPCMCodecStream(Dova.JDK.com.sun.media.sound.PCMtoPCMCodec arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1, Dova.JDK.javax.sound.sampled.AudioFormat arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/PCMtoPCMCodec$PCMtoPCMCodecStream;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII)I", "public")]
		public int read(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("([B)I", "public")]
		public int read(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int read()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("([BIII)V", "private")]
		public void switchSigned8bit(JavaArray<byte> arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("([BIII)V", "private")]
		public void switchEndian(JavaArray<byte> arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("([BIII)V", "private")]
		public void switchSignedLE(JavaArray<byte> arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("([BIII)V", "private")]
		public void switchSignedBE(JavaArray<byte> arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		}
	}
}
