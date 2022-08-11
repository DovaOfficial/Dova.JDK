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

[JniSignatureAttribute("Ljavax/sound/midi/MetaEventListener;", "public abstract interface")]
public partial interface MetaEventListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MetaEventListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/midi/MetaEventListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "meta", "(Ljavax/sound/midi/MetaMessage;)V"));
	}

	[JniSignatureAttribute("(Ljavax/sound/midi/MetaMessage;)V", "public abstract")]
	void meta(Dova.JDK.javax.sound.midi.MetaMessage arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
