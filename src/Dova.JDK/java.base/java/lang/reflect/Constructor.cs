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

namespace Dova.JDK.java.lang.reflect;

[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "public final")]
public partial class Constructor
	: Dova.JDK.java.lang.reflect.Executable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Constructor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/reflect/Constructor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Class;IILjava/lang/String;[B[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericInfo", "()Lsun/reflect/generics/repository/ConstructorRepository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFactory", "()Lsun/reflect/generics/factory/GenericsFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawAnnotations", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynthetic", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringClass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCanSetAccessible", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toShortString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRoot_0", "()Ljava/lang/reflect/AccessibleObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRoot_1", "()Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "()Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarArgs", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasGenericInformation", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationBytes", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSharedParameterTypes", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSharedExceptionTypes", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "specificToStringHeader", "(Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "specificToGenericStringHeader", "(Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedReturnType", "()Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleParameterNumberMismatch", "(I[Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedReceiverType", "()Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignature", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstanceWithCaller", "([Ljava/lang/Object;ZLjava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireConstructorAccessor", "()Ljdk/internal/reflect/ConstructorAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorAccessor", "()Ljdk/internal/reflect/ConstructorAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConstructorAccessor", "(Ljdk/internal/reflect/ConstructorAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSlot", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawParameterAnnotations", "()[B"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Constructor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Class;IILjava/lang/String;[B[B)V", "")]
	public Constructor(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Class> arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, int arg3, int arg4, Dova.JDK.java.lang.String arg5, JavaArray<byte> arg6, JavaArray<byte> arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/reflect/Constructor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getModifiers()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/TypeVariable;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.TypeVariable> getTypeParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.TypeVariable>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public transient")]
	public Dova.JDK.java.lang.Object newInstance(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/repository/ConstructorRepository;", "")]
	public Dova.JDK.sun.reflect.generics.repository.ConstructorRepository getGenericInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.repository.ConstructorRepository>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/factory/GenericsFactory;", "private")]
	public Dova.JDK.sun.reflect.generics.factory.GenericsFactory getFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.factory.GenericsFactory>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getParameterTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()[B", "")]
	public JavaArray<byte> getRawAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toGenericString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSynthetic()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getDeclaringClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "public")]
	public Dova.JDK.java.lang.Object getAnnotation(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/annotation/Annotation;", "public")]
	public JavaArray<Dova.JDK.java.lang.annotation.Annotation> getDeclaredAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setAccessible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "")]
	public void checkCanSetAccessible(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String toShortString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AccessibleObject;", "volatile")]
	public Dova.JDK.java.lang.reflect.AccessibleObject getRoot_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AccessibleObject>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Constructor;", "")]
	public Dova.JDK.java.lang.reflect.Constructor getRoot_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Constructor;", "")]
	public Dova.JDK.java.lang.reflect.Constructor copy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isVarArgs()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getParameterCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()[[Ljava/lang/annotation/Annotation;", "public")]
	public JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>> getParameterAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Type;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> getGenericParameterTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Type;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> getGenericExceptionTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool hasGenericInformation()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()[B", "")]
	public JavaArray<byte> getAnnotationBytes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "")]
	public JavaArray<Dova.JDK.java.lang.Class> getSharedParameterTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "")]
	public JavaArray<Dova.JDK.java.lang.Class> getSharedExceptionTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getExceptionTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)V", "")]
	public void specificToStringHeader(Dova.JDK.java.lang.StringBuilder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)V", "")]
	public void specificToGenericStringHeader(Dova.JDK.java.lang.StringBuilder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
	public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("(I[Ljava/lang/Class;)Z", "")]
	public bool handleParameterNumberMismatch(int arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
	public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedReceiverType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;ZLjava/lang/Class;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object newInstanceWithCaller(JavaArray<Dova.JDK.java.lang.Object> arg0, bool arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/reflect/ConstructorAccessor;", "private")]
	public Dova.JDK.jdk.@internal.reflect.ConstructorAccessor acquireConstructorAccessor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstructorAccessor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/reflect/ConstructorAccessor;", "")]
	public Dova.JDK.jdk.@internal.reflect.ConstructorAccessor getConstructorAccessor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstructorAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/reflect/ConstructorAccessor;)V", "")]
	public void setConstructorAccessor(Dova.JDK.jdk.@internal.reflect.ConstructorAccessor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()I", "")]
	public int getSlot()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("()[B", "")]
	public JavaArray<byte> getRawParameterAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
