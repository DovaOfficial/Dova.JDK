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

[JniSignatureAttribute("Lsun/awt/X11/XModalityProtocol;", "public abstract interface")]
public partial interface XModalityProtocol
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XModalityProtocol()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XModalityProtocol;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBlocked", "(Lsun/awt/X11/XDialogPeer;Lsun/awt/X11/XWindowPeer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setModal", "(Lsun/awt/X11/XDialogPeer;Z)Z"));
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XDialogPeer;Lsun/awt/X11/XWindowPeer;)Z", "public abstract")]
	bool isBlocked(Dova.JDK.sun.awt.X11.XDialogPeer arg0, Dova.JDK.sun.awt.X11.XWindowPeer arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XDialogPeer;Z)Z", "public abstract")]
	bool setModal(Dova.JDK.sun.awt.X11.XDialogPeer arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}
}
