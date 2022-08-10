/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/WriterFactory;", "public abstract interface")]
public partial interface WriterFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WriterFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/WriterFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPackageSummaryWriter", "(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/PackageSummaryWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getModuleSummaryWriter", "(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/ModuleSummaryWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getClassWriter", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMethodWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/MethodWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotationTypeMemberWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEnumConstantWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/EnumConstantWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFieldWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/FieldWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPropertyWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/PropertyWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getConstructorWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/ConstructorWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerializedFormWriter", "()Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMemberSummaryWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljdk/javadoc/internal/doclets/toolkit/MemberSummaryWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getConstantsSummaryWriter", "()Ljdk/javadoc/internal/doclets/toolkit/ConstantsSummaryWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotationTypeOptionalMemberWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocFilesHandler", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/DocFilesHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotationTypeRequiredMemberWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;"));
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/PackageSummaryWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.PackageSummaryWriter getPackageSummaryWriter(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.PackageSummaryWriter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/ModuleSummaryWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ModuleSummaryWriter getModuleSummaryWriter(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ModuleSummaryWriter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter getClassWriter(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/MethodWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MethodWriter getMethodWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MethodWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter getAnnotationTypeMemberWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/EnumConstantWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.EnumConstantWriter getEnumConstantWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.EnumConstantWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/FieldWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.FieldWriter getFieldWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.FieldWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/PropertyWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.PropertyWriter getPropertyWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.PropertyWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/ConstructorWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ConstructorWriter getConstructorWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ConstructorWriter>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.SerializedFormWriter getSerializedFormWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.SerializedFormWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljdk/javadoc/internal/doclets/toolkit/MemberSummaryWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MemberSummaryWriter getMemberSummaryWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.VisibleMemberTable.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MemberSummaryWriter>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/ConstantsSummaryWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ConstantsSummaryWriter getConstantsSummaryWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ConstantsSummaryWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter getAnnotationTypeOptionalMemberWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/DocFilesHandler;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.DocFilesHandler getDocFilesHandler(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.DocFilesHandler>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter getAnnotationTypeRequiredMemberWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter>(ret);
	}
}
