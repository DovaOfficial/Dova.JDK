/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.reflect.annotation;

[JniSignatureAttribute("Lsun/reflect/annotation/AnnotationParser;", "public")]
public partial class AnnotationParser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/AnnotationParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY_ANNOTATIONS_ARRAY", "[Ljava/lang/annotation/Annotation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY_ANNOTATION_ARRAY", "[Ljava/lang/annotation/Annotation;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotationParser", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toArray", "(Ljava/util/Map;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "contains", "([Ljava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toClass", "(Ljava/lang/reflect/Type;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseAnnotations", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseMemberValue", "(Ljava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseParameterAnnotations", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)[[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseSig", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseAnnotations2", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;[Ljava/lang/Class;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseAnnotation2", "(Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;Z[Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseParameterAnnotations2", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)[[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseAnnotation", "(Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;Z)Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "skipAnnotation", "(Ljava/nio/ByteBuffer;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "skipMemberValue", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "skipMemberValue", "(ILjava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "annotationForMap", "(Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseEnumValue", "(Ljava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseClassValue", "(Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseArray", "(Ljava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseConst", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseUnknownArray", "(ILjava/nio/ByteBuffer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseByteArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseCharArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseDoubleArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseFloatArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseIntArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseLongArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseShortArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseBooleanArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseStringArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseClassArray", "(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseEnumArray", "(ILjava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseAnnotationArray", "(ILjava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "exceptionProxy", "(I)Lsun/reflect/annotation/ExceptionProxy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseArrayElements", "([Ljava/lang/Object;Ljava/nio/ByteBuffer;ILjava/util/function/Supplier;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "skipArray", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseSelectAnnotations", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;[Ljava/lang/Class;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getEmptyAnnotationArray", "()[Ljava/lang/annotation/Annotation;"));
	}

	[JniSignatureAttribute("[Ljava/lang/annotation/Annotation;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.annotation.Annotation> EMPTY_ANNOTATIONS_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/annotation/Annotation;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.annotation.Annotation> EMPTY_ANNOTATION_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AnnotationParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AnnotationParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/annotation/AnnotationParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Map;)[Ljava/lang/annotation/Annotation;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.annotation.Annotation> toArray(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/lang/Object;)Z", "private static")]
	public static bool contains(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class toClass(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/util/Map;", "public static")]
	public static Dova.JDK.java.util.Map parseAnnotations(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object parseMemberValue(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)[[Ljava/lang/annotation/Annotation;", "public static")]
	public static JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>> parseParameterAnnotations(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class parseSig(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;[Ljava/lang/Class;)Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map parseAnnotations2(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2, JavaArray<Dova.JDK.java.lang.Class> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;Z[Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "private static")]
	public static Dova.JDK.java.lang.annotation.Annotation parseAnnotation2(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2, bool arg3, JavaArray<Dova.JDK.java.lang.Class> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.annotation.Annotation>(ret);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)[[Ljava/lang/annotation/Annotation;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>> parseParameterAnnotations2(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;Z)Ljava/lang/annotation/Annotation;", "static")]
	public static Dova.JDK.java.lang.annotation.Annotation parseAnnotation(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.annotation.Annotation>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Z)V", "private static")]
	public static void skipAnnotation(Dova.JDK.java.nio.ByteBuffer arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "private static")]
	public static void skipMemberValue(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;)V", "private static")]
	public static void skipMemberValue(int arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/annotation/Annotation;", "public static")]
	public static Dova.JDK.java.lang.annotation.Annotation annotationForMap(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.annotation.Annotation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseEnumValue(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseClassValue(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseArray(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseConst(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseUnknownArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseByteArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseCharArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseDoubleArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseFloatArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseIntArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseLongArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseShortArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseBooleanArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseStringArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseClassArray(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.jdk.@internal.reflect.ConstantPool arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseEnumArray(int arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.nio.ByteBuffer arg2, Dova.JDK.jdk.@internal.reflect.ConstantPool arg3, Dova.JDK.java.lang.Class arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Class;Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseAnnotationArray(int arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.nio.ByteBuffer arg2, Dova.JDK.jdk.@internal.reflect.ConstantPool arg3, Dova.JDK.java.lang.Class arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/reflect/annotation/ExceptionProxy;", "private static")]
	public static Dova.JDK.sun.reflect.annotation.ExceptionProxy exceptionProxy(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.ExceptionProxy>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/nio/ByteBuffer;ILjava/util/function/Supplier;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object parseArrayElements(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.nio.ByteBuffer arg1, int arg2, Dova.JDK.java.util.function.Supplier arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "private static")]
	public static void skipArray(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;[Ljava/lang/Class;)Ljava/util/Map;", "static transient")]
	public static Dova.JDK.java.util.Map parseSelectAnnotations(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2, JavaArray<Dova.JDK.java.lang.Class> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/annotation/Annotation;", "static")]
	public static JavaArray<Dova.JDK.java.lang.annotation.Annotation> getEmptyAnnotationArray()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
	}
}
