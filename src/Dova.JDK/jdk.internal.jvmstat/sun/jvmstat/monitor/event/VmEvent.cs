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

namespace Dova.JDK.sun.jvmstat.monitor.@event;

[JniSignatureAttribute("Lsun/jvmstat/monitor/event/VmEvent;", "public")]
public partial class VmEvent
	: Dova.JDK.java.util.EventObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VmEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/monitor/event/VmEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/jvmstat/monitor/MonitoredVm;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonitoredVm", "()Lsun/jvmstat/monitor/MonitoredVm;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VmEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/MonitoredVm;)V", "public")]
	public VmEvent(Dova.JDK.sun.jvmstat.monitor.MonitoredVm arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/jvmstat/monitor/event/VmEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/jvmstat/monitor/MonitoredVm;", "public")]
	public Dova.JDK.sun.jvmstat.monitor.MonitoredVm getMonitoredVm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredVm>(ret);
	}
}
