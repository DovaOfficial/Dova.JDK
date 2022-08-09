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

[JniSignatureAttribute("Lcom/sun/media/sound/MidiInDeviceProvider;", "public final")]
public partial class MidiInDeviceProvider
	: Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MidiInDeviceProvider()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/media/sound/MidiInDeviceProvider;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "infos", "[Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "devices", "[Ljavax/sound/midi/MidiDevice;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enabled", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MidiInDeviceProvider", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "nGetNumDevices", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "nGetName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "nGetVendor", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "nGetDescription", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "nGetVersion", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getInfoCache", "()[Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDeviceCache", "()[Ljavax/sound/midi/MidiDevice;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setInfoCache", "([Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDeviceCache", "([Ljavax/sound/midi/MidiDevice;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNumDevices", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createInfo", "(I)Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDevice", "(Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;)Ljavax/sound/midi/MidiDevice;"));
	}

	[JniSignatureAttribute("[Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info> infos_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljavax/sound/midi/MidiDevice;", "private static")]
	public static JavaArray<Dova.JDK.javax.sound.midi.MidiDevice> devices_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.MidiDevice>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool enabled_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MidiInDeviceProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MidiInDeviceProvider() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/MidiInDeviceProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "private static native")]
	public static int nGetNumDevices()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String nGetName(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String nGetVendor(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String nGetDescription(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String nGetVersion(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;", "")]
	public JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info> getInfoCache()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/sound/midi/MidiDevice;", "")]
	public JavaArray<Dova.JDK.javax.sound.midi.MidiDevice> getDeviceCache()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.sound.midi.MidiDevice>>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;)V", "")]
	public void setInfoCache(JavaArray<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info> arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("([Ljavax/sound/midi/MidiDevice;)V", "")]
	public void setDeviceCache(JavaArray<Dova.JDK.javax.sound.midi.MidiDevice> arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()I", "")]
	public int getNumDevices()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;", "")]
	public Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info createInfo(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/AbstractMidiDeviceProvider$Info;)Ljavax/sound/midi/MidiDevice;", "")]
	public Dova.JDK.javax.sound.midi.MidiDevice createDevice(Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.MidiDevice>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/MidiInDeviceProvider$MidiInDeviceInfo;", "static final")]
	public partial class MidiInDeviceInfo
		: Dova.JDK.com.sun.media.sound.AbstractMidiDeviceProvider.Info
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MidiInDeviceInfo()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/media/sound/MidiInDeviceProvider$MidiInDeviceInfo;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "providerClass", "Ljava/lang/Class;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MidiInDeviceInfo", "(ILjava/lang/Class;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class providerClass_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MidiInDeviceInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Class;)V", "private")]
		public MidiInDeviceInfo(int arg0, Dova.JDK.java.lang.Class arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/MidiInDeviceProvider$MidiInDeviceInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}