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

[JniSignatureAttribute("Lcom/sun/media/sound/WaveFileWriter;", "public final")]
public partial class WaveFileWriter
	: Dova.JDK.com.sun.media.sound.SunFileWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WaveFileWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/WaveFileWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/File;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/OutputStream;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeWaveFile", "(Ljava/io/InputStream;Lcom/sun/media/sound/WaveFileFormat;Ljava/io/OutputStream;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileStream", "(Lcom/sun/media/sound/WaveFileFormat;Ljava/io/InputStream;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioFileFormat", "(Ljavax/sound/sampled/AudioFileFormat$Type;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioFileTypes", "(Ljavax/sound/sampled/AudioInputStream;)[Ljavax/sound/sampled/AudioFileFormat$Type;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public WaveFileWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public WaveFileWriter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/WaveFileWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/File;)I", "public")]
	public int write(Dova.JDK.javax.sound.sampled.AudioInputStream arg0, Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg1, Dova.JDK.java.io.File arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/OutputStream;)I", "public")]
	public int write(Dova.JDK.javax.sound.sampled.AudioInputStream arg0, Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg1, Dova.JDK.java.io.OutputStream arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Lcom/sun/media/sound/WaveFileFormat;Ljava/io/OutputStream;)I", "private")]
	public int writeWaveFile(Dova.JDK.java.io.InputStream arg0, Dova.JDK.com.sun.media.sound.WaveFileFormat arg1, Dova.JDK.java.io.OutputStream arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/WaveFileFormat;Ljava/io/InputStream;)Ljava/io/InputStream;", "private")]
	public Dova.JDK.java.io.InputStream getFileStream(Dova.JDK.com.sun.media.sound.WaveFileFormat arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFileFormat$Type;Ljavax/sound/sampled/AudioInputStream;)Ljavax/sound/sampled/AudioFileFormat;", "private")]
	public Dova.JDK.javax.sound.sampled.AudioFileFormat getAudioFileFormat(Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;)[Ljavax/sound/sampled/AudioFileFormat$Type;", "public")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type> getAudioFileTypes(Dova.JDK.javax.sound.sampled.AudioInputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type>>(ret);
	}
}
