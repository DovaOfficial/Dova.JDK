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

namespace Dova.JDK.javax.lang.model.util;

[JniSignatureAttribute("Ljavax/lang/model/util/AbstractElementVisitor14;", "public abstract")]
public partial class AbstractElementVisitor14
	: Dova.JDK.javax.lang.model.util.AbstractElementVisitor9
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractElementVisitor14()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/lang/model/util/AbstractElementVisitor14;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AbstractElementVisitor14", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRecordComponent", "(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractElementVisitor14(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AbstractElementVisitor14() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/lang/model/util/AbstractElementVisitor14;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object visitRecordComponent(Dova.JDK.javax.lang.model.element.RecordComponentElement arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
