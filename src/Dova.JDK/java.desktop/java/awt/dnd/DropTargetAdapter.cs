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

[JniSignatureAttribute("Ljava/awt/dnd/DropTargetAdapter;", "public abstract")]
public partial class DropTargetAdapter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.dnd.DropTargetListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DropTargetAdapter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/dnd/DropTargetAdapter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dragEnter", "(Ljava/awt/dnd/DropTargetDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dragOver", "(Ljava/awt/dnd/DropTargetDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropActionChanged", "(Ljava/awt/dnd/DropTargetDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dragExit", "(Ljava/awt/dnd/DropTargetEvent;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DropTargetAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public DropTargetAdapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/dnd/DropTargetAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/dnd/DropTargetDragEvent;)V", "public")]
	public void dragEnter(Dova.JDK.java.awt.dnd.DropTargetDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DropTargetDragEvent;)V", "public")]
	public void dragOver(Dova.JDK.java.awt.dnd.DropTargetDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DropTargetDragEvent;)V", "public")]
	public void dropActionChanged(Dova.JDK.java.awt.dnd.DropTargetDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DropTargetEvent;)V", "public")]
	public void dragExit(Dova.JDK.java.awt.dnd.DropTargetEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}
}
