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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.formats.html;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/ClassWriterImpl;", "public")]
public partial class ClassWriterImpl
	: Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter
	, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassWriterImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/ClassWriterImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "suppressSubtypesSet", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "suppressImplementingSet", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeElement", "Ljavax/lang/model/element/TypeElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classtree", "Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeader", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPreviewInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTreeForClassHelper", "(Ljavax/lang/model/type/TypeMirror;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassInheritanceTree", "(Ljavax/lang/model/type/TypeMirror;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLinks", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljava/util/Collection;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassContentHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFooter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printDocument", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassInfoTreeHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassSignature", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassDescription", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassTagInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassTree", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addParamInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSubClassInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSubInterfacesInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInterfaceUsageInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addImplementedInterfacesInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSuperInterfacesInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNestedClassInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFunctionalInterfaceInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassDeprecationInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNavBar", "(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/Navigation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberDetailsTree", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeElement", "()Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFunctionalInterface", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentPageElement", "()Ljavax/lang/model/element/TypeElement;"));
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
	public static Dova.JDK.java.util.Set suppressSubtypesSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
	public static Dova.JDK.java.util.Set suppressImplementingSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/element/TypeElement;", "protected final")]
	public Dova.JDK.javax.lang.model.element.TypeElement typeElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree classtree_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassWriterImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)V", "public")]
	public ClassWriterImpl(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/ClassWriterImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getHeader(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "private")]
	public void addPreviewInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getTreeForClassHelper(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassInheritanceTree(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljava/util/Collection;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassLinks(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.java.util.Collection arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassContentHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void addFooter()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void printDocument(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassInfoTreeHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addClassSignature(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addClassDescription(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addClassTagInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addClassTree(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addParamInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSubClassInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSubInterfacesInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addInterfaceUsageInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addImplementedInterfacesInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSuperInterfacesInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addNestedClassInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addFunctionalInterfaceInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addClassDeprecationInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/Navigation;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation getNavBar(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getMemberDetailsTree(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getTypeElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFunctionalInterface()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/TypeElement;", "protected")]
	public Dova.JDK.javax.lang.model.element.TypeElement getCurrentPageElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}
}
