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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/Visitor;", "public abstract interface")]
public partial interface Visitor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Visitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/classfile/Visitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitField", "(Lcom/sun/org/apache/bcel/internal/classfile/Field;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Lcom/sun/org/apache/bcel/internal/classfile/Annotations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(Lcom/sun/org/apache/bcel/internal/classfile/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCode", "(Lcom/sun/org/apache/bcel/internal/classfile/Code;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "(Lcom/sun/org/apache/bcel/internal/classfile/AnnotationDefault;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterAnnotation", "(Lcom/sun/org/apache/bcel/internal/classfile/ParameterAnnotations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariable", "(Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLineNumber", "(Lcom/sun/org/apache/bcel/internal/classfile/LineNumber;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestHost", "(Lcom/sun/org/apache/bcel/internal/classfile/NestHost;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClass", "(Lcom/sun/org/apache/bcel/internal/classfile/InnerClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/org/apache/bcel/internal/classfile/Module;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantPool", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantClass", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantDouble", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantDouble;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantFieldref", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantFieldref;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantFloat", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantFloat;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantInteger", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantInteger;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantInterfaceMethodref", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantInterfaceMethodref;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantInvokeDynamic", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantInvokeDynamic;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantLong", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantLong;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantMethodref", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantMethodref;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantString", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantString;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantUtf8", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantUtf8;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantValue", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDeprecated", "(Lcom/sun/org/apache/bcel/internal/classfile/Deprecated;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExceptionTable", "(Lcom/sun/org/apache/bcel/internal/classfile/ExceptionTable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClasses", "(Lcom/sun/org/apache/bcel/internal/classfile/InnerClasses;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLineNumberTable", "(Lcom/sun/org/apache/bcel/internal/classfile/LineNumberTable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitJavaClass", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantNameAndType", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantNameAndType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableTable", "(Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSignature", "(Lcom/sun/org/apache/bcel/internal/classfile/Signature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSourceFile", "(Lcom/sun/org/apache/bcel/internal/classfile/SourceFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSynthetic", "(Lcom/sun/org/apache/bcel/internal/classfile/Synthetic;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknown", "(Lcom/sun/org/apache/bcel/internal/classfile/Unknown;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStackMap", "(Lcom/sun/org/apache/bcel/internal/classfile/StackMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStackMapEntry", "(Lcom/sun/org/apache/bcel/internal/classfile/StackMapEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationEntry", "(Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableTypeTable", "(Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTypeTable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnclosingMethod", "(Lcom/sun/org/apache/bcel/internal/classfile/EnclosingMethod;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBootstrapMethods", "(Lcom/sun/org/apache/bcel/internal/classfile/BootstrapMethods;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodParameters", "(Lcom/sun/org/apache/bcel/internal/classfile/MethodParameters;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodParameter", "(Lcom/sun/org/apache/bcel/internal/classfile/MethodParameter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantMethodType", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantMethodType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantMethodHandle", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantMethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterAnnotationEntry", "(Lcom/sun/org/apache/bcel/internal/classfile/ParameterAnnotationEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantPackage", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPackage;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantModule", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantModule;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantDynamic", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantDynamic;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleRequires", "(Lcom/sun/org/apache/bcel/internal/classfile/ModuleRequires;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleExports", "(Lcom/sun/org/apache/bcel/internal/classfile/ModuleExports;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleOpens", "(Lcom/sun/org/apache/bcel/internal/classfile/ModuleOpens;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleProvides", "(Lcom/sun/org/apache/bcel/internal/classfile/ModuleProvides;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModulePackages", "(Lcom/sun/org/apache/bcel/internal/classfile/ModulePackages;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleMainClass", "(Lcom/sun/org/apache/bcel/internal/classfile/ModuleMainClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestMembers", "(Lcom/sun/org/apache/bcel/internal/classfile/NestMembers;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCodeException", "(Lcom/sun/org/apache/bcel/internal/classfile/CodeException;)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Field;)V", "public abstract")]
	void visitField(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Field arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Annotations;)V", "public abstract")]
	void visitAnnotation(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Annotations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Method;)V", "public abstract")]
	void visitMethod(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Method arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Code;)V", "public abstract")]
	void visitCode(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Code arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/AnnotationDefault;)V", "public abstract")]
	void visitAnnotationDefault(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationDefault arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ParameterAnnotations;)V", "public abstract")]
	void visitParameterAnnotation(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ParameterAnnotations arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/LocalVariable;)V", "public abstract")]
	void visitLocalVariable(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/LineNumber;)V", "public abstract")]
	void visitLineNumber(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LineNumber arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/NestHost;)V", "public")]
	void visitNestHost(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.NestHost arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/InnerClass;)V", "public abstract")]
	void visitInnerClass(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.InnerClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Module;)V", "public")]
	void visitModule(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Module arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "public abstract")]
	void visitConstantPool(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantClass;)V", "public abstract")]
	void visitConstantClass(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantDouble;)V", "public abstract")]
	void visitConstantDouble(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantDouble arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantFieldref;)V", "public abstract")]
	void visitConstantFieldref(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantFieldref arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantFloat;)V", "public abstract")]
	void visitConstantFloat(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantFloat arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantInteger;)V", "public abstract")]
	void visitConstantInteger(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantInteger arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantInterfaceMethodref;)V", "public abstract")]
	void visitConstantInterfaceMethodref(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantInterfaceMethodref arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantInvokeDynamic;)V", "public abstract")]
	void visitConstantInvokeDynamic(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantInvokeDynamic arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantLong;)V", "public abstract")]
	void visitConstantLong(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantLong arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantMethodref;)V", "public abstract")]
	void visitConstantMethodref(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantMethodref arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantString;)V", "public abstract")]
	void visitConstantString(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantString arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantUtf8;)V", "public abstract")]
	void visitConstantUtf8(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantUtf8 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantValue;)V", "public abstract")]
	void visitConstantValue(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Deprecated;)V", "public abstract")]
	void visitDeprecated(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Deprecated arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ExceptionTable;)V", "public abstract")]
	void visitExceptionTable(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ExceptionTable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/InnerClasses;)V", "public abstract")]
	void visitInnerClasses(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.InnerClasses arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/LineNumberTable;)V", "public abstract")]
	void visitLineNumberTable(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LineNumberTable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)V", "public abstract")]
	void visitJavaClass(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantNameAndType;)V", "public abstract")]
	void visitConstantNameAndType(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantNameAndType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTable;)V", "public abstract")]
	void visitLocalVariableTable(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariableTable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Signature;)V", "public abstract")]
	void visitSignature(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Signature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/SourceFile;)V", "public abstract")]
	void visitSourceFile(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.SourceFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Synthetic;)V", "public abstract")]
	void visitSynthetic(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Synthetic arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Unknown;)V", "public abstract")]
	void visitUnknown(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Unknown arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/StackMap;)V", "public abstract")]
	void visitStackMap(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.StackMap arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/StackMapEntry;)V", "public abstract")]
	void visitStackMapEntry(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.StackMapEntry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;)V", "public abstract")]
	void visitAnnotationEntry(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/LocalVariableTypeTable;)V", "public abstract")]
	void visitLocalVariableTypeTable(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.LocalVariableTypeTable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/EnclosingMethod;)V", "public abstract")]
	void visitEnclosingMethod(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.EnclosingMethod arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/BootstrapMethods;)V", "public abstract")]
	void visitBootstrapMethods(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.BootstrapMethods arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/MethodParameters;)V", "public abstract")]
	void visitMethodParameters(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.MethodParameters arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/MethodParameter;)V", "public")]
	void visitMethodParameter(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.MethodParameter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantMethodType;)V", "public abstract")]
	void visitConstantMethodType(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantMethodType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantMethodHandle;)V", "public abstract")]
	void visitConstantMethodHandle(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantMethodHandle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ParameterAnnotationEntry;)V", "public abstract")]
	void visitParameterAnnotationEntry(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ParameterAnnotationEntry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPackage;)V", "public abstract")]
	void visitConstantPackage(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPackage arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantModule;)V", "public abstract")]
	void visitConstantModule(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantModule arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantDynamic;)V", "public")]
	void visitConstantDynamic(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantDynamic arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ModuleRequires;)V", "public")]
	void visitModuleRequires(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ModuleRequires arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ModuleExports;)V", "public")]
	void visitModuleExports(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ModuleExports arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ModuleOpens;)V", "public")]
	void visitModuleOpens(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ModuleOpens arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ModuleProvides;)V", "public")]
	void visitModuleProvides(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ModuleProvides arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ModulePackages;)V", "public")]
	void visitModulePackages(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ModulePackages arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ModuleMainClass;)V", "public")]
	void visitModuleMainClass(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ModuleMainClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/NestMembers;)V", "public")]
	void visitNestMembers(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.NestMembers arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/CodeException;)V", "public abstract")]
	void visitCodeException(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.CodeException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}
}
