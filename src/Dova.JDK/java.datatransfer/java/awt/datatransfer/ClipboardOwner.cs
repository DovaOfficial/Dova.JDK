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

namespace Dova.JDK.java.awt.datatransfer;

[JniSignatureAttribute("Ljava/awt/datatransfer/ClipboardOwner;", "public abstract interface")]
public partial interface ClipboardOwner
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClipboardOwner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/datatransfer/ClipboardOwner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lostOwnership", "(Ljava/awt/datatransfer/Clipboard;Ljava/awt/datatransfer/Transferable;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/Clipboard;Ljava/awt/datatransfer/Transferable;)V", "public abstract")]
	void lostOwnership(Dova.JDK.java.awt.datatransfer.Clipboard arg0, Dova.JDK.java.awt.datatransfer.Transferable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
