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

namespace Dova.JDK.java.rmi.server;

[JniSignatureAttribute("Ljava/rmi/server/Skeleton;", "public abstract interface")]
public partial interface Skeleton
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Skeleton()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/rmi/server/Skeleton;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispatch", "(Ljava/rmi/Remote;Ljava/rmi/server/RemoteCall;IJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOperations", "()[Ljava/rmi/server/Operation;"));
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;Ljava/rmi/server/RemoteCall;IJ)V", "public abstract")]
	void dispatch(Dova.JDK.java.rmi.Remote arg0, Dova.JDK.java.rmi.server.RemoteCall arg1, int arg2, long arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()[Ljava/rmi/server/Operation;", "public abstract")]
	JavaArray<Dova.JDK.java.rmi.server.Operation> getOperations()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.rmi.server.Operation>>(ret);
	}
}
