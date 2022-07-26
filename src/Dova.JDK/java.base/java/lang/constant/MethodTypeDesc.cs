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

[JniSignatureAttribute("Ljava/lang/constant/MethodTypeDesc;", "public abstract interface")]
public partial interface MethodTypeDesc
	: IJavaObject
	, Dova.JDK.java.lang.constant.ConstantDesc
	, Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodTypeDesc()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/MethodTypeDesc;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType_0", "()Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType_1", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "descriptorString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDescriptor", "(Ljava/lang/String;)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterType_0", "(I)Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterType_1", "(I)Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertParameterTypes", "(I[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertParameterTypes", "(I[Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeReturnType", "(Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeReturnType", "(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropParameterTypes_0", "(II)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropParameterTypes_1", "(II)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterList", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterArray_0", "()[Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterArray_1", "()[Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeParameterType", "(ILjava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeParameterType", "(ILjava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayDescriptor", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("()Ljava/lang/constant/ClassDesc;", "public abstract")]
	Dova.JDK.java.lang.constant.ClassDesc returnType_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	Dova.JDK.java.lang.invoke.TypeDescriptor.OfField returnType_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;", "public static transient")]
	static Dova.JDK.java.lang.constant.MethodTypeDesc of(Dova.JDK.java.lang.constant.ClassDesc arg0, JavaArray<Dova.JDK.java.lang.constant.ClassDesc> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String descriptorString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/constant/MethodTypeDesc;", "public static")]
	static Dova.JDK.java.lang.constant.MethodTypeDesc ofDescriptor(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	Dova.JDK.java.lang.invoke.TypeDescriptor.OfField parameterType_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/constant/ClassDesc;", "public abstract")]
	Dova.JDK.java.lang.constant.ClassDesc parameterType_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("(I[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;", "public abstract transient")]
	Dova.JDK.java.lang.constant.MethodTypeDesc insertParameterTypes(int arg0, JavaArray<Dova.JDK.java.lang.constant.ClassDesc> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public volatile")]
	Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod insertParameterTypes(int arg0, JavaArray<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;", "public abstract")]
	Dova.JDK.java.lang.constant.MethodTypeDesc changeReturnType(Dova.JDK.java.lang.constant.ClassDesc arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public volatile")]
	Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod changeReturnType(Dova.JDK.java.lang.invoke.TypeDescriptor.OfField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public volatile")]
	Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod dropParameterTypes_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/constant/MethodTypeDesc;", "public abstract")]
	Dova.JDK.java.lang.constant.MethodTypeDesc dropParameterTypes_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int parameterCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List parameterList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/constant/ClassDesc;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.constant.ClassDesc> parameterArray_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.ClassDesc>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	JavaArray<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField> parameterArray_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public volatile")]
	Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod changeParameterType(int arg0, Dova.JDK.java.lang.invoke.TypeDescriptor.OfField arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;", "public abstract")]
	Dova.JDK.java.lang.constant.MethodTypeDesc changeParameterType(int arg0, Dova.JDK.java.lang.constant.ClassDesc arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	Dova.JDK.java.lang.String displayDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
