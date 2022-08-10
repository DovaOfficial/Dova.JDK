/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.lang.model.util;

[JniSignatureAttribute("Ljavax/lang/model/util/Types;", "public abstract interface")]
public partial interface Types
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Types()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/lang/model/util/Types;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "contains", "(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "capture", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asElement", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSameType", "(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSubtype", "(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isAssignable", "(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSubsignature", "(Ljavax/lang/model/type/ExecutableType;Ljavax/lang/model/type/ExecutableType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "directSupertypes", "(Ljavax/lang/model/type/TypeMirror;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "boxedClass", "(Ljavax/lang/model/type/PrimitiveType;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unboxedType", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/PrimitiveType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrimitiveType", "(Ljavax/lang/model/type/TypeKind;)Ljavax/lang/model/type/PrimitiveType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNullType", "()Ljavax/lang/model/type/NullType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNoType", "(Ljavax/lang/model/type/TypeKind;)Ljavax/lang/model/type/NoType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getArrayType", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/ArrayType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getWildcardType", "(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/WildcardType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDeclaredType", "(Ljavax/lang/model/type/DeclaredType;Ljavax/lang/model/element/TypeElement;[Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/DeclaredType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDeclaredType", "(Ljavax/lang/model/element/TypeElement;[Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/DeclaredType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asMemberOf", "(Ljavax/lang/model/type/DeclaredType;Ljavax/lang/model/element/Element;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "erasure", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;"));
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Z", "public abstract")]
	bool contains(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	Dova.JDK.javax.lang.model.type.TypeMirror capture(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/element/Element;", "public abstract")]
	Dova.JDK.javax.lang.model.element.Element asElement(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Z", "public abstract")]
	bool isSameType(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Z", "public abstract")]
	bool isSubtype(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Z", "public abstract")]
	bool isAssignable(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/ExecutableType;Ljavax/lang/model/type/ExecutableType;)Z", "public abstract")]
	bool isSubsignature(Dova.JDK.javax.lang.model.type.ExecutableType arg0, Dova.JDK.javax.lang.model.type.ExecutableType arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List directSupertypes(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/PrimitiveType;)Ljavax/lang/model/element/TypeElement;", "public abstract")]
	Dova.JDK.javax.lang.model.element.TypeElement boxedClass(Dova.JDK.javax.lang.model.type.PrimitiveType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/PrimitiveType;", "public abstract")]
	Dova.JDK.javax.lang.model.type.PrimitiveType unboxedType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.PrimitiveType>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeKind;)Ljavax/lang/model/type/PrimitiveType;", "public abstract")]
	Dova.JDK.javax.lang.model.type.PrimitiveType getPrimitiveType(Dova.JDK.javax.lang.model.type.TypeKind arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.PrimitiveType>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/NullType;", "public abstract")]
	Dova.JDK.javax.lang.model.type.NullType getNullType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.NullType>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeKind;)Ljavax/lang/model/type/NoType;", "public abstract")]
	Dova.JDK.javax.lang.model.type.NoType getNoType(Dova.JDK.javax.lang.model.type.TypeKind arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.NoType>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/ArrayType;", "public abstract")]
	Dova.JDK.javax.lang.model.type.ArrayType getArrayType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.ArrayType>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/WildcardType;", "public abstract")]
	Dova.JDK.javax.lang.model.type.WildcardType getWildcardType(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.WildcardType>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/DeclaredType;Ljavax/lang/model/element/TypeElement;[Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/DeclaredType;", "public abstract transient")]
	Dova.JDK.javax.lang.model.type.DeclaredType getDeclaredType(Dova.JDK.javax.lang.model.type.DeclaredType arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, JavaArray<Dova.JDK.javax.lang.model.type.TypeMirror> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.DeclaredType>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;[Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/DeclaredType;", "public abstract transient")]
	Dova.JDK.javax.lang.model.type.DeclaredType getDeclaredType(Dova.JDK.javax.lang.model.element.TypeElement arg0, JavaArray<Dova.JDK.javax.lang.model.type.TypeMirror> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.DeclaredType>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/DeclaredType;Ljavax/lang/model/element/Element;)Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	Dova.JDK.javax.lang.model.type.TypeMirror asMemberOf(Dova.JDK.javax.lang.model.type.DeclaredType arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	Dova.JDK.javax.lang.model.type.TypeMirror erasure(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}
}
