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

[JniSignatureAttribute("Lcom/sun/media/sound/SoftResamplerStreamer;", "public abstract interface")]
public partial interface SoftResamplerStreamer
	: IJavaObject
	, Dova.JDK.com.sun.media.sound.ModelOscillatorStream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SoftResamplerStreamer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftResamplerStreamer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "open", "(Lcom/sun/media/sound/ModelWavetable;F)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelWavetable;F)V", "public abstract")]
	void open(Dova.JDK.com.sun.media.sound.ModelWavetable arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
