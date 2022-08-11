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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaLangModuleAccess;", "public abstract interface")]
public partial interface JavaLangModuleAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaLangModuleAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaLangModuleAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "packages", "(Ljava/lang/module/ModuleDescriptor$Builder;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAndBind", "(Ljava/lang/module/ModuleFinder;Ljava/util/Collection;Ljava/io/PrintStream;)Ljava/lang/module/Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConfiguration", "(Ljava/lang/module/ModuleFinder;Ljava/util/Map;)Ljava/lang/module/Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requires", "(Ljava/lang/module/ModuleDescriptor$Builder;Ljava/util/Set;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newModuleBuilder", "(Ljava/lang/String;ZLjava/util/Set;)Ljava/lang/module/ModuleDescriptor$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newRequires", "(Ljava/util/Set;Ljava/lang/String;Ljava/lang/module/ModuleDescriptor$Version;)Ljava/lang/module/ModuleDescriptor$Requires;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newExports", "(Ljava/util/Set;Ljava/lang/String;Ljava/util/Set;)Ljava/lang/module/ModuleDescriptor$Exports;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newExports", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/module/ModuleDescriptor$Exports;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOpens", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/module/ModuleDescriptor$Opens;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOpens", "(Ljava/util/Set;Ljava/lang/String;Ljava/util/Set;)Ljava/lang/module/ModuleDescriptor$Opens;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newProvides", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/module/ModuleDescriptor$Provides;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newModuleDescriptor", "(Ljava/lang/String;Ljava/lang/module/ModuleDescriptor$Version;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/lang/String;I)Ljava/lang/module/ModuleDescriptor;"));
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleDescriptor$Builder;)Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set packages(Dova.JDK.java.lang.module.ModuleDescriptor.Builder arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleFinder;Ljava/util/Collection;Ljava/io/PrintStream;)Ljava/lang/module/Configuration;", "public abstract")]
	Dova.JDK.java.lang.module.Configuration resolveAndBind(Dova.JDK.java.lang.module.ModuleFinder arg0, Dova.JDK.java.util.Collection arg1, Dova.JDK.java.io.PrintStream arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.Configuration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleFinder;Ljava/util/Map;)Ljava/lang/module/Configuration;", "public abstract")]
	Dova.JDK.java.lang.module.Configuration newConfiguration(Dova.JDK.java.lang.module.ModuleFinder arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.Configuration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleDescriptor$Builder;Ljava/util/Set;Ljava/lang/String;Ljava/lang/String;)V", "public abstract")]
	void requires(Dova.JDK.java.lang.module.ModuleDescriptor.Builder arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZLjava/util/Set;)Ljava/lang/module/ModuleDescriptor$Builder;", "public abstract")]
	Dova.JDK.java.lang.module.ModuleDescriptor.Builder newModuleBuilder(Dova.JDK.java.lang.String arg0, bool arg1, Dova.JDK.java.util.Set arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;Ljava/lang/module/ModuleDescriptor$Version;)Ljava/lang/module/ModuleDescriptor$Requires;", "public abstract")]
	Dova.JDK.java.lang.module.ModuleDescriptor.Requires newRequires(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.module.ModuleDescriptor.Version arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor.Requires>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;Ljava/util/Set;)Ljava/lang/module/ModuleDescriptor$Exports;", "public abstract")]
	Dova.JDK.java.lang.module.ModuleDescriptor.Exports newExports(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Set arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor.Exports>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/module/ModuleDescriptor$Exports;", "public abstract")]
	Dova.JDK.java.lang.module.ModuleDescriptor.Exports newExports(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor.Exports>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/module/ModuleDescriptor$Opens;", "public abstract")]
	Dova.JDK.java.lang.module.ModuleDescriptor.Opens newOpens(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor.Opens>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;Ljava/util/Set;)Ljava/lang/module/ModuleDescriptor$Opens;", "public abstract")]
	Dova.JDK.java.lang.module.ModuleDescriptor.Opens newOpens(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Set arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor.Opens>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Ljava/lang/module/ModuleDescriptor$Provides;", "public abstract")]
	Dova.JDK.java.lang.module.ModuleDescriptor.Provides newProvides(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor.Provides>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/module/ModuleDescriptor$Version;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Ljava/lang/String;I)Ljava/lang/module/ModuleDescriptor;", "public abstract")]
	Dova.JDK.java.lang.module.ModuleDescriptor newModuleDescriptor(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.module.ModuleDescriptor.Version arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.util.Set arg3, Dova.JDK.java.util.Set arg4, Dova.JDK.java.util.Set arg5, Dova.JDK.java.util.Set arg6, Dova.JDK.java.util.Set arg7, Dova.JDK.java.util.Set arg8, Dova.JDK.java.lang.String arg9, int arg10)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor>(ret);
	}
}
