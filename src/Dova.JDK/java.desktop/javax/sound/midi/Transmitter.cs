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

namespace Dova.JDK.javax.sound.midi;

[JniSignatureAttribute("Ljavax/sound/midi/Transmitter;", "public abstract interface")]
public partial interface Transmitter
	: IJavaObject
	, Dova.JDK.java.lang.AutoCloseable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Transmitter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/midi/Transmitter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiver", "()Ljavax/sound/midi/Receiver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReceiver", "(Ljavax/sound/midi/Receiver;)V"));
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljavax/sound/midi/Receiver;", "public abstract")]
	Dova.JDK.javax.sound.midi.Receiver getReceiver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Receiver>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/Receiver;)V", "public abstract")]
	void setReceiver(Dova.JDK.javax.sound.midi.Receiver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
