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

namespace Dova.JDK.jdk.@internal.platform.cgroupv2;

[JniSignatureAttribute("Ljdk/internal/platform/cgroupv2/CgroupV2Subsystem;", "public")]
public partial class CgroupV2Subsystem
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.platform.CgroupSubsystem
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CgroupV2Subsystem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/platform/cgroupv2/CgroupV2Subsystem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljdk/internal/platform/cgroupv2/CgroupV2Subsystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG_ARRAY_NOT_SUPPORTED", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT_ARRAY_UNAVAILABLE", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unified", "Ljdk/internal/platform/CgroupSubsystemController;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROVIDER_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PER_CPU_SHARES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_STR", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_SWAP", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/platform/CgroupSubsystemController;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljdk/internal/platform/CgroupInfo;)Ljdk/internal/platform/CgroupSubsystem;"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongVal", "(Ljava/lang/String;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongVal", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFromCpuMax", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCpuSet", "(Ljava/lang/String;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sumTokensIOStat", "(Ljava/util/function/Function;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRWIOMatchTokenNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ioStatLineToLong", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Long;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRWBytesIOMatchTokenNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longOrZero", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lineToRandWIOs", "(Ljava/lang/String;)Ljava/lang/Long;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lineToRBytesAndWBytesIO", "(Ljava/lang/String;)Ljava/lang/Long;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryAndSwapUsage", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemoryUsage", "()J"));
	}

	[JniSignatureAttribute("Ljdk/internal/platform/cgroupv2/CgroupV2Subsystem;", "private static volatile")]
	public static Dova.JDK.jdk.@internal.platform.cgroupv2.CgroupV2Subsystem INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.cgroupv2.CgroupV2Subsystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[J", "private static final")]
	public static JavaArray<long> LONG_ARRAY_NOT_SUPPORTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> INT_ARRAY_UNAVAILABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/platform/CgroupSubsystemController;", "private final")]
	public Dova.JDK.jdk.@internal.platform.CgroupSubsystemController unified_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.CgroupSubsystemController>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PROVIDER_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int PER_CPU_SHARES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object EMPTY_STR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long NO_SWAP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CgroupV2Subsystem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/CgroupSubsystemController;)V", "private")]
	public CgroupV2Subsystem(Dova.JDK.jdk.@internal.platform.CgroupSubsystemController arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/platform/cgroupv2/CgroupV2Subsystem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/platform/CgroupInfo;)Ljdk/internal/platform/CgroupSubsystem;", "public static")]
	public static Dova.JDK.jdk.@internal.platform.CgroupSubsystem getInstance(Dova.JDK.jdk.@internal.platform.CgroupInfo arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.CgroupSubsystem>(ret);
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

	[JniSignatureAttribute("()J", "public")]
	public long getCpuUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()[J", "public")]
	public JavaArray<long> getPerCpuUsage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuUserUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuSystemUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuNumPeriods()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuNumThrottled()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getCpuThrottledTime()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryFailCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getTcpMemoryUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getPidsCurrent()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getBlkIOServiceCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getBlkIOServiced()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;J)J", "private")]
	public long getLongVal(Dova.JDK.java.lang.String arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "private")]
	public long getLongVal(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "private")]
	public long getFromCpuMax(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[I", "private")]
	public JavaArray<int> getCpuSet(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)J", "private")]
	public long sumTokensIOStat(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> getRWIOMatchTokenNames()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Long;", "private static")]
	public static Dova.JDK.java.lang.Long ioStatLineToLong(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Long>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> getRWBytesIOMatchTokenNames()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "private static")]
	public static long longOrZero(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Long;", "public static")]
	public static Dova.JDK.java.lang.Long lineToRandWIOs(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Long>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Long;", "public static")]
	public static Dova.JDK.java.lang.Long lineToRBytesAndWBytesIO(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Long>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryAndSwapUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getMemoryUsage()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}
}
