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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.classfile;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/ConstantFieldref;", "public final")]
public partial class ConstantFieldref
	: Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantCP
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConstantFieldref()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/classfile/ConstantFieldref;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstantFieldref", "(II)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstantFieldref", "(Ljava/io/DataInput;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstantFieldref", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantFieldref;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConstantFieldref(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(II)V", "public")]
	public ConstantFieldref(int arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;)V", "")]
	public ConstantFieldref(Dova.JDK.java.io.DataInput arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantFieldref;)V", "public")]
	public ConstantFieldref(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantFieldref arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/classfile/ConstantFieldref;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V", "public")]
	public void accept(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Visitor arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}