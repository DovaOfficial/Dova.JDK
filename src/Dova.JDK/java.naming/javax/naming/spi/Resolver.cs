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

[JniSignatureAttribute("Ljavax/naming/spi/Resolver;", "public abstract interface")]
public partial interface Resolver
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Resolver()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/naming/spi/Resolver;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resolveToClass", "(Ljavax/naming/Name;Ljava/lang/Class;)Ljavax/naming/spi/ResolveResult;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resolveToClass", "(Ljava/lang/String;Ljava/lang/Class;)Ljavax/naming/spi/ResolveResult;"));
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Class;)Ljavax/naming/spi/ResolveResult;", "public abstract")]
	Dova.JDK.javax.naming.spi.ResolveResult resolveToClass(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.spi.ResolveResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljavax/naming/spi/ResolveResult;", "public abstract")]
	Dova.JDK.javax.naming.spi.ResolveResult resolveToClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.spi.ResolveResult>(ret);
	}
}
