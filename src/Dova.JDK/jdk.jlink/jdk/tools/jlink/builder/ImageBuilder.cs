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

namespace Dova.JDK.jdk.tools.jlink.builder;

[JniSignatureAttribute("Ljdk/tools/jlink/builder/ImageBuilder;", "public abstract interface")]
public partial interface ImageBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImageBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/builder/ImageBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetPlatform", "()Ljdk/tools/jlink/internal/Platform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJImageOutputStream", "()Ljava/io/DataOutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExecutableImage", "()Ljdk/tools/jlink/internal/ExecutableImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeFiles", "(Ljdk/tools/jlink/plugin/ResourcePool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeFiles", "(Ljdk/tools/jlink/plugin/ResourcePool;Ljava/util/Properties;)V"));
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/internal/Platform;", "public")]
	Dova.JDK.jdk.tools.jlink.@internal.Platform getTargetPlatform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/DataOutputStream;", "public abstract")]
	Dova.JDK.java.io.DataOutputStream getJImageOutputStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.DataOutputStream>(ret);
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/internal/ExecutableImage;", "public abstract")]
	Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage getExecutableImage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage>(ret);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;)V", "public")]
	void storeFiles(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;Ljava/util/Properties;)V", "public")]
	void storeFiles(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0, Dova.JDK.java.util.Properties arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}
}
