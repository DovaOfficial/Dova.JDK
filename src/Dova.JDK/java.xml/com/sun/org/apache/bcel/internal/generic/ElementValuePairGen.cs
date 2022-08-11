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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/ElementValuePairGen;", "public")]
public partial class ElementValuePairGen
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ElementValuePairGen()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/ElementValuePairGen;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameIdx", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Lcom/sun/org/apache/bcel/internal/generic/ElementValueGen;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantPoolGen", "Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/ElementValueGen;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILcom/sun/org/apache/bcel/internal/generic/ElementValueGen;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/classfile/ElementValuePair;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()Lcom/sun/org/apache/bcel/internal/generic/ElementValueGen;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementNameValuePair", "()Lcom/sun/org/apache/bcel/internal/classfile/ElementValuePair;"));
	}

	[JniSignatureAttribute("I", "private")]
	public int nameIdx_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/ElementValueGen;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ElementValueGen value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ElementValueGen>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen constantPoolGen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ElementValuePairGen(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/ElementValueGen;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V", "public")]
	public ElementValuePairGen(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ElementValueGen arg1, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/bcel/internal/generic/ElementValueGen;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V", "protected")]
	public ElementValuePairGen(int arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ElementValueGen arg1, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ElementValuePair;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)V", "public")]
	public ElementValuePairGen(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ElementValuePair arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/ElementValuePairGen;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/ElementValueGen;", "public final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ElementValueGen getValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ElementValueGen>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getNameString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNameIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "protected")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/classfile/ElementValuePair;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ElementValuePair getElementNameValuePair()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ElementValuePair>(ret);
	}
}
