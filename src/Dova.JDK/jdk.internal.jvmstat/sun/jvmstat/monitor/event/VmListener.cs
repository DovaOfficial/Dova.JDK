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

namespace Dova.JDK.sun.jvmstat.monitor.@event;

[JniSignatureAttribute("Lsun/jvmstat/monitor/event/VmListener;", "public abstract interface")]
public partial interface VmListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VmListener()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/jvmstat/monitor/event/VmListener;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "monitorStatusChanged", "(Lsun/jvmstat/monitor/event/MonitorStatusChangeEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "monitorsUpdated", "(Lsun/jvmstat/monitor/event/VmEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "disconnected", "(Lsun/jvmstat/monitor/event/VmEvent;)V"));
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/MonitorStatusChangeEvent;)V", "public abstract")]
	void monitorStatusChanged(Dova.JDK.sun.jvmstat.monitor.@event.MonitorStatusChangeEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/VmEvent;)V", "public abstract")]
	void monitorsUpdated(Dova.JDK.sun.jvmstat.monitor.@event.VmEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/VmEvent;)V", "public abstract")]
	void disconnected(Dova.JDK.sun.jvmstat.monitor.@event.VmEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}