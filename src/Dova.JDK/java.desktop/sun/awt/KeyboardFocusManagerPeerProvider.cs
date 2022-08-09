/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.awt;

[JniSignatureAttribute("Lsun/awt/KeyboardFocusManagerPeerProvider;", "public abstract interface")]
public partial interface KeyboardFocusManagerPeerProvider
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyboardFocusManagerPeerProvider()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/KeyboardFocusManagerPeerProvider;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getKeyboardFocusManagerPeer", "()Ljava/awt/peer/KeyboardFocusManagerPeer;"));
	}

	[JniSignatureAttribute("()Ljava/awt/peer/KeyboardFocusManagerPeer;", "public abstract")]
	Dova.JDK.java.awt.peer.KeyboardFocusManagerPeer getKeyboardFocusManagerPeer()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.KeyboardFocusManagerPeer>(ret);
	}
}
