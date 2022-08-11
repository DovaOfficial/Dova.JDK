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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.classfile;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/RuntimeVisibleParameterAnnotations;", "public")]
public partial class RuntimeVisibleParameterAnnotations
	: Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ParameterAnnotations
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RuntimeVisibleParameterAnnotations()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/classfile/RuntimeVisibleParameterAnnotations;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RuntimeVisibleParameterAnnotations(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "public")]
	public RuntimeVisibleParameterAnnotations(int arg0, int arg1, Dova.JDK.java.io.DataInput arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/classfile/RuntimeVisibleParameterAnnotations;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
