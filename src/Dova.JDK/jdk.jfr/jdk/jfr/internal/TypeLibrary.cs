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

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/TypeLibrary;", "public final")]
public partial class TypeLibrary
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeLibrary()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/TypeLibrary;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Ljdk/jfr/internal/TypeLibrary;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "implicitFieldTypes", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "types", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DURATION_FIELD", "Ljdk/jfr/ValueDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD_FIELD", "Ljdk/jfr/ValueDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STACK_TRACE_FIELD", "Ljdk/jfr/ValueDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START_TIME_FIELD", "Ljdk/jfr/ValueDescriptor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Ljdk/jfr/internal/TypeLibrary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getType", "(Ljava/lang/Class;)Ljdk/jfr/internal/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDefined", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTypes", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addType", "(Ljdk/jfr/internal/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearUnregistered", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeType", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createType", "(Ljava/lang/Class;)Ljdk/jfr/internal/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createType", "(Ljava/lang/Class;Ljava/util/List;Ljava/util/List;)Ljdk/jfr/internal/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createAnnotation", "(Ljava/lang/annotation/Annotation;)Ljdk/jfr/AnnotationElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "visitReachable", "(Ljava/util/Collection;Ljava/util/function/Predicate;Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createStandardAnnotations", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "shouldPersist", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "defineType", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljdk/jfr/internal/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolveRepeatedAnnotations", "([Ljava/lang/annotation/Annotation;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createAnnotationType", "(Ljava/lang/Class;)Ljdk/jfr/internal/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeAnnotation", "(Ljava/lang/annotation/Annotation;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addImplicitFields", "(Ljdk/jfr/internal/Type;ZZZZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addUserFields", "(Ljava/lang/Class;Ljdk/jfr/internal/Type;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addAnnotations", "(Ljava/lang/Class;Ljdk/jfr/internal/Type;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createField", "(Ljava/lang/reflect/Field;)Ljdk/jfr/ValueDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addFields", "(Ljdk/jfr/internal/Type;ZZZZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "visitAnnotations", "(Ljava/util/Queue;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDurationField", "()Ljdk/jfr/ValueDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createThreadField", "()Ljdk/jfr/ValueDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createStackTraceField", "()Ljdk/jfr/ValueDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createStartTimeField", "()Ljdk/jfr/ValueDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibleTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypes", "()Ljava/util/Collection;"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/TypeLibrary;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.TypeLibrary instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.TypeLibrary>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool implicitFieldTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/ValueDescriptor;", "static final")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor DURATION_FIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/ValueDescriptor;", "static final")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor THREAD_FIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/ValueDescriptor;", "static final")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor STACK_TRACE_FIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/ValueDescriptor;", "static final")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor START_TIME_FIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeLibrary(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public TypeLibrary(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/TypeLibrary;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jfr/internal/TypeLibrary;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.TypeLibrary getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.TypeLibrary>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/jfr/internal/Type;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.Type getType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private static")]
	public static bool isDefined(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public static")]
	public static void addTypes(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;)V", "public")]
	public void addType(Dova.JDK.jdk.jfr.@internal.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool clearUnregistered()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void removeType(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/jfr/internal/Type;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.Type createType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/List;Ljava/util/List;)Ljdk/jfr/internal/Type;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.Type createType(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;)Ljdk/jfr/AnnotationElement;", "static")]
	public static Dova.JDK.jdk.jfr.AnnotationElement createAnnotation(Dova.JDK.java.lang.annotation.Annotation arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.AnnotationElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Ljava/util/function/Predicate;Ljava/util/function/Consumer;)V", "private static")]
	public static void visitReachable(Dova.JDK.java.util.Collection arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.java.util.function.Consumer arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List createStandardAnnotations(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private static")]
	public static bool shouldPersist(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Z)Ljdk/jfr/internal/Type;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.Type defineType(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List resolveRepeatedAnnotations(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/jfr/internal/Type;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.Type createAnnotationType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;Ljava/lang/String;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object invokeAnnotation(Dova.JDK.java.lang.annotation.Annotation arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;ZZZZZ)V", "static")]
	public static void addImplicitFields(Dova.JDK.jdk.jfr.@internal.Type arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljdk/jfr/internal/Type;Ljava/util/List;)V", "private static")]
	public static void addUserFields(Dova.JDK.java.lang.Class arg0, Dova.JDK.jdk.jfr.@internal.Type arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljdk/jfr/internal/Type;Ljava/util/List;)V", "private static")]
	public static void addAnnotations(Dova.JDK.java.lang.Class arg0, Dova.JDK.jdk.jfr.@internal.Type arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljdk/jfr/ValueDescriptor;", "private static")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor createField(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;ZZZZZ)V", "private static")]
	public static void addFields(Dova.JDK.jdk.jfr.@internal.Type arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/util/Queue;Ljava/util/List;)V", "private static")]
	public static void visitAnnotations(Dova.JDK.java.util.Queue arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/jfr/ValueDescriptor;", "private static")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor createDurationField()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/ValueDescriptor;", "private static")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor createThreadField()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/ValueDescriptor;", "private static")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor createStackTraceField()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/ValueDescriptor;", "private static")]
	public static Dova.JDK.jdk.jfr.ValueDescriptor createStartTimeField()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getVisibleTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection getTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}
}
