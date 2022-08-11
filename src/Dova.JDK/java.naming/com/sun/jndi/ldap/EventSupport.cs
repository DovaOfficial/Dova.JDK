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

[JniSignatureAttribute("Lcom/sun/jndi/ldap/EventSupport;", "final")]
public partial class EventSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/ldap/EventSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctx", "Lcom/sun/jndi/ldap/LdapCtx;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notifiers", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unsolicited", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eventQueue", "Lcom/sun/jndi/ldap/EventQueue;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/ldap/LdapCtx;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNamingListener", "(Ljava/lang/String;ILjavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNamingListener", "(Ljava/lang/String;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNamingListener", "(Ljavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queueEvent", "(Ljava/util/EventObject;Ljava/util/Vector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasUnsolicited", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDeadNotifier", "(Lcom/sun/jndi/ldap/NotifierArgs;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireUnsolicited", "(Ljava/lang/Object;)V"));
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

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/LdapCtx;", "private")]
	public Dova.JDK.com.sun.jndi.ldap.LdapCtx ctx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapCtx>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable notifiers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector unsolicited_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/EventQueue;", "private")]
	public Dova.JDK.com.sun.jndi.ldap.EventQueue eventQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.EventQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EventSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapCtx;)V", "")]
	public EventSupport(Dova.JDK.com.sun.jndi.ldap.LdapCtx arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/ldap/EventSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "synchronized")]
	public void cleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjavax/naming/event/NamingListener;)V", "synchronized")]
	public void addNamingListener(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.javax.naming.@event.NamingListener arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V", "synchronized")]
	public void addNamingListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2, Dova.JDK.javax.naming.@event.NamingListener arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/event/NamingListener;)V", "synchronized")]
	public void removeNamingListener(Dova.JDK.javax.naming.@event.NamingListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EventObject;Ljava/util/Vector;)V", "synchronized")]
	public void queueEvent(Dova.JDK.java.util.EventObject arg0, Dova.JDK.java.util.Vector arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "synchronized")]
	public bool hasUnsolicited()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/NotifierArgs;)V", "synchronized")]
	public void removeDeadNotifier(Dova.JDK.com.sun.jndi.ldap.NotifierArgs arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "synchronized")]
	public void fireUnsolicited(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}
}
