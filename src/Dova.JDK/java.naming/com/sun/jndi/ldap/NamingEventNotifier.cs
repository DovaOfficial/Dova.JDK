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

namespace Dova.JDK.com.sun.jndi.ldap;

[JniSignatureAttribute("Lcom/sun/jndi/ldap/NamingEventNotifier;", "final")]
public partial class NamingEventNotifier
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Runnable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NamingEventNotifier()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/ldap/NamingEventNotifier;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "namingListeners", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "worker", "Ljava/lang/Thread;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Lcom/sun/jndi/ldap/LdapCtx;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eventSrc", "Ljavax/naming/event/EventContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "support", "Lcom/sun/jndi/ldap/EventSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "results", "Ljavax/naming/NamingEnumeration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "info", "Lcom/sun/jndi/ldap/NotifierArgs;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/ldap/EventSupport;Lcom/sun/jndi/ldap/LdapCtx;Lcom/sun/jndi/ldap/NotifierArgs;Ljavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNamingListener", "(Ljavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNamingListener", "(Ljavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNamingListeners", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireObjectAdded", "(Ljavax/naming/Binding;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireObjectRemoved", "(Ljavax/naming/Binding;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireObjectChanged", "(Ljavax/naming/Binding;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireObjectRenamed", "(Ljavax/naming/Binding;Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireNamingException", "(Ljavax/naming/NamingException;)V"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector namingListeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Thread;", "private")]
	public Dova.JDK.java.lang.Thread worker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/LdapCtx;", "private")]
	public Dova.JDK.com.sun.jndi.ldap.LdapCtx context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapCtx>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/naming/event/EventContext;", "private")]
	public Dova.JDK.javax.naming.@event.EventContext eventSrc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.@event.EventContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/EventSupport;", "private")]
	public Dova.JDK.com.sun.jndi.ldap.EventSupport support_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.EventSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/naming/NamingEnumeration;", "private")]
	public Dova.JDK.javax.naming.NamingEnumeration results_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/NotifierArgs;", "")]
	public Dova.JDK.com.sun.jndi.ldap.NotifierArgs info_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.NotifierArgs>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NamingEventNotifier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/EventSupport;Lcom/sun/jndi/ldap/LdapCtx;Lcom/sun/jndi/ldap/NotifierArgs;Ljavax/naming/event/NamingListener;)V", "")]
	public NamingEventNotifier(Dova.JDK.com.sun.jndi.ldap.EventSupport arg0, Dova.JDK.com.sun.jndi.ldap.LdapCtx arg1, Dova.JDK.com.sun.jndi.ldap.NotifierArgs arg2, Dova.JDK.javax.naming.@event.NamingListener arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/ldap/NamingEventNotifier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void run()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "")]
	public void stop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void cleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljavax/naming/event/NamingListener;)V", "")]
	public void addNamingListener(Dova.JDK.javax.naming.@event.NamingListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/event/NamingListener;)V", "")]
	public void removeNamingListener(Dova.JDK.javax.naming.@event.NamingListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool hasNamingListeners()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/naming/Binding;J)V", "private")]
	public void fireObjectAdded(Dova.JDK.javax.naming.Binding arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Binding;J)V", "private")]
	public void fireObjectRemoved(Dova.JDK.javax.naming.Binding arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Binding;J)V", "private")]
	public void fireObjectChanged(Dova.JDK.javax.naming.Binding arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Binding;Ljava/lang/String;J)V", "private")]
	public void fireObjectRenamed(Dova.JDK.javax.naming.Binding arg0, Dova.JDK.java.lang.String arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/NamingException;)V", "private")]
	public void fireNamingException(Dova.JDK.javax.naming.NamingException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}
}
