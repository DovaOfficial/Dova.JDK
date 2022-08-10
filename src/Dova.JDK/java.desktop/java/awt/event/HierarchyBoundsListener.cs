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

namespace Dova.JDK.java.awt.@event;

[JniSignatureAttribute("Ljava/awt/event/HierarchyBoundsListener;", "public abstract interface")]
public partial interface HierarchyBoundsListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HierarchyBoundsListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/event/HierarchyBoundsListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ancestorMoved", "(Ljava/awt/event/HierarchyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ancestorResized", "(Ljava/awt/event/HierarchyEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyEvent;)V", "public abstract")]
	void ancestorMoved(Dova.JDK.java.awt.@event.HierarchyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyEvent;)V", "public abstract")]
	void ancestorResized(Dova.JDK.java.awt.@event.HierarchyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
