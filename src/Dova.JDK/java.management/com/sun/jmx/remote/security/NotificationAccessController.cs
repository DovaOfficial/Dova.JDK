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

namespace Dova.JDK.com.sun.jmx.remote.security;

[JniSignatureAttribute("Lcom/sun/jmx/remote/security/NotificationAccessController;", "public abstract interface")]
public partial interface NotificationAccessController
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NotificationAccessController()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/security/NotificationAccessController;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fetchNotification", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/Notification;Ljavax/security/auth/Subject;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V", "public abstract")]
	void addNotificationListener(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V", "public abstract")]
	void removeNotificationListener(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/Notification;Ljavax/security/auth/Subject;)V", "public abstract")]
	void fetchNotification(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.Notification arg2, Dova.JDK.javax.security.auth.Subject arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}
}
