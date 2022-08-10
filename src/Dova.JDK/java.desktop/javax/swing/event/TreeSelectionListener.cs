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

[JniSignatureAttribute("Ljavax/swing/event/TreeSelectionListener;", "public abstract interface")]
public partial interface TreeSelectionListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TreeSelectionListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/TreeSelectionListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "valueChanged", "(Ljavax/swing/event/TreeSelectionEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionEvent;)V", "public abstract")]
	void valueChanged(Dova.JDK.javax.swing.@event.TreeSelectionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
