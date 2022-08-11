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

[JniSignatureAttribute("Lcom/sun/media/sound/ReferenceCountingDevice;", "public abstract interface")]
public partial interface ReferenceCountingDevice
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReferenceCountingDevice()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/ReferenceCountingDevice;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverReferenceCounting", "()Ljavax/sound/midi/Receiver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransmitterReferenceCounting", "()Ljavax/sound/midi/Transmitter;"));
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Receiver;", "public abstract")]
	Dova.JDK.javax.sound.midi.Receiver getReceiverReferenceCounting()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Receiver>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Transmitter;", "public abstract")]
	Dova.JDK.javax.sound.midi.Transmitter getTransmitterReferenceCounting()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Transmitter>(ret);
	}
}
