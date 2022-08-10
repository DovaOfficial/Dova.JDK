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

namespace Dova.JDK.java.lang.reflect;

[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedParameterizedType;", "public abstract interface")]
public partial interface AnnotatedParameterizedType
	: IJavaObject
	, Dova.JDK.java.lang.reflect.AnnotatedType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotatedParameterizedType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/reflect/AnnotatedParameterizedType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotatedActualTypeArguments", "()[Ljava/lang/reflect/AnnotatedType;"));
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public abstract")]
	Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedOwnerType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/AnnotatedType;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedActualTypeArguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
	}
}
