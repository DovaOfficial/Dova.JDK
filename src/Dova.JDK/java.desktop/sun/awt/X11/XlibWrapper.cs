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

[JniSignatureAttribute("Lsun/awt/X11/XlibWrapper;", "final")]
public partial class XlibWrapper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XlibWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XlibWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAXSIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINSIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "eventToString", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "lbuffer", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ibuffer", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "larg1", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "larg2", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "larg3", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "larg4", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "larg5", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "larg6", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "larg7", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "larg8", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iarg1", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iarg2", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iarg3", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iarg4", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iarg5", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iarg6", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iarg7", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iarg8", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dataModel", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "isBuildInternal", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAddress", "(Ljava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSupportsLocale", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetLocaleModifiers", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XRefreshKeyboardMapping", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XNextSecondaryLoopEvent", "(JJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XEventsQueued", "(JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XNextEvent", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XFilterEvent", "(JJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XBell", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DisplayWidth", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DisplayWidthMM", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetDefault", "(JLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XWindowEvent", "(JJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XKeysymToKeycode", "(JJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetModifierMapping", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XFreeModifiermap", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ScreenCount", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ScreenOfDisplay", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DoesBackingStore", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsXsunKPBehavior", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsSunKeyboard", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsKanaKeyboard", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XQueryExtension", "(JLjava/lang/String;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbLibraryVersion", "(JJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbQueryExtension", "(JJJJJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbSelectEvents", "(JJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbSelectEventDetails", "(JJJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbGetMap", "(JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbSetDetectableAutoRepeat", "(JZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbFreeKeyboard", "(JJZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbGetUpdatedMap", "(JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XMoveWindow", "(JJII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XChangePropertyImpl", "(JJJJIIJI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBuildInternal", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyIntArray", "(JLjava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyLongArray", "(JLjava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XOpenDisplay", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XCloseDisplay", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XDisplayString", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetCloseDownMode", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DisplayHeight", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DisplayHeightMM", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGrabServer", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XUngrabServer", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XMapRaised", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XLowerWindow", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XRestackWindows", "(JJI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XConfigureWindow", "(JJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XMaskEvent", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XTranslateCoordinates", "(JJJJJJJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XPeekEvent", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XResizeWindow", "(JJII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XFreeCursor", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XInternAtoms", "(J[Ljava/lang/String;ZJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetWindowProperty", "(JJJJJJJJJJJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XChangePropertyS", "(JJJJIILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetTransientFor", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetWMHints", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetPointerMapping", "(JJI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XIconifyWindow", "(JJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ServerVendor", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VendorRelease", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XCreateBitmapFromData", "(JJJII)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XFreePixmap", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XCreatePixmapCursor", "(JJJJJII)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XQueryBestCursor", "(JJIIJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XAllocColor", "(JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetErrorHandler", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CallErrorHandler", "(JJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XChangeWindowAttributes", "(JJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetGeometry", "(JJJJJJJJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetMinMaxHints", "(JJIIIIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XPutBackEvent", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XQueryTree", "(JJJJJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetVisualInfo", "(JJJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XConvertSelection", "(JJJJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetSelectionOwner", "(JJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetSelectionOwner", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XMaxRequestSize", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XCreatePixmap", "(JJIII)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XCreateImage", "(JJIIIJIIII)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XDestroyImage", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XPutImage", "(JJJJIIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XCreateGC", "(JJJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XFreeGC", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetWindowBackgroundPixmap", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetIconSizes", "(JJJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XdbeQueryExtension", "(JJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsKeypadKey", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XdbeAllocateBackBufferName", "(JJI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XdbeDeallocateBackBufferName", "(JJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XdbeBeginIdiom", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XdbeEndIdiom", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XdbeSwapBuffers", "(JJI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XQueryKeymap", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbGetEffectiveGroup", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbKeycodeToKeysym", "(JIII)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XkbTranslateKeyCode", "(JIJJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XConvertCase", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XChangeActivePointerGrab", "(JIJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSynchronize", "(JZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ExitSecondaryLoop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XTextPropertyToStringList", "([BJ)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XShapeQueryExtension", "(JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SetRectangularShape", "(JJIIIILsun/java2d/pipe/Region;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SetBitmapShape", "(JJII[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SetZOrder", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDataModel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEventToString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSendEvent", "(JJZJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RootWindow", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetWindowBackground", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XClearWindow", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XFlush", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XKeycodeToKeysym", "(JII)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XCreateWindow", "(JJIIIIIIJJJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XFree", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XDestroyWindow", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetWMHints", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XAllocWMHints", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XAllocSizeHints", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hintsToString", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetWMNormalHints", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XRaiseWindow", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetInputFocus2", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSetInputFocus", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetInputFocus", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XMapWindow", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XUnmapWindow", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getScreenOfWindow", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XScreenNumberOfScreen", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XMoveResizeWindow", "(JJIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGrabPointer", "(JJIIIIJJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XUngrabPointer", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGrabKeyboard", "(JJIIIJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XUngrabKeyboard", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSelectInput", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetWindowAttributes", "(JJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetWMNormalHints", "(JJJJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XReparentWindow", "(JJJII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XGetAtomName", "(JJ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InternAtom", "(JLjava/lang/String;I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SetProperty", "(JJJLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "GetProperty", "(JJJ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XChangeProperty", "(JJJJIIJI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "memcpy", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XDeleteProperty", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStringBytes", "(J)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SetToolkitErrorHandler", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XSync", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PrintXErrorEvent", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DefaultScreen", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XQueryPointer", "(JJJJJJJJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XCreateFontCursor", "(JI)I"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "static")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAXSIZE_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MINSIZE_Property
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

	[JniSignatureAttribute("[Ljava/lang/String;", "static final")]
	public static JavaArray<Dova.JDK.java.lang.String> eventToString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long lbuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long ibuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long larg1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long larg2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long larg3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long larg4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long larg5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long larg6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long larg7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long larg8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long iarg1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long iarg2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long iarg3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long iarg4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long iarg5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long iarg6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long iarg7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long iarg8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "static")]
	public static int dataModel_Property
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

	[JniSignatureAttribute("Z", "static final")]
	public static bool isBuildInternal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XlibWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public XlibWrapper() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XlibWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)J", "static native")]
	public static long getAddress(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static native")]
	public static bool XSupportsLocale()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "static native")]
	public static Dova.JDK.java.lang.String XSetLocaleModifiers(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XRefreshKeyboardMapping(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(JJ)Z", "static native")]
	public static bool XNextSecondaryLoopEvent(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JI)I", "static native")]
	public static int XEventsQueued(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XNextEvent(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)Z", "static native")]
	public static bool XFilterEvent(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JI)V", "static native")]
	public static void XBell(long arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)J", "static native")]
	public static long DisplayWidth(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "static native")]
	public static long DisplayWidthMM(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "static native")]
	public static Dova.JDK.java.lang.String XGetDefault(long arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JJJJ)V", "static native")]
	public static void XWindowEvent(long arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJ)I", "static native")]
	public static int XKeysymToKeycode(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "static native")]
	public static long XGetModifierMapping(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XFreeModifiermap(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(J)I", "static native")]
	public static int ScreenCount(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "static native")]
	public static long ScreenOfDisplay(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "static native")]
	public static int DoesBackingStore(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "static native")]
	public static bool IsXsunKPBehavior(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "static native")]
	public static bool IsSunKeyboard(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "static native")]
	public static bool IsKanaKeyboard(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/lang/String;JJJ)Z", "static native")]
	public static bool XQueryExtension(long arg0, Dova.JDK.java.lang.String arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(JJ)Z", "static native")]
	public static bool XkbLibraryVersion(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJJJJJ)Z", "static native")]
	public static bool XkbQueryExtension(long arg0, long arg1, long arg2, long arg3, long arg4, long arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(JJJJ)V", "static native")]
	public static void XkbSelectEvents(long arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJJJJ)V", "static native")]
	public static void XkbSelectEventDetails(long arg0, long arg1, long arg2, long arg3, long arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(JJJ)J", "static native")]
	public static long XkbGetMap(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JZ)V", "static native")]
	public static void XkbSetDetectableAutoRepeat(long arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(JJZ)V", "static native")]
	public static void XkbFreeKeyboard(long arg0, long arg1, bool arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJJ)J", "static native")]
	public static long XkbGetUpdatedMap(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJII)V", "static native")]
	public static void XMoveWindow(long arg0, long arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJJJIIJI)V", "static native")]
	public static void XChangePropertyImpl(long arg0, long arg1, long arg2, long arg3, int arg4, int arg5, long arg6, int arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool getBuildInternal()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/lang/Object;I)V", "static native")]
	public static void copyIntArray(long arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JLjava/lang/Object;I)V", "static native")]
	public static void copyLongArray(long arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)J", "static native")]
	public static long XOpenDisplay(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XCloseDisplay(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(J)J", "static native")]
	public static long XDisplayString(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)V", "static native")]
	public static void XSetCloseDownMode(long arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)J", "static native")]
	public static long DisplayHeight(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "static native")]
	public static long DisplayHeightMM(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XGrabServer(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XUngrabServer(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XMapRaised(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XLowerWindow(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1);
	}

	[JniSignatureAttribute("(JJI)V", "static native")]
	public static void XRestackWindows(long arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJJJ)V", "static native")]
	public static void XConfigureWindow(long arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XMaskEvent(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJJJJJJJ)I", "static native")]
	public static int XTranslateCoordinates(long arg0, long arg1, long arg2, long arg3, long arg4, long arg5, long arg6, long arg7)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XPeekEvent(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1);
	}

	[JniSignatureAttribute("(JJII)V", "static native")]
	public static void XResizeWindow(long arg0, long arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XFreeCursor(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1);
	}

	[JniSignatureAttribute("(J[Ljava/lang/String;ZJ)I", "static native")]
	public static int XInternAtoms(long arg0, JavaArray<Dova.JDK.java.lang.String> arg1, bool arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJJJJJJJJJJJ)I", "static native")]
	public static int XGetWindowProperty(long arg0, long arg1, long arg2, long arg3, long arg4, long arg5, long arg6, long arg7, long arg8, long arg9, long arg10, long arg11)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return ret;
	}

	[JniSignatureAttribute("(JJJJIILjava/lang/String;)V", "static native")]
	public static void XChangePropertyS(long arg0, long arg1, long arg2, long arg3, int arg4, int arg5, Dova.JDK.java.lang.String arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XSetTransientFor(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XGetWMHints(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJI)I", "static native")]
	public static int XGetPointerMapping(long arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJJ)I", "static native")]
	public static int XIconifyWindow(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/lang/String;", "static native")]
	public static Dova.JDK.java.lang.String ServerVendor(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)I", "static native")]
	public static int VendorRelease(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[61], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJJII)J", "static native")]
	public static long XCreateBitmapFromData(long arg0, long arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XFreePixmap(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[63], arg0, arg1);
	}

	[JniSignatureAttribute("(JJJJJII)J", "static native")]
	public static long XCreatePixmapCursor(long arg0, long arg1, long arg2, long arg3, long arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(JJIIJJ)Z", "static native")]
	public static bool XQueryBestCursor(long arg0, long arg1, int arg2, int arg3, long arg4, long arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[65], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(JJJ)Z", "static native")]
	public static bool XAllocColor(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[66], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XSetErrorHandler(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(JJJ)I", "static native")]
	public static int CallErrorHandler(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJJJ)V", "static native")]
	public static void XChangeWindowAttributes(long arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[69], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJJJJJJJJ)I", "static native")]
	public static int XGetGeometry(long arg0, long arg1, long arg2, long arg3, long arg4, long arg5, long arg6, long arg7, long arg8)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[70], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(JJIIIIJ)V", "static native")]
	public static void XSetMinMaxHints(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, long arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[71], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XPutBackEvent(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[72], arg0, arg1);
	}

	[JniSignatureAttribute("(JJJJJJ)I", "static native")]
	public static int XQueryTree(long arg0, long arg1, long arg2, long arg3, long arg4, long arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[73], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(JJJJ)J", "static native")]
	public static long XGetVisualInfo(long arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[74], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJJJJJ)V", "static native")]
	public static void XConvertSelection(long arg0, long arg1, long arg2, long arg3, long arg4, long arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(JJJJ)V", "static native")]
	public static void XSetSelectionOwner(long arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJ)J", "static native")]
	public static long XGetSelectionOwner(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "static native")]
	public static long XMaxRequestSize(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[78], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJIII)J", "static native")]
	public static long XCreatePixmap(long arg0, long arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[79], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(JJIIIJIIII)J", "static native")]
	public static long XCreateImage(long arg0, long arg1, int arg2, int arg3, int arg4, long arg5, int arg6, int arg7, int arg8, int arg9)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[80], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XDestroyImage(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[81], arg0);
	}

	[JniSignatureAttribute("(JJJJIIIIII)V", "static native")]
	public static void XPutImage(long arg0, long arg1, long arg2, long arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[82], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(JJJJ)J", "static native")]
	public static long XCreateGC(long arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[83], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XFreeGC(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[84], arg0, arg1);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XSetWindowBackgroundPixmap(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[85], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJJJ)I", "static native")]
	public static int XGetIconSizes(long arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[86], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJJ)I", "static native")]
	public static int XdbeQueryExtension(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[87], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "static native")]
	public static bool IsKeypadKey(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[88], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJI)J", "static native")]
	public static long XdbeAllocateBackBufferName(long arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[89], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJ)I", "static native")]
	public static int XdbeDeallocateBackBufferName(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[90], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "static native")]
	public static int XdbeBeginIdiom(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[91], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "static native")]
	public static int XdbeEndIdiom(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[92], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJI)I", "static native")]
	public static int XdbeSwapBuffers(long arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[93], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XQueryKeymap(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[94], arg0, arg1);
	}

	[JniSignatureAttribute("(J)I", "static native")]
	public static int XkbGetEffectiveGroup(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[95], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JIII)J", "static native")]
	public static long XkbKeycodeToKeysym(long arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[96], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JIJJJ)Z", "static native")]
	public static bool XkbTranslateKeyCode(long arg0, int arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[97], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XConvertCase(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[98], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JIJJ)V", "static native")]
	public static void XChangeActivePointerGrab(long arg0, int arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[99], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JZ)I", "static native")]
	public static int XSynchronize(long arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[100], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "static native")]
	public static void ExitSecondaryLoop()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[101]);
	}

	[JniSignatureAttribute("([BJ)[Ljava/lang/String;", "static native")]
	public static JavaArray<Dova.JDK.java.lang.String> XTextPropertyToStringList(JavaArray<byte> arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[102], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(JJJ)Z", "static native")]
	public static bool XShapeQueryExtension(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[103], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJIIIILsun/java2d/pipe/Region;)V", "static native")]
	public static void SetRectangularShape(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.sun.java2d.pipe.Region arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[104], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(JJII[I)V", "static native")]
	public static void SetBitmapShape(long arg0, long arg1, int arg2, int arg3, JavaArray<int> arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[105], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void SetZOrder(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[106], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getDataModel()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[107]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getEventToString(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[108], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JJZJJ)I", "static native")]
	public static int XSendEvent(long arg0, long arg1, bool arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[109], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "static native")]
	public static long RootWindow(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[110], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XSetWindowBackground(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[111], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XClearWindow(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[112], arg0, arg1);
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XFlush(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[113], arg0);
	}

	[JniSignatureAttribute("(JII)J", "static native")]
	public static long XKeycodeToKeysym(long arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[114], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJIIIIIIJJJJ)J", "static native")]
	public static long XCreateWindow(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, long arg8, long arg9, long arg10, long arg11)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[115], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void XFree(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[116], arg0);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XDestroyWindow(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[117], arg0, arg1);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XSetWMHints(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[118], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()J", "static native")]
	public static long XAllocWMHints()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[119]);
		return ret;
	}

	[JniSignatureAttribute("()J", "static native")]
	public static long XAllocSizeHints()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[120]);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String hintsToString(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[121], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XSetWMNormalHints(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[122], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XRaiseWindow(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[123], arg0, arg1);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XSetInputFocus2(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[124], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XSetInputFocus(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[125], arg0, arg1);
	}

	[JniSignatureAttribute("(J)J", "static native")]
	public static long XGetInputFocus(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[126], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XMapWindow(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[127], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XUnmapWindow(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[128], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)J", "static native")]
	public static long getScreenOfWindow(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[129], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "static native")]
	public static long XScreenNumberOfScreen(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[130], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJIIII)V", "static native")]
	public static void XMoveResizeWindow(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[131], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(JJIIIIJJJ)I", "static native")]
	public static int XGrabPointer(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, long arg6, long arg7, long arg8)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[132], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XUngrabPointer(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[133], arg0, arg1);
	}

	[JniSignatureAttribute("(JJIIIJ)I", "static native")]
	public static int XGrabKeyboard(long arg0, long arg1, int arg2, int arg3, int arg4, long arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[134], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void XUngrabKeyboard(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[135], arg0, arg1);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XSelectInput(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[136], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJJ)I", "static native")]
	public static int XGetWindowAttributes(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[137], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJJJ)I", "static native")]
	public static int XGetWMNormalHints(long arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[138], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJJII)V", "static native")]
	public static void XReparentWindow(long arg0, long arg1, long arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[139], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(JJ)Ljava/lang/String;", "static native")]
	public static Dova.JDK.java.lang.String XGetAtomName(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[140], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JLjava/lang/String;I)J", "static native")]
	public static long InternAtom(long arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[141], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJJLjava/lang/String;)V", "static native")]
	public static void SetProperty(long arg0, long arg1, long arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[142], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJJ)Ljava/lang/String;", "static native")]
	public static Dova.JDK.java.lang.String GetProperty(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[143], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JJJJIIJI)V", "static")]
	public static void XChangeProperty(long arg0, long arg1, long arg2, long arg3, int arg4, int arg5, long arg6, int arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[144], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void memcpy(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[145], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJJ)V", "static native")]
	public static void XDeleteProperty(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[146], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)[B", "static native")]
	public static JavaArray<byte> getStringBytes(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[147], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()J", "static native")]
	public static long SetToolkitErrorHandler()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[148]);
		return ret;
	}

	[JniSignatureAttribute("(JI)V", "static native")]
	public static void XSync(long arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[149], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "static native")]
	public static void PrintXErrorEvent(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[150], arg0, arg1);
	}

	[JniSignatureAttribute("(J)J", "static native")]
	public static long DefaultScreen(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[151], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJJJJJJJJ)Z", "static native")]
	public static bool XQueryPointer(long arg0, long arg1, long arg2, long arg3, long arg4, long arg5, long arg6, long arg7, long arg8)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[152], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(JI)I", "static native")]
	public static int XCreateFontCursor(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[153], arg0, arg1);
		return ret;
	}
}
