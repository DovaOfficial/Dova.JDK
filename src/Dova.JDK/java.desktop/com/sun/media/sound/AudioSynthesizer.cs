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

[JniSignatureAttribute("Lcom/sun/media/sound/AudioSynthesizer;", "public abstract interface")]
public partial interface AudioSynthesizer
	: IJavaObject
	, Dova.JDK.javax.sound.midi.Synthesizer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AudioSynthesizer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioSynthesizer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openStream", "(Ljavax/sound/sampled/AudioFormat;Ljava/util/Map;)Ljavax/sound/sampled/AudioInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "open", "(Ljavax/sound/sampled/SourceDataLine;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFormat", "()Ljavax/sound/sampled/AudioFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPropertyInfo", "(Ljava/util/Map;)[Lcom/sun/media/sound/AudioSynthesizerPropertyInfo;"));
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;Ljava/util/Map;)Ljavax/sound/sampled/AudioInputStream;", "public abstract")]
	Dova.JDK.javax.sound.sampled.AudioInputStream openStream(Dova.JDK.javax.sound.sampled.AudioFormat arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/SourceDataLine;Ljava/util/Map;)V", "public abstract")]
	void open(Dova.JDK.javax.sound.sampled.SourceDataLine arg0, Dova.JDK.java.util.Map arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/sound/sampled/AudioFormat;", "public abstract")]
	Dova.JDK.javax.sound.sampled.AudioFormat getFormat()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)[Lcom/sun/media/sound/AudioSynthesizerPropertyInfo;", "public abstract")]
	JavaArray<Dova.JDK.com.sun.media.sound.AudioSynthesizerPropertyInfo> getPropertyInfo(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.AudioSynthesizerPropertyInfo>>(ret);
	}
}
