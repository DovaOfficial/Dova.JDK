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

namespace Dova.JDK.jdk.tools.jlink.@internal.plugins;

[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/CDSPlugin;", "public final")]
public partial class CDSPlugin
	: Dova.JDK.jdk.tools.jlink.@internal.plugins.AbstractPlugin
	, Dova.JDK.jdk.tools.jlink.@internal.PostProcessor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CDSPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/CDSPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetPlatform", "Ljdk/tools/jlink/internal/Platform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "runtimePlatform", "Ljdk/tools/jlink/internal/Platform;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Ljdk/tools/jlink/plugin/Plugin$Category;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "process", "(Ljdk/tools/jlink/internal/ExecutableImage;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "javaExecutableName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateCDSArchive", "(Ljdk/tools/jlink/internal/ExecutableImage;Z)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform;", "private")]
	public Dova.JDK.jdk.tools.jlink.@internal.Platform targetPlatform_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform;", "private")]
	public Dova.JDK.jdk.tools.jlink.@internal.Platform runtimePlatform_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CDSPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CDSPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/CDSPlugin;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;", "public")]
	public Dova.JDK.jdk.tools.jlink.plugin.ResourcePool transform(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolBuilder arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePool>(ret);
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/Plugin$Category;", "public")]
	public Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/internal/ExecutableImage;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List process(Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String javaExecutableName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/internal/ExecutableImage;Z)V", "private")]
	public void generateCDSArchive(Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}
}
