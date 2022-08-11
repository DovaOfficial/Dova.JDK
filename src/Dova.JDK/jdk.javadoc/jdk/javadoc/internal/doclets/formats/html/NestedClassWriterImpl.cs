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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/NestedClassWriterImpl;", "public")]
public partial class NestedClassWriterImpl
	: Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.AbstractMemberWriter
	, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MemberSummaryWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NestedClassWriterImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/NestedClassWriterImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;Ljavax/lang/model/element/TypeElement;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryLink", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSummaryTable", "()Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSummaryTableHeader", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/TableHeader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryType", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInheritedSummaryLink", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberSummaryHeader", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummary", "(Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSummaryLabel", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInheritedSummaryLabel", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSummaryLink", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NestedClassWriterImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;Ljavax/lang/model/element/TypeElement;)V", "public")]
	public NestedClassWriterImpl(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/SubWriterHolderWriter;)V", "public")]
	public NestedClassWriterImpl(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/NestedClassWriterImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addSummaryLink(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.element.Element arg2, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/Table;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table createSummaryTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/TableHeader;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader getSummaryTableHeader(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addSummaryType(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addInheritedSummaryLink(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getMemberSummaryHeader(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSummary(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addSummaryLabel(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void addInheritedSummaryLabel(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSummaryLink(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}
}
