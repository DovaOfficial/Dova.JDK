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

namespace Dova.JDK.javax.sound.sampled.spi;

[JniSignatureAttribute("Ljavax/sound/sampled/spi/AudioFileWriter;", "public abstract")]
public partial class AudioFileWriter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AudioFileWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/sampled/spi/AudioFileWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/OutputStream;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/File;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioFileTypes", "(Ljavax/sound/sampled/AudioInputStream;)[Ljavax/sound/sampled/AudioFileFormat$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioFileTypes", "()[Ljavax/sound/sampled/AudioFileFormat$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFileTypeSupported", "(Ljavax/sound/sampled/AudioFileFormat$Type;Ljavax/sound/sampled/AudioInputStream;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFileTypeSupported", "(Ljavax/sound/sampled/AudioFileFormat$Type;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AudioFileWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AudioFileWriter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/sound/sampled/spi/AudioFileWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/OutputStream;)I", "public abstract")]
	public int write(Dova.JDK.javax.sound.sampled.AudioInputStream arg0, Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg1, Dova.JDK.java.io.OutputStream arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;Ljavax/sound/sampled/AudioFileFormat$Type;Ljava/io/File;)I", "public abstract")]
	public int write(Dova.JDK.javax.sound.sampled.AudioInputStream arg0, Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg1, Dova.JDK.java.io.File arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioInputStream;)[Ljavax/sound/sampled/AudioFileFormat$Type;", "public abstract")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type> getAudioFileTypes(Dova.JDK.javax.sound.sampled.AudioInputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/AudioFileFormat$Type;", "public abstract")]
	public JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type> getAudioFileTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.AudioFileFormat.Type>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFileFormat$Type;Ljavax/sound/sampled/AudioInputStream;)Z", "public")]
	public bool isFileTypeSupported(Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg0, Dova.JDK.javax.sound.sampled.AudioInputStream arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFileFormat$Type;)Z", "public")]
	public bool isFileTypeSupported(Dova.JDK.javax.sound.sampled.AudioFileFormat.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}
}
