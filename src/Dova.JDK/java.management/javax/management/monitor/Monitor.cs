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

namespace Dova.JDK.javax.management.monitor;

[JniSignatureAttribute("Ljavax/management/monitor/Monitor;", "public abstract")]
public partial class Monitor
	: Dova.JDK.javax.management.NotificationBroadcasterSupport
	, Dova.JDK.javax.management.monitor.MonitorMBean
	, Dova.JDK.javax.management.MBeanRegistration
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Monitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/monitor/Monitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "observedAttribute", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "granularityPeriod", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isActive", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sequenceNumber", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isComplexTypeAttribute", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstAttribute", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "remainingAttributes", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "noPermissionsACC", "Ljava/security/AccessControlContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "scheduler", "Ljava/util/concurrent/ScheduledExecutorService;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "executors", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "executorsLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "maximumPoolSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "monitorFuture", "Ljava/util/concurrent/Future;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "schedulerTask", "Ljavax/management/monitor/Monitor$SchedulerTask;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "schedulerFuture", "Ljava/util/concurrent/ScheduledFuture;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "capacityIncrement", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elementCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alreadyNotified", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alreadyNotifieds", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "server", "Ljavax/management/MBeanServer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESET_FLAGS_ALREADY_NOTIFIED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBSERVED_OBJECT_ERROR_NOTIFIED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBSERVED_ATTRIBUTE_ERROR_NOTIFIED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBSERVED_ATTRIBUTE_TYPE_ERROR_NOTIFIED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUNTIME_ERROR_NOTIFIED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dbgTag", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "observedObjects", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THRESHOLD_ERROR_NOTIFIED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER_ZERO", "Ljava/lang/Integer;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isActive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljavax/management/MBeanServerConnection;Ljavax/management/ObjectName;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postRegister", "(Ljava/lang/Boolean;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preDeregister", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postDeregister", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preRegister", "(Ljavax/management/MBeanServer;Ljavax/management/ObjectName;)Ljavax/management/ObjectName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObservedObject", "(Ljavax/management/ObjectName;)Ljavax/management/monitor/Monitor$ObservedObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObservedObject", "()Ljavax/management/ObjectName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsObservedObject", "(Ljavax/management/ObjectName;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addObservedObject", "(Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createObservedObject", "(Ljavax/management/ObjectName;)Ljavax/management/monitor/Monitor$ObservedObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAlreadyNotified", "(Ljavax/management/monitor/Monitor$ObservedObject;II[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAlreadyNotified", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanupIsComplexTypeAttribute", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetAlreadyNotified", "(Ljavax/management/monitor/Monitor$ObservedObject;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanupFutures", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGranularityPeriod", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGauge", "(Ljavax/management/ObjectName;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGaugeTimeStamp", "(Ljavax/management/ObjectName;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObservedAttribute", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateDeprecatedAlreadyNotified", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeAlreadyNotifiedIndex", "(Ljavax/management/monitor/Monitor$ObservedObject;I[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAlreadyNotified", "(Ljavax/management/monitor/Monitor$ObservedObject;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onErrorNotification", "(Ljavax/management/monitor/MonitorNotification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlreadyNotified", "(Ljavax/management/monitor/Monitor$ObservedObject;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComparableFromAttribute", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Comparable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isComparableTypeValid", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isThresholdTypeValid", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildErrorNotification", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetAllAlreadyNotified", "(Ljavax/management/monitor/Monitor$ObservedObject;I[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGaugeFromComparable", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljava/lang/Comparable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildAlarmNotification", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljavax/management/monitor/MonitorNotification;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObservedObject", "(Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeObservedObject", "(Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObservedObjects", "()[Ljavax/management/ObjectName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObservedAttribute", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGranularityPeriod", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doStart", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doStop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "classForType", "(Ljavax/management/monitor/Monitor$NumericalType;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidForType", "(Ljava/lang/Object;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "monitor", "(Ljavax/management/monitor/Monitor$ObservedObject;I[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNotification", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljavax/management/ObjectName;Z)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String observedAttribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long granularityPeriod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isActive_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicLong sequenceNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isComplexTypeAttribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String firstAttribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List remainingAttributes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private static final")]
	public static Dova.JDK.java.security.AccessControlContext noPermissionsACC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private volatile")]
	public Dova.JDK.java.security.AccessControlContext acc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ScheduledExecutorService;", "private static final")]
	public static Dova.JDK.java.util.concurrent.ScheduledExecutorService scheduler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledExecutorService>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map executors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object executorsLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int maximumPoolSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/Future;", "private")]
	public Dova.JDK.java.util.concurrent.Future monitorFuture_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/monitor/Monitor$SchedulerTask;", "private final")]
	public Dova.JDK.javax.management.monitor.Monitor.SchedulerTask schedulerTask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.SchedulerTask>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ScheduledFuture;", "private")]
	public Dova.JDK.java.util.concurrent.ScheduledFuture schedulerFuture_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledFuture>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int capacityIncrement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int elementCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int alreadyNotified_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("[I", "protected")]
	public JavaArray<int> alreadyNotifieds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/MBeanServer;", "protected")]
	public Dova.JDK.javax.management.MBeanServer server_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int RESET_FLAGS_ALREADY_NOTIFIED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int OBSERVED_OBJECT_ERROR_NOTIFIED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int OBSERVED_ATTRIBUTE_ERROR_NOTIFIED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int OBSERVED_ATTRIBUTE_TYPE_ERROR_NOTIFIED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int RUNTIME_ERROR_NOTIFIED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String dbgTag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List observedObjects_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int THRESHOLD_ERROR_NOTIFIED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Integer;", "static final")]
	public static Dova.JDK.java.lang.Integer INTEGER_ZERO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Monitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Monitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/monitor/Monitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public abstract")]
	public void start()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void stop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool isActive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServerConnection;Ljavax/management/ObjectName;Ljava/lang/String;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object getAttribute(Dova.JDK.javax.management.MBeanServerConnection arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Boolean;)V", "public")]
	public void postRegister(Dova.JDK.java.lang.Boolean arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void preDeregister()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void postDeregister()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;Ljavax/management/ObjectName;)Ljavax/management/ObjectName;", "public")]
	public Dova.JDK.javax.management.ObjectName preRegister(Dova.JDK.javax.management.MBeanServer arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/monitor/Monitor$ObservedObject;", "synchronized")]
	public Dova.JDK.javax.management.monitor.Monitor.ObservedObject getObservedObject(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.ObservedObject>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/ObjectName;", "public synchronized")]
	public Dova.JDK.javax.management.ObjectName getObservedObject()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Z", "public synchronized")]
	public bool containsObservedObject(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "public synchronized")]
	public void addObservedObject(Dova.JDK.javax.management.ObjectName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/monitor/Monitor$ObservedObject;", "")]
	public Dova.JDK.javax.management.monitor.Monitor.ObservedObject createObservedObject(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.ObservedObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$ObservedObject;II[I)V", "synchronized")]
	public void setAlreadyNotified(Dova.JDK.javax.management.monitor.Monitor.ObservedObject arg0, int arg1, int arg2, JavaArray<int> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void createAlreadyNotified()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()V", "private synchronized")]
	public void cleanupIsComplexTypeAttribute()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$ObservedObject;II)V", "synchronized")]
	public void resetAlreadyNotified(Dova.JDK.javax.management.monitor.Monitor.ObservedObject arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "private synchronized")]
	public void cleanupFutures()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()J", "public synchronized")]
	public long getGranularityPeriod()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljava/lang/Object;", "synchronized")]
	public Dova.JDK.java.lang.Object getDerivedGauge(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)J", "synchronized")]
	public long getDerivedGaugeTimeStamp(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public synchronized")]
	public Dova.JDK.java.lang.String getObservedAttribute()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void updateDeprecatedAlreadyNotified()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$ObservedObject;I[I)I", "synchronized")]
	public int computeAlreadyNotifiedIndex(Dova.JDK.javax.management.monitor.Monitor.ObservedObject arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$ObservedObject;I)V", "synchronized")]
	public void updateAlreadyNotified(Dova.JDK.javax.management.monitor.Monitor.ObservedObject arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/MonitorNotification;)V", "")]
	public void onErrorNotification(Dova.JDK.javax.management.monitor.MonitorNotification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$ObservedObject;I)Z", "synchronized")]
	public bool isAlreadyNotified(Dova.JDK.javax.management.monitor.Monitor.ObservedObject arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Comparable;", "")]
	public Dova.JDK.java.lang.Comparable getComparableFromAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Z", "")]
	public bool isComparableTypeValid(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Z", "")]
	public bool isThresholdTypeValid(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String buildErrorNotification(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$ObservedObject;I[I)V", "synchronized")]
	public void resetAllAlreadyNotified(Dova.JDK.javax.management.monitor.Monitor.ObservedObject arg0, int arg1, JavaArray<int> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
	public Dova.JDK.java.lang.Comparable getDerivedGaugeFromComparable(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljavax/management/monitor/MonitorNotification;", "")]
	public Dova.JDK.javax.management.monitor.MonitorNotification buildAlarmNotification(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.MonitorNotification>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "public synchronized")]
	public void setObservedObject(Dova.JDK.javax.management.ObjectName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "public synchronized")]
	public void removeObservedObject(Dova.JDK.javax.management.ObjectName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/management/ObjectName;", "public synchronized")]
	public JavaArray<Dova.JDK.javax.management.ObjectName> getObservedObjects()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.ObjectName>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setObservedAttribute(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(J)V", "public synchronized")]
	public void setGranularityPeriod(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void doStart()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39]);
	}

	[JniSignatureAttribute("()V", "")]
	public void doStop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40]);
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$NumericalType;)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class classForType(Dova.JDK.javax.management.monitor.Monitor.NumericalType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Z", "static")]
	public static bool isValidForType(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$ObservedObject;I[I)V", "private")]
	public void monitor(Dova.JDK.javax.management.monitor.Monitor.ObservedObject arg0, int arg1, JavaArray<int> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;JLjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljavax/management/ObjectName;Z)V", "private")]
	public void sendNotification(Dova.JDK.java.lang.String arg0, long arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.javax.management.ObjectName arg5, bool arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("Ljavax/management/monitor/Monitor$SchedulerTask;", "private")]
	public partial class SchedulerTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SchedulerTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/monitor/Monitor$SchedulerTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "task", "Ljavax/management/monitor/Monitor$MonitorTask;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/management/monitor/Monitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/monitor/Monitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMonitorTask", "(Ljavax/management/monitor/Monitor$MonitorTask;)V"));
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor$MonitorTask;", "private")]
		public Dova.JDK.javax.management.monitor.Monitor.MonitorTask task_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.MonitorTask>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor;", "final")]
		public Dova.JDK.javax.management.monitor.Monitor this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SchedulerTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/monitor/Monitor;)V", "public")]
		public SchedulerTask(Dova.JDK.javax.management.monitor.Monitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/monitor/Monitor$SchedulerTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$MonitorTask;)V", "public")]
		public void setMonitorTask(Dova.JDK.javax.management.monitor.Monitor.MonitorTask arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/management/monitor/Monitor$ObservedObject;", "static")]
	public partial class ObservedObject
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ObservedObject()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/monitor/Monitor$ObservedObject;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "observedObject", "Ljavax/management/ObjectName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alreadyNotified", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "derivedGauge", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "derivedGaugeTimeStamp", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/ObjectName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObservedObject", "()Ljavax/management/ObjectName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAlreadyNotified", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDerivedGauge", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDerivedGaugeTimeStamp", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGauge", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGaugeTimeStamp", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlreadyNotified", "()I"));
		}

		[JniSignatureAttribute("Ljavax/management/ObjectName;", "private final")]
		public Dova.JDK.javax.management.ObjectName observedObject_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int alreadyNotified_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object derivedGauge_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private")]
		public long derivedGaugeTimeStamp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ObservedObject(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "public")]
		public ObservedObject(Dova.JDK.javax.management.ObjectName arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/monitor/Monitor$ObservedObject;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/management/ObjectName;", "public final")]
		public Dova.JDK.javax.management.ObjectName getObservedObject()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
		}

		[JniSignatureAttribute("(I)V", "public final synchronized")]
		public void setAlreadyNotified(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public final synchronized")]
		public void setDerivedGauge(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(J)V", "public final synchronized")]
		public void setDerivedGaugeTimeStamp(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public final synchronized")]
		public Dova.JDK.java.lang.Object getDerivedGauge()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()J", "public final synchronized")]
		public long getDerivedGaugeTimeStamp()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public final synchronized")]
		public int getAlreadyNotified()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/management/monitor/Monitor$MonitorTask;", "private")]
	public partial class MonitorTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MonitorTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/monitor/Monitor$MonitorTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/ThreadPoolExecutor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/management/monitor/Monitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/monitor/Monitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "submit", "()Ljava/util/concurrent/Future;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ThreadPoolExecutor;", "private")]
		public Dova.JDK.java.util.concurrent.ThreadPoolExecutor executor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ThreadPoolExecutor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor;", "final")]
		public Dova.JDK.javax.management.monitor.Monitor this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MonitorTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/monitor/Monitor;)V", "public")]
		public MonitorTask(Dova.JDK.javax.management.monitor.Monitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/monitor/Monitor$MonitorTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/Future;", "public")]
		public Dova.JDK.java.util.concurrent.Future submit()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/management/monitor/Monitor$NumericalType;", "static final")]
	public partial class NumericalType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NumericalType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/monitor/Monitor$NumericalType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Ljavax/management/monitor/Monitor$NumericalType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Ljavax/management/monitor/Monitor$NumericalType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Ljavax/management/monitor/Monitor$NumericalType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Ljavax/management/monitor/Monitor$NumericalType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Ljavax/management/monitor/Monitor$NumericalType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Ljavax/management/monitor/Monitor$NumericalType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljavax/management/monitor/Monitor$NumericalType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljavax/management/monitor/Monitor$NumericalType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljavax/management/monitor/Monitor$NumericalType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljavax/management/monitor/Monitor$NumericalType;"));
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor$NumericalType;", "public static final")]
		public static Dova.JDK.javax.management.monitor.Monitor.NumericalType BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor$NumericalType;", "public static final")]
		public static Dova.JDK.javax.management.monitor.Monitor.NumericalType SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor$NumericalType;", "public static final")]
		public static Dova.JDK.javax.management.monitor.Monitor.NumericalType INTEGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor$NumericalType;", "public static final")]
		public static Dova.JDK.javax.management.monitor.Monitor.NumericalType LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor$NumericalType;", "public static final")]
		public static Dova.JDK.javax.management.monitor.Monitor.NumericalType FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor$NumericalType;", "public static final")]
		public static Dova.JDK.javax.management.monitor.Monitor.NumericalType DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/management/monitor/Monitor$NumericalType;", "private static final")]
		public static JavaArray<Dova.JDK.javax.management.monitor.Monitor.NumericalType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.monitor.Monitor.NumericalType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NumericalType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public NumericalType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/monitor/Monitor$NumericalType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/management/monitor/Monitor$NumericalType;", "public static")]
		public static JavaArray<Dova.JDK.javax.management.monitor.Monitor.NumericalType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.monitor.Monitor.NumericalType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/management/monitor/Monitor$NumericalType;", "public static")]
		public static Dova.JDK.javax.management.monitor.Monitor.NumericalType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/management/monitor/Monitor$NumericalType;", "private static")]
		public static JavaArray<Dova.JDK.javax.management.monitor.Monitor.NumericalType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.monitor.Monitor.NumericalType>>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/management/monitor/Monitor$DaemonThreadFactory;", "private static")]
	public partial class DaemonThreadFactory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.ThreadFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DaemonThreadFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/monitor/Monitor$DaemonThreadFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "group", "Ljava/lang/ThreadGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "threadNumber", "Ljava/util/concurrent/atomic/AtomicInteger;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "namePrefix", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nameSuffix", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/ThreadGroup;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThreadGroup", "()Ljava/lang/ThreadGroup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"));
		}

		[JniSignatureAttribute("Ljava/lang/ThreadGroup;", "final")]
		public Dova.JDK.java.lang.ThreadGroup group_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicInteger;", "final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicInteger threadNumber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicInteger>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String namePrefix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "static final")]
		public static Dova.JDK.java.lang.String nameSuffix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DaemonThreadFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public DaemonThreadFactory(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ThreadGroup;)V", "public")]
		public DaemonThreadFactory(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ThreadGroup arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/monitor/Monitor$DaemonThreadFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/ThreadGroup;", "public")]
		public Dova.JDK.java.lang.ThreadGroup getThreadGroup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/lang/Thread;", "public")]
		public Dova.JDK.java.lang.Thread newThread(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
	}
}
