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
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServicesListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serviceAvailable", "(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V", "public abstract")]
	void serviceAvailable(Dova.JDK.java.beans.beancontext.BeanContextServiceAvailableEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
