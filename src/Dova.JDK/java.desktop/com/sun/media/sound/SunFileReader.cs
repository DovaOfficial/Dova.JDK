/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Lcom/sun/media/sound/SunFileReader;", "abstract")]
public partial class SunFileReader
	: Dova.JDK.javax.sound.sampled.spi.AudioFileReader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SunFileReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SunFileReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SunFileReader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAudioInputStream", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAudioInputStream", "(Ljava/net/URL;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAudioInputStream", "(Ljava/io/File;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAudioFileFormat_0", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAudioFileFormat_1", "(Ljava/io/InputStream;)Lcom/sun/media/sound/StandardFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAudioFileFormat", "(Ljava/net/URL;)Ljavax/sound/sampled/AudioFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAudioFileFormat", "(Ljava/io/File;)Ljavax/sound/sampled/AudioFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rllong", "(Ljava/io/DataInputStream;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "big2little", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rlshort", "(Ljava/io/DataInputStream;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "big2littleShort", "(S)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAudioFileFormatImpl", "(Ljava/io/InputStream;)Lcom/sun/media/sound/StandardFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "closeSilently", "(Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "calculatePCMFrameSize", "(II)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SunFileReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public SunFileReader() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SunFileReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioInputStream;", "public")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/sampled/AudioInputStream;", "public final")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/sampled/AudioInputStream;", "public final")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioFileFormat;", "public volatile")]
	public Dova.JDK.javax.sound.sampled.AudioFileFormat getAudioFileFormat_0(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Lcom/sun/media/sound/StandardFileFormat;", "public final")]
	public Dova.JDK.com.sun.media.sound.StandardFileFormat getAudioFileFormat_1(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.StandardFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/sampled/AudioFileFormat;", "public final")]
	public Dova.JDK.javax.sound.sampled.AudioFileFormat getAudioFileFormat(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/sampled/AudioFileFormat;", "public final")]
	public Dova.JDK.javax.sound.sampled.AudioFileFormat getAudioFileFormat(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataInputStream;)I", "final")]
	public int rllong(Dova.JDK.java.io.DataInputStream arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "final")]
	public int big2little(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/DataInputStream;)S", "final")]
	public short rlshort(Dova.JDK.java.io.DataInputStream arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(S)S", "final")]
	public short big2littleShort(short arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Lcom/sun/media/sound/StandardFileFormat;", "abstract")]
	public Dova.JDK.com.sun.media.sound.StandardFileFormat getAudioFileFormatImpl(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.StandardFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)V", "private static")]
	public static void closeSilently(Dova.JDK.java.io.InputStream arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(II)I", "static final")]
	public static int calculatePCMFrameSize(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}
}
