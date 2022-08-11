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

namespace Dova.JDK.java.lang.module;

[JniSignatureAttribute("Ljava/lang/module/ModuleFinder;", "public abstract interface")]
public partial interface ModuleFinder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModuleFinder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/module/ModuleFinder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "([Ljava/nio/file/Path;)Ljava/lang/module/ModuleFinder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compose", "([Ljava/lang/module/ModuleFinder;)Ljava/lang/module/ModuleFinder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSystem", "()Ljava/lang/module/ModuleFinder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAll", "()Ljava/util/Set;"));
	}

	[JniSignatureAttribute("([Ljava/nio/file/Path;)Ljava/lang/module/ModuleFinder;", "public static transient")]
	static Dova.JDK.java.lang.module.ModuleFinder of(JavaArray<Dova.JDK.java.nio.file.Path> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleFinder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public abstract")]
	Dova.JDK.java.util.Optional find(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/module/ModuleFinder;)Ljava/lang/module/ModuleFinder;", "public static transient")]
	static Dova.JDK.java.lang.module.ModuleFinder compose(JavaArray<Dova.JDK.java.lang.module.ModuleFinder> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleFinder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/module/ModuleFinder;", "public static")]
	static Dova.JDK.java.lang.module.ModuleFinder ofSystem()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleFinder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set findAll()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}
}
