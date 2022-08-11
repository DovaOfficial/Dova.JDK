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

namespace Dova.JDK.jdk.dynalink.beans;

[JniSignatureAttribute("Ljdk/dynalink/beans/SingleDynamicMethod;", "abstract")]
public partial class SingleDynamicMethod
	: Dova.JDK.jdk.dynalink.beans.DynamicMethod
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SingleDynamicMethod()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/SingleDynamicMethod;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAN_CONVERT_TO", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljdk/dynalink/beans/SingleDynamicMethod;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarArgs", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodType", "()Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "(Ljdk/dynalink/CallSiteDescriptor;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectArguments", "(Ljava/lang/invoke/MethodHandle;I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInvocation", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;Ljdk/dynalink/linker/LinkerServices;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInvocation", "(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "typeMatchesDescription", "(Ljava/lang/String;Ljava/lang/invoke/MethodType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createConvertingInvocation", "(Ljava/lang/invoke/MethodHandle;Ljdk/dynalink/linker/LinkerServices;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "typeNameMatches", "(Ljava/lang/String;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "canConvertTo", "(Ljdk/dynalink/linker/LinkerServices;Ljava/lang/Class;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodForExactParamTypes", "(Ljava/lang/String;)Ljdk/dynalink/beans/SingleDynamicMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethodNameWithSignature", "(Ljava/lang/invoke/MethodType;Ljava/lang/String;Z)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle CAN_CONVERT_TO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SingleDynamicMethod(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public SingleDynamicMethod(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/SingleDynamicMethod;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/dynalink/beans/SingleDynamicMethod;)Z", "")]
	public bool contains(Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "abstract")]
	public bool isVarArgs()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/MethodType;", "abstract")]
	public Dova.JDK.java.lang.invoke.MethodType getMethodType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;)Ljava/lang/invoke/MethodHandle;", "abstract")]
	public Dova.JDK.java.lang.invoke.MethodHandle getTarget(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;I)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle collectArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;Ljdk/dynalink/linker/LinkerServices;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle getInvocation(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1, Dova.JDK.jdk.dynalink.linker.LinkerServices arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;)Ljava/lang/invoke/MethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.MethodHandle getInvocation(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/invoke/MethodType;)Z", "private static")]
	public static bool typeMatchesDescription(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljdk/dynalink/linker/LinkerServices;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle createConvertingInvocation(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1, Dova.JDK.java.lang.invoke.MethodType arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Z", "private static")]
	public static bool typeNameMatches(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkerServices;Ljava/lang/Class;Ljava/lang/Object;)Z", "private static")]
	public static bool canConvertTo(Dova.JDK.jdk.dynalink.linker.LinkerServices arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/dynalink/beans/SingleDynamicMethod;", "")]
	public Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod getMethodForExactParamTypes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/String;Z)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getMethodNameWithSignature(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.String arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
