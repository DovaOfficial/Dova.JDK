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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/Annotations;", "public abstract")]
public partial class Annotations
	: Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Annotations()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/classfile/Annotations;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTable", "[Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isRuntimeVisible", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(BIILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(BII[Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRuntimeVisible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAnnotationTable", "([Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumAnnotations", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeAnnotations", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationEntries", "()[Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;"));
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry> annotationTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool isRuntimeVisible_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Annotations(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(BIILjava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;Z)V", "")]
	public Annotations(byte arg0, int arg1, int arg2, Dova.JDK.java.io.DataInput arg3, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(BII[Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;Z)V", "public")]
	public Annotations(byte arg0, int arg1, int arg2, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry> arg3, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/classfile/Annotations;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V", "public")]
	public void accept(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Visitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRuntimeVisible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;)V", "public final")]
	public void setAnnotationTable(JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getNumAnnotations()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "protected")]
	public void writeAnnotations(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry> getAnnotationEntries()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry>>(ret);
	}
}
