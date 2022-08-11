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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/SourceFile;", "public final")]
public partial class SourceFile
	: Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SourceFile()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/classfile/SourceFile;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceFileIndex", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIILcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/classfile/SourceFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceFileIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSourceFileIndex", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceFileName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceFileIndex_Property
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
	public SourceFile(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IIILcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "public")]
	public SourceFile(int arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(IILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "")]
	public SourceFile(int arg0, int arg1, Dova.JDK.java.io.DataInput arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/SourceFile;)V", "public")]
	public SourceFile(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.SourceFile arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/classfile/SourceFile;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
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

	[JniSignatureAttribute("()I", "public")]
	public int getSourceFileIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setSourceFileIndex(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSourceFileName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "public")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
