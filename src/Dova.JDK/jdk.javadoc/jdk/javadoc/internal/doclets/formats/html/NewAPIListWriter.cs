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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/NewAPIListWriter;", "public")]
public partial class NewAPIListWriter
	: Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SummaryListWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NewAPIListWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/NewAPIListWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/NewAPIBuilder;Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generate", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHeading", "(Ljdk/javadoc/internal/doclets/toolkit/util/NewAPIBuilder;Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCaption", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addExtraSection", "(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addExtraSection", "(Ljdk/javadoc/internal/doclets/toolkit/util/NewAPIBuilder;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTableTabs", "(Ljdk/javadoc/internal/doclets/formats/html/Table;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addComments", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NewAPIListWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/NewAPIBuilder;Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "public")]
	public NewAPIListWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.NewAPIBuilder arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/NewAPIListWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V", "public static")]
	public static void generate(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/NewAPIBuilder;Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getHeading(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.NewAPIBuilder arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getTableCaption(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected volatile")]
	public void addExtraSection(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.SummaryAPIListBuilder arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/NewAPIBuilder;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addExtraSection(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.NewAPIBuilder arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/Table;Ljava/lang/String;)V", "protected")]
	public void addTableTabs(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addComments(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}
}
