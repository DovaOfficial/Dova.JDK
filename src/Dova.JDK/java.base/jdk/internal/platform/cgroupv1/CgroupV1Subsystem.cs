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

namespace Dova.JDK.jdk.@internal.platform.cgroupv1;

[JniSignatureAttribute("Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;", "public")]
public partial class CgroupV1Subsystem
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.platform.CgroupSubsystem
	, Dova.JDK.jdk.@internal.platform.CgroupV1Metrics
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CgroupV1Subsystem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "memory", "Ljdk/internal/platform/cgroupv1/CgroupV1MemorySubSystemController;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cpu", "Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cpuacct", "Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cpuset", "Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "blkio", "Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pids", "Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROVIDER_NAME", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/util/Map;)Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvider", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEffectiveCpuCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuPeriod", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuQuota", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuShares", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuSetCpus", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEffectiveCpuSetCpus", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuSetMems", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEffectiveCpuSetMems", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryLimit", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemorySoftLimit", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryAndSwapLimit", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPidsMax", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLongValue", "(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPerCpuUsage", "()[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuUserUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuSystemUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuNumPeriods", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuNumThrottled", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuThrottledTime", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryFailCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTcpMemoryUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPidsCurrent", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlkIOServiceCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlkIOServiced", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryMaxUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKernelMemoryFailCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKernelMemoryMaxUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKernelMemoryUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTcpMemoryFailCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTcpMemoryMaxUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryAndSwapFailCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryAndSwapMaxUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMemoryOOMKillEnabled", "()Ljava/lang/Boolean;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuSetMemoryPressure", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCpuSetMemoryPressureEnabled", "()Ljava/lang/Boolean;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initSubSystem", "(Ljava/util/Map;)Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHierarchical", "(Ljdk/internal/platform/cgroupv1/CgroupV1MemorySubSystemController;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSwapEnabled", "(Ljdk/internal/platform/cgroupv1/CgroupV1MemorySubSystemController;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemorySubSystem", "(Ljdk/internal/platform/cgroupv1/CgroupV1MemorySubSystemController;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCpuSetController", "(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCpuAcctController", "(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCpuController", "(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlkIOController", "(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPidsController", "(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryAndSwapUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryUsage", "()J"));
	}

	[JniSignatureAttribute("Ljdk/internal/platform/cgroupv1/CgroupV1MemorySubSystemController;", "private")]
	public Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1MemorySubSystemController memory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1MemorySubSystemController>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;", "private")]
	public Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController cpu_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;", "private")]
	public Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController cpuacct_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;", "private")]
	public Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController cpuset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;", "private")]
	public Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController blkio_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;", "private")]
	public Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController pids_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;", "private static volatile")]
	public static Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1Subsystem INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1Subsystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PROVIDER_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CgroupV1Subsystem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public CgroupV1Subsystem() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Map;)Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;", "public static")]
	public static Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1Subsystem getInstance(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1Subsystem>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getEffectiveCpuCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuPeriod()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuQuota()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuShares()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getCpuSetCpus()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getEffectiveCpuSetCpus()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getCpuSetMems()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getEffectiveCpuSetMems()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryLimit()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemorySoftLimit()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryAndSwapLimit()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getPidsMax()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;)J", "private static")]
	public static long getLongValue(Dova.JDK.jdk.@internal.platform.CgroupSubsystemController arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()[J", "public")]
	public JavaArray<long> getPerCpuUsage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuUserUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuSystemUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuNumPeriods()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuNumThrottled()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuThrottledTime()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryFailCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getTcpMemoryUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getPidsCurrent()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getBlkIOServiceCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getBlkIOServiced()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryMaxUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getKernelMemoryFailCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getKernelMemoryMaxUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getKernelMemoryUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getTcpMemoryFailCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getTcpMemoryMaxUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryAndSwapFailCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryAndSwapMaxUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Boolean;", "public")]
	public Dova.JDK.java.lang.Boolean isMemoryOOMKillEnabled()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getCpuSetMemoryPressure()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Boolean;", "public")]
	public Dova.JDK.java.lang.Boolean isCpuSetMemoryPressureEnabled()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljdk/internal/platform/cgroupv1/CgroupV1Subsystem;", "private static")]
	public static Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1Subsystem initSubSystem(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1Subsystem>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/cgroupv1/CgroupV1MemorySubSystemController;)Z", "private static")]
	public static bool getHierarchical(Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1MemorySubSystemController arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[39], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/cgroupv1/CgroupV1MemorySubSystemController;)Z", "private static")]
	public static bool getSwapEnabled(Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1MemorySubSystemController arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/cgroupv1/CgroupV1MemorySubSystemController;)V", "private")]
	public void setMemorySubSystem(Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1MemorySubSystemController arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V", "private")]
	public void setCpuSetController(Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V", "private")]
	public void setCpuAcctController(Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V", "private")]
	public void setCpuController(Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V", "private")]
	public void setBlkIOController(Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/cgroupv1/CgroupV1SubsystemController;)V", "private")]
	public void setPidsController(Dova.JDK.jdk.@internal.platform.cgroupv1.CgroupV1SubsystemController arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryAndSwapUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[47]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[48]);
		return ret;
	}
}
