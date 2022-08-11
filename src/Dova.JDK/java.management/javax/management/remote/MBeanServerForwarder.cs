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

namespace Dova.JDK.javax.management.remote;

[JniSignatureAttribute("Ljavax/management/remote/MBeanServerForwarder;", "public abstract interface")]
public partial interface MBeanServerForwarder
	: IJavaObject
	, Dova.JDK.javax.management.MBeanServer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MBeanServerForwarder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/remote/MBeanServerForwarder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanServer", "()Ljavax/management/MBeanServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMBeanServer", "(Ljavax/management/MBeanServer;)V"));
	}

	[JniSignatureAttribute("()Ljavax/management/MBeanServer;", "public abstract")]
	Dova.JDK.javax.management.MBeanServer getMBeanServer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)V", "public abstract")]
	void setMBeanServer(Dova.JDK.javax.management.MBeanServer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
