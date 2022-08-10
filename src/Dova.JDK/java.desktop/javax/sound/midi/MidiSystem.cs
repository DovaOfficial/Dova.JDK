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

namespace Dova.JDK.javax.sound.midi;

[JniSignatureAttribute("Ljavax/sound/midi/MidiSystem;", "public")]
public partial class MidiSystem
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MidiSystem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/midi/MidiSystem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MidiSystem", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljavax/sound/midi/Sequence;ILjava/io/OutputStream;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljavax/sound/midi/Sequence;ILjava/io/File;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getProviders", "(Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isFileTypeSupported", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isFileTypeSupported", "(ILjavax/sound/midi/Sequence;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiDeviceProviders", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDefaultDeviceWrapper", "(Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTransmitter", "()Ljavax/sound/midi/Transmitter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSequencer", "(Z)Ljavax/sound/midi/Sequencer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSequencer", "()Ljavax/sound/midi/Sequencer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSynthesizer", "()Ljavax/sound/midi/Synthesizer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSoundbankReaders", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSoundbank", "(Ljava/net/URL;)Ljavax/sound/midi/Soundbank;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSoundbank", "(Ljava/io/InputStream;)Ljavax/sound/midi/Soundbank;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSoundbank", "(Ljava/io/File;)Ljavax/sound/midi/Soundbank;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiFileReaders", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiFileFormat", "(Ljava/net/URL;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiFileFormat", "(Ljava/io/File;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiFileFormat", "(Ljava/io/InputStream;)Ljavax/sound/midi/MidiFileFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiFileWriters", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiFileTypes", "(Ljavax/sound/midi/Sequence;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiFileTypes", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDefaultDevice", "(Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNamedDevice", "(Ljava/lang/String;Ljava/util/List;Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNamedDevice", "(Ljava/lang/String;Ljavax/sound/midi/spi/MidiDeviceProvider;Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNamedDevice", "(Ljava/lang/String;Ljava/util/List;Ljava/lang/Class;ZZ)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNamedDevice", "(Ljava/lang/String;Ljavax/sound/midi/spi/MidiDeviceProvider;Ljava/lang/Class;ZZ)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getFirstDevice", "(Ljavax/sound/midi/spi/MidiDeviceProvider;Ljava/lang/Class;ZZ)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getFirstDevice", "(Ljava/util/List;Ljava/lang/Class;ZZ)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getFirstDevice", "(Ljava/util/List;Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getFirstDevice", "(Ljavax/sound/midi/spi/MidiDeviceProvider;Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isAppropriateDevice", "(Ljavax/sound/midi/MidiDevice;Ljava/lang/Class;ZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiDeviceInfo", "()[Ljavax/sound/midi/MidiDevice$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMidiDevice", "(Ljavax/sound/midi/MidiDevice$Info;)Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNamedProvider", "(Ljava/lang/String;Ljava/util/List;)Ljavax/sound/midi/spi/MidiDeviceProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getReceiver", "()Ljavax/sound/midi/Receiver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSequence", "(Ljava/io/InputStream;)Ljavax/sound/midi/Sequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSequence", "(Ljava/io/File;)Ljavax/sound/midi/Sequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSequence", "(Ljava/net/URL;)Ljavax/sound/midi/Sequence;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MidiSystem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public MidiSystem() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/sound/midi/MidiSystem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/midi/Sequence;ILjava/io/OutputStream;)I", "public static")]
	public static int write(Dova.JDK.javax.sound.midi.Sequence arg0, int arg1, Dova.JDK.java.io.OutputStream arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Sequence;ILjava/io/File;)I", "public static")]
	public static int write(Dova.JDK.javax.sound.midi.Sequence arg0, int arg1, Dova.JDK.java.io.File arg2)
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

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isFileTypeSupported(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/sound/midi/Sequence;)Z", "public static")]
	public static bool isFileTypeSupported(int arg0, Dova.JDK.javax.sound.midi.Sequence arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getMidiDeviceProviders()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getDefaultDeviceWrapper(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Transmitter;", "public static")]
	public static Dova.JDK.javax.sound.midi.Transmitter getTransmitter()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Transmitter>(ret);
	}

	[JniSignatureAttribute("(Z)Ljavax/sound/midi/Sequencer;", "public static")]
	public static Dova.JDK.javax.sound.midi.Sequencer getSequencer(bool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequencer>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Sequencer;", "public static")]
	public static Dova.JDK.javax.sound.midi.Sequencer getSequencer()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequencer>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Synthesizer;", "public static")]
	public static Dova.JDK.javax.sound.midi.Synthesizer getSynthesizer()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Synthesizer>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getSoundbankReaders()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/Soundbank;", "public static")]
	public static Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/Soundbank;", "public static")]
	public static Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/Soundbank;", "public static")]
	public static Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getMidiFileReaders()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/MidiFileFormat;", "public static")]
	public static Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/MidiFileFormat;", "public static")]
	public static Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/MidiFileFormat;", "public static")]
	public static Dova.JDK.javax.sound.midi.MidiFileFormat getMidiFileFormat(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiFileFormat>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getMidiFileWriters()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Sequence;)[I", "public static")]
	public static JavaArray<int> getMidiFileTypes(Dova.JDK.javax.sound.midi.Sequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()[I", "public static")]
	public static JavaArray<int> getMidiFileTypes()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getDefaultDevice(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getNamedDevice(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/sound/midi/spi/MidiDeviceProvider;Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getNamedDevice(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.sound.midi.spi.MidiDeviceProvider arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;Ljava/lang/Class;ZZ)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getNamedDevice(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.Class arg2, bool arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/sound/midi/spi/MidiDeviceProvider;Ljava/lang/Class;ZZ)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getNamedDevice(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.sound.midi.spi.MidiDeviceProvider arg1, Dova.JDK.java.lang.Class arg2, bool arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/spi/MidiDeviceProvider;Ljava/lang/Class;ZZ)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getFirstDevice(Dova.JDK.javax.sound.midi.spi.MidiDeviceProvider arg0, Dova.JDK.java.lang.Class arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/Class;ZZ)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getFirstDevice(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.Class arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getFirstDevice(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/spi/MidiDeviceProvider;Ljava/lang/Class;)Ljavax/sound/midi/MidiDevice;", "private static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getFirstDevice(Dova.JDK.javax.sound.midi.spi.MidiDeviceProvider arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/MidiDevice;Ljava/lang/Class;ZZ)Z", "private static")]
	public static bool isAppropriateDevice(Dova.JDK.javax.sound.midi.MidiDevice arg0, Dova.JDK.java.lang.Class arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()[Ljavax/sound/midi/MidiDevice$Info;", "public static")]
	public static JavaArray<Dova.JDK.javax.sound.midi.MidiDevice.Info> getMidiDeviceInfo()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.MidiDevice.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/MidiDevice$Info;)Ljavax/sound/midi/MidiDevice;", "public static")]
	public static Dova.JDK.javax.sound.midi.MidiDevice getMidiDevice(Dova.JDK.javax.sound.midi.MidiDevice.Info arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Ljavax/sound/midi/spi/MidiDeviceProvider;", "private static")]
	public static Dova.JDK.javax.sound.midi.spi.MidiDeviceProvider getNamedProvider(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.spi.MidiDeviceProvider>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Receiver;", "public static")]
	public static Dova.JDK.javax.sound.midi.Receiver getReceiver()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Receiver>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/Sequence;", "public static")]
	public static Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/Sequence;", "public static")]
	public static Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/Sequence;", "public static")]
	public static Dova.JDK.javax.sound.midi.Sequence getSequence(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Sequence>(ret);
	}
}
