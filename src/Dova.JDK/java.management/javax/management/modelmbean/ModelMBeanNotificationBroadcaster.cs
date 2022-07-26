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

namespace Dova.JDK.javax.management.modelmbean;

[JniSignatureAttribute("Ljavax/management/modelmbean/ModelMBeanNotificationBroadcaster;", "public abstract interface")]
public partial interface ModelMBeanNotificationBroadcaster
	: IJavaObject
	, Dova.JDK.javax.management.NotificationBroadcaster
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModelMBeanNotificationBroadcaster()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/modelmbean/ModelMBeanNotificationBroadcaster;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNotification", "(Ljavax/management/Notification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNotification", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendAttributeChangeNotification", "(Ljavax/management/Attribute;Ljavax/management/Attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendAttributeChangeNotification", "(Ljavax/management/AttributeChangeNotification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttributeChangeNotificationListener", "(Ljavax/management/NotificationListener;Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAttributeChangeNotificationListener", "(Ljavax/management/NotificationListener;Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("(Ljavax/management/Notification;)V", "public abstract")]
	void sendNotification(Dova.JDK.javax.management.Notification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void sendNotification(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/Attribute;Ljavax/management/Attribute;)V", "public abstract")]
	void sendAttributeChangeNotification(Dova.JDK.javax.management.Attribute arg0, Dova.JDK.javax.management.Attribute arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/AttributeChangeNotification;)V", "public abstract")]
	void sendAttributeChangeNotification(Dova.JDK.javax.management.AttributeChangeNotification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljava/lang/String;Ljava/lang/Object;)V", "public abstract")]
	void addAttributeChangeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljava/lang/String;)V", "public abstract")]
	void removeAttributeChangeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}
}
