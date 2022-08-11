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

[JniSignatureAttribute("Ljava/awt/peer/MenuPeer;", "public abstract interface")]
public partial interface MenuPeer
	: IJavaObject
	, Dova.JDK.java.awt.peer.MenuItemPeer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MenuPeer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/peer/MenuPeer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addItem", "(Ljava/awt/MenuItem;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delItem", "(I)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/MenuItem;)V", "public abstract")]
	void addItem(Dova.JDK.java.awt.MenuItem arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void delItem(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
