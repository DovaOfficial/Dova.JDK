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

namespace Dova.JDK.jdk.javadoc.@internal.doclint;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Env;", "public")]
public partial class Env
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Env()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/Env;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messages", "Ljdk/javadoc/internal/doclint/Messages;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "customTags", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includePackages", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "excludePackages", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trees", "Lcom/sun/source/util/DocTrees;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elements", "Ljavax/lang/model/util/Elements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Ljavax/lang/model/util/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "java_lang_Error", "Ljavax/lang/model/type/TypeMirror;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "java_lang_RuntimeException", "Ljavax/lang/model/type/TypeMirror;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "java_lang_SuppressWarnings", "Ljavax/lang/model/type/TypeMirror;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "java_lang_Throwable", "Ljavax/lang/model/type/TypeMirror;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "java_lang_Void", "Ljavax/lang/model/type/TypeMirror;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currPath", "Lcom/sun/source/util/TreePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currElement", "Ljavax/lang/model/element/Element;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currDocComment", "Lcom/sun/source/doctree/DocCommentTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currAccess", "Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currOverriddenMethods", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suppressWarnings", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "min", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lcom/sun/source/util/DocTrees;Ljavax/lang/model/util/Elements;Ljavax/lang/model/util/Types;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lcom/sun/source/util/JavacTask;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCheckPackages", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldCheck", "(Lcom/sun/source/tree/CompilationUnitTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suppressWarnings", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclint/Messages$Group;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suppressWarnings", "(Ljdk/javadoc/internal/doclint/Messages$Group;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuppressWarningsValue", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initTypes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurrent", "(Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessKind", "()Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPos", "(Lcom/sun/source/util/TreePath;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuppressedGroups", "(Ljavax/lang/model/element/Element;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCustomTags", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPos", "(Lcom/sun/source/util/TreePath;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "validatePackages", "(Ljava/lang/String;)Z"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Messages;", "final")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.Messages messages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Messages>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set customTags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set includePackages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set excludePackages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/util/DocTrees;", "")]
	public Dova.JDK.com.sun.source.util.DocTrees trees_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTrees>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/Elements;", "")]
	public Dova.JDK.javax.lang.model.util.Elements elements_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/Types;", "")]
	public Dova.JDK.javax.lang.model.util.Types types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/type/TypeMirror;", "")]
	public Dova.JDK.javax.lang.model.type.TypeMirror java_lang_Error_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/type/TypeMirror;", "")]
	public Dova.JDK.javax.lang.model.type.TypeMirror java_lang_RuntimeException_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/type/TypeMirror;", "")]
	public Dova.JDK.javax.lang.model.type.TypeMirror java_lang_SuppressWarnings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/type/TypeMirror;", "")]
	public Dova.JDK.javax.lang.model.type.TypeMirror java_lang_Throwable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/type/TypeMirror;", "")]
	public Dova.JDK.javax.lang.model.type.TypeMirror java_lang_Void_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/util/TreePath;", "")]
	public Dova.JDK.com.sun.source.util.TreePath currPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/element/Element;", "")]
	public Dova.JDK.javax.lang.model.element.Element currElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/doctree/DocCommentTree;", "")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree currDocComment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Env$AccessKind;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind currAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set currOverriddenMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map suppressWarnings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Env(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Env() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/Env;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "private")]
	public Dova.JDK.java.lang.Object min(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/DocTrees;Ljavax/lang/model/util/Elements;Ljavax/lang/model/util/Types;)V", "")]
	public void init(Dova.JDK.com.sun.source.util.DocTrees arg0, Dova.JDK.javax.lang.model.util.Elements arg1, Dova.JDK.javax.lang.model.util.Types arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/JavacTask;)V", "")]
	public void init(Dova.JDK.com.sun.source.util.JavacTask arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void setCheckPackages(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;)Z", "")]
	public bool shouldCheck(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclint/Messages$Group;)Z", "")]
	public bool suppressWarnings(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclint.Messages.Group arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclint/Messages$Group;)Z", "")]
	public bool suppressWarnings(Dova.JDK.jdk.javadoc.@internal.doclint.Messages.Group arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getSuppressWarningsValue(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void initTypes()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;)V", "")]
	public void setCurrent(Dova.JDK.com.sun.source.util.TreePath arg0, Dova.JDK.com.sun.source.doctree.DocCommentTree arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclint/Env$AccessKind;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind getAccessKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)J", "")]
	public long getPos(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set getSuppressedGroups(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void setCustomTags(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)J", "")]
	public long getStartPos(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
	public static bool validatePackages(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Env$AccessKind;", "public static final")]
	public partial class AccessKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/Env$AccessKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVATE", "Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE", "Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTECTED", "Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUBLIC", "Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/util/Set;)Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/Env$AccessKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "accepts", "(Ljava/lang/String;)Z"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Env$AccessKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind PRIVATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Env$AccessKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind PACKAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Env$AccessKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind PROTECTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Env$AccessKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind PUBLIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/Env$AccessKind;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public AccessKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/Env$AccessKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/Env$AccessKind;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/Env$AccessKind;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Ljdk/javadoc/internal/doclint/Env$AccessKind;", "static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind of(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/Env$AccessKind;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Env.AccessKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
		public static bool accepts(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}
	}
}
