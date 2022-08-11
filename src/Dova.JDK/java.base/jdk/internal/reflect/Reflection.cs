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

[JniSignatureAttribute("Ljdk/internal/reflect/Reflection;", "public")]
public partial class Reflection
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Reflection()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/Reflection;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClassAccessFlags", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCallerClass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterFields", "(Ljava/lang/Class;[Ljava/lang/reflect/Field;)[Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterMethods", "(Ljava/lang/Class;[Ljava/lang/reflect/Method;)[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filter", "([Ljava/lang/reflect/Member;Ljava/util/Set;)[Ljava/lang/reflect/Member;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSubclassOf", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newIllegalAccessException", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;I)Ljava/lang/IllegalAccessException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newIllegalAccessException", "(Ljava/lang/Class;I)Ljava/lang/IllegalAccessException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "verifyPublicMemberAccess", "(Ljava/lang/Class;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "verifyMemberAccess", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isCallerSensitive", "(Ljava/lang/reflect/Method;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerFieldsToFilter", "(Ljava/lang/Class;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isTrustedFinalField", "(Ljava/lang/reflect/Field;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "verifyModuleAccess", "(Ljava/lang/Module;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSameClassPackage", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "areNestMates", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerFilter", "(Ljava/util/Map;Ljava/lang/Class;Ljava/util/Set;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureMemberAccess", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureNativeAccess", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerMethodsToFilter", "(Ljava/lang/Class;Ljava/util/Set;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Reflection(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Reflection() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/Reflection;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "public static native")]
	public static int getClassAccessFlags(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public static native")]
	public static Dova.JDK.java.lang.Class getCallerClass()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/reflect/Field;)[Ljava/lang/reflect/Field;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.Field> filterFields(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.reflect.Field> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/reflect/Method;)[Ljava/lang/reflect/Method;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.Method> filterMethods(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.reflect.Method> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Member;Ljava/util/Set;)[Ljava/lang/reflect/Member;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.Member> filter(JavaArray<Dova.JDK.java.lang.reflect.Member> arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Member>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "static")]
	public static bool isSubclassOf(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;I)Ljava/lang/IllegalAccessException;", "public static")]
	public static Dova.JDK.java.lang.IllegalAccessException newIllegalAccessException(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalAccessException>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;I)Ljava/lang/IllegalAccessException;", "private static")]
	public static Dova.JDK.java.lang.IllegalAccessException newIllegalAccessException(Dova.JDK.java.lang.Class arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalAccessException>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;I)Z", "public static")]
	public static bool verifyPublicMemberAccess(Dova.JDK.java.lang.Class arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;I)Z", "public static")]
	public static bool verifyMemberAccess(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Z", "public static")]
	public static bool isCallerSensitive(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Set;)V", "public static synchronized")]
	public static void registerFieldsToFilter(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Z", "public static")]
	public static bool isTrustedFinalField(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Module;Ljava/lang/Class;)Z", "public static")]
	public static bool verifyModuleAccess(Dova.JDK.java.lang.Module arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "private static")]
	public static bool isSameClassPackage(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "public static native")]
	public static bool areNestMates(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/Class;Ljava/util/Set;)Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map registerFilter(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.util.Set arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;I)V", "public static")]
	public static void ensureMemberAccess(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public static")]
	public static void ensureNativeAccess(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Set;)V", "public static synchronized")]
	public static void registerMethodsToFilter(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
	}
}
