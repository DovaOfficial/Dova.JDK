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

namespace Dova.JDK.jdk.@internal.reflect;

[JniSignatureAttribute("Ljdk/internal/reflect/ReflectionFactory;", "public")]
public partial class ReflectionFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReflectionFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/ReflectionFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "initted", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "soleInstance", "Ljdk/internal/reflect/ReflectionFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "hasStaticInitializerMethod", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "noInflation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "inflationThreshold", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_MH_ACCESSOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_MH_ACCESSOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_MH_ACCESSORS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "useDirectMethodHandle", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "useNativeAccessorOnly", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "disableSerialConstructorChecks", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "langReflectAccess", "Ljdk/internal/access/JavaLangReflectAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getReflectionFactory", "()Ljdk/internal/reflect/ReflectionFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyConstructor", "(Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExecutableSharedParameterTypes", "(Ljava/lang/reflect/Executable;)[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyMethod", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyField", "(Ljava/lang/reflect/Field;)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExecutableTypeAnnotationBytes", "(Ljava/lang/reflect/Executable;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFieldAccessor", "(Ljava/lang/reflect/Field;Z)Ljdk/internal/reflect/FieldAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newMethodAccessor", "(Ljava/lang/reflect/Method;Z)Ljdk/internal/reflect/MethodAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorAccessor", "(Ljava/lang/reflect/Constructor;)Ljdk/internal/reflect/ConstructorAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConstructorAccessor", "(Ljava/lang/reflect/Constructor;)Ljdk/internal/reflect/ConstructorAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConstructorAccessor", "(Ljava/lang/reflect/Constructor;Ljdk/internal/reflect/ConstructorAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inflationThreshold", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateConstructor", "(Ljava/lang/Class;Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConstructor", "(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Class;IILjava/lang/String;[B[B)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leafCopyMethod", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkInitted", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "useFieldHandleAccessor", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "useMethodHandleAccessor", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noInflation", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generateMethodAccessor", "(Ljava/lang/reflect/Method;)Ljdk/internal/reflect/MethodAccessorImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "packageEquals", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "superHasAccessibleConstructor", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findReadWriteObjectForSerialization", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplaceResolveForSerialization", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "useNativeAccessorOnly", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConstructorForExternalization", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConstructorForSerialization", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConstructorForSerialization", "(Ljava/lang/Class;Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObjectForSerialization", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObjectNoDataForSerialization", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObjectForSerialization", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplaceForSerialization", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readResolveForSerialization", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasStaticInitializerForSerialization", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOptionalDataExceptionForSerialization", "()Ljava/lang/reflect/Constructor;"));
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool initted_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/reflect/ReflectionFactory;", "private static final")]
	public static Dova.JDK.jdk.@internal.reflect.ReflectionFactory soleInstance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ReflectionFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static volatile")]
	public static Dova.JDK.java.lang.reflect.Method hasStaticInitializerMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool noInflation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int inflationThreshold_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int METHOD_MH_ACCESSOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FIELD_MH_ACCESSOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ALL_MH_ACCESSORS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int useDirectMethodHandle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool useNativeAccessorOnly_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool disableSerialConstructorChecks_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangReflectAccess;", "private final")]
	public Dova.JDK.jdk.@internal.access.JavaLangReflectAccess langReflectAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangReflectAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ReflectionFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ReflectionFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/ReflectionFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/internal/reflect/ReflectionFactory;", "public static")]
	public static Dova.JDK.jdk.@internal.reflect.ReflectionFactory getReflectionFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ReflectionFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;", "public")]
	public Dova.JDK.java.lang.reflect.Constructor copyConstructor(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object newInstance(Dova.JDK.java.lang.reflect.Constructor arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Executable;)[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getExecutableSharedParameterTypes(Dova.JDK.java.lang.reflect.Executable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;", "public")]
	public Dova.JDK.java.lang.reflect.Method copyMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/reflect/Field;", "public")]
	public Dova.JDK.java.lang.reflect.Field copyField(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Executable;)[B", "public")]
	public JavaArray<byte> getExecutableTypeAnnotationBytes(Dova.JDK.java.lang.reflect.Executable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;Z)Ljdk/internal/reflect/FieldAccessor;", "public")]
	public Dova.JDK.jdk.@internal.reflect.FieldAccessor newFieldAccessor(Dova.JDK.java.lang.reflect.Field arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.FieldAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Z)Ljdk/internal/reflect/MethodAccessor;", "public")]
	public Dova.JDK.jdk.@internal.reflect.MethodAccessor newMethodAccessor(Dova.JDK.java.lang.reflect.Method arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.MethodAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Ljdk/internal/reflect/ConstructorAccessor;", "public")]
	public Dova.JDK.jdk.@internal.reflect.ConstructorAccessor getConstructorAccessor(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstructorAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Ljdk/internal/reflect/ConstructorAccessor;", "public")]
	public Dova.JDK.jdk.@internal.reflect.ConstructorAccessor newConstructorAccessor(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstructorAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Ljdk/internal/reflect/ConstructorAccessor;)V", "public")]
	public void setConstructorAccessor(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.jdk.@internal.reflect.ConstructorAccessor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "static")]
	public static int inflationThreshold()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;", "private final")]
	public Dova.JDK.java.lang.reflect.Constructor generateConstructor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.reflect.Constructor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Class;IILjava/lang/String;[B[B)Ljava/lang/reflect/Constructor;", "public")]
	public Dova.JDK.java.lang.reflect.Constructor newConstructor(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Class> arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, int arg3, int arg4, Dova.JDK.java.lang.String arg5, JavaArray<byte> arg6, JavaArray<byte> arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;", "public")]
	public Dova.JDK.java.lang.reflect.Method leafCopyMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void checkInitted()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool useFieldHandleAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool useMethodHandleAccessor()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool noInflation()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljdk/internal/reflect/MethodAccessorImpl;", "static")]
	public static Dova.JDK.jdk.@internal.reflect.MethodAccessorImpl generateMethodAccessor(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.MethodAccessorImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "private static")]
	public static bool packageEquals(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private")]
	public bool superHasAccessibleConstructor(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private final")]
	public Dova.JDK.java.lang.invoke.MethodHandle findReadWriteObjectForSerialization(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/invoke/MethodHandle;", "private")]
	public Dova.JDK.java.lang.invoke.MethodHandle getReplaceResolveForSerialization(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool useNativeAccessorOnly()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "public final")]
	public Dova.JDK.java.lang.reflect.Constructor newConstructorForExternalization(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "public final")]
	public Dova.JDK.java.lang.reflect.Constructor newConstructorForSerialization(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;", "public final")]
	public Dova.JDK.java.lang.reflect.Constructor newConstructorForSerialization(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.reflect.Constructor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public final")]
	public Dova.JDK.java.lang.invoke.MethodHandle readObjectForSerialization(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public final")]
	public Dova.JDK.java.lang.invoke.MethodHandle readObjectNoDataForSerialization(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public final")]
	public Dova.JDK.java.lang.invoke.MethodHandle writeObjectForSerialization(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public final")]
	public Dova.JDK.java.lang.invoke.MethodHandle writeReplaceForSerialization(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public final")]
	public Dova.JDK.java.lang.invoke.MethodHandle readResolveForSerialization(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public final")]
	public bool hasStaticInitializerForSerialization(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Constructor;", "public final")]
	public Dova.JDK.java.lang.reflect.Constructor newOptionalDataExceptionForSerialization()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/reflect/ReflectionFactory$GetReflectionFactoryAction;", "public static final")]
	public partial class GetReflectionFactoryAction
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.security.PrivilegedAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GetReflectionFactoryAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/ReflectionFactory$GetReflectionFactoryAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljdk/internal/reflect/ReflectionFactory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GetReflectionFactoryAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public GetReflectionFactoryAction() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/reflect/ReflectionFactory$GetReflectionFactoryAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/internal/reflect/ReflectionFactory;", "public")]
		public Dova.JDK.jdk.@internal.reflect.ReflectionFactory run_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ReflectionFactory>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object run_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
