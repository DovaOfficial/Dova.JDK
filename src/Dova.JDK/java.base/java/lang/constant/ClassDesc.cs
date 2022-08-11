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

namespace Dova.JDK.java.lang.constant;

[JniSignatureAttribute("Ljava/lang/constant/ClassDesc;", "public abstract interface")]
public partial interface ClassDesc
	: IJavaObject
	, Dova.JDK.java.lang.constant.ConstantDesc
	, Dova.JDK.java.lang.invoke.TypeDescriptor.OfField
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassDesc()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/ClassDesc;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentType_0", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentType_1", "()Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "packageName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "descriptorString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDescriptor", "(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayType_0", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayType_1", "()Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayType", "(I)Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isClassOrInterface", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nested", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nested", "(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	bool isArray()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	bool isPrimitive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	Dova.JDK.java.lang.invoke.TypeDescriptor.OfField componentType_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/ClassDesc;", "public")]
	Dova.JDK.java.lang.constant.ClassDesc componentType_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;", "public static")]
	static Dova.JDK.java.lang.constant.ClassDesc of(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/constant/ClassDesc;", "public static")]
	static Dova.JDK.java.lang.constant.ClassDesc of(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String packageName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String descriptorString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;", "public static")]
	static Dova.JDK.java.lang.constant.ClassDesc ofDescriptor(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	Dova.JDK.java.lang.invoke.TypeDescriptor.OfField arrayType_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/ClassDesc;", "public")]
	Dova.JDK.java.lang.constant.ClassDesc arrayType_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/constant/ClassDesc;", "public")]
	Dova.JDK.java.lang.constant.ClassDesc arrayType(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String displayName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	bool isClassOrInterface()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/constant/ClassDesc;", "public transient")]
	Dova.JDK.java.lang.constant.ClassDesc nested(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;", "public")]
	Dova.JDK.java.lang.constant.ClassDesc nested(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}
}
