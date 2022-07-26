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

namespace Dova.JDK.javax.swing.@event;

[JniSignatureAttribute("Ljavax/swing/event/MenuDragMouseListener;", "public abstract interface")]
public partial interface MenuDragMouseListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MenuDragMouseListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/MenuDragMouseListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuDragMouseEntered", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuDragMouseExited", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuDragMouseDragged", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuDragMouseReleased", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "public abstract")]
	void menuDragMouseEntered(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "public abstract")]
	void menuDragMouseExited(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "public abstract")]
	void menuDragMouseDragged(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "public abstract")]
	void menuDragMouseReleased(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}
}
