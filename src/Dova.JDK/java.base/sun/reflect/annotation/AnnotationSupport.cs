/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.reflect.annotation;

[JniSignatureAttribute("Lsun/reflect/annotation/AnnotationSupport;", "public final")]
public partial class AnnotationSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationSupport()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/reflect/annotation/AnnotationSupport;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LANG_ACCESS", "Ljdk/internal/access/JavaLangAccess;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AnnotationSupport", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAssociatedAnnotations", "(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getDirectlyAndIndirectlyPresent", "(Ljava/util/Map;Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getIndirectlyPresent", "(Ljava/util/Map;Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "containerBeforeContainee", "(Ljava/util/Map;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getValueArray", "(Ljava/lang/annotation/Annotation;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "checkTypes", "([Ljava/lang/annotation/Annotation;Ljava/lang/annotation/Annotation;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "invalidContainerException", "(Ljava/lang/annotation/Annotation;Ljava/lang/Throwable;)Ljava/lang/annotation/AnnotationFormatError;"));
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangAccess;", "private static final")]
	public static Dova.JDK.jdk.@internal.access.JavaLangAccess LANG_ACCESS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangAccess>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AnnotationSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AnnotationSupport() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/annotation/AnnotationSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.Object> getAssociatedAnnotations(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.Object> getDirectlyAndIndirectlyPresent(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.Object> getIndirectlyPresent(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/Class;)Z", "private static")]
	public static bool containerBeforeContainee(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;)[Ljava/lang/annotation/Annotation;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.Object> getValueArray(Dova.JDK.java.lang.annotation.Annotation arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;Ljava/lang/annotation/Annotation;Ljava/lang/Class;)V", "private static")]
	public static void checkTypes(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.annotation.Annotation arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;Ljava/lang/Throwable;)Ljava/lang/annotation/AnnotationFormatError;", "private static")]
	public static Dova.JDK.java.lang.annotation.AnnotationFormatError invalidContainerException(Dova.JDK.java.lang.annotation.Annotation arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.annotation.AnnotationFormatError>(ret);
	}
}
