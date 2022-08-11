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

[JniSignatureAttribute("Lsun/awt/HeadlessToolkit;", "public final")]
public partial class HeadlessToolkit
	: Dova.JDK.java.awt.Toolkit
	, Dova.JDK.sun.awt.ComponentFactory
	, Dova.JDK.sun.awt.KeyboardFocusManagerPeerProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HeadlessToolkit()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/HeadlessToolkit;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "kfmPeer", "Ljava/awt/peer/KeyboardFocusManagerPeer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tk", "Ljava/awt/Toolkit;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentFactory", "Lsun/awt/ComponentFactory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Toolkit;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sync", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScreenInsets", "(Ljava/awt/GraphicsConfiguration;)Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModalExclusionTypeSupported", "(Ljava/awt/Dialog$ModalExclusionType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlwaysOnTopSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDynamicLayout", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDynamicLayoutSet", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDynamicLayoutActive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrintJob", "(Ljava/awt/Frame;Ljava/lang/String;Ljava/awt/JobAttributes;Ljava/awt/PageAttributes;)Ljava/awt/PrintJob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrintJob", "(Ljava/awt/Frame;Ljava/lang/String;Ljava/util/Properties;)Ljava/awt/PrintJob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCustomCursor", "(Ljava/awt/Image;Ljava/awt/Point;Ljava/lang/String;)Ljava/awt/Cursor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBestCursorSize", "(II)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumCursorColors", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystemEventQueueImpl", "()Ljava/awt/EventQueue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnderlyingToolkit", "()Ljava/awt/Toolkit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "areExtraMouseButtonsEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadSystemColors", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScreenSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScreenResolution", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontList", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImage", "(Ljava/net/URL;)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImage", "(Ljava/lang/String;)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystemClipboard", "()Ljava/awt/datatransfer/Clipboard;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuShortcutKeyMask", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuShortcutKeyMaskEx", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLockingKeyState", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLockingKeyState", "(IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDragGestureRecognizer", "(Ljava/lang/Class;Ljava/awt/dnd/DragSource;Ljava/awt/Component;ILjava/awt/dnd/DragGestureListener;)Ljava/awt/dnd/DragGestureRecognizer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModalityTypeSupported", "(Ljava/awt/Dialog$ModalityType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAWTEventListener", "(Ljava/awt/event/AWTEventListener;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAWTEventListener", "(Ljava/awt/event/AWTEventListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAWTEventListeners", "(J)[Ljava/awt/event/AWTEventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAWTEventListeners", "()[Ljava/awt/event/AWTEventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapInputMethodHighlight", "(Ljava/awt/im/InputMethodHighlight;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beep", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalCursorManager", "()Lsun/awt/GlobalCursorManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTrayIcon", "(Ljava/awt/TrayIcon;)Ljava/awt/peer/TrayIconPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSystemTray", "(Ljava/awt/SystemTray;)Ljava/awt/peer/SystemTrayPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTraySupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyboardFocusManagerPeer", "()Ljava/awt/peer/KeyboardFocusManagerPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDesktopSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontPeer", "(Ljava/lang/String;I)Ljava/awt/peer/FontPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColorModel", "()Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createImage", "(Ljava/awt/image/ImageProducer;)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createImage", "(Ljava/lang/String;)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createImage", "(Ljava/net/URL;)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createImage", "([B)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createImage", "([BII)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareImage", "(Ljava/awt/Image;IILjava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkImage", "(Ljava/awt/Image;IILjava/awt/image/ImageObserver;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/peer/KeyboardFocusManagerPeer;", "private static final")]
	public static Dova.JDK.java.awt.peer.KeyboardFocusManagerPeer kfmPeer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.KeyboardFocusManagerPeer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Toolkit;", "private final")]
	public Dova.JDK.java.awt.Toolkit tk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Toolkit>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/ComponentFactory;", "private")]
	public Dova.JDK.sun.awt.ComponentFactory componentFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.ComponentFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HeadlessToolkit(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Toolkit;)V", "public")]
	public HeadlessToolkit(Dova.JDK.java.awt.Toolkit arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/HeadlessToolkit;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void sync()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;)Ljava/awt/Insets;", "public")]
	public Dova.JDK.java.awt.Insets getScreenInsets(Dova.JDK.java.awt.GraphicsConfiguration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog$ModalExclusionType;)Z", "public")]
	public bool isModalExclusionTypeSupported(Dova.JDK.java.awt.Dialog.ModalExclusionType arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAlwaysOnTopSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setDynamicLayout(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isDynamicLayoutSet()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDynamicLayoutActive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Frame;Ljava/lang/String;Ljava/awt/JobAttributes;Ljava/awt/PageAttributes;)Ljava/awt/PrintJob;", "public")]
	public Dova.JDK.java.awt.PrintJob getPrintJob(Dova.JDK.java.awt.Frame arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.awt.JobAttributes arg2, Dova.JDK.java.awt.PageAttributes arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PrintJob>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Frame;Ljava/lang/String;Ljava/util/Properties;)Ljava/awt/PrintJob;", "public")]
	public Dova.JDK.java.awt.PrintJob getPrintJob(Dova.JDK.java.awt.Frame arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Properties arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PrintJob>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/Point;Ljava/lang/String;)Ljava/awt/Cursor;", "public")]
	public Dova.JDK.java.awt.Cursor createCustomCursor(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.Point arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getBestCursorSize(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaximumCursorColors()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/EventQueue;", "public")]
	public Dova.JDK.java.awt.EventQueue getSystemEventQueueImpl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventQueue>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Toolkit;", "public")]
	public Dova.JDK.java.awt.Toolkit getUnderlyingToolkit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Toolkit>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool areExtraMouseButtonsEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("([I)V", "protected")]
	public void loadSystemColors(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getScreenSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getScreenResolution()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getFontList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image getImage(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image getImage(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/datatransfer/Clipboard;", "public")]
	public Dova.JDK.java.awt.datatransfer.Clipboard getSystemClipboard()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.datatransfer.Clipboard>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMenuShortcutKeyMask()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMenuShortcutKeyMaskEx()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool getLockingKeyState(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IZ)V", "public")]
	public void setLockingKeyState(int arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/awt/dnd/DragSource;Ljava/awt/Component;ILjava/awt/dnd/DragGestureListener;)Ljava/awt/dnd/DragGestureRecognizer;", "public")]
	public Dova.JDK.java.lang.Object createDragGestureRecognizer(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.awt.dnd.DragSource arg1, Dova.JDK.java.awt.Component arg2, int arg3, Dova.JDK.java.awt.dnd.DragGestureListener arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog$ModalityType;)Z", "public")]
	public bool isModalityTypeSupported(Dova.JDK.java.awt.Dialog.ModalityType arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/AWTEventListener;J)V", "public")]
	public void addAWTEventListener(Dova.JDK.java.awt.@event.AWTEventListener arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/AWTEventListener;)V", "public")]
	public void removeAWTEventListener(Dova.JDK.java.awt.@event.AWTEventListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(J)[Ljava/awt/event/AWTEventListener;", "public")]
	public JavaArray<Dova.JDK.java.awt.@event.AWTEventListener> getAWTEventListeners(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.@event.AWTEventListener>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/event/AWTEventListener;", "public")]
	public JavaArray<Dova.JDK.java.awt.@event.AWTEventListener> getAWTEventListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.@event.AWTEventListener>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/im/InputMethodHighlight;)Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map mapInputMethodHighlight(Dova.JDK.java.awt.im.InputMethodHighlight arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void beep()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33]);
	}

	[JniSignatureAttribute("()Lsun/awt/GlobalCursorManager;", "public")]
	public Dova.JDK.sun.awt.GlobalCursorManager getGlobalCursorManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.GlobalCursorManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/TrayIcon;)Ljava/awt/peer/TrayIconPeer;", "public")]
	public Dova.JDK.java.awt.peer.TrayIconPeer createTrayIcon(Dova.JDK.java.awt.TrayIcon arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.TrayIconPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/SystemTray;)Ljava/awt/peer/SystemTrayPeer;", "public")]
	public Dova.JDK.java.awt.peer.SystemTrayPeer createSystemTray(Dova.JDK.java.awt.SystemTray arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.SystemTrayPeer>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTraySupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/peer/KeyboardFocusManagerPeer;", "public")]
	public Dova.JDK.java.awt.peer.KeyboardFocusManagerPeer getKeyboardFocusManagerPeer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.KeyboardFocusManagerPeer>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDesktopSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/awt/peer/FontPeer;", "public")]
	public Dova.JDK.java.awt.peer.FontPeer getFontPeer(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.FontPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void addPropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public")]
	public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/image/ColorModel;", "public")]
	public Dova.JDK.java.awt.image.ColorModel getColorModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageProducer;)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image createImage(Dova.JDK.java.awt.image.ImageProducer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image createImage(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image createImage(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image createImage(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("([BII)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image createImage(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IILjava/awt/image/ImageObserver;)Z", "public")]
	public bool prepareImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, Dova.JDK.java.awt.image.ImageObserver arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IILjava/awt/image/ImageObserver;)I", "public")]
	public int checkImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, Dova.JDK.java.awt.image.ImageObserver arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void removePropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
	}
}
