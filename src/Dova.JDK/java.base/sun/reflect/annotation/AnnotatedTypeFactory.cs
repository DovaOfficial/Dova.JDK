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

[JniSignatureAttribute("Lsun/reflect/annotation/AnnotatedTypeFactory;", "public final")]
public partial class AnnotatedTypeFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotatedTypeFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/AnnotatedTypeFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY_TYPE_ANNOTATION_ARRAY", "[Lsun/reflect/annotation/TypeAnnotation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY_ANNOTATED_TYPE", "Ljava/lang/reflect/AnnotatedType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY_ANNOTATED_TYPE_ARRAY", "[Ljava/lang/reflect/AnnotatedType;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotatedTypeFactory", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isArray", "(Ljava/lang/reflect/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "buildAnnotatedType", "(Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "nestingForType", "(Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
	}

	[JniSignatureAttribute("[Lsun/reflect/annotation/TypeAnnotation;", "static final")]
	public static JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> EMPTY_TYPE_ANNOTATION_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedType;", "static final")]
	public static Dova.JDK.java.lang.reflect.AnnotatedType EMPTY_ANNOTATED_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/reflect/AnnotatedType;", "static final")]
	public static JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> EMPTY_ANNOTATED_TYPE_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AnnotatedTypeFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AnnotatedTypeFactory() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/annotation/AnnotatedTypeFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "private static")]
	public static bool isArray(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedType;", "public static")]
	public static Dova.JDK.java.lang.reflect.AnnotatedType buildAnnotatedType(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg1, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg2, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg3, Dova.JDK.java.lang.reflect.AnnotatedElement arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public static")]
	public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo nestingForType(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedArrayTypeImpl;", "private static final")]
	public partial class AnnotatedArrayTypeImpl
		: Dova.JDK.sun.reflect.annotation.AnnotatedTypeFactory.AnnotatedTypeBaseImpl
		, Dova.JDK.java.lang.reflect.AnnotatedArrayType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotatedArrayTypeImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedArrayTypeImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotatedArrayTypeImpl", "(Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getComponentType", "()Ljava/lang/reflect/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedGenericComponentType", "()Ljava/lang/reflect/AnnotatedType;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotatedArrayTypeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V", "")]
		public AnnotatedArrayTypeImpl(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg1, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg2, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg3, Dova.JDK.java.lang.reflect.AnnotatedElement arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedArrayTypeImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "private")]
		public Dova.JDK.java.lang.reflect.Type getComponentType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
		public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedOwnerType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
		public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedGenericComponentType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedTypeBaseImpl;", "private static")]
	public partial class AnnotatedTypeBaseImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.reflect.AnnotatedType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotatedTypeBaseImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedTypeBaseImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type", "Ljava/lang/reflect/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "decl", "Ljava/lang/reflect/AnnotatedElement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "location", "Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "allOnSameTargetTypeAnnotations", "[Lsun/reflect/annotation/TypeAnnotation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "annotations", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotatedTypeBaseImpl", "(Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotations", "()[Ljava/lang/annotation/Annotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDeclaredAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDeclaredAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocation", "()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getType", "()Ljava/lang/reflect/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTypeAnnotations", "()[Lsun/reflect/annotation/TypeAnnotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equalsTypeAndAnnotations", "(Ljava/lang/reflect/AnnotatedType;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "baseHashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "annotationsToString", "([Ljava/lang/annotation/Annotation;Z)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDecl", "()Ljava/lang/reflect/AnnotatedElement;"));
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Type;", "private final")]
		public Dova.JDK.java.lang.reflect.Type type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedElement;", "private final")]
		public Dova.JDK.java.lang.reflect.AnnotatedElement decl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "private final")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo location_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lsun/reflect/annotation/TypeAnnotation;", "private final")]
		public JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> allOnSameTargetTypeAnnotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map annotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotatedTypeBaseImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Type;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V", "")]
		public AnnotatedTypeBaseImpl(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg1, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg2, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg3, Dova.JDK.java.lang.reflect.AnnotatedElement arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedTypeBaseImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "public final")]
		public Dova.JDK.java.lang.Object getAnnotation(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "public final")]
		public JavaArray<Dova.JDK.java.lang.Object> getAnnotationsByType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/annotation/Annotation;", "public final")]
		public JavaArray<Dova.JDK.java.lang.annotation.Annotation> getAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "public final")]
		public Dova.JDK.java.lang.Object getDeclaredAnnotation(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "public final")]
		public JavaArray<Dova.JDK.java.lang.Object> getDeclaredAnnotationsByType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/annotation/Annotation;", "public final")]
		public JavaArray<Dova.JDK.java.lang.annotation.Annotation> getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
		}

		[JniSignatureAttribute("()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "final")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo getLocation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public final")]
		public Dova.JDK.java.lang.reflect.Type getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
		public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedOwnerType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
		}

		[JniSignatureAttribute("()[Lsun/reflect/annotation/TypeAnnotation;", "final")]
		public JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> getTypeAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedType;)Z", "protected")]
		public bool equalsTypeAndAnnotations(Dova.JDK.java.lang.reflect.AnnotatedType arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "")]
		public int baseHashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;Z)Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String annotationsToString(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "final")]
		public Dova.JDK.java.lang.reflect.AnnotatedElement getDecl()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedTypeVariableImpl;", "private static final")]
	public partial class AnnotatedTypeVariableImpl
		: Dova.JDK.sun.reflect.annotation.AnnotatedTypeFactory.AnnotatedTypeBaseImpl
		, Dova.JDK.java.lang.reflect.AnnotatedTypeVariable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotatedTypeVariableImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedTypeVariableImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotatedTypeVariableImpl", "(Ljava/lang/reflect/TypeVariable;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTypeVariable", "()Ljava/lang/reflect/TypeVariable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedBounds", "()[Ljava/lang/reflect/AnnotatedType;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotatedTypeVariableImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/TypeVariable;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V", "")]
		public AnnotatedTypeVariableImpl(Dova.JDK.java.lang.reflect.TypeVariable arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg1, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg2, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg3, Dova.JDK.java.lang.reflect.AnnotatedElement arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedTypeVariableImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
		public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedOwnerType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/TypeVariable;", "private")]
		public Dova.JDK.java.lang.reflect.TypeVariable getTypeVariable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.TypeVariable>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/reflect/AnnotatedType;", "public")]
		public JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedParameterizedTypeImpl;", "private static final")]
	public partial class AnnotatedParameterizedTypeImpl
		: Dova.JDK.sun.reflect.annotation.AnnotatedTypeFactory.AnnotatedTypeBaseImpl
		, Dova.JDK.java.lang.reflect.AnnotatedParameterizedType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotatedParameterizedTypeImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedParameterizedTypeImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotatedParameterizedTypeImpl", "(Ljava/lang/reflect/ParameterizedType;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParameterizedType", "()Ljava/lang/reflect/ParameterizedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedActualTypeArguments", "()[Ljava/lang/reflect/AnnotatedType;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotatedParameterizedTypeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/ParameterizedType;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V", "")]
		public AnnotatedParameterizedTypeImpl(Dova.JDK.java.lang.reflect.ParameterizedType arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg1, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg2, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg3, Dova.JDK.java.lang.reflect.AnnotatedElement arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedParameterizedTypeImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/ParameterizedType;", "private")]
		public Dova.JDK.java.lang.reflect.ParameterizedType getParameterizedType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.ParameterizedType>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
		public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedOwnerType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/reflect/AnnotatedType;", "public")]
		public JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedActualTypeArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedWildcardTypeImpl;", "private static final")]
	public partial class AnnotatedWildcardTypeImpl
		: Dova.JDK.sun.reflect.annotation.AnnotatedTypeFactory.AnnotatedTypeBaseImpl
		, Dova.JDK.java.lang.reflect.AnnotatedWildcardType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotatedWildcardTypeImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedWildcardTypeImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hasUpperBounds", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotatedWildcardTypeImpl", "(Ljava/lang/reflect/WildcardType;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getWildcardType", "()Ljava/lang/reflect/WildcardType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasUpperBounds", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedLowerBounds", "()[Ljava/lang/reflect/AnnotatedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedUpperBounds", "()[Ljava/lang/reflect/AnnotatedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedBounds", "([Ljava/lang/reflect/Type;)[Ljava/lang/reflect/AnnotatedType;"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool hasUpperBounds_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotatedWildcardTypeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/WildcardType;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;[Lsun/reflect/annotation/TypeAnnotation;[Lsun/reflect/annotation/TypeAnnotation;Ljava/lang/reflect/AnnotatedElement;)V", "")]
		public AnnotatedWildcardTypeImpl(Dova.JDK.java.lang.reflect.WildcardType arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg1, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg2, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg3, Dova.JDK.java.lang.reflect.AnnotatedElement arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/reflect/annotation/AnnotatedTypeFactory$AnnotatedWildcardTypeImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
		public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedOwnerType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/WildcardType;", "private")]
		public Dova.JDK.java.lang.reflect.WildcardType getWildcardType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.WildcardType>(ret);
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool hasUpperBounds()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()[Ljava/lang/reflect/AnnotatedType;", "public")]
		public JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedLowerBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/reflect/AnnotatedType;", "public")]
		public JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedUpperBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/reflect/Type;)[Ljava/lang/reflect/AnnotatedType;", "private")]
		public JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedBounds(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
		}
	}
}
