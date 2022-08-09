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

namespace Dova.JDK.java.beans.beancontext;

[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServices;", "public abstract interface")]
public partial interface BeanContextServices
	: IJavaObject
	, Dova.JDK.java.beans.beancontext.BeanContext
	, Dova.JDK.java.beans.beancontext.BeanContextServicesListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BeanContextServices()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServices;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getService", "(Ljava/beans/beancontext/BeanContextChild;Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/Object;Ljava/beans/beancontext/BeanContextServiceRevokedListener;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCurrentServiceSelectors", "(Ljava/lang/Class;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addService", "(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "revokeService", "(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hasService", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "releaseService", "(Ljava/beans/beancontext/BeanContextChild;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCurrentServiceClasses", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addBeanContextServicesListener", "(Ljava/beans/beancontext/BeanContextServicesListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeBeanContextServicesListener", "(Ljava/beans/beancontext/BeanContextServicesListener;)V"));
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextChild;Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/Object;Ljava/beans/beancontext/BeanContextServiceRevokedListener;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getService(Dova.JDK.java.beans.beancontext.BeanContextChild arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedListener arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Iterator;", "public abstract")]
	Dova.JDK.java.util.Iterator getCurrentServiceSelectors(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;)Z", "public abstract")]
	bool addService(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;Z)V", "public abstract")]
	void revokeService(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg1, bool arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool hasService(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextChild;Ljava/lang/Object;Ljava/lang/Object;)V", "public abstract")]
	void releaseService(Dova.JDK.java.beans.beancontext.BeanContextChild arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public abstract")]
	Dova.JDK.java.util.Iterator getCurrentServiceClasses()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServicesListener;)V", "public abstract")]
	void addBeanContextServicesListener(Dova.JDK.java.beans.beancontext.BeanContextServicesListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServicesListener;)V", "public abstract")]
	void removeBeanContextServicesListener(Dova.JDK.java.beans.beancontext.BeanContextServicesListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}
}
