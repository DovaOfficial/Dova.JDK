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

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/Logger;", "public final")]
public partial class Logger
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Logger()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/Logger;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_EVENT_SIZE", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "log", "(Ljdk/jfr/internal/LogTag;Ljdk/jfr/internal/LogLevel;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "logEvent", "(Ljdk/jfr/internal/LogLevel;[Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "logInternal", "(Ljdk/jfr/internal/LogTag;Ljdk/jfr/internal/LogLevel;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "shouldLog", "(Ljdk/jfr/internal/LogTag;Ljdk/jfr/internal/LogLevel;)Z"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_EVENT_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Logger(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Logger() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/Logger;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jfr/internal/LogTag;Ljdk/jfr/internal/LogLevel;Ljava/lang/String;)V", "public static")]
	public static void log(Dova.JDK.jdk.jfr.@internal.LogTag arg0, Dova.JDK.jdk.jfr.@internal.LogLevel arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/LogLevel;[Ljava/lang/String;Z)V", "public static")]
	public static void logEvent(Dova.JDK.jdk.jfr.@internal.LogLevel arg0, JavaArray<Dova.JDK.java.lang.String> arg1, bool arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/LogTag;Ljdk/jfr/internal/LogLevel;Ljava/lang/String;)V", "private static")]
	public static void logInternal(Dova.JDK.jdk.jfr.@internal.LogTag arg0, Dova.JDK.jdk.jfr.@internal.LogLevel arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/LogTag;Ljdk/jfr/internal/LogLevel;)Z", "public static")]
	public static bool shouldLog(Dova.JDK.jdk.jfr.@internal.LogTag arg0, Dova.JDK.jdk.jfr.@internal.LogLevel arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}
}
