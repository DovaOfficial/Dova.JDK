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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractMemberBuilder;", "public abstract")]
public partial class AbstractMemberBuilder
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.builders.AbstractBuilder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractMemberBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractMemberBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeElement", "Ljavax/lang/model/element/TypeElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibleMemberTable", "Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractBuilder$Context;Ljavax/lang/model/element/TypeElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasMembersToDocument", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibleMembers", "(Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljava/util/List;"));
	}

	[JniSignatureAttribute("Ljavax/lang/model/element/TypeElement;", "protected final")]
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

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable;", "protected final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.VisibleMemberTable visibleMemberTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.VisibleMemberTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractMemberBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractBuilder$Context;Ljavax/lang/model/element/TypeElement;)V", "public")]
	public AbstractMemberBuilder(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.builders.AbstractBuilder.Context arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/builders/AbstractMemberBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
	public void build(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void build()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool hasMembersToDocument()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List getVisibleMembers(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.VisibleMemberTable.Kind arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}
}
