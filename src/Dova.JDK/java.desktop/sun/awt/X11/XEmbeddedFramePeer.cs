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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XEmbeddedFramePeer;", "public")]
public partial class XEmbeddedFramePeer
	: Dova.JDK.sun.awt.X11.XFramePeer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XEmbeddedFramePeer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XEmbeddedFramePeer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "xembedLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strokes", "Ljava/util/LinkedList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "embedder", "Lsun/awt/X11/XEmbedClientHelper;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/EmbeddedFrame;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getState", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOpaque", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setState", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isXEmbedActive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParentWindowHandle", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notifyStarted", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notifyStopped", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseOutForward", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseOutBackward", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "synthesizeFocusInOut", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMaximizedBounds", "(Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOpacity", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateIconImages", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateMinimumSize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateFocusableWindowState", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setModalBlocked", "(Ljava/awt/Dialog;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setModalBlocked", "(Ljava/awt/Dialog;ZLjava/util/Vector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAlwaysOnTopState", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateWindow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addToplevelStateListener", "(Lsun/awt/X11/ToplevelStateListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerPeer", "()Lsun/awt/X11/XWindowPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recursivelySetIcon", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkIfOnNewScreen", "(Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleWindowFocusIn", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleWindowFocusOut", "(Ljava/awt/Window;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestInitialFocus", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isGrabbed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleWindowFocusInSync", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetMinimumSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleIconify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDeiconify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleStateChange", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFocusTargetWindow", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleWindowFocusIn_Dispatch", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleWindowFocusOutSync", "(Ljava/awt/Window;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleFocusEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeToplevelStateListener", "(Lsun/awt/X11/ToplevelStateListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBoundsPrivate", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoundsPrivate", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emulateActivation", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repositionSecurityWarning", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsXEmbed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerAccelerator", "(Ljava/awt/AWTKeyStroke;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterAccelerator", "(Ljava/awt/AWTKeyStroke;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestWindowFocus", "(JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestWindowFocus", "(Lsun/awt/X11/XWindowPeer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestWindowFocus", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentWindow", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGrab", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paletteChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setResizable", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preInit", "(Lsun/awt/X11/XCreateWindowParams;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postInit", "(Lsun/awt/X11/XCreateWindowParams;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEventDisabled", "(Lsun/awt/X11/XEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleButtonPressRelease", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleMotionNotify", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleXCrossingEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleConfigureNotifyEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleMapNotifyEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleUnmapNotifyEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handlePropertyNotify", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAbsoluteX", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAbsoluteY", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleVisibilityEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleClientMessage", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleReparentNotifyEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateSecurityWarningVisibility", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNETWMState", "()Lsun/awt/X11/XAtomList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNETWMState", "(Lsun/awt/X11/XAtomList;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFullScreenExclusiveModeState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWMName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMWMHints", "()Lsun/awt/X11/PropMwmHints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMWMHints", "(Lsun/awt/X11/PropMwmHints;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "xSetVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShell", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDropTarget", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDropTarget", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFront", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMenuBar", "(Ljava/awt/MenuBar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTitle", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toBack", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphics", "()Ljava/awt/Graphics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInsets", "()Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "()Ljava/awt/Point;"));
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger xembedLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/LinkedList;", "")]
	public Dova.JDK.java.util.LinkedList strokes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XEmbedClientHelper;", "")]
	public Dova.JDK.sun.awt.X11.XEmbedClientHelper embedder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XEmbedClientHelper>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XEmbeddedFramePeer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/EmbeddedFrame;)V", "public")]
	public XEmbeddedFramePeer(Dova.JDK.sun.awt.EmbeddedFrame arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XEmbeddedFramePeer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Point;", "public volatile")]
	public Dova.JDK.java.awt.Point getLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("()I", "public volatile")]
	public int getState()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public volatile")]
	public void print(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public volatile")]
	public void setOpaque(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(I)V", "public volatile")]
	public void setState(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isXEmbedActive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()J", "final")]
	public long getParentWindowHandle()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void notifyStarted()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "")]
	public void notifyStopped()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void traverseOutForward()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void traverseOutBackward()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void synthesizeFocusInOut(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public volatile")]
	public void setMaximizedBounds(Dova.JDK.java.awt.Rectangle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(F)V", "public volatile")]
	public void setOpacity(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void updateIconImages()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateMinimumSize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void updateFocusableWindowState()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;Z)V", "public")]
	public void setModalBlocked(Dova.JDK.java.awt.Dialog arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;ZLjava/util/Vector;)V", "public volatile")]
	public void setModalBlocked(Dova.JDK.java.awt.Dialog arg0, bool arg1, Dova.JDK.java.util.Vector arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void updateAlwaysOnTopState()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void updateWindow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/ToplevelStateListener;)V", "public volatile")]
	public void addToplevelStateListener(Dova.JDK.sun.awt.X11.ToplevelStateListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XWindowPeer;", "public volatile")]
	public Dova.JDK.sun.awt.X11.XWindowPeer getOwnerPeer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XWindowPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public volatile")]
	public void recursivelySetIcon(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public volatile")]
	public void checkIfOnNewScreen(Dova.JDK.java.awt.Rectangle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(J)V", "public volatile")]
	public void handleWindowFocusIn(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;J)V", "public volatile")]
	public void handleWindowFocusOut(Dova.JDK.java.awt.Window arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void requestInitialFocus()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30]);
	}

	[JniSignatureAttribute("()Z", "public volatile")]
	public bool isGrabbed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public volatile")]
	public void handleWindowFocusInSync(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public volatile")]
	public Dova.JDK.java.awt.Dimension getTargetMinimumSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void handleIconify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void handleDeiconify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35]);
	}

	[JniSignatureAttribute("(II)V", "public volatile")]
	public void handleStateChange(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
	}

	[JniSignatureAttribute("()J", "")]
	public long getFocusTargetWindow()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void handleWindowFocusIn_Dispatch()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38]);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;J)V", "public volatile")]
	public void handleWindowFocusOutSync(Dova.JDK.java.awt.Window arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleFocusEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/ToplevelStateListener;)V", "public volatile")]
	public void removeToplevelStateListener(Dova.JDK.sun.awt.X11.ToplevelStateListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void setBoundsPrivate(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getBoundsPrivate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public volatile")]
	public void emulateActivation(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void repositionSecurityWarning()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45]);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool supportsXEmbed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTKeyStroke;)V", "")]
	public void registerAccelerator(Dova.JDK.java.awt.AWTKeyStroke arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTKeyStroke;)V", "")]
	public void unregisterAccelerator(Dova.JDK.java.awt.AWTKeyStroke arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(JZ)Z", "public")]
	public bool requestWindowFocus(long arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;)Z", "public volatile")]
	public bool requestWindowFocus(Dova.JDK.sun.awt.X11.XWindowPeer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public volatile")]
	public bool requestWindowFocus()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public volatile")]
	public long getContentWindow()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[52]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public volatile")]
	public void setGrab(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void displayChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54]);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void paletteChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55]);
	}

	[JniSignatureAttribute("(Z)V", "public volatile")]
	public void setResizable(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public volatile")]
	public void setVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getWidth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[58]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHeight()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[59]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XCreateWindowParams;)V", "public")]
	public void preInit(Dova.JDK.sun.awt.X11.XCreateWindowParams arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XCreateWindowParams;)V", "")]
	public void postInit(Dova.JDK.sun.awt.X11.XCreateWindowParams arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)Z", "protected")]
	public bool isEventDisabled(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleButtonPressRelease(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleMotionNotify(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleXCrossingEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public")]
	public void handleConfigureNotifyEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleMapNotifyEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleUnmapNotifyEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handlePropertyNotify(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAbsoluteX()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[70]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAbsoluteY()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[71]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleVisibilityEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleClientMessage(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleReparentNotifyEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void updateSecurityWarningVisibility()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75]);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XAtomList;", "public volatile")]
	public Dova.JDK.sun.awt.X11.XAtomList getNETWMState()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtomList>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XAtomList;)V", "public volatile")]
	public void setNETWMState(Dova.JDK.sun.awt.X11.XAtomList arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public volatile")]
	public void setFullScreenExclusiveModeState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getWMName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/PropMwmHints;", "public volatile")]
	public Dova.JDK.sun.awt.X11.PropMwmHints getMWMHints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.PropMwmHints>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/PropMwmHints;)V", "public volatile")]
	public void setMWMHints(Dova.JDK.sun.awt.X11.PropMwmHints arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public volatile")]
	public void xSetVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
	}

	[JniSignatureAttribute("()J", "public volatile")]
	public long getShell()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[83]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void addDropTarget()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84]);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void removeDropTarget()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85]);
	}

	[JniSignatureAttribute("()I", "public volatile")]
	public int getX()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[86]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public volatile")]
	public int getY()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[87]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void toFront()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[88]);
	}

	[JniSignatureAttribute("(Ljava/awt/MenuBar;)V", "public volatile")]
	public void setMenuBar(Dova.JDK.java.awt.MenuBar arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public volatile")]
	public void setTitle(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void toBack()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[91]);
	}

	[JniSignatureAttribute("()Ljava/awt/Graphics;", "public volatile")]
	public Dova.JDK.java.awt.Graphics getGraphics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Insets;", "public volatile")]
	public Dova.JDK.java.awt.Insets getInsets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(IIIII)V", "public volatile")]
	public void setBounds(int arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
	public Dova.JDK.java.awt.Point getLocationOnScreen()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}
}
