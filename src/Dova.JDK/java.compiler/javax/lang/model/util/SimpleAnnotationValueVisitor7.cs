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

namespace Dova.JDK.javax.lang.model.util;

[JniSignatureAttribute("Ljavax/lang/model/util/SimpleAnnotationValueVisitor7;", "public")]
public partial class SimpleAnnotationValueVisitor7
	: Dova.JDK.javax.lang.model.util.SimpleAnnotationValueVisitor6
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleAnnotationValueVisitor7()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/lang/model/util/SimpleAnnotationValueVisitor7;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleAnnotationValueVisitor7(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public SimpleAnnotationValueVisitor7() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public SimpleAnnotationValueVisitor7(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/lang/model/util/SimpleAnnotationValueVisitor7;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
