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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTypeTable;", "public")]
public partial class LocalVariableTypeTable
	: Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LocalVariableTypeTable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTypeTable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localVariableTypeTable", "[Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II[Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTypeTable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocalVariableTable", "([Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalVariable", "(I)Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalVariableTypeTable", "()[Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;"));
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable> localVariableTypeTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LocalVariableTypeTable(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "")]
	public LocalVariableTypeTable(int arg0, int arg1, Dova.JDK.java.io.DataInput arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(II[Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "public")]
	public LocalVariableTypeTable(int arg0, int arg1, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable> arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTypeTable;)V", "public")]
	public LocalVariableTypeTable(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariableTypeTable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTypeTable;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V", "public")]
	public void accept(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Visitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute copy(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getTableLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;)V", "public final")]
	public void setLocalVariableTable(JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "public final")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;", "public final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable getLocalVariable(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;", "public final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable> getLocalVariableTypeTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable>>(ret);
	}
}
