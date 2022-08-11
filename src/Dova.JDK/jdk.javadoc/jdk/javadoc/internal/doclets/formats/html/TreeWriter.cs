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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/TreeWriter;", "public")]
public partial class TreeWriter
	: Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.AbstractTreeWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TreeWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/TreeWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packages", "Ljava/util/SortedSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classesOnly", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bodyContents", "Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generate", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateTreeFile", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPackageTreeLinks", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTreeHeader", "()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnnamedPackage", "()Z"));
	}

	[JniSignatureAttribute("Ljava/util/SortedSet;", "")]
	public Dova.JDK.java.util.SortedSet packages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool classesOnly_Property
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

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/BodyContents;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.BodyContents bodyContents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.BodyContents>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TreeWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)V", "public")]
	public TreeWriter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/TreeWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)V", "public static")]
	public static void generate(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void generateTreeFile()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addPackageTreeLinks(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree getTreeHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isUnnamedPackage()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}
}
