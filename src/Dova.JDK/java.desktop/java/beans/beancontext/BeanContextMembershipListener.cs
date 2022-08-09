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

[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextMembershipListener;", "public abstract interface")]
public partial interface BeanContextMembershipListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BeanContextMembershipListener()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/beans/beancontext/BeanContextMembershipListener;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "childrenAdded", "(Ljava/beans/beancontext/BeanContextMembershipEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "childrenRemoved", "(Ljava/beans/beancontext/BeanContextMembershipEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextMembershipEvent;)V", "public abstract")]
	void childrenAdded(Dova.JDK.java.beans.beancontext.BeanContextMembershipEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextMembershipEvent;)V", "public abstract")]
	void childrenRemoved(Dova.JDK.java.beans.beancontext.BeanContextMembershipEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}