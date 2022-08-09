/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.javadoc.doclet;

[JniSignatureAttribute("Ljdk/javadoc/doclet/DocletEnvironment;", "public abstract interface")]
public partial interface DocletEnvironment
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocletEnvironment()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/javadoc/doclet/DocletEnvironment;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isIncluded", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSpecifiedElements", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getIncludedElements", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getModuleMode", "()Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFileKind", "(Ljavax/lang/model/element/TypeElement;)Ljavax/tools/JavaFileObject$Kind;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDocTrees", "()Lcom/sun/source/util/DocTrees;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTypeUtils", "()Ljavax/lang/model/util/Types;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getJavaFileManager", "()Ljavax/tools/JavaFileManager;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSourceVersion", "()Ljavax/lang/model/SourceVersion;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isSelected", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getElementUtils", "()Ljavax/lang/model/util/Elements;"));
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public abstract")]
	bool isIncluded(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getSpecifiedElements()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getIncludedElements()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public abstract")]
	Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode getModuleMode()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljavax/tools/JavaFileObject$Kind;", "public abstract")]
	Dova.JDK.javax.tools.JavaFileObject.Kind getFileKind(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/DocTrees;", "public abstract")]
	Dova.JDK.com.sun.source.util.DocTrees getDocTrees()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTrees>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Types;", "public abstract")]
	Dova.JDK.javax.lang.model.util.Types getTypeUtils()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
	}

	[JniSignatureAttribute("()Ljavax/tools/JavaFileManager;", "public abstract")]
	Dova.JDK.javax.tools.JavaFileManager getJavaFileManager()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/SourceVersion;", "public abstract")]
	Dova.JDK.javax.lang.model.SourceVersion getSourceVersion()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.SourceVersion>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public abstract")]
	bool isSelected(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Elements;", "public abstract")]
	Dova.JDK.javax.lang.model.util.Elements getElementUtils()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
	}

	[JniSignatureAttribute("Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static final")]
	public partial class ModuleMode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModuleMode()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "API", "Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ALL", "Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ModuleMode", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static final")]
		public static Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode API_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static final")]
		public static Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode ALL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModuleMode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ModuleMode(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static")]
		public static Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>>(ret);
		}
	}
}