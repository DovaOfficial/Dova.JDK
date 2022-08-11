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

[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatFormatConverter;", "public final")]
public partial class AudioFloatFormatConverter
	: Dova.JDK.javax.sound.sampled.spi.FormatConversionProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AudioFloatFormatConverter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatFormatConverter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "formats", "[Ljavax/sound/sampled/AudioFormat$Encoding;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioInputStream", "(Ljavax/sound/sampled/AudioFormat;Lcom/sun/media/sound/AudioFloatInputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioInputStream", "(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioInputStream", "(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetEncodings", "(Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat$Encoding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetEncodings", "()[Ljavax/sound/sampled/AudioFormat$Encoding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConversionSupported", "(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConversionSupported", "(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioFormat;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetFormats", "(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceEncodings", "()[Ljavax/sound/sampled/AudioFormat$Encoding;"));
	}

	[JniSignatureAttribute("[Ljavax/sound/sampled/AudioFormat$Encoding;", "private final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> formats_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AudioFloatFormatConverter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AudioFloatFormatConverter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatFormatConverter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Lcom/sun/media/sound/AudioFloatInputStream;)Ljavax/sound/sampled/AudioInputStream;", "public")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.com.sun.media.sound.AudioFloatInputStream arg1)
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

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;", "public")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat$Encoding;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> getTargetEncodings(Dova.JDK.javax.sound.sampled.AudioFormat arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/AudioFormat$Encoding;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> getTargetEncodings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)Z", "public")]
	public bool isConversionSupported(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioFormat;)Z", "public")]
	public bool isConversionSupported(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat> getTargetFormats(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/AudioFormat$Encoding;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> getSourceEncodings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatInputStreamChannelMixer;", "private static")]
	public partial class AudioFloatInputStreamChannelMixer
		: Dova.JDK.com.sun.media.sound.AudioFloatInputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatInputStreamChannelMixer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatInputStreamChannelMixer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetChannels", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceChannels", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ais", "Lcom/sun/media/sound/AudioFloatInputStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetFormat", "Ljavax/sound/sampled/AudioFormat;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "conversion_buffer", "[F"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/AudioFloatInputStream;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([FII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "available", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markSupported", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFormat", "()Ljavax/sound/sampled/AudioFormat;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameLength", "()J"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int targetChannels_Property
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
		public int sourceChannels_Property
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

		[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatInputStream;", "private final")]
		public Dova.JDK.com.sun.media.sound.AudioFloatInputStream ais_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AudioFloatInputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/sound/sampled/AudioFormat;", "private final")]
		public Dova.JDK.javax.sound.sampled.AudioFormat targetFormat_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[F", "private")]
		public JavaArray<float> conversion_buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatInputStreamChannelMixer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/AudioFloatInputStream;I)V", "")]
		public AudioFloatInputStreamChannelMixer(Dova.JDK.com.sun.media.sound.AudioFloatInputStream arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatInputStreamChannelMixer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII)I", "public")]
		public int read(JavaArray<float> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void mark(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(J)J", "public")]
		public long skip(long arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int available()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool markSupported()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()Ljavax/sound/sampled/AudioFormat;", "public")]
		public Dova.JDK.javax.sound.sampled.AudioFormat getFormat()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long getFrameLength()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatInputStreamResampler;", "private static")]
	public partial class AudioFloatInputStreamResampler
		: Dova.JDK.com.sun.media.sound.AudioFloatInputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatInputStreamResampler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatInputStreamResampler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ais", "Lcom/sun/media/sound/AudioFloatInputStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetFormat", "Ljavax/sound/sampled/AudioFormat;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "skipbuffer", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resampler", "Lcom/sun/media/sound/SoftAbstractResampler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pitch", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ibuffer2", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ibuffer", "[[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ibuffer_index", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ibuffer_len", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nrofchannels", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbuffer", "[[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer_len", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pad", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pad2", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ix", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ox", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mark_ibuffer", "[[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mark_ibuffer_index", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mark_ibuffer_len", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/AudioFloatInputStream;Ljavax/sound/sampled/AudioFormat;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([FII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "available", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markSupported", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFormat", "()Ljavax/sound/sampled/AudioFormat;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readNextBuffer", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameLength", "()J"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatInputStream;", "private final")]
		public Dova.JDK.com.sun.media.sound.AudioFloatInputStream ais_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AudioFloatInputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/sound/sampled/AudioFormat;", "private final")]
		public Dova.JDK.javax.sound.sampled.AudioFormat targetFormat_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[F", "private")]
		public JavaArray<float> skipbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftAbstractResampler;", "private")]
		public Dova.JDK.com.sun.media.sound.SoftAbstractResampler resampler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftAbstractResampler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[F", "private final")]
		public JavaArray<float> pitch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[F", "private final")]
		public JavaArray<float> ibuffer2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[[F", "private final")]
		public JavaArray<JavaArray<float>> ibuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<float>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float ibuffer_index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int ibuffer_len_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int nrofchannels_Property
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

		[JniSignatureAttribute("[[F", "private")]
		public JavaArray<JavaArray<float>> cbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<float>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int buffer_len_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int pad_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int pad2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("[F", "private final")]
		public JavaArray<float> ix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "private final")]
		public JavaArray<int> ox_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[[F", "private")]
		public JavaArray<JavaArray<float>> mark_ibuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<float>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float mark_ibuffer_index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int mark_ibuffer_len_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatInputStreamResampler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/AudioFloatInputStream;Ljavax/sound/sampled/AudioFormat;)V", "")]
		public AudioFloatInputStreamResampler(Dova.JDK.com.sun.media.sound.AudioFloatInputStream arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatInputStreamResampler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII)I", "public")]
		public int read(JavaArray<float> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void mark(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(J)J", "public")]
		public long skip(long arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int available()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool markSupported()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()Ljavax/sound/sampled/AudioFormat;", "public")]
		public Dova.JDK.javax.sound.sampled.AudioFormat getFormat()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void readNextBuffer()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("()J", "public")]
		public long getFrameLength()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatFormatConverterInputStream;", "private static")]
	public partial class AudioFloatFormatConverterInputStream
		: Dova.JDK.java.io.InputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatFormatConverterInputStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatFormatConverterInputStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "converter", "Lcom/sun/media/sound/AudioFloatConverter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stream", "Lcom/sun/media/sound/AudioFloatInputStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readfloatbuffer", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fsize", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/sound/sampled/AudioFormat;Lcom/sun/media/sound/AudioFloatInputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "available", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markSupported", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter;", "private final")]
		public Dova.JDK.com.sun.media.sound.AudioFloatConverter converter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AudioFloatConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatInputStream;", "private final")]
		public Dova.JDK.com.sun.media.sound.AudioFloatInputStream stream_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AudioFloatInputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[F", "private")]
		public JavaArray<float> readfloatbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int fsize_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatFormatConverterInputStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Lcom/sun/media/sound/AudioFloatInputStream;)V", "")]
		public AudioFloatFormatConverterInputStream(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.com.sun.media.sound.AudioFloatInputStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatFormatConverter$AudioFloatFormatConverterInputStream;";
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

		[JniSignatureAttribute("(I)V", "public synchronized")]
		public void mark(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(J)J", "public")]
		public long skip(long arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int available()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool markSupported()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public synchronized")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}
	}
}
