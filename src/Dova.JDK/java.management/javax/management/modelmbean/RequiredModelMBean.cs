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

[JniSignatureAttribute("Ljavax/management/modelmbean/RequiredModelMBean;", "public")]
public partial class RequiredModelMBean
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.management.modelmbean.ModelMBean
	, Dova.JDK.javax.management.MBeanRegistration
	, Dova.JDK.javax.management.NotificationEmitter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RequiredModelMBean()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/modelmbean/RequiredModelMBean;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modelMBeanInfo", "Ljavax/management/modelmbean/ModelMBeanInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generalBroadcaster", "Ljavax/management/NotificationBroadcasterSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeBroadcaster", "Ljavax/management/NotificationBroadcasterSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "managedResource", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registered", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "server", "Ljavax/management/MBeanServer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaSecurityAccess", "Ljdk/internal/access/JavaSecurityAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveClasses", "[Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveClassMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "rmmbMethodNames", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveTypes", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveWrappers", "[Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/modelmbean/ModelMBeanInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "([Ljava/lang/String;)Ljavax/management/AttributeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttribute", "(Ljavax/management/Attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanInfo", "()Ljavax/management/MBeanInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/NotificationListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeMethod", "(Ljava/lang/String;Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preRegister", "(Ljavax/management/MBeanServer;Ljavax/management/ObjectName;)Ljavax/management/ObjectName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotificationInfo", "()[Ljavax/management/MBeanNotificationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNotification", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNotification", "(Ljavax/management/Notification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultModelMBeanInfo", "()Ljavax/management/modelmbean/ModelMBeanInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printModelMBeanInfo", "(Ljavax/management/modelmbean/ModelMBeanInfo;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveForCacheValue", "(Ljavax/management/Descriptor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findRMMBMethod", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isRMMBMethodName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeToLog", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasNotification", "(Ljavax/management/modelmbean/ModelMBeanInfo;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeGenericInfo", "()Ljavax/management/modelmbean/ModelMBeanNotificationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeAttributeChangeInfo", "()Ljavax/management/modelmbean/ModelMBeanNotificationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setModelMBeanInfo", "(Ljavax/management/modelmbean/ModelMBeanInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setManagedResource", "(Ljava/lang/Object;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendAttributeChangeNotification", "(Ljavax/management/AttributeChangeNotification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendAttributeChangeNotification", "(Ljavax/management/Attribute;Ljavax/management/Attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttributeChangeNotificationListener", "(Ljavax/management/NotificationListener;Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAttributeChangeNotificationListener", "(Ljavax/management/NotificationListener;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheResult", "(Ljavax/management/modelmbean/ModelMBeanOperationInfo;Ljavax/management/Descriptor;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postRegister", "(Ljava/lang/Boolean;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preDeregister", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postDeregister", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoaderRepository", "()Ljavax/management/loading/ClassLoaderRepository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributes", "(Ljavax/management/AttributeList;)Ljavax/management/AttributeList;"));
	}

	[JniSignatureAttribute("Ljavax/management/modelmbean/ModelMBeanInfo;", "")]
	public Dova.JDK.javax.management.modelmbean.ModelMBeanInfo modelMBeanInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.modelmbean.ModelMBeanInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/NotificationBroadcasterSupport;", "private")]
	public Dova.JDK.javax.management.NotificationBroadcasterSupport generalBroadcaster_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationBroadcasterSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/NotificationBroadcasterSupport;", "private")]
	public Dova.JDK.javax.management.NotificationBroadcasterSupport attributeBroadcaster_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationBroadcasterSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object managedResource_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool registered_Property
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

	[JniSignatureAttribute("Ljavax/management/MBeanServer;", "private transient")]
	public Dova.JDK.javax.management.MBeanServer server_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaSecurityAccess;", "private static final")]
	public static Dova.JDK.jdk.@internal.access.JavaSecurityAccess javaSecurityAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecurityAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private final")]
	public Dova.JDK.java.security.AccessControlContext acc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Class;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.Class> primitiveClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map primitiveClassMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private static")]
	public static Dova.JDK.java.util.Set rmmbMethodNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> primitiveTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> primitiveWrappers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RequiredModelMBean(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public RequiredModelMBean() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljavax/management/modelmbean/ModelMBeanInfo;)V", "public")]
	public RequiredModelMBean(Dova.JDK.javax.management.modelmbean.ModelMBeanInfo arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/modelmbean/RequiredModelMBean;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "private")]
	public Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void load()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void store()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljavax/management/AttributeList;", "public")]
	public Dova.JDK.javax.management.AttributeList getAttributes(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/Attribute;)V", "public")]
	public void setAttribute(Dova.JDK.javax.management.Attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getAttribute(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/MBeanInfo;", "public")]
	public Dova.JDK.javax.management.MBeanInfo getMBeanInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void addNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;)V", "public")]
	public void removeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object invokeMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.Object arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;Ljavax/management/ObjectName;)Ljavax/management/ObjectName;", "public")]
	public Dova.JDK.javax.management.ObjectName preRegister(Dova.JDK.javax.management.MBeanServer arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/reflect/Method;", "private")]
	public Dova.JDK.java.lang.reflect.Method resolveMethod(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/management/MBeanNotificationInfo;", "public")]
	public JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> getNotificationInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void sendNotification(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/Notification;)V", "public")]
	public void sendNotification(Dova.JDK.javax.management.Notification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Ljavax/management/modelmbean/ModelMBeanInfo;", "private")]
	public Dova.JDK.javax.management.modelmbean.ModelMBeanInfo createDefaultModelMBeanInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.modelmbean.ModelMBeanInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/modelmbean/ModelMBeanInfo;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String printModelMBeanInfo(Dova.JDK.javax.management.modelmbean.ModelMBeanInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/Descriptor;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object resolveForCacheValue(Dova.JDK.javax.management.Descriptor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/reflect/Method;", "private")]
	public Dova.JDK.java.lang.reflect.Method findRMMBMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.String> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static synchronized")]
	public static bool isRMMBMethodName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "private synchronized")]
	public void writeToLog(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/modelmbean/ModelMBeanInfo;Ljava/lang/String;)Z", "private static final")]
	public static bool hasNotification(Dova.JDK.javax.management.modelmbean.ModelMBeanInfo arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/management/modelmbean/ModelMBeanNotificationInfo;", "private static final")]
	public static Dova.JDK.javax.management.modelmbean.ModelMBeanNotificationInfo makeGenericInfo()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.modelmbean.ModelMBeanNotificationInfo>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/modelmbean/ModelMBeanNotificationInfo;", "private static final")]
	public static Dova.JDK.javax.management.modelmbean.ModelMBeanNotificationInfo makeAttributeChangeInfo()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.modelmbean.ModelMBeanNotificationInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/modelmbean/ModelMBeanInfo;)V", "public")]
	public void setModelMBeanInfo(Dova.JDK.javax.management.modelmbean.ModelMBeanInfo arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)V", "public")]
	public void setManagedResource(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/AttributeChangeNotification;)V", "public")]
	public void sendAttributeChangeNotification(Dova.JDK.javax.management.AttributeChangeNotification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/Attribute;Ljavax/management/Attribute;)V", "public")]
	public void sendAttributeChangeNotification(Dova.JDK.javax.management.Attribute arg0, Dova.JDK.javax.management.Attribute arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void addAttributeChangeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljava/lang/String;)V", "public")]
	public void removeAttributeChangeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/modelmbean/ModelMBeanOperationInfo;Ljavax/management/Descriptor;Ljava/lang/Object;)V", "private")]
	public void cacheResult(Dova.JDK.javax.management.modelmbean.ModelMBeanOperationInfo arg0, Dova.JDK.javax.management.Descriptor arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Boolean;)V", "public")]
	public void postRegister(Dova.JDK.java.lang.Boolean arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void preDeregister()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void postDeregister()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35]);
	}

	[JniSignatureAttribute("()Ljavax/management/loading/ClassLoaderRepository;", "protected")]
	public Dova.JDK.javax.management.loading.ClassLoaderRepository getClassLoaderRepository()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.loading.ClassLoaderRepository>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/AttributeList;)Ljavax/management/AttributeList;", "public")]
	public Dova.JDK.javax.management.AttributeList setAttributes(Dova.JDK.javax.management.AttributeList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
	}
}
