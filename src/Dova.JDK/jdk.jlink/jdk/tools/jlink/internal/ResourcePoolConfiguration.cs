/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.tools.jlink.@internal;

[JniSignatureAttribute("Ljdk/tools/jlink/internal/ResourcePoolConfiguration;", "final")]
public partial class ResourcePoolConfiguration
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ResourcePoolConfiguration()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/ResourcePoolConfiguration;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ResourcePoolConfiguration", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "validate", "(Ljdk/tools/jlink/plugin/ResourcePool;)Ljava/lang/module/Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "moduleReference", "(Ljava/lang/module/ModuleDescriptor;)Ljava/lang/module/ModuleReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkPackages", "(Ljdk/tools/jlink/plugin/ResourcePool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "descriptorOf", "(Ljdk/tools/jlink/plugin/ResourcePoolModule;)Ljava/lang/module/ModuleDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "allModRefs", "(Ljdk/tools/jlink/plugin/ResourcePool;)Ljava/util/Map;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ResourcePoolConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ResourcePoolConfiguration() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/ResourcePoolConfiguration;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;)Ljava/lang/module/Configuration;", "static")]
	public static Dova.JDK.java.lang.module.Configuration validate(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.Configuration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleDescriptor;)Ljava/lang/module/ModuleReference;", "private static")]
	public static Dova.JDK.java.lang.module.ModuleReference moduleReference(Dova.JDK.java.lang.module.ModuleDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleReference>(ret);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;)V", "private static")]
	public static void checkPackages(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolModule;)Ljava/lang/module/ModuleDescriptor;", "private static")]
	public static Dova.JDK.java.lang.module.ModuleDescriptor descriptorOf(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolModule arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;)Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map allModRefs(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}
}
