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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/ClassElementValueGen;", "public")]
public partial class ClassElementValueGen
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ElementValueGen
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassElementValueGen()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/ClassElementValueGen;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "idx", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/classfile/ClassElementValue;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/generic/ObjectType;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementValue", "()Lcom/sun/org/apache/bcel/internal/classfile/ElementValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringifyValue", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("I", "private")]
	public int idx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassElementValueGen(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ClassElementValue;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)V", "public")]
	public ClassElementValueGen(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ClassElementValue arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ObjectType;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V", "public")]
	public ClassElementValueGen(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ObjectType arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V", "protected")]
	public ClassElementValueGen(int arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/ClassElementValueGen;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int getIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/classfile/ElementValue;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ElementValue getElementValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ElementValue>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "public")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getClassString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String stringifyValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
