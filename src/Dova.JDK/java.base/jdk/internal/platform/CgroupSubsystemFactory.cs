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

namespace Dova.JDK.jdk.@internal.platform;

[JniSignatureAttribute("Ljdk/internal/platform/CgroupSubsystemFactory;", "public")]
public partial class CgroupSubsystemFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CgroupSubsystemFactory()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/platform/CgroupSubsystemFactory;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CPU_CTRL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CPUACCT_CTRL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CPUSET_CTRL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BLKIO_CTRL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEMORY_CTRL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PIDS_CTRL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MOUNTINFO_PATTERN", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CgroupSubsystemFactory", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "create", "()Ljdk/internal/platform/CgroupMetrics;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "determineType", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "amendCgroupInfos", "(Ljava/lang/String;Ljava/util/Map;Z)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setCgroupV2Path", "(Ljava/util/Map;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setCgroupV1Path", "(Ljava/util/Map;[Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String CPU_CTRL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String CPUACCT_CTRL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String CPUSET_CTRL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String BLKIO_CTRL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String MEMORY_CTRL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PIDS_CTRL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern MOUNTINFO_PATTERN_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CgroupSubsystemFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CgroupSubsystemFactory() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/platform/CgroupSubsystemFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/internal/platform/CgroupMetrics;", "static")]
	public static Dova.JDK.jdk.@internal.platform.CgroupMetrics create()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.platform.CgroupMetrics>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Optional;", "public static")]
	public static Dova.JDK.java.util.Optional determineType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;Z)Z", "private static")]
	public static bool amendCgroupInfos(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1, bool arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;[Ljava/lang/String;)V", "private static")]
	public static void setCgroupV2Path(Dova.JDK.java.util.Map arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Map;[Ljava/lang/String;)V", "private static")]
	public static void setCgroupV1Path(Dova.JDK.java.util.Map arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("Ljdk/internal/platform/CgroupSubsystemFactory$CgroupTypeResult;", "public static final")]
	public partial class CgroupTypeResult
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CgroupTypeResult()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/platform/CgroupSubsystemFactory$CgroupTypeResult;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "isCgroupV2", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "anyControllersEnabled", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "anyCgroupV2Controllers", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "anyCgroupV1Controllers", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "infos", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CgroupTypeResult", "(ZZZZLjava/util/Map;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isAnyControllersEnabled", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isAnyCgroupV1Controllers", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isAnyCgroupV2Controllers", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getInfos", "()Ljava/util/Map;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isCgroupV2", "()Z"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isCgroupV2_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool anyControllersEnabled_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool anyCgroupV2Controllers_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool anyCgroupV1Controllers_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map infos_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CgroupTypeResult(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZZZZLjava/util/Map;)V", "private")]
		public CgroupTypeResult(bool arg0, bool arg1, bool arg2, bool arg3, Dova.JDK.java.util.Map arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/platform/CgroupSubsystemFactory$CgroupTypeResult;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnyControllersEnabled()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnyCgroupV1Controllers()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnyCgroupV2Controllers()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map getInfos()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCgroupV2()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}
}