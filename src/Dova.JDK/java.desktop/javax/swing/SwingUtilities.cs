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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/SwingUtilities;", "public")]
public partial class SwingUtilities
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.swing.SwingConstants
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SwingUtilities()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/SwingUtilities;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "canAccessEventQueue", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "eventQueueTested", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "suppressDropSupport", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "checkedSuppressDropSupport", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedOwnerFrameKey", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRoot", "(Ljava/awt/Component;)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isEventDispatchThread", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeAndWait", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeLater", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRootPane", "(Ljava/awt/Component;)Ljavax/swing/JRootPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "layoutCompoundLabel", "(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "layoutCompoundLabel", "(Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertScreenLocationToParent", "(Ljava/awt/Container;II)Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAncestorOfClass", "(Ljava/lang/Class;Ljava/awt/Component;)Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAncestorNamed", "(Ljava/lang/String;Ljava/awt/Component;)Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertMouseEvent", "(Ljava/awt/Component;Ljava/awt/event/MouseEvent;Ljava/awt/Component;)Ljava/awt/event/MouseEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "windowForComponent", "(Ljava/awt/Component;)Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeUnion", "(IIIILjava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeDifference", "(Ljava/awt/Rectangle;Ljava/awt/Rectangle;)[Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLeftMouseButton", "(Ljava/awt/event/MouseEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMiddleMouseButton", "(Ljava/awt/event/MouseEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isRightMouseButton", "(Ljava/awt/event/MouseEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeStringWidth", "(Ljava/awt/FontMetrics;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findFocusOwner", "(Ljava/awt/Component;)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replaceUIInputMap", "(Ljavax/swing/JComponent;ILjavax/swing/InputMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replaceUIActionMap", "(Ljavax/swing/JComponent;Ljavax/swing/ActionMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUIInputMap", "(Ljavax/swing/JComponent;I)Ljavax/swing/InputMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUIActionMap", "(Ljavax/swing/JComponent;)Ljavax/swing/ActionMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSharedOwnerFrameShutdownListener", "()Ljava/awt/event/WindowListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadSystemClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "calculateInnerArea", "(Ljavax/swing/JComponent;Ljava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getValidateRoot", "(Ljava/awt/Container;Z)Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "appContextRemove", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSuppressDropTarget", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertPointFromScreen", "(Ljava/awt/Point;Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertPointToScreen", "(Ljava/awt/Point;Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertPoint", "(Ljava/awt/Component;Ljava/awt/Point;Ljava/awt/Component;)Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertPoint", "(Ljava/awt/Component;IILjava/awt/Component;)Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDeepestComponentAt", "(Ljava/awt/Component;II)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isRectangleContainingRectangle", "(Ljava/awt/Rectangle;Ljava/awt/Rectangle;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMouseButton", "(Ljava/awt/event/MouseEvent;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "layoutCompoundLabelImpl", "(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCellRendererPane", "(Ljava/awt/Component;Ljava/awt/Container;)Ljavax/swing/CellRendererPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "updateComponentTreeUI0", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSharedOwnerFrame", "()Ljava/awt/Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLocalBounds", "(Ljava/awt/Component;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "updateRendererOrEditorUI", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "updateComponentTreeUI", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDescendingFrom", "(Ljava/awt/Component;Ljava/awt/Component;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;Ljava/awt/Component;Ljava/awt/Container;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;Ljava/awt/Component;Ljava/awt/Container;Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindowAncestor", "(Ljava/awt/Component;)Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeIntersection", "(IIIILjava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "appContextGet", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "appContextPut", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "processKeyBindings", "(Ljava/awt/event/KeyEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "notifyAction", "(Ljavax/swing/Action;Ljavax/swing/KeyStroke;Ljava/awt/event/KeyEvent;Ljava/lang/Object;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidKeyEventForKeyBindings", "(Ljava/awt/event/KeyEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "installSwingDropTargetAsNecessary", "(Ljava/awt/Component;Ljavax/swing/TransferHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPaintingOrigin", "(Ljavax/swing/JComponent;)Ljavax/swing/JComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertRectangle", "(Ljava/awt/Component;Ljava/awt/Rectangle;Ljava/awt/Component;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessibleChildrenCount", "(Ljava/awt/Component;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessibleChild", "(Ljava/awt/Component;I)Ljavax/accessibility/Accessible;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Component;Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessibleIndexInParent", "(Ljava/awt/Component;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessibleStateSet", "(Ljava/awt/Component;)Ljavax/accessibility/AccessibleStateSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findDisplayedMnemonicIndex", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doesIconReferenceImage", "(Ljavax/swing/Icon;Ljava/awt/Image;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUnwrappedParent", "(Ljava/awt/Component;)Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUnwrappedView", "(Ljavax/swing/JViewport;)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLeftToRight", "(Ljava/awt/Component;)Z"));
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool canAccessEventQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool eventQueueTested_Property
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

	[JniSignatureAttribute("Z", "private static")]
	public static bool suppressDropSupport_Property
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

	[JniSignatureAttribute("Z", "private static")]
	public static bool checkedSuppressDropSupport_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object sharedOwnerFrameKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SwingUtilities(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public SwingUtilities() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/SwingUtilities;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Component;", "public static")]
	public static Dova.JDK.java.awt.Component getRoot(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isEventDispatchThread()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public static")]
	public static void invokeAndWait(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public static")]
	public static void invokeLater(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljavax/swing/JRootPane;", "public static")]
	public static Dova.JDK.javax.swing.JRootPane getRootPane(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRootPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String layoutCompoundLabel(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.FontMetrics arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, Dova.JDK.java.awt.Rectangle arg8, Dova.JDK.java.awt.Rectangle arg9, Dova.JDK.java.awt.Rectangle arg10, int arg11)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String layoutCompoundLabel(Dova.JDK.java.awt.FontMetrics arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.swing.Icon arg2, int arg3, int arg4, int arg5, int arg6, Dova.JDK.java.awt.Rectangle arg7, Dova.JDK.java.awt.Rectangle arg8, Dova.JDK.java.awt.Rectangle arg9, int arg10)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;II)Ljava/awt/Point;", "static")]
	public static Dova.JDK.java.awt.Point convertScreenLocationToParent(Dova.JDK.java.awt.Container arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/awt/Component;)Ljava/awt/Container;", "public static")]
	public static Dova.JDK.java.awt.Container getAncestorOfClass(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.awt.Component arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/Component;)Ljava/awt/Container;", "public static")]
	public static Dova.JDK.java.awt.Container getAncestorNamed(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.Component arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/event/MouseEvent;Ljava/awt/Component;)Ljava/awt/event/MouseEvent;", "public static")]
	public static Dova.JDK.java.awt.@event.MouseEvent convertMouseEvent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.@event.MouseEvent arg1, Dova.JDK.java.awt.Component arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Window;", "public static")]
	public static Dova.JDK.java.awt.Window windowForComponent(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(IIIILjava/awt/Rectangle;)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle computeUnion(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.Rectangle arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;Ljava/awt/Rectangle;)[Ljava/awt/Rectangle;", "public static")]
	public static JavaArray<Dova.JDK.java.awt.Rectangle> computeDifference(Dova.JDK.java.awt.Rectangle arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Rectangle>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Z", "public static")]
	public static bool isLeftMouseButton(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Z", "public static")]
	public static bool isMiddleMouseButton(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Z", "public static")]
	public static bool isRightMouseButton(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/FontMetrics;Ljava/lang/String;)I", "public static")]
	public static int computeStringWidth(Dova.JDK.java.awt.FontMetrics arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Component;", "public static")]
	public static Dova.JDK.java.awt.Component findFocusOwner(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;ILjavax/swing/InputMap;)V", "public static")]
	public static void replaceUIInputMap(Dova.JDK.javax.swing.JComponent arg0, int arg1, Dova.JDK.javax.swing.InputMap arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/ActionMap;)V", "public static")]
	public static void replaceUIActionMap(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.ActionMap arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;I)Ljavax/swing/InputMap;", "public static")]
	public static Dova.JDK.javax.swing.InputMap getUIInputMap(Dova.JDK.javax.swing.JComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.InputMap>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/ActionMap;", "public static")]
	public static Dova.JDK.javax.swing.ActionMap getUIActionMap(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ActionMap>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/event/WindowListener;", "static")]
	public static Dova.JDK.java.awt.@event.WindowListener getSharedOwnerFrameShutdownListener()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class loadSystemClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/Rectangle;)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle calculateInnerArea(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;Z)Ljava/awt/Container;", "static")]
	public static Dova.JDK.java.awt.Container getValidateRoot(Dova.JDK.java.awt.Container arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "static")]
	public static void appContextRemove(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool getSuppressDropTarget()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Point;Ljava/awt/Component;)V", "public static")]
	public static void convertPointFromScreen(Dova.JDK.java.awt.Point arg0, Dova.JDK.java.awt.Component arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;Ljava/awt/Component;)V", "public static")]
	public static void convertPointToScreen(Dova.JDK.java.awt.Point arg0, Dova.JDK.java.awt.Component arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Point;Ljava/awt/Component;)Ljava/awt/Point;", "public static")]
	public static Dova.JDK.java.awt.Point convertPoint(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Point arg1, Dova.JDK.java.awt.Component arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;IILjava/awt/Component;)Ljava/awt/Point;", "public static")]
	public static Dova.JDK.java.awt.Point convertPoint(Dova.JDK.java.awt.Component arg0, int arg1, int arg2, Dova.JDK.java.awt.Component arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;II)Ljava/awt/Component;", "public static")]
	public static Dova.JDK.java.awt.Component getDeepestComponentAt(Dova.JDK.java.awt.Component arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;Ljava/awt/Rectangle;)Z", "public static final")]
	public static bool isRectangleContainingRectangle(Dova.JDK.java.awt.Rectangle arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;II)Z", "private static")]
	public static bool checkMouseButton(Dova.JDK.java.awt.@event.MouseEvent arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String layoutCompoundLabelImpl(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.FontMetrics arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, Dova.JDK.java.awt.Rectangle arg8, Dova.JDK.java.awt.Rectangle arg9, Dova.JDK.java.awt.Rectangle arg10, int arg11)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Container;)Ljavax/swing/CellRendererPane;", "private static")]
	public static Dova.JDK.javax.swing.CellRendererPane getCellRendererPane(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Container arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.CellRendererPane>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "private static")]
	public static void updateComponentTreeUI0(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Frame;", "static")]
	public static Dova.JDK.java.awt.Frame getSharedOwnerFrame()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Frame>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle getLocalBounds(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "static")]
	public static void updateRendererOrEditorUI(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public static")]
	public static void updateComponentTreeUI(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;)Z", "public static")]
	public static bool isDescendingFrom(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Component;Ljava/awt/Container;IIII)V", "public static")]
	public static void paintComponent(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Component arg1, Dova.JDK.java.awt.Container arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Component;Ljava/awt/Container;Ljava/awt/Rectangle;)V", "public static")]
	public static void paintComponent(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Component arg1, Dova.JDK.java.awt.Container arg2, Dova.JDK.java.awt.Rectangle arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Window;", "public static")]
	public static Dova.JDK.java.awt.Window getWindowAncestor(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(IIIILjava/awt/Rectangle;)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle computeIntersection(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.Rectangle arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object appContextGet(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "static")]
	public static void appContextPut(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "public static")]
	public static bool processKeyBindings(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[50], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;Ljavax/swing/KeyStroke;Ljava/awt/event/KeyEvent;Ljava/lang/Object;I)Z", "public static")]
	public static bool notifyAction(Dova.JDK.javax.swing.Action arg0, Dova.JDK.javax.swing.KeyStroke arg1, Dova.JDK.java.awt.@event.KeyEvent arg2, Dova.JDK.java.lang.Object arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "static")]
	public static bool isValidKeyEventForKeyBindings(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[52], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljavax/swing/TransferHandler;)V", "static")]
	public static void installSwingDropTargetAsNecessary(Dova.JDK.java.awt.Component arg0, Dova.JDK.javax.swing.TransferHandler arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/JComponent;", "static")]
	public static Dova.JDK.javax.swing.JComponent getPaintingOrigin(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComponent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Rectangle;Ljava/awt/Component;)Ljava/awt/Rectangle;", "public static")]
	public static Dova.JDK.java.awt.Rectangle convertRectangle(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Rectangle arg1, Dova.JDK.java.awt.Component arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)I", "public static")]
	public static int getAccessibleChildrenCount(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[56], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;I)Ljavax/accessibility/Accessible;", "public static")]
	public static Dova.JDK.javax.accessibility.Accessible getAccessibleChild(Dova.JDK.java.awt.Component arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public static")]
	public static Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Point arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)I", "public static")]
	public static int getAccessibleIndexInParent(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[59], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljavax/accessibility/AccessibleStateSet;", "public static")]
	public static Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "static")]
	public static int findDisplayedMnemonicIndex(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;Ljava/awt/Image;)Z", "static")]
	public static bool doesIconReferenceImage(Dova.JDK.javax.swing.Icon arg0, Dova.JDK.java.awt.Image arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Container;", "public static")]
	public static Dova.JDK.java.awt.Container getUnwrappedParent(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JViewport;)Ljava/awt/Component;", "public static")]
	public static Dova.JDK.java.awt.Component getUnwrappedView(Dova.JDK.javax.swing.JViewport arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Z", "static")]
	public static bool isLeftToRight(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[65], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/swing/SwingUtilities$SharedOwnerFrame;", "static")]
	public partial class SharedOwnerFrame
		: Dova.JDK.java.awt.Frame
		, Dova.JDK.java.awt.@event.WindowListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SharedOwnerFrame()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/SwingUtilities$SharedOwnerFrame;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowOpened", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowClosing", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowClosed", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowIconified", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowDeiconified", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowActivated", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowDeactivated", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "show", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotify", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SharedOwnerFrame(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public SharedOwnerFrame() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/SwingUtilities$SharedOwnerFrame;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowOpened(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowClosing(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowClosed(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowIconified(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowDeiconified(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowActivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowDeactivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void installListeners()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void show()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void addNotify()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
		}
	}
}
