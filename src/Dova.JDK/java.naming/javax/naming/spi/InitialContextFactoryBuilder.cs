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

namespace Dova.JDK.javax.naming.spi;

[JniSignatureAttribute("Ljavax/naming/spi/InitialContextFactoryBuilder;", "public abstract interface")]
public partial interface InitialContextFactoryBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InitialContextFactoryBuilder()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/naming/spi/InitialContextFactoryBuilder;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createInitialContextFactory", "(Ljava/util/Hashtable;)Ljavax/naming/spi/InitialContextFactory;"));
	}

	[JniSignatureAttribute("(Ljava/util/Hashtable;)Ljavax/naming/spi/InitialContextFactory;", "public abstract")]
	Dova.JDK.javax.naming.spi.InitialContextFactory createInitialContextFactory(Dova.JDK.java.util.Hashtable arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.spi.InitialContextFactory>(ret);
	}
}
