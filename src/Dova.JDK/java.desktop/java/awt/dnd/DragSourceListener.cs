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

namespace Dova.JDK.java.awt.dnd;

[JniSignatureAttribute("Ljava/awt/dnd/DragSourceListener;", "public abstract interface")]
public partial interface DragSourceListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DragSourceListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/dnd/DragSourceListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dragEnter", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dragOver", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropActionChanged", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dragExit", "(Ljava/awt/dnd/DragSourceEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dragDropEnd", "(Ljava/awt/dnd/DragSourceDropEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "public abstract")]
	void dragEnter(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "public abstract")]
	void dragOver(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "public abstract")]
	void dropActionChanged(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceEvent;)V", "public abstract")]
	void dragExit(Dova.JDK.java.awt.dnd.DragSourceEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDropEvent;)V", "public abstract")]
	void dragDropEnd(Dova.JDK.java.awt.dnd.DragSourceDropEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
