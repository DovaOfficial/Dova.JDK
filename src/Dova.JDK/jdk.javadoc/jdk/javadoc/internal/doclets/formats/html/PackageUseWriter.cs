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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/PackageUseWriter;", "public")]
public partial class PackageUseWriter
	: Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.SubWriterHolderWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PackageUseWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/PackageUseWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageElement", "Ljavax/lang/model/element/PackageElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "usingPackageToUsedClasses", "Ljava/util/SortedMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/ClassUseMapper;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljavax/lang/model/element/PackageElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generate", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/ClassUseMapper;Ljavax/lang/model/element/PackageElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNavBar", "(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/Navigation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageUseHeader", "()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generatePackageUseFile", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPackageList", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassList", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPackageUse", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
	}

	[JniSignatureAttribute("Ljavax/lang/model/element/PackageElement;", "final")]
	public Dova.JDK.javax.lang.model.element.PackageElement packageElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/SortedMap;", "final")]
	public Dova.JDK.java.util.SortedMap usingPackageToUsedClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PackageUseWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/ClassUseMapper;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljavax/lang/model/element/PackageElement;)V", "public")]
	public PackageUseWriter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassUseMapper arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg2, Dova.JDK.javax.lang.model.element.PackageElement arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/PackageUseWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/ClassUseMapper;Ljavax/lang/model/element/PackageElement;)V", "public static")]
	public static void generate(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassUseMapper arg1, Dova.JDK.javax.lang.model.element.PackageElement arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/Navigation;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation getNavBar(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree getPackageUseHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void generatePackageUseFile()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addPackageList(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addClassList(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addPackageUse(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
