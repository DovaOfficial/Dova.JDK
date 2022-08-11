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

namespace Dova.JDK.sun.reflect.generics.factory;

[JniSignatureAttribute("Lsun/reflect/generics/factory/GenericsFactory;", "public abstract interface")]
public partial interface GenericsFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GenericsFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/factory/GenericsFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeLong", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeInt", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeShort", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeDouble", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeTypeVariable", "(Ljava/lang/String;[Lsun/reflect/generics/tree/FieldTypeSignature;)Ljava/lang/reflect/TypeVariable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeWildcard", "([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)Ljava/lang/reflect/WildcardType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeParameterizedType", "(Ljava/lang/reflect/Type;[Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)Ljava/lang/reflect/ParameterizedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findTypeVariable", "(Ljava/lang/String;)Ljava/lang/reflect/TypeVariable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNamedType", "(Ljava/lang/String;)Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeArrayType", "(Ljava/lang/reflect/Type;)Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeByte", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeBool", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChar", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeFloat", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeVoid", "()Ljava/lang/reflect/Type;"));
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeLong()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeInt()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeShort()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeDouble()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lsun/reflect/generics/tree/FieldTypeSignature;)Ljava/lang/reflect/TypeVariable;", "public abstract")]
	Dova.JDK.java.lang.reflect.TypeVariable makeTypeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.TypeVariable>(ret);
	}

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)Ljava/lang/reflect/WildcardType;", "public abstract")]
	Dova.JDK.java.lang.reflect.WildcardType makeWildcard(JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.WildcardType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;[Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)Ljava/lang/reflect/ParameterizedType;", "public abstract")]
	Dova.JDK.java.lang.reflect.ParameterizedType makeParameterizedType(Dova.JDK.java.lang.reflect.Type arg0, JavaArray<Dova.JDK.java.lang.reflect.Type> arg1, Dova.JDK.java.lang.reflect.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.ParameterizedType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/reflect/TypeVariable;", "public abstract")]
	Dova.JDK.java.lang.reflect.TypeVariable findTypeVariable(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.TypeVariable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeNamedType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeArrayType(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeByte()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeBool()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeChar()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeFloat()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public abstract")]
	Dova.JDK.java.lang.reflect.Type makeVoid()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}
}
