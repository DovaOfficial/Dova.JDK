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

[JniSignatureAttribute("Lcom/sun/media/sound/SoftFilter;", "public final")]
public partial class SoftFilter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SoftFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/SoftFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILTERTYPE_LP6", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILTERTYPE_LP12", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILTERTYPE_HP12", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILTERTYPE_BP12", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILTERTYPE_NP12", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILTERTYPE_LP24", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILTERTYPE_HP24", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filtertype", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "samplerate", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x1", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x2", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y1", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y2", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xx1", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xx2", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yy1", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yy2", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "a0", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "a1", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "a2", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "b1", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "b2", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "q", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wet", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_wet", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_a0", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_a1", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_a2", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_b1", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_b2", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_q", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_gain", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last_set", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cutoff", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resonancedB", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirty", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sinh", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processAudio", "(Lcom/sun/media/sound/SoftAudioBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter1", "(Lcom/sun/media/sound/SoftAudioBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter2", "(Lcom/sun/media/sound/SoftAudioBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter4", "(Lcom/sun/media/sound/SoftAudioBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter2calc", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter1calc", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFrequency", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setResonance", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFilterType", "(I)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FILTERTYPE_LP6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FILTERTYPE_LP12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FILTERTYPE_HP12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FILTERTYPE_BP12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FILTERTYPE_NP12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FILTERTYPE_LP24_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FILTERTYPE_HP24_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int filtertype_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("F", "private final")]
	public float samplerate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float x1_Property
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

	[JniSignatureAttribute("F", "private")]
	public float x2_Property
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

	[JniSignatureAttribute("F", "private")]
	public float y1_Property
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

	[JniSignatureAttribute("F", "private")]
	public float y2_Property
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

	[JniSignatureAttribute("F", "private")]
	public float xx1_Property
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
	public float xx2_Property
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
	public float yy1_Property
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
	public float yy2_Property
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
	public float a0_Property
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

	[JniSignatureAttribute("F", "private")]
	public float a1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float a2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float b1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float b2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float q_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float gain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float wet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float last_wet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float last_a0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float last_a1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float last_a2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float last_b1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float last_b2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float last_q_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float last_gain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool last_set_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double cutoff_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double resonancedB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool dirty_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SoftFilter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(F)V", "public")]
	public SoftFilter(float arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SoftFilter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(D)D", "private")]
	public double sinh(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SoftAudioBuffer;)V", "public")]
	public void processAudio(Dova.JDK.com.sun.media.sound.SoftAudioBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SoftAudioBuffer;)V", "public")]
	public void filter1(Dova.JDK.com.sun.media.sound.SoftAudioBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SoftAudioBuffer;)V", "public")]
	public void filter2(Dova.JDK.com.sun.media.sound.SoftAudioBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/SoftAudioBuffer;)V", "public")]
	public void filter4(Dova.JDK.com.sun.media.sound.SoftAudioBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void filter2calc()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void filter1calc()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(D)V", "public")]
	public void setFrequency(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(D)V", "public")]
	public void setResonance(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setFilterType(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}
}
