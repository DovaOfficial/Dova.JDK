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

namespace Dova.JDK.jdk.@internal.module;

[JniSignatureAttribute("Ljdk/internal/module/ExplodedSystemModules;", "")]
public partial class ExplodedSystemModules
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.module.SystemModules
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExplodedSystemModules()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/module/ExplodedSystemModules;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSplitPackages", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasIncubatorModules", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleReads", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleDescriptors", "()[Ljava/lang/module/ModuleDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleTargets", "()[Ljdk/internal/module/ModuleTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleHashes", "()[Ljdk/internal/module/ModuleHashes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleResolutions", "()[Ljdk/internal/module/ModuleResolution;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExplodedSystemModules(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public ExplodedSystemModules() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/module/ExplodedSystemModules;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool hasSplitPackages()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasIncubatorModules()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map moduleReads()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/module/ModuleDescriptor;", "public")]
	public JavaArray<Dova.JDK.java.lang.module.ModuleDescriptor> moduleDescriptors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.module.ModuleDescriptor>>(ret);
	}

	[JniSignatureAttribute("()[Ljdk/internal/module/ModuleTarget;", "public")]
	public JavaArray<Dova.JDK.jdk.@internal.module.ModuleTarget> moduleTargets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.module.ModuleTarget>>(ret);
	}

	[JniSignatureAttribute("()[Ljdk/internal/module/ModuleHashes;", "public")]
	public JavaArray<Dova.JDK.jdk.@internal.module.ModuleHashes> moduleHashes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.module.ModuleHashes>>(ret);
	}

	[JniSignatureAttribute("()[Ljdk/internal/module/ModuleResolution;", "public")]
	public JavaArray<Dova.JDK.jdk.@internal.module.ModuleResolution> moduleResolutions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.module.ModuleResolution>>(ret);
	}
}
