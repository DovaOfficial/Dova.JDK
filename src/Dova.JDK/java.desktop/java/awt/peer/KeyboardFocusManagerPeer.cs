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

namespace Dova.JDK.java.awt.peer;

[JniSignatureAttribute("Ljava/awt/peer/KeyboardFocusManagerPeer;", "public abstract interface")]
public partial interface KeyboardFocusManagerPeer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyboardFocusManagerPeer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/peer/KeyboardFocusManagerPeer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurrentFocusedWindow", "(Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurrentFocusOwner", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentFocusOwner", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentFocusedWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearGlobalFocusOwner", "(Ljava/awt/Window;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "public abstract")]
	void setCurrentFocusedWindow(Dova.JDK.java.awt.Window arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public abstract")]
	void setCurrentFocusOwner(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public abstract")]
	Dova.JDK.java.awt.Component getCurrentFocusOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "public abstract")]
	Dova.JDK.java.awt.Window getCurrentFocusedWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "public abstract")]
	void clearGlobalFocusOwner(Dova.JDK.java.awt.Window arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
