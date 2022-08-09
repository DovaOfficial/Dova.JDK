/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.lang.constant;

[JniSignatureAttribute("Ljava/lang/constant/MethodHandleDesc;", "public abstract interface")]
public partial interface MethodHandleDesc
	: IJavaObject
	, Dova.JDK.java.lang.constant.ConstantDesc
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodHandleDesc()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/constant/MethodHandleDesc;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/constant/DirectMethodHandleDesc$Kind;Ljava/lang/constant/ClassDesc;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/constant/DirectMethodHandleDesc;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "asType", "(Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/MethodHandleDesc;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofField", "(Ljava/lang/constant/DirectMethodHandleDesc$Kind;Ljava/lang/constant/ClassDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/DirectMethodHandleDesc;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofMethod", "(Ljava/lang/constant/DirectMethodHandleDesc$Kind;Ljava/lang/constant/ClassDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/DirectMethodHandleDesc;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "invocationType", "()Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofConstructor", "(Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/DirectMethodHandleDesc;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc$Kind;Ljava/lang/constant/ClassDesc;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/constant/DirectMethodHandleDesc;", "public static")]
	static Dova.JDK.java.lang.constant.DirectMethodHandleDesc of(Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind arg0, Dova.JDK.java.lang.constant.ClassDesc arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/MethodHandleDesc;", "public")]
	Dova.JDK.java.lang.constant.MethodHandleDesc asType(Dova.JDK.java.lang.constant.MethodTypeDesc arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodHandleDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc$Kind;Ljava/lang/constant/ClassDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/DirectMethodHandleDesc;", "public static")]
	static Dova.JDK.java.lang.constant.DirectMethodHandleDesc ofField(Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind arg0, Dova.JDK.java.lang.constant.ClassDesc arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.constant.ClassDesc arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc$Kind;Ljava/lang/constant/ClassDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/DirectMethodHandleDesc;", "public static")]
	static Dova.JDK.java.lang.constant.DirectMethodHandleDesc ofMethod(Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind arg0, Dova.JDK.java.lang.constant.ClassDesc arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.constant.MethodTypeDesc arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/MethodTypeDesc;", "public abstract")]
	Dova.JDK.java.lang.constant.MethodTypeDesc invocationType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/DirectMethodHandleDesc;", "public static transient")]
	static Dova.JDK.java.lang.constant.DirectMethodHandleDesc ofConstructor(Dova.JDK.java.lang.constant.ClassDesc arg0, JavaArray<Dova.JDK.java.lang.constant.ClassDesc> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc>(ret);
	}
}