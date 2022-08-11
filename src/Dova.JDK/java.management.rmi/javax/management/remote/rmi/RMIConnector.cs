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

[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector;", "public")]
public partial class RMIConnector
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.management.remote.JMXConnector
	, Dova.JDK.java.io.Serializable
	, Dova.JDK.javax.management.remote.JMXAddressable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RMIConnector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "logger", "Lcom/sun/jmx/remote/util/ClassLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "rmiServerImplStubClassName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "rmiServerImplStubClass", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "rmiConnectionImplStubClassName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "rmiConnectionImplStubClass", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "pRefClassName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "proxyRefConstructor", "Ljava/lang/reflect/Constructor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "base64ToInt", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmiServer", "Ljavax/management/remote/rmi/RMIServer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jmxServiceURL", "Ljavax/management/remote/JMXServiceURL;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultClassLoader", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connection", "Ljavax/management/remote/rmi/RMIConnection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectionId", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientNotifSeqNo", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmbscMap", "Ljava/util/WeakHashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nullSubjectConnRef", "Ljava/lang/ref/WeakReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmiNotifClient", "Ljavax/management/remote/rmi/RMIConnector$RMINotifClient;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientNotifCounter", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connected", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminated", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closeException", "Ljava/lang/Exception;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectionBroadcaster", "Ljavax/management/NotificationBroadcasterSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "communicatorAdmin", "Lcom/sun/jmx/remote/internal/ClientCommunicatorAdmin;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "orb", "Ljava/lang/ref/WeakReference;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/remote/rmi/RMIServer;Ljava/util/Map;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/remote/rmi/RMIServer;Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAddress", "()Ljavax/management/remote/JMXServiceURL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "strings", "([Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConnection", "(Ljavax/management/remote/rmi/RMIServer;Ljava/lang/Object;Z)Ljavax/management/remote/rmi/RMIConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectionId", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkStub", "(Ljava/rmi/Remote;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNotification", "(Ljavax/management/Notification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initTransients", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findRMIServer", "(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)Ljavax/management/remote/rmi/RMIServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectionWithSubject", "(Ljavax/security/auth/Subject;)Ljavax/management/MBeanServerConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addListenerWithSubject", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;Z)Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addListenersWithSubjects", "([Ljavax/management/ObjectName;[Ljava/rmi/MarshalledObject;[Ljavax/security/auth/Subject;Z)[Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushDefaultClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popDefaultClassLoader", "(Ljava/lang/ClassLoader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findRMIServerJNDI", "(Ljava/lang/String;Ljava/util/Map;)Ljavax/management/remote/rmi/RMIServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findRMIServerJRMP", "(Ljava/lang/String;Ljava/util/Map;)Ljavax/management/remote/rmi/RMIServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "narrowJRMPServer", "(Ljava/lang/Object;)Ljavax/management/remote/rmi/RMIServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "shadowJrmpStub", "(Ljava/rmi/server/RemoteObject;)Ljavax/management/remote/rmi/RMIConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConnectionNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeConnectionNotificationListener", "(Ljavax/management/NotificationListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeConnectionNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "packageOf", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAttributesNames", "(Ljavax/management/AttributeList;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanServerConnection", "(Ljavax/security/auth/Subject;)Ljavax/management/MBeanServerConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanServerConnection", "()Ljavax/management/MBeanServerConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "base64ToByteArray", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "base64toInt", "(C)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "objects", "([Ljava/lang/Object;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/util/ClassLogger;", "private static final")]
	public static Dova.JDK.com.sun.jmx.remote.util.ClassLogger logger_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.util.ClassLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String rmiServerImplStubClassName_Property
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

	[JniSignatureAttribute("Ljava/lang/Class;", "private static final")]
	public static Dova.JDK.java.lang.Class rmiServerImplStubClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String rmiConnectionImplStubClassName_Property
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

	[JniSignatureAttribute("Ljava/lang/Class;", "private static final")]
	public static Dova.JDK.java.lang.Class rmiConnectionImplStubClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String pRefClassName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Constructor proxyRefConstructor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> base64ToInt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIServer;", "private final")]
	public Dova.JDK.javax.management.remote.rmi.RMIServer rmiServer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/JMXServiceURL;", "private final")]
	public Dova.JDK.javax.management.remote.JMXServiceURL jmxServiceURL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.JMXServiceURL>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private transient")]
	public Dova.JDK.java.util.Map env_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private transient")]
	public Dova.JDK.java.lang.ClassLoader defaultClassLoader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnection;", "private transient")]
	public Dova.JDK.javax.management.remote.rmi.RMIConnection connection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private transient")]
	public Dova.JDK.java.lang.String connectionId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private transient")]
	public long clientNotifSeqNo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/WeakHashMap;", "private transient")]
	public Dova.JDK.java.util.WeakHashMap rmbscMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.WeakHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/WeakReference;", "private transient")]
	public Dova.JDK.java.lang.@ref.WeakReference nullSubjectConnRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.WeakReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector$RMINotifClient;", "private transient")]
	public Dova.JDK.javax.management.remote.rmi.RMIConnector.RMINotifClient rmiNotifClient_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnector.RMINotifClient>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private transient")]
	public long clientNotifCounter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool connected_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool terminated_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Exception;", "private transient")]
	public Dova.JDK.java.lang.Exception closeException_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/NotificationBroadcasterSupport;", "private transient")]
	public Dova.JDK.javax.management.NotificationBroadcasterSupport connectionBroadcaster_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationBroadcasterSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ClientCommunicatorAdmin;", "private transient")]
	public Dova.JDK.com.sun.jmx.remote.@internal.ClientCommunicatorAdmin communicatorAdmin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.@internal.ClientCommunicatorAdmin>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/WeakReference;", "private static volatile")]
	public static Dova.JDK.java.lang.@ref.WeakReference orb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.WeakReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RMIConnector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIServer;Ljava/util/Map;)V", "public")]
	public RMIConnector(Dova.JDK.javax.management.remote.rmi.RMIServer arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)V", "public")]
	public RMIConnector(Dova.JDK.javax.management.remote.JMXServiceURL arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIServer;Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)V", "private")]
	public RMIConnector(Dova.JDK.javax.management.remote.rmi.RMIServer arg0, Dova.JDK.javax.management.remote.JMXServiceURL arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIConnector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void connect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public synchronized")]
	public void connect(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Z)V", "private synchronized")]
	public void close(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()Ljavax/management/remote/JMXServiceURL;", "public")]
	public Dova.JDK.javax.management.remote.JMXServiceURL getAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.JMXServiceURL>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String strings(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIServer;Ljava/lang/Object;Z)Ljavax/management/remote/rmi/RMIConnection;", "private static")]
	public static Dova.JDK.javax.management.remote.rmi.RMIConnection getConnection(Dova.JDK.javax.management.remote.rmi.RMIServer arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnection>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public synchronized")]
	public Dova.JDK.java.lang.String getConnectionId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;Ljava/lang/Class;)V", "private static")]
	public static void checkStub(Dova.JDK.java.rmi.Remote arg0, Dova.JDK.java.lang.Class arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/Notification;)V", "private")]
	public void sendNotification(Dova.JDK.javax.management.Notification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initTransients()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)Ljavax/management/remote/rmi/RMIServer;", "private")]
	public Dova.JDK.javax.management.remote.rmi.RMIServer findRMIServer(Dova.JDK.javax.management.remote.JMXServiceURL arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)Ljavax/management/MBeanServerConnection;", "private")]
	public Dova.JDK.javax.management.MBeanServerConnection getConnectionWithSubject(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerConnection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;Z)Ljava/lang/Integer;", "private")]
	public Dova.JDK.java.lang.Integer addListenerWithSubject(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.rmi.MarshalledObject arg1, Dova.JDK.javax.security.auth.Subject arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
	}

	[JniSignatureAttribute("([Ljavax/management/ObjectName;[Ljava/rmi/MarshalledObject;[Ljavax/security/auth/Subject;Z)[Ljava/lang/Integer;", "private")]
	public JavaArray<Dova.JDK.java.lang.Integer> addListenersWithSubjects(JavaArray<Dova.JDK.javax.management.ObjectName> arg0, JavaArray<Dova.JDK.java.rmi.MarshalledObject> arg1, JavaArray<Dova.JDK.javax.security.auth.Subject> arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Integer>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "private")]
	public Dova.JDK.java.lang.ClassLoader pushDefaultClassLoader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "private")]
	public void popDefaultClassLoader(Dova.JDK.java.lang.ClassLoader arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljavax/management/remote/rmi/RMIServer;", "private")]
	public Dova.JDK.javax.management.remote.rmi.RMIServer findRMIServerJNDI(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljavax/management/remote/rmi/RMIServer;", "private")]
	public Dova.JDK.javax.management.remote.rmi.RMIServer findRMIServerJRMP(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/management/remote/rmi/RMIServer;", "private static")]
	public static Dova.JDK.javax.management.remote.rmi.RMIServer narrowJRMPServer(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/server/RemoteObject;)Ljavax/management/remote/rmi/RMIConnection;", "private static")]
	public static Dova.JDK.javax.management.remote.rmi.RMIConnection shadowJrmpStub(Dova.JDK.java.rmi.server.RemoteObject arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void addConnectionNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;)V", "public")]
	public void removeConnectionNotificationListener(Dova.JDK.javax.management.NotificationListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
	public void removeConnectionNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String packageOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/AttributeList;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getAttributesNames(Dova.JDK.javax.management.AttributeList arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)Ljavax/management/MBeanServerConnection;", "public synchronized")]
	public Dova.JDK.javax.management.MBeanServerConnection getMBeanServerConnection(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerConnection>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/MBeanServerConnection;", "public synchronized")]
	public Dova.JDK.javax.management.MBeanServerConnection getMBeanServerConnection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "private static")]
	public static JavaArray<byte> base64ToByteArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(C)I", "private static")]
	public static int base64toInt(char arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String objects(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector$RMINotifClient;", "private")]
	public partial class RMINotifClient
		: Dova.JDK.com.sun.jmx.remote.@internal.ClientNotifForwarder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RMINotifClient()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnector$RMINotifClient;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/management/remote/rmi/RMIConnector;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/remote/rmi/RMIConnector;Ljava/lang/ClassLoader;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rethrowDeserializationException", "(Ljava/io/IOException;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addListenerForMBeanRemovedNotif", "()Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeListenerForMBeanRemovedNotif", "(Ljava/lang/Integer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lostNotifs", "(Ljava/lang/String;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fetchNotifs", "(JIJ)Ljavax/management/remote/NotificationResult;"));
		}

		[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector;", "final")]
		public Dova.JDK.javax.management.remote.rmi.RMIConnector this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RMINotifClient(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIConnector;Ljava/lang/ClassLoader;Ljava/util/Map;)V", "public")]
		public RMINotifClient(Dova.JDK.javax.management.remote.rmi.RMIConnector arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIConnector$RMINotifClient;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/io/IOException;)V", "private")]
		public void rethrowDeserializationException(Dova.JDK.java.io.IOException arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Integer;", "protected")]
		public Dova.JDK.java.lang.Integer addListenerForMBeanRemovedNotif()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Integer;)V", "protected")]
		public void removeListenerForMBeanRemovedNotif(Dova.JDK.java.lang.Integer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;J)V", "protected")]
		public void lostNotifs(Dova.JDK.java.lang.String arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(JIJ)Ljavax/management/remote/NotificationResult;", "protected")]
		public Dova.JDK.javax.management.remote.NotificationResult fetchNotifs(long arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.NotificationResult>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector$RMIClientCommunicatorAdmin;", "private")]
	public partial class RMIClientCommunicatorAdmin
		: Dova.JDK.com.sun.jmx.remote.@internal.ClientCommunicatorAdmin
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RMIClientCommunicatorAdmin()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnector$RMIClientCommunicatorAdmin;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/management/remote/rmi/RMIConnector;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/remote/rmi/RMIConnector;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doStart", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkConnection", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reconnectNotificationListeners", "([Lcom/sun/jmx/remote/internal/ClientListenerInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "gotIOException", "(Ljava/io/IOException;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doStop", "()V"));
		}

		[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector;", "final")]
		public Dova.JDK.javax.management.remote.rmi.RMIConnector this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RMIClientCommunicatorAdmin(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIConnector;J)V", "public")]
		public RMIClientCommunicatorAdmin(Dova.JDK.javax.management.remote.rmi.RMIConnector arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIConnector$RMIClientCommunicatorAdmin;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void doStart()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void checkConnection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("([Lcom/sun/jmx/remote/internal/ClientListenerInfo;)V", "public")]
		public void reconnectNotificationListeners(JavaArray<Dova.JDK.com.sun.jmx.remote.@internal.ClientListenerInfo> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/io/IOException;)V", "public")]
		public void gotIOException(Dova.JDK.java.io.IOException arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void doStop()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector$Util;", "static final")]
	public partial class Util
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Util()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnector$Util;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Util(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Util() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIConnector$Util;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public static")]
		public static Dova.JDK.java.lang.Object cast(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector$ObjectInputStreamWithLoader;", "private static final")]
	public partial class ObjectInputStreamWithLoader
		: Dova.JDK.java.io.ObjectInputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ObjectInputStreamWithLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnector$ObjectInputStreamWithLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loader", "Ljava/lang/ClassLoader;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;Ljava/lang/ClassLoader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveClass", "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
		public Dova.JDK.java.lang.ClassLoader loader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ObjectInputStreamWithLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/ClassLoader;)V", "")]
		public ObjectInputStreamWithLoader(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.ClassLoader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIConnector$ObjectInputStreamWithLoader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;", "protected")]
		public Dova.JDK.java.lang.Class resolveClass(Dova.JDK.java.io.ObjectStreamClass arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector$RemoteMBeanServerConnection;", "private")]
	public partial class RemoteMBeanServerConnection
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.management.MBeanServerConnection
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RemoteMBeanServerConnection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnector$RemoteMBeanServerConnection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegationSubject", "Ljavax/security/auth/Subject;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/management/remote/rmi/RMIConnector;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/remote/rmi/RMIConnector;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/remote/rmi/RMIConnector;Ljavax/security/auth/Subject;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljavax/management/ObjectName;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRegistered", "(Ljavax/management/ObjectName;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljavax/management/ObjectName;[Ljava/lang/String;)Ljavax/management/AttributeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttribute", "(Ljavax/management/ObjectName;Ljavax/management/Attribute;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljavax/management/ObjectName;Ljava/lang/String;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterMBean", "(Ljavax/management/ObjectName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectInstance", "(Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryMBeans", "(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryNames", "(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanCount", "()Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultDomain", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDomains", "()[Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanInfo", "(Ljavax/management/ObjectName;)Ljavax/management/MBeanInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstanceOf", "(Ljavax/management/ObjectName;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributes", "(Ljavax/management/ObjectName;Ljavax/management/AttributeList;)Ljavax/management/AttributeList;"));
		}

		[JniSignatureAttribute("Ljavax/security/auth/Subject;", "private")]
		public Dova.JDK.javax.security.auth.Subject delegationSubject_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.Subject>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnector;", "final")]
		public Dova.JDK.javax.management.remote.rmi.RMIConnector this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RemoteMBeanServerConnection(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIConnector;)V", "public")]
		public RemoteMBeanServerConnection(Dova.JDK.javax.management.remote.rmi.RMIConnector arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIConnector;Ljavax/security/auth/Subject;)V", "public")]
		public RemoteMBeanServerConnection(Dova.JDK.javax.management.remote.rmi.RMIConnector arg0, Dova.JDK.javax.security.auth.Subject arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIConnector$RemoteMBeanServerConnection;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object invoke(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, JavaArray<Dova.JDK.java.lang.String> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;)Z", "public")]
		public bool isRegistered(Dova.JDK.javax.management.ObjectName arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;[Ljava/lang/String;)Ljavax/management/AttributeList;", "public")]
		public Dova.JDK.javax.management.AttributeList getAttributes(Dova.JDK.javax.management.ObjectName arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/Attribute;)V", "public")]
		public void setAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.Attribute arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getAttribute(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;", "public")]
		public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, JavaArray<Dova.JDK.java.lang.String> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "public")]
		public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "public")]
		public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;)Ljavax/management/ObjectInstance;", "public")]
		public Dova.JDK.javax.management.ObjectInstance createMBean(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.ObjectName arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "public")]
		public void unregisterMBean(Dova.JDK.javax.management.ObjectName arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/ObjectInstance;", "public")]
		public Dova.JDK.javax.management.ObjectInstance getObjectInstance(Dova.JDK.javax.management.ObjectName arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectInstance>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set queryMBeans(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.QueryExp arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set queryNames(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.QueryExp arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer getMBeanCount()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getDefaultDomain()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
		public JavaArray<Dova.JDK.java.lang.String> getDomains()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljavax/management/MBeanInfo;", "public")]
		public Dova.JDK.javax.management.MBeanInfo getMBeanInfo(Dova.JDK.javax.management.ObjectName arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanInfo>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
		public void addNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
		public void addNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
		public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public")]
		public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;)V", "public")]
		public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/ObjectName;)V", "public")]
		public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.ObjectName arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljava/lang/String;)Z", "public")]
		public bool isInstanceOf(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/AttributeList;)Ljavax/management/AttributeList;", "public")]
		public Dova.JDK.javax.management.AttributeList setAttributes(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.AttributeList arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeList>(ret);
		}
	}
}
