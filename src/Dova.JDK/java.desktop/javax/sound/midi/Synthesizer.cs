/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljavax/sound/midi/Synthesizer;", "public abstract interface")]
public partial interface Synthesizer
	: IJavaObject
	, Dova.JDK.javax.sound.midi.MidiDevice
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Synthesizer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/midi/Synthesizer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMaxPolyphony", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLatency", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVoiceStatus", "()[Ljavax/sound/midi/VoiceStatus;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSoundbankSupported", "(Ljavax/sound/midi/Soundbank;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "loadInstrument", "(Ljavax/sound/midi/Instrument;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unloadInstrument", "(Ljavax/sound/midi/Instrument;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remapInstrument", "(Ljavax/sound/midi/Instrument;Ljavax/sound/midi/Instrument;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultSoundbank", "()Ljavax/sound/midi/Soundbank;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAvailableInstruments", "()[Ljavax/sound/midi/Instrument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLoadedInstruments", "()[Ljavax/sound/midi/Instrument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "loadAllInstruments", "(Ljavax/sound/midi/Soundbank;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unloadAllInstruments", "(Ljavax/sound/midi/Soundbank;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "loadInstruments", "(Ljavax/sound/midi/Soundbank;[Ljavax/sound/midi/Patch;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unloadInstruments", "(Ljavax/sound/midi/Soundbank;[Ljavax/sound/midi/Patch;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChannels", "()[Ljavax/sound/midi/MidiChannel;"));
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getMaxPolyphony()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long getLatency()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljavax/sound/midi/VoiceStatus;", "public abstract")]
	JavaArray<Dova.JDK.javax.sound.midi.VoiceStatus> getVoiceStatus()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.VoiceStatus>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Soundbank;)Z", "public abstract")]
	bool isSoundbankSupported(Dova.JDK.javax.sound.midi.Soundbank arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Instrument;)Z", "public abstract")]
	bool loadInstrument(Dova.JDK.javax.sound.midi.Instrument arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Instrument;)V", "public abstract")]
	void unloadInstrument(Dova.JDK.javax.sound.midi.Instrument arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Instrument;Ljavax/sound/midi/Instrument;)Z", "public abstract")]
	bool remapInstrument(Dova.JDK.javax.sound.midi.Instrument arg0, Dova.JDK.javax.sound.midi.Instrument arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Soundbank;", "public abstract")]
	Dova.JDK.javax.sound.midi.Soundbank getDefaultSoundbank()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/midi/Instrument;", "public abstract")]
	JavaArray<Dova.JDK.javax.sound.midi.Instrument> getAvailableInstruments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.Instrument>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/midi/Instrument;", "public abstract")]
	JavaArray<Dova.JDK.javax.sound.midi.Instrument> getLoadedInstruments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.Instrument>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Soundbank;)Z", "public abstract")]
	bool loadAllInstruments(Dova.JDK.javax.sound.midi.Soundbank arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Soundbank;)V", "public abstract")]
	void unloadAllInstruments(Dova.JDK.javax.sound.midi.Soundbank arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Soundbank;[Ljavax/sound/midi/Patch;)Z", "public abstract")]
	bool loadInstruments(Dova.JDK.javax.sound.midi.Soundbank arg0, JavaArray<Dova.JDK.javax.sound.midi.Patch> arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Soundbank;[Ljavax/sound/midi/Patch;)V", "public abstract")]
	void unloadInstruments(Dova.JDK.javax.sound.midi.Soundbank arg0, JavaArray<Dova.JDK.javax.sound.midi.Patch> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("()[Ljavax/sound/midi/MidiChannel;", "public abstract")]
	JavaArray<Dova.JDK.javax.sound.midi.MidiChannel> getChannels()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.MidiChannel>>(ret);
	}
}
