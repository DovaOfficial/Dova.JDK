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

[JniSignatureAttribute("Lcom/sun/media/sound/DLSSoundbankReader;", "public final")]
public partial class DLSSoundbankReader
	: Dova.JDK.javax.sound.midi.spi.SoundbankReader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DLSSoundbankReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/DLSSoundbankReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSoundbank", "(Ljava/io/File;)Ljavax/sound/midi/Soundbank;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSoundbank", "(Ljava/io/InputStream;)Ljavax/sound/midi/Soundbank;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSoundbank", "(Ljava/net/URL;)Ljavax/sound/midi/Soundbank;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DLSSoundbankReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DLSSoundbankReader() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/DLSSoundbankReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/Soundbank;", "public")]
	public Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/Soundbank;", "public")]
	public Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/Soundbank;", "public")]
	public Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}
}
