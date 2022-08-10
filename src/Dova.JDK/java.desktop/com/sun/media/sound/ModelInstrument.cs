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

[JniSignatureAttribute("Lcom/sun/media/sound/ModelInstrument;", "public abstract")]
public partial class ModelInstrument
	: Dova.JDK.javax.sound.midi.Instrument
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModelInstrument()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/ModelInstrument;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ModelInstrument", "(Ljavax/sound/midi/Soundbank;Ljavax/sound/midi/Patch;Ljava/lang/String;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getKeys", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPerformers", "()[Lcom/sun/media/sound/ModelPerformer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDirector", "([Lcom/sun/media/sound/ModelPerformer;Ljavax/sound/midi/MidiChannel;Lcom/sun/media/sound/ModelDirectedPlayer;)Lcom/sun/media/sound/ModelDirector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChannelMixer", "(Ljavax/sound/midi/MidiChannel;Ljavax/sound/sampled/AudioFormat;)Lcom/sun/media/sound/ModelChannelMixer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPatchAlias", "()Ljavax/sound/midi/Patch;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChannels", "()[Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ModelInstrument(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Soundbank;Ljavax/sound/midi/Patch;Ljava/lang/String;Ljava/lang/Class;)V", "protected")]
	public ModelInstrument(Dova.JDK.javax.sound.midi.Soundbank arg0, Dova.JDK.javax.sound.midi.Patch arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Class arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/ModelInstrument;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/lang/String;", "public final")]
	public JavaArray<Dova.JDK.java.lang.String> getKeys()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/media/sound/ModelPerformer;", "public")]
	public JavaArray<Dova.JDK.com.sun.media.sound.ModelPerformer> getPerformers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.ModelPerformer>>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/media/sound/ModelPerformer;Ljavax/sound/midi/MidiChannel;Lcom/sun/media/sound/ModelDirectedPlayer;)Lcom/sun/media/sound/ModelDirector;", "public")]
	public Dova.JDK.com.sun.media.sound.ModelDirector getDirector(JavaArray<Dova.JDK.com.sun.media.sound.ModelPerformer> arg0, Dova.JDK.javax.sound.midi.MidiChannel arg1, Dova.JDK.com.sun.media.sound.ModelDirectedPlayer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelDirector>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/MidiChannel;Ljavax/sound/sampled/AudioFormat;)Lcom/sun/media/sound/ModelChannelMixer;", "public")]
	public Dova.JDK.com.sun.media.sound.ModelChannelMixer getChannelMixer(Dova.JDK.javax.sound.midi.MidiChannel arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelChannelMixer>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Patch;", "public final")]
	public Dova.JDK.javax.sound.midi.Patch getPatchAlias()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Patch>(ret);
	}

	[JniSignatureAttribute("()[Z", "public final")]
	public JavaArray<bool> getChannels()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
	}
}
