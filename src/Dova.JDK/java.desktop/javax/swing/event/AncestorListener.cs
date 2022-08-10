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

namespace Dova.JDK.javax.swing.@event;

[JniSignatureAttribute("Ljavax/swing/event/AncestorListener;", "public abstract interface")]
public partial interface AncestorListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AncestorListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/AncestorListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ancestorAdded", "(Ljavax/swing/event/AncestorEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ancestorRemoved", "(Ljavax/swing/event/AncestorEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ancestorMoved", "(Ljavax/swing/event/AncestorEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/event/AncestorEvent;)V", "public abstract")]
	void ancestorAdded(Dova.JDK.javax.swing.@event.AncestorEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/AncestorEvent;)V", "public abstract")]
	void ancestorRemoved(Dova.JDK.javax.swing.@event.AncestorEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/AncestorEvent;)V", "public abstract")]
	void ancestorMoved(Dova.JDK.javax.swing.@event.AncestorEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
