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

[JniSignatureAttribute("Lcom/sun/media/sound/ModelDestination;", "public final")]
public partial class ModelDestination
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModelDestination()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/ModelDestination;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_NONE", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_KEYNUMBER", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_VELOCITY", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_PITCH", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_GAIN", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_PAN", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_REVERB", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_CHORUS", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_LFO1_DELAY", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_LFO1_FREQ", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_LFO2_DELAY", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_LFO2_FREQ", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG1_DELAY", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG1_ATTACK", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG1_HOLD", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG1_DECAY", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG1_SUSTAIN", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG1_RELEASE", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG1_SHUTDOWN", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG2_DELAY", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG2_ATTACK", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG2_HOLD", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG2_DECAY", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG2_SUSTAIN", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG2_RELEASE", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_EG2_SHUTDOWN", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_FILTER_FREQ", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTINATION_FILTER_Q", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "destination", "Lcom/sun/media/sound/ModelIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transform", "Lcom/sun/media/sound/ModelTransform;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/ModelIdentifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIdentifier", "(Lcom/sun/media/sound/ModelIdentifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifier", "()Lcom/sun/media/sound/ModelIdentifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransform", "()Lcom/sun/media/sound/ModelTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTransform", "(Lcom/sun/media/sound/ModelTransform;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_NONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_KEYNUMBER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_VELOCITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_PITCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_GAIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_PAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_REVERB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_CHORUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_LFO1_DELAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_LFO1_FREQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_LFO2_DELAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_LFO2_FREQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG1_DELAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG1_ATTACK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG1_HOLD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG1_DECAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG1_SUSTAIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG1_RELEASE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG1_SHUTDOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG2_DELAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG2_ATTACK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG2_HOLD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG2_DECAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG2_SUSTAIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG2_RELEASE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_EG2_SHUTDOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_FILTER_FREQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "public static final")]
	public static Dova.JDK.com.sun.media.sound.ModelIdentifier DESTINATION_FILTER_Q_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelIdentifier;", "private")]
	public Dova.JDK.com.sun.media.sound.ModelIdentifier destination_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelTransform;", "private")]
	public Dova.JDK.com.sun.media.sound.ModelTransform transform_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ModelDestination(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ModelDestination() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelIdentifier;)V", "public")]
	public ModelDestination(Dova.JDK.com.sun.media.sound.ModelIdentifier arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/ModelDestination;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelIdentifier;)V", "public")]
	public void setIdentifier(Dova.JDK.com.sun.media.sound.ModelIdentifier arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/media/sound/ModelIdentifier;", "public")]
	public Dova.JDK.com.sun.media.sound.ModelIdentifier getIdentifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelIdentifier>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/media/sound/ModelTransform;", "public")]
	public Dova.JDK.com.sun.media.sound.ModelTransform getTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelTransform>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelTransform;)V", "public")]
	public void setTransform(Dova.JDK.com.sun.media.sound.ModelTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}
}
