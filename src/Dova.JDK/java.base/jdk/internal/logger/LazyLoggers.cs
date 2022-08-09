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

namespace Dova.JDK.jdk.@internal.logger;

[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers;", "public final")]
public partial class LazyLoggers
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LazyLoggers()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/logger/LazyLoggers;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LOGGERFINDER_PERMISSION", "Ljava/lang/RuntimePermission;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "provider", "Ljava/lang/System$LoggerFinder;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "loggerSupplier", "Ljava/util/function/BiFunction;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "factories", "Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LazyLoggers", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getLogger", "(Ljava/lang/String;Ljava/lang/Module;)Ljava/lang/System$Logger;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getLazyLogger", "(Ljava/lang/String;Ljava/lang/Module;)Ljava/lang/System$Logger;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "accessLoggerFinder", "()Ljava/lang/System$LoggerFinder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getLoggerFromFinder", "(Ljava/lang/String;Ljava/lang/Module;)Ljava/lang/System$Logger;"));
	}

	[JniSignatureAttribute("Ljava/lang/RuntimePermission;", "static final")]
	public static Dova.JDK.java.lang.RuntimePermission LOGGERFINDER_PERMISSION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimePermission>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/System$LoggerFinder;", "private static volatile")]
	public static Dova.JDK.java.lang.System.LoggerFinder provider_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.LoggerFinder>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/BiFunction;", "private static final")]
	public static Dova.JDK.java.util.function.BiFunction loggerSupplier_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;", "private static final")]
	public static Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerFactories factories_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerFactories>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LazyLoggers(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public LazyLoggers() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/logger/LazyLoggers;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Module;)Ljava/lang/System$Logger;", "public static final")]
	public static Dova.JDK.java.lang.System.Logger getLogger(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Module arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Module;)Ljava/lang/System$Logger;", "public static final")]
	public static Dova.JDK.java.lang.System.Logger getLazyLogger(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Module arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/System$LoggerFinder;", "private static")]
	public static Dova.JDK.java.lang.System.LoggerFinder accessLoggerFinder()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.LoggerFinder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Module;)Ljava/lang/System$Logger;", "static")]
	public static Dova.JDK.java.lang.System.Logger getLoggerFromFinder(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Module arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$JdkLazyLogger;", "private static final")]
	public partial class JdkLazyLogger
		: Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JdkLazyLogger()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/logger/LazyLoggers$JdkLazyLogger;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JdkLazyLogger", "(Ljava/lang/String;Ljava/lang/Module;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JdkLazyLogger", "(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;Ljava/lang/Void;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JdkLazyLogger(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Module;)V", "")]
		public JdkLazyLogger(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Module arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;Ljava/lang/Void;)V", "private")]
		public JdkLazyLogger(Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor arg0, Dova.JDK.java.lang.Void arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/LazyLoggers$JdkLazyLogger;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;", "private static final")]
	public partial class LazyLoggerFactories
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LazyLoggerFactories()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "loggerSupplier", "Ljava/util/function/BiFunction;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LazyLoggerFactories", "(Ljava/util/function/BiFunction;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LazyLoggerFactories", "(Ljava/util/function/BiFunction;Ljava/lang/Void;)V"));
		}

		[JniSignatureAttribute("Ljava/util/function/BiFunction;", "final")]
		public Dova.JDK.java.util.function.BiFunction loggerSupplier_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LazyLoggerFactories(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/BiFunction;)V", "public")]
		public LazyLoggerFactories(Dova.JDK.java.util.function.BiFunction arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/BiFunction;Ljava/lang/Void;)V", "private")]
		public LazyLoggerFactories(Dova.JDK.java.util.function.BiFunction arg0, Dova.JDK.java.lang.Void arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$LazyLoggerWrapper;", "private static")]
	public partial class LazyLoggerWrapper
		: Dova.JDK.jdk.@internal.logger.AbstractLoggerWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LazyLoggerWrapper()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/logger/LazyLoggers$LazyLoggerWrapper;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "loggerAccessor", "Ljdk/internal/logger/LazyLoggers$LoggerAccessor;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LazyLoggerWrapper", "(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LazyLoggerWrapper", "(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;Ljava/lang/Void;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrapped", "()Ljava/lang/System$Logger;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "platformProxy", "()Lsun/util/logging/PlatformLogger$Bridge;"));
		}

		[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$LoggerAccessor;", "final")]
		public Dova.JDK.jdk.@internal.logger.LazyLoggers.LoggerAccessor loggerAccessor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LazyLoggers.LoggerAccessor>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LazyLoggerWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)V", "public")]
		public LazyLoggerWrapper(Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;Ljava/lang/Void;)V", "private")]
		public LazyLoggerWrapper(Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor arg0, Dova.JDK.java.lang.Void arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/LazyLoggers$LazyLoggerWrapper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/System$Logger;", "final")]
		public Dova.JDK.java.lang.System.Logger wrapped()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
		}

		[JniSignatureAttribute("()Lsun/util/logging/PlatformLogger$Bridge;", "")]
		public Dova.JDK.sun.util.logging.PlatformLogger.Bridge platformProxy()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger.Bridge>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;", "static final")]
	public partial class LazyLoggerAccessor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.logger.LazyLoggers.LoggerAccessor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LazyLoggerAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "factories", "Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "moduleRef", "Ljava/lang/ref/WeakReference;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "w", "Ljava/lang/System$Logger;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "p", "Lsun/util/logging/PlatformLogger$Bridge;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LazyLoggerAccessor", "(Ljava/lang/String;Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;Ljava/lang/Module;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LazyLoggerAccessor", "(Ljava/lang/String;Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;Ljava/lang/Module;Ljava/lang/Void;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "release", "(Ljdk/internal/logger/SimpleConsoleLogger;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "platform", "()Lsun/util/logging/PlatformLogger$Bridge;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLoggerName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getConcretePlatformLogger", "(Ljdk/internal/logger/BootstrapLogger;)Lsun/util/logging/PlatformLogger$Bridge;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getConcreteLogger", "(Ljdk/internal/logger/BootstrapLogger;)Ljava/lang/System$Logger;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrapped", "()Ljava/lang/System$Logger;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createLogger", "()Ljava/lang/System$Logger;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeAccessor", "(Ljava/lang/String;Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;Ljava/lang/Module;)Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setWrappedIfNotSet", "(Ljava/lang/System$Logger;)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;", "final")]
		public Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerFactories factories_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerFactories>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/ref/WeakReference;", "private final")]
		public Dova.JDK.java.lang.@ref.WeakReference moduleRef_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.WeakReference>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/System$Logger;", "private volatile")]
		public Dova.JDK.java.lang.System.Logger w_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/util/logging/PlatformLogger$Bridge;", "private volatile")]
		public Dova.JDK.sun.util.logging.PlatformLogger.Bridge p_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger.Bridge>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LazyLoggerAccessor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;Ljava/lang/Module;)V", "private")]
		public LazyLoggerAccessor(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerFactories arg1, Dova.JDK.java.lang.Module arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;Ljava/lang/Module;Ljava/lang/Void;)V", "private")]
		public LazyLoggerAccessor(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerFactories arg1, Dova.JDK.java.lang.Module arg2, Dova.JDK.java.lang.Void arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/logger/SimpleConsoleLogger;Z)V", "")]
		public void release(Dova.JDK.jdk.@internal.logger.SimpleConsoleLogger arg0, bool arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Lsun/util/logging/PlatformLogger$Bridge;", "public")]
		public Dova.JDK.sun.util.logging.PlatformLogger.Bridge platform()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger.Bridge>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getLoggerName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;)Lsun/util/logging/PlatformLogger$Bridge;", "")]
		public Dova.JDK.sun.util.logging.PlatformLogger.Bridge getConcretePlatformLogger(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger.Bridge>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;)Ljava/lang/System$Logger;", "")]
		public Dova.JDK.java.lang.System.Logger getConcreteLogger(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/System$Logger;", "public")]
		public Dova.JDK.java.lang.System.Logger wrapped()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/System$Logger;", "")]
		public Dova.JDK.java.lang.System.Logger createLogger()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/logger/LazyLoggers$LazyLoggerFactories;Ljava/lang/Module;)Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;", "public static")]
		public static Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor makeAccessor(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerFactories arg1, Dova.JDK.java.lang.Module arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/System$Logger;)V", "private")]
		public void setWrappedIfNotSet(Dova.JDK.java.lang.System.Logger arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$LoggerAccessor;", "abstract static interface")]
	public partial interface LoggerAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LoggerAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/logger/LazyLoggers$LoggerAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "platform", "()Lsun/util/logging/PlatformLogger$Bridge;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLoggerName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrapped", "()Ljava/lang/System$Logger;"));
		}

		[JniSignatureAttribute("()Lsun/util/logging/PlatformLogger$Bridge;", "public abstract")]
		Dova.JDK.sun.util.logging.PlatformLogger.Bridge platform()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger.Bridge>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getLoggerName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/System$Logger;", "public abstract")]
		Dova.JDK.java.lang.System.Logger wrapped()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
		}
	}
}
