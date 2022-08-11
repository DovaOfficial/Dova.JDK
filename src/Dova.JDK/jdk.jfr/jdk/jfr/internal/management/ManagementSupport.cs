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

namespace Dova.JDK.jdk.jfr.@internal.management;

[JniSignatureAttribute("Ljdk/jfr/internal/management/ManagementSupport;", "public final")]
public partial class ManagementSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ManagementSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/management/ManagementSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newConfiguration", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)Ljdk/jfr/Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "logError", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newEventDirectoryStream", "(Ljava/security/AccessControlContext;Ljava/nio/file/Path;Ljava/util/List;)Ljdk/jfr/consumer/EventStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setOnChunkCompleteHandler", "(Ljdk/jfr/consumer/EventStream;Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newEventSettings", "(Ljdk/jfr/internal/management/EventSettingsModifier;)Ljdk/jfr/EventSettings;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEventTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "formatTimespan", "(Ljava/time/Duration;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDestinationOriginalText", "(Ljdk/jfr/Recording;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseTimespan", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkSetDestination", "(Ljdk/jfr/Recording;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "epochNanosToInstant", "(J)Ljava/time/Instant;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "logDebug", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStartTimeNanos", "(Ljdk/jfr/Recording;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removePath", "(Ljdk/jfr/Recording;Ljava/nio/file/Path;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ManagementSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ManagementSupport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/management/ManagementSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)Ljdk/jfr/Configuration;", "public static")]
	public static Dova.JDK.jdk.jfr.Configuration newConfiguration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.Map arg4, Dova.JDK.java.lang.String arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.Configuration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void logError(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/AccessControlContext;Ljava/nio/file/Path;Ljava/util/List;)Ljdk/jfr/consumer/EventStream;", "public static")]
	public static Dova.JDK.jdk.jfr.consumer.EventStream newEventDirectoryStream(Dova.JDK.java.security.AccessControlContext arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.EventStream>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/consumer/EventStream;Ljava/util/function/Consumer;)V", "public static")]
	public static void setOnChunkCompleteHandler(Dova.JDK.jdk.jfr.consumer.EventStream arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/management/EventSettingsModifier;)Ljdk/jfr/EventSettings;", "public static")]
	public static Dova.JDK.jdk.jfr.EventSettings newEventSettings(Dova.JDK.jdk.jfr.@internal.management.EventSettingsModifier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventSettings>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List getEventTypes()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Duration;Ljava/lang/String;)Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String formatTimespan(Dova.JDK.java.time.Duration arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/Recording;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getDestinationOriginalText(Dova.JDK.jdk.jfr.Recording arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "public static")]
	public static long parseTimespan(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/Recording;Ljava/lang/String;)V", "public static")]
	public static void checkSetDestination(Dova.JDK.jdk.jfr.Recording arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(J)Ljava/time/Instant;", "public static")]
	public static Dova.JDK.java.time.Instant epochNanosToInstant(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void logDebug(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/Recording;)J", "public static")]
	public static long getStartTimeNanos(Dova.JDK.jdk.jfr.Recording arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/Recording;Ljava/nio/file/Path;)V", "public static")]
	public static void removePath(Dova.JDK.jdk.jfr.Recording arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
	}
}
