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

namespace Dova.JDK.javax.management.remote.rmi;

[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnection;", "public abstract interface")]
public partial interface RMIConnection
	: IJavaObject
	, Dova.JDK.java.io.Closeable
	, Dova.JDK.java.rmi.Remote
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RMIConnection()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnection;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRegistered", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljavax/management/ObjectName;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttribute", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectionId", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterMBean", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectInstance", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryMBeans", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryNames", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanCount", "(Ljavax/security/auth/Subject;)Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultDomain", "(Ljavax/security/auth/Subject;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDomains", "(Ljavax/security/auth/Subject;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanInfo", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/MBeanInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListeners", "([Ljavax/management/ObjectName;[Ljava/rmi/MarshalledObject;[Ljavax/security/auth/Subject;)[Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListeners", "(Ljavax/management/ObjectName;[Ljava/lang/Integer;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fetchNotifications", "(JIJ)Ljavax/management/remote/NotificationResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstanceOf", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributes", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;"));
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object invoke(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.rmi.MarshalledObject arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.javax.security.auth.Subject arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Z", "public abstract")]
	bool isRegistered(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;", "public abstract")]
	Dova.JDK.javax.management.AttributeList getAttributes(Dova.JDK.javax.management.ObjectName arg0, JavaArray<Dova.JDK.java.lang.String> arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", "public abstract")]
	void setAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getConnectionId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public abstract")]
	Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2, Dova.JDK.javax.security.auth.Subject arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public abstract")]
	Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.rmi.MarshalledObject arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.javax.security.auth.Subject arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public abstract")]
	Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public abstract")]
	Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2, Dova.JDK.java.rmi.MarshalledObject arg3, JavaArray<Dova.JDK.java.lang.String> arg4, Dova.JDK.javax.security.auth.Subject arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V", "public abstract")]
	void unregisterMBean(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public abstract")]
	Dova.JDK.javax.management.ObjectInstance getObjectInstance(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set queryMBeans(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set queryNames(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)Ljava/lang/Integer;", "public abstract")]
	Dova.JDK.java.lang.Integer getMBeanCount(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getDefaultDomain(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)[Ljava/lang/String;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.String> getDomains(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/MBeanInfo;", "public abstract")]
	Dova.JDK.javax.management.MBeanInfo getMBeanInfo(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", "public abstract")]
	void addNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.rmi.MarshalledObject arg2, Dova.JDK.java.rmi.MarshalledObject arg3, Dova.JDK.javax.security.auth.Subject arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", "public abstract")]
	void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.rmi.MarshalledObject arg2, Dova.JDK.java.rmi.MarshalledObject arg3, Dova.JDK.javax.security.auth.Subject arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V", "public abstract")]
	void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljavax/management/ObjectName;[Ljava/rmi/MarshalledObject;[Ljavax/security/auth/Subject;)[Ljava/lang/Integer;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.Integer> addNotificationListeners(JavaArray<Dova.JDK.javax.management.ObjectName> arg0, JavaArray<Dova.JDK.java.rmi.MarshalledObject> arg1, JavaArray<Dova.JDK.javax.security.auth.Subject> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Integer>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;[Ljava/lang/Integer;Ljavax/security/auth/Subject;)V", "public abstract")]
	void removeNotificationListeners(Dova.JDK.javax.management.ObjectName arg0, JavaArray<Dova.JDK.java.lang.Integer> arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JIJ)Ljavax/management/remote/NotificationResult;", "public abstract")]
	Dova.JDK.javax.management.remote.NotificationResult fetchNotifications(long arg0, int arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.NotificationResult>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Z", "public abstract")]
	bool isInstanceOf(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;", "public abstract")]
	Dova.JDK.javax.management.AttributeList setAttributes(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
	}
}
