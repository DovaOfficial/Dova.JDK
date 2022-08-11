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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkFactory;", "public")]
public partial class HtmlLinkFactory
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.links.LinkFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HtmlLinkFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_writer", "Ljdk/javadoc/internal/doclets/formats/html/HtmlDocletWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docPaths", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPaths;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlDocletWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameterLinks", "(Ljdk/javadoc/internal/doclets/toolkit/util/links/LinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newContent", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeAnnotationLinks", "(Ljdk/javadoc/internal/doclets/toolkit/util/links/LinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameterLink", "(Ljdk/javadoc/internal/doclets/toolkit/util/links/LinkInfo;Ljavax/lang/model/type/TypeMirror;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassToolTip", "(Ljavax/lang/model/element/TypeElement;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLink", "(Ljdk/javadoc/internal/doclets/toolkit/util/links/LinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlDocletWriter;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlDocletWriter m_writer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlDocletWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPaths;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPaths docPaths_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPaths>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HtmlLinkFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlDocletWriter;)V", "public")]
	public HtmlLinkFactory(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlDocletWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath getPath(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/links/LinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getTypeParameterLinks(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.links.LinkInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content newContent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/links/LinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getTypeAnnotationLinks(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.links.LinkInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/links/LinkInfo;Ljavax/lang/model/type/TypeMirror;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getTypeParameterLink(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.links.LinkInfo arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Z)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getClassToolTip(Dova.JDK.javax.lang.model.element.TypeElement arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/links/LinkInfo;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassLink(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.links.LinkInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}
}
