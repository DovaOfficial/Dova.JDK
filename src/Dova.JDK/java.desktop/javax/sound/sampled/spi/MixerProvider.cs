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

namespace Dova.JDK.javax.sound.sampled.spi;

[JniSignatureAttribute("Ljavax/sound/sampled/spi/MixerProvider;", "public abstract")]
public partial class MixerProvider
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MixerProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sound/sampled/spi/MixerProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMixer", "(Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/Mixer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMixerInfo", "()[Ljavax/sound/sampled/Mixer$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMixerSupported", "(Ljavax/sound/sampled/Mixer$Info;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MixerProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public MixerProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/sound/sampled/spi/MixerProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/sampled/Mixer$Info;)Ljavax/sound/sampled/Mixer;", "public abstract")]
	public Dova.JDK.javax.sound.sampled.Mixer getMixer(Dova.JDK.javax.sound.sampled.Mixer.Info arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Mixer>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/Mixer$Info;", "public abstract")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Mixer.Info> getMixerInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Mixer.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Mixer$Info;)Z", "public")]
	public bool isMixerSupported(Dova.JDK.javax.sound.sampled.Mixer.Info arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}
}
