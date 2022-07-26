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

[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin;", "public final")]
public partial class StripNativeDebugSymbolsPlugin
	: Dova.JDK.jdk.tools.jlink.@internal.plugins.AbstractPlugin
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StripNativeDebugSymbolsPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_STRIP_CMD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRIP_CMD_ARG", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KEEP_DEBUG_INFO_ARG", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCLUDE_DEBUG_INFO_ARG", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_DEBUG_EXT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRIP_DEBUG_SYMS_OPT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONLY_KEEP_DEBUG_SYMS_OPT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_DEBUG_LINK_OPT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "resourceBundle", "Ljava/util/ResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHARED_LIBS_EXT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmdBuilder", "Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includeDebugSymbols", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stripBin", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debuginfoExt", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Ljdk/tools/jlink/plugin/Plugin$Category;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "logError", "(Ljdk/tools/jlink/plugin/ResourcePoolEntry;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doConfigure", "(ZLjava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateStripArg", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasArguments", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configure", "(Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
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

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String DEFAULT_STRIP_CMD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String STRIP_CMD_ARG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String KEEP_DEBUG_INFO_ARG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String EXCLUDE_DEBUG_INFO_ARG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String DEFAULT_DEBUG_EXT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String STRIP_DEBUG_SYMS_OPT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String ONLY_KEEP_DEBUG_SYMS_OPT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String ADD_DEBUG_LINK_OPT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ResourceBundle;", "private static final")]
	public static Dova.JDK.java.util.ResourceBundle resourceBundle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String SHARED_LIBS_EXT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;", "private final")]
	public Dova.JDK.jdk.tools.jlink.@internal.plugins.StripNativeDebugSymbolsPlugin.ObjCopyCmdBuilder cmdBuilder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.plugins.StripNativeDebugSymbolsPlugin.ObjCopyCmdBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool includeDebugSymbols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String stripBin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String debuginfoExt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StripNativeDebugSymbolsPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public StripNativeDebugSymbolsPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;)V", "public")]
	public StripNativeDebugSymbolsPlugin(Dova.JDK.jdk.tools.jlink.@internal.plugins.StripNativeDebugSymbolsPlugin.ObjCopyCmdBuilder arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin;";
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

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolEntry;Ljava/lang/String;)V", "private")]
	public void logError(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(ZLjava/util/Map;)V", "public")]
	public void doConfigure(bool arg0, Dova.JDK.java.util.Map arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void validateStripArg(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
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

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$DefaultObjCopyCmdBuilder;", "private static final")]
	public partial class DefaultObjCopyCmdBuilder
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.tools.jlink.@internal.plugins.StripNativeDebugSymbolsPlugin.ObjCopyCmdBuilder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultObjCopyCmdBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$DefaultObjCopyCmdBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultObjCopyCmdBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DefaultObjCopyCmdBuilder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$DefaultObjCopyCmdBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "public transient")]
		public Dova.JDK.java.util.List build(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;", "public abstract static interface")]
	public partial interface ObjCopyCmdBuilder
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ObjCopyCmdBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "public abstract transient")]
		Dova.JDK.java.util.List build(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$StrippedDebugInfoBinaryBuilder;", "private static")]
	public partial class StrippedDebugInfoBinaryBuilder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StrippedDebugInfoBinaryBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$StrippedDebugInfoBinaryBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includeDebug", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debugExt", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmdBuilder", "Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strip", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZLjava/lang/String;Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Ljdk/tools/jlink/plugin/ResourcePoolEntry;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addGnuDebugLink", "(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDebugSymbolsFile", "(Ljava/nio/file/Path;Ljava/nio/file/Path;Ljava/lang/String;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteDirRecursivelyIgnoreResult", "(Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripBinary", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createProcessBuilder", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool includeDebug_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String debugExt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;", "private final")]
		public Dova.JDK.jdk.tools.jlink.@internal.plugins.StripNativeDebugSymbolsPlugin.ObjCopyCmdBuilder cmdBuilder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.plugins.StripNativeDebugSymbolsPlugin.ObjCopyCmdBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strip_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StrippedDebugInfoBinaryBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZLjava/lang/String;Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$ObjCopyCmdBuilder;Ljava/lang/String;)V", "private")]
		public StrippedDebugInfoBinaryBuilder(bool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.tools.jlink.@internal.plugins.StripNativeDebugSymbolsPlugin.ObjCopyCmdBuilder arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$StrippedDebugInfoBinaryBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolEntry;)Ljava/util/Optional;", "private")]
		public Dova.JDK.java.util.Optional build(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/String;)Z", "private")]
		public bool addGnuDebugLink(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/Path;Ljava/lang/String;)[B", "private")]
		public JavaArray<byte> createDebugSymbolsFile(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "private")]
		public void deleteDirRecursivelyIgnoreResult(Dova.JDK.java.nio.file.Path arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "private")]
		public bool stripBinary(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/List;)Ljava/lang/ProcessBuilder;", "private")]
		public Dova.JDK.java.lang.ProcessBuilder createProcessBuilder(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$StrippedDebugInfoBinary;", "private static")]
	public partial class StrippedDebugInfoBinary
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StrippedDebugInfoBinary()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$StrippedDebugInfoBinary;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strippedBinary", "Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debugSymbols", "Ljava/util/Optional;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/tools/jlink/plugin/ResourcePoolEntry;Ljava/util/Optional;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "strippedBinary", "()Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debugSymbols", "()Ljava/util/Optional;"));
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "private final")]
		public Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry strippedBinary_Property
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

		[JniSignatureAttribute("Ljava/util/Optional;", "private final")]
		public Dova.JDK.java.util.Optional debugSymbols_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StrippedDebugInfoBinary(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolEntry;Ljava/util/Optional;)V", "private")]
		public StrippedDebugInfoBinary(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg0, Dova.JDK.java.util.Optional arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/StripNativeDebugSymbolsPlugin$StrippedDebugInfoBinary;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public")]
		public Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry strippedBinary()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional debugSymbols()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}
	}
}
