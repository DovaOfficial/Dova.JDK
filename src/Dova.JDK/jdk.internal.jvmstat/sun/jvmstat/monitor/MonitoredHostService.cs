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

namespace Dova.JDK.sun.jvmstat.monitor;

[JniSignatureAttribute("Lsun/jvmstat/monitor/MonitoredHostService;", "public abstract interface")]
public partial interface MonitoredHostService
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MonitoredHostService()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/monitor/MonitoredHostService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScheme", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonitoredHost", "(Lsun/jvmstat/monitor/HostIdentifier;)Lsun/jvmstat/monitor/MonitoredHost;"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getScheme()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/HostIdentifier;)Lsun/jvmstat/monitor/MonitoredHost;", "public abstract")]
	Dova.JDK.sun.jvmstat.monitor.MonitoredHost getMonitoredHost(Dova.JDK.sun.jvmstat.monitor.HostIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredHost>(ret);
	}
}
