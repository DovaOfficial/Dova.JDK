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

namespace Dova.JDK.sun.java2d;

[JniSignatureAttribute("Lsun/java2d/SunGraphicsEnvironment;", "public abstract")]
public partial class SunGraphicsEnvironment
	: Dova.JDK.java.awt.GraphicsEnvironment
	, Dova.JDK.sun.awt.DisplayChangedListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SunGraphicsEnvironment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/SunGraphicsEnvironment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultFont", "Ljava/awt/Font;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiScaleEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debugScale", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "screens", "[Ljava/awt/GraphicsDevice;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "displayChanger", "Lsun/awt/SunDisplayChanger;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDisplayChangedListener", "(Lsun/awt/DisplayChangedListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumScreens", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeScreenDevice", "(I)Ljava/awt/GraphicsDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paletteChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFontManagerForSGE", "()Lsun/font/FontManagerForSGE;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "useAlternateFontforJALocales", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getGraphicsConfigurationAtPoint", "(Ljava/awt/GraphicsConfiguration;DD)Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toDeviceSpaceAbs", "(II)Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toDeviceSpaceAbs", "(Ljava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toDeviceSpaceAbs", "(Ljava/awt/GraphicsConfiguration;IIII)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toDeviceSpace", "(Ljava/awt/GraphicsConfiguration;IIII)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toDeviceSpace", "(II)Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDisplayChangedListener", "(Lsun/awt/DisplayChangedListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUIScaleEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDebugScale", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getGCDeviceBounds", "(Ljava/awt/GraphicsConfiguration;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUserSpace", "(Ljava/awt/GraphicsConfiguration;II)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFlipStrategyPreferred", "(Ljava/awt/peer/ComponentPeer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultScreenDevice", "()Ljava/awt/GraphicsDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createGraphics", "(Ljava/awt/image/BufferedImage;)Ljava/awt/Graphics2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUsableBounds", "(Ljava/awt/GraphicsDevice;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScreenDevices", "()[Ljava/awt/GraphicsDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllFonts", "()[Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableFontFamilyNames", "(Ljava/util/Locale;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableFontFamilyNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDisplayLocal", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getScaleFactor", "(Ljava/lang/String;)D"));
	}

	[JniSignatureAttribute("Ljava/awt/Font;", "private final")]
	public Dova.JDK.java.awt.Font defaultFont_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool uiScaleEnabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double debugScale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("[Ljava/awt/GraphicsDevice;", "protected")]
	public JavaArray<Dova.JDK.java.awt.GraphicsDevice> screens_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.GraphicsDevice>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/SunDisplayChanger;", "protected")]
	public Dova.JDK.sun.awt.SunDisplayChanger displayChanger_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.SunDisplayChanger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SunGraphicsEnvironment(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SunGraphicsEnvironment() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/SunGraphicsEnvironment;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/DisplayChangedListener;)V", "public")]
	public void addDisplayChangedListener(Dova.JDK.sun.awt.DisplayChangedListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()I", "protected abstract")]
	public int getNumScreens()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/awt/GraphicsDevice;", "protected abstract")]
	public Dova.JDK.java.awt.GraphicsDevice makeScreenDevice(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsDevice>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void paletteChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Lsun/font/FontManagerForSGE;", "public static")]
	public static Dova.JDK.sun.font.FontManagerForSGE getFontManagerForSGE()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.FontManagerForSGE>(ret);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void useAlternateFontforJALocales()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;DD)Ljava/awt/GraphicsConfiguration;", "public static")]
	public static Dova.JDK.java.awt.GraphicsConfiguration getGraphicsConfigurationAtPoint(Dova.JDK.java.awt.GraphicsConfiguration arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Point;", "public static")]
	public static Dova.JDK.java.awt.Point toDeviceSpaceAbs(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle toDeviceSpaceAbs(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;IIII)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle toDeviceSpaceAbs(Dova.JDK.java.awt.GraphicsConfiguration arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;IIII)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle toDeviceSpace(Dova.JDK.java.awt.GraphicsConfiguration arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Point;", "public static")]
	public static Dova.JDK.java.awt.Point toDeviceSpace(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/DisplayChangedListener;)V", "public")]
	public void removeDisplayChangedListener(Dova.JDK.sun.awt.DisplayChangedListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isUIScaleEnabled()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public static")]
	public static double getDebugScale()
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle getGCDeviceBounds(Dova.JDK.java.awt.GraphicsConfiguration arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;II)Ljava/awt/Dimension;", "public static")]
	public static Dova.JDK.java.awt.Dimension toUserSpace(Dova.JDK.java.awt.GraphicsConfiguration arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void displayChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("(Ljava/awt/peer/ComponentPeer;)Z", "public")]
	public bool isFlipStrategyPreferred(Dova.JDK.java.awt.peer.ComponentPeer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsDevice;", "public")]
	public Dova.JDK.java.awt.GraphicsDevice getDefaultScreenDevice()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsDevice>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)Ljava/awt/Graphics2D;", "public")]
	public Dova.JDK.java.awt.Graphics2D createGraphics(Dova.JDK.java.awt.image.BufferedImage arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsDevice;)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle getUsableBounds(Dova.JDK.java.awt.GraphicsDevice arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/GraphicsDevice;", "public synchronized")]
	public JavaArray<Dova.JDK.java.awt.GraphicsDevice> getScreenDevices()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.GraphicsDevice>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/Font;", "public")]
	public JavaArray<Dova.JDK.java.awt.Font> getAllFonts()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Font>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getAvailableFontFamilyNames(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getAvailableFontFamilyNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isDisplayLocal()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)D", "public static")]
	public static double getScaleFactor(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return ret;
	}
}
