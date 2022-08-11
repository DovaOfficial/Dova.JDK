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

[JniSignatureAttribute("Ljava/awt/peer/MenuBarPeer;", "public abstract interface")]
public partial interface MenuBarPeer
	: IJavaObject
	, Dova.JDK.java.awt.peer.MenuComponentPeer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MenuBarPeer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/peer/MenuBarPeer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHelpMenu", "(Ljava/awt/Menu;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMenu", "(Ljava/awt/Menu;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delMenu", "(I)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/Menu;)V", "public abstract")]
	void addHelpMenu(Dova.JDK.java.awt.Menu arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Menu;)V", "public abstract")]
	void addMenu(Dova.JDK.java.awt.Menu arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void delMenu(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
