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

namespace Dova.JDK.javax.management;

[JniSignatureAttribute("Ljavax/management/StandardEmitterMBean;", "public")]
public partial class StandardEmitterMBean
	: Dova.JDK.javax.management.StandardMBean
	, Dova.JDK.javax.management.NotificationEmitter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StandardEmitterMBean()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/StandardEmitterMBean;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_NOTIFICATION_INFO", "[Ljavax/management/MBeanNotificationInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "emitter", "Ljavax/management/NotificationEmitter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notificationInfo", "[Ljavax/management/MBeanNotificationInfo;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;ZLjavax/management/NotificationEmitter;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljavax/management/NotificationEmitter;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Class;ZLjavax/management/NotificationEmitter;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Class;Ljavax/management/NotificationEmitter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/NotificationListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotifications", "(Ljavax/management/MBeanInfo;)[Ljavax/management/MBeanNotificationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotificationInfo", "()[Ljavax/management/MBeanNotificationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNotification", "(Ljavax/management/Notification;)V"));
	}

	[JniSignatureAttribute("[Ljavax/management/MBeanNotificationInfo;", "private static final")]
	public static JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> NO_NOTIFICATION_INFO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/NotificationEmitter;", "private final")]
	public Dova.JDK.javax.management.NotificationEmitter emitter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationEmitter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/management/MBeanNotificationInfo;", "private final")]
	public JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> notificationInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StandardEmitterMBean(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;ZLjavax/management/NotificationEmitter;)V", "protected")]
	public StandardEmitterMBean(Dova.JDK.java.lang.Class arg0, bool arg1, Dova.JDK.javax.management.NotificationEmitter arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljavax/management/NotificationEmitter;)V", "protected")]
	public StandardEmitterMBean(Dova.JDK.java.lang.Class arg0, Dova.JDK.javax.management.NotificationEmitter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;ZLjavax/management/NotificationEmitter;)V", "public")]
	public StandardEmitterMBean(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1, bool arg2, Dova.JDK.javax.management.NotificationEmitter arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;Ljavax/management/NotificationEmitter;)V", "public")]
	public StandardEmitterMBean(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.javax.management.NotificationEmitter arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/StandardEmitterMBean;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void addNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanInfo;)[Ljavax/management/MBeanNotificationInfo;", "")]
	public JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> getNotifications(Dova.JDK.javax.management.MBeanInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/management/MBeanNotificationInfo;", "public")]
	public JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> getNotificationInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/Notification;)V", "public")]
	public void sendNotification(Dova.JDK.javax.management.Notification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}
