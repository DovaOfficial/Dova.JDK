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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/AbstractMemberWriter;", "public abstract")]
public partial class AbstractMemberWriter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MemberSummaryWriter
	, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MemberWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractMemberWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/AbstractMemberWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljdk/javadoc/internal/doclets/formats/html/HtmlOptions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writer", "Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contents", "Ljdk/javadoc/internal/doclets/formats/html/Contents;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resources", "Ljdk/javadoc/internal/doclets/toolkit/Resources;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "links", "Ljdk/javadoc/internal/doclets/formats/html/markup/Links;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "htmlIds", "Ljdk/javadoc/internal/doclets/formats/html/HtmlIds;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeElement", "Ljavax/lang/model/element/TypeElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "summaryTable", "Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;Ljavax/lang/model/element/TypeElement;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryLink", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSummaryTable", "()Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addModifier", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSummaryTableHeader", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/TableHeader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryType", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSummaryTable", "()Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInheritedMemberSummary", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;ZZLjdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInheritedSummaryLink", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPreviewInfo", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDeprecatedInfo", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addComment", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addUseInfo", "(Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serialWarning", "(Ljavax/lang/model/element/Element;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMemberSummary", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInheritedSummaryHeader", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInheritedSummaryLinksTree", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSummaryTableTree", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberTree", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberList", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberListItem", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryLabel", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInheritedSummaryLabel", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addModifierAndType", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/type/TypeMirror;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSummaryLink", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlOptions;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlOptions options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlOptions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter writer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/Contents;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Contents contents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Contents>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Resources;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources resources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Links;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Links links_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Links>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlIds;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlIds htmlIds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlIds>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/element/TypeElement;", "protected final")]
	public Dova.JDK.javax.lang.model.element.TypeElement typeElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/Table;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table summaryTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractMemberWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;Ljavax/lang/model/element/TypeElement;)V", "public")]
	public AbstractMemberWriter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;)V", "public")]
	public AbstractMemberWriter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/AbstractMemberWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String name(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addSummaryLink(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected abstract")]
	public void addSummaryLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.element.Element arg2, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/Table;", "protected abstract")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table createSummaryTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "private")]
	public void addModifier(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/TableHeader;", "public abstract")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader getSummaryTableHeader(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected abstract")]
	public void addSummaryType(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/Table;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table getSummaryTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;ZZLjdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addInheritedMemberSummary(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Element arg1, bool arg2, bool arg3, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected abstract")]
	public void addInheritedSummaryLink(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addPreviewInfo(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addDeprecatedInfo(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addUseInfo(Dova.JDK.java.util.List arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
	public void serialWarning(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljava/util/List;)V", "public")]
	public void addMemberSummary(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getInheritedSummaryHeader(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getInheritedSummaryLinksTree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSummaryTableTree(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getMemberTree(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getMemberList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getMemberListItem(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
	public void addSummaryLabel(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
	public void addInheritedSummaryLabel(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/type/TypeMirror;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addModifierAndType(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected abstract")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSummaryLink(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}
}
