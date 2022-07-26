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

[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StringSharingPlugin;", "public")]
public partial class StringSharingPlugin
	: Dova.JDK.jdk.tools.jlink.@internal.plugins.AbstractPlugin
	, Dova.JDK.jdk.tools.jlink.@internal.ResourcePrevisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StringSharingPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/StringSharingPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZES", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "predicate", "Ljava/util/function/Predicate;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Predicate;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;)Ljdk/tools/jlink/plugin/ResourcePool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Ljdk/tools/jlink/plugin/Plugin$Category;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previsit", "(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/internal/StringTable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasArguments", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configure", "(Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> SIZES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private")]
	public Dova.JDK.java.util.function.Predicate predicate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StringSharingPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public StringSharingPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)V", "")]
	public StringSharingPlugin(Dova.JDK.java.util.function.Predicate arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/StringSharingPlugin;";
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

	[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePool;Ljdk/tools/jlink/internal/StringTable;)V", "public")]
	public void previsit(Dova.JDK.jdk.tools.jlink.plugin.ResourcePool arg0, Dova.JDK.jdk.tools.jlink.@internal.StringTable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasArguments()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
	public void configure(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StringSharingPlugin$CompactCPHelper;", "private static final")]
	public partial class CompactCPHelper
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompactCPHelper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/StringSharingPlugin$CompactCPHelper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/tools/jlink/plugin/ResourcePoolEntry;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;Ljdk/tools/jlink/internal/StringTable;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "optimize", "(Ljdk/tools/jlink/plugin/ResourcePoolEntry;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;Ljdk/tools/jlink/internal/StringTable;Ljava/util/Set;[B)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeDescriptorReference", "(Ljava/io/DataOutputStream;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeUTF8Reference", "(Ljava/io/DataOutputStream;I)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompactCPHelper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CompactCPHelper() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/StringSharingPlugin$CompactCPHelper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolEntry;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;Ljdk/tools/jlink/internal/StringTable;)[B", "public")]
		public JavaArray<byte> transform(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolBuilder arg1, Dova.JDK.jdk.tools.jlink.@internal.StringTable arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljdk/tools/jlink/plugin/ResourcePoolEntry;Ljdk/tools/jlink/plugin/ResourcePoolBuilder;Ljdk/tools/jlink/internal/StringTable;Ljava/util/Set;[B)[B", "private")]
		public JavaArray<byte> optimize(Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolBuilder arg1, Dova.JDK.jdk.tools.jlink.@internal.StringTable arg2, Dova.JDK.java.util.Set arg3, JavaArray<byte> arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/DataOutputStream;Ljava/util/List;)V", "private")]
		public void writeDescriptorReference(Dova.JDK.java.io.DataOutputStream arg0, Dova.JDK.java.util.List arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/io/DataOutputStream;I)V", "private")]
		public void writeUTF8Reference(Dova.JDK.java.io.DataOutputStream arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/plugins/StringSharingPlugin$CompactCPHelper$DescriptorsScanner;", "private static final")]
		public partial class DescriptorsScanner
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DescriptorsScanner()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/plugins/StringSharingPlugin$CompactCPHelper$DescriptorsScanner;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cf", "Lcom/sun/tools/classfile/ClassFile;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/classfile/ClassFile;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "()Ljava/util/Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanConstantPool", "(Ljava/util/Set;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanFields", "(Ljava/util/Set;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanMethods", "(Ljava/util/Set;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanAnnotation", "(Lcom/sun/tools/classfile/Annotation;Ljava/util/Set;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanElementValue", "(Lcom/sun/tools/classfile/Annotation$element_value;Ljava/util/Set;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanAttributes", "(Lcom/sun/tools/classfile/Attributes;Ljava/util/Set;)V"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassFile;", "private final")]
			public Dova.JDK.com.sun.tools.classfile.ClassFile cf_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DescriptorsScanner(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)V", "private")]
			public DescriptorsScanner(Dova.JDK.com.sun.tools.classfile.ClassFile arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/plugins/StringSharingPlugin$CompactCPHelper$DescriptorsScanner;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Set;", "private")]
			public Dova.JDK.java.util.Set scan()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Set;)V", "private")]
			public void scanConstantPool(Dova.JDK.java.util.Set arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/Set;)V", "private")]
			public void scanFields(Dova.JDK.java.util.Set arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/Set;)V", "private")]
			public void scanMethods(Dova.JDK.java.util.Set arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation;Ljava/util/Set;)V", "private")]
			public void scanAnnotation(Dova.JDK.com.sun.tools.classfile.Annotation arg0, Dova.JDK.java.util.Set arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$element_value;Ljava/util/Set;)V", "private")]
			public void scanElementValue(Dova.JDK.com.sun.tools.classfile.Annotation.element_value arg0, Dova.JDK.java.util.Set arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attributes;Ljava/util/Set;)V", "private")]
			public void scanAttributes(Dova.JDK.com.sun.tools.classfile.Attributes arg0, Dova.JDK.java.util.Set arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			}
		}
	}
}
