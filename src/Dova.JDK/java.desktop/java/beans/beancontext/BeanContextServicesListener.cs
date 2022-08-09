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

[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesListener;", "public abstract interface")]
public partial interface BeanContextServicesListener
	: IJavaObject
	, Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BeanContextServicesListener()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServicesListener;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "serviceAvailable", "(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V", "public abstract")]
	void serviceAvailable(Dova.JDK.java.beans.beancontext.BeanContextServiceAvailableEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
