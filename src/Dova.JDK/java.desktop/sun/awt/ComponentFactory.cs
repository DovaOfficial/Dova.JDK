/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Lsun/awt/ComponentFactory;", "public abstract interface")]
public partial interface ComponentFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ComponentFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/ComponentFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createLabel", "(Ljava/awt/Label;)Ljava/awt/peer/LabelPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createFrame", "(Ljava/awt/Frame;)Ljava/awt/peer/FramePeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createWindow", "(Ljava/awt/Window;)Ljava/awt/peer/WindowPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createDialog", "(Ljava/awt/Dialog;)Ljava/awt/peer/DialogPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createDesktopPeer", "(Ljava/awt/Desktop;)Ljava/awt/peer/DesktopPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTaskbarPeer", "(Ljava/awt/Taskbar;)Ljava/awt/peer/TaskbarPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createButton", "(Ljava/awt/Button;)Ljava/awt/peer/ButtonPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTextField", "(Ljava/awt/TextField;)Ljava/awt/peer/TextFieldPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createList", "(Ljava/awt/List;)Ljava/awt/peer/ListPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createCheckbox", "(Ljava/awt/Checkbox;)Ljava/awt/peer/CheckboxPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createScrollbar", "(Ljava/awt/Scrollbar;)Ljava/awt/peer/ScrollbarPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createScrollPane", "(Ljava/awt/ScrollPane;)Ljava/awt/peer/ScrollPanePeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTextArea", "(Ljava/awt/TextArea;)Ljava/awt/peer/TextAreaPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createChoice", "(Ljava/awt/Choice;)Ljava/awt/peer/ChoicePeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createCanvas", "(Ljava/awt/Canvas;)Ljava/awt/peer/CanvasPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPanel", "(Ljava/awt/Panel;)Ljava/awt/peer/PanelPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMenuBar", "(Ljava/awt/MenuBar;)Ljava/awt/peer/MenuBarPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMenu", "(Ljava/awt/Menu;)Ljava/awt/peer/MenuPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPopupMenu", "(Ljava/awt/PopupMenu;)Ljava/awt/peer/PopupMenuPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMenuItem", "(Ljava/awt/MenuItem;)Ljava/awt/peer/MenuItemPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createFileDialog", "(Ljava/awt/FileDialog;)Ljava/awt/peer/FileDialogPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createCheckboxMenuItem", "(Ljava/awt/CheckboxMenuItem;)Ljava/awt/peer/CheckboxMenuItemPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createDragSourceContextPeer", "(Ljava/awt/dnd/DragGestureEvent;)Ljava/awt/dnd/peer/DragSourceContextPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFontPeer", "(Ljava/lang/String;I)Ljava/awt/peer/FontPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createRobot", "(Ljava/awt/GraphicsDevice;)Ljava/awt/peer/RobotPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDataTransferer", "()Lsun/awt/datatransfer/DataTransferer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMouseInfoPeer", "()Ljava/awt/peer/MouseInfoPeer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createComponent", "(Ljava/awt/Component;)Ljava/awt/peer/LightweightPeer;"));
	}

	[JniSignatureAttribute("(Ljava/awt/Label;)Ljava/awt/peer/LabelPeer;", "public")]
	Dova.JDK.java.awt.peer.LabelPeer createLabel(Dova.JDK.java.awt.Label arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.LabelPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Frame;)Ljava/awt/peer/FramePeer;", "public")]
	Dova.JDK.java.awt.peer.FramePeer createFrame(Dova.JDK.java.awt.Frame arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.FramePeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)Ljava/awt/peer/WindowPeer;", "public")]
	Dova.JDK.java.awt.peer.WindowPeer createWindow(Dova.JDK.java.awt.Window arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.WindowPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;)Ljava/awt/peer/DialogPeer;", "public")]
	Dova.JDK.java.awt.peer.DialogPeer createDialog(Dova.JDK.java.awt.Dialog arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.DialogPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Desktop;)Ljava/awt/peer/DesktopPeer;", "public")]
	Dova.JDK.java.awt.peer.DesktopPeer createDesktopPeer(Dova.JDK.java.awt.Desktop arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.DesktopPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Taskbar;)Ljava/awt/peer/TaskbarPeer;", "public")]
	Dova.JDK.java.awt.peer.TaskbarPeer createTaskbarPeer(Dova.JDK.java.awt.Taskbar arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.TaskbarPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Button;)Ljava/awt/peer/ButtonPeer;", "public")]
	Dova.JDK.java.awt.peer.ButtonPeer createButton(Dova.JDK.java.awt.Button arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.ButtonPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/TextField;)Ljava/awt/peer/TextFieldPeer;", "public")]
	Dova.JDK.java.awt.peer.TextFieldPeer createTextField(Dova.JDK.java.awt.TextField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.TextFieldPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/List;)Ljava/awt/peer/ListPeer;", "public")]
	Dova.JDK.java.awt.peer.ListPeer createList(Dova.JDK.java.awt.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.ListPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Checkbox;)Ljava/awt/peer/CheckboxPeer;", "public")]
	Dova.JDK.java.awt.peer.CheckboxPeer createCheckbox(Dova.JDK.java.awt.Checkbox arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.CheckboxPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Scrollbar;)Ljava/awt/peer/ScrollbarPeer;", "public")]
	Dova.JDK.java.awt.peer.ScrollbarPeer createScrollbar(Dova.JDK.java.awt.Scrollbar arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.ScrollbarPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/ScrollPane;)Ljava/awt/peer/ScrollPanePeer;", "public")]
	Dova.JDK.java.awt.peer.ScrollPanePeer createScrollPane(Dova.JDK.java.awt.ScrollPane arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.ScrollPanePeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/TextArea;)Ljava/awt/peer/TextAreaPeer;", "public")]
	Dova.JDK.java.awt.peer.TextAreaPeer createTextArea(Dova.JDK.java.awt.TextArea arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.TextAreaPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Choice;)Ljava/awt/peer/ChoicePeer;", "public")]
	Dova.JDK.java.awt.peer.ChoicePeer createChoice(Dova.JDK.java.awt.Choice arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.ChoicePeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Canvas;)Ljava/awt/peer/CanvasPeer;", "public")]
	Dova.JDK.java.awt.peer.CanvasPeer createCanvas(Dova.JDK.java.awt.Canvas arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.CanvasPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Panel;)Ljava/awt/peer/PanelPeer;", "public")]
	Dova.JDK.java.awt.peer.PanelPeer createPanel(Dova.JDK.java.awt.Panel arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.PanelPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/MenuBar;)Ljava/awt/peer/MenuBarPeer;", "public")]
	Dova.JDK.java.awt.peer.MenuBarPeer createMenuBar(Dova.JDK.java.awt.MenuBar arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.MenuBarPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Menu;)Ljava/awt/peer/MenuPeer;", "public")]
	Dova.JDK.java.awt.peer.MenuPeer createMenu(Dova.JDK.java.awt.Menu arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.MenuPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/PopupMenu;)Ljava/awt/peer/PopupMenuPeer;", "public")]
	Dova.JDK.java.awt.peer.PopupMenuPeer createPopupMenu(Dova.JDK.java.awt.PopupMenu arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.PopupMenuPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/MenuItem;)Ljava/awt/peer/MenuItemPeer;", "public")]
	Dova.JDK.java.awt.peer.MenuItemPeer createMenuItem(Dova.JDK.java.awt.MenuItem arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.MenuItemPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/FileDialog;)Ljava/awt/peer/FileDialogPeer;", "public")]
	Dova.JDK.java.awt.peer.FileDialogPeer createFileDialog(Dova.JDK.java.awt.FileDialog arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.FileDialogPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/CheckboxMenuItem;)Ljava/awt/peer/CheckboxMenuItemPeer;", "public")]
	Dova.JDK.java.awt.peer.CheckboxMenuItemPeer createCheckboxMenuItem(Dova.JDK.java.awt.CheckboxMenuItem arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.CheckboxMenuItemPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;)Ljava/awt/dnd/peer/DragSourceContextPeer;", "public")]
	Dova.JDK.java.awt.dnd.peer.DragSourceContextPeer createDragSourceContextPeer(Dova.JDK.java.awt.dnd.DragGestureEvent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.peer.DragSourceContextPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/awt/peer/FontPeer;", "public")]
	Dova.JDK.java.awt.peer.FontPeer getFontPeer(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.FontPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsDevice;)Ljava/awt/peer/RobotPeer;", "public")]
	Dova.JDK.java.awt.peer.RobotPeer createRobot(Dova.JDK.java.awt.GraphicsDevice arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.RobotPeer>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/datatransfer/DataTransferer;", "public")]
	Dova.JDK.sun.awt.datatransfer.DataTransferer getDataTransferer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.datatransfer.DataTransferer>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/peer/MouseInfoPeer;", "public")]
	Dova.JDK.java.awt.peer.MouseInfoPeer getMouseInfoPeer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.MouseInfoPeer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/peer/LightweightPeer;", "public")]
	Dova.JDK.java.awt.peer.LightweightPeer createComponent(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.LightweightPeer>(ret);
	}
}
