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

namespace Dova.JDK.sun.awt;

[JniSignatureAttribute("Lsun/awt/X11GraphicsDevice;", "public final")]
public partial class X11GraphicsDevice
	: Dova.JDK.java.awt.GraphicsDevice
	, Dova.JDK.sun.awt.DisplayChangedListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static X11GraphicsDevice()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11GraphicsDevice;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "screen", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x11ProxyKeyMap", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fullScreenExclusivePermission", "Ljava/awt/AWTPermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "xrandrExtSupported", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "topLevels", "Lsun/awt/SunDisplayChanger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origDisplayMode", "Ljava/awt/DisplayMode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shutdownHookRegistered", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scale", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configs", "[Ljava/awt/GraphicsConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultConfig", "Ljava/awt/GraphicsConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doubleBufferVisuals", "Ljava/util/HashSet;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scaleUp", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfigurations", "()[Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplay", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDisplayChangedListener", "(Lsun/awt/DisplayChangedListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paletteChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDisplayChangedListener", "(Lsun/awt/DisplayChangedListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scaleDown", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScreen", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initScaleFactor", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pGetBounds", "(I)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeConfigurations", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumConfigs", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDBESupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleBufferVisuals", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfigVisualId", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfigDepth", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfigColormap", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeDefaultConfiguration", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initXrandrExtension", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isXrandrExtensionSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFullScreenSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enterFullScreenExclusive", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enterFullScreenExclusive", "(Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exitFullScreenExclusive", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exitFullScreenExclusive", "(Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDisplayChangeSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDisplayMode", "(Ljava/awt/DisplayMode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFullScreenWindow", "(Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayMode", "()Ljava/awt/DisplayMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCurrentDisplayMode", "(I)Ljava/awt/DisplayMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultDisplayMode", "()Ljava/awt/DisplayMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayModes", "()[Ljava/awt/DisplayMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enumDisplayModes", "(ILjava/util/ArrayList;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatchingDisplayMode", "(Ljava/awt/DisplayMode;)Ljava/awt/DisplayMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "configDisplayMode", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNativeScaleFactor", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeScale", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyKeyFor", "(Lsun/java2d/loops/SurfaceType;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDoubleBufferVisual", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIDstring", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "(Lsun/awt/X11GraphicsDevice;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultConfiguration", "()Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScaleFactor", "()I"));
	}

	[JniSignatureAttribute("I", "private volatile")]
	public int screen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "")]
	public Dova.JDK.java.util.HashMap x11ProxyKeyMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/AWTPermission;", "private static")]
	public static Dova.JDK.java.awt.AWTPermission fullScreenExclusivePermission_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTPermission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private static")]
	public static Dova.JDK.java.lang.Boolean xrandrExtSupported_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object configLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/SunDisplayChanger;", "private")]
	public Dova.JDK.sun.awt.SunDisplayChanger topLevels_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.SunDisplayChanger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/DisplayMode;", "private")]
	public Dova.JDK.java.awt.DisplayMode origDisplayMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.DisplayMode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool shutdownHookRegistered_Property
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

	[JniSignatureAttribute("I", "private")]
	public int scale_Property
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

	[JniSignatureAttribute("[Ljava/awt/GraphicsConfiguration;", "")]
	public JavaArray<Dova.JDK.java.awt.GraphicsConfiguration> configs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.GraphicsConfiguration>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsConfiguration;", "")]
	public Dova.JDK.java.awt.GraphicsConfiguration defaultConfig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashSet;", "")]
	public Dova.JDK.java.util.HashSet doubleBufferVisuals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public X11GraphicsDevice(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public X11GraphicsDevice(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11GraphicsDevice;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int scaleUp(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/awt/GraphicsConfiguration;", "public")]
	public JavaArray<Dova.JDK.java.awt.GraphicsConfiguration> getConfigurations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.GraphicsConfiguration>>(ret);
	}

	[JniSignatureAttribute("()J", "public native")]
	public long getDisplay()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/DisplayChangedListener;)V", "public")]
	public void addDisplayChangedListener(Dova.JDK.sun.awt.DisplayChangedListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void paletteChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Lsun/awt/DisplayChangedListener;)V", "public")]
	public void removeDisplayChangedListener(Dova.JDK.sun.awt.DisplayChangedListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int scaleDown(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getScreen()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int initScaleFactor()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/awt/Rectangle;", "private native")]
	public Dova.JDK.java.awt.Rectangle pGetBounds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void makeConfigurations()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(I)I", "public native")]
	public int getNumConfigs(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static native")]
	public static bool isDBESupported()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private native")]
	public void getDoubleBufferVisuals(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(II)I", "public native")]
	public int getConfigVisualId(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "private native")]
	public int getConfigDepth(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "private native")]
	public int getConfigColormap(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void makeDefaultConfiguration()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()Z", "private static native")]
	public static bool initXrandrExtension()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private static synchronized")]
	public static bool isXrandrExtensionSupported()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFullScreenSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "private static native")]
	public static void enterFullScreenExclusive(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "private static")]
	public static void enterFullScreenExclusive(Dova.JDK.java.awt.Window arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(J)V", "private static native")]
	public static void exitFullScreenExclusive(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "private static")]
	public static void exitFullScreenExclusive(Dova.JDK.java.awt.Window arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDisplayChangeSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/DisplayMode;)V", "public synchronized")]
	public void setDisplayMode(Dova.JDK.java.awt.DisplayMode arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "public synchronized")]
	public void setFullScreenWindow(Dova.JDK.java.awt.Window arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/DisplayMode;", "public synchronized")]
	public Dova.JDK.java.awt.DisplayMode getDisplayMode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.DisplayMode>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/DisplayMode;", "private static native")]
	public static Dova.JDK.java.awt.DisplayMode getCurrentDisplayMode(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.DisplayMode>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/DisplayMode;", "private")]
	public Dova.JDK.java.awt.DisplayMode getDefaultDisplayMode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.DisplayMode>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/DisplayMode;", "public synchronized")]
	public JavaArray<Dova.JDK.java.awt.DisplayMode> getDisplayModes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.DisplayMode>>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/ArrayList;)V", "private static native")]
	public static void enumDisplayModes(int arg0, Dova.JDK.java.util.ArrayList arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/DisplayMode;)Ljava/awt/DisplayMode;", "private synchronized")]
	public Dova.JDK.java.awt.DisplayMode getMatchingDisplayMode(Dova.JDK.java.awt.DisplayMode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.DisplayMode>(ret);
	}

	[JniSignatureAttribute("(IIII)V", "private static native")]
	public static void configDisplayMode(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)D", "private static native")]
	public static double getNativeScaleFactor(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNativeScale()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getProxyKeyFor(Dova.JDK.sun.java2d.loops.SurfaceType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void addDoubleBufferVisual(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void displayChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getIDstring()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11GraphicsDevice;)V", "public")]
	public void invalidate(Dova.JDK.sun.awt.X11GraphicsDevice arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsConfiguration;", "public")]
	public Dova.JDK.java.awt.GraphicsConfiguration getDefaultConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getScaleFactor()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[46]);
		return ret;
	}
}
