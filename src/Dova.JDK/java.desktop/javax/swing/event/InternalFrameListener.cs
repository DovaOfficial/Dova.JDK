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

[JniSignatureAttribute("Ljavax/swing/event/InternalFrameListener;", "public abstract interface")]
public partial interface InternalFrameListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InternalFrameListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/InternalFrameListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalFrameOpened", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalFrameClosing", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalFrameClosed", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalFrameIconified", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalFrameDeiconified", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalFrameActivated", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalFrameDeactivated", "(Ljavax/swing/event/InternalFrameEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public abstract")]
	void internalFrameOpened(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public abstract")]
	void internalFrameClosing(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public abstract")]
	void internalFrameClosed(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public abstract")]
	void internalFrameIconified(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public abstract")]
	void internalFrameDeiconified(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public abstract")]
	void internalFrameActivated(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public abstract")]
	void internalFrameDeactivated(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
