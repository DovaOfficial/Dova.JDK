/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.lang.model.util;

[JniSignatureAttribute("Ljavax/lang/model/util/SimpleTypeVisitor14;", "public")]
public partial class SimpleTypeVisitor14
	: Dova.JDK.javax.lang.model.util.SimpleTypeVisitor9
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleTypeVisitor14()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/lang/model/util/SimpleTypeVisitor14;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SimpleTypeVisitor14", "()V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SimpleTypeVisitor14", "(Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleTypeVisitor14(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public SimpleTypeVisitor14() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public SimpleTypeVisitor14(Dova.JDK.java.lang.Object arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/lang/model/util/SimpleTypeVisitor14;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}