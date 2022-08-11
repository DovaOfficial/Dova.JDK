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

[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin;", "public final")]
public partial class OrderResourcesPlugin
	: Dova.JDK.jdk.tools.jlink.@internal.plugins.AbstractPlugin
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OrderResourcesPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JRT_FILE_SYSTEM", "Ljava/nio/file/FileSystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filters", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "orderedPaths", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin$SortWrapper;Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin$SortWrapper;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Ljdk/tools/jlink/plugin/Plugin$Category;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrdinal", "(Ljdk/tools/jlink/plugin/ResourcePoolEntry;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripModule", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasArguments", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configure", "(Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("Ljava/nio/file/FileSystem;", "private static final")]
	public static Dova.JDK.java.nio.file.FileSystem JRT_FILE_SYSTEM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List filters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map orderedPaths_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OrderResourcesPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public OrderResourcesPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin$SortWrapper;Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin$SortWrapper;)I", "private static")]
	public static int compare(Dova.JDK.jdk.tools.jlink.@internal.plugins.OrderResourcesPlugin.SortWrapper arg0, Dova.JDK.jdk.tools.jlink.@internal.plugins.OrderResourcesPlugin.SortWrapper arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;", "public")]
	public Dova.JDK.jdk.tools.jlink.plugin.ResourcePool transform(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolBuilder arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePool>(ret);
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/Plugin$Category;", "public")]
	public Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolEntry;)I", "private")]
	public int getOrdinal(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String stripModule(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasArguments()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
	public void configure(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin$SortWrapper;", "static")]
	public partial class SortWrapper
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SortWrapper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin$SortWrapper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resource", "Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ordinal", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/tools/jlink/plugin/ResourcePoolEntry;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResource", "()Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrdinal", "()I"));
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "private final")]
		public Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry resource_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int ordinal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SortWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolEntry;I)V", "")]
		public SortWrapper(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/OrderResourcesPlugin$SortWrapper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "")]
		public Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry getResource()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getPath()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "")]
		public int getOrdinal()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}
}
