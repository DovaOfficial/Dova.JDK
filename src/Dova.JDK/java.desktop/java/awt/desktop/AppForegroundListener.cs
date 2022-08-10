/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljava/awt/desktop/AppForegroundListener;", "public abstract interface")]
public partial interface AppForegroundListener
	: IJavaObject
	, Dova.JDK.java.awt.desktop.SystemEventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AppForegroundListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/desktop/AppForegroundListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "appRaisedToForeground", "(Ljava/awt/desktop/AppForegroundEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "appMovedToBackground", "(Ljava/awt/desktop/AppForegroundEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/AppForegroundEvent;)V", "public abstract")]
	void appRaisedToForeground(Dova.JDK.java.awt.desktop.AppForegroundEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/AppForegroundEvent;)V", "public abstract")]
	void appMovedToBackground(Dova.JDK.java.awt.desktop.AppForegroundEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
