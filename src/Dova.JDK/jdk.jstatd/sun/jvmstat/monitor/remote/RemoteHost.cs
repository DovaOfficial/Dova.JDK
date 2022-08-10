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

namespace Dova.JDK.sun.jvmstat.monitor.remote;

[JniSignatureAttribute("Lsun/jvmstat/monitor/remote/RemoteHost;", "public abstract interface")]
public partial interface RemoteHost
	: IJavaObject
	, Dova.JDK.java.rmi.Remote
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RemoteHost()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/monitor/remote/RemoteHost;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "activeVms", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "attachVm", "(ILjava/lang/String;)Lsun/jvmstat/monitor/remote/RemoteVm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "detachVm", "(Lsun/jvmstat/monitor/remote/RemoteVm;)V"));
	}

	[JniSignatureAttribute("()[I", "public abstract")]
	JavaArray<int> activeVms()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Lsun/jvmstat/monitor/remote/RemoteVm;", "public abstract")]
	Dova.JDK.sun.jvmstat.monitor.remote.RemoteVm attachVm(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.remote.RemoteVm>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/remote/RemoteVm;)V", "public abstract")]
	void detachVm(Dova.JDK.sun.jvmstat.monitor.remote.RemoteVm arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
