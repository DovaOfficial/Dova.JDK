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

namespace Dova.JDK.sun.jvmstat.perfdata.monitor.protocol.file;

[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/protocol/file/MonitoredHostFileService;", "public final")]
public partial class MonitoredHostFileService
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.jvmstat.monitor.MonitoredHostService
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MonitoredHostFileService()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/jvmstat/perfdata/monitor/protocol/file/MonitoredHostFileService;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MonitoredHostFileService", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getScheme", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMonitoredHost", "(Lsun/jvmstat/monitor/HostIdentifier;)Lsun/jvmstat/monitor/MonitoredHost;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MonitoredHostFileService(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MonitoredHostFileService() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/jvmstat/perfdata/monitor/protocol/file/MonitoredHostFileService;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getScheme()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/HostIdentifier;)Lsun/jvmstat/monitor/MonitoredHost;", "public")]
	public Dova.JDK.sun.jvmstat.monitor.MonitoredHost getMonitoredHost(Dova.JDK.sun.jvmstat.monitor.HostIdentifier arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredHost>(ret);
	}
}