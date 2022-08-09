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

namespace Dova.JDK.javax.management.remote.rmi;

[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnectorServer;", "public")]
public partial class RMIConnectorServer
	: Dova.JDK.javax.management.remote.JMXConnectorServer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RMIConnectorServer()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/management/remote/rmi/RMIConnectorServer;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JNDI_REBIND_ATTRIBUTE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RMI_SERVER_SOCKET_FACTORY_ATTRIBUTE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CREDENTIALS_FILTER_PATTERN", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SERIAL_FILTER_PATTERN", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "intToAlpha", "[C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "logger", "Lcom/sun/jmx/remote/util/ClassLogger;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "address", "Ljavax/management/remote/JMXServiceURL;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rmiServerImpl", "Ljavax/management/remote/rmi/RMIServerImpl;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "attributes", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "defaultClassLoader", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "boundJndiUrl", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CREATED", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "STARTED", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "STOPPED", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "state", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "openedServers", "Ljava/util/Set;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RMIConnectorServer", "(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;Ljavax/management/remote/rmi/RMIServerImpl;Ljavax/management/MBeanServer;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RMIConnectorServer", "(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;Ljavax/management/MBeanServer;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RMIConnectorServer", "(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "start", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "stop", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAddress", "()Ljavax/management/remote/JMXServiceURL;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAttributes", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isActive", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "bind", "(Ljava/lang/String;Ljava/util/Hashtable;Ljavax/management/remote/rmi/RMIServer;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newServer", "()Ljavax/management/remote/rmi/RMIServerImpl;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "objectToBind", "(Ljavax/management/remote/rmi/RMIServerImpl;Ljava/util/Map;)Ljavax/management/remote/rmi/RMIServer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "encodeStubInAddress", "(Ljavax/management/remote/rmi/RMIServer;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newJRMPServer", "(Ljava/util/Map;I)Ljavax/management/remote/rmi/RMIServerImpl;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "encodeStub", "(Ljavax/management/remote/rmi/RMIServer;Ljava/util/Map;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "encodeJRMPStub", "(Ljavax/management/remote/rmi/RMIServer;Ljava/util/Map;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setMBeanServerForwarder", "(Ljavax/management/remote/MBeanServerForwarder;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toJMXConnector", "(Ljava/util/Map;)Ljavax/management/remote/JMXConnector;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "connectionOpened", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "connectionFailed", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "connectionClosed", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newIOException", "(Ljava/lang/String;Ljava/lang/Throwable;)Ljava/io/IOException;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "byteArrayToBase64", "([B)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String JNDI_REBIND_ATTRIBUTE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String RMI_SERVER_SOCKET_FACTORY_ATTRIBUTE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String CREDENTIALS_FILTER_PATTERN_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String SERIAL_FILTER_PATTERN_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[C", "private static final")]
	public static JavaArray<char> intToAlpha_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/util/ClassLogger;", "private static")]
	public static Dova.JDK.com.sun.jmx.remote.util.ClassLogger logger_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.util.ClassLogger>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/management/remote/JMXServiceURL;", "private")]
	public Dova.JDK.javax.management.remote.JMXServiceURL address_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.JMXServiceURL>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIServerImpl;", "private")]
	public Dova.JDK.javax.management.remote.rmi.RMIServerImpl rmiServerImpl_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServerImpl>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map attributes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private")]
	public Dova.JDK.java.lang.ClassLoader defaultClassLoader_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String boundJndiUrl_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CREATED_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STARTED_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STOPPED_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int state_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
	public static Dova.JDK.java.util.Set openedServers_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RMIConnectorServer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;Ljavax/management/remote/rmi/RMIServerImpl;Ljavax/management/MBeanServer;)V", "public")]
	public RMIConnectorServer(Dova.JDK.javax.management.remote.JMXServiceURL arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.javax.management.remote.rmi.RMIServerImpl arg2, Dova.JDK.javax.management.MBeanServer arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;Ljavax/management/MBeanServer;)V", "public")]
	public RMIConnectorServer(Dova.JDK.javax.management.remote.JMXServiceURL arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.javax.management.MBeanServer arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)V", "public")]
	public RMIConnectorServer(Dova.JDK.javax.management.remote.JMXServiceURL arg0, Dova.JDK.java.util.Map arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIConnectorServer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public synchronized")]
	public void start()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void stop()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Ljavax/management/remote/JMXServiceURL;", "public")]
	public Dova.JDK.javax.management.remote.JMXServiceURL getAddress()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.JMXServiceURL>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getAttributes()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool isActive()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Hashtable;Ljavax/management/remote/rmi/RMIServer;Z)V", "")]
	public void bind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Hashtable arg1, Dova.JDK.javax.management.remote.rmi.RMIServer arg2, bool arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljavax/management/remote/rmi/RMIServerImpl;", "")]
	public Dova.JDK.javax.management.remote.rmi.RMIServerImpl newServer()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServerImpl>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIServerImpl;Ljava/util/Map;)Ljavax/management/remote/rmi/RMIServer;", "private static")]
	public static Dova.JDK.javax.management.remote.rmi.RMIServer objectToBind(Dova.JDK.javax.management.remote.rmi.RMIServerImpl arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIServer;Ljava/util/Map;)V", "private")]
	public void encodeStubInAddress(Dova.JDK.javax.management.remote.rmi.RMIServer arg0, Dova.JDK.java.util.Map arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Map;I)Ljavax/management/remote/rmi/RMIServerImpl;", "private static")]
	public static Dova.JDK.javax.management.remote.rmi.RMIServerImpl newJRMPServer(Dova.JDK.java.util.Map arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIServerImpl>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIServer;Ljava/util/Map;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String encodeStub(Dova.JDK.javax.management.remote.rmi.RMIServer arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIServer;Ljava/util/Map;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String encodeJRMPStub(Dova.JDK.javax.management.remote.rmi.RMIServer arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/MBeanServerForwarder;)V", "public synchronized")]
	public void setMBeanServerForwarder(Dova.JDK.javax.management.remote.MBeanServerForwarder arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljavax/management/remote/JMXConnector;", "public")]
	public Dova.JDK.javax.management.remote.JMXConnector toJMXConnector(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.JMXConnector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "protected")]
	public void connectionOpened(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "protected")]
	public void connectionFailed(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "protected")]
	public void connectionClosed(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)Ljava/io/IOException;", "private static")]
	public static Dova.JDK.java.io.IOException newIOException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String byteArrayToBase64(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}