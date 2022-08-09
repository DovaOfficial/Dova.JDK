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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "componentAccessor", "Lsun/awt/AWTAccessor$ComponentAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "containerAccessor", "Lsun/awt/AWTAccessor$ContainerAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "windowAccessor", "Lsun/awt/AWTAccessor$WindowAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "awtEventAccessor", "Lsun/awt/AWTAccessor$AWTEventAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "inputEventAccessor", "Lsun/awt/AWTAccessor$InputEventAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "mouseEventAccessor", "Lsun/awt/AWTAccessor$MouseEventAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "frameAccessor", "Lsun/awt/AWTAccessor$FrameAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "kfmAccessor", "Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "menuComponentAccessor", "Lsun/awt/AWTAccessor$MenuComponentAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "eventQueueAccessor", "Lsun/awt/AWTAccessor$EventQueueAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "popupMenuAccessor", "Lsun/awt/AWTAccessor$PopupMenuAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "fileDialogAccessor", "Lsun/awt/AWTAccessor$FileDialogAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "scrollPaneAdjustableAccessor", "Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "checkboxMenuItemAccessor", "Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursorAccessor", "Lsun/awt/AWTAccessor$CursorAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "menuBarAccessor", "Lsun/awt/AWTAccessor$MenuBarAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "menuItemAccessor", "Lsun/awt/AWTAccessor$MenuItemAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "menuAccessor", "Lsun/awt/AWTAccessor$MenuAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "keyEventAccessor", "Lsun/awt/AWTAccessor$KeyEventAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "clientPropertyKeyAccessor", "Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "systemTrayAccessor", "Lsun/awt/AWTAccessor$SystemTrayAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "trayIconAccessor", "Lsun/awt/AWTAccessor$TrayIconAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "defaultKeyboardFocusManagerAccessor", "Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sequencedEventAccessor", "Lsun/awt/AWTAccessor$SequencedEventAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "toolkitAccessor", "Lsun/awt/AWTAccessor$ToolkitAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "invocationEventAccessor", "Lsun/awt/AWTAccessor$InvocationEventAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "systemColorAccessor", "Lsun/awt/AWTAccessor$SystemColorAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "accessibleContextAccessor", "Lsun/awt/AWTAccessor$AccessibleContextAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "accessibleBundleAccessor", "Lsun/awt/AWTAccessor$AccessibleBundleAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dragSourceContextAccessor", "Lsun/awt/AWTAccessor$DragSourceContextAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dropTargetContextAccessor", "Lsun/awt/AWTAccessor$DropTargetContextAccessor;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AWTAccessor", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ensureClassInitialized", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setComponentAccessor", "(Lsun/awt/AWTAccessor$ComponentAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getComponentAccessor", "()Lsun/awt/AWTAccessor$ComponentAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setContainerAccessor", "(Lsun/awt/AWTAccessor$ContainerAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getInputEventAccessor", "()Lsun/awt/AWTAccessor$InputEventAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setAWTEventAccessor", "(Lsun/awt/AWTAccessor$AWTEventAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setFrameAccessor", "(Lsun/awt/AWTAccessor$FrameAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setAccessibleBundleAccessor", "(Lsun/awt/AWTAccessor$AccessibleBundleAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setWindowAccessor", "(Lsun/awt/AWTAccessor$WindowAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getContainerAccessor", "()Lsun/awt/AWTAccessor$ContainerAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getWindowAccessor", "()Lsun/awt/AWTAccessor$WindowAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAWTEventAccessor", "()Lsun/awt/AWTAccessor$AWTEventAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setInputEventAccessor", "(Lsun/awt/AWTAccessor$InputEventAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setMouseEventAccessor", "(Lsun/awt/AWTAccessor$MouseEventAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getMouseEventAccessor", "()Lsun/awt/AWTAccessor$MouseEventAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getFrameAccessor", "()Lsun/awt/AWTAccessor$FrameAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setKeyboardFocusManagerAccessor", "(Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyboardFocusManagerAccessor", "()Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setMenuComponentAccessor", "(Lsun/awt/AWTAccessor$MenuComponentAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getMenuComponentAccessor", "()Lsun/awt/AWTAccessor$MenuComponentAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setEventQueueAccessor", "(Lsun/awt/AWTAccessor$EventQueueAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getEventQueueAccessor", "()Lsun/awt/AWTAccessor$EventQueueAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setPopupMenuAccessor", "(Lsun/awt/AWTAccessor$PopupMenuAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getPopupMenuAccessor", "()Lsun/awt/AWTAccessor$PopupMenuAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setFileDialogAccessor", "(Lsun/awt/AWTAccessor$FileDialogAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getFileDialogAccessor", "()Lsun/awt/AWTAccessor$FileDialogAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setScrollPaneAdjustableAccessor", "(Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getScrollPaneAdjustableAccessor", "()Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setCheckboxMenuItemAccessor", "(Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getCheckboxMenuItemAccessor", "()Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setCursorAccessor", "(Lsun/awt/AWTAccessor$CursorAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getCursorAccessor", "()Lsun/awt/AWTAccessor$CursorAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setMenuBarAccessor", "(Lsun/awt/AWTAccessor$MenuBarAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getMenuBarAccessor", "()Lsun/awt/AWTAccessor$MenuBarAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setMenuItemAccessor", "(Lsun/awt/AWTAccessor$MenuItemAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getMenuItemAccessor", "()Lsun/awt/AWTAccessor$MenuItemAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setMenuAccessor", "(Lsun/awt/AWTAccessor$MenuAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getMenuAccessor", "()Lsun/awt/AWTAccessor$MenuAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setKeyEventAccessor", "(Lsun/awt/AWTAccessor$KeyEventAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyEventAccessor", "()Lsun/awt/AWTAccessor$KeyEventAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setClientPropertyKeyAccessor", "(Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getClientPropertyKeyAccessor", "()Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setSystemTrayAccessor", "(Lsun/awt/AWTAccessor$SystemTrayAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getSystemTrayAccessor", "()Lsun/awt/AWTAccessor$SystemTrayAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setTrayIconAccessor", "(Lsun/awt/AWTAccessor$TrayIconAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getTrayIconAccessor", "()Lsun/awt/AWTAccessor$TrayIconAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setDefaultKeyboardFocusManagerAccessor", "(Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getDefaultKeyboardFocusManagerAccessor", "()Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setSequencedEventAccessor", "(Lsun/awt/AWTAccessor$SequencedEventAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getSequencedEventAccessor", "()Lsun/awt/AWTAccessor$SequencedEventAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setToolkitAccessor", "(Lsun/awt/AWTAccessor$ToolkitAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getToolkitAccessor", "()Lsun/awt/AWTAccessor$ToolkitAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setInvocationEventAccessor", "(Lsun/awt/AWTAccessor$InvocationEventAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getInvocationEventAccessor", "()Lsun/awt/AWTAccessor$InvocationEventAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getSystemColorAccessor", "()Lsun/awt/AWTAccessor$SystemColorAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setSystemColorAccessor", "(Lsun/awt/AWTAccessor$SystemColorAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAccessibleContextAccessor", "()Lsun/awt/AWTAccessor$AccessibleContextAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAccessibleBundleAccessor", "()Lsun/awt/AWTAccessor$AccessibleBundleAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setAccessibleContextAccessor", "(Lsun/awt/AWTAccessor$AccessibleContextAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getDragSourceContextAccessor", "()Lsun/awt/AWTAccessor$DragSourceContextAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setDragSourceContextAccessor", "(Lsun/awt/AWTAccessor$DragSourceContextAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getDropTargetContextAccessor", "()Lsun/awt/AWTAccessor$DropTargetContextAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setDropTargetContextAccessor", "(Lsun/awt/AWTAccessor$DropTargetContextAccessor;)V"));
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ComponentAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor componentAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ContainerAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor containerAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$WindowAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.WindowAccessor windowAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.WindowAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AWTEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor awtEventAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$InputEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor inputEventAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MouseEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor mouseEventAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$FrameAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.FrameAccessor frameAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.FrameAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor kfmAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuComponentAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor menuComponentAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$EventQueueAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor eventQueueAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$PopupMenuAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor popupMenuAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$FileDialogAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor fileDialogAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor scrollPaneAdjustableAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor checkboxMenuItemAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$CursorAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.CursorAccessor cursorAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.CursorAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuBarAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor menuBarAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuItemAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor menuItemAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$MenuAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuAccessor menuAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$KeyEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor keyEventAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor clientPropertyKeyAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SystemTrayAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor systemTrayAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$TrayIconAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor trayIconAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor defaultKeyboardFocusManagerAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SequencedEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor sequencedEventAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$ToolkitAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor toolkitAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$InvocationEventAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor invocationEventAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$SystemColorAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor systemColorAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AccessibleContextAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor accessibleContextAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$AccessibleBundleAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor accessibleBundleAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DragSourceContextAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor dragSourceContextAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/AWTAccessor$DropTargetContextAccessor;", "private static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor dropTargetContextAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AWTAccessor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public AWTAccessor() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/AWTAccessor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static")]
	public static void ensureClassInitialized(Dova.JDK.java.lang.Class arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ComponentAccessor;)V", "public static")]
	public static void setComponentAccessor(Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ComponentAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor getComponentAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ComponentAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ContainerAccessor;)V", "public static")]
	public static void setContainerAccessor(Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$InputEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor getInputEventAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$AWTEventAccessor;)V", "public static")]
	public static void setAWTEventAccessor(Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$FrameAccessor;)V", "public static")]
	public static void setFrameAccessor(Dova.JDK.sun.awt.AWTAccessor.FrameAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$AccessibleBundleAccessor;)V", "public static")]
	public static void setAccessibleBundleAccessor(Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$WindowAccessor;)V", "public static")]
	public static void setWindowAccessor(Dova.JDK.sun.awt.AWTAccessor.WindowAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ContainerAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor getContainerAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ContainerAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$WindowAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.WindowAccessor getWindowAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.WindowAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$AWTEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor getAWTEventAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AWTEventAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$InputEventAccessor;)V", "public static")]
	public static void setInputEventAccessor(Dova.JDK.sun.awt.AWTAccessor.InputEventAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MouseEventAccessor;)V", "public static")]
	public static void setMouseEventAccessor(Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MouseEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor getMouseEventAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MouseEventAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$FrameAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.FrameAccessor getFrameAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.FrameAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;)V", "public static")]
	public static void setKeyboardFocusManagerAccessor(Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor getKeyboardFocusManagerAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.KeyboardFocusManagerAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MenuComponentAccessor;)V", "public static")]
	public static void setMenuComponentAccessor(Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MenuComponentAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor getMenuComponentAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuComponentAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$EventQueueAccessor;)V", "public static")]
	public static void setEventQueueAccessor(Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$EventQueueAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor getEventQueueAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.EventQueueAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$PopupMenuAccessor;)V", "public static")]
	public static void setPopupMenuAccessor(Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$PopupMenuAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor getPopupMenuAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.PopupMenuAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$FileDialogAccessor;)V", "public static")]
	public static void setFileDialogAccessor(Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$FileDialogAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor getFileDialogAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.FileDialogAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;)V", "public static")]
	public static void setScrollPaneAdjustableAccessor(Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor getScrollPaneAdjustableAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ScrollPaneAdjustableAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;)V", "public static")]
	public static void setCheckboxMenuItemAccessor(Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor getCheckboxMenuItemAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.CheckboxMenuItemAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$CursorAccessor;)V", "public static")]
	public static void setCursorAccessor(Dova.JDK.sun.awt.AWTAccessor.CursorAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$CursorAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.CursorAccessor getCursorAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.CursorAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MenuBarAccessor;)V", "public static")]
	public static void setMenuBarAccessor(Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MenuBarAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor getMenuBarAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuBarAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MenuItemAccessor;)V", "public static")]
	public static void setMenuItemAccessor(Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MenuItemAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor getMenuItemAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuItemAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$MenuAccessor;)V", "public static")]
	public static void setMenuAccessor(Dova.JDK.sun.awt.AWTAccessor.MenuAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$MenuAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.MenuAccessor getMenuAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.MenuAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$KeyEventAccessor;)V", "public static")]
	public static void setKeyEventAccessor(Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$KeyEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor getKeyEventAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.KeyEventAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;)V", "public static")]
	public static void setClientPropertyKeyAccessor(Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor getClientPropertyKeyAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ClientPropertyKeyAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$SystemTrayAccessor;)V", "public static")]
	public static void setSystemTrayAccessor(Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$SystemTrayAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor getSystemTrayAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SystemTrayAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$TrayIconAccessor;)V", "public static")]
	public static void setTrayIconAccessor(Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$TrayIconAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor getTrayIconAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.TrayIconAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;)V", "public static")]
	public static void setDefaultKeyboardFocusManagerAccessor(Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor getDefaultKeyboardFocusManagerAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DefaultKeyboardFocusManagerAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$SequencedEventAccessor;)V", "public static")]
	public static void setSequencedEventAccessor(Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$SequencedEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor getSequencedEventAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SequencedEventAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$ToolkitAccessor;)V", "public static")]
	public static void setToolkitAccessor(Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$ToolkitAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor getToolkitAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.ToolkitAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$InvocationEventAccessor;)V", "public static")]
	public static void setInvocationEventAccessor(Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$InvocationEventAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor getInvocationEventAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.InvocationEventAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$SystemColorAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor getSystemColorAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$SystemColorAccessor;)V", "public static")]
	public static void setSystemColorAccessor(Dova.JDK.sun.awt.AWTAccessor.SystemColorAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$AccessibleContextAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor getAccessibleContextAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$AccessibleBundleAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor getAccessibleBundleAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.AccessibleBundleAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$AccessibleContextAccessor;)V", "public static")]
	public static void setAccessibleContextAccessor(Dova.JDK.sun.awt.AWTAccessor.AccessibleContextAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$DragSourceContextAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor getDragSourceContextAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$DragSourceContextAccessor;)V", "public static")]
	public static void setDragSourceContextAccessor(Dova.JDK.sun.awt.AWTAccessor.DragSourceContextAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/AWTAccessor$DropTargetContextAccessor;", "public static")]
	public static Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor getDropTargetContextAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AWTAccessor$DropTargetContextAccessor;)V", "public static")]
	public static void setDropTargetContextAccessor(Dova.JDK.sun.awt.AWTAccessor.DropTargetContextAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[62], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$ComponentAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBounds", "(Ljava/awt/Component;)Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLocation", "(Ljava/awt/Component;)Ljava/awt/Point;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getParent", "(Ljava/awt/Component;)Ljava/awt/Container;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setParent", "(Ljava/awt/Component;Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSize", "(Ljava/awt/Component;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isEnabled", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBackgroundEraseDisabled", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setPeer", "(Ljava/awt/Component;Ljava/awt/peer/ComponentPeer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setLocation", "(Ljava/awt/Component;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAppContext", "(Ljava/awt/Component;)Lsun/awt/AppContext;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isLightweight", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getForeground", "(Ljava/awt/Component;)Ljava/awt/Color;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBackground", "(Ljava/awt/Component;)Ljava/awt/Color;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setBackground", "(Ljava/awt/Component;Ljava/awt/Color;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFont", "(Ljava/awt/Component;)Ljava/awt/Font;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getX", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getY", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getWidth", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getHeight", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "revalidateSynchronously", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isVisible", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createBufferStrategy", "(Ljava/awt/Component;ILjava/awt/BufferCapabilities;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "processEvent", "(Ljava/awt/Component;Ljava/awt/AWTEvent;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "requestFocus", "(Ljava/awt/Component;Ljava/awt/event/FocusEvent$Cause;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "canBeFocusOwner", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isDisplayable", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAccessControlContext", "(Ljava/awt/Component;)Ljava/security/AccessControlContext;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setGraphicsConfiguration", "(Ljava/awt/Component;Ljava/awt/GraphicsConfiguration;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCursor", "(Ljava/awt/Component;)Ljava/awt/Cursor;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBufferStrategy", "(Ljava/awt/Component;)Ljava/awt/image/BufferStrategy;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getIgnoreRepaint", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setRequestFocusController", "(Lsun/awt/RequestFocusController;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setAppContext", "(Ljava/awt/Component;Lsun/awt/AppContext;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPeer", "(Ljava/awt/Component;)Ljava/awt/peer/ComponentPeer;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setBackgroundEraseDisabled", "(Ljava/awt/Component;Z)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Rectangle;", "public abstract")]
		Dova.JDK.java.awt.Rectangle getBounds(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Point;", "public abstract")]
		Dova.JDK.java.awt.Point getLocation(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Container;", "public abstract")]
		Dova.JDK.java.awt.Container getParent(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Container;)V", "public abstract")]
		void setParent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Container arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;II)V", "public abstract")]
		void setSize(Dova.JDK.java.awt.Component arg0, int arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool isEnabled(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool getBackgroundEraseDisabled(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/peer/ComponentPeer;)V", "public abstract")]
		void setPeer(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.peer.ComponentPeer arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;II)V", "public abstract")]
		void setLocation(Dova.JDK.java.awt.Component arg0, int arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Lsun/awt/AppContext;", "public abstract")]
		Dova.JDK.sun.awt.AppContext getAppContext(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool isLightweight(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Color;", "public abstract")]
		Dova.JDK.java.awt.Color getForeground(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Color;", "public abstract")]
		Dova.JDK.java.awt.Color getBackground(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Color;)V", "public abstract")]
		void setBackground(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Color arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Font;", "public abstract")]
		Dova.JDK.java.awt.Font getFont(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "public abstract")]
		int getX(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "public abstract")]
		int getY(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "public abstract")]
		int getWidth(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "public abstract")]
		int getHeight(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "public abstract")]
		void revalidateSynchronously(Dova.JDK.java.awt.Component arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool isVisible(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;ILjava/awt/BufferCapabilities;)V", "public abstract")]
		void createBufferStrategy(Dova.JDK.java.awt.Component arg0, int arg1, Dova.JDK.java.awt.BufferCapabilities arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/AWTEvent;)V", "public abstract")]
		void processEvent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.AWTEvent arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/event/FocusEvent$Cause;)V", "public abstract")]
		void requestFocus(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.@event.FocusEvent.Cause arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool canBeFocusOwner(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool isDisplayable(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/security/AccessControlContext;", "public abstract")]
		Dova.JDK.java.security.AccessControlContext getAccessControlContext(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/GraphicsConfiguration;)V", "public abstract")]
		void setGraphicsConfiguration(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.GraphicsConfiguration arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Cursor;", "public abstract")]
		Dova.JDK.java.awt.Cursor getCursor(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/image/BufferStrategy;", "public abstract")]
		Dova.JDK.java.awt.image.BufferStrategy getBufferStrategy(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferStrategy>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public abstract")]
		bool getIgnoreRepaint(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/awt/RequestFocusController;)V", "public abstract")]
		void setRequestFocusController(Dova.JDK.sun.awt.RequestFocusController arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Lsun/awt/AppContext;)V", "public abstract")]
		void setAppContext(Dova.JDK.java.awt.Component arg0, Dova.JDK.sun.awt.AppContext arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/peer/ComponentPeer;", "public abstract")]
		Dova.JDK.java.lang.Object getPeer(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Z)V", "public abstract")]
		void setBackgroundEraseDisabled(Dova.JDK.java.awt.Component arg0, bool arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$ContainerAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findComponentAt", "(Ljava/awt/Container;IIZ)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "validateUnconditionally", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "startLWModal", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "stopLWModal", "(Ljava/awt/Container;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/Container;IIZ)Ljava/awt/Component;", "public abstract")]
		Dova.JDK.java.awt.Component findComponentAt(Dova.JDK.java.awt.Container arg0, int arg1, int arg2, bool arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public abstract")]
		void validateUnconditionally(Dova.JDK.java.awt.Container arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public abstract")]
		void startLWModal(Dova.JDK.java.awt.Container arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public abstract")]
		void stopLWModal(Dova.JDK.java.awt.Container arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$WindowAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isTrayIconWindow", "(Ljava/awt/Window;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOwnedWindows", "(Ljava/awt/Window;)[Ljava/awt/Window;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateWindow", "(Ljava/awt/Window;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isAutoRequestFocus", "(Ljava/awt/Window;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "calculateSecurityWarningPosition", "(Ljava/awt/Window;DDDD)Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setLWRequestStatus", "(Ljava/awt/Window;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSecurityWarningSize", "(Ljava/awt/Window;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setTrayIconWindow", "(Ljava/awt/Window;Z)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)Z", "public abstract")]
		bool isTrayIconWindow(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)[Ljava/awt/Window;", "public abstract")]
		JavaArray<Dova.JDK.java.awt.Window> getOwnedWindows(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Window>>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)V", "public abstract")]
		void updateWindow(Dova.JDK.java.awt.Window arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)Z", "public abstract")]
		bool isAutoRequestFocus(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Window;DDDD)Ljava/awt/geom/Point2D;", "public abstract")]
		Dova.JDK.java.awt.geom.Point2D calculateSecurityWarningPosition(Dova.JDK.java.awt.Window arg0, double arg1, double arg2, double arg3, double arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;Z)V", "public abstract")]
		void setLWRequestStatus(Dova.JDK.java.awt.Window arg0, bool arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;II)V", "public abstract")]
		void setSecurityWarningSize(Dova.JDK.java.awt.Window arg0, int arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;Z)V", "public abstract")]
		void setTrayIconWindow(Dova.JDK.java.awt.Window arg0, bool arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$AWTEventAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setPosted", "(Ljava/awt/AWTEvent;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isSystemGenerated", "(Ljava/awt/AWTEvent;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAccessControlContext", "(Ljava/awt/AWTEvent;)Ljava/security/AccessControlContext;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBData", "(Ljava/awt/AWTEvent;)[B"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setBData", "(Ljava/awt/AWTEvent;[B)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSystemGenerated", "(Ljava/awt/AWTEvent;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "public abstract")]
		void setPosted(Dova.JDK.java.awt.AWTEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Z", "public abstract")]
		bool isSystemGenerated(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/security/AccessControlContext;", "public abstract")]
		Dova.JDK.java.security.AccessControlContext getAccessControlContext(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)[B", "public abstract")]
		JavaArray<byte> getBData(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;[B)V", "public abstract")]
		void setBData(Dova.JDK.java.awt.AWTEvent arg0, JavaArray<byte> arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "public abstract")]
		void setSystemGenerated(Dova.JDK.java.awt.AWTEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$InputEventAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "canAccessSystemClipboard", "(Ljava/awt/event/InputEvent;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setCanAccessSystemClipboard", "(Ljava/awt/event/InputEvent;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getButtonDownMasks", "()[I"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/InputEvent;)Z", "public abstract")]
		bool canAccessSystemClipboard(Dova.JDK.java.awt.@event.InputEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/event/InputEvent;Z)V", "public abstract")]
		void setCanAccessSystemClipboard(Dova.JDK.java.awt.@event.InputEvent arg0, bool arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()[I", "public abstract")]
		JavaArray<int> getButtonDownMasks()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$MouseEventAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isCausedByTouchEvent", "(Ljava/awt/event/MouseEvent;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setCausedByTouchEvent", "(Ljava/awt/event/MouseEvent;Z)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Z", "public abstract")]
		bool isCausedByTouchEvent(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;Z)V", "public abstract")]
		void setCausedByTouchEvent(Dova.JDK.java.awt.@event.MouseEvent arg0, bool arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$FrameAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExtendedState", "(Ljava/awt/Frame;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setExtendedState", "(Ljava/awt/Frame;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMaximizedBounds", "(Ljava/awt/Frame;)Ljava/awt/Rectangle;"));
		}

		[JniSignatureAttribute("(Ljava/awt/Frame;)I", "public abstract")]
		int getExtendedState(Dova.JDK.java.awt.Frame arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Frame;I)V", "public abstract")]
		void setExtendedState(Dova.JDK.java.awt.Frame arg0, int arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Frame;)Ljava/awt/Rectangle;", "public abstract")]
		Dova.JDK.java.awt.Rectangle getMaximizedBounds(Dova.JDK.java.awt.Frame arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$KeyboardFocusManagerAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "processSynchronousLightweightTransfer", "(Ljava/awt/Component;Ljava/awt/Component;ZZJ)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "shouldNativelyFocusHeavyweight", "(Ljava/awt/Component;Ljava/awt/Component;ZZJLjava/awt/event/FocusEvent$Cause;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeLastFocusRequest", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCurrentKeyboardFocusManager", "(Lsun/awt/AppContext;)Ljava/awt/KeyboardFocusManager;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setMostRecentFocusOwner", "(Ljava/awt/Window;Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMostRecentFocusOwner", "(Ljava/awt/Window;)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCurrentFocusCycleRoot", "()Ljava/awt/Container;"));
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;ZZJ)Z", "public abstract")]
		bool processSynchronousLightweightTransfer(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1, bool arg2, bool arg3, long arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;ZZJLjava/awt/event/FocusEvent$Cause;)I", "public abstract")]
		int shouldNativelyFocusHeavyweight(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1, bool arg2, bool arg3, long arg4, Dova.JDK.java.awt.@event.FocusEvent.Cause arg5)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "public abstract")]
		void removeLastFocusRequest(Dova.JDK.java.awt.Component arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lsun/awt/AppContext;)Ljava/awt/KeyboardFocusManager;", "public abstract")]
		Dova.JDK.java.awt.KeyboardFocusManager getCurrentKeyboardFocusManager(Dova.JDK.sun.awt.AppContext arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;Ljava/awt/Component;)V", "public abstract")]
		void setMostRecentFocusOwner(Dova.JDK.java.awt.Window arg0, Dova.JDK.java.awt.Component arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)Ljava/awt/Component;", "public abstract")]
		Dova.JDK.java.awt.Component getMostRecentFocusOwner(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Container;", "public abstract")]
		Dova.JDK.java.awt.Container getCurrentFocusCycleRoot()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$MenuComponentAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getParent", "(Ljava/awt/MenuComponent;)Ljava/awt/MenuContainer;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setParent", "(Ljava/awt/MenuComponent;Ljava/awt/MenuContainer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAppContext", "(Ljava/awt/MenuComponent;)Lsun/awt/AppContext;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFont_NoClientCode", "(Ljava/awt/MenuComponent;)Ljava/awt/Font;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setAppContext", "(Ljava/awt/MenuComponent;Lsun/awt/AppContext;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPeer", "(Ljava/awt/MenuComponent;)Ljava/awt/peer/MenuComponentPeer;"));
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;)Ljava/awt/MenuContainer;", "public abstract")]
		Dova.JDK.java.awt.MenuContainer getParent(Dova.JDK.java.awt.MenuComponent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.MenuContainer>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;Ljava/awt/MenuContainer;)V", "public abstract")]
		void setParent(Dova.JDK.java.awt.MenuComponent arg0, Dova.JDK.java.awt.MenuContainer arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;)Lsun/awt/AppContext;", "public abstract")]
		Dova.JDK.sun.awt.AppContext getAppContext(Dova.JDK.java.awt.MenuComponent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;)Ljava/awt/Font;", "public abstract")]
		Dova.JDK.java.awt.Font getFont_NoClientCode(Dova.JDK.java.awt.MenuComponent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;Lsun/awt/AppContext;)V", "public abstract")]
		void setAppContext(Dova.JDK.java.awt.MenuComponent arg0, Dova.JDK.sun.awt.AppContext arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuComponent;)Ljava/awt/peer/MenuComponentPeer;", "public abstract")]
		Dova.JDK.java.lang.Object getPeer(Dova.JDK.java.awt.MenuComponent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$EventQueueAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeSourceEvents", "(Ljava/awt/EventQueue;Ljava/lang/Object;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMostRecentEventTime", "(Ljava/awt/EventQueue;)J"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "invokeAndWait", "(Ljava/lang/Object;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wakeup", "(Ljava/awt/EventQueue;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isDispatchThreadImpl", "(Ljava/awt/EventQueue;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "noEvents", "(Ljava/awt/EventQueue;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setFwDispatcher", "(Ljava/awt/EventQueue;Lsun/awt/FwDispatcher;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDispatchThread", "(Ljava/awt/EventQueue;)Ljava/lang/Thread;"));
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;Ljava/lang/Object;Z)V", "public abstract")]
		void removeSourceEvents(Dova.JDK.java.awt.EventQueue arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;)J", "public abstract")]
		long getMostRecentEventTime(Dova.JDK.java.awt.EventQueue arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Runnable;)V", "public abstract")]
		void invokeAndWait(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Runnable arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;Z)V", "public abstract")]
		void wakeup(Dova.JDK.java.awt.EventQueue arg0, bool arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;)Z", "public abstract")]
		bool isDispatchThreadImpl(Dova.JDK.java.awt.EventQueue arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;)Z", "public abstract")]
		bool noEvents(Dova.JDK.java.awt.EventQueue arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;Lsun/awt/FwDispatcher;)V", "public abstract")]
		void setFwDispatcher(Dova.JDK.java.awt.EventQueue arg0, Dova.JDK.sun.awt.FwDispatcher arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;)Ljava/lang/Thread;", "public abstract")]
		Dova.JDK.java.lang.Thread getDispatchThread(Dova.JDK.java.awt.EventQueue arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$PopupMenuAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isTrayIconPopup", "(Ljava/awt/PopupMenu;)Z"));
		}

		[JniSignatureAttribute("(Ljava/awt/PopupMenu;)Z", "public abstract")]
		bool isTrayIconPopup(Dova.JDK.java.awt.PopupMenu arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$FileDialogAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDirectory", "(Ljava/awt/FileDialog;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isMultipleMode", "(Ljava/awt/FileDialog;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setFiles", "(Ljava/awt/FileDialog;[Ljava/io/File;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setFile", "(Ljava/awt/FileDialog;Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/FileDialog;Ljava/lang/String;)V", "public abstract")]
		void setDirectory(Dova.JDK.java.awt.FileDialog arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/FileDialog;)Z", "public abstract")]
		bool isMultipleMode(Dova.JDK.java.awt.FileDialog arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/FileDialog;[Ljava/io/File;)V", "public abstract")]
		void setFiles(Dova.JDK.java.awt.FileDialog arg0, JavaArray<Dova.JDK.java.io.File> arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/FileDialog;Ljava/lang/String;)V", "public abstract")]
		void setFile(Dova.JDK.java.awt.FileDialog arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$ScrollPaneAdjustableAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setTypedValue", "(Ljava/awt/ScrollPaneAdjustable;II)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/ScrollPaneAdjustable;II)V", "public abstract")]
		void setTypedValue(Dova.JDK.java.awt.ScrollPaneAdjustable arg0, int arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$CheckboxMenuItemAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getState", "(Ljava/awt/CheckboxMenuItem;)Z"));
		}

		[JniSignatureAttribute("(Ljava/awt/CheckboxMenuItem;)Z", "public abstract")]
		bool getState(Dova.JDK.java.awt.CheckboxMenuItem arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$CursorAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getType", "(Ljava/awt/Cursor;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setPData", "(Ljava/awt/Cursor;J)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPData", "(Ljava/awt/Cursor;)J"));
		}

		[JniSignatureAttribute("(Ljava/awt/Cursor;)I", "public abstract")]
		int getType(Dova.JDK.java.awt.Cursor arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Cursor;J)V", "public abstract")]
		void setPData(Dova.JDK.java.awt.Cursor arg0, long arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Cursor;)J", "public abstract")]
		long getPData(Dova.JDK.java.awt.Cursor arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$MenuBarAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getHelpMenu", "(Ljava/awt/MenuBar;)Ljava/awt/Menu;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMenus", "(Ljava/awt/MenuBar;)Ljava/util/Vector;"));
		}

		[JniSignatureAttribute("(Ljava/awt/MenuBar;)Ljava/awt/Menu;", "public abstract")]
		Dova.JDK.java.awt.Menu getHelpMenu(Dova.JDK.java.awt.MenuBar arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Menu>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuBar;)Ljava/util/Vector;", "public abstract")]
		Dova.JDK.java.util.Vector getMenus(Dova.JDK.java.awt.MenuBar arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$MenuItemAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isEnabled", "(Ljava/awt/MenuItem;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getActionCommandImpl", "(Ljava/awt/MenuItem;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isItemEnabled", "(Ljava/awt/MenuItem;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getShortcut", "(Ljava/awt/MenuItem;)Ljava/awt/MenuShortcut;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLabel", "(Ljava/awt/MenuItem;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Z", "public abstract")]
		bool isEnabled(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getActionCommandImpl(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Z", "public abstract")]
		bool isItemEnabled(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Ljava/awt/MenuShortcut;", "public abstract")]
		Dova.JDK.java.awt.MenuShortcut getShortcut(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.MenuShortcut>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/MenuItem;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getLabel(Dova.JDK.java.awt.MenuItem arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$MenuAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getItems", "(Ljava/awt/Menu;)Ljava/util/Vector;"));
		}

		[JniSignatureAttribute("(Ljava/awt/Menu;)Ljava/util/Vector;", "public abstract")]
		Dova.JDK.java.util.Vector getItems(Dova.JDK.java.awt.Menu arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$KeyEventAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setRawCode", "(Ljava/awt/event/KeyEvent;J)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setPrimaryLevelUnicode", "(Ljava/awt/event/KeyEvent;J)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setExtendedKeyCode", "(Ljava/awt/event/KeyEvent;J)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOriginalSource", "(Ljava/awt/event/KeyEvent;)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isProxyActive", "(Ljava/awt/event/KeyEvent;)Z"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;J)V", "public abstract")]
		void setRawCode(Dova.JDK.java.awt.@event.KeyEvent arg0, long arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;J)V", "public abstract")]
		void setPrimaryLevelUnicode(Dova.JDK.java.awt.@event.KeyEvent arg0, long arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;J)V", "public abstract")]
		void setExtendedKeyCode(Dova.JDK.java.awt.@event.KeyEvent arg0, long arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Ljava/awt/Component;", "public abstract")]
		Dova.JDK.java.awt.Component getOriginalSource(Dova.JDK.java.awt.@event.KeyEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "public abstract")]
		bool isProxyActive(Dova.JDK.java.awt.@event.KeyEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$ClientPropertyKeyAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getJComponent_TRANSFER_HANDLER", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object getJComponent_TRANSFER_HANDLER()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$SystemTrayAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "firePropertyChange", "(Ljava/awt/SystemTray;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/SystemTray;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "public abstract")]
		void firePropertyChange(Dova.JDK.java.awt.SystemTray arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$TrayIconAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeNotify", "(Ljava/awt/TrayIcon;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addNotify", "(Ljava/awt/TrayIcon;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/TrayIcon;)V", "public abstract")]
		void removeNotify(Dova.JDK.java.awt.TrayIcon arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/TrayIcon;)V", "public abstract")]
		void addNotify(Dova.JDK.java.awt.TrayIcon arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$DefaultKeyboardFocusManagerAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "consumeNextKeyTyped", "(Ljava/awt/DefaultKeyboardFocusManager;Ljava/awt/event/KeyEvent;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/DefaultKeyboardFocusManager;Ljava/awt/event/KeyEvent;)V", "public abstract")]
		void consumeNextKeyTyped(Dova.JDK.java.awt.DefaultKeyboardFocusManager arg0, Dova.JDK.java.awt.@event.KeyEvent arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$SequencedEventAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "create", "(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isSequencedEvent", "(Ljava/awt/AWTEvent;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNested", "(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;"));
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;", "public abstract")]
		Dova.JDK.java.awt.AWTEvent create(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Z", "public abstract")]
		bool isSequencedEvent(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;", "public abstract")]
		Dova.JDK.java.awt.AWTEvent getNested(Dova.JDK.java.awt.AWTEvent arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$ToolkitAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setPlatformResources", "(Ljava/util/ResourceBundle;)V"));
		}

		[JniSignatureAttribute("(Ljava/util/ResourceBundle;)V", "public abstract")]
		void setPlatformResources(Dova.JDK.java.util.ResourceBundle arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$InvocationEventAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispose", "(Ljava/awt/event/InvocationEvent;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/InvocationEvent;)V", "public abstract")]
		void dispose(Dova.JDK.java.awt.@event.InvocationEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$SystemColorAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateSystemColors", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void updateSystemColors()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$AccessibleContextAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAppContext", "(Ljavax/accessibility/AccessibleContext;)Lsun/awt/AppContext;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setAppContext", "(Ljavax/accessibility/AccessibleContext;Lsun/awt/AppContext;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNativeAXResource", "(Ljavax/accessibility/AccessibleContext;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setNativeAXResource", "(Ljavax/accessibility/AccessibleContext;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleContext;)Lsun/awt/AppContext;", "public abstract")]
		Dova.JDK.sun.awt.AppContext getAppContext(Dova.JDK.javax.accessibility.AccessibleContext arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleContext;Lsun/awt/AppContext;)V", "public abstract")]
		void setAppContext(Dova.JDK.javax.accessibility.AccessibleContext arg0, Dova.JDK.sun.awt.AppContext arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleContext;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object getNativeAXResource(Dova.JDK.javax.accessibility.AccessibleContext arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleContext;Ljava/lang/Object;)V", "public abstract")]
		void setNativeAXResource(Dova.JDK.javax.accessibility.AccessibleContext arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$AccessibleBundleAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getKey", "(Ljavax/accessibility/AccessibleBundle;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleBundle;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getKey(Dova.JDK.javax.accessibility.AccessibleBundle arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$DragSourceContextAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPeer", "(Ljava/awt/dnd/DragSourceContext;)Ljava/awt/dnd/peer/DragSourceContextPeer;"));
		}

		[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceContext;)Ljava/awt/dnd/peer/DragSourceContextPeer;", "public abstract")]
		Dova.JDK.java.awt.dnd.peer.DragSourceContextPeer getPeer(Dova.JDK.java.awt.dnd.DragSourceContext arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/AWTAccessor$DropTargetContextAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "reset", "(Ljava/awt/dnd/DropTargetContext;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDropTargetContextPeer", "(Ljava/awt/dnd/DropTargetContext;Ljava/awt/dnd/peer/DropTargetContextPeer;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/dnd/DropTargetContext;)V", "public abstract")]
		void reset(Dova.JDK.java.awt.dnd.DropTargetContext arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/dnd/DropTargetContext;Ljava/awt/dnd/peer/DropTargetContextPeer;)V", "public abstract")]
		void setDropTargetContextPeer(Dova.JDK.java.awt.dnd.DropTargetContext arg0, Dova.JDK.java.awt.dnd.peer.DropTargetContextPeer arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}
}
