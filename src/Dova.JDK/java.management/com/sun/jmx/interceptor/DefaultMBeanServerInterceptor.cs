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

namespace Dova.JDK.com.sun.jmx.interceptor;

[JniSignatureAttribute("Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor;", "public")]
public partial class DefaultMBeanServerInterceptor
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.jmx.interceptor.MBeanServerInterceptor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultMBeanServerInterceptor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instantiator", "Lcom/sun/jmx/mbeanserver/MBeanInstantiator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "server", "Ljavax/management/MBeanServer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Ljavax/management/MBeanServerDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "repository", "Lcom/sun/jmx/mbeanserver/Repository;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listenerWrappers", "Ljava/util/WeakHashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "domain", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "beingUnregistered", "Ljava/util/Set;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/MBeanServer;Ljavax/management/MBeanServerDelegate;Lcom/sun/jmx/mbeanserver/MBeanInstantiator;Lcom/sun/jmx/mbeanserver/Repository;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljavax/management/ObjectName;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "(Ljavax/management/ObjectName;)Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getResource", "(Ljavax/management/DynamicMBean;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRegistered", "(Ljavax/management/ObjectName;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljavax/management/ObjectName;[Ljava/lang/String;)Ljavax/management/AttributeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClassName", "(Ljavax/management/DynamicMBean;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttribute", "(Ljavax/management/ObjectName;Ljavax/management/Attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljavax/management/ObjectName;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rethrow", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "postRegister", "(Ljavax/management/ObjectName;Ljavax/management/DynamicMBean;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListener", "(Ljavax/management/ObjectName;)Ljavax/management/NotificationListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "preRegister", "(Ljavax/management/DynamicMBean;Ljavax/management/MBeanServer;Ljavax/management/ObjectName;)Ljavax/management/ObjectName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassLoader", "(Ljava/lang/ClassLoader;Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeClassLoader", "(Ljava/lang/ClassLoader;Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMBeanPermission", "(Ljava/lang/String;Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMBeanPermission", "(Ljavax/management/DynamicMBean;Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "safeGetClassName", "(Ljavax/management/DynamicMBean;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nonDefaultDomain", "(Ljavax/management/ObjectName;)Ljavax/management/ObjectName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMBeanTrustPermission", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNewMBeanClassName", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerObject", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exclusiveUnregisterMBean", "(Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBean", "(Ljavax/management/ObjectName;)Ljavax/management/DynamicMBean;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "preDeregisterInvoke", "(Ljavax/management/MBeanRegistration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterFromRepository", "(Ljava/lang/Object;Ljavax/management/DynamicMBean;Ljavax/management/ObjectName;)Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "postDeregisterInvoke", "(Ljavax/management/ObjectName;Ljavax/management/MBeanRegistration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryMBeansImpl", "(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filterListOfObjectInstances", "(Ljava/util/Set;Ljavax/management/QueryExp;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "objectInstancesFromFilteredNamedObjects", "(Ljava/util/Set;Ljavax/management/QueryExp;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryNamesImpl", "(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "objectNamesFromFilteredNamedObjects", "(Ljava/util/Set;Ljavax/management/QueryExp;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rethrowMaybeMBeanException", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerDynamicMBean", "(Ljava/lang/String;Ljavax/management/DynamicMBean;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerWithRepository", "(Ljava/lang/Object;Ljavax/management/DynamicMBean;Ljavax/management/ObjectName;)Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwMBeanRegistrationException", "(Ljava/lang/Throwable;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNotificationBroadcaster", "(Ljavax/management/ObjectName;Ljava/lang/Object;Ljava/lang/Class;)Ljavax/management/NotificationBroadcaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListenerWrapper", "(Ljavax/management/NotificationListener;Ljavax/management/ObjectName;Ljavax/management/DynamicMBean;Z)Ljavax/management/NotificationListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeResourceContextFor", "(Ljava/lang/Object;Ljavax/management/ObjectName;)Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstantiatorCLR", "()Lcom/sun/jmx/mbeanserver/ModifiableClassLoaderRepository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createClassLoaderContext", "(Ljava/lang/ClassLoader;Ljavax/management/ObjectName;)Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterMBean", "(Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstanceOf", "(Ljavax/management/ObjectName;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryNames", "(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerMBean", "(Ljava/lang/Object;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNotification", "(Ljava/lang/String;Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Z[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectInstance", "(Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryMBeans", "(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanCount", "()Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributes", "(Ljavax/management/ObjectName;Ljavax/management/AttributeList;)Ljavax/management/AttributeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultDomain", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDomains", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanInfo", "(Ljavax/management/ObjectName;)Ljavax/management/MBeanInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/String;Ljavax/management/ObjectName;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/String;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoaderFor", "(Ljavax/management/ObjectName;)Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoaderRepository", "()Ljavax/management/loading/ClassLoaderRepository;"));
	}

	[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/MBeanInstantiator;", "private final transient")]
	public Dova.JDK.com.sun.jmx.mbeanserver.MBeanInstantiator instantiator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.MBeanInstantiator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/MBeanServer;", "private transient")]
	public Dova.JDK.javax.management.MBeanServer server_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/MBeanServerDelegate;", "private final transient")]
	public Dova.JDK.javax.management.MBeanServerDelegate @delegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/Repository;", "private final transient")]
	public Dova.JDK.com.sun.jmx.mbeanserver.Repository repository_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.Repository>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/WeakHashMap;", "private final transient")]
	public Dova.JDK.java.util.WeakHashMap listenerWrappers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.WeakHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String domain_Property
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

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set beingUnregistered_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultMBeanServerInterceptor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;Ljavax/management/MBeanServerDelegate;Lcom/sun/jmx/mbeanserver/MBeanInstantiator;Lcom/sun/jmx/mbeanserver/Repository;)V", "public")]
	public DefaultMBeanServerInterceptor(Dova.JDK.javax.management.MBeanServer arg0, Dova.JDK.javax.management.MBeanServerDelegate arg1, Dova.JDK.com.sun.jmx.mbeanserver.MBeanInstantiator arg2, Dova.JDK.com.sun.jmx.mbeanserver.Repository arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, JavaArray<Dova.JDK.java.lang.String> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljava/lang/ClassLoader;", "public")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/DynamicMBean;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object getResource(Dova.JDK.javax.management.DynamicMBean arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Z", "public")]
	public bool isRegistered(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;[Ljava/lang/String;)Ljavax/management/AttributeList;", "public")]
	public Dova.JDK.javax.management.AttributeList getAttributes(Dova.JDK.javax.management.ObjectName arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/DynamicMBean;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getClassName(Dova.JDK.javax.management.DynamicMBean arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/Attribute;)V", "public")]
	public void setAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.Attribute arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "private static")]
	public static void rethrow(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/DynamicMBean;ZZ)V", "private static")]
	public static void postRegister(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.DynamicMBean arg1, bool arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/NotificationListener;", "private")]
	public Dova.JDK.javax.management.NotificationListener getListener(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/DynamicMBean;Ljavax/management/MBeanServer;Ljavax/management/ObjectName;)Ljavax/management/ObjectName;", "private static")]
	public static Dova.JDK.javax.management.ObjectName preRegister(Dova.JDK.javax.management.DynamicMBean arg0, Dova.JDK.javax.management.MBeanServer arg1, Dova.JDK.javax.management.ObjectName arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljavax/management/ObjectName;)V", "private")]
	public void addClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljavax/management/ObjectName;)V", "private")]
	public void removeClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/String;)V", "private static")]
	public static void checkMBeanPermission(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.ObjectName arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/management/DynamicMBean;Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/String;)V", "private static")]
	public static void checkMBeanPermission(Dova.JDK.javax.management.DynamicMBean arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.ObjectName arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/management/DynamicMBean;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String safeGetClassName(Dova.JDK.javax.management.DynamicMBean arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/ObjectName;", "private")]
	public Dova.JDK.javax.management.ObjectName nonDefaultDomain(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static")]
	public static void checkMBeanTrustPermission(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getNewMBeanClassName(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "private")]
	public Dova.JDK.javax.management.ObjectInstance registerObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.management.ObjectName arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "private")]
	public void exclusiveUnregisterMBean(Dova.JDK.javax.management.ObjectName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/DynamicMBean;", "private")]
	public Dova.JDK.javax.management.DynamicMBean getMBean(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.DynamicMBean>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanRegistration;)V", "private static")]
	public static void preDeregisterInvoke(Dova.JDK.javax.management.MBeanRegistration arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/management/DynamicMBean;Ljavax/management/ObjectName;)Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;", "private")]
	public Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext unregisterFromRepository(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.management.DynamicMBean arg1, Dova.JDK.javax.management.ObjectName arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/MBeanRegistration;)V", "private static")]
	public static void postDeregisterInvoke(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.MBeanRegistration arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set queryMBeansImpl(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljavax/management/QueryExp;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set filterListOfObjectInstances(Dova.JDK.java.util.Set arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljavax/management/QueryExp;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set objectInstancesFromFilteredNamedObjects(Dova.JDK.java.util.Set arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set queryNamesImpl(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljavax/management/QueryExp;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set objectNamesFromFilteredNamedObjects(Dova.JDK.java.util.Set arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "private static")]
	public static void rethrowMaybeMBeanException(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/DynamicMBean;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "private")]
	public Dova.JDK.javax.management.ObjectInstance registerDynamicMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.DynamicMBean arg1, Dova.JDK.javax.management.ObjectName arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/management/DynamicMBean;Ljavax/management/ObjectName;)Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;", "private")]
	public Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext registerWithRepository(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.management.DynamicMBean arg1, Dova.JDK.javax.management.ObjectName arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;Ljava/lang/String;)V", "private static")]
	public static void throwMBeanRegistrationException(Dova.JDK.java.lang.Throwable arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/Object;Ljava/lang/Class;)Ljavax/management/NotificationBroadcaster;", "private static")]
	public static Dova.JDK.java.lang.Object getNotificationBroadcaster(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/ObjectName;Ljavax/management/DynamicMBean;Z)Ljavax/management/NotificationListener;", "private")]
	public Dova.JDK.javax.management.NotificationListener getListenerWrapper(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.DynamicMBean arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/management/ObjectName;)Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;", "private")]
	public Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext makeResourceContextFor(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jmx/mbeanserver/ModifiableClassLoaderRepository;", "private")]
	public Dova.JDK.com.sun.jmx.mbeanserver.ModifiableClassLoaderRepository getInstantiatorCLR()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.ModifiableClassLoaderRepository>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljavax/management/ObjectName;)Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;", "private")]
	public Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext createClassLoaderContext(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "public")]
	public void unregisterMBean(Dova.JDK.javax.management.ObjectName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;)Z", "public")]
	public bool isInstanceOf(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set queryNames(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance registerMBean(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;)V", "private")]
	public void sendNotification(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void addNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void addNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;Z)V", "private")]
	public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, JavaArray<Dova.JDK.java.lang.String> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Z[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;", "private")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2, bool arg3, JavaArray<Dova.JDK.java.lang.Object> arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "public")]
	public Dova.JDK.javax.management.ObjectInstance getObjectInstance(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set queryMBeans(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Integer;", "public")]
	public Dova.JDK.java.lang.Integer getMBeanCount()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/AttributeList;)Ljavax/management/AttributeList;", "public")]
	public Dova.JDK.javax.management.AttributeList setAttributes(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.AttributeList arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDefaultDomain()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getDomains()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/MBeanInfo;", "public")]
	public Dova.JDK.javax.management.MBeanInfo getMBeanInfo(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, JavaArray<Dova.JDK.java.lang.String> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljava/lang/ClassLoader;", "public")]
	public Dova.JDK.java.lang.ClassLoader getClassLoaderFor(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/loading/ClassLoaderRepository;", "public")]
	public Dova.JDK.javax.management.loading.ClassLoaderRepository getClassLoaderRepository()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.loading.ClassLoaderRepository>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;", "private abstract static interface")]
	public partial interface ResourceContext
		: IJavaObject
		, Dova.JDK.com.sun.jmx.mbeanserver.Repository.RegistrationContext
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ResourceContext()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "done", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ResourceContext;", "public static final")]
		public static Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.interceptor.DefaultMBeanServerInterceptor.ResourceContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void done()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ListenerWrapper;", "private static")]
	public partial class ListenerWrapper
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.management.NotificationListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ListenerWrapper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ListenerWrapper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listener", "Ljavax/management/NotificationListener;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljavax/management/ObjectName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mbean", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/NotificationListener;Ljavax/management/ObjectName;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleNotification", "(Ljavax/management/Notification;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljavax/management/NotificationListener;", "private")]
		public Dova.JDK.javax.management.NotificationListener listener_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationListener>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/ObjectName;", "private")]
		public Dova.JDK.javax.management.ObjectName name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object mbean_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ListenerWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/ObjectName;Ljava/lang/Object;)V", "")]
		public ListenerWrapper(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.lang.Object arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jmx/interceptor/DefaultMBeanServerInterceptor$ListenerWrapper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/management/Notification;Ljava/lang/Object;)V", "public")]
		public void handleNotification(Dova.JDK.javax.management.Notification arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}
	}
}
