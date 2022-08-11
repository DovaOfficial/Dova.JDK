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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;", "public")]
public partial class CommentHelper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CommentHelper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Lcom/sun/source/util/TreePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dcTree", "Lcom/sun/source/doctree/DocCommentTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Ljavax/lang/model/element/Element;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPACER", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;Ljavax/lang/model/element/Element;Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/doctree/IdentifierTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReference", "(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getException", "(Lcom/sun/source/doctree/ThrowsTree;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/doctree/ReferenceTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Lcom/sun/source/doctree/ReferenceTree;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "(Ljava/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElement", "(Lcom/sun/source/doctree/ReferenceTree;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagName", "(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstSentenceTrees", "(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstSentenceTrees", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocTreePath", "(Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/util/DocTreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceType", "(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionName", "(Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/doctree/ReferenceTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalizeSignature", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedElement", "(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedSignature", "(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedType", "(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText0", "(Lcom/sun/source/doctree/DocTree;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedPackage", "(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/PackageElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedPackage", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/PackageElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedModule", "(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/ModuleElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedModule", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/ModuleElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedClass", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedClass", "(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedModuleName", "(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedModuleName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedMember", "(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedMember", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedMemberName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferencedMemberName", "(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInheritedDocTreePath", "(Lcom/sun/source/doctree/DocTree;Ljavax/lang/model/element/ExecutableElement;)Lcom/sun/source/util/DocTreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTypeParameter", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTags", "(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterName", "(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel", "(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/util/TreePath;", "public final")]
	public Dova.JDK.com.sun.source.util.TreePath path_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/doctree/DocCommentTree;", "public final")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree dcTree_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/element/Element;", "public final")]
	public Dova.JDK.javax.lang.model.element.Element element_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String SPACER_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CommentHelper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;Ljavax/lang/model/element/Element;Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;)V", "public")]
	public CommentHelper(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.com.sun.source.util.TreePath arg2, Dova.JDK.com.sun.source.doctree.DocCommentTree arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/doctree/IdentifierTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.IdentifierTree getName(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.IdentifierTree>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getReference(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ThrowsTree;)Ljavax/lang/model/element/Element;", "public")]
	public Dova.JDK.javax.lang.model.element.Element getException(Dova.JDK.com.sun.source.doctree.ThrowsTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/doctree/ReferenceTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.ReferenceTree getType(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getType(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getText(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getText(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;)Ljavax/lang/model/element/Element;", "")]
	public Dova.JDK.javax.lang.model.element.Element getElement(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTagName(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFirstSentenceTrees(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFirstSentenceTrees(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getDescription(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/util/DocTreePath;", "public")]
	public Dova.JDK.com.sun.source.util.DocTreePath getDocTreePath(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreePath>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getServiceType(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/doctree/ReferenceTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.ReferenceTree getExceptionName(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String normalizeSignature(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/Element;", "private")]
	public Dova.JDK.javax.lang.model.element.Element getReferencedElement(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getReferencedSignature(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getReferencedType(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/lang/StringBuilder;", "private")]
	public Dova.JDK.java.lang.StringBuilder getText0(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/PackageElement;", "public")]
	public Dova.JDK.javax.lang.model.element.PackageElement getReferencedPackage(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/PackageElement;", "public")]
	public Dova.JDK.javax.lang.model.element.PackageElement getReferencedPackage(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/ModuleElement;", "public")]
	public Dova.JDK.javax.lang.model.element.ModuleElement getReferencedModule(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.ModuleElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/ModuleElement;", "public")]
	public Dova.JDK.javax.lang.model.element.ModuleElement getReferencedModule(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.ModuleElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getReferencedClass(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getReferencedClass(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getReferencedModuleName(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getReferencedModuleName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljavax/lang/model/element/Element;", "public")]
	public Dova.JDK.javax.lang.model.element.Element getReferencedMember(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/Element;", "public")]
	public Dova.JDK.javax.lang.model.element.Element getReferencedMember(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getReferencedMemberName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getReferencedMemberName(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljavax/lang/model/element/ExecutableElement;)Lcom/sun/source/util/DocTreePath;", "private")]
	public Dova.JDK.com.sun.source.util.DocTreePath getInheritedDocTreePath(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.javax.lang.model.element.ExecutableElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreePath>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public")]
	public bool isTypeParameter(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getTags(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getParameterName(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getBody(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getLabel(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper$ReferenceDocTreeVisitor;", "private static")]
	public partial class ReferenceDocTreeVisitor
		: Dova.JDK.com.sun.source.util.SimpleDocTreeVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReferenceDocTreeVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper$ReferenceDocTreeVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLink", "(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLink", "(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Void;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialField", "(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialField", "(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Void;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSee", "(Lcom/sun/source/doctree/SeeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSee", "(Lcom/sun/source/doctree/SeeTree;Ljava/lang/Void;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides", "(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides", "(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Void;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses", "(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Void;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses", "(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultAction", "(Lcom/sun/source/doctree/DocTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultAction", "(Lcom/sun/source/doctree/DocTree;Ljava/lang/Void;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitValue", "(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitValue", "(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Void;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReferenceDocTreeVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ReferenceDocTreeVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/CommentHelper$ReferenceDocTreeVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitLink(Dova.JDK.com.sun.source.doctree.LinkTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Void;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitLink(Dova.JDK.com.sun.source.doctree.LinkTree arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitSerialField(Dova.JDK.com.sun.source.doctree.SerialFieldTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Void;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitSerialField(Dova.JDK.com.sun.source.doctree.SerialFieldTree arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/SeeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitSee(Dova.JDK.com.sun.source.doctree.SeeTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/SeeTree;Ljava/lang/Void;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitSee(Dova.JDK.com.sun.source.doctree.SeeTree arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitProvides(Dova.JDK.com.sun.source.doctree.ProvidesTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Void;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitProvides(Dova.JDK.com.sun.source.doctree.ProvidesTree arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Void;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitUses(Dova.JDK.com.sun.source.doctree.UsesTree arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitUses(Dova.JDK.com.sun.source.doctree.UsesTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/lang/Object;)Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object defaultAction(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/lang/Void;)Ljava/lang/Object;", "protected")]
		public Dova.JDK.java.lang.Object defaultAction(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitValue(Dova.JDK.com.sun.source.doctree.ValueTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Void;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitValue(Dova.JDK.com.sun.source.doctree.ValueTree arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
