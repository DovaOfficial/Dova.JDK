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

[JniSignatureAttribute("Lcom/sun/media/sound/AbstractMixer;", "abstract")]
public partial class AbstractMixer
	: Dova.JDK.com.sun.media.sound.AbstractLine
	, Dova.JDK.javax.sound.sampled.Mixer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractMixer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AbstractMixer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PCM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ULAW", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALAW", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mixerInfo", "Ljavax/sound/sampled/Mixer$Info;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceLineInfo", "[Ljavax/sound/sampled/Line$Info;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetLineInfo", "[Ljavax/sound/sampled/Line$Info;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "started", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manuallyOpened", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceLines", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetLines", "Ljava/util/Vector;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/sound/sampled/Mixer$Info;[Ljavax/sound/sampled/Control;[Ljavax/sound/sampled/Line$Info;[Ljavax/sound/sampled/Line$Info;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "(Ljavax/sound/sampled/Line;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "(Ljavax/sound/sampled/Line;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "(Ljavax/sound/sampled/Line;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "open", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "open", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "open", "(Ljavax/sound/sampled/Line;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implClose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineInfo", "(Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Line$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMixerInfo", "()Ljavax/sound/sampled/Mixer$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceLineInfo", "()[Ljavax/sound/sampled/Line$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceLineInfo", "(Ljavax/sound/sampled/Line$Info;)[Ljavax/sound/sampled/Line$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetLineInfo", "()[Ljavax/sound/sampled/Line$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetLineInfo", "(Ljavax/sound/sampled/Line$Info;)[Ljavax/sound/sampled/Line$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLineSupported", "(Ljavax/sound/sampled/Line$Info;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxLines", "(Ljavax/sound/sampled/Line$Info;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceLines", "()[Ljavax/sound/sampled/Line;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetLines", "()[Ljavax/sound/sampled/Line;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "synchronize", "([Ljavax/sound/sampled/Line;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsynchronize", "([Ljavax/sound/sampled/Line;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynchronizationSupported", "([Ljavax/sound/sampled/Line;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implStart", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implStop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSourceLine", "(Ljavax/sound/sampled/Line$Info;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTargetLine", "(Ljavax/sound/sampled/Line$Info;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLine", "(Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Line;"));
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int PCM_Property
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

	[JniSignatureAttribute("I", "protected static final")]
	public static int ULAW_Property
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

	[JniSignatureAttribute("I", "protected static final")]
	public static int ALAW_Property
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

	[JniSignatureAttribute("Ljavax/sound/sampled/Mixer$Info;", "private final")]
	public Dova.JDK.javax.sound.sampled.Mixer.Info mixerInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Mixer.Info>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/sound/sampled/Line$Info;", "protected")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> sourceLineInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line.Info>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/sound/sampled/Line$Info;", "protected")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> targetLineInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line.Info>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool started_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool manuallyOpened_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private final")]
	public Dova.JDK.java.util.Vector sourceLines_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private final")]
	public Dova.JDK.java.util.Vector targetLines_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractMixer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Mixer$Info;[Ljavax/sound/sampled/Control;[Ljavax/sound/sampled/Line$Info;[Ljavax/sound/sampled/Line$Info;)V", "protected")]
	public AbstractMixer(Dova.JDK.javax.sound.sampled.Mixer.Info arg0, JavaArray<Dova.JDK.javax.sound.sampled.Control> arg1, JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> arg2, JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AbstractMixer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line;)V", "final synchronized")]
	public void start(Dova.JDK.javax.sound.sampled.Line arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line;)V", "final synchronized")]
	public void stop(Dova.JDK.javax.sound.sampled.Line arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line;)V", "final synchronized")]
	public void close(Dova.JDK.javax.sound.sampled.Line arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()V", "public final synchronized")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "public final synchronized")]
	public void open()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Z)V", "final synchronized")]
	public void open(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line;)V", "final synchronized")]
	public void open(Dova.JDK.javax.sound.sampled.Line arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void implClose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Line$Info;", "final")]
	public Dova.JDK.javax.sound.sampled.Line.Info getLineInfo(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Line.Info>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/sampled/Mixer$Info;", "public final")]
	public Dova.JDK.javax.sound.sampled.Mixer.Info getMixerInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Mixer.Info>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/Line$Info;", "public final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> getSourceLineInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)[Ljavax/sound/sampled/Line$Info;", "public final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> getSourceLineInfo(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line.Info>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/Line$Info;", "public final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> getTargetLineInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)[Ljavax/sound/sampled/Line$Info;", "public final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Line.Info> getTargetLineInfo(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line.Info>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)Z", "public final")]
	public bool isLineSupported(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)I", "public abstract")]
	public int getMaxLines(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/Line;", "public final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Line> getSourceLines()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/sampled/Line;", "public final")]
	public JavaArray<Dova.JDK.javax.sound.sampled.Line> getTargetLines()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.sampled.Line>>(ret);
	}

	[JniSignatureAttribute("([Ljavax/sound/sampled/Line;Z)V", "public final")]
	public void synchronize(JavaArray<Dova.JDK.javax.sound.sampled.Line> arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljavax/sound/sampled/Line;)V", "public final")]
	public void unsynchronize(JavaArray<Dova.JDK.javax.sound.sampled.Line> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("([Ljavax/sound/sampled/Line;Z)Z", "public final")]
	public bool isSynchronizationSupported(JavaArray<Dova.JDK.javax.sound.sampled.Line> arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void implOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void implStart()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void implStop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)Z", "final")]
	public bool isSourceLine(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)Z", "final")]
	public bool isTargetLine(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/Line$Info;)Ljavax/sound/sampled/Line;", "public abstract")]
	public Dova.JDK.javax.sound.sampled.Line getLine(Dova.JDK.javax.sound.sampled.Line.Info arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.Line>(ret);
	}
}
