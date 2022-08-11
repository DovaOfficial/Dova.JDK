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

namespace Dova.JDK.com.sun.jndi.rmi.registry;

[JniSignatureAttribute("Lcom/sun/jndi/rmi/registry/RegistryContext;", "public")]
public partial class RegistryContext
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.naming.Context
	, Dova.JDK.javax.naming.Referenceable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RegistryContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/rmi/registry/RegistryContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "environment", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registry", "Ljava/rmi/registry/Registry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "host", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "port", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nameParser", "Ljavax/naming/NameParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOCKET_FACTORY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "trustURLCodebase", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reference", "Ljavax/naming/Reference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECURITY_MGR", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/util/Hashtable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/rmi/registry/RegistryContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finalize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReference", "()Ljavax/naming/Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljavax/naming/Name;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljavax/naming/Name;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljavax/naming/Name;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rename", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rename", "(Ljavax/naming/Name;Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addToEnvironment", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubcontext", "(Ljavax/naming/Name;)Ljavax/naming/Context;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubcontext", "(Ljava/lang/String;)Ljavax/naming/Context;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unbind", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unbind", "(Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listBindings", "(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listBindings", "(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroySubcontext", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroySubcontext", "(Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupLink", "(Ljavax/naming/Name;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupLink", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameParser", "(Ljavax/naming/Name;)Ljavax/naming/NameParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameParser", "(Ljava/lang/String;)Ljavax/naming/NameParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "composeName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "composeName", "(Ljavax/naming/Name;Ljavax/naming/Name;)Ljavax/naming/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFromEnvironment", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnvironment", "()Ljava/util/Hashtable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameInNamespace", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "installSecurityMgr", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRegistry", "(Ljava/lang/String;ILjava/rmi/server/RMIClientSocketFactory;)Ljava/rmi/registry/Registry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "wrapRemoteException", "(Ljava/rmi/RemoteException;)Ljavax/naming/NamingException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeObject", "(Ljava/rmi/Remote;Ljavax/naming/Name;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeObject", "(Ljava/lang/Object;Ljavax/naming/Name;)Ljava/rmi/Remote;"));
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable environment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/rmi/registry/Registry;", "private")]
	public Dova.JDK.java.rmi.registry.Registry registry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.registry.Registry>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String host_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int port_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljavax/naming/NameParser;", "private static final")]
	public static Dova.JDK.javax.naming.NameParser nameParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String SOCKET_FACTORY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool trustURLCodebase_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljavax/naming/Reference;", "")]
	public Dova.JDK.javax.naming.Reference reference_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Reference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String SECURITY_MGR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RegistryContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/Hashtable;)V", "public")]
	public RegistryContext(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.Hashtable arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/rmi/registry/RegistryContext;)V", "")]
	public RegistryContext(Dova.JDK.com.sun.jndi.rmi.registry.RegistryContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/rmi/registry/RegistryContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "protected")]
	public void finalize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljavax/naming/Reference;", "public")]
	public Dova.JDK.javax.naming.Reference getReference()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Reference>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration list(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration list(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object lookup(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void rebind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;)V", "public")]
	public void rebind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;)V", "public")]
	public void bind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void bind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void rename(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/Name;)V", "public")]
	public void rename(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.Name arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object addToEnvironment(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/Context;", "public")]
	public Dova.JDK.javax.naming.Context createSubcontext(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Context>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/Context;", "public")]
	public Dova.JDK.javax.naming.Context createSubcontext(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Context>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void unbind(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)V", "public")]
	public void unbind(Dova.JDK.javax.naming.Name arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration listBindings(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration listBindings(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void destroySubcontext(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)V", "public")]
	public void destroySubcontext(Dova.JDK.javax.naming.Name arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object lookupLink(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object lookupLink(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/NameParser;", "public")]
	public Dova.JDK.javax.naming.NameParser getNameParser(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameParser>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/NameParser;", "public")]
	public Dova.JDK.javax.naming.NameParser getNameParser(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameParser>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String composeName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/Name;)Ljavax/naming/Name;", "public")]
	public Dova.JDK.javax.naming.Name composeName(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.Name arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Name>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object removeFromEnvironment(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Hashtable;", "public")]
	public Dova.JDK.java.util.Hashtable getEnvironment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNameInNamespace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void installSecurityMgr()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/rmi/server/RMIClientSocketFactory;)Ljava/rmi/registry/Registry;", "private static")]
	public static Dova.JDK.java.rmi.registry.Registry getRegistry(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.registry.Registry>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/RemoteException;)Ljavax/naming/NamingException;", "public static")]
	public static Dova.JDK.javax.naming.NamingException wrapRemoteException(Dova.JDK.java.rmi.RemoteException arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingException>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;Ljavax/naming/Name;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object decodeObject(Dova.JDK.java.rmi.Remote arg0, Dova.JDK.javax.naming.Name arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/naming/Name;)Ljava/rmi/Remote;", "private")]
	public Dova.JDK.java.rmi.Remote encodeObject(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.naming.Name arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}
}
