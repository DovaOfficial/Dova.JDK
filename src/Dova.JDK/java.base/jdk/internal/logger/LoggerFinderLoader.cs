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

namespace Dova.JDK.jdk.@internal.logger;

[JniSignatureAttribute("Ljdk/internal/logger/LoggerFinderLoader;", "public final")]
public partial class LoggerFinderLoader
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LoggerFinderLoader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/LoggerFinderLoader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "service", "Ljava/lang/System$LoggerFinder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "lock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASSLOADER_PERMISSION", "Ljava/security/Permission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "READ_PERMISSION", "Ljava/security/Permission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOGGERFINDER_PERMISSION", "Ljava/lang/RuntimePermission;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "service", "()Ljava/lang/System$LoggerFinder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLoggerFinder", "()Ljava/lang/System$LoggerFinder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadLoggerFinder", "()Ljava/lang/System$LoggerFinder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findLoggerFinderProviders", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureSingletonProvider", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadDefaultImplementation", "()Ljava/lang/System$LoggerFinder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "configurationErrorPolicy", "()Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
	}

	[JniSignatureAttribute("Ljava/lang/System$LoggerFinder;", "private static volatile")]
	public static Dova.JDK.java.lang.System.LoggerFinder service_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.LoggerFinder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object @lock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/Permission;", "static final")]
	public static Dova.JDK.java.security.Permission CLASSLOADER_PERMISSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.Permission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/Permission;", "static final")]
	public static Dova.JDK.java.security.Permission READ_PERMISSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.Permission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/RuntimePermission;", "public static final")]
	public static Dova.JDK.java.lang.RuntimePermission LOGGERFINDER_PERMISSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimePermission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LoggerFinderLoader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public LoggerFinderLoader() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/logger/LoggerFinderLoader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/System$LoggerFinder;", "private static")]
	public static Dova.JDK.java.lang.System.LoggerFinder service()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.LoggerFinder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/System$LoggerFinder;", "public static")]
	public static Dova.JDK.java.lang.System.LoggerFinder getLoggerFinder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.LoggerFinder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/System$LoggerFinder;", "private static")]
	public static Dova.JDK.java.lang.System.LoggerFinder loadLoggerFinder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.LoggerFinder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "private static")]
	public static Dova.JDK.java.util.Iterator findLoggerFinderProviders()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool ensureSingletonProvider()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/System$LoggerFinder;", "private static")]
	public static Dova.JDK.java.lang.System.LoggerFinder loadDefaultImplementation()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.LoggerFinder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "private static")]
	public static Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy configurationErrorPolicy()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "private static final")]
	public partial class ErrorPolicy
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ErrorPolicy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR", "Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING", "Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUIET", "Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;"));
		}

		[JniSignatureAttribute("Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "public static final")]
		public static Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy ERROR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "public static final")]
		public static Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy WARNING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "public static final")]
		public static Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy DEBUG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "public static final")]
		public static Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy QUIET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ErrorPolicy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ErrorPolicy(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "public static")]
		public static Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/logger/LoggerFinderLoader$ErrorPolicy;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.logger.LoggerFinderLoader.ErrorPolicy>>(ret);
		}
	}
}
