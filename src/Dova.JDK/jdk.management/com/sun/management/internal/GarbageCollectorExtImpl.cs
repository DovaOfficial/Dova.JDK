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

namespace Dova.JDK.com.sun.management.@internal;

[JniSignatureAttribute("Lcom/sun/management/internal/GarbageCollectorExtImpl;", "public")]
public partial class GarbageCollectorExtImpl
	: Dova.JDK.sun.management.GarbageCollectorImpl
	, Dova.JDK.com.sun.management.GarbageCollectorMXBean
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GarbageCollectorExtImpl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/management/internal/GarbageCollectorExtImpl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "poolNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "notifName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "gcNotifTypes", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "seqNumber", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "gcInfoBuilder", "Lcom/sun/management/internal/GcInfoBuilder;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "GarbageCollectorExtImpl", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getGcInfoBuilder", "()Lcom/sun/management/internal/GcInfoBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createGCNotification", "(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/management/GcInfo;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createGarbageCollector", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/management/GarbageCollectorMXBean;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeNotificationListener", "(Ljavax/management/NotificationListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setNotificationEnabled", "(Lcom/sun/management/GarbageCollectorMXBean;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNotificationInfo", "()[Ljavax/management/MBeanNotificationInfo;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLastGcInfo", "()Lcom/sun/management/GcInfo;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAllPoolNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getNextSeqNumber", "()J"));
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> poolNames_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String notifName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> gcNotifTypes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private static")]
	public static long seqNumber_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Lcom/sun/management/internal/GcInfoBuilder;", "private")]
	public Dova.JDK.com.sun.management.@internal.GcInfoBuilder gcInfoBuilder_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.management.@internal.GcInfoBuilder>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GarbageCollectorExtImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public GarbageCollectorExtImpl(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/management/internal/GarbageCollectorExtImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/management/internal/GcInfoBuilder;", "private synchronized")]
	public Dova.JDK.com.sun.management.@internal.GcInfoBuilder getGcInfoBuilder()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.management.@internal.GcInfoBuilder>(ret);
	}

	[JniSignatureAttribute("(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/management/GcInfo;)V", "protected")]
	public void createGCNotification(long arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.management.GcInfo arg4)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/management/GarbageCollectorMXBean;", "private static")]
	public static Dova.JDK.java.lang.management.GarbageCollectorMXBean createGarbageCollector(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.management.GarbageCollectorMXBean>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public synchronized")]
	public void addNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public synchronized")]
	public void removeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;)V", "public synchronized")]
	public void removeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/management/GarbageCollectorMXBean;Z)V", "private native")]
	public void setNotificationEnabled(Dova.JDK.com.sun.management.GarbageCollectorMXBean arg0, bool arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()[Ljavax/management/MBeanNotificationInfo;", "public")]
	public JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> getNotificationInfo()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/management/GcInfo;", "public")]
	public Dova.JDK.com.sun.management.GcInfo getLastGcInfo()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.management.GcInfo>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "private synchronized")]
	public JavaArray<Dova.JDK.java.lang.String> getAllPoolNames()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()J", "private static")]
	public static long getNextSeqNumber()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[10]);
		return ret;
	}
}