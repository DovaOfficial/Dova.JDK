/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotationParser;", "public final")]
public partial class TypeAnnotationParser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeAnnotationParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/TypeAnnotationParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY_TYPE_ANNOTATION_ARRAY", "[Lsun/reflect/annotation/TypeAnnotation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_TYPE_PARAMETER", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_TYPE_PARAMETER", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_EXTENDS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_TYPE_PARAMETER_BOUND", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_TYPE_PARAMETER_BOUND", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FIELD", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_RETURN", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_RECEIVER", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_FORMAL_PARAMETER", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "THROWS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOCAL_VARIABLE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RESOURCE_VARIABLE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXCEPTION_PARAMETER", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSTANCEOF", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEW", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTRUCTOR_REFERENCE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_REFERENCE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CAST", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTRUCTOR_INVOCATION_TYPE_ARGUMENT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_INVOCATION_TYPE_ARGUMENT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTRUCTOR_REFERENCE_TYPE_ARGUMENT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_REFERENCE_TYPE_ARGUMENT", "B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypeAnnotationParser", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "buildAnnotatedSuperclass", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "buildAnnotatedInterfaces", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)[Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "buildAnnotatedType", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/Class;Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;)Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "buildAnnotatedTypes", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/Class;[Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;)[Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "mapTypeAnnotations", "([Lsun/reflect/annotation/TypeAnnotation;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseTypeAnnotations", "([BLjdk/internal/reflect/ConstantPool;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/Class;)[Lsun/reflect/annotation/TypeAnnotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseAllTypeAnnotations", "(Ljava/lang/reflect/AnnotatedElement;)[Lsun/reflect/annotation/TypeAnnotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fetchBounds", "(Ljava/lang/reflect/GenericDeclaration;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseTypeAnnotation", "(Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/Class;)Lsun/reflect/annotation/TypeAnnotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseTargetInfo", "(Ljava/nio/ByteBuffer;)Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parse2ByteTarget", "(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;Ljava/nio/ByteBuffer;)Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseShortTarget", "(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;Ljava/nio/ByteBuffer;)Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseTypeVariableAnnotations", "(Ljava/lang/reflect/GenericDeclaration;I)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseAnnotatedBounds", "([Ljava/lang/reflect/Type;Ljava/lang/reflect/GenericDeclaration;I)[Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseAnnotatedBounds", "([Ljava/lang/reflect/Type;Ljava/lang/reflect/GenericDeclaration;ILsun/reflect/annotation/TypeAnnotation$LocationInfo;)[Ljava/lang/reflect/AnnotatedType;"));
	}

	[JniSignatureAttribute("[Lsun/reflect/annotation/TypeAnnotation;", "private static final")]
	public static JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> EMPTY_TYPE_ANNOTATION_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte CLASS_TYPE_PARAMETER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte METHOD_TYPE_PARAMETER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte CLASS_EXTENDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte CLASS_TYPE_PARAMETER_BOUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte METHOD_TYPE_PARAMETER_BOUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte METHOD_RETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte METHOD_RECEIVER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte METHOD_FORMAL_PARAMETER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte THROWS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte LOCAL_VARIABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte RESOURCE_VARIABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte EXCEPTION_PARAMETER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte INSTANCEOF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte NEW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte CONSTRUCTOR_REFERENCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[16], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte METHOD_REFERENCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[17], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte CAST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[18], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte CONSTRUCTOR_INVOCATION_TYPE_ARGUMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[19], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte METHOD_INVOCATION_TYPE_ARGUMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[20], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte CONSTRUCTOR_REFERENCE_TYPE_ARGUMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[21], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte METHOD_REFERENCE_TYPE_ARGUMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[22], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeAnnotationParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public TypeAnnotationParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/annotation/TypeAnnotationParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)Ljava/lang/reflect/AnnotatedType;", "public static")]
	public static Dova.JDK.java.lang.reflect.AnnotatedType buildAnnotatedSuperclass(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/Class;)[Ljava/lang/reflect/AnnotatedType;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> buildAnnotatedInterfaces(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/Class;Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;)Ljava/lang/reflect/AnnotatedType;", "public static")]
	public static Dova.JDK.java.lang.reflect.AnnotatedType buildAnnotatedType(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.reflect.AnnotatedElement arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.java.lang.reflect.Type arg4, Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/Class;[Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;)[Ljava/lang/reflect/AnnotatedType;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> buildAnnotatedTypes(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.reflect.AnnotatedElement arg2, Dova.JDK.java.lang.Class arg3, JavaArray<Dova.JDK.java.lang.reflect.Type> arg4, Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
	}

	[JniSignatureAttribute("([Lsun/reflect/annotation/TypeAnnotation;)Ljava/util/Map;", "static")]
	public static Dova.JDK.java.util.Map mapTypeAnnotations(JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("([BLjdk/internal/reflect/ConstantPool;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/Class;)[Lsun/reflect/annotation/TypeAnnotation;", "private static")]
	public static JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> parseTypeAnnotations(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.reflect.AnnotatedElement arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)[Lsun/reflect/annotation/TypeAnnotation;", "static")]
	public static JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> parseAllTypeAnnotations(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/GenericDeclaration;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List fetchBounds(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/reflect/ConstantPool;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/Class;)Lsun/reflect/annotation/TypeAnnotation;", "private static")]
	public static Dova.JDK.sun.reflect.annotation.TypeAnnotation parseTypeAnnotation(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.reflect.ConstantPool arg1, Dova.JDK.java.lang.reflect.AnnotatedElement arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;", "private static")]
	public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo parseTargetInfo(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;Ljava/nio/ByteBuffer;)Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;", "private static")]
	public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo parse2ByteTarget(Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;Ljava/nio/ByteBuffer;)Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;", "private static")]
	public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo parseShortTarget(Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/GenericDeclaration;I)[Ljava/lang/annotation/Annotation;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.annotation.Annotation> parseTypeVariableAnnotations(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Type;Ljava/lang/reflect/GenericDeclaration;I)[Ljava/lang/reflect/AnnotatedType;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> parseAnnotatedBounds(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Type;Ljava/lang/reflect/GenericDeclaration;ILsun/reflect/annotation/TypeAnnotation$LocationInfo;)[Ljava/lang/reflect/AnnotatedType;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> parseAnnotatedBounds(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
	}
}
