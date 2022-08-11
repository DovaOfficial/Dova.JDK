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

[JniSignatureAttribute("Lsun/awt/X11/XComponentPeer;", "public")]
public partial class XComponentPeer
	: Dova.JDK.sun.awt.X11.XWindow
	, Dova.JDK.java.awt.peer.ComponentPeer
	, Dova.JDK.java.awt.dnd.peer.DropTargetPeer
	, Dova.JDK.sun.java2d.BackBufferCapsProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XComponentPeer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XComponentPeer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "log", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "buffersLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "focusLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fontLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "enableLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "shapeLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paintPending", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isLayouting", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundsOperation", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "foreground", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "background", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "darkShadow", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lightShadow", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectColor", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "font", "Ljava/awt/Font;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "backBuffer", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xBackBuffer", "Ljava/awt/image/VolatileImage;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "systemColors", "[Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bHasFocus", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BACKGROUND_COLOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIGHLIGHT_COLOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHADOW_COLOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOREGROUND_COLOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "backBufferCaps", "Ljava/awt/BufferCapabilities;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Component;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Component;JLjava/awt/Rectangle;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11/XCreateWindowParams;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flip", "(IIIILjava/awt/BufferCapabilities$FlipContents;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeerBackground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateMotifColors", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaMouseEvent", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeerFont", "()Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeerSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawMotif3DRect", "(Ljava/awt/Graphics;IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeerForeground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaKeyEvent", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInitialReshape", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rejectFocusRequestHelper", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParentTopLevel", "()Lsun/awt/X11/XWindowPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaMouseWheelEvent", "(Ljava/awt/event/MouseWheelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleF10JavaKeyEvent", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaInputMethodEvent", "(Ljava/awt/event/InputMethodEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaFocusEvent", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaWindowFocusEvent", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRGBvals", "(Ljava/awt/Color;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "wrapInSequenced", "(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGUIcolors", "()[Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw3DOval", "(Ljava/awt/Graphics;[Ljava/awt/Color;IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw3DOval", "(Ljava/awt/Graphics;Ljava/awt/Color;IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawScrollbar", "(Ljava/awt/Graphics;Ljava/awt/Color;IIIIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackBufferCaps", "()Ljava/awt/BufferCapabilities;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notifyTextComponentChange", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBoundsOperation", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "operationToString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isObscured", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canDetermineObscurity", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBuffers", "(ILjava/awt/BufferCapabilities;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroyBuffers", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPaintPending", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "(Ljava/awt/Component;ZZJLjava/awt/event/FocusEvent$Cause;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSurfaceData", "()Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTree", "(Ljava/util/Collection;Ljava/util/Set;Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventSource", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSystemColors", "()[Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preInit", "(Lsun/awt/X11/XCreateWindowParams;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphicsConfigurationData", "()Lsun/awt/X11/AwtGraphicsConfigData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postInit", "(Lsun/awt/X11/XCreateWindowParams;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWinBackground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postPaintEvent", "(Ljava/awt/Component;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleExposeEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEventDisabled", "(Lsun/awt/X11/XEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postEventToEventQueue", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleButtonPressRelease", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleMotionNotify", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleXCrossingEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pSetCursor", "(Ljava/awt/Cursor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pSetCursor", "(Ljava/awt/Cursor;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleConfigureNotifyEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleMapNotifyEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleUnmapNotifyEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleKeyPress", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postKeyEvent", "(IIIIIJIJII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleKeyRelease", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handlePropertyNotify", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMouseAbove", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw3DRect", "(Ljava/awt/Graphics;Ljava/awt/Color;IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw3DRect", "(Ljava/awt/Graphics;[Ljava/awt/Color;IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "coalescePaintEvent", "(Ljava/awt/event/PaintEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFullScreenExclusiveModeState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMWMHints", "()Lsun/awt/X11/PropMwmHints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMWMHints", "(Lsun/awt/X11/PropMwmHints;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmbedded", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDropTarget", "(Ljava/awt/dnd/DropTarget;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDropTarget", "(Ljava/awt/dnd/DropTarget;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reshape", "(Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reshape", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hide", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphics", "()Ljava/awt/Graphics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInsets", "()Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popup", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphicsConfiguration", "()Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCursorImmediately", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReparentSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reparent", "(Ljava/awt/peer/ContainerPeer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateGraphicsData", "(Ljava/awt/GraphicsConfiguration;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layout", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginValidate", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endValidate", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginLayout", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLayout", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endLayout", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleEvent", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "()Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColorModel", "()Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColorModel", "(I)Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createImage", "(II)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createVolatileImage", "(II)Ljava/awt/image/VolatileImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackBuffer", "()Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handlesWheelScrolling", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasFocus", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyShape", "(Lsun/java2d/pipe/Region;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setZOrder", "(Ljava/awt/peer/ComponentPeer;)V"));
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger log_Property
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

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger buffersLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger focusLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger fontLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger enableLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger shapeLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool paintPending_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool isLayouting_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool enabled_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int boundsOperation_Property
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

	[JniSignatureAttribute("Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color foreground_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color background_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color darkShadow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color lightShadow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color selectColor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Font;", "")]
	public Dova.JDK.java.awt.Font font_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long backBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/VolatileImage;", "private")]
	public Dova.JDK.java.awt.image.VolatileImage xBackBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.VolatileImage>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/awt/Color;", "static")]
	public static JavaArray<Dova.JDK.java.awt.Color> systemColors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Color>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool bHasFocus_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int BACKGROUND_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int HIGHLIGHT_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SHADOW_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int FOREGROUND_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/BufferCapabilities;", "private")]
	public Dova.JDK.java.awt.BufferCapabilities backBufferCaps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.BufferCapabilities>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XComponentPeer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "")]
	public XComponentPeer(Dova.JDK.java.awt.Component arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Component;JLjava/awt/Rectangle;)V", "")]
	public XComponentPeer(Dova.JDK.java.awt.Component arg0, long arg1, Dova.JDK.java.awt.Rectangle arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XCreateWindowParams;)V", "")]
	public XComponentPeer(Dova.JDK.sun.awt.X11.XCreateWindowParams arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "")]
	public XComponentPeer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XComponentPeer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void print(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object getTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(IIIILjava/awt/BufferCapabilities$FlipContents;)V", "public")]
	public void flip(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.BufferCapabilities.FlipContents arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color getPeerBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "")]
	public void updateMotifColors(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "")]
	public void handleJavaMouseEvent(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Font;", "")]
	public Dova.JDK.java.awt.Font getPeerFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "")]
	public Dova.JDK.java.awt.Dimension getPeerSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIIIZ)V", "public")]
	public void drawMotif3DRect(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, bool arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color getPeerForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "")]
	public void handleJavaKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isInitialReshape()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool rejectFocusRequestHelper(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XWindowPeer;", "")]
	public Dova.JDK.sun.awt.X11.XWindowPeer getParentTopLevel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XWindowPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseWheelEvent;)V", "")]
	public void handleJavaMouseWheelEvent(Dova.JDK.java.awt.@event.MouseWheelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "")]
	public void handleF10JavaKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputMethodEvent;)V", "")]
	public void handleJavaInputMethodEvent(Dova.JDK.java.awt.@event.InputMethodEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "")]
	public void handleJavaFocusEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "")]
	public void handleJavaWindowFocusEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)[I", "static")]
	public static JavaArray<int> getRGBvals(Dova.JDK.java.awt.Color arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;", "static final")]
	public static Dova.JDK.java.awt.AWTEvent wrapInSequenced(Dova.JDK.java.awt.AWTEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/Color;", "public")]
	public JavaArray<Dova.JDK.java.awt.Color> getGUIcolors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Color>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;[Ljava/awt/Color;IIIIZ)V", "public")]
	public void draw3DOval(Dova.JDK.java.awt.Graphics arg0, JavaArray<Dova.JDK.java.awt.Color> arg1, int arg2, int arg3, int arg4, int arg5, bool arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Color;IIIIZ)V", "")]
	public void draw3DOval(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Color arg1, int arg2, int arg3, int arg4, int arg5, bool arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Color;IIIIIIZ)V", "")]
	public void drawScrollbar(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Color arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, bool arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("()Ljava/awt/BufferCapabilities;", "public")]
	public Dova.JDK.java.awt.BufferCapabilities getBackBufferCaps()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.BufferCapabilities>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void notifyTextComponentChange(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setBoundsOperation(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String operationToString(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isObscured()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canDetermineObscurity()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/awt/BufferCapabilities;)V", "public")]
	public void createBuffers(int arg0, Dova.JDK.java.awt.BufferCapabilities arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void destroyBuffers()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPaintPending()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setForeground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)V", "public")]
	public void setFont(Dova.JDK.java.awt.Font arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
	public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
	public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Font;", "public")]
	public Dova.JDK.java.awt.Font getFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;ZZJLjava/awt/event/FocusEvent$Cause;)Z", "public final")]
	public bool requestFocus(Dova.JDK.java.awt.Component arg0, bool arg1, bool arg2, long arg3, Dova.JDK.java.awt.@event.FocusEvent.Cause arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public volatile")]
	public Dova.JDK.sun.java2d.SurfaceData getSurfaceData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Ljava/util/Set;Ljava/awt/Container;)V", "private")]
	public void addTree(Dova.JDK.java.util.Collection arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.java.awt.Container arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public volatile")]
	public Dova.JDK.java.awt.Component getEventSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/Color;", "static")]
	public static JavaArray<Dova.JDK.java.awt.Color> getSystemColors()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Color>>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XCreateWindowParams;)V", "")]
	public void preInit(Dova.JDK.sun.awt.X11.XCreateWindowParams arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/AwtGraphicsConfigData;", "public volatile")]
	public Dova.JDK.sun.awt.X11.AwtGraphicsConfigData getGraphicsConfigurationData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.AwtGraphicsConfigData>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XCreateWindowParams;)V", "")]
	public void postInit(Dova.JDK.sun.awt.X11.XCreateWindowParams arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getWinBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;IIII)V", "public volatile")]
	public void postPaintEvent(Dova.JDK.java.awt.Component arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleExposeEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)Z", "protected")]
	public bool isEventDisabled(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "public volatile")]
	public void postEventToEventQueue(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleButtonPressRelease(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleMotionNotify(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleXCrossingEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public final")]
	public void pSetCursor(Dova.JDK.java.awt.Cursor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Cursor;Z)V", "public")]
	public void pSetCursor(Dova.JDK.java.awt.Cursor arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleConfigureNotifyEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleMapNotifyEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleUnmapNotifyEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleKeyPress(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(IIIIIJIJII)V", "public volatile")]
	public void postKeyEvent(int arg0, int arg1, int arg2, int arg3, int arg4, long arg5, int arg6, long arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handleKeyRelease(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public volatile")]
	public void handlePropertyNotify(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public volatile")]
	public Dova.JDK.java.awt.Rectangle getTargetBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()Z", "public volatile")]
	public bool isMouseAbove()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[70]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Color;IIIIZ)V", "")]
	public void draw3DRect(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Color arg1, int arg2, int arg3, int arg4, int arg5, bool arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;[Ljava/awt/Color;IIIIZ)V", "public")]
	public void draw3DRect(Dova.JDK.java.awt.Graphics arg0, JavaArray<Dova.JDK.java.awt.Color> arg1, int arg2, int arg3, int arg4, int arg5, bool arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/awt/event/PaintEvent;)V", "public")]
	public void coalescePaintEvent(Dova.JDK.java.awt.@event.PaintEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public volatile")]
	public void setFullScreenExclusiveModeState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/PropMwmHints;", "public volatile")]
	public Dova.JDK.sun.awt.X11.PropMwmHints getMWMHints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.PropMwmHints>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/PropMwmHints;)V", "public volatile")]
	public void setMWMHints(Dova.JDK.sun.awt.X11.PropMwmHints arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("()Z", "public volatile")]
	public bool isEmbedded()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[77]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DropTarget;)V", "public")]
	public void addDropTarget(Dova.JDK.java.awt.dnd.DropTarget arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DropTarget;)V", "public")]
	public void removeDropTarget(Dova.JDK.java.awt.dnd.DropTarget arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public volatile")]
	public void reshape(Dova.JDK.java.awt.Rectangle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void reshape(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "public")]
	public void hide()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82]);
	}

	[JniSignatureAttribute("()Ljava/awt/Graphics;", "public")]
	public Dova.JDK.java.awt.Graphics getGraphics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public")]
	public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Insets;", "public")]
	public Dova.JDK.java.awt.Insets getInsets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setBackground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[88], arg0);
	}

	[JniSignatureAttribute("(IIIII)V", "public")]
	public void setBounds(int arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIII)V", "public volatile")]
	public void popup(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsConfiguration;", "public volatile")]
	public Dova.JDK.java.awt.GraphicsConfiguration getGraphicsConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateCursorImmediately()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[92]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFocusable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[93]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isReparentSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[94]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/peer/ContainerPeer;)V", "public")]
	public void reparent(Dova.JDK.java.awt.peer.ContainerPeer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;)Z", "public")]
	public bool updateGraphicsData(Dova.JDK.java.awt.GraphicsConfiguration arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void layout()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[97]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void beginValidate()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endValidate()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void beginLayout()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[100]);
	}

	[JniSignatureAttribute("(IIII)V", "public volatile")]
	public void doLayout(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[101], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endLayout()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[102]);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "public")]
	public void handleEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[103], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Point;", "public volatile")]
	public Dova.JDK.java.awt.Point getLocationOnScreen()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/image/ColorModel;", "public volatile")]
	public Dova.JDK.java.awt.image.ColorModel getColorModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/image/ColorModel;", "public volatile")]
	public Dova.JDK.java.awt.image.ColorModel getColorModel(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image createImage(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/image/VolatileImage;", "public")]
	public Dova.JDK.java.awt.image.VolatileImage createVolatileImage(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.VolatileImage>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image getBackBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool handlesWheelScrolling()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[110]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool hasFocus()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[111]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)V", "public")]
	public void applyShape(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[112], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/peer/ComponentPeer;)V", "public")]
	public void setZOrder(Dova.JDK.java.awt.peer.ComponentPeer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
	}
}
