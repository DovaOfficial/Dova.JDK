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

[JniSignatureAttribute("Lsun/awt/AWTAccessor;", "public final")]
public partial class AWTAccessor
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AWTAccessor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "componentAccessor", "Lsun/awt/AWTAccessor$ComponentAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "containerAccessor", "Lsun/awt/AWTAccessor$ContainerAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "windowAccessor", "Lsun/awt/AWTAccessor$WindowAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "awtEventAccessor", "Lsun/awt/AWTAccessor$AWTEventAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "inputEventAccessor", "Lsun/awt/AWTAccessor$InputEventAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mouseEventAccessor", "Lsun/awt/AWTAccessor$MouseEventAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "frameAccessor", "Lsun/awt/AWTAccessor$FrameAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "kfmAccessor", "Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "menuComponentAccessor", "Lsun/awt/AWTAccessor$MenuComponentAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "eventQueueAccessor", "Lsun/awt/AWTAccessor$EventQueueAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "popupMenuAccessor", "Lsun/awt/AWTAccessor$PopupMenuAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fileDialogAccessor", "Lsun/awt/AWTAccessor$FileDialogAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "scrollPaneAdjustableAccessor", "Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "checkboxMenuItemAccessor", "Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cursorAccessor", "Lsun/awt/AWTAccessor$CursorAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "menuBarAccessor", "Lsun/awt/AWTAccessor$MenuBarAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "menuItemAccessor", "Lsun/awt/AWTAccessor$MenuItemAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "menuAccessor", "Lsun/awt/AWTAccessor$MenuAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "keyEventAccessor", "Lsun/awt/AWTAccessor$KeyEventAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "clientPropertyKeyAccessor", "Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "systemTrayAccessor", "Lsun/awt/AWTAccessor$SystemTrayAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "trayIconAccessor", "Lsun/awt/AWTAccessor$TrayIconAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultKeyboardFocusManagerAccessor", "Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sequencedEventAccessor", "Lsun/awt/AWTAccessor$SequencedEventAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "toolkitAccessor", "Lsun/awt/AWTAccessor$ToolkitAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "invocationEventAccessor", "Lsun/awt/AWTAccessor$InvocationEventAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "systemColorAccessor", "Lsun/awt/AWTAccessor$SystemColorAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "accessibleContextAccessor", "Lsun/awt/AWTAccessor$AccessibleContextAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "accessibleBundleAccessor", "Lsun/awt/AWTAccessor$AccessibleBundleAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dragSourceContextAccessor", "Lsun/awt/AWTAccessor$DragSourceContextAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dropTargetContextAccessor", "Lsun/awt/AWTAccessor$DropTargetContextAccessor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureClassInitialized", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setComponentAccessor", "(Lsun/awt/AWTAccessor$ComponentAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getComponentAccessor", "()Lsun/awt/AWTAccessor$ComponentAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setContainerAccessor", "(Lsun/awt/AWTAccessor$ContainerAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInputEventAccessor", "()Lsun/awt/AWTAccessor$InputEventAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAWTEventAccessor", "(Lsun/awt/AWTAccessor$AWTEventAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setFrameAccessor", "(Lsun/awt/AWTAccessor$FrameAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAccessibleBundleAccessor", "(Lsun/awt/AWTAccessor$AccessibleBundleAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setWindowAccessor", "(Lsun/awt/AWTAccessor$WindowAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getContainerAccessor", "()Lsun/awt/AWTAccessor$ContainerAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindowAccessor", "()Lsun/awt/AWTAccessor$WindowAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAWTEventAccessor", "()Lsun/awt/AWTAccessor$AWTEventAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setInputEventAccessor", "(Lsun/awt/AWTAccessor$InputEventAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setMouseEventAccessor", "(Lsun/awt/AWTAccessor$MouseEventAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMouseEventAccessor", "()Lsun/awt/AWTAccessor$MouseEventAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFrameAccessor", "()Lsun/awt/AWTAccessor$FrameAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setKeyboardFocusManagerAccessor", "(Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getKeyboardFocusManagerAccessor", "()Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setMenuComponentAccessor", "(Lsun/awt/AWTAccessor$MenuComponentAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMenuComponentAccessor", "()Lsun/awt/AWTAccessor$MenuComponentAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setEventQueueAccessor", "(Lsun/awt/AWTAccessor$EventQueueAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEventQueueAccessor", "()Lsun/awt/AWTAccessor$EventQueueAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setPopupMenuAccessor", "(Lsun/awt/AWTAccessor$PopupMenuAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPopupMenuAccessor", "()Lsun/awt/AWTAccessor$PopupMenuAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setFileDialogAccessor", "(Lsun/awt/AWTAccessor$FileDialogAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFileDialogAccessor", "()Lsun/awt/AWTAccessor$FileDialogAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setScrollPaneAdjustableAccessor", "(Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getScrollPaneAdjustableAccessor", "()Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCheckboxMenuItemAccessor", "(Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCheckboxMenuItemAccessor", "()Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCursorAccessor", "(Lsun/awt/AWTAccessor$CursorAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCursorAccessor", "()Lsun/awt/AWTAccessor$CursorAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setMenuBarAccessor", "(Lsun/awt/AWTAccessor$MenuBarAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMenuBarAccessor", "()Lsun/awt/AWTAccessor$MenuBarAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setMenuItemAccessor", "(Lsun/awt/AWTAccessor$MenuItemAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMenuItemAccessor", "()Lsun/awt/AWTAccessor$MenuItemAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setMenuAccessor", "(Lsun/awt/AWTAccessor$MenuAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMenuAccessor", "()Lsun/awt/AWTAccessor$MenuAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setKeyEventAccessor", "(Lsun/awt/AWTAccessor$KeyEventAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getKeyEventAccessor", "()Lsun/awt/AWTAccessor$KeyEventAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setClientPropertyKeyAccessor", "(Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClientPropertyKeyAccessor", "()Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setSystemTrayAccessor", "(Lsun/awt/AWTAccessor$SystemTrayAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSystemTrayAccessor", "()Lsun/awt/AWTAccessor$SystemTrayAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setTrayIconAccessor", "(Lsun/awt/AWTAccessor$TrayIconAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTrayIconAccessor", "()Lsun/awt/AWTAccessor$TrayIconAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDefaultKeyboardFocusManagerAccessor", "(Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultKeyboardFocusManagerAccessor", "()Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setSequencedEventAccessor", "(Lsun/awt/AWTAccessor$SequencedEventAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSequencedEventAccessor", "()Lsun/awt/AWTAccessor$SequencedEventAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setToolkitAccessor", "(Lsun/awt/AWTAccessor$ToolkitAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getToolkitAccessor", "()Lsun/awt/AWTAccessor$ToolkitAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setInvocationEventAccessor", "(Lsun/awt/AWTAccessor$InvocationEventAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInvocationEventAccessor", "()Lsun/awt/AWTAccessor$InvocationEventAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSystemColorAccessor", "()Lsun/awt/AWTAccessor$SystemColorAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setSystemColorAccessor", "(Lsun/awt/AWTAccessor$SystemColorAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessibleContextAccessor", "()Lsun/awt/AWTAccessor$AccessibleContextAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessibleBundleAccessor", "()Lsun/awt/AWTAccessor$AccessibleBundleAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAccessibleContextAccessor", "(Lsun/awt/AWTAccessor$AccessibleContextAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDragSourceContextAccessor", "()Lsun/awt/AWTAccessor$DragSourceContextAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDragSourceContextAccessor", "(Lsun/awt/AWTAccessor$DragSourceContextAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDropTargetContextAccessor", "()Lsun/awt/AWTAccessor$DropTargetContextAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDropTargetContextAccessor", "(Lsun/awt/AWTAccessor$DropTargetContextAccessor;)V"));
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ComponentAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor componentAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ContainerAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor containerAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$WindowAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.WindowAccessor windowAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.WindowAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AWTEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor awtEventAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$InputEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor inputEventAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MouseEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor mouseEventAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$FrameAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.FrameAccessor frameAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.FrameAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor kfmAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuComponentAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor menuComponentAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$EventQueueAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor eventQueueAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$PopupMenuAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor popupMenuAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$FileDialogAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor fileDialogAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor scrollPaneAdjustableAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor checkboxMenuItemAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$CursorAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.CursorAccessor cursorAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.CursorAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuBarAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor menuBarAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuItemAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor menuItemAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuAccessor menuAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$KeyEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor keyEventAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor clientPropertyKeyAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SystemTrayAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor systemTrayAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$TrayIconAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor trayIconAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor defaultKeyboardFocusManagerAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SequencedEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor sequencedEventAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ToolkitAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor toolkitAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$InvocationEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor invocationEventAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SystemColorAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor systemColorAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AccessibleContextAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor accessibleContextAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AccessibleBundleAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor accessibleBundleAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DragSourceContextAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor dragSourceContextAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DropTargetContextAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor dropTargetContextAccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AWTAccessor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public AWTAccessor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/AWTAccessor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static")]
	public static void ensureClassInitialized(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ComponentAccessor;)V", "public static")]
	public static void setComponentAccessor(Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ComponentAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor getComponentAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ContainerAccessor;)V", "public static")]
	public static void setContainerAccessor(Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$InputEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor getInputEventAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$AWTEventAccessor;)V", "public static")]
	public static void setAWTEventAccessor(Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$FrameAccessor;)V", "public static")]
	public static void setFrameAccessor(Dova.JDK.sun.awt.AWTAccessor.FrameAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$AccessibleBundleAccessor;)V", "public static")]
	public static void setAccessibleBundleAccessor(Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$WindowAccessor;)V", "public static")]
	public static void setWindowAccessor(Dova.JDK.sun.awt.AWTAccessor.WindowAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ContainerAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor getContainerAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$WindowAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.WindowAccessor getWindowAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.WindowAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$AWTEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor getAWTEventAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$InputEventAccessor;)V", "public static")]
	public static void setInputEventAccessor(Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MouseEventAccessor;)V", "public static")]
	public static void setMouseEventAccessor(Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MouseEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor getMouseEventAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$FrameAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.FrameAccessor getFrameAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.FrameAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;)V", "public static")]
	public static void setKeyboardFocusManagerAccessor(Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor getKeyboardFocusManagerAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MenuComponentAccessor;)V", "public static")]
	public static void setMenuComponentAccessor(Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MenuComponentAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor getMenuComponentAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$EventQueueAccessor;)V", "public static")]
	public static void setEventQueueAccessor(Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$EventQueueAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor getEventQueueAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$PopupMenuAccessor;)V", "public static")]
	public static void setPopupMenuAccessor(Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$PopupMenuAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor getPopupMenuAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$FileDialogAccessor;)V", "public static")]
	public static void setFileDialogAccessor(Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$FileDialogAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor getFileDialogAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;)V", "public static")]
	public static void setScrollPaneAdjustableAccessor(Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor getScrollPaneAdjustableAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;)V", "public static")]
	public static void setCheckboxMenuItemAccessor(Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor getCheckboxMenuItemAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$CursorAccessor;)V", "public static")]
	public static void setCursorAccessor(Dova.JDK.sun.awt.AWTAccessor.CursorAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$CursorAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.CursorAccessor getCursorAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.CursorAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MenuBarAccessor;)V", "public static")]
	public static void setMenuBarAccessor(Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MenuBarAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor getMenuBarAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MenuItemAccessor;)V", "public static")]
	public static void setMenuItemAccessor(Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MenuItemAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor getMenuItemAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MenuAccessor;)V", "public static")]
	public static void setMenuAccessor(Dova.JDK.sun.awt.AWTAccessor.MenuAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MenuAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuAccessor getMenuAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$KeyEventAccessor;)V", "public static")]
	public static void setKeyEventAccessor(Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$KeyEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor getKeyEventAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;)V", "public static")]
	public static void setClientPropertyKeyAccessor(Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor getClientPropertyKeyAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$SystemTrayAccessor;)V", "public static")]
	public static void setSystemTrayAccessor(Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$SystemTrayAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor getSystemTrayAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$TrayIconAccessor;)V", "public static")]
	public static void setTrayIconAccessor(Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$TrayIconAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor getTrayIconAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;)V", "public static")]
	public static void setDefaultKeyboardFocusManagerAccessor(Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor getDefaultKeyboardFocusManagerAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$SequencedEventAccessor;)V", "public static")]
	public static void setSequencedEventAccessor(Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$SequencedEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor getSequencedEventAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ToolkitAccessor;)V", "public static")]
	public static void setToolkitAccessor(Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ToolkitAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor getToolkitAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$InvocationEventAccessor;)V", "public static")]
	public static void setInvocationEventAccessor(Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$InvocationEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor getInvocationEventAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$SystemColorAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor getSystemColorAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$SystemColorAccessor;)V", "public static")]
	public static void setSystemColorAccessor(Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$AccessibleContextAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor getAccessibleContextAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$AccessibleBundleAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor getAccessibleBundleAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$AccessibleContextAccessor;)V", "public static")]
	public static void setAccessibleContextAccessor(Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$DragSourceContextAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor getDragSourceContextAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$DragSourceContextAccessor;)V", "public static")]
	public static void setDragSourceContextAccessor(Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$DropTargetContextAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor getDropTargetContextAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$DropTargetContextAccessor;)V", "public static")]
	public static void setDropTargetContextAccessor(Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ComponentAccessor;", "public abstract static interface")]
	public partial interface ComponentAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComponentAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$ComponentAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "(Ljava/awt/Component;)Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "(Ljava/awt/Component;)Ljava/awt/Point;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParent", "(Ljava/awt/Component;)Ljava/awt/Container;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParent", "(Ljava/awt/Component;Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljava/awt/Component;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackgroundEraseDisabled", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPeer", "(Ljava/awt/Component;Ljava/awt/peer/ComponentPeer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljava/awt/Component;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppContext", "(Ljava/awt/Component;)Lsun/awt/AppContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLightweight", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "(Ljava/awt/Component;)Ljava/awt/Color;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "(Ljava/awt/Component;)Ljava/awt/Color;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Component;Ljava/awt/Color;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "(Ljava/awt/Component;)Ljava/awt/Font;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "revalidateSynchronously", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBufferStrategy", "(Ljava/awt/Component;ILjava/awt/BufferCapabilities;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processEvent", "(Ljava/awt/Component;Ljava/awt/AWTEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "(Ljava/awt/Component;Ljava/awt/event/FocusEvent$Cause;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canBeFocusOwner", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDisplayable", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessControlContext", "(Ljava/awt/Component;)Ljava/security/AccessControlContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGraphicsConfiguration", "(Ljava/awt/Component;Ljava/awt/GraphicsConfiguration;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursor", "(Ljava/awt/Component;)Ljava/awt/Cursor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferStrategy", "(Ljava/awt/Component;)Ljava/awt/image/BufferStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIgnoreRepaint", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRequestFocusController", "(Lsun/awt/RequestFocusController;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAppContext", "(Ljava/awt/Component;Lsun/awt/AppContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeer", "(Ljava/awt/Component;)Ljava/awt/peer/ComponentPeer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackgroundEraseDisabled", "(Ljava/awt/Component;Z)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Rectangle;", "public abstract")]
		Dova.JDK.java.awt.Rectangle getBounds(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Point;", "public abstract")]
		Dova.JDK.java.awt.Point getLocation(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Container;", "public abstract")]
		Dova.JDK.java.awt.Container getParent(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Container;)V", "public abstract")]
		void setParent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Container arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;II)V", "public abstract")]
		void setSize(Dova.JDK.java.awt.Component arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool isEnabled(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool getBackgroundEraseDisabled(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/peer/ComponentPeer;)V", "public abstract")]
		void setPeer(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.peer.ComponentPeer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;II)V", "public abstract")]
		void setLocation(Dova.JDK.java.awt.Component arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Lsun/awt/AppContext;", "public abstract")]
		Dova.JDK.sun.awt.AppContext getAppContext(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool isLightweight(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Color;", "public abstract")]
		Dova.JDK.java.awt.Color getForeground(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Color;", "public abstract")]
		Dova.JDK.java.awt.Color getBackground(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Color;)V", "public abstract")]
		void setBackground(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Color arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Font;", "public abstract")]
		Dova.JDK.java.awt.Font getFont(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "public abstract")]
		int getX(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "public abstract")]
		int getY(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "public abstract")]
		int getWidth(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "public abstract")]
		int getHeight(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "public abstract")]
		void revalidateSynchronously(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool isVisible(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;ILjava/awt/BufferCapabilities;)V", "public abstract")]
		void createBufferStrategy(Dova.JDK.java.awt.Component arg0, int arg1, Dova.JDK.java.awt.BufferCapabilities arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/AWTEvent;)V", "public abstract")]
		void processEvent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.AWTEvent arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/event/FocusEvent$Cause;)V", "public abstract")]
		void requestFocus(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.@event.FocusEvent.Cause arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool canBeFocusOwner(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool isDisplayable(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/security/AccessControlContext;", "public abstract")]
		Dova.JDK.java.security.AccessControlContext getAccessControlContext(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/GraphicsConfiguration;)V", "public abstract")]
		void setGraphicsConfiguration(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.GraphicsConfiguration arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Cursor;", "public abstract")]
		Dova.JDK.java.awt.Cursor getCursor(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/image/BufferStrategy;", "public abstract")]
		Dova.JDK.java.awt.image.BufferStrategy getBufferStrategy(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferStrategy>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool getIgnoreRepaint(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/awt/RequestFocusController;)V", "public abstract")]
		void setRequestFocusController(Dova.JDK.sun.awt.RequestFocusController arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Lsun/awt/AppContext;)V", "public abstract")]
		void setAppContext(Dova.JDK.java.awt.Component arg0, Dova.JDK.sun.awt.AppContext arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/peer/ComponentPeer;", "public abstract")]
		Dova.JDK.java.lang.Object getPeer(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Z)V", "public abstract")]
		void setBackgroundEraseDisabled(Dova.JDK.java.awt.Component arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ContainerAccessor;", "public abstract static interface")]
	public partial interface ContainerAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ContainerAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$ContainerAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findComponentAt", "(Ljava/awt/Container;IIZ)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateUnconditionally", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startLWModal", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stopLWModal", "(Ljava/awt/Container;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/Container;IIZ)Ljava/awt/Component;", "public abstract")]
		Dova.JDK.java.awt.Component findComponentAt(Dova.JDK.java.awt.Container arg0, int arg1, int arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public abstract")]
		void validateUnconditionally(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public abstract")]
		void startLWModal(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public abstract")]
		void stopLWModal(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$WindowAccessor;", "public abstract static interface")]
	public partial interface WindowAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WindowAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$WindowAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTrayIconWindow", "(Ljava/awt/Window;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnedWindows", "(Ljava/awt/Window;)[Ljava/awt/Window;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateWindow", "(Ljava/awt/Window;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAutoRequestFocus", "(Ljava/awt/Window;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateSecurityWarningPosition", "(Ljava/awt/Window;DDDD)Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLWRequestStatus", "(Ljava/awt/Window;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSecurityWarningSize", "(Ljava/awt/Window;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTrayIconWindow", "(Ljava/awt/Window;Z)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)Z", "public abstract")]
		bool isTrayIconWindow(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)[Ljava/awt/Window;", "public abstract")]
		JavaArray<Dova.JDK.java.awt.Window> getOwnedWindows(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Window>>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)V", "public abstract")]
		void updateWindow(Dova.JDK.java.awt.Window arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)Z", "public abstract")]
		bool isAutoRequestFocus(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Window;DDDD)Ljava/awt/geom/Point2D;", "public abstract")]
		Dova.JDK.java.awt.geom.Point2D calculateSecurityWarningPosition(Dova.JDK.java.awt.Window arg0, double arg1, double arg2, double arg3, double arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;Z)V", "public abstract")]
		void setLWRequestStatus(Dova.JDK.java.awt.Window arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;II)V", "public abstract")]
		void setSecurityWarningSize(Dova.JDK.java.awt.Window arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;Z)V", "public abstract")]
		void setTrayIconWindow(Dova.JDK.java.awt.Window arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AWTEventAccessor;", "public abstract static interface")]
	public partial interface AWTEventAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AWTEventAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$AWTEventAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPosted", "(Ljava/awt/AWTEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSystemGenerated", "(Ljava/awt/AWTEvent;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessControlContext", "(Ljava/awt/AWTEvent;)Ljava/security/AccessControlContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBData", "(Ljava/awt/AWTEvent;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBData", "(Ljava/awt/AWTEvent;[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSystemGenerated", "(Ljava/awt/AWTEvent;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "public abstract")]
		void setPosted(Dova.JDK.java.awt.AWTEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Z", "public abstract")]
		bool isSystemGenerated(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/security/AccessControlContext;", "public abstract")]
		Dova.JDK.java.security.AccessControlContext getAccessControlContext(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)[B", "public abstract")]
		JavaArray<byte> getBData(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;[B)V", "public abstract")]
		void setBData(Dova.JDK.java.awt.AWTEvent arg0, JavaArray<byte> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "public abstract")]
		void setSystemGenerated(Dova.JDK.java.awt.AWTEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$InputEventAccessor;", "public abstract static interface")]
	public partial interface InputEventAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InputEventAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$InputEventAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canAccessSystemClipboard", "(Ljava/awt/event/InputEvent;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCanAccessSystemClipboard", "(Ljava/awt/event/InputEvent;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getButtonDownMasks", "()[I"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/InputEvent;)Z", "public abstract")]
		bool canAccessSystemClipboard(Dova.JDK.java.awt.@event.InputEvent arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/event/InputEvent;Z)V", "public abstract")]
		void setCanAccessSystemClipboard(Dova.JDK.java.awt.@event.InputEvent arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()[I", "public abstract")]
		JavaArray<int> getButtonDownMasks()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MouseEventAccessor;", "public abstract static interface")]
	public partial interface MouseEventAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MouseEventAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$MouseEventAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCausedByTouchEvent", "(Ljava/awt/event/MouseEvent;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCausedByTouchEvent", "(Ljava/awt/event/MouseEvent;Z)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Z", "public abstract")]
		bool isCausedByTouchEvent(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;Z)V", "public abstract")]
		void setCausedByTouchEvent(Dova.JDK.java.awt.@event.MouseEvent arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$FrameAccessor;", "public abstract static interface")]
	public partial interface FrameAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FrameAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$FrameAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtendedState", "(Ljava/awt/Frame;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExtendedState", "(Ljava/awt/Frame;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximizedBounds", "(Ljava/awt/Frame;)Ljava/awt/Rectangle;"));
		}

		[JniSignatureAttribute("(Ljava/awt/Frame;)I", "public abstract")]
		int getExtendedState(Dova.JDK.java.awt.Frame arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Frame;I)V", "public abstract")]
		void setExtendedState(Dova.JDK.java.awt.Frame arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Frame;)Ljava/awt/Rectangle;", "public abstract")]
		Dova.JDK.java.awt.Rectangle getMaximizedBounds(Dova.JDK.java.awt.Frame arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;", "public abstract static interface")]
	public partial interface KeyboardFocusManagerAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyboardFocusManagerAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processSynchronousLightweightTransfer", "(Ljava/awt/Component;Ljava/awt/Component;ZZJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldNativelyFocusHeavyweight", "(Ljava/awt/Component;Ljava/awt/Component;ZZJLjava/awt/event/FocusEvent$Cause;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeLastFocusRequest", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentKeyboardFocusManager", "(Lsun/awt/AppContext;)Ljava/awt/KeyboardFocusManager;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMostRecentFocusOwner", "(Ljava/awt/Window;Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMostRecentFocusOwner", "(Ljava/awt/Window;)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentFocusCycleRoot", "()Ljava/awt/Container;"));
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;ZZJ)Z", "public abstract")]
		bool processSynchronousLightweightTransfer(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1, bool arg2, bool arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;ZZJLjava/awt/event/FocusEvent$Cause;)I", "public abstract")]
		int shouldNativelyFocusHeavyweight(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1, bool arg2, bool arg3, long arg4, Dova.JDK.java.awt.@event.FocusEvent.Cause arg5)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "public abstract")]
		void removeLastFocusRequest(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lsun/awt/AppContext;)Ljava/awt/KeyboardFocusManager;", "public abstract")]
		Dova.JDK.java.awt.KeyboardFocusManager getCurrentKeyboardFocusManager(Dova.JDK.sun.awt.AppContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;Ljava/awt/Component;)V", "public abstract")]
		void setMostRecentFocusOwner(Dova.JDK.java.awt.Window arg0, Dova.JDK.java.awt.Component arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)Ljava/awt/Component;", "public abstract")]
		Dova.JDK.java.awt.Component getMostRecentFocusOwner(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Container;", "public abstract")]
		Dova.JDK.java.awt.Container getCurrentFocusCycleRoot()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuComponentAccessor;", "public abstract static interface")]
	public partial interface MenuComponentAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuComponentAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$MenuComponentAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParent", "(Ljava/awt/MenuComponent;)Ljava/awt/MenuContainer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParent", "(Ljava/awt/MenuComponent;Ljava/awt/MenuContainer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppContext", "(Ljava/awt/MenuComponent;)Lsun/awt/AppContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont_NoClientCode", "(Ljava/awt/MenuComponent;)Ljava/awt/Font;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAppContext", "(Ljava/awt/MenuComponent;Lsun/awt/AppContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeer", "(Ljava/awt/MenuComponent;)Ljava/awt/peer/MenuComponentPeer;"));
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;)Ljava/awt/MenuContainer;", "public abstract")]
		Dova.JDK.java.awt.MenuContainer getParent(Dova.JDK.java.awt.MenuComponent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.MenuContainer>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;Ljava/awt/MenuContainer;)V", "public abstract")]
		void setParent(Dova.JDK.java.awt.MenuComponent arg0, Dova.JDK.java.awt.MenuContainer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;)Lsun/awt/AppContext;", "public abstract")]
		Dova.JDK.sun.awt.AppContext getAppContext(Dova.JDK.java.awt.MenuComponent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;)Ljava/awt/Font;", "public abstract")]
		Dova.JDK.java.awt.Font getFont_NoClientCode(Dova.JDK.java.awt.MenuComponent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;Lsun/awt/AppContext;)V", "public abstract")]
		void setAppContext(Dova.JDK.java.awt.MenuComponent arg0, Dova.JDK.sun.awt.AppContext arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;)Ljava/awt/peer/MenuComponentPeer;", "public abstract")]
		Dova.JDK.java.lang.Object getPeer(Dova.JDK.java.awt.MenuComponent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$EventQueueAccessor;", "public abstract static interface")]
	public partial interface EventQueueAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EventQueueAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$EventQueueAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSourceEvents", "(Ljava/awt/EventQueue;Ljava/lang/Object;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMostRecentEventTime", "(Ljava/awt/EventQueue;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeAndWait", "(Ljava/lang/Object;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wakeup", "(Ljava/awt/EventQueue;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDispatchThreadImpl", "(Ljava/awt/EventQueue;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noEvents", "(Ljava/awt/EventQueue;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFwDispatcher", "(Ljava/awt/EventQueue;Lsun/awt/FwDispatcher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDispatchThread", "(Ljava/awt/EventQueue;)Ljava/lang/Thread;"));
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;Ljava/lang/Object;Z)V", "public abstract")]
		void removeSourceEvents(Dova.JDK.java.awt.EventQueue arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;)J", "public abstract")]
		long getMostRecentEventTime(Dova.JDK.java.awt.EventQueue arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Runnable;)V", "public abstract")]
		void invokeAndWait(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Runnable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;Z)V", "public abstract")]
		void wakeup(Dova.JDK.java.awt.EventQueue arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;)Z", "public abstract")]
		bool isDispatchThreadImpl(Dova.JDK.java.awt.EventQueue arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;)Z", "public abstract")]
		bool noEvents(Dova.JDK.java.awt.EventQueue arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;Lsun/awt/FwDispatcher;)V", "public abstract")]
		void setFwDispatcher(Dova.JDK.java.awt.EventQueue arg0, Dova.JDK.sun.awt.FwDispatcher arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;)Ljava/lang/Thread;", "public abstract")]
		Dova.JDK.java.lang.Thread getDispatchThread(Dova.JDK.java.awt.EventQueue arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$PopupMenuAccessor;", "public abstract static interface")]
	public partial interface PopupMenuAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PopupMenuAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$PopupMenuAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTrayIconPopup", "(Ljava/awt/PopupMenu;)Z"));
		}

		[JniSignatureAttribute("(Ljava/awt/PopupMenu;)Z", "public abstract")]
		bool isTrayIconPopup(Dova.JDK.java.awt.PopupMenu arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$FileDialogAccessor;", "public abstract static interface")]
	public partial interface FileDialogAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FileDialogAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$FileDialogAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDirectory", "(Ljava/awt/FileDialog;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMultipleMode", "(Ljava/awt/FileDialog;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFiles", "(Ljava/awt/FileDialog;[Ljava/io/File;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFile", "(Ljava/awt/FileDialog;Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/FileDialog;Ljava/lang/String;)V", "public abstract")]
		void setDirectory(Dova.JDK.java.awt.FileDialog arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/FileDialog;)Z", "public abstract")]
		bool isMultipleMode(Dova.JDK.java.awt.FileDialog arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/FileDialog;[Ljava/io/File;)V", "public abstract")]
		void setFiles(Dova.JDK.java.awt.FileDialog arg0, JavaArray<Dova.JDK.java.io.File> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/FileDialog;Ljava/lang/String;)V", "public abstract")]
		void setFile(Dova.JDK.java.awt.FileDialog arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;", "public abstract static interface")]
	public partial interface ScrollPaneAdjustableAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ScrollPaneAdjustableAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTypedValue", "(Ljava/awt/ScrollPaneAdjustable;II)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/ScrollPaneAdjustable;II)V", "public abstract")]
		void setTypedValue(Dova.JDK.java.awt.ScrollPaneAdjustable arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;", "public abstract static interface")]
	public partial interface CheckboxMenuItemAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckboxMenuItemAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getState", "(Ljava/awt/CheckboxMenuItem;)Z"));
		}

		[JniSignatureAttribute("(Ljava/awt/CheckboxMenuItem;)Z", "public abstract")]
		bool getState(Dova.JDK.java.awt.CheckboxMenuItem arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$CursorAccessor;", "public abstract static interface")]
	public partial interface CursorAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CursorAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$CursorAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Ljava/awt/Cursor;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPData", "(Ljava/awt/Cursor;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPData", "(Ljava/awt/Cursor;)J"));
		}

		[JniSignatureAttribute("(Ljava/awt/Cursor;)I", "public abstract")]
		int getType(Dova.JDK.java.awt.Cursor arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Cursor;J)V", "public abstract")]
		void setPData(Dova.JDK.java.awt.Cursor arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Cursor;)J", "public abstract")]
		long getPData(Dova.JDK.java.awt.Cursor arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuBarAccessor;", "public abstract static interface")]
	public partial interface MenuBarAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuBarAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$MenuBarAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHelpMenu", "(Ljava/awt/MenuBar;)Ljava/awt/Menu;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenus", "(Ljava/awt/MenuBar;)Ljava/util/Vector;"));
		}

		[JniSignatureAttribute("(Ljava/awt/MenuBar;)Ljava/awt/Menu;", "public abstract")]
		Dova.JDK.java.awt.Menu getHelpMenu(Dova.JDK.java.awt.MenuBar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Menu>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuBar;)Ljava/util/Vector;", "public abstract")]
		Dova.JDK.java.util.Vector getMenus(Dova.JDK.java.awt.MenuBar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuItemAccessor;", "public abstract static interface")]
	public partial interface MenuItemAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuItemAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$MenuItemAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "(Ljava/awt/MenuItem;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActionCommandImpl", "(Ljava/awt/MenuItem;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isItemEnabled", "(Ljava/awt/MenuItem;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortcut", "(Ljava/awt/MenuItem;)Ljava/awt/MenuShortcut;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel", "(Ljava/awt/MenuItem;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Z", "public abstract")]
		bool isEnabled(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getActionCommandImpl(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Z", "public abstract")]
		bool isItemEnabled(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Ljava/awt/MenuShortcut;", "public abstract")]
		Dova.JDK.java.awt.MenuShortcut getShortcut(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.MenuShortcut>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getLabel(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuAccessor;", "public abstract static interface")]
	public partial interface MenuAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$MenuAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItems", "(Ljava/awt/Menu;)Ljava/util/Vector;"));
		}

		[JniSignatureAttribute("(Ljava/awt/Menu;)Ljava/util/Vector;", "public abstract")]
		Dova.JDK.java.util.Vector getItems(Dova.JDK.java.awt.Menu arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$KeyEventAccessor;", "public abstract static interface")]
	public partial interface KeyEventAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyEventAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$KeyEventAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRawCode", "(Ljava/awt/event/KeyEvent;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrimaryLevelUnicode", "(Ljava/awt/event/KeyEvent;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExtendedKeyCode", "(Ljava/awt/event/KeyEvent;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginalSource", "(Ljava/awt/event/KeyEvent;)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProxyActive", "(Ljava/awt/event/KeyEvent;)Z"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;J)V", "public abstract")]
		void setRawCode(Dova.JDK.java.awt.@event.KeyEvent arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;J)V", "public abstract")]
		void setPrimaryLevelUnicode(Dova.JDK.java.awt.@event.KeyEvent arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;J)V", "public abstract")]
		void setExtendedKeyCode(Dova.JDK.java.awt.@event.KeyEvent arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Ljava/awt/Component;", "public abstract")]
		Dova.JDK.java.awt.Component getOriginalSource(Dova.JDK.java.awt.@event.KeyEvent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "public abstract")]
		bool isProxyActive(Dova.JDK.java.awt.@event.KeyEvent arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;", "public abstract static interface")]
	public partial interface ClientPropertyKeyAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClientPropertyKeyAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJComponent_TRANSFER_HANDLER", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object getJComponent_TRANSFER_HANDLER()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SystemTrayAccessor;", "public abstract static interface")]
	public partial interface SystemTrayAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SystemTrayAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$SystemTrayAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePropertyChange", "(Ljava/awt/SystemTray;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/SystemTray;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "public abstract")]
		void firePropertyChange(Dova.JDK.java.awt.SystemTray arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$TrayIconAccessor;", "public abstract static interface")]
	public partial interface TrayIconAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TrayIconAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$TrayIconAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotify", "(Ljava/awt/TrayIcon;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotify", "(Ljava/awt/TrayIcon;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/TrayIcon;)V", "public abstract")]
		void removeNotify(Dova.JDK.java.awt.TrayIcon arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/TrayIcon;)V", "public abstract")]
		void addNotify(Dova.JDK.java.awt.TrayIcon arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;", "public abstract static interface")]
	public partial interface DefaultKeyboardFocusManagerAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultKeyboardFocusManagerAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consumeNextKeyTyped", "(Ljava/awt/DefaultKeyboardFocusManager;Ljava/awt/event/KeyEvent;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/DefaultKeyboardFocusManager;Ljava/awt/event/KeyEvent;)V", "public abstract")]
		void consumeNextKeyTyped(Dova.JDK.java.awt.DefaultKeyboardFocusManager arg0, Dova.JDK.java.awt.@event.KeyEvent arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SequencedEventAccessor;", "public abstract static interface")]
	public partial interface SequencedEventAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SequencedEventAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$SequencedEventAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSequencedEvent", "(Ljava/awt/AWTEvent;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNested", "(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;"));
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;", "public abstract")]
		Dova.JDK.java.awt.AWTEvent create(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Z", "public abstract")]
		bool isSequencedEvent(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;", "public abstract")]
		Dova.JDK.java.awt.AWTEvent getNested(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ToolkitAccessor;", "public abstract static interface")]
	public partial interface ToolkitAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ToolkitAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$ToolkitAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPlatformResources", "(Ljava/util/ResourceBundle;)V"));
		}

		[JniSignatureAttribute("(Ljava/util/ResourceBundle;)V", "public abstract")]
		void setPlatformResources(Dova.JDK.java.util.ResourceBundle arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$InvocationEventAccessor;", "public abstract static interface")]
	public partial interface InvocationEventAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvocationEventAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$InvocationEventAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "(Ljava/awt/event/InvocationEvent;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/InvocationEvent;)V", "public abstract")]
		void dispose(Dova.JDK.java.awt.@event.InvocationEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SystemColorAccessor;", "public abstract static interface")]
	public partial interface SystemColorAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SystemColorAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$SystemColorAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateSystemColors", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void updateSystemColors()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AccessibleContextAccessor;", "public abstract static interface")]
	public partial interface AccessibleContextAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleContextAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$AccessibleContextAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppContext", "(Ljavax/accessibility/AccessibleContext;)Lsun/awt/AppContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAppContext", "(Ljavax/accessibility/AccessibleContext;Lsun/awt/AppContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeAXResource", "(Ljavax/accessibility/AccessibleContext;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNativeAXResource", "(Ljavax/accessibility/AccessibleContext;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleContext;)Lsun/awt/AppContext;", "public abstract")]
		Dova.JDK.sun.awt.AppContext getAppContext(Dova.JDK.javax.accessibility.AccessibleContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleContext;Lsun/awt/AppContext;)V", "public abstract")]
		void setAppContext(Dova.JDK.javax.accessibility.AccessibleContext arg0, Dova.JDK.sun.awt.AppContext arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleContext;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object getNativeAXResource(Dova.JDK.javax.accessibility.AccessibleContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleContext;Ljava/lang/Object;)V", "public abstract")]
		void setNativeAXResource(Dova.JDK.javax.accessibility.AccessibleContext arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AccessibleBundleAccessor;", "public abstract static interface")]
	public partial interface AccessibleBundleAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleBundleAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$AccessibleBundleAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "(Ljavax/accessibility/AccessibleBundle;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleBundle;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getKey(Dova.JDK.javax.accessibility.AccessibleBundle arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DragSourceContextAccessor;", "public abstract static interface")]
	public partial interface DragSourceContextAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DragSourceContextAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$DragSourceContextAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPeer", "(Ljava/awt/dnd/DragSourceContext;)Ljava/awt/dnd/peer/DragSourceContextPeer;"));
		}

		[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceContext;)Ljava/awt/dnd/peer/DragSourceContextPeer;", "public abstract")]
		Dova.JDK.java.awt.dnd.peer.DragSourceContextPeer getPeer(Dova.JDK.java.awt.dnd.DragSourceContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.peer.DragSourceContextPeer>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DropTargetContextAccessor;", "public abstract static interface")]
	public partial interface DropTargetContextAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DropTargetContextAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/AWTAccessor$DropTargetContextAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/awt/dnd/DropTargetContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDropTargetContextPeer", "(Ljava/awt/dnd/DropTargetContext;Ljava/awt/dnd/peer/DropTargetContextPeer;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/dnd/DropTargetContext;)V", "public abstract")]
		void reset(Dova.JDK.java.awt.dnd.DropTargetContext arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/dnd/DropTargetContext;Ljava/awt/dnd/peer/DropTargetContextPeer;)V", "public abstract")]
		void setDropTargetContextPeer(Dova.JDK.java.awt.dnd.DropTargetContext arg0, Dova.JDK.java.awt.dnd.peer.DropTargetContextPeer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}
}
