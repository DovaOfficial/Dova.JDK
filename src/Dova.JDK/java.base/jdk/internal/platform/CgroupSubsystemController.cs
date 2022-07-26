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

namespace Dova.JDK.jdk.@internal.platform;

[JniSignatureAttribute("Ljdk/internal/platform/CgroupSubsystemController;", "public abstract interface")]
public partial interface CgroupSubsystemController
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CgroupSubsystemController()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/platform/CgroupSubsystemController;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_STR", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "path", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLongValue", "(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;Ljava/util/function/Function;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDoubleValue", "(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStringValue", "(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLongValueMatchingLine", "(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Function;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLongEntry", "(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;Ljava/lang/String;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringRangeToIntArray", "(Ljava/lang/String;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertStringToLong", "(Ljava/lang/String;JJ)J"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String EMPTY_STR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String path()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;Ljava/util/function/Function;J)J", "public static")]
	static long getLongValue(Dova.JDK.jdk.@internal.platform.CgroupSubsystemController arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.function.Function arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;D)D", "public static")]
	static double getDoubleValue(Dova.JDK.jdk.@internal.platform.CgroupSubsystemController arg0, Dova.JDK.java.lang.String arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;)Ljava/lang/String;", "public static")]
	static Dova.JDK.java.lang.String getStringValue(Dova.JDK.jdk.@internal.platform.CgroupSubsystemController arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Function;J)J", "public static")]
	static long getLongValueMatchingLine(Dova.JDK.jdk.@internal.platform.CgroupSubsystemController arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.function.Function arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/platform/CgroupSubsystemController;Ljava/lang/String;Ljava/lang/String;J)J", "public static")]
	static long getLongEntry(Dova.JDK.jdk.@internal.platform.CgroupSubsystemController arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[I", "public static")]
	static JavaArray<int> stringRangeToIntArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;JJ)J", "public static")]
	static long convertStringToLong(Dova.JDK.java.lang.String arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}
}
