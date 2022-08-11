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

namespace Dova.JDK.java.awt.desktop;

[JniSignatureAttribute("Ljava/awt/desktop/AppHiddenListener;", "public abstract interface")]
public partial interface AppHiddenListener
	: IJavaObject
	, Dova.JDK.java.awt.desktop.SystemEventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AppHiddenListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/desktop/AppHiddenListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appHidden", "(Ljava/awt/desktop/AppHiddenEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appUnhidden", "(Ljava/awt/desktop/AppHiddenEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/AppHiddenEvent;)V", "public abstract")]
	void appHidden(Dova.JDK.java.awt.desktop.AppHiddenEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/AppHiddenEvent;)V", "public abstract")]
	void appUnhidden(Dova.JDK.java.awt.desktop.AppHiddenEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
