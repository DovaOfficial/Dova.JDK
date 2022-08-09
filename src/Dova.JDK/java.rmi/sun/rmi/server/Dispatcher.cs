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

namespace Dova.JDK.sun.rmi.server;

[JniSignatureAttribute("Lsun/rmi/server/Dispatcher;", "public abstract interface")]
public partial interface Dispatcher
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Dispatcher()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/rmi/server/Dispatcher;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispatch", "(Ljava/rmi/Remote;Ljava/rmi/server/RemoteCall;)V"));
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;Ljava/rmi/server/RemoteCall;)V", "public abstract")]
	void dispatch(Dova.JDK.java.rmi.Remote arg0, Dova.JDK.java.rmi.server.RemoteCall arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}