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

namespace Dova.JDK.javax.sound.midi.spi;

[JniSignatureAttribute("Ljavax/sound/midi/spi/MidiFileReader;", "public abstract")]
public partial class MidiFileReader
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MidiFileReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/midi/spi/MidiFileReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSequence", "(Ljava/io/File;)Ljavax/sound/midi/Sequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSequence", "(Ljava/io/InputStream;)Ljavax/sound/midi/Sequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSequence", "(Ljava/net/URL;)Ljavax/sound/midi/Sequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMidiFileFormat", "(Ljava/net/URL;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMidiFileFormat", "(Ljava/io/InputStream;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMidiFileFormat", "(Ljava/io/File;)Ljavax/sound/midi/MidiFileFormat;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MidiFileReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public MidiFileReader() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/sound/midi/spi/MidiFileReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/Sequence;", "public abstract")]
	public Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/Sequence;", "public abstract")]
	public Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/Sequence;", "public abstract")]
	public Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/MidiFileFormat;", "public abstract")]
	public Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/MidiFileFormat;", "public abstract")]
	public Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/MidiFileFormat;", "public abstract")]
	public Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}
}
