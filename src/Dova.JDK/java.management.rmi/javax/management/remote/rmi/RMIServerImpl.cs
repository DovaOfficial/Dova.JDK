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

[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIServerImpl;", "public abstract")]
public partial class RMIServerImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Closeable
	, Dova.JDK.javax.management.remote.rmi.RMIServer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RMIServerImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/rmi/RMIServerImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "logger", "Lcom/sun/jmx/remote/util/ClassLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientList", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cl", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mbeanServer", "Ljavax/management/MBeanServer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connServer", "Ljavax/management/remote/rmi/RMIConnectorServer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "connectionIdNumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notifBuffer", "Lcom/sun/jmx/remote/internal/NotificationBuffer;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProtocol", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "export", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVersion", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doNewClient", "(Ljava/lang/Object;)Ljavax/management/remote/rmi/RMIConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newClient", "(Ljava/lang/Object;)Ljavax/management/remote/rmi/RMIConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeConnectionId", "(Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeClient", "(Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/remote/rmi/RMIConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropDeadReferences", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeClient", "(Ljavax/management/remote/rmi/RMIConnection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeServer", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRMIConnectorServer", "(Ljavax/management/remote/rmi/RMIConnectorServer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultClassLoader", "(Ljava/lang/ClassLoader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStub", "()Ljava/rmi/Remote;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanServer", "()Ljavax/management/MBeanServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotifBuffer", "()Lcom/sun/jmx/remote/internal/NotificationBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clientClosed", "(Ljavax/management/remote/rmi/RMIConnection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMBeanServer", "(Ljavax/management/MBeanServer;)V"));
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

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List clientList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private")]
	public Dova.JDK.java.lang.ClassLoader cl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/MBeanServer;", "private")]
	public Dova.JDK.javax.management.MBeanServer mbeanServer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map env_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/remote/rmi/RMIConnectorServer;", "private")]
	public Dova.JDK.javax.management.remote.rmi.RMIConnectorServer connServer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnectorServer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int connectionIdNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/NotificationBuffer;", "private")]
	public Dova.JDK.com.sun.jmx.remote.@internal.NotificationBuffer notifBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.@internal.NotificationBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RMIServerImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
	public RMIServerImpl(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/remote/rmi/RMIServerImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public synchronized")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected abstract")]
	public Dova.JDK.java.lang.String getProtocol()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void export()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/management/remote/rmi/RMIConnection;", "")]
	public Dova.JDK.javax.management.remote.rmi.RMIConnection doNewClient(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/management/remote/rmi/RMIConnection;", "public")]
	public Dova.JDK.javax.management.remote.rmi.RMIConnection newClient(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/String;", "private static synchronized")]
	public static Dova.JDK.java.lang.String makeConnectionId(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/remote/rmi/RMIConnection;", "protected abstract")]
	public Dova.JDK.javax.management.remote.rmi.RMIConnection makeClient(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.security.auth.Subject arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.rmi.RMIConnection>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void dropDeadReferences()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIConnection;)V", "protected abstract")]
	public void closeClient(Dova.JDK.javax.management.remote.rmi.RMIConnection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void closeServer()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIConnectorServer;)V", "")]
	public void setRMIConnectorServer(Dova.JDK.javax.management.remote.rmi.RMIConnectorServer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "public synchronized")]
	public void setDefaultClassLoader(Dova.JDK.java.lang.ClassLoader arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public synchronized")]
	public Dova.JDK.java.lang.ClassLoader getDefaultClassLoader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()Ljava/rmi/Remote;", "public abstract")]
	public Dova.JDK.java.rmi.Remote toStub()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/MBeanServer;", "public synchronized")]
	public Dova.JDK.javax.management.MBeanServer getMBeanServer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jmx/remote/internal/NotificationBuffer;", "synchronized")]
	public Dova.JDK.com.sun.jmx.remote.@internal.NotificationBuffer getNotifBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.@internal.NotificationBuffer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/remote/rmi/RMIConnection;)V", "protected")]
	public void clientClosed(Dova.JDK.javax.management.remote.rmi.RMIConnection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)V", "public synchronized")]
	public void setMBeanServer(Dova.JDK.javax.management.MBeanServer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}
}
