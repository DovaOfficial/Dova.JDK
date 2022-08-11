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

[JniSignatureAttribute("Lcom/sun/media/sound/SoftChorus;", "public final")]
public partial class SoftChorus
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.media.sound.SoftAudioProcessor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SoftChorus()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftChorus;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mix", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputA", "Lcom/sun/media/sound/SoftAudioBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "left", "Lcom/sun/media/sound/SoftAudioBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "right", "Lcom/sun/media/sound/SoftAudioBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reverb", "Lcom/sun/media/sound/SoftAudioBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vdelay1L", "Lcom/sun/media/sound/SoftChorus$LFODelay;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vdelay1R", "Lcom/sun/media/sound/SoftChorus$LFODelay;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rgain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty_vdelay1L_rate", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty_vdelay1R_rate", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty_vdelay1L_depth", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty_vdelay1R_depth", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty_vdelay1L_feedback", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty_vdelay1R_feedback", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty_vdelay1L_reverbsendgain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty_vdelay1R_reverbsendgain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "controlrate", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "silentcounter", "D"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInput", "(ILcom/sun/media/sound/SoftAudioBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "globalParameterControlChange", "([IJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMixMode", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processAudio", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processControlLogic", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutput", "(ILcom/sun/media/sound/SoftAudioBuffer;)V"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool mix_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftAudioBuffer;", "private")]
	public Dova.JDK.com.sun.media.sound.SoftAudioBuffer inputA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftAudioBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftAudioBuffer;", "private")]
	public Dova.JDK.com.sun.media.sound.SoftAudioBuffer left_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftAudioBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftAudioBuffer;", "private")]
	public Dova.JDK.com.sun.media.sound.SoftAudioBuffer right_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftAudioBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftAudioBuffer;", "private")]
	public Dova.JDK.com.sun.media.sound.SoftAudioBuffer reverb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftAudioBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftChorus$LFODelay;", "private")]
	public Dova.JDK.com.sun.media.sound.SoftChorus.LFODelay vdelay1L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftChorus.LFODelay>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftChorus$LFODelay;", "private")]
	public Dova.JDK.com.sun.media.sound.SoftChorus.LFODelay vdelay1R_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftChorus.LFODelay>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float rgain_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool dirty_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double dirty_vdelay1L_rate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double dirty_vdelay1R_rate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double dirty_vdelay1L_depth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double dirty_vdelay1R_depth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float dirty_vdelay1L_feedback_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float dirty_vdelay1R_feedback_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float dirty_vdelay1L_reverbsendgain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float dirty_vdelay1R_reverbsendgain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float controlrate_Property
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

	[JniSignatureAttribute("D", "")]
	public double silentcounter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SoftChorus(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SoftChorus() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftChorus;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(FF)V", "public")]
	public void init(float arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(ILcom/sun/media/sound/SoftAudioBuffer;)V", "public")]
	public void setInput(int arg0, Dova.JDK.com.sun.media.sound.SoftAudioBuffer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("([IJJ)V", "public")]
	public void globalParameterControlChange(JavaArray<int> arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setMixMode(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void processAudio()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void processControlLogic()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(ILcom/sun/media/sound/SoftAudioBuffer;)V", "public")]
	public void setOutput(int arg0, Dova.JDK.com.sun.media.sound.SoftAudioBuffer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftChorus$LFODelay;", "private static")]
	public partial class LFODelay
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LFODelay()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftChorus$LFODelay;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "phase", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "phase_step", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depth", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vdelay", "Lcom/sun/media/sound/SoftChorus$VariableDelay;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "samplerate", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "controlrate", "D"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(DD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGain", "(F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPhase", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRate", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDepth", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeedBack", "(F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReverbSendGain", "(F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMix", "([F[F[F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processReplace", "([F[F[F)V"));
		}

		[JniSignatureAttribute("D", "private")]
		public double phase_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("D", "private")]
		public double phase_step_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("D", "private")]
		public double depth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/SoftChorus$VariableDelay;", "private")]
		public Dova.JDK.com.sun.media.sound.SoftChorus.VariableDelay vdelay_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.SoftChorus.VariableDelay>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("D", "private final")]
		public double samplerate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("D", "private final")]
		public double controlrate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LFODelay(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(DD)V", "")]
		public LFODelay(double arg0, double arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftChorus$LFODelay;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(F)V", "public")]
		public void setGain(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void setPhase(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void setRate(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void setDepth(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(F)V", "public")]
		public void setFeedBack(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(F)V", "public")]
		public void setReverbSendGain(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("([F[F[F)V", "public")]
		public void processMix(JavaArray<float> arg0, JavaArray<float> arg1, JavaArray<float> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([F[F[F)V", "public")]
		public void processReplace(JavaArray<float> arg0, JavaArray<float> arg1, JavaArray<float> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/SoftChorus$VariableDelay;", "private static")]
	public partial class VariableDelay
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static VariableDelay()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftChorus$VariableDelay;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delaybuffer", "[F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rovepos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gain", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rgain", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delay", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastdelay", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "feedback", "F"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGain", "(F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeedBack", "(F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReverbSendGain", "(F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMix", "([F[F[F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processReplace", "([F[F[F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDelay", "(F)V"));
		}

		[JniSignatureAttribute("[F", "private final")]
		public JavaArray<float> delaybuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int rovepos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float gain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float rgain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float delay_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float lastdelay_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float feedback_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public VariableDelay(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public VariableDelay(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftChorus$VariableDelay;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(F)V", "public")]
		public void setGain(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(F)V", "public")]
		public void setFeedBack(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(F)V", "public")]
		public void setReverbSendGain(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("([F[F[F)V", "public")]
		public void processMix(JavaArray<float> arg0, JavaArray<float> arg1, JavaArray<float> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([F[F[F)V", "public")]
		public void processReplace(JavaArray<float> arg0, JavaArray<float> arg1, JavaArray<float> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(F)V", "public")]
		public void setDelay(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}
}
