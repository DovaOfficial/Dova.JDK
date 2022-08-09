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

namespace Dova.JDK.java.awt.desktop;

[JniSignatureAttribute("Ljava/awt/desktop/ScreenSleepListener;", "public abstract interface")]
public partial interface ScreenSleepListener
	: IJavaObject
	, Dova.JDK.java.awt.desktop.SystemEventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ScreenSleepListener()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/desktop/ScreenSleepListener;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "screenAboutToSleep", "(Ljava/awt/desktop/ScreenSleepEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "screenAwoke", "(Ljava/awt/desktop/ScreenSleepEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/ScreenSleepEvent;)V", "public abstract")]
	void screenAboutToSleep(Dova.JDK.java.awt.desktop.ScreenSleepEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/ScreenSleepEvent;)V", "public abstract")]
	void screenAwoke(Dova.JDK.java.awt.desktop.ScreenSleepEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
