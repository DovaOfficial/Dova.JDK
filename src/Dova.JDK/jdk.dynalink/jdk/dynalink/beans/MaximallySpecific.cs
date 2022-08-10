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

namespace Dova.JDK.jdk.dynalink.beans;

[JniSignatureAttribute("Ljdk/dynalink/beans/MaximallySpecific;", "")]
public partial class MaximallySpecific
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MaximallySpecific()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/MaximallySpecific;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MaximallySpecific", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compare", "(Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Class;ILjdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getParameterClass", "(Ljava/lang/invoke/MethodType;IIZ)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMaximallySpecificMethodHandles", "(Ljava/util/List;Z[Ljava/lang/Class;Ljdk/dynalink/linker/LinkerServices;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMaximallySpecificMethods", "(Ljava/util/List;Z)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMaximallySpecificMethods", "(Ljava/util/List;Z[Ljava/lang/Class;Ljdk/dynalink/linker/LinkerServices;Ljava/util/function/Function;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isMoreSpecific", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;Z[Ljava/lang/Class;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MaximallySpecific(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public MaximallySpecific() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/MaximallySpecific;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Class;ILjdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/ConversionComparator$Comparison;", "private static")]
	public static Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison compare(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, int arg3, Dova.JDK.jdk.dynalink.linker.LinkerServices arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;IIZ)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class getParameterClass(Dova.JDK.java.lang.invoke.MethodType arg0, int arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Z[Ljava/lang/Class;Ljdk/dynalink/linker/LinkerServices;)Ljava/util/List;", "static")]
	public static Dova.JDK.java.util.List getMaximallySpecificMethodHandles(Dova.JDK.java.util.List arg0, bool arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, Dova.JDK.jdk.dynalink.linker.LinkerServices arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Z)Ljava/util/List;", "static")]
	public static Dova.JDK.java.util.List getMaximallySpecificMethods(Dova.JDK.java.util.List arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Z[Ljava/lang/Class;Ljdk/dynalink/linker/LinkerServices;Ljava/util/function/Function;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getMaximallySpecificMethods(Dova.JDK.java.util.List arg0, bool arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, Dova.JDK.jdk.dynalink.linker.LinkerServices arg3, Dova.JDK.java.util.function.Function arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;Z[Ljava/lang/Class;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/ConversionComparator$Comparison;", "private static")]
	public static Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison isMoreSpecific(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.MethodType arg1, bool arg2, JavaArray<Dova.JDK.java.lang.Class> arg3, Dova.JDK.jdk.dynalink.linker.LinkerServices arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>(ret);
	}
}
