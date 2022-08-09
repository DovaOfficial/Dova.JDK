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

namespace Dova.JDK.jdk.jpackage.@internal;

[JniSignatureAttribute("Ljdk/jpackage/internal/Bundlers;", "public abstract interface")]
public partial interface Bundlers
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Bundlers()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jpackage/internal/Bundlers;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "loadBundlersFromServices", "(Ljava/lang/ClassLoader;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createBundlersInstance", "()Ljdk/jpackage/internal/Bundlers;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createBundlersInstance", "(Ljava/lang/ClassLoader;)Ljdk/jpackage/internal/Bundlers;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBundlers", "(Ljava/lang/String;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBundlers", "()Ljava/util/Collection;"));
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "public abstract")]
	void loadBundlersFromServices(Dova.JDK.java.lang.ClassLoader arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/Bundlers;", "public static")]
	static Dova.JDK.jdk.jpackage.@internal.Bundlers createBundlersInstance()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.Bundlers>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Ljdk/jpackage/internal/Bundlers;", "public static")]
	static Dova.JDK.jdk.jpackage.@internal.Bundlers createBundlersInstance(Dova.JDK.java.lang.ClassLoader arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.Bundlers>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Collection;", "public abstract")]
	Dova.JDK.java.util.Collection getBundlers(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "public abstract")]
	Dova.JDK.java.util.Collection getBundlers()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}
}