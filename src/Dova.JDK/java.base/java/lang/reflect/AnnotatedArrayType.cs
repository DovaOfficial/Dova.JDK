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

[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedArrayType;", "public abstract interface")]
public partial interface AnnotatedArrayType
	: IJavaObject
	, Dova.JDK.java.lang.reflect.AnnotatedType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotatedArrayType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/reflect/AnnotatedArrayType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedGenericComponentType", "()Ljava/lang/reflect/AnnotatedType;"));
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public abstract")]
	Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedOwnerType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public abstract")]
	Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedGenericComponentType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}
}
