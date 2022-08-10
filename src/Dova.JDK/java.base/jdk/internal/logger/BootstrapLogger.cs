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

namespace Dova.JDK.jdk.@internal.logger;

[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger;", "public final")]
public partial class BootstrapLogger
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.System.Logger
	, Dova.JDK.sun.util.logging.PlatformLogger.Bridge
	, Dova.JDK.sun.util.logging.PlatformLogger.ConfigurableBridge
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BootstrapLogger()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/BootstrapLogger;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "holder", "Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "isBooted", "Ljava/util/function/BooleanSupplier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "logManagerConfigured", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BootstrapLogger", "(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/Throwable;Ljava/util/function/Supplier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger$Level;Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger$Level;Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger$Level;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger$Level;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Lsun/util/logging/PlatformLogger$Level;Ljava/util/function/Supplier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flush", "(Ljdk/internal/logger/BootstrapLogger$LogEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isBooted", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getLogger", "(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)Ljava/lang/System$Logger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isAlive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "push", "(Ljdk/internal/logger/BootstrapLogger$LogEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isLoggable", "(Ljava/lang/System$Logger$Level;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isLoggable", "(Lsun/util/logging/PlatformLogger$Level;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "redirectTemporaryLoggers", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logp", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/function/Supplier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logp", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logp", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logp", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Supplier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logp", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logrb", "(Lsun/util/logging/PlatformLogger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logrb", "(Lsun/util/logging/PlatformLogger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logrb", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "logrb", "(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkBootstrapping", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLoggerConfiguration", "()Lsun/util/logging/PlatformLogger$ConfigurableBridge$LoggerConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "useSurrogateLoggers", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createSurrogateLogger", "(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)Ljava/lang/System$Logger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "releaseSurrogateLoggers", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "awaitPendingTasks", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "useLazyLoggers", "()Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;", "final")]
	public Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor holder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/BooleanSupplier;", "private static volatile")]
	public static Dova.JDK.java.util.function.BooleanSupplier isBooted_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BooleanSupplier>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private static volatile")]
	public static bool logManagerConfigured_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BootstrapLogger(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)V", "")]
	public BootstrapLogger(Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/logger/BootstrapLogger;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;Ljava/lang/Throwable;)V", "public")]
	public void log(Dova.JDK.java.lang.System.Logger.Level arg0, Dova.JDK.java.util.function.Supplier arg1, Dova.JDK.java.lang.Throwable arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void log(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
	public void log(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Throwable arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/Throwable;Ljava/util/function/Supplier;)V", "public")]
	public void log(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.Throwable arg1, Dova.JDK.java.util.function.Supplier arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void log(Dova.JDK.java.lang.System.Logger.Level arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
	public void log(Dova.JDK.java.lang.System.Logger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Throwable arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;Ljava/lang/String;)V", "public")]
	public void log(Dova.JDK.java.lang.System.Logger.Level arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;Ljava/lang/Object;)V", "public")]
	public void log(Dova.JDK.java.lang.System.Logger.Level arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;)V", "public")]
	public void log(Dova.JDK.java.lang.System.Logger.Level arg0, Dova.JDK.java.util.function.Supplier arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;)V", "public")]
	public void log(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/util/function/Supplier;)V", "public")]
	public void log(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.util.function.Supplier arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
	public void log(Dova.JDK.java.lang.System.Logger.Level arg0, Dova.JDK.java.util.ResourceBundle arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Throwable arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void log(Dova.JDK.java.lang.System.Logger.Level arg0, Dova.JDK.java.util.ResourceBundle arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger$LogEvent;)V", "")]
	public void flush(Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isBooted()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)Ljava/lang/System$Logger;", "static")]
	public static Dova.JDK.java.lang.System.Logger getLogger(Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool isAlive()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger$LogEvent;)V", "")]
	public void push(Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/System$Logger$Level;)Z", "public")]
	public bool isLoggable(Dova.JDK.java.lang.System.Logger.Level arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;)Z", "public")]
	public bool isLoggable(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void redirectTemporaryLoggers()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/function/Supplier;)V", "public")]
	public void logp(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Throwable arg3, Dova.JDK.java.util.function.Supplier arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void logp(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
	public void logp(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Throwable arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Supplier;)V", "public")]
	public void logp(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.function.Supplier arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void logp(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
	public void logrb(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.util.ResourceBundle arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Throwable arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void logrb(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.util.ResourceBundle arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
	public void logrb(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.ResourceBundle arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.Throwable arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void logrb(Dova.JDK.sun.util.logging.PlatformLogger.Level arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.ResourceBundle arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.Object> arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool checkBootstrapping()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/util/logging/PlatformLogger$ConfigurableBridge$LoggerConfiguration;", "public")]
	public Dova.JDK.sun.util.logging.PlatformLogger.ConfigurableBridge.LoggerConfiguration getLoggerConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger.ConfigurableBridge.LoggerConfiguration>(ret);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool useSurrogateLoggers()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)Ljava/lang/System$Logger;", "static synchronized")]
	public static Dova.JDK.java.lang.System.Logger createSurrogateLogger(Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "private static synchronized")]
	public static Dova.JDK.java.util.Map releaseSurrogateLoggers()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()V", "static")]
	public static void awaitPendingTasks()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[37]);
	}

	[JniSignatureAttribute("()Z", "public static synchronized")]
	public static bool useLazyLoggers()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$BootstrapExecutors;", "private static")]
	public partial class BootstrapExecutors
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.ThreadFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BootstrapExecutors()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/BootstrapLogger$BootstrapExecutors;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "KEEP_EXECUTOR_ALIVE_SECONDS", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "executorRef", "Ljava/lang/ref/WeakReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "head", "Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "tail", "Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BootstrapExecutors", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "flush", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "join", "(Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "enqueue", "(Ljdk/internal/logger/BootstrapLogger$LogEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isAlive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "submit", "(Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "awaitPendingTasks", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getExecutor", "()Ljava/util/concurrent/ExecutorService;"));
		}

		[JniSignatureAttribute("J", "static final")]
		public static long KEEP_EXECUTOR_ALIVE_SECONDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/lang/ref/WeakReference;", "private static volatile")]
		public static Dova.JDK.java.lang.@ref.WeakReference executorRef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.WeakReference>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent head_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent tail_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BootstrapExecutors(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public BootstrapExecutors() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/BootstrapLogger$BootstrapExecutors;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "static")]
		public static void flush()
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "static")]
		public static void join(Dova.JDK.java.lang.Runnable arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger$LogEvent;)V", "static")]
		public static void enqueue(Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Z", "static")]
		public static bool isAlive()
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "static")]
		public static void submit(Dova.JDK.java.lang.Runnable arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/lang/Thread;", "public")]
		public Dova.JDK.java.lang.Thread newThread(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}

		[JniSignatureAttribute("()V", "static")]
		public static void awaitPendingTasks()
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/ExecutorService;", "private static")]
		public static Dova.JDK.java.util.concurrent.ExecutorService getExecutor()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ExecutorService>(ret);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$BootstrapExecutors$BootstrapMessageLoggerTask;", "private static")]
		public partial class BootstrapMessageLoggerTask
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.lang.Runnable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BootstrapMessageLoggerTask()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/BootstrapLogger$BootstrapExecutors$BootstrapMessageLoggerTask;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "owner", "Ljava/util/concurrent/ExecutorService;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "run", "Ljava/lang/Runnable;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BootstrapMessageLoggerTask", "(Ljava/util/concurrent/ExecutorService;Ljava/lang/Runnable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "()V"));
			}

			[JniSignatureAttribute("Ljava/util/concurrent/ExecutorService;", "")]
			public Dova.JDK.java.util.concurrent.ExecutorService owner_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ExecutorService>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/lang/Runnable;", "")]
			public Dova.JDK.java.lang.Runnable run_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BootstrapMessageLoggerTask(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/ExecutorService;Ljava/lang/Runnable;)V", "public")]
			public BootstrapMessageLoggerTask(Dova.JDK.java.util.concurrent.ExecutorService arg0, Dova.JDK.java.lang.Runnable arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/logger/BootstrapLogger$BootstrapExecutors$BootstrapMessageLoggerTask;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void run()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static final")]
	public partial class LogEvent
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LogEvent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/BootstrapLogger$LogEvent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "level", "Ljava/lang/System$Logger$Level;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "platformLevel", "Lsun/util/logging/PlatformLogger$Level;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bootstrap", "Ljdk/internal/logger/BootstrapLogger;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bundle", "Ljava/util/ResourceBundle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "msg", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "thrown", "Ljava/lang/Throwable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "params", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "msgSupplier", "Ljava/util/function/Supplier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sourceClass", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sourceMethod", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "timeMillis", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nanoAdjustment", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "acc", "Ljava/security/AccessControlContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "next", "Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LogEvent", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Supplier;Ljava/lang/Throwable;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LogEvent", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LogEvent", "(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;Ljava/lang/Throwable;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LogEvent", "(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Ljava/lang/System$Logger;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "log", "(Ljdk/internal/logger/BootstrapLogger$LogEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "log", "(Lsun/util/logging/PlatformLogger$Bridge;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "log", "(Ljdk/internal/logger/BootstrapLogger$LogEvent;Ljava/lang/System$Logger;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "log", "(Ljdk/internal/logger/BootstrapLogger$LogEvent;Lsun/util/logging/PlatformLogger$Bridge;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;[Ljava/lang/Object;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/util/function/Supplier;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Supplier;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "vaueOf", "(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/util/function/Supplier;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;"));
		}

		[JniSignatureAttribute("Ljava/lang/System$Logger$Level;", "final")]
		public Dova.JDK.java.lang.System.Logger.Level level_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger.Level>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/util/logging/PlatformLogger$Level;", "final")]
		public Dova.JDK.sun.util.logging.PlatformLogger.Level platformLevel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger.Level>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger;", "final")]
		public Dova.JDK.jdk.@internal.logger.BootstrapLogger bootstrap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ResourceBundle;", "final")]
		public Dova.JDK.java.util.ResourceBundle bundle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String msg_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Throwable;", "final")]
		public Dova.JDK.java.lang.Throwable thrown_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "final")]
		public JavaArray<Dova.JDK.java.lang.Object> @params_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/Supplier;", "final")]
		public Dova.JDK.java.util.function.Supplier msgSupplier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String sourceClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String sourceMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("J", "final")]
		public long timeMillis_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("J", "final")]
		public long nanoAdjustment_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "final")]
		public Dova.JDK.java.security.AccessControlContext acc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LogEvent;", "")]
		public Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LogEvent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Supplier;Ljava/lang/Throwable;[Ljava/lang/Object;)V", "private")]
		public LogEvent(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.function.Supplier arg4, Dova.JDK.java.lang.Throwable arg5, JavaArray<Dova.JDK.java.lang.Object> arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V", "private")]
		public LogEvent(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.ResourceBundle arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.Throwable arg6, JavaArray<Dova.JDK.java.lang.Object> arg7) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;Ljava/lang/Throwable;[Ljava/lang/Object;)V", "private")]
		public LogEvent(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.java.lang.System.Logger.Level arg1, Dova.JDK.java.util.function.Supplier arg2, Dova.JDK.java.lang.Throwable arg3, JavaArray<Dova.JDK.java.lang.Object> arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V", "private")]
		public LogEvent(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.java.lang.System.Logger.Level arg1, Dova.JDK.java.util.ResourceBundle arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Throwable arg4, JavaArray<Dova.JDK.java.lang.Object> arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/BootstrapLogger$LogEvent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/System$Logger;)V", "private")]
		public void log(Dova.JDK.java.lang.System.Logger arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger$LogEvent;)V", "static")]
		public static void log(Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lsun/util/logging/PlatformLogger$Bridge;)V", "private")]
		public void log(Dova.JDK.sun.util.logging.PlatformLogger.Bridge arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger$LogEvent;Ljava/lang/System$Logger;)V", "static")]
		public static void log(Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent arg0, Dova.JDK.java.lang.System.Logger arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger$LogEvent;Lsun/util/logging/PlatformLogger$Bridge;)V", "static")]
		public static void log(Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent arg0, Dova.JDK.sun.util.logging.PlatformLogger.Bridge arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;[Ljava/lang/Object;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.java.lang.System.Logger.Level arg1, Dova.JDK.java.util.function.Supplier arg2, Dova.JDK.java.lang.Throwable arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Throwable arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/util/function/Supplier;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.util.function.Supplier arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/function/Supplier;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.java.lang.System.Logger.Level arg1, Dova.JDK.java.util.function.Supplier arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.ResourceBundle arg4, Dova.JDK.java.lang.String arg5, JavaArray<Dova.JDK.java.lang.Object> arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.ResourceBundle arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.Throwable arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Supplier;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.function.Supplier arg4, Dova.JDK.java.lang.Throwable arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.java.lang.System.Logger.Level arg1, Dova.JDK.java.util.ResourceBundle arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Throwable arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Ljava/lang/System$Logger$Level;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent valueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.java.lang.System.Logger.Level arg1, Dova.JDK.java.util.ResourceBundle arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/BootstrapLogger;Lsun/util/logging/PlatformLogger$Level;Ljava/util/function/Supplier;Ljava/lang/Throwable;)Ljdk/internal/logger/BootstrapLogger$LogEvent;", "static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent vaueOf(Dova.JDK.jdk.@internal.logger.BootstrapLogger arg0, Dova.JDK.sun.util.logging.PlatformLogger.Level arg1, Dova.JDK.java.util.function.Supplier arg2, Dova.JDK.java.lang.Throwable arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LogEvent>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$DetectBackend;", "private static final")]
	public partial class DetectBackend
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DetectBackend()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/BootstrapLogger$DetectBackend;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "detectedBackend", "Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DetectBackend", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "static final")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend detectedBackend_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DetectBackend(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DetectBackend() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/BootstrapLogger$DetectBackend;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "private static final")]
	public partial class LoggingBackend
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LoggingBackend()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/BootstrapLogger$LoggingBackend;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NONE", "Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JUL_DEFAULT", "Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JUL_WITH_CONFIG", "Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CUSTOM", "Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "useLoggerFinder", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LoggingBackend", "(Ljava/lang/String;IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljdk/internal/logger/BootstrapLogger$LoggingBackend;"));
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "public static final")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "public static final")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend JUL_DEFAULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "public static final")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend JUL_WITH_CONFIG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "public static final")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend CUSTOM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "final")]
		public bool useLoggerFinder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("[Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LoggingBackend(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
		public LoggingBackend(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/BootstrapLogger$LoggingBackend;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "public static")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/logger/BootstrapLogger$LoggingBackend;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.logger.BootstrapLogger.LoggingBackend>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$RedirectedLoggers;", "static final")]
	public partial class RedirectedLoggers
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.function.Function
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RedirectedLoggers()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/logger/BootstrapLogger$RedirectedLoggers;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "redirectedLoggers", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cleared", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSTANCE", "Ljdk/internal/logger/BootstrapLogger$RedirectedLoggers;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RedirectedLoggers", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)Ljdk/internal/logger/SurrogateLogger;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "apply", "(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)Ljdk/internal/logger/SurrogateLogger;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "apply", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drainLoggersMap", "()Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "replaceSurrogateLoggers", "(Ljava/util/Map;)V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map redirectedLoggers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "")]
		public bool cleared_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Ljdk/internal/logger/BootstrapLogger$RedirectedLoggers;", "static final")]
		public static Dova.JDK.jdk.@internal.logger.BootstrapLogger.RedirectedLoggers INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.BootstrapLogger.RedirectedLoggers>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RedirectedLoggers(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public RedirectedLoggers() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/logger/BootstrapLogger$RedirectedLoggers;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)Ljdk/internal/logger/SurrogateLogger;", "")]
		public Dova.JDK.jdk.@internal.logger.SurrogateLogger get(Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.SurrogateLogger>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/logger/LazyLoggers$LazyLoggerAccessor;)Ljdk/internal/logger/SurrogateLogger;", "public")]
		public Dova.JDK.jdk.@internal.logger.SurrogateLogger apply(Dova.JDK.jdk.@internal.logger.LazyLoggers.LazyLoggerAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.logger.SurrogateLogger>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object apply(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "")]
		public Dova.JDK.java.util.Map drainLoggersMap()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;)V", "static")]
		public static void replaceSurrogateLoggers(Dova.JDK.java.util.Map arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		}
	}
}
