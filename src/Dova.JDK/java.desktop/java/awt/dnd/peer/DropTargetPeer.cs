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

namespace Dova.JDK.java.awt.dnd.peer;

[JniSignatureAttribute("Ljava/awt/dnd/peer/DropTargetPeer;", "public abstract interface")]
public partial interface DropTargetPeer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DropTargetPeer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/dnd/peer/DropTargetPeer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDropTarget", "(Ljava/awt/dnd/DropTarget;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDropTarget", "(Ljava/awt/dnd/DropTarget;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DropTarget;)V", "public abstract")]
	void addDropTarget(Dova.JDK.java.awt.dnd.DropTarget arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DropTarget;)V", "public abstract")]
	void removeDropTarget(Dova.JDK.java.awt.dnd.DropTarget arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
