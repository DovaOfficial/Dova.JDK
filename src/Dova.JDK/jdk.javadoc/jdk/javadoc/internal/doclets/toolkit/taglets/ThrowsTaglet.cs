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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/ThrowsTaglet;", "public")]
public partial class ThrowsTaglet
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.BaseTaglet
	, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.InheritableTaglet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ThrowsTaglet()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/taglets/ThrowsTaglet;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inheritThrowsDocumentation", "(Ljavax/lang/model/element/Element;Ljava/util/List;Ljava/util/Set;Ljava/util/Map;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubstitutedThrownTypes", "(Ljava/util/List;Ljava/util/List;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwsTagsOutput", "(Ljava/util/Map;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;Ljava/util/Set;Ljava/util/Map;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "linkToUndocumentedDeclaredExceptions", "(Ljava/util/List;Ljava/util/Set;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllBlockTagOutput", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inherit", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocFinder$Input;Ljdk/javadoc/internal/doclets/toolkit/util/DocFinder$Output;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ThrowsTaglet(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ThrowsTaglet() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/taglets/ThrowsTaglet;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/List;Ljava/util/Set;Ljava/util/Map;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content inheritThrowsDocumentation(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map getSubstitutedThrownTypes(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;Ljava/util/Set;Ljava/util/Map;Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content throwsTagsOutput(Dova.JDK.java.util.Map arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.util.Map arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/Set;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content linkToUndocumentedDeclaredExceptions(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getAllBlockTagOutput(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocFinder$Input;Ljdk/javadoc/internal/doclets/toolkit/util/DocFinder$Output;)V", "public")]
	public void inherit(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFinder.Input arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFinder.Output arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}
}
