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

[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin;", "public abstract interface")]
public partial interface Plugin
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Plugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/plugin/Plugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getState", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Ljdk/tools/jlink/plugin/Plugin$Category;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUsage", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasArguments", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasRawArgument", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgumentsDescription", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStateDescription", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configure", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOption", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;", "public abstract")]
	Dova.JDK.jdk.tools.jlink.plugin.ResourcePool transform(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolBuilder arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePool>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	Dova.JDK.java.util.Set getState()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/Plugin$Category;", "public")]
	Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String getDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String getUsage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	bool hasArguments()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	bool hasRawArgument()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String getArgumentsDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String getStateDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
	void configure(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String getOption()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
	public partial class Category
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Category()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/plugin/Plugin$Category;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILTER", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADDER", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSFORMER", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULEINFO_TRANSFORMER", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SORTER", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METAINFO_ADDER", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPRESSOR", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERIFIER", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROCESSOR", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGER", "Ljdk/tools/jlink/plugin/Plugin$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/tools/jlink/plugin/Plugin$Category;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/tools/jlink/plugin/Plugin$Category;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/tools/jlink/plugin/Plugin$Category;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/tools/jlink/plugin/Plugin$Category;"));
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category FILTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category ADDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category TRANSFORMER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category MODULEINFO_TRANSFORMER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category SORTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category METAINFO_ADDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category COMPRESSOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category VERIFIER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category PROCESSOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$Category;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category PACKAGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/tools/jlink/plugin/Plugin$Category;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Category(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public Category(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/plugin/Plugin$Category;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/tools/jlink/plugin/Plugin$Category;", "public static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/tools/jlink/plugin/Plugin$Category;", "public static")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/tools/jlink/plugin/Plugin$Category;", "private static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.Category>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$State;", "public static final")]
	public partial class State
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static State()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/plugin/Plugin$State;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISABLED", "Ljdk/tools/jlink/plugin/Plugin$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTO_ENABLED", "Ljdk/tools/jlink/plugin/Plugin$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FUNCTIONAL", "Ljdk/tools/jlink/plugin/Plugin$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/tools/jlink/plugin/Plugin$State;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/tools/jlink/plugin/Plugin$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/tools/jlink/plugin/Plugin$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/tools/jlink/plugin/Plugin$State;"));
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$State;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.State DISABLED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$State;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.State AUTO_ENABLED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/Plugin$State;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.State FUNCTIONAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/tools/jlink/plugin/Plugin$State;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public State(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public State(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/plugin/Plugin$State;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/tools/jlink/plugin/Plugin$State;", "public static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/tools/jlink/plugin/Plugin$State;", "public static")]
		public static Dova.JDK.jdk.tools.jlink.plugin.Plugin.State valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/tools/jlink/plugin/Plugin$State;", "private static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.Plugin.State>>(ret);
		}
	}
}
