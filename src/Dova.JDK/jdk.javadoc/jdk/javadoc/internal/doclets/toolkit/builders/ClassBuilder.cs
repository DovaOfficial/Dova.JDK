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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.builders;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/builders/ClassBuilder;", "public")]
public partial class ClassBuilder
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.builders.AbstractBuilder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/builders/ClassBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeElement", "Ljavax/lang/model/element/TypeElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writer", "Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentTree", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractBuilder$Context;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractBuilder$Context;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/builders/ClassBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildDeprecationInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRecordDocumentation", "(Ljavax/lang/model/element/TypeElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildClassDoc", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildMemberSummary", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildMemberDetails", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildInterfaceUsageInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildNestedClassInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildFunctionalInterfaceInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildClassSignature", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildClassDescription", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildClassTagInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildEnumConstantsDetails", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildPropertyDetails", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildFieldDetails", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildConstructorDetails", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildAnnotationTypeMemberDetails", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildMethodDetails", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildParamInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildSuperInterfacesInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildImplementedInterfacesInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildSubClassInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildSubInterfacesInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnumDocumentation", "(Ljavax/lang/model/element/TypeElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildClassTree", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyDocFiles", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildClassInfo", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
	}

	[JniSignatureAttribute("Ljavax/lang/model/element/TypeElement;", "private final")]
	public Dova.JDK.javax.lang.model.element.TypeElement typeElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter writer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content contentTree_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractBuilder$Context;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)V", "private")]
	public ClassBuilder(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.builders.AbstractBuilder.Context arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/builders/ClassBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractBuilder$Context;Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/ClassWriter;)Ljdk/javadoc/internal/doclets/toolkit/builders/ClassBuilder;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.builders.ClassBuilder getInstance(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.builders.AbstractBuilder.Context arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.ClassWriter arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.builders.ClassBuilder>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void build()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildDeprecationInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)V", "private")]
	public void setRecordDocumentation(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void buildClassDoc()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildMemberSummary(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildMemberDetails(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildInterfaceUsageInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildNestedClassInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildFunctionalInterfaceInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildClassSignature(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildClassDescription(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildClassTagInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildEnumConstantsDetails(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public void buildPropertyDetails(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildFieldDetails(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildConstructorDetails(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildAnnotationTypeMemberDetails(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildMethodDetails(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildParamInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildSuperInterfacesInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildImplementedInterfacesInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildSubClassInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildSubInterfacesInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)V", "private")]
	public void setEnumDocumentation(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildClassTree(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void copyDocFiles()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26]);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void buildClassInfo(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}
}
