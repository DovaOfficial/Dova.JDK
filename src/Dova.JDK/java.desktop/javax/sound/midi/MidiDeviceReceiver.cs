/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.sound.midi;

[JniSignatureAttribute("Ljavax/sound/midi/MidiDeviceReceiver;", "public abstract interface")]
public partial interface MidiDeviceReceiver
	: IJavaObject
	, Dova.JDK.javax.sound.midi.Receiver
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MidiDeviceReceiver()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/sound/midi/MidiDeviceReceiver;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMidiDevice", "()Ljavax/sound/midi/MidiDevice;"));
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/MidiDevice;", "public abstract")]
	Dova.JDK.javax.sound.midi.MidiDevice getMidiDevice()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}
}
