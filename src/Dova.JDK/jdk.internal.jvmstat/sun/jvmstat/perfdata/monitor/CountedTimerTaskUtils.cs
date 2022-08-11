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

namespace Dova.JDK.sun.jvmstat.perfdata.monitor;

[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/CountedTimerTaskUtils;", "public")]
public partial class CountedTimerTaskUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CountedTimerTaskUtils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/perfdata/monitor/CountedTimerTaskUtils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reschedule", "(Ljava/util/Timer;Lsun/jvmstat/perfdata/monitor/CountedTimerTask;Lsun/jvmstat/perfdata/monitor/CountedTimerTask;II)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CountedTimerTaskUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CountedTimerTaskUtils() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/jvmstat/perfdata/monitor/CountedTimerTaskUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Timer;Lsun/jvmstat/perfdata/monitor/CountedTimerTask;Lsun/jvmstat/perfdata/monitor/CountedTimerTask;II)V", "public static")]
	public static void reschedule(Dova.JDK.java.util.Timer arg0, Dova.JDK.sun.jvmstat.perfdata.monitor.CountedTimerTask arg1, Dova.JDK.sun.jvmstat.perfdata.monitor.CountedTimerTask arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}
}
