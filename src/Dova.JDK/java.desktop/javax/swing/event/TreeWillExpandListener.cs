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

[JniSignatureAttribute("Ljavax/swing/event/TreeWillExpandListener;", "public abstract interface")]
public partial interface TreeWillExpandListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TreeWillExpandListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/TreeWillExpandListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeWillExpand", "(Ljavax/swing/event/TreeExpansionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeWillCollapse", "(Ljavax/swing/event/TreeExpansionEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionEvent;)V", "public abstract")]
	void treeWillExpand(Dova.JDK.javax.swing.@event.TreeExpansionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionEvent;)V", "public abstract")]
	void treeWillCollapse(Dova.JDK.javax.swing.@event.TreeExpansionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
