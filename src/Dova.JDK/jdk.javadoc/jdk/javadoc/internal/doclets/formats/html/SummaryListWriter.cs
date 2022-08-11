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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/SummaryListWriter;", "public")]
public partial class SummaryListWriter
	: Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SummaryListWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/SummaryListWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pageMode", "Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "headContent", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "titleKey", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeader", "()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addIndexLink", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSummaryLink", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateSummaryListFile", "(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryAPI", "(Ljava/util/SortedSet;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;Ljava/lang/String;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCaption", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addExtraIndexLink", "(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addExtraSection", "(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTableTabs", "(Ljdk/javadoc/internal/doclets/formats/html/Table;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentsList", "(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeadingKey", "(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder$SummaryElementKind;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeaderKey", "(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder$SummaryElementKind;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addComments", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode pageMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String description_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content headContent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String titleKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SummaryListWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;Ljava/lang/String;)V", "public")]
	public SummaryListWriter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg4, Dova.JDK.java.lang.String arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/SummaryListWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree getHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addIndexLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSummaryLink(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;)V", "protected")]
	public void generateSummaryListFile(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/SortedSet;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;Ljava/lang/String;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addSummaryAPI(Dova.JDK.java.util.SortedSet arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getTableCaption(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addExtraIndexLink(Dova.JDK.java.lang.Object arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addExtraSection(Dova.JDK.java.lang.Object arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/Table;Ljava/lang/String;)V", "protected")]
	public void addTableTabs(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getContentsList(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder$SummaryElementKind;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getHeadingKey(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.SummaryAPIListBuilder.SummaryElementKind arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder$SummaryElementKind;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getHeaderKey(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.SummaryAPIListBuilder.SummaryElementKind arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addComments(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}
}
