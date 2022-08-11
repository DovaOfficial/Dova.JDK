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
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/doclet/DocletEnvironment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIncluded", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecifiedElements", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIncludedElements", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleMode", "()Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileKind", "(Ljavax/lang/model/element/TypeElement;)Ljavax/tools/JavaFileObject$Kind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocTrees", "()Lcom/sun/source/util/DocTrees;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeUtils", "()Ljavax/lang/model/util/Types;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileManager", "()Ljavax/tools/JavaFileManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceVersion", "()Ljavax/lang/model/SourceVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelected", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementUtils", "()Ljavax/lang/model/util/Elements;"));
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public abstract")]
	bool isIncluded(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getSpecifiedElements()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getIncludedElements()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public abstract")]
	Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode getModuleMode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljavax/tools/JavaFileObject$Kind;", "public abstract")]
	Dova.JDK.javax.tools.JavaFileObject.Kind getFileKind(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/DocTrees;", "public abstract")]
	Dova.JDK.com.sun.source.util.DocTrees getDocTrees()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTrees>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Types;", "public abstract")]
	Dova.JDK.javax.lang.model.util.Types getTypeUtils()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
	}

	[JniSignatureAttribute("()Ljavax/tools/JavaFileManager;", "public abstract")]
	Dova.JDK.javax.tools.JavaFileManager getJavaFileManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/SourceVersion;", "public abstract")]
	Dova.JDK.javax.lang.model.SourceVersion getSourceVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.SourceVersion>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public abstract")]
	bool isSelected(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Elements;", "public abstract")]
	Dova.JDK.javax.lang.model.util.Elements getElementUtils()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "API", "Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL", "Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static final")]
		public static Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode API_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static final")]
		public static Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModuleMode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ModuleMode(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "public static")]
		public static Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/doclet/DocletEnvironment$ModuleMode;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment.ModuleMode>>(ret);
		}
	}
}
