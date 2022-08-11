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

namespace Dova.JDK.javax.xml.validation;

[JniSignatureAttribute("Ljavax/xml/validation/Schema;", "public abstract")]
public partial class Schema
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Schema()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/validation/Schema;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValidator", "()Ljavax/xml/validation/Validator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValidatorHandler", "()Ljavax/xml/validation/ValidatorHandler;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Schema(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public Schema() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/xml/validation/Schema;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/xml/validation/Validator;", "public abstract")]
	public Dova.JDK.javax.xml.validation.Validator newValidator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.validation.Validator>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/validation/ValidatorHandler;", "public abstract")]
	public Dova.JDK.javax.xml.validation.ValidatorHandler newValidatorHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.validation.ValidatorHandler>(ret);
	}
}
