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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.generic;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/InvokeInstruction;", "public abstract")]
public partial class InvokeInstruction
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FieldOrMethod
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ExceptionThrower
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StackConsumer
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StackProducer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InvokeInstruction()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/InvokeInstruction;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(SI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)Lcom/sun/org/apache/bcel/internal/generic/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)Lcom/sun/org/apache/bcel/internal/generic/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassName", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodName", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgumentTypes", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)[Lcom/sun/org/apache/bcel/internal/generic/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consumeStack", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "produceStack", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InvokeInstruction(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public InvokeInstruction() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(SI)V", "protected")]
	public InvokeInstruction(short arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/InvokeInstruction;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)Lcom/sun/org/apache/bcel/internal/generic/Type;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type getReturnType(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)Lcom/sun/org/apache/bcel/internal/generic/Type;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type getType(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getClassName(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getMethodName(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)[Lcom/sun/org/apache/bcel/internal/generic/Type;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type> getArgumentTypes(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)I", "public")]
	public int consumeStack(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)I", "public")]
	public int produceStack(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}
}
