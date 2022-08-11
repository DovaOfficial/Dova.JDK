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

namespace Dova.JDK.sun.jvmstat.monitor;

[JniSignatureAttribute("Lsun/jvmstat/monitor/MonitoredHost;", "public abstract")]
public partial class MonitoredHost
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MonitoredHost()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/monitor/MonitoredHost;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "monitoredHosts", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_PROTOCOL_PROP_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_PROTOCOL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REMOTE_PROTOCOL_PROP_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REMOTE_PROTOCOL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hostId", "Lsun/jvmstat/monitor/HostIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interval", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastException", "Ljava/lang/Exception;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "monitoredHostServiceLoader", "Ljava/util/ServiceLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detach", "(Lsun/jvmstat/monitor/MonitoredVm;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolveHostId", "(Lsun/jvmstat/monitor/HostIdentifier;)Lsun/jvmstat/monitor/HostIdentifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeHostListener", "(Lsun/jvmstat/monitor/event/HostListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMonitoredHost", "(Ljava/lang/String;)Lsun/jvmstat/monitor/MonitoredHost;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMonitoredHost", "(Lsun/jvmstat/monitor/VmIdentifier;)Lsun/jvmstat/monitor/MonitoredHost;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMonitoredHost", "(Lsun/jvmstat/monitor/HostIdentifier;)Lsun/jvmstat/monitor/MonitoredHost;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "activeVms", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonitoredVm", "(Lsun/jvmstat/monitor/VmIdentifier;)Lsun/jvmstat/monitor/MonitoredVm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonitoredVm", "(Lsun/jvmstat/monitor/VmIdentifier;I)Lsun/jvmstat/monitor/MonitoredVm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInterval", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterval", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLastException", "(Ljava/lang/Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastException", "()Ljava/lang/Exception;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearLastException", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErrored", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHostIdentifier", "()Lsun/jvmstat/monitor/HostIdentifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHostListener", "(Lsun/jvmstat/monitor/event/HostListener;)V"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map monitoredHosts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String LOCAL_PROTOCOL_PROP_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String LOCAL_PROTOCOL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String REMOTE_PROTOCOL_PROP_NAME_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String REMOTE_PROTOCOL_Property
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

	[JniSignatureAttribute("Lsun/jvmstat/monitor/HostIdentifier;", "protected")]
	public Dova.JDK.sun.jvmstat.monitor.HostIdentifier hostId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.HostIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int interval_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Exception;", "protected")]
	public Dova.JDK.java.lang.Exception lastException_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ServiceLoader;", "private static")]
	public static Dova.JDK.java.util.ServiceLoader monitoredHostServiceLoader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ServiceLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MonitoredHost(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MonitoredHost() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/jvmstat/monitor/MonitoredHost;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/MonitoredVm;)V", "public abstract")]
	public void detach(Dova.JDK.sun.jvmstat.monitor.MonitoredVm arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/HostIdentifier;)Lsun/jvmstat/monitor/HostIdentifier;", "protected static")]
	public static Dova.JDK.sun.jvmstat.monitor.HostIdentifier resolveHostId(Dova.JDK.sun.jvmstat.monitor.HostIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.HostIdentifier>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/HostListener;)V", "public abstract")]
	public void removeHostListener(Dova.JDK.sun.jvmstat.monitor.@event.HostListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/jvmstat/monitor/MonitoredHost;", "public static")]
	public static Dova.JDK.sun.jvmstat.monitor.MonitoredHost getMonitoredHost(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredHost>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/VmIdentifier;)Lsun/jvmstat/monitor/MonitoredHost;", "public static")]
	public static Dova.JDK.sun.jvmstat.monitor.MonitoredHost getMonitoredHost(Dova.JDK.sun.jvmstat.monitor.VmIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredHost>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/HostIdentifier;)Lsun/jvmstat/monitor/MonitoredHost;", "public static")]
	public static Dova.JDK.sun.jvmstat.monitor.MonitoredHost getMonitoredHost(Dova.JDK.sun.jvmstat.monitor.HostIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredHost>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	public Dova.JDK.java.util.Set activeVms()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/VmIdentifier;)Lsun/jvmstat/monitor/MonitoredVm;", "public abstract")]
	public Dova.JDK.sun.jvmstat.monitor.MonitoredVm getMonitoredVm(Dova.JDK.sun.jvmstat.monitor.VmIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredVm>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/VmIdentifier;I)Lsun/jvmstat/monitor/MonitoredVm;", "public abstract")]
	public Dova.JDK.sun.jvmstat.monitor.MonitoredVm getMonitoredVm(Dova.JDK.sun.jvmstat.monitor.VmIdentifier arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.MonitoredVm>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setInterval(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getInterval()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;)V", "public")]
	public void setLastException(Dova.JDK.java.lang.Exception arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Exception;", "public")]
	public Dova.JDK.java.lang.Exception getLastException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearLastException()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isErrored()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/jvmstat/monitor/HostIdentifier;", "public")]
	public Dova.JDK.sun.jvmstat.monitor.HostIdentifier getHostIdentifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.monitor.HostIdentifier>(ret);
	}

	[JniSignatureAttribute("(Lsun/jvmstat/monitor/event/HostListener;)V", "public abstract")]
	public void addHostListener(Dova.JDK.sun.jvmstat.monitor.@event.HostListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}
}
