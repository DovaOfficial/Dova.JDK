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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlDocletWriter;", "public")]
public partial class HtmlDocletWriter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HtmlDocletWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/HtmlDocletWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pathToRoot", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filename", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljdk/javadoc/internal/doclets/formats/html/HtmlOptions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contents", "Ljdk/javadoc/internal/doclets/formats/html/Contents;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messages", "Ljdk/javadoc/internal/doclets/toolkit/Messages;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resources", "Ljdk/javadoc/internal/doclets/toolkit/Resources;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "links", "Ljdk/javadoc/internal/doclets/formats/html/markup/Links;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docPaths", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPaths;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "comparators", "Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "htmlIds", "Ljdk/javadoc/internal/doclets/formats/html/HtmlIds;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isAnnotationDocumented", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isContainerDocumented", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "winTitle", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainBodyScript", "Ljdk/javadoc/internal/doclets/formats/html/markup/Script;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indexAnchorTable", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "docrootPattern", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "commentRemoved", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "(Ljava/util/List;Z)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeader", "(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeader", "(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/Element;Ljava/lang/CharSequence;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljava/lang/CharSequence;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljava/lang/CharSequence;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljava/lang/CharSequence;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMainBodyScript", "()Ljdk/javadoc/internal/doclets/formats/html/markup/Script;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagletWriterInstance", "(Z)Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagletWriterInstance", "(Ljdk/javadoc/internal/doclets/formats/html/TagletWriterImpl$Context;)Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInlineComment", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInlineComment", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPreviewInfo", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationInfo", "(Ljava/util/List;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationInfo", "(Ljavax/lang/model/element/Element;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pathString", "(Ljavax/lang/model/element/PackageElement;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pathString", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameterLinks", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectRelativeLinks", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/TextTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingPackageName", "(Ljavax/lang/model/element/TypeElement;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commentTagsToContent", "(Lcom/sun/source/doctree/DocTree;Ljavax/lang/model/element/Element;Ljava/util/List;Ljdk/javadoc/internal/doclets/formats/html/TagletWriterImpl$Context;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commentTagsToContent", "(Lcom/sun/source/doctree/DocTree;Ljavax/lang/model/element/Element;Ljava/util/List;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commentTagsToContent", "(Lcom/sun/source/doctree/DocTree;Ljavax/lang/model/element/Element;Ljava/util/List;ZZ)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotationValueToContent", "(Ljavax/lang/model/element/AnnotationValue;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifiedClassLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPreviewFeatures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalStylesheets", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMethodInfo", "(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFooter", "()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHtmlDocument", "(Ljava/util/List;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHtmlDocument", "(Ljava/util/List;Ljava/lang/String;Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHtmlDocument", "(Ljava/util/List;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeTrailingSlash", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTagsInfo", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowTitle", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceDocRootDir", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNavBar", "(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/Navigation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageLabel", "(Ljava/lang/CharSequence;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSerializationOverviewTags", "(Ljavax/lang/model/element/VariableElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInlineDeprecatedComment", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DeprecatedTree;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPreQualifiedClassLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPreQualifiedClassLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleStylesheets", "(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCrossPackageLink", "(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalizedPackageName", "(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPreQualifiedStrongClassLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreQualifiedClassLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldRedirectRelativeLinks", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageTableHeader", "()Ljdk/javadoc/internal/doclets/formats/html/TableHeader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plainOrCode", "(ZLjdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleLink", "(Ljavax/lang/model/element/ModuleElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageLink", "(Ljavax/lang/model/element/PackageElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCrossModuleLink", "(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addCommentTags", "(Ljavax/lang/model/element/Element;Ljava/util/List;ZZZLjdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreNonInlineTag", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inSamePackage", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationArray", "(Ljava/util/Map;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBodyStyle", "()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStylesheets", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreviewNotes", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLinks", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNavLinkMainTree", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSrcLink", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCrossClassLink", "(Ljavax/lang/model/element/TypeElement;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seeTagToContent", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/formats/html/TagletWriterImpl$Context;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "linkToContent", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;Ljava/lang/String;Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPreviewComment", "(Ljavax/lang/model/element/Element;Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeprecatedPhrase", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPreviewSummary", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryComment", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryComment", "(Ljavax/lang/model/element/Element;Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryDeprecatedComment", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DeprecatedTree;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDescription", "(Ljava/lang/String;Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAnnotations", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;Ljdk/javadoc/internal/doclets/formats/html/markup/ContentBuilder;Ljava/util/Map;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidTagOutput", "(Ljava/lang/String;Ljava/util/Optional;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentPageElement", "()Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTagOutput", "(Ljavax/lang/model/element/Element;Ljava/util/List;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTagOutput", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInlineTagOutput", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/formats/html/TagletWriterImpl$Context;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCoreClass", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getGenerator", "(Ljava/lang/Class;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath pathToRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath path_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath filename_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlOptions;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlOptions options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlOptions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/Contents;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Contents contents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Contents>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Messages;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Messages messages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Messages>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Resources;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources resources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Links;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Links links_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Links>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPaths;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPaths docPaths_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPaths>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators comparators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlIds;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlIds htmlIds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlIds>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isAnnotationDocumented_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool isContainerDocumented_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String winTitle_Property
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

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Script;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Script mainBodyScript_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Script>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map indexAnchorTable_Property
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

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern docrootPattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool commentRemoved_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HtmlDocletWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "public")]
	public HtmlDocletWriter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/HtmlDocletWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/List;Z)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getAnnotations(Dova.JDK.java.util.List arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree getHeader(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree getHeader(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/Element;Ljava/lang/CharSequence;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getDocLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.lang.CharSequence arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getDocLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.element.Element arg2, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg3, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg4, bool arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljava/lang/CharSequence;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getDocLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.element.Element arg2, Dova.JDK.java.lang.CharSequence arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljava/lang/CharSequence;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getDocLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.element.Element arg2, Dova.JDK.java.lang.CharSequence arg3, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljava/lang/CharSequence;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getDocLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.element.Element arg2, Dova.JDK.java.lang.CharSequence arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/markup/Script;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Script getMainBodyScript()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Script>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter getTagletWriterInstance(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/TagletWriterImpl$Context;)Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter getTagletWriterInstance(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TagletWriterImpl.Context arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addInlineComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addInlineComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addPreviewInfo(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getAnnotationInfo(Dova.JDK.java.util.List arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getAnnotationInfo(Dova.JDK.javax.lang.model.element.Element arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath pathString(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath pathString(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getTypeParameterLinks(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/TextTree;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String redirectRelativeLinks(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.TextTree arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getEnclosingPackageName(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljavax/lang/model/element/Element;Ljava/util/List;Ljdk/javadoc/internal/doclets/formats/html/TagletWriterImpl$Context;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content commentTagsToContent(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.util.List arg2, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TagletWriterImpl.Context arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljavax/lang/model/element/Element;Ljava/util/List;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content commentTagsToContent(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.util.List arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljavax/lang/model/element/Element;Ljava/util/List;ZZ)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content commentTagsToContent(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.util.List arg2, bool arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/AnnotationValue;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotationValueToContent(Dova.JDK.javax.lang.model.element.AnnotationValue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getQualifiedClassLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content withPreviewFeatures(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "")]
	public Dova.JDK.java.util.List getLocalStylesheets(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "private")]
	public void addMethodInfo(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree getFooter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void printHtmlDocument(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2, Dova.JDK.java.util.List arg3, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void printHtmlDocument(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.List arg2, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void printHtmlDocument(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String removeTrailingSlash(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addTagsInfo(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getWindowTitle(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replaceDocRootDir(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/Navigation;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation getNavBar(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getPackageLabel(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;)Z", "protected")]
	public bool hasSerializationOverviewTags(Dova.JDK.javax.lang.model.element.VariableElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DeprecatedTree;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addInlineDeprecatedComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DeprecatedTree arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addPreQualifiedClassLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg2, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addPreQualifiedClassLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getModuleStylesheets(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink getCrossPackageLink(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getLocalizedPackageName(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addPreQualifiedStrongClassLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getPreQualifiedClassLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "private")]
	public bool shouldRedirectRelativeLinks(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/TableHeader;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader getPackageTableHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader>(ret);
	}

	[JniSignatureAttribute("(ZLjdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content plainOrCode(bool arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getModuleLink(Dova.JDK.javax.lang.model.element.ModuleElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getPackageLink(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink getCrossModuleLink(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/List;ZZZLjdk/javadoc/internal/doclets/toolkit/Content;)V", "private")]
	public void addCommentTags(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.List arg1, bool arg2, bool arg3, bool arg4, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "")]
	public bool ignoreNonInlineTag(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "private")]
	public bool inSamePackage(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Z", "private")]
	public bool isAnnotationArray(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle getBodyStyle()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getStylesheets(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getPreviewNotes(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content withLinks(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Set arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getNavLinkMainTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSrcLink(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getCrossClassLink(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/formats/html/TagletWriterImpl$Context;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content seeTagToContent(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TagletWriterImpl.Context arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;Ljava/lang/String;Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content linkToContent(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addPreviewComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.List arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getDeprecatedPhrase(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addPreviewSummary(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSummaryComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSummaryComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.List arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DeprecatedTree;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSummaryDeprecatedComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DeprecatedTree arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/lang/model/element/Element;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getDescription(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[74], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;Ljdk/javadoc/internal/doclets/formats/html/markup/ContentBuilder;Ljava/util/Map;Z)V", "private")]
	public void addAnnotations(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo arg1, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.ContentBuilder arg2, Dova.JDK.java.util.Map arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree getBody(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Optional;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content invalidTagOutput(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Optional arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/TypeElement;", "protected")]
	public Dova.JDK.javax.lang.model.element.TypeElement getCurrentPageElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/List;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getBlockTagOutput(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getBlockTagOutput(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/formats/html/TagletWriterImpl$Context;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getInlineTagOutput(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1, Dova.JDK.com.sun.source.doctree.DocTree arg2, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TagletWriterImpl.Context arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public")]
	public bool isCoreClass(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getGenerator(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
