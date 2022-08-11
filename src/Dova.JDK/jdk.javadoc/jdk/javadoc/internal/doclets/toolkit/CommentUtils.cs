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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/CommentUtils;", "public")]
public partial class CommentUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CommentUtils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/CommentUtils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resources", "Ljdk/javadoc/internal/doclets/toolkit/Resources;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeFactory", "Lcom/sun/source/util/DocTreeFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trees", "Lcom/sun/source/util/DocTrees;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elementUtils", "Ljavax/lang/model/util/Elements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dcInfoMap", "Ljava/util/HashMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/util/List;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/net/URI;Ljava/lang/String;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComment", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComment", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSyntheticCommentInfo", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHtmlCommentInfo", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeTextTree", "(Ljava/lang/String;)Lcom/sun/source/doctree/TextTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeDescriptionWithName", "(Ljava/lang/String;Ljavax/lang/model/element/Name;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeDescriptionWithComponent", "(Ljava/lang/String;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Name;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeTextTreeForResource", "(Ljava/lang/String;)Lcom/sun/source/doctree/TextTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeCodeTree", "(Ljava/lang/String;)Lcom/sun/source/doctree/LiteralTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeReturnTree", "(Ljava/util/List;)Lcom/sun/source/doctree/ReturnTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeParamTree", "(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/ParamTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makePropertyDescriptionTree", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSeeTree", "(Ljava/lang/String;Ljavax/lang/model/element/Element;)Lcom/sun/source/doctree/DocTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocCommentTree", "(Ljavax/lang/model/element/Element;Ljava/util/List;Ljava/util/List;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasParamForComponent", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Name;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocCommentInfo", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeFirstSentenceTree", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnumValuesTree", "(Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnumValueOfTree", "(Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRecordConstructorTree", "(Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRecordEqualsTree", "(Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRecordHashCodeTree", "(Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRecordToStringTree", "(Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRecordAccessorTree", "(Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRecordFieldTree", "(Ljavax/lang/model/element/VariableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updatePropertyMethodComment", "(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/Element;)V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;", "final")]
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

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Resources;", "final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources resources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/util/DocTreeFactory;", "final")]
	public Dova.JDK.com.sun.source.util.DocTreeFactory treeFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreeFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/util/DocTrees;", "final")]
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

	[JniSignatureAttribute("Ljavax/lang/model/util/Elements;", "final")]
	public Dova.JDK.javax.lang.model.util.Elements elementUtils_Property
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

	[JniSignatureAttribute("Ljava/util/HashMap;", "final")]
	public Dova.JDK.java.util.HashMap dcInfoMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CommentUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V", "protected")]
	public CommentUtils(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/CommentUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;)V", "private")]
	public void add(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/URI;Ljava/lang/String;)Lcom/sun/source/doctree/DocCommentTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree parse(Dova.JDK.java.net.URI arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getComment(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getComment(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo getSyntheticCommentInfo(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo getHtmlCommentInfo(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/TextTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.TextTree makeTextTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.TextTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/lang/model/element/Name;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List makeDescriptionWithName(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.lang.model.element.Name arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Name;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List makeDescriptionWithComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.element.Name arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/TextTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.TextTree makeTextTreeForResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.TextTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/LiteralTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.LiteralTree makeCodeTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LiteralTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/ReturnTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.ReturnTree makeReturnTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReturnTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/ParamTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.ParamTree makeParamTree(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ParamTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List makePropertyDescriptionTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/lang/model/element/Element;)Lcom/sun/source/doctree/DocTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.DocTree makeSeeTree(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/List;Ljava/util/List;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo setDocCommentTree(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Name;)Z", "private")]
	public bool hasParamForComponent(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Name arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;)Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo setDocCommentInfo(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.CommentUtils.DocCommentInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List makeFirstSentenceTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "public")]
	public void setEnumValuesTree(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "public")]
	public void setEnumValueOfTree(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "public")]
	public void setRecordConstructorTree(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "public")]
	public void setRecordEqualsTree(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "public")]
	public void setRecordHashCodeTree(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "public")]
	public void setRecordToStringTree(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "public")]
	public void setRecordAccessorTree(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;)V", "public")]
	public void setRecordFieldTree(Dova.JDK.javax.lang.model.element.VariableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/Element;)V", "public")]
	public void updatePropertyMethodComment(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;", "public static")]
	public partial class DocCommentInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DocCommentInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treePath", "Lcom/sun/source/util/TreePath;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dcTree", "Lcom/sun/source/doctree/DocCommentTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TreePath;", "public final")]
		public Dova.JDK.com.sun.source.util.TreePath treePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/doctree/DocCommentTree;", "public final")]
		public Dova.JDK.com.sun.source.doctree.DocCommentTree dcTree_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DocCommentInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;)V", "public")]
		public DocCommentInfo(Dova.JDK.com.sun.source.util.TreePath arg0, Dova.JDK.com.sun.source.doctree.DocCommentTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/CommentUtils$DocCommentInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
