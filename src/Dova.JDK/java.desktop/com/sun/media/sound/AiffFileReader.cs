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

[JniSignatureAttribute("Lcom/sun/media/sound/AiffFileReader;", "public final")]
public partial class AiffFileReader
	: Dova.JDK.com.sun.media.sound.SunFileReader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AiffFileReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AiffFileReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read_ieee_extended", "(Ljava/io/DataInputStream;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioFileFormatImpl", "(Ljava/io/InputStream;)Lcom/sun/media/sound/StandardFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAudioInputStream", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioInputStream;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AiffFileReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AiffFileReader() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AiffFileReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/DataInputStream;)D", "private")]
	public double read_ieee_extended(Dova.JDK.java.io.DataInputStream arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Lcom/sun/media/sound/StandardFileFormat;", "")]
	public Dova.JDK.com.sun.media.sound.StandardFileFormat getAudioFileFormatImpl(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.StandardFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioInputStream;", "public volatile")]
	public Dova.JDK.javax.sound.sampled.AudioInputStream getAudioInputStream(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}
}
