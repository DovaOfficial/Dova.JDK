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

[JniSignatureAttribute("Lsun/awt/X11/XStateProtocol;", "public abstract interface")]
public partial interface XStateProtocol
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XStateProtocol()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XStateProtocol;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getState", "(Lsun/awt/X11/XWindowPeer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setState", "(Lsun/awt/X11/XWindowPeer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unshadeKludge", "(Lsun/awt/X11/XWindowPeer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsState", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStateChange", "(Lsun/awt/X11/XPropertyEvent;)Z"));
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;)I", "public abstract")]
	int getState(Dova.JDK.sun.awt.X11.XWindowPeer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;I)V", "public abstract")]
	void setState(Dova.JDK.sun.awt.X11.XWindowPeer arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;)V", "public abstract")]
	void unshadeKludge(Dova.JDK.sun.awt.X11.XWindowPeer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(I)Z", "public abstract")]
	bool supportsState(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XPropertyEvent;)Z", "public abstract")]
	bool isStateChange(Dova.JDK.sun.awt.X11.XPropertyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}
}
