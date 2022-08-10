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

namespace Dova.JDK.sun.jvmstat.perfdata.monitor.protocol.file;

[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/protocol/file/MonitoredHostProvider;", "public")]
public partial class MonitoredHostProvider
	: Dova.JDK.sun.jvmstat.monitor.MonitoredHost
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MonitoredHostProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/perfdata/monitor/protocol/file/MonitoredHostProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_POLLING_INTERVAL", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MonitoredHostProvider", "(Lsun/jvmstat/monitor/HostIdentifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "detach", "(Lsun/jvmstat/monitor/MonitoredVm;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeHostListener", "(Lsun/jvmstat/monitor/event/HostListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "activeVms", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMonitoredVm", "(Lsun/jvmstat/monitor/VmIdentifier;I)Lsun/jvmstat/monitor/MonitoredVm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMonitoredVm", "(Lsun/jvmstat/monitor/VmIdentifier;)Lsun/jvmstat/monitor/MonitoredVm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addHostListener", "(Lsun/jvmstat/monitor/event/HostListener;)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DEFAULT_POLLING_INTERVAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MonitoredHostProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/HostIdentifier;)V", "public")]
	public MonitoredHostProvider(Dova.JDK.sun.jvmstat.monitor.HostIdentifier arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/jvmstat/perfdata/monitor/protocol/file/MonitoredHostProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/MonitoredVm;)V", "public")]
	public void detach(Dova.JDK.sun.jvmstat.monitor.MonitoredVm arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/HostListener;)V", "public")]
	public void removeHostListener(Dova.JDK.sun.jvmstat.monitor.@event.HostListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set activeVms()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/VmIdentifier;I)Lsun/jvmstat/monitor/MonitoredVm;", "public")]
	public Dova.JDK.sun.jvmstat.monitor.MonitoredVm getMonitoredVm(Dova.JDK.sun.jvmstat.monitor.VmIdentifier arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredVm>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/VmIdentifier;)Lsun/jvmstat/monitor/MonitoredVm;", "public")]
	public Dova.JDK.sun.jvmstat.monitor.MonitoredVm getMonitoredVm(Dova.JDK.sun.jvmstat.monitor.VmIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredVm>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/HostListener;)V", "public")]
	public void addHostListener(Dova.JDK.sun.jvmstat.monitor.@event.HostListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}
