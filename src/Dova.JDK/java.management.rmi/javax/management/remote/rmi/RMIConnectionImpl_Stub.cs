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

[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnectionImpl_Stub;", "public final")]
public partial class RMIConnectionImpl_Stub
	: Dova.JDK.java.rmi.server.RemoteStub
	, Dova.JDK.javax.management.remote.rmi.RMIConnection
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RMIConnectionImpl_Stub()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnectionImpl_Stub;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_addNotificationListener_0", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_addNotificationListeners_1", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_close_2", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_createMBean_3", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_createMBean_4", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_createMBean_5", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_createMBean_6", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_fetchNotifications_7", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_getAttribute_8", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_getAttributes_9", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_getConnectionId_10", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_getDefaultDomain_11", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_getDomains_12", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_getMBeanCount_13", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_getMBeanInfo_14", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_getObjectInstance_15", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_invoke_16", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_isInstanceOf_17", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_isRegistered_18", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_queryMBeans_19", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_queryNames_20", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_removeNotificationListener_21", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_removeNotificationListener_22", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_removeNotificationListeners_23", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_setAttribute_24", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_setAttributes_25", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$method_unregisterMBean_26", "Ljava/lang/reflect/Method;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/rmi/server/RemoteRef;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRegistered", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljavax/management/ObjectName;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttribute", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectionId", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterMBean", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectInstance", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryMBeans", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryNames", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanCount", "(Ljavax/security/auth/Subject;)Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultDomain", "(Ljavax/security/auth/Subject;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDomains", "(Ljavax/security/auth/Subject;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanInfo", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/MBeanInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListeners", "([Ljavax/management/ObjectName;[Ljava/rmi/MarshalledObject;[Ljavax/security/auth/Subject;)[Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListeners", "(Ljavax/management/ObjectName;[Ljava/lang/Integer;Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fetchNotifications", "(JIJ)Ljavax/management/remote/NotificationResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstanceOf", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributes", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_addNotificationListener_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_addNotificationListeners_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_close_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_createMBean_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_createMBean_4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_createMBean_5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_createMBean_6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_fetchNotifications_7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_getAttribute_8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_getAttributes_9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_getConnectionId_10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_getDefaultDomain_11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_getDomains_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_getMBeanCount_13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_getMBeanInfo_14_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_getObjectInstance_15_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_invoke_16_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_isInstanceOf_17_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_isRegistered_18_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_queryMBeans_19_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_queryNames_20_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_removeNotificationListener_21_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_removeNotificationListener_22_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_removeNotificationListeners_23_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_setAttribute_24_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_setAttributes_25_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method method_unregisterMBean_26_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RMIConnectionImpl_Stub(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/rmi/server/RemoteRef;)V", "public")]
	public RMIConnectionImpl_Stub(Dova.JDK.java.rmi.server.RemoteRef arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIConnectionImpl_Stub;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.rmi.MarshalledObject arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.javax.security.auth.Subject arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Z", "public")]
	public bool isRegistered(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;", "public")]
	public Dova.JDK.javax.management.AttributeList getAttributes(Dova.JDK.javax.management.ObjectName arg0, JavaArray<Dova.JDK.java.lang.String> arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", "public")]
	public void setAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getConnectionId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2, Dova.JDK.java.rmi.MarshalledObject arg3, JavaArray<Dova.JDK.java.lang.String> arg4, Dova.JDK.javax.security.auth.Subject arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.rmi.MarshalledObject arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.javax.security.auth.Subject arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2, Dova.JDK.javax.security.auth.Subject arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V", "public")]
	public void unregisterMBean(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance getObjectInstance(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set queryMBeans(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set queryNames(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)Ljava/lang/Integer;", "public")]
	public Dova.JDK.java.lang.Integer getMBeanCount(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDefaultDomain(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getDomains(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/MBeanInfo;", "public")]
	public Dova.JDK.javax.management.MBeanInfo getMBeanInfo(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", "public")]
	public void addNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.rmi.MarshalledObject arg2, Dova.JDK.java.rmi.MarshalledObject arg3, Dova.JDK.javax.security.auth.Subject arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.rmi.MarshalledObject arg2, Dova.JDK.java.rmi.MarshalledObject arg3, Dova.JDK.javax.security.auth.Subject arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("([Ljavax/management/ObjectName;[Ljava/rmi/MarshalledObject;[Ljavax/security/auth/Subject;)[Ljava/lang/Integer;", "public")]
	public JavaArray<Dova.JDK.java.lang.Integer> addNotificationListeners(JavaArray<Dova.JDK.javax.management.ObjectName> arg0, JavaArray<Dova.JDK.java.rmi.MarshalledObject> arg1, JavaArray<Dova.JDK.javax.security.auth.Subject> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Integer>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;[Ljava/lang/Integer;Ljavax/security/auth/Subject;)V", "public")]
	public void removeNotificationListeners(Dova.JDK.javax.management.ObjectName arg0, JavaArray<Dova.JDK.java.lang.Integer> arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JIJ)Ljavax/management/remote/NotificationResult;", "public")]
	public Dova.JDK.javax.management.remote.NotificationResult fetchNotifications(long arg0, int arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.NotificationResult>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Z", "public")]
	public bool isInstanceOf(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;", "public")]
	public Dova.JDK.javax.management.AttributeList setAttributes(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
	}
}
