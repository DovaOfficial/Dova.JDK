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

[JniSignatureAttribute("Lcom/sun/media/sound/MidiOutDeviceProvider;", "public final")]
public partial class MidiOutDeviceProvider
	: Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MidiOutDeviceProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/MidiOutDeviceProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "infos", "[Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "devices", "[Ljavax/sound/midi/MidiDevice;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "enabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nGetNumDevices", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nGetName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nGetVendor", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nGetDescription", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nGetVersion", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInfoCache", "()[Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeviceCache", "()[Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInfoCache", "([Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDeviceCache", "([Ljavax/sound/midi/MidiDevice;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumDevices", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createInfo", "(I)Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDevice", "(Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;)Ljavax/sound/midi/MidiDevice;"));
	}

	[JniSignatureAttribute("[Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info> infos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/sound/midi/MidiDevice;", "private static")]
	public static JavaArray<Dova.JDK.javax.sound.midi.MidiDevice> devices_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.MidiDevice>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool enabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MidiOutDeviceProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MidiOutDeviceProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/MidiOutDeviceProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "private static native")]
	public static int nGetNumDevices()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String nGetName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String nGetVendor(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String nGetDescription(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String nGetVersion(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;", "")]
	public JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info> getInfoCache()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/midi/MidiDevice;", "")]
	public JavaArray<Dova.JDK.javax.sound.midi.MidiDevice> getDeviceCache()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.MidiDevice>>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;)V", "")]
	public void setInfoCache(JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("([Ljavax/sound/midi/MidiDevice;)V", "")]
	public void setDeviceCache(JavaArray<Dova.JDK.javax.sound.midi.MidiDevice> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()I", "")]
	public int getNumDevices()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;", "")]
	public Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info createInfo(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;)Ljavax/sound/midi/MidiDevice;", "")]
	public Dova.JDK.javax.sound.midi.MidiDevice createDevice(Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/MidiOutDeviceProvider$MidiOutDeviceInfo;", "static final")]
	public partial class MidiOutDeviceInfo
		: Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MidiOutDeviceInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/MidiOutDeviceProvider$MidiOutDeviceInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "providerClass", "Ljava/lang/Class;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Class;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class providerClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MidiOutDeviceInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Class;)V", "private")]
		public MidiOutDeviceInfo(int arg0, Dova.JDK.java.lang.Class arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/MidiOutDeviceProvider$MidiOutDeviceInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
