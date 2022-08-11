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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaLangReflectAccess;", "public abstract interface")]
public partial interface JavaLangReflectAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaLangReflectAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaLangReflectAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyConstructor", "(Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExecutableSharedParameterTypes", "(Ljava/lang/reflect/Executable;)[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyMethod", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyField", "(Ljava/lang/reflect/Field;)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExecutableTypeAnnotationBytes", "(Ljava/lang/reflect/Executable;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRoot", "(Ljava/lang/reflect/AccessibleObject;)Ljava/lang/reflect/AccessibleObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodAccessor", "(Ljava/lang/reflect/Method;)Ljdk/internal/reflect/MethodAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMethodAccessor", "(Ljava/lang/reflect/Method;Ljdk/internal/reflect/MethodAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorAccessor", "(Ljava/lang/reflect/Constructor;)Ljdk/internal/reflect/ConstructorAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConstructorAccessor", "(Ljava/lang/reflect/Constructor;Ljdk/internal/reflect/ConstructorAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTrustedFinalField", "(Ljava/lang/reflect/Field;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConstructor", "(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Class;IILjava/lang/String;[B[B)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorSlot", "(Ljava/lang/reflect/Constructor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorSignature", "(Ljava/lang/reflect/Constructor;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorAnnotations", "(Ljava/lang/reflect/Constructor;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorParameterAnnotations", "(Ljava/lang/reflect/Constructor;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leafCopyMethod", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;"));
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;", "public abstract")]
	Dova.JDK.java.lang.reflect.Constructor copyConstructor(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object newInstance(Dova.JDK.java.lang.reflect.Constructor arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Executable;)[Ljava/lang/Class;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.Class> getExecutableSharedParameterTypes(Dova.JDK.java.lang.reflect.Executable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;", "public abstract")]
	Dova.JDK.java.lang.reflect.Method copyMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/reflect/Field;", "public abstract")]
	Dova.JDK.java.lang.reflect.Field copyField(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Executable;)[B", "public abstract")]
	JavaArray<byte> getExecutableTypeAnnotationBytes(Dova.JDK.java.lang.reflect.Executable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/AccessibleObject;)Ljava/lang/reflect/AccessibleObject;", "public abstract")]
	Dova.JDK.java.lang.Object getRoot(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljdk/internal/reflect/MethodAccessor;", "public abstract")]
	Dova.JDK.jdk.@internal.reflect.MethodAccessor getMethodAccessor(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.MethodAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljdk/internal/reflect/MethodAccessor;)V", "public abstract")]
	void setMethodAccessor(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.jdk.@internal.reflect.MethodAccessor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Ljdk/internal/reflect/ConstructorAccessor;", "public abstract")]
	Dova.JDK.jdk.@internal.reflect.ConstructorAccessor getConstructorAccessor(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstructorAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Ljdk/internal/reflect/ConstructorAccessor;)V", "public abstract")]
	void setConstructorAccessor(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.jdk.@internal.reflect.ConstructorAccessor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Z", "public abstract")]
	bool isTrustedFinalField(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Class;IILjava/lang/String;[B[B)Ljava/lang/reflect/Constructor;", "public abstract")]
	Dova.JDK.java.lang.reflect.Constructor newConstructor(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Class> arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, int arg3, int arg4, Dova.JDK.java.lang.String arg5, JavaArray<byte> arg6, JavaArray<byte> arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)I", "public abstract")]
	int getConstructorSlot(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getConstructorSignature(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)[B", "public abstract")]
	JavaArray<byte> getConstructorAnnotations(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)[B", "public abstract")]
	JavaArray<byte> getConstructorParameterAnnotations(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;", "public abstract")]
	Dova.JDK.java.lang.reflect.Method leafCopyMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}
}
