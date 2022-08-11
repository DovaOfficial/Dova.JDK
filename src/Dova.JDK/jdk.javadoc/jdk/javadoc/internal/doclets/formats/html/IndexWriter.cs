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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/IndexWriter;", "public")]
public partial class IndexWriter
	: Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlDocletWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IndexWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/IndexWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainIndex", "Ljdk/javadoc/internal/doclets/toolkit/util/IndexBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "splitIndex", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generate", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addComment", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHeading", "(CLjdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassInfo", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMemberDesc", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTagDescription", "(Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addElementDescription", "(Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVerticalSeparator", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLinksForIndexes", "(Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDescription", "(Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateIndexFile", "(Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addContents", "(CLjava/util/SortedSet;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/IndexBuilder;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexBuilder mainIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected final")]
	public bool splitIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IndexWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "protected")]
	public IndexWriter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/IndexWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V", "public static")]
	public static void generate(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addComment(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(CLjdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addHeading(char arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addClassInfo(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addMemberDesc(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addTagDescription(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addElementDescription(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getVerticalSeparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addLinksForIndexes(Dova.JDK.java.util.List arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addDescription(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)V", "protected")]
	public void generateIndexFile(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(CLjava/util/SortedSet;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addContents(char arg0, Dova.JDK.java.util.SortedSet arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}
}
