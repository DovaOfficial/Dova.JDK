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

namespace Dova.JDK.java.rmi.registry;

[JniSignatureAttribute("Ljava/rmi/registry/RegistryHandler;", "public abstract interface")]
public partial interface RegistryHandler
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RegistryHandler()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/rmi/registry/RegistryHandler;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "registryImpl", "(I)Ljava/rmi/registry/Registry;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "registryStub", "(Ljava/lang/String;I)Ljava/rmi/registry/Registry;"));
	}

	[JniSignatureAttribute("(I)Ljava/rmi/registry/Registry;", "public abstract")]
	Dova.JDK.java.rmi.registry.Registry registryImpl(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.registry.Registry>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/rmi/registry/Registry;", "public abstract")]
	Dova.JDK.java.rmi.registry.Registry registryStub(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.registry.Registry>(ret);
	}
}
