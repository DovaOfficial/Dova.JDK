/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljavax/swing/event/MenuKeyListener;", "public abstract interface")]
public partial interface MenuKeyListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MenuKeyListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/MenuKeyListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "menuKeyPressed", "(Ljavax/swing/event/MenuKeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "menuKeyReleased", "(Ljavax/swing/event/MenuKeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "menuKeyTyped", "(Ljavax/swing/event/MenuKeyEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyEvent;)V", "public abstract")]
	void menuKeyPressed(Dova.JDK.javax.swing.@event.MenuKeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyEvent;)V", "public abstract")]
	void menuKeyReleased(Dova.JDK.javax.swing.@event.MenuKeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyEvent;)V", "public abstract")]
	void menuKeyTyped(Dova.JDK.javax.swing.@event.MenuKeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
