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

[JniSignatureAttribute("Lcom/sun/media/sound/MidiDeviceReceiverEnvelope;", "public final")]
public partial class MidiDeviceReceiverEnvelope
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.sound.midi.MidiDeviceReceiver
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MidiDeviceReceiverEnvelope()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/MidiDeviceReceiverEnvelope;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "device", "Ljavax/sound/midi/MidiDevice;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "receiver", "Ljavax/sound/midi/Receiver;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MidiDeviceReceiverEnvelope", "(Ljavax/sound/midi/MidiDevice;Ljavax/sound/midi/Receiver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "send", "(Ljavax/sound/midi/MidiMessage;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMidiDevice", "()Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getReceiver", "()Ljavax/sound/midi/Receiver;"));
	}

	[JniSignatureAttribute("Ljavax/sound/midi/MidiDevice;", "private final")]
	public Dova.JDK.javax.sound.midi.MidiDevice device_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/sound/midi/Receiver;", "private final")]
	public Dova.JDK.javax.sound.midi.Receiver receiver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Receiver>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MidiDeviceReceiverEnvelope(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/MidiDevice;Ljavax/sound/midi/Receiver;)V", "public")]
	public MidiDeviceReceiverEnvelope(Dova.JDK.javax.sound.midi.MidiDevice arg0, Dova.JDK.javax.sound.midi.Receiver arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/MidiDeviceReceiverEnvelope;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/MidiMessage;J)V", "public")]
	public void send(Dova.JDK.javax.sound.midi.MidiMessage arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/MidiDevice;", "public")]
	public Dova.JDK.javax.sound.midi.MidiDevice getMidiDevice()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Receiver;", "public")]
	public Dova.JDK.javax.sound.midi.Receiver getReceiver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Receiver>(ret);
	}
}
