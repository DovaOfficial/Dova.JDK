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

[JniSignatureAttribute("Lsun/jvmstat/monitor/LongMonitor;", "public abstract interface")]
public partial interface LongMonitor
	: IJavaObject
	, Dova.JDK.sun.jvmstat.monitor.Monitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LongMonitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/monitor/LongMonitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longValue", "()J"));
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long longValue()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}
}
