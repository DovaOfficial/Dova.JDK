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

[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin;", "public final")]
public partial class DefaultStripDebugPlugin
	: Dova.JDK.jdk.tools.jlink.@internal.plugins.AbstractPlugin
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultStripDebugPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRIP_NATIVE_DEBUG_PLUGIN", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCLUDE_DEBUGINFO", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javaStripPlugin", "Ljdk/tools/jlink/plugin/Plugin;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stripNativePluginFactory", "Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$NativePluginFactory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/tools/jlink/plugin/Plugin;Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$NativePluginFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String STRIP_NATIVE_DEBUG_PLUGIN_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String EXCLUDE_DEBUGINFO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin;", "private final")]
	public Dova.JDK.jdk.tools.jlink.plugin.Plugin javaStripPlugin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$NativePluginFactory;", "private final")]
	public Dova.JDK.jdk.tools.jlink.@internal.plugins.DefaultStripDebugPlugin.NativePluginFactory stripNativePluginFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.plugins.DefaultStripDebugPlugin.NativePluginFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultStripDebugPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultStripDebugPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/Plugin;Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$NativePluginFactory;)V", "public")]
	public DefaultStripDebugPlugin(Dova.JDK.jdk.tools.jlink.plugin.Plugin arg0, Dova.JDK.jdk.tools.jlink.@internal.plugins.DefaultStripDebugPlugin.NativePluginFactory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;", "public")]
	public Dova.JDK.jdk.tools.jlink.plugin.ResourcePool transform(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolBuilder arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePool>(ret);
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$DefaultNativePluginFactory;", "private static")]
	public partial class DefaultNativePluginFactory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.tools.jlink.@internal.plugins.DefaultStripDebugPlugin.NativePluginFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultNativePluginFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$DefaultNativePluginFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "()Ljdk/tools/jlink/plugin/Plugin;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultNativePluginFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DefaultNativePluginFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$DefaultNativePluginFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/Plugin;", "public")]
		public Dova.JDK.jdk.tools.jlink.plugin.Plugin create()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$NativePluginFactory;", "public abstract static interface")]
	public partial interface NativePluginFactory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NativePluginFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/DefaultStripDebugPlugin$NativePluginFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "()Ljdk/tools/jlink/plugin/Plugin;"));
		}

		[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/Plugin;", "public abstract")]
		Dova.JDK.jdk.tools.jlink.plugin.Plugin create()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin>(ret);
		}
	}
}
