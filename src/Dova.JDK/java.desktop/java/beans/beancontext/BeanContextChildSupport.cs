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

namespace Dova.JDK.java.beans.beancontext;

[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextChildSupport;", "public")]
public partial class BeanContextChildSupport
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.beans.beancontext.BeanContextChild
	, Dova.JDK.java.beans.beancontext.BeanContextServicesListener
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BeanContextChildSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContextChildSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "beanContextChildPeer", "Ljava/beans/beancontext/BeanContextChild;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pcSupport", "Ljava/beans/PropertyChangeSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vcSupport", "Ljava/beans/VetoableChangeSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "beanContext", "Ljava/beans/beancontext/BeanContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rejectedSetBCOnce", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextChild;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBeanContext", "(Ljava/beans/beancontext/BeanContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBeanContext", "()Ljava/beans/beancontext/BeanContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validatePendingSetBeanContext", "(Ljava/beans/beancontext/BeanContext;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseBeanContextResources", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeBeanContextResources", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serviceRevoked", "(Ljava/beans/beancontext/BeanContextServiceRevokedEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serviceAvailable", "(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBeanContextChildPeer", "()Ljava/beans/beancontext/BeanContextChild;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDelegated", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireVetoableChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVetoableChangeListener", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeVetoableChangeListener", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V"));
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

	[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextChild;", "public")]
	public Dova.JDK.java.beans.beancontext.BeanContextChild beanContextChildPeer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextChild>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeSupport;", "protected")]
	public Dova.JDK.java.beans.PropertyChangeSupport pcSupport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/VetoableChangeSupport;", "protected")]
	public Dova.JDK.java.beans.VetoableChangeSupport vcSupport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.VetoableChangeSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/beancontext/BeanContext;", "protected transient")]
	public Dova.JDK.java.beans.beancontext.BeanContext beanContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected transient")]
	public bool rejectedSetBCOnce_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BeanContextChildSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BeanContextChildSupport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextChild;)V", "public")]
	public BeanContextChildSupport(Dova.JDK.java.beans.beancontext.BeanContextChild arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/beans/beancontext/BeanContextChildSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContext;)V", "public synchronized")]
	public void setBeanContext(Dova.JDK.java.beans.beancontext.BeanContext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljava/beans/beancontext/BeanContext;", "public synchronized")]
	public Dova.JDK.java.beans.beancontext.BeanContext getBeanContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContext;)Z", "public")]
	public bool validatePendingSetBeanContext(Dova.JDK.java.beans.beancontext.BeanContext arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void releaseBeanContextResources()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void initializeBeanContextResources()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceRevokedEvent;)V", "public")]
	public void serviceRevoked(Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V", "public")]
	public void serviceAvailable(Dova.JDK.java.beans.beancontext.BeanContextServiceAvailableEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Ljava/beans/beancontext/BeanContextChild;", "public")]
	public Dova.JDK.java.beans.beancontext.BeanContextChild getBeanContextChildPeer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextChild>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDelegated()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
	public void firePropertyChange(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void addPropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void removePropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
	public void fireVetoableChange(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V", "public")]
	public void addVetoableChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V", "public")]
	public void removeVetoableChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}
}
