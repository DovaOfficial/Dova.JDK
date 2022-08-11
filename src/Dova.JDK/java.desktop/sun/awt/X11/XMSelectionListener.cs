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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XMSelectionListener;", "public abstract interface")]
public partial interface XMSelectionListener
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMSelectionListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XMSelectionListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ownerChanged", "(ILsun/awt/X11/XMSelection;JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ownerDeath", "(ILsun/awt/X11/XMSelection;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectionChanged", "(ILsun/awt/X11/XMSelection;JLsun/awt/X11/XPropertyEvent;)V"));
	}

	[JniSignatureAttribute("(ILsun/awt/X11/XMSelection;JJJ)V", "public abstract")]
	void ownerChanged(int arg0, Dova.JDK.sun.awt.X11.XMSelection arg1, long arg2, long arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILsun/awt/X11/XMSelection;J)V", "public abstract")]
	void ownerDeath(int arg0, Dova.JDK.sun.awt.X11.XMSelection arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILsun/awt/X11/XMSelection;JLsun/awt/X11/XPropertyEvent;)V", "public abstract")]
	void selectionChanged(int arg0, Dova.JDK.sun.awt.X11.XMSelection arg1, long arg2, Dova.JDK.sun.awt.X11.XPropertyEvent arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}
}
