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

namespace Dova.JDK.jdk.tools.jlink.plugin;

[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolBuilder;", "public abstract interface")]
public partial interface ResourcePoolBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ResourcePoolBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/plugin/ResourcePoolBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljdk/tools/jlink/plugin/ResourcePoolEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljdk/tools/jlink/plugin/ResourcePool;"));
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolEntry;)V", "public abstract")]
	void add(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/ResourcePool;", "public abstract")]
	Dova.JDK.jdk.tools.jlink.plugin.ResourcePool build()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePool>(ret);
	}
}
