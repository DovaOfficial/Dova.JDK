/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.shellsupport.doc;

[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocHelper;", "public abstract")]
public partial class JavadocHelper
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.AutoCloseable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavadocHelper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/shellsupport/doc/JavadocHelper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "compiler", "Ljavax/tools/JavaCompiler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "JavadocHelper", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Lcom/sun/source/util/JavacTask;Ljava/util/Collection;)Ljdk/internal/shellsupport/doc/JavadocHelper;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSourceElement", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResolvedDocComment", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljavax/tools/JavaCompiler;", "private static final")]
	public static Dova.JDK.javax.tools.JavaCompiler compiler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaCompiler>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavadocHelper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JavadocHelper() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/shellsupport/doc/JavadocHelper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public abstract")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Ljava/util/Collection;)Ljdk/internal/shellsupport/doc/JavadocHelper;", "public static")]
	public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocHelper create(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.java.util.Collection arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocHelper>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/Element;", "public abstract")]
	public Dova.JDK.javax.lang.model.element.Element getSourceElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getResolvedDocComment(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocHelper$OnDemandJavadocHelper;", "private static final")]
	public partial class OnDemandJavadocHelper
		: Dova.JDK.jdk.@internal.shellsupport.doc.JavadocHelper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OnDemandJavadocHelper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/shellsupport/doc/JavadocHelper$OnDemandJavadocHelper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "mainTask", "Lcom/sun/source/util/JavacTask;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "baseFileManager", "Ljavax/tools/JavaFileManager;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fm", "Ljavax/tools/StandardJavaFileManager;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "signature2Source", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OnDemandJavadocHelper", "(Lcom/sun/source/util/JavacTask;Ljavax/tools/StandardJavaFileManager;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "interfaces", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findSource", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/Pair;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "topLevelType", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillElementCache", "(Lcom/sun/source/util/JavacTask;Lcom/sun/source/tree/CompilationUnitTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "superMethodsForInheritDoc", "(Lcom/sun/source/util/JavacTask;Ljavax/lang/model/element/ExecutableElement;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseDocComment", "(Lcom/sun/source/util/JavacTask;Ljava/lang/String;)Lcom/sun/tools/javac/util/Pair;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "superTypeForInheritDoc", "(Lcom/sun/source/util/JavacTask;Ljavax/lang/model/element/Element;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSourceElement", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSourceElement", "(Lcom/sun/source/util/JavacTask;Ljavax/lang/model/element/Element;)Lcom/sun/tools/javac/util/Pair;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResolvedDocComment", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResolvedDocComment", "(Lcom/sun/source/util/JavacTask;Lcom/sun/source/util/TreePath;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "elementSignature", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseBlockTag", "(Lcom/sun/source/util/JavacTask;Ljava/lang/String;)Lcom/sun/source/doctree/DocTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getThrownException", "(Lcom/sun/source/util/JavacTask;Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/doctree/ThrowsTree;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/util/JavacTask;", "private final")]
		public Dova.JDK.com.sun.source.util.JavacTask mainTask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.JavacTask>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileManager;", "private final")]
		public Dova.JDK.javax.tools.JavaFileManager baseFileManager_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/tools/StandardJavaFileManager;", "private final")]
		public Dova.JDK.javax.tools.StandardJavaFileManager fm_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.StandardJavaFileManager>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map signature2Source_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OnDemandJavadocHelper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Ljavax/tools/StandardJavaFileManager;)V", "private")]
		public OnDemandJavadocHelper(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.javax.tools.StandardJavaFileManager arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/shellsupport/doc/JavadocHelper$OnDemandJavadocHelper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/stream/Stream;", "private")]
		public Dova.JDK.java.util.stream.Stream interfaces(Dova.JDK.javax.lang.model.element.TypeElement arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/Pair;", "private")]
		public Dova.JDK.com.sun.tools.javac.util.Pair findSource(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Pair>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;", "private")]
		public Dova.JDK.javax.lang.model.element.TypeElement topLevelType(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Lcom/sun/source/tree/CompilationUnitTree;)V", "private")]
		public void fillElementCache(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.com.sun.source.tree.CompilationUnitTree arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Ljavax/lang/model/element/ExecutableElement;)Ljava/util/stream/Stream;", "private")]
		public Dova.JDK.java.util.stream.Stream superMethodsForInheritDoc(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.javax.lang.model.element.ExecutableElement arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Ljava/lang/String;)Lcom/sun/tools/javac/util/Pair;", "private")]
		public Dova.JDK.com.sun.tools.javac.util.Pair parseDocComment(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Pair>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Ljavax/lang/model/element/Element;)Ljava/util/stream/Stream;", "private")]
		public Dova.JDK.java.util.stream.Stream superTypeForInheritDoc(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.javax.lang.model.element.Element arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/Element;", "public")]
		public Dova.JDK.javax.lang.model.element.Element getSourceElement(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Ljavax/lang/model/element/Element;)Lcom/sun/tools/javac/util/Pair;", "private")]
		public Dova.JDK.com.sun.tools.javac.util.Pair getSourceElement(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.javax.lang.model.element.Element arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Pair>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getResolvedDocComment(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Lcom/sun/source/util/TreePath;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getResolvedDocComment(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.com.sun.source.util.TreePath arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String elementSignature(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Ljava/lang/String;)Lcom/sun/source/doctree/DocTree;", "private")]
		public Dova.JDK.com.sun.source.doctree.DocTree parseBlockTag(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/doctree/ThrowsTree;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getThrownException(Dova.JDK.com.sun.source.util.JavacTask arg0, Dova.JDK.com.sun.source.util.TreePath arg1, Dova.JDK.com.sun.source.doctree.DocCommentTree arg2, Dova.JDK.com.sun.source.doctree.ThrowsTree arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocHelper$OnDemandJavadocHelper$PatchModuleFileManager;", "private static final")]
		public partial class PatchModuleFileManager
			: Dova.JDK.javax.tools.ForwardingJavaFileManager
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PatchModuleFileManager()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/shellsupport/doc/JavadocHelper$OnDemandJavadocHelper$PatchModuleFileManager;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "file", "Ljavax/tools/JavaFileObject;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "moduleName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PATCH_LOCATION", "Ljavax/tools/JavaFileManager$Location;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PatchModuleFileManager", "(Ljavax/tools/JavaFileManager;Ljavax/tools/JavaFileObject;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasLocation", "(Ljavax/tools/JavaFileManager$Location;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileManager$Location;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inferModuleName", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljavax/tools/JavaFileObject;", "private final")]
			public Dova.JDK.javax.tools.JavaFileObject file_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String moduleName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljavax/tools/JavaFileManager$Location;", "private static final")]
			public static Dova.JDK.javax.tools.JavaFileManager.Location PATCH_LOCATION_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PatchModuleFileManager(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/tools/JavaFileManager;Ljavax/tools/JavaFileObject;Ljava/lang/String;)V", "public")]
			public PatchModuleFileManager(Dova.JDK.javax.tools.JavaFileManager arg0, Dova.JDK.javax.tools.JavaFileObject arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/shellsupport/doc/JavadocHelper$OnDemandJavadocHelper$PatchModuleFileManager;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Z", "public")]
			public bool hasLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileManager$Location;", "public")]
			public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.javax.tools.JavaFileObject arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
			}

			[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String inferModuleName(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}
}
