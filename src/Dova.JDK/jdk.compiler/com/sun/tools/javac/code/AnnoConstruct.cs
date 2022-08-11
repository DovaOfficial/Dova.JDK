/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.code;

[JniSignatureAttribute("Lcom/sun/tools/javac/code/AnnoConstruct;", "public abstract")]
public partial class AnnoConstruct
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.lang.model.AnnotatedConstruct
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnoConstruct()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/AnnoConstruct;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljava/lang/Class;)Lcom/sun/tools/javac/code/Attribute$Compound;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInheritedAnnotations", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unpackContained", "(Lcom/sun/tools/javac/code/Attribute$Compound;)[Lcom/sun/tools/javac/code/Attribute$Compound;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unpackAttributes", "(Lcom/sun/tools/javac/code/Attribute$Compound;)[Lcom/sun/tools/javac/code/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getContainer", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors_0", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors_1", "()Lcom/sun/tools/javac/util/List;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AnnoConstruct(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AnnoConstruct() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/AnnoConstruct;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "public")]
	public Dova.JDK.java.lang.Object getAnnotation(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getAnnotationsByType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/tools/javac/code/Attribute$Compound;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Attribute.Compound getAttribute(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Attribute.Compound>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "protected")]
	public JavaArray<Dova.JDK.java.lang.Object> getInheritedAnnotations(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Compound;)[Lcom/sun/tools/javac/code/Attribute$Compound;", "private")]
	public JavaArray<Dova.JDK.com.sun.tools.javac.code.Attribute.Compound> unpackContained(Dova.JDK.com.sun.tools.javac.code.Attribute.Compound arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Attribute.Compound>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Compound;)[Lcom/sun/tools/javac/code/Attribute;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Attribute> unpackAttributes(Dova.JDK.com.sun.tools.javac.code.Attribute.Compound arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Attribute>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class getContainer(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
	public Dova.JDK.java.util.List getAnnotationMirrors_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public abstract")]
	public Dova.JDK.com.sun.tools.javac.util.List getAnnotationMirrors_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}
}
