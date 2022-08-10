/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljava/awt/desktop/SystemSleepListener;", "public abstract interface")]
public partial interface SystemSleepListener
	: IJavaObject
	, Dova.JDK.java.awt.desktop.SystemEventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SystemSleepListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/desktop/SystemSleepListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "systemAboutToSleep", "(Ljava/awt/desktop/SystemSleepEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "systemAwoke", "(Ljava/awt/desktop/SystemSleepEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/SystemSleepEvent;)V", "public abstract")]
	void systemAboutToSleep(Dova.JDK.java.awt.desktop.SystemSleepEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/SystemSleepEvent;)V", "public abstract")]
	void systemAwoke(Dova.JDK.java.awt.desktop.SystemSleepEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
