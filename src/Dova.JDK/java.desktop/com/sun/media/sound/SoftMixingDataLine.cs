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

[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine;", "public abstract")]
public partial class SoftMixingDataLine
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.sound.sampled.DataLine
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SoftMixingDataLine()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHORUS_SEND", "Ljavax/sound/sampled/FloatControl$Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gain_control", "Lcom/sun/media/sound/SoftMixingDataLine$Gain;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mute_control", "Lcom/sun/media/sound/SoftMixingDataLine$Mute;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "balance_control", "Lcom/sun/media/sound/SoftMixingDataLine$Balance;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pan_control", "Lcom/sun/media/sound/SoftMixingDataLine$Pan;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reverbsend_control", "Lcom/sun/media/sound/SoftMixingDataLine$ReverbSend;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chorussend_control", "Lcom/sun/media/sound/SoftMixingDataLine$ChorusSend;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "apply_reverb", "Lcom/sun/media/sound/SoftMixingDataLine$ApplyReverb;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "controls", "[Ljavax/sound/sampled/Control;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leftgain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rightgain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eff1gain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eff2gain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listeners", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "control_mutex", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mixer", "Lcom/sun/media/sound/SoftMixingMixer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "info", "Ljavax/sound/sampled/DataLine$Info;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/SoftMixingMixer;Ljavax/sound/sampled/DataLine$Info;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControl", "(Ljavax/sound/sampled/Control$Type;)Ljavax/sound/sampled/Control;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calcVolume", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processControlLogic", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processAudioLogic", "([Lcom/sun/media/sound/SoftAudioBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineInfo", "()Ljavax/sound/sampled/Line$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControls", "()[Ljavax/sound/sampled/Control;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isControlSupported", "(Ljavax/sound/sampled/Control$Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLineListener", "(Ljavax/sound/sampled/LineListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeLineListener", "(Ljavax/sound/sampled/LineListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendEvent", "(Ljavax/sound/sampled/LineEvent;)V"));
	}

	[JniSignatureAttribute("Ljavax/sound/sampled/FloatControl$Type;", "public static final")]
	public static Dova.JDK.javax.sound.sampled.FloatControl.Type CHORUS_SEND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.FloatControl.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$Gain;", "private final")]
	public Dova.JDK.com.sun.media.sound.SoftMixingDataLine.Gain gain_control_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine.Gain>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$Mute;", "private final")]
	public Dova.JDK.com.sun.media.sound.SoftMixingDataLine.Mute mute_control_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine.Mute>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$Balance;", "private final")]
	public Dova.JDK.com.sun.media.sound.SoftMixingDataLine.Balance balance_control_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine.Balance>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$Pan;", "private final")]
	public Dova.JDK.com.sun.media.sound.SoftMixingDataLine.Pan pan_control_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine.Pan>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$ReverbSend;", "private final")]
	public Dova.JDK.com.sun.media.sound.SoftMixingDataLine.ReverbSend reverbsend_control_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine.ReverbSend>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$ChorusSend;", "private final")]
	public Dova.JDK.com.sun.media.sound.SoftMixingDataLine.ChorusSend chorussend_control_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine.ChorusSend>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$ApplyReverb;", "private final")]
	public Dova.JDK.com.sun.media.sound.SoftMixingDataLine.ApplyReverb apply_reverb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine.ApplyReverb>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/sound/sampled/Control;", "private final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Control> controls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Control>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("F", "")]
	public float leftgain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("F", "")]
	public float rightgain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("F", "")]
	public float eff1gain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("F", "")]
	public float eff2gain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List listeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object control_mutex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingMixer;", "")]
	public Dova.JDK.com.sun.media.sound.SoftMixingMixer mixer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingMixer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/sound/sampled/DataLine$Info;", "")]
	public Dova.JDK.javax.sound.sampled.DataLine.Info info_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.DataLine.Info>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SoftMixingDataLine(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SoftMixingMixer;Ljavax/sound/sampled/DataLine$Info;)V", "")]
	public SoftMixingDataLine(Dova.JDK.com.sun.media.sound.SoftMixingMixer arg0, Dova.JDK.javax.sound.sampled.DataLine.Info arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/sampled/Control$Type;)Ljavax/sound/sampled/Control;", "public final")]
	public Dova.JDK.javax.sound.sampled.Control getControl(Dova.JDK.javax.sound.sampled.Control.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Control>(ret);
	}

	[JniSignatureAttribute("()V", "final")]
	public void calcVolume()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void processControlLogic()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("([Lcom/sun/media/sound/SoftAudioBuffer;)V", "protected abstract")]
	public void processAudioLogic(JavaArray<Dova.JDK.com.sun.media.sound.SoftAudioBuffer> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Ljavax/sound/sampled/Line$Info;", "public final")]
	public Dova.JDK.javax.sound.sampled.Line.Info getLineInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Line.Info>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/Control;", "public final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Control> getControls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Control>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Control$Type;)Z", "public final")]
	public bool isControlSupported(Dova.JDK.javax.sound.sampled.Control.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/LineListener;)V", "public final")]
	public void addLineListener(Dova.JDK.javax.sound.sampled.LineListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/LineListener;)V", "public final")]
	public void removeLineListener(Dova.JDK.javax.sound.sampled.LineListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/LineEvent;)V", "final")]
	public void sendEvent(Dova.JDK.javax.sound.sampled.LineEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$Gain;", "private final")]
	public partial class Gain
		: Dova.JDK.javax.sound.sampled.FloatControl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Gain()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine$Gain;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/media/sound/SoftMixingDataLine;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/SoftMixingDataLine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(F)V"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine;", "final")]
		public Dova.JDK.com.sun.media.sound.SoftMixingDataLine this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Gain(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/SoftMixingDataLine;)V", "private")]
		public Gain(Dova.JDK.com.sun.media.sound.SoftMixingDataLine arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine$Gain;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(F)V", "public")]
		public void setValue(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$Mute;", "private final")]
	public partial class Mute
		: Dova.JDK.javax.sound.sampled.BooleanControl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Mute()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine$Mute;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/media/sound/SoftMixingDataLine;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/SoftMixingDataLine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Z)V"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine;", "final")]
		public Dova.JDK.com.sun.media.sound.SoftMixingDataLine this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Mute(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/SoftMixingDataLine;)V", "private")]
		public Mute(Dova.JDK.com.sun.media.sound.SoftMixingDataLine arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine$Mute;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Z)V", "public")]
		public void setValue(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$Balance;", "private final")]
	public partial class Balance
		: Dova.JDK.javax.sound.sampled.FloatControl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Balance()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine$Balance;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/media/sound/SoftMixingDataLine;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/SoftMixingDataLine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(F)V"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine;", "final")]
		public Dova.JDK.com.sun.media.sound.SoftMixingDataLine this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Balance(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/SoftMixingDataLine;)V", "private")]
		public Balance(Dova.JDK.com.sun.media.sound.SoftMixingDataLine arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine$Balance;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(F)V", "public")]
		public void setValue(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$Pan;", "private final")]
	public partial class Pan
		: Dova.JDK.javax.sound.sampled.FloatControl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Pan()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine$Pan;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/media/sound/SoftMixingDataLine;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/SoftMixingDataLine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(F)V"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine;", "final")]
		public Dova.JDK.com.sun.media.sound.SoftMixingDataLine this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Pan(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/SoftMixingDataLine;)V", "private")]
		public Pan(Dova.JDK.com.sun.media.sound.SoftMixingDataLine arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine$Pan;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()F", "public")]
		public float getValue()
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(F)V", "public")]
		public void setValue(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$ReverbSend;", "private final")]
	public partial class ReverbSend
		: Dova.JDK.javax.sound.sampled.FloatControl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReverbSend()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine$ReverbSend;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/media/sound/SoftMixingDataLine;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/SoftMixingDataLine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(F)V"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine;", "final")]
		public Dova.JDK.com.sun.media.sound.SoftMixingDataLine this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReverbSend(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/SoftMixingDataLine;)V", "private")]
		public ReverbSend(Dova.JDK.com.sun.media.sound.SoftMixingDataLine arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine$ReverbSend;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(F)V", "public")]
		public void setValue(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$ChorusSend;", "private final")]
	public partial class ChorusSend
		: Dova.JDK.javax.sound.sampled.FloatControl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChorusSend()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine$ChorusSend;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/media/sound/SoftMixingDataLine;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/SoftMixingDataLine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(F)V"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine;", "final")]
		public Dova.JDK.com.sun.media.sound.SoftMixingDataLine this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChorusSend(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/SoftMixingDataLine;)V", "private")]
		public ChorusSend(Dova.JDK.com.sun.media.sound.SoftMixingDataLine arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine$ChorusSend;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(F)V", "public")]
		public void setValue(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$ApplyReverb;", "private final")]
	public partial class ApplyReverb
		: Dova.JDK.javax.sound.sampled.BooleanControl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ApplyReverb()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine$ApplyReverb;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/media/sound/SoftMixingDataLine;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/SoftMixingDataLine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Z)V"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine;", "final")]
		public Dova.JDK.com.sun.media.sound.SoftMixingDataLine this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftMixingDataLine>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ApplyReverb(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/SoftMixingDataLine;)V", "private")]
		public ApplyReverb(Dova.JDK.com.sun.media.sound.SoftMixingDataLine arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine$ApplyReverb;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Z)V", "public")]
		public void setValue(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftMixingDataLine$AudioFloatInputStreamResampler;", "protected static final")]
	public partial class AudioFloatInputStreamResampler
		: Dova.JDK.com.sun.media.sound.AudioFloatInputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatInputStreamResampler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftMixingDataLine$AudioFloatInputStreamResampler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ais", "Lcom/sun/media/sound/AudioFloatInputStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetFormat", "Ljavax/sound/sampled/AudioFormat;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "skipbuffer", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resampler", "Lcom/sun/media/sound/SoftAbstractResampler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pitch", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ibuffer2", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ibuffer", "[[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ibuffer_index", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ibuffer_len", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nrofchannels", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbuffer", "[[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer_len", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pad", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pad2", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ix", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ox", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mark_ibuffer", "[[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mark_ibuffer_index", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mark_ibuffer_len", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/AudioFloatInputStream;Ljavax/sound/sampled/AudioFormat;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([FII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "available", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markSupported", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFormat", "()Ljavax/sound/sampled/AudioFormat;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readNextBuffer", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameLength", "()J"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatInputStream;", "private final")]
		public Dova.JDK.com.sun.media.sound.AudioFloatInputStream ais_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AudioFloatInputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/sound/sampled/AudioFormat;", "private final")]
		public Dova.JDK.javax.sound.sampled.AudioFormat targetFormat_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[F", "private")]
		public JavaArray<float> skipbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftAbstractResampler;", "private")]
		public Dova.JDK.com.sun.media.sound.SoftAbstractResampler resampler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftAbstractResampler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[F", "private final")]
		public JavaArray<float> pitch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[F", "private final")]
		public JavaArray<float> ibuffer2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[[F", "private final")]
		public JavaArray<JavaArray<float>> ibuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<float>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float ibuffer_index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int ibuffer_len_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int nrofchannels_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("[[F", "private")]
		public JavaArray<JavaArray<float>> cbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<float>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int buffer_len_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int pad_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int pad2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("[F", "private final")]
		public JavaArray<float> ix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "private final")]
		public JavaArray<int> ox_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[[F", "private")]
		public JavaArray<JavaArray<float>> mark_ibuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<float>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float mark_ibuffer_index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int mark_ibuffer_len_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatInputStreamResampler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/AudioFloatInputStream;Ljavax/sound/sampled/AudioFormat;)V", "public")]
		public AudioFloatInputStreamResampler(Dova.JDK.com.sun.media.sound.AudioFloatInputStream arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftMixingDataLine$AudioFloatInputStreamResampler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII)I", "public")]
		public int read(JavaArray<float> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void mark(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(J)J", "public")]
		public long skip(long arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int available()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool markSupported()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()Ljavax/sound/sampled/AudioFormat;", "public")]
		public Dova.JDK.javax.sound.sampled.AudioFormat getFormat()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void readNextBuffer()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("()J", "public")]
		public long getFrameLength()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}
	}
}
