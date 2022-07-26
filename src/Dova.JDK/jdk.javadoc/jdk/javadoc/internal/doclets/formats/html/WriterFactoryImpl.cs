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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/WriterFactoryImpl;", "public")]
public partial class WriterFactoryImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.WriterFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WriterFactoryImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/WriterFactoryImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageSummaryWriter", "(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/PackageSummaryWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleSummaryWriter", "(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/ModuleSummaryWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassWriter", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodWriter_0", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/MethodWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodWriter_1", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/MethodWriterImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationTypeMemberWriter_0", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/AnnotationTypeMemberWriterImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationTypeMemberWriter_1", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnumConstantWriter_0", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/EnumConstantWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnumConstantWriter_1", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/EnumConstantWriterImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldWriter_0", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/FieldWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldWriter_1", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/FieldWriterImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyWriter_0", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/PropertyWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyWriter_1", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/PropertyWriterImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorWriter_0", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/ConstructorWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorWriter_1", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/ConstructorWriterImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSerializedFormWriter", "()Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberSummaryWriter", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljdk/javadoc/internal/doclets/toolkit/MemberSummaryWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstantsSummaryWriter", "()Ljdk/javadoc/internal/doclets/toolkit/ConstantsSummaryWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationTypeOptionalMemberWriter_0", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationTypeOptionalMemberWriter_1", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/AnnotationTypeMemberWriterImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocFilesHandler", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/DocFilesHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationTypeRequiredMemberWriter_0", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationTypeRequiredMemberWriter_1", "(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/AnnotationTypeMemberWriterImpl;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public WriterFactoryImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V", "public")]
	public WriterFactoryImpl(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/WriterFactoryImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/PackageSummaryWriter;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.PackageSummaryWriter getPackageSummaryWriter(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.PackageSummaryWriter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/ModuleSummaryWriter;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ModuleSummaryWriter getModuleSummaryWriter(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ModuleSummaryWriter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter getClassWriter(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/MethodWriter;", "public volatile")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MethodWriter getMethodWriter_0(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MethodWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/MethodWriterImpl;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.MethodWriterImpl getMethodWriter_1(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.MethodWriterImpl>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/AnnotationTypeMemberWriterImpl;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.AnnotationTypeMemberWriterImpl getAnnotationTypeMemberWriter_0(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.AnnotationTypeMemberWriterImpl>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;", "public volatile")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter getAnnotationTypeMemberWriter_1(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/EnumConstantWriter;", "public volatile")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.EnumConstantWriter getEnumConstantWriter_0(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.EnumConstantWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/EnumConstantWriterImpl;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.EnumConstantWriterImpl getEnumConstantWriter_1(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.EnumConstantWriterImpl>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/FieldWriter;", "public volatile")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.FieldWriter getFieldWriter_0(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.FieldWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/FieldWriterImpl;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.FieldWriterImpl getFieldWriter_1(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.FieldWriterImpl>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/PropertyWriter;", "public volatile")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.PropertyWriter getPropertyWriter_0(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.PropertyWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/PropertyWriterImpl;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.PropertyWriterImpl getPropertyWriter_1(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.PropertyWriterImpl>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/ConstructorWriter;", "public volatile")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ConstructorWriter getConstructorWriter_0(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ConstructorWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/ConstructorWriterImpl;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.ConstructorWriterImpl getConstructorWriter_1(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.ConstructorWriterImpl>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.SerializedFormWriter getSerializedFormWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.SerializedFormWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljdk/javadoc/internal/doclets/toolkit/MemberSummaryWriter;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MemberSummaryWriter getMemberSummaryWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.VisibleMemberTable.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.MemberSummaryWriter>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/ConstantsSummaryWriter;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ConstantsSummaryWriter getConstantsSummaryWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ConstantsSummaryWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;", "public volatile")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter getAnnotationTypeOptionalMemberWriter_0(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/AnnotationTypeMemberWriterImpl;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.AnnotationTypeMemberWriterImpl getAnnotationTypeOptionalMemberWriter_1(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.AnnotationTypeMemberWriterImpl>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/DocFilesHandler;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.DocFilesHandler getDocFilesHandler(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.DocFilesHandler>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/AnnotationTypeMemberWriter;", "public volatile")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter getAnnotationTypeRequiredMemberWriter_0(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.AnnotationTypeMemberWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/formats/html/AnnotationTypeMemberWriterImpl;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.AnnotationTypeMemberWriterImpl getAnnotationTypeRequiredMemberWriter_1(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.AnnotationTypeMemberWriterImpl>(ret);
	}
}
