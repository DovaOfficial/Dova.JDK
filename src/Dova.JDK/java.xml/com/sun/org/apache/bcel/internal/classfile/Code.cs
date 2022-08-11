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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/Code;", "public final")]
public partial class Code
	: Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Code()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/classfile/Code;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxStack", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxLocals", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "code", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionTable", "[Lcom/sun/org/apache/bcel/internal/classfile/CodeException;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributes", "[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIII[B[Lcom/sun/org/apache/bcel/internal/classfile/CodeException;[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/classfile/Code;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMaxStack", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCode", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMaxLocals", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxLocals", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxStack", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCode", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExceptionTable", "([Lcom/sun/org/apache/bcel/internal/classfile/CodeException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTable", "()[Lcom/sun/org/apache/bcel/internal/classfile/CodeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineNumberTable", "()Lcom/sun/org/apache/bcel/internal/classfile/LineNumberTable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalVariableTable", "()Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributes", "([Lcom/sun/org/apache/bcel/internal/classfile/Attribute;)V"));
	}

	[JniSignatureAttribute("I", "private")]
	public int maxStack_Property
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

	[JniSignatureAttribute("I", "private")]
	public int maxLocals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> code_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/bcel/internal/classfile/CodeException;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.CodeException> exceptionTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.CodeException>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute> attributes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Code(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IIII[B[Lcom/sun/org/apache/bcel/internal/classfile/CodeException;[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "public")]
	public Code(int arg0, int arg1, int arg2, int arg3, JavaArray<byte> arg4, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.CodeException> arg5, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute> arg6, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(IILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "")]
	public Code(int arg0, int arg1, Dova.JDK.java.io.DataInput arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Code;)V", "public")]
	public Code(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Code arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/classfile/Code;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V", "public")]
	public void accept(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Visitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute copy(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute> getAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMaxStack(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "public")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getCode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMaxLocals(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaxLocals()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaxStack()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int calculateLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int getInternalLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("([B)V", "public")]
	public void setCode(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/bcel/internal/classfile/CodeException;)V", "public")]
	public void setExceptionTable(JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.CodeException> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/bcel/internal/classfile/CodeException;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.CodeException> getExceptionTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.CodeException>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/classfile/LineNumberTable;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LineNumberTable getLineNumberTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LineNumberTable>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTable;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariableTable getLocalVariableTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariableTable>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/bcel/internal/classfile/Attribute;)V", "public")]
	public void setAttributes(JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}
}
