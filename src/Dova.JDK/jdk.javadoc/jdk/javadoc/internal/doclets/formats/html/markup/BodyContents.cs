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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;", "public")]
public partial class BodyContents
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BodyContents()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainContents", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "header", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "footer", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/io/Writer;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHeader", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;)Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFooter", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;)Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMainContent", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toContent", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List mainContents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree header_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree footer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BodyContents(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BodyContents() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Z)Z", "public")]
	public bool write(Dova.JDK.java.io.Writer arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;)Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.BodyContents setHeader(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.BodyContents>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;)Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.BodyContents setFooter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.BodyContents>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.BodyContents addMainContent(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.BodyContents>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content toContent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}
}
