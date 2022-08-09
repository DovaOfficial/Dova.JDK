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

namespace Dova.JDK.com.sun.media.sound;

[JniSignatureAttribute("Lcom/sun/media/sound/EmergencySoundbank;", "public final")]
public partial class EmergencySoundbank
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EmergencySoundbank()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/media/sound/EmergencySoundbank;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "general_midi_instruments", "[Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "EmergencySoundbank", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toBytes", "([FLjavax/sound/sampled/AudioFormat;)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "normalize", "([FD)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "normalize", "([DD)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newLayer", "(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;Lcom/sun/media/sound/SF2Sample;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_bass_drum", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_snare_drum", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_tom", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_open_hihat", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_closed_hihat", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_crash_cymbal", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_side_stick", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_gpiano", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_gpiano2", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_piano_hammer", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_piano1", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_epiano1", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_epiano2", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_guitar1", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_guitar_pick", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_guitar_dist", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_bass1", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_bass2", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_synthbass", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_string2", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_orchhit", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_choir", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_solostring", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_organ", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_ch_organ", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_bell", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_flute", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_timpani", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_melodic_toms", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_trumpet", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_trombone", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_brass_section", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_horn", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_sax", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_oboe", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_bassoon", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_clarinet", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "new_reverse_cymbal", "(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newInstrument", "(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;Ljavax/sound/midi/Patch;[Lcom/sun/media/sound/SF2Layer;)Lcom/sun/media/sound/SF2Instrument;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "complexGaussianDist", "([DDDD)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newSimpleFFTSample", "(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;[DDI)Lcom/sun/media/sound/SF2Sample;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newSimpleFFTSample", "(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;[DD)Lcom/sun/media/sound/SF2Sample;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newSimpleFFTSample_dist", "(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;[DDD)Lcom/sun/media/sound/SF2Sample;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fft", "([D)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "randomPhase", "([DLjava/util/Random;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "randomPhase", "([D)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ifft", "([D)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "realPart", "([D)[D"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fadeUp", "([FI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fadeUp", "([DI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newSimpleDrumSample", "(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;[D)Lcom/sun/media/sound/SF2Sample;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toFloat", "([D)[F"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "loopExtend", "([DI)[D"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "loopExtend", "([FI)[F"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createSoundbank", "()Lcom/sun/media/sound/SF2Soundbank;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "imgPart", "([D)[D"));
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> general_midi_instruments_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EmergencySoundbank(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public EmergencySoundbank() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/EmergencySoundbank;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([FLjavax/sound/sampled/AudioFormat;)[B", "public static")]
	public static JavaArray<byte> toBytes(JavaArray<float> arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([FD)V", "public static")]
	public static void normalize(JavaArray<float> arg0, double arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("([DD)V", "public static")]
	public static void normalize(JavaArray<double> arg0, double arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;Lcom/sun/media/sound/SF2Sample;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer newLayer(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.media.sound.SF2Sample arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_bass_drum(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_snare_drum(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_tom(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_open_hihat(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_closed_hihat(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_crash_cymbal(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_side_stick(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_gpiano(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_gpiano2(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_piano_hammer(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_piano1(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_epiano1(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_epiano2(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_guitar1(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_guitar_pick(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_guitar_dist(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_bass1(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_bass2(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_synthbass(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_string2(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_orchhit(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_choir(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_solostring(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_organ(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_ch_organ(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_bell(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_flute(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_timpani(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_melodic_toms(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_trumpet(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_trombone(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_brass_section(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_horn(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_sax(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_oboe(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_bassoon(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_clarinet(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;)Lcom/sun/media/sound/SF2Layer;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Layer new_reverse_cymbal(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Layer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;Ljavax/sound/midi/Patch;[Lcom/sun/media/sound/SF2Layer;)Lcom/sun/media/sound/SF2Instrument;", "public static transient")]
	public static Dova.JDK.com.sun.media.sound.SF2Instrument newInstrument(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.sound.midi.Patch arg2, JavaArray<Dova.JDK.com.sun.media.sound.SF2Layer> arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Instrument>(ret);
	}

	[JniSignatureAttribute("([DDDD)V", "public static")]
	public static void complexGaussianDist(JavaArray<double> arg0, double arg1, double arg2, double arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;[DDI)Lcom/sun/media/sound/SF2Sample;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Sample newSimpleFFTSample(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0, Dova.JDK.java.lang.String arg1, JavaArray<double> arg2, double arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Sample>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;[DD)Lcom/sun/media/sound/SF2Sample;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Sample newSimpleFFTSample(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0, Dova.JDK.java.lang.String arg1, JavaArray<double> arg2, double arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Sample>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;[DDD)Lcom/sun/media/sound/SF2Sample;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Sample newSimpleFFTSample_dist(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0, Dova.JDK.java.lang.String arg1, JavaArray<double> arg2, double arg3, double arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Sample>(ret);
	}

	[JniSignatureAttribute("([D)V", "public static")]
	public static void fft(JavaArray<double> arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("([DLjava/util/Random;)V", "public static")]
	public static void randomPhase(JavaArray<double> arg0, Dova.JDK.java.util.Random arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1);
	}

	[JniSignatureAttribute("([D)V", "public static")]
	public static void randomPhase(JavaArray<double> arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("([D)V", "public static")]
	public static void ifft(JavaArray<double> arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("([D)[D", "public static")]
	public static JavaArray<double> realPart(JavaArray<double> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("([FI)V", "public static")]
	public static void fadeUp(JavaArray<float> arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1);
	}

	[JniSignatureAttribute("([DI)V", "public static")]
	public static void fadeUp(JavaArray<double> arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SF2Soundbank;Ljava/lang/String;[D)Lcom/sun/media/sound/SF2Sample;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Sample newSimpleDrumSample(Dova.JDK.com.sun.media.sound.SF2Soundbank arg0, Dova.JDK.java.lang.String arg1, JavaArray<double> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Sample>(ret);
	}

	[JniSignatureAttribute("([D)[F", "public static")]
	public static JavaArray<float> toFloat(JavaArray<double> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([DI)[D", "public static")]
	public static JavaArray<double> loopExtend(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("([FI)[F", "public static")]
	public static JavaArray<float> loopExtend(JavaArray<float> arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/media/sound/SF2Soundbank;", "public static")]
	public static Dova.JDK.com.sun.media.sound.SF2Soundbank createSoundbank()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SF2Soundbank>(ret);
	}

	[JniSignatureAttribute("([D)[D", "public static")]
	public static JavaArray<double> imgPart(JavaArray<double> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}
}
