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

[JniSignatureAttribute("Lcom/sun/media/sound/StandardMidiFileReader;", "public final")]
public partial class StandardMidiFileReader
	: Dova.JDK.javax.sound.midi.spi.MidiFileReader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StandardMidiFileReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/StandardMidiFileReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MThd_MAGIC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "bisBufferSize", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StandardMidiFileReader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMidiFileFormatFromStream", "(Ljava/io/InputStream;ILcom/sun/media/sound/SMFParser;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMidiFileFormat", "(Ljava/io/File;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMidiFileFormat", "(Ljava/net/URL;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMidiFileFormat", "(Ljava/io/InputStream;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSequence", "(Ljava/io/File;)Ljavax/sound/midi/Sequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSequence", "(Ljava/net/URL;)Ljavax/sound/midi/Sequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSequence", "(Ljava/io/InputStream;)Ljavax/sound/midi/Sequence;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MThd_MAGIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int bisBufferSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StandardMidiFileReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public StandardMidiFileReader() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/StandardMidiFileReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/InputStream;ILcom/sun/media/sound/SMFParser;)Ljavax/sound/midi/MidiFileFormat;", "private")]
	public Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormatFromStream(Dova.JDK.java.io.InputStream arg0, int arg1, Dova.JDK.com.sun.media.sound.SMFParser arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/MidiFileFormat;", "public")]
	public Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/MidiFileFormat;", "public")]
	public Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/MidiFileFormat;", "public")]
	public Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/Sequence;", "public")]
	public Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/Sequence;", "public")]
	public Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/Sequence;", "public")]
	public Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}
}
