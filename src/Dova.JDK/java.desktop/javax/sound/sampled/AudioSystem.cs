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

namespace Dova.JDK.javax.sound.sampled;

[JniSignatureAttribute("Ljavax/sound/sampled/AudioSystem;", "public")]
public partial class AudioSystem
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AudioSystem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/sampled/AudioSystem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_SPECIFIED", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/OutputStream;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/File;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getProviders", "(Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioInputStream", "(Ljava/io/File;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioInputStream", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioInputStream", "(Ljava/net/URL;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioInputStream", "(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioInputStream", "(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMixerInfoList", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMixerInfoList", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMixerProviders", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMixer", "(Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/Mixer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMixerInfo", "()[Ljavax/sound/sampled/Mixer$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSourceLineInfo", "(Ljavax/sound/sampled/Line$Info;)[Ljavax/sound/sampled/Line$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTargetLineInfo", "(Ljavax/sound/sampled/Line$Info;)[Ljavax/sound/sampled/Line$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLineSupported", "(Ljavax/sound/sampled/Line$Info;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultMixer", "(Ljava/util/List;Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Mixer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAppropriateMixer", "(Ljavax/sound/sampled/Mixer;Ljavax/sound/sampled/Line$Info;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFormatConversionProviders", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTargetEncodings", "(Ljavax/sound/sampled/AudioFormat$Encoding;)[Ljavax/sound/sampled/AudioFormat$Encoding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTargetEncodings", "(Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat$Encoding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isConversionSupported", "(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isConversionSupported", "(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioFormat;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTargetFormats", "(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioFileReaders", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioFileFormat", "(Ljava/io/File;)Ljavax/sound/sampled/AudioFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioFileFormat", "(Ljava/net/URL;)Ljavax/sound/sampled/AudioFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioFileFormat", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioFileWriters", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioFileTypes", "()[Ljavax/sound/sampled/AudioFileFormat$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAudioFileTypes", "(Ljavax/sound/sampled/AudioInputStream;)[Ljavax/sound/sampled/AudioFileFormat$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isFileTypeSupported", "(Ljavax/sound/sampled/AudioFileFormat$Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isFileTypeSupported", "(Ljavax/sound/sampled/AudioFileFormat$Type;Ljavax/sound/sampled/AudioInputStream;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNamedProvider", "(Ljava/lang/String;Ljava/util/List;)Ljavax/sound/sampled/spi/MixerProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNamedMixer", "(Ljava/lang/String;Ljava/util/List;Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Mixer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNamedMixer", "(Ljava/lang/String;Ljavax/sound/sampled/spi/MixerProvider;Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Mixer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFirstMixer", "(Ljavax/sound/sampled/spi/MixerProvider;Ljavax/sound/sampled/Line$Info;Z)Ljavax/sound/sampled/Mixer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSourceDataLine", "(Ljavax/sound/sampled/AudioFormat;)Ljavax/sound/sampled/SourceDataLine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSourceDataLine", "(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/SourceDataLine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTargetDataLine", "(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/TargetDataLine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTargetDataLine", "(Ljavax/sound/sampled/AudioFormat;)Ljavax/sound/sampled/TargetDataLine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLine", "(Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Line;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClip", "()Ljavax/sound/sampled/Clip;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClip", "(Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/Clip;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int NOT_SPECIFIED_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AudioSystem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public AudioSystem() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/sound/sampled/AudioSystem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/OutputStream;)I", "public static")]
	public static int write(Dova.JDK.javax.sound.sampled.AudioInputStream arg0, Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg1, Dova.JDK.java.io.OutputStream arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/File;)I", "public static")]
	public static int write(Dova.JDK.javax.sound.sampled.AudioInputStream arg0, Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg1, Dova.JDK.java.io.File arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getProviders(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/sampled/AudioInputStream;", "public static")]
	public static Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioInputStream;", "public static")]
	public static Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/sampled/AudioInputStream;", "public static")]
	public static Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;", "public static")]
	public static Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioInputStream;", "public static")]
	public static Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getMixerInfoList(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getMixerInfoList()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getMixerProviders()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/Mixer;", "public static")]
	public static Dova.JDK.javax.sound.sampled.Mixer getMixer(Dova.JDK.javax.sound.sampled.Mixer.Info arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Mixer>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/Mixer$Info;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.sampled.Mixer.Info> getMixerInfo()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Mixer.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)[Ljavax/sound/sampled/Line$Info;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> getSourceLineInfo(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)[Ljavax/sound/sampled/Line$Info;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> getTargetLineInfo(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)Z", "public static")]
	public static bool isLineSupported(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Mixer;", "private static")]
	public static Dova.JDK.javax.sound.sampled.Mixer getDefaultMixer(Dova.JDK.java.util.List arg0, Dova.JDK.javax.sound.sampled.Line.Info arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Mixer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Mixer;Ljavax/sound/sampled/Line$Info;Z)Z", "private static")]
	public static bool isAppropriateMixer(Dova.JDK.javax.sound.sampled.Mixer arg0, Dova.JDK.javax.sound.sampled.Line.Info arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getFormatConversionProviders()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;)[Ljavax/sound/sampled/AudioFormat$Encoding;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> getTargetEncodings(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat$Encoding;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding> getTargetEncodings(Dova.JDK.javax.sound.sampled.AudioFormat arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat.Encoding>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)Z", "public static")]
	public static bool isConversionSupported(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/AudioFormat;)Z", "public static")]
	public static bool isConversionSupported(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat$Encoding;Ljavax/sound/sampled/AudioFormat;)[Ljavax/sound/sampled/AudioFormat;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat> getTargetFormats(Dova.JDK.javax.sound.sampled.AudioFormat.Encoding arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFormat>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getAudioFileReaders()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/sampled/AudioFileFormat;", "public static")]
	public static Dova.JDK.javax.sound.sampled.AudioFileFormat getAudioFileFormat(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/sampled/AudioFileFormat;", "public static")]
	public static Dova.JDK.javax.sound.sampled.AudioFileFormat getAudioFileFormat(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioFileFormat;", "public static")]
	public static Dova.JDK.javax.sound.sampled.AudioFileFormat getAudioFileFormat(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFileFormat>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getAudioFileWriters()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/AudioFileFormat$Type;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type> getAudioFileTypes()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;)[Ljavax/sound/sampled/AudioFileFormat$Type;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type> getAudioFileTypes(Dova.JDK.javax.sound.sampled.AudioInputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFileFormat$Type;)Z", "public static")]
	public static bool isFileTypeSupported(Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFileFormat$Type;Ljavax/sound/sampled/AudioInputStream;)Z", "public static")]
	public static bool isFileTypeSupported(Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Ljavax/sound/sampled/spi/MixerProvider;", "private static")]
	public static Dova.JDK.javax.sound.sampled.spi.MixerProvider getNamedProvider(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.spi.MixerProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Mixer;", "private static")]
	public static Dova.JDK.javax.sound.sampled.Mixer getNamedMixer(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1, Dova.JDK.javax.sound.sampled.Line.Info arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Mixer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/sound/sampled/spi/MixerProvider;Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Mixer;", "private static")]
	public static Dova.JDK.javax.sound.sampled.Mixer getNamedMixer(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.sound.sampled.spi.MixerProvider arg1, Dova.JDK.javax.sound.sampled.Line.Info arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Mixer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/spi/MixerProvider;Ljavax/sound/sampled/Line$Info;Z)Ljavax/sound/sampled/Mixer;", "private static")]
	public static Dova.JDK.javax.sound.sampled.Mixer getFirstMixer(Dova.JDK.javax.sound.sampled.spi.MixerProvider arg0, Dova.JDK.javax.sound.sampled.Line.Info arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Mixer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;)Ljavax/sound/sampled/SourceDataLine;", "public static")]
	public static Dova.JDK.javax.sound.sampled.SourceDataLine getSourceDataLine(Dova.JDK.javax.sound.sampled.AudioFormat arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.SourceDataLine>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/SourceDataLine;", "public static")]
	public static Dova.JDK.javax.sound.sampled.SourceDataLine getSourceDataLine(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.javax.sound.sampled.Mixer.Info arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.SourceDataLine>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/TargetDataLine;", "public static")]
	public static Dova.JDK.javax.sound.sampled.TargetDataLine getTargetDataLine(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.javax.sound.sampled.Mixer.Info arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.TargetDataLine>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;)Ljavax/sound/sampled/TargetDataLine;", "public static")]
	public static Dova.JDK.javax.sound.sampled.TargetDataLine getTargetDataLine(Dova.JDK.javax.sound.sampled.AudioFormat arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.TargetDataLine>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Line;", "public static")]
	public static Dova.JDK.javax.sound.sampled.Line getLine(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Line>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/sampled/Clip;", "public static")]
	public static Dova.JDK.javax.sound.sampled.Clip getClip()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Clip>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/Clip;", "public static")]
	public static Dova.JDK.javax.sound.sampled.Clip getClip(Dova.JDK.javax.sound.sampled.Mixer.Info arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Clip>(ret);
	}
}
