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

[JniSignatureAttribute("Ljavax/swing/event/TableColumnModelListener;", "public abstract interface")]
public partial interface TableColumnModelListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TableColumnModelListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/TableColumnModelListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnAdded", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnRemoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnMoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnMarginChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnSelectionChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public abstract")]
	void columnAdded(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public abstract")]
	void columnRemoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public abstract")]
	void columnMoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public abstract")]
	void columnMarginChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public abstract")]
	void columnSelectionChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
