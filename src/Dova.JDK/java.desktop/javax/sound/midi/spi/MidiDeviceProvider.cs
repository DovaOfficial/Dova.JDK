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

[JniSignatureAttribute("Ljavax/sound/midi/spi/MidiDeviceProvider;", "public abstract")]
public partial class MidiDeviceProvider
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MidiDeviceProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/midi/spi/MidiDeviceProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeviceInfo", "()[Ljavax/sound/midi/MidiDevice$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeviceSupported", "(Ljavax/sound/midi/MidiDevice$Info;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDevice", "(Ljavax/sound/midi/MidiDevice$Info;)Ljavax/sound/midi/MidiDevice;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MidiDeviceProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public MidiDeviceProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/sound/midi/spi/MidiDeviceProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljavax/sound/midi/MidiDevice$Info;", "public abstract")]
	public JavaArray<Dova.JDK.javax.sound.midi.MidiDevice.Info> getDeviceInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.MidiDevice.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/MidiDevice$Info;)Z", "public")]
	public bool isDeviceSupported(Dova.JDK.javax.sound.midi.MidiDevice.Info arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/MidiDevice$Info;)Ljavax/sound/midi/MidiDevice;", "public abstract")]
	public Dova.JDK.javax.sound.midi.MidiDevice getDevice(Dova.JDK.javax.sound.midi.MidiDevice.Info arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}
}
