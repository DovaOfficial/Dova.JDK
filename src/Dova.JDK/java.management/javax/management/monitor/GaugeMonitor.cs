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

[JniSignatureAttribute("Ljavax/management/monitor/GaugeMonitor;", "public")]
public partial class GaugeMonitor
	: Dova.JDK.javax.management.monitor.Monitor
	, Dova.JDK.javax.management.monitor.GaugeMonitorMBean
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GaugeMonitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/monitor/GaugeMonitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "highThreshold", "Ljava/lang/Number;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lowThreshold", "Ljava/lang/Number;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notifyHigh", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notifyLow", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "differenceMode", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "types", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "notifsInfo", "[Ljavax/management/MBeanNotificationInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RISING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FALLING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RISING_OR_FALLING", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotificationInfo", "()[Ljavax/management/MBeanNotificationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGauge_0", "(Ljavax/management/ObjectName;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGauge_1", "(Ljavax/management/ObjectName;)Ljava/lang/Number;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGauge", "()Ljava/lang/Number;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGaugeTimeStamp", "(Ljavax/management/ObjectName;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGaugeTimeStamp", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDerivedGaugeWithDifference", "(Ljava/lang/Number;Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateDerivedGauge", "(Ljava/lang/Object;Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDifferenceMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDifferenceMode", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createObservedObject", "(Ljavax/management/ObjectName;)Ljavax/management/monitor/Monitor$ObservedObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isComparableTypeValid", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGaugeFromComparable", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljava/lang/Comparable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onErrorNotification", "(Ljavax/management/monitor/MonitorNotification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildAlarmNotification", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljavax/management/monitor/MonitorNotification;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isThresholdTypeValid", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHighThreshold", "()Ljava/lang/Number;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowThreshold", "()Ljava/lang/Number;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setThresholds", "(Ljava/lang/Number;Ljava/lang/Number;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotifyHigh", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNotifyHigh", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotifyLow", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNotifyLow", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFirstStrictlyGreaterThanLast", "(Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFirstGreaterThanLast", "(Ljava/lang/Number;Ljava/lang/Number;Ljavax/management/monitor/Monitor$NumericalType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNotifications", "(Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;)Ljavax/management/monitor/MonitorNotification;"));
	}

	[JniSignatureAttribute("Ljava/lang/Number;", "private")]
	public Dova.JDK.java.lang.Number highThreshold_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Number;", "private")]
	public Dova.JDK.java.lang.Number lowThreshold_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool notifyHigh_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool notifyLow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool differenceMode_Property
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

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/management/MBeanNotificationInfo;", "private static final")]
	public static JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> notifsInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int RISING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FALLING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int RISING_OR_FALLING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GaugeMonitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public GaugeMonitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/monitor/GaugeMonitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public synchronized")]
	public void start()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void stop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()[Ljavax/management/MBeanNotificationInfo;", "public")]
	public JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> getNotificationInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object getDerivedGauge_0(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljava/lang/Number;", "public synchronized")]
	public Dova.JDK.java.lang.Number getDerivedGauge_1(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Number;", "public synchronized")]
	public Dova.JDK.java.lang.Number getDerivedGauge()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)J", "public synchronized")]
	public long getDerivedGaugeTimeStamp(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()J", "public synchronized")]
	public long getDerivedGaugeTimeStamp()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Number;Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;)V", "private synchronized")]
	public void setDerivedGaugeWithDifference(Dova.JDK.java.lang.Number arg0, Dova.JDK.javax.management.monitor.GaugeMonitor.GaugeMonitorObservedObject arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;)Z", "private synchronized")]
	public bool updateDerivedGauge(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.management.monitor.GaugeMonitor.GaugeMonitorObservedObject arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool getDifferenceMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public synchronized")]
	public void setDifferenceMode(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/monitor/Monitor$ObservedObject;", "")]
	public Dova.JDK.javax.management.monitor.Monitor.ObservedObject createObservedObject(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.ObservedObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Z", "synchronized")]
	public bool isComparableTypeValid(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "synchronized")]
	public Dova.JDK.java.lang.Comparable getDerivedGaugeFromComparable(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/MonitorNotification;)V", "synchronized")]
	public void onErrorNotification(Dova.JDK.javax.management.monitor.MonitorNotification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Ljavax/management/monitor/MonitorNotification;", "synchronized")]
	public Dova.JDK.javax.management.monitor.MonitorNotification buildAlarmNotification(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.MonitorNotification>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/lang/Comparable;)Z", "synchronized")]
	public bool isThresholdTypeValid(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Comparable arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Number;", "public synchronized")]
	public Dova.JDK.java.lang.Number getHighThreshold()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Number;", "public synchronized")]
	public Dova.JDK.java.lang.Number getLowThreshold()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Number;Ljava/lang/Number;)V", "public synchronized")]
	public void setThresholds(Dova.JDK.java.lang.Number arg0, Dova.JDK.java.lang.Number arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool getNotifyHigh()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public synchronized")]
	public void setNotifyHigh(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool getNotifyLow()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public synchronized")]
	public void setNotifyLow(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/String;)Z", "private")]
	public bool isFirstStrictlyGreaterThanLast(Dova.JDK.java.lang.Number arg0, Dova.JDK.java.lang.Number arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Number;Ljava/lang/Number;Ljavax/management/monitor/Monitor$NumericalType;)Z", "private")]
	public bool isFirstGreaterThanLast(Dova.JDK.java.lang.Number arg0, Dova.JDK.java.lang.Number arg1, Dova.JDK.javax.management.monitor.Monitor.NumericalType arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;)Ljavax/management/monitor/MonitorNotification;", "private synchronized")]
	public Dova.JDK.javax.management.monitor.MonitorNotification updateNotifications(Dova.JDK.javax.management.monitor.GaugeMonitor.GaugeMonitorObservedObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.MonitorNotification>(ret);
	}

	[JniSignatureAttribute("Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;", "static")]
	public partial class GaugeMonitorObservedObject
		: Dova.JDK.javax.management.monitor.Monitor.ObservedObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GaugeMonitorObservedObject()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "derivedGaugeValid", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljavax/management/monitor/Monitor$NumericalType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousScanGauge", "Ljava/lang/Number;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/ObjectName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Ljavax/management/monitor/Monitor$NumericalType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStatus", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatus", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDerivedGaugeValid", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDerivedGaugeValid", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPreviousScanGauge", "(Ljava/lang/Number;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreviousScanGauge", "()Ljava/lang/Number;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType", "(Ljavax/management/monitor/Monitor$NumericalType;)V"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool derivedGaugeValid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljavax/management/monitor/Monitor$NumericalType;", "private")]
		public Dova.JDK.javax.management.monitor.Monitor.NumericalType type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Number;", "private")]
		public Dova.JDK.java.lang.Number previousScanGauge_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int status_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GaugeMonitorObservedObject(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "public")]
		public GaugeMonitorObservedObject(Dova.JDK.javax.management.ObjectName arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/monitor/GaugeMonitor$GaugeMonitorObservedObject;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/management/monitor/Monitor$NumericalType;", "public final synchronized")]
		public Dova.JDK.javax.management.monitor.Monitor.NumericalType getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.monitor.Monitor.NumericalType>(ret);
		}

		[JniSignatureAttribute("(I)V", "public final synchronized")]
		public void setStatus(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()I", "public final synchronized")]
		public int getStatus()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "public final synchronized")]
		public void setDerivedGaugeValid(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Z", "public final synchronized")]
		public bool getDerivedGaugeValid()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Number;)V", "public final synchronized")]
		public void setPreviousScanGauge(Dova.JDK.java.lang.Number arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Number;", "public final synchronized")]
		public Dova.JDK.java.lang.Number getPreviousScanGauge()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/monitor/Monitor$NumericalType;)V", "public final synchronized")]
		public void setType(Dova.JDK.javax.management.monitor.Monitor.NumericalType arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}
	}
}
