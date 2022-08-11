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

[JniSignatureAttribute("Ljavax/swing/event/PopupMenuListener;", "public abstract interface")]
public partial interface PopupMenuListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PopupMenuListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/PopupMenuListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuWillBecomeVisible", "(Ljavax/swing/event/PopupMenuEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuWillBecomeInvisible", "(Ljavax/swing/event/PopupMenuEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuCanceled", "(Ljavax/swing/event/PopupMenuEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public abstract")]
	void popupMenuWillBecomeVisible(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public abstract")]
	void popupMenuWillBecomeInvisible(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public abstract")]
	void popupMenuCanceled(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
