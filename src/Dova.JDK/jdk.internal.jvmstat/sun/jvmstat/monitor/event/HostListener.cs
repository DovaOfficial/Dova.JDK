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

namespace Dova.JDK.sun.jvmstat.monitor.@event;

[JniSignatureAttribute("Lsun/jvmstat/monitor/event/HostListener;", "public abstract interface")]
public partial interface HostListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HostListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/monitor/event/HostListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "disconnected", "(Lsun/jvmstat/monitor/event/HostEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "vmStatusChanged", "(Lsun/jvmstat/monitor/event/VmStatusChangeEvent;)V"));
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/HostEvent;)V", "public abstract")]
	void disconnected(Dova.JDK.sun.jvmstat.monitor.@event.HostEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/VmStatusChangeEvent;)V", "public abstract")]
	void vmStatusChanged(Dova.JDK.sun.jvmstat.monitor.@event.VmStatusChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
