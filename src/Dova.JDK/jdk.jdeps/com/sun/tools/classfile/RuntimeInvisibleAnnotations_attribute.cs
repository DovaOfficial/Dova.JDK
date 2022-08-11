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

namespace Dova.JDK.com.sun.tools.classfile;

[JniSignatureAttribute("Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;", "public")]
public partial class RuntimeInvisibleAnnotations_attribute
	: Dova.JDK.com.sun.tools.classfile.RuntimeAnnotations_attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RuntimeInvisibleAnnotations_attribute()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Lcom/sun/tools/classfile/Annotation;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/classfile/ConstantPool;[Lcom/sun/tools/classfile/Annotation;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/classfile/ClassReader;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/classfile/Attribute$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RuntimeInvisibleAnnotations_attribute(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I[Lcom/sun/tools/classfile/Annotation;)V", "public")]
	public RuntimeInvisibleAnnotations_attribute(int arg0, JavaArray<Dova.JDK.com.sun.tools.classfile.Annotation> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;[Lcom/sun/tools/classfile/Annotation;)V", "public")]
	public RuntimeInvisibleAnnotations_attribute(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, JavaArray<Dova.JDK.com.sun.tools.classfile.Annotation> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;II)V", "")]
	public RuntimeInvisibleAnnotations_attribute(Dova.JDK.com.sun.tools.classfile.ClassReader arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attribute$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.Attribute.Visitor arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
