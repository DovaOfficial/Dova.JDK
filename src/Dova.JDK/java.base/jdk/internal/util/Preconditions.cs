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

namespace Dova.JDK.jdk.@internal.util;

[JniSignatureAttribute("Ljdk/internal/util/Preconditions;", "public")]
public partial class Preconditions
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Preconditions()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/Preconditions;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIOOBE_FORMATTER", "Ljava/util/function/BiFunction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AIOOBE_FORMATTER", "Ljava/util/function/BiFunction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IOOBE_FORMATTER", "Ljava/util/function/BiFunction;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkIndex", "(IILjava/util/function/BiFunction;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkIndex", "(JJLjava/util/function/BiFunction;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkFromToIndex", "(JJJLjava/util/function/BiFunction;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkFromToIndex", "(IIILjava/util/function/BiFunction;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkFromIndexSize", "(IIILjava/util/function/BiFunction;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkFromIndexSize", "(JJJLjava/util/function/BiFunction;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBounds", "(Ljava/util/function/BiFunction;Ljava/lang/String;[Ljava/lang/Number;)Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBoundsMessage", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBoundsCheckIndex", "(Ljava/util/function/BiFunction;JJ)Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBoundsCheckIndex", "(Ljava/util/function/BiFunction;II)Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBoundsCheckFromToIndex", "(Ljava/util/function/BiFunction;III)Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBoundsCheckFromToIndex", "(Ljava/util/function/BiFunction;JJJ)Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBoundsCheckFromIndexSize", "(Ljava/util/function/BiFunction;III)Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBoundsCheckFromIndexSize", "(Ljava/util/function/BiFunction;JJJ)Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outOfBoundsExceptionFormatter", "(Ljava/util/function/Function;)Ljava/util/function/BiFunction;"));
	}

	[JniSignatureAttribute("Ljava/util/function/BiFunction;", "public static final")]
	public static Dova.JDK.java.util.function.BiFunction SIOOBE_FORMATTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/BiFunction;", "public static final")]
	public static Dova.JDK.java.util.function.BiFunction AIOOBE_FORMATTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/BiFunction;", "public static final")]
	public static Dova.JDK.java.util.function.BiFunction IOOBE_FORMATTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Preconditions(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Preconditions() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/util/Preconditions;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(IILjava/util/function/BiFunction;)I", "public static")]
	public static int checkIndex(int arg0, int arg1, Dova.JDK.java.util.function.BiFunction arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJLjava/util/function/BiFunction;)J", "public static")]
	public static long checkIndex(long arg0, long arg1, Dova.JDK.java.util.function.BiFunction arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJJLjava/util/function/BiFunction;)J", "public static")]
	public static long checkFromToIndex(long arg0, long arg1, long arg2, Dova.JDK.java.util.function.BiFunction arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IIILjava/util/function/BiFunction;)I", "public static")]
	public static int checkFromToIndex(int arg0, int arg1, int arg2, Dova.JDK.java.util.function.BiFunction arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IIILjava/util/function/BiFunction;)I", "public static")]
	public static int checkFromIndexSize(int arg0, int arg1, int arg2, Dova.JDK.java.util.function.BiFunction arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJJLjava/util/function/BiFunction;)J", "public static")]
	public static long checkFromIndexSize(long arg0, long arg1, long arg2, Dova.JDK.java.util.function.BiFunction arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;Ljava/lang/String;[Ljava/lang/Number;)Ljava/lang/RuntimeException;", "private static transient")]
	public static Dova.JDK.java.lang.RuntimeException outOfBounds(Dova.JDK.java.util.function.BiFunction arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Number> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String outOfBoundsMessage(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;JJ)Ljava/lang/RuntimeException;", "private static")]
	public static Dova.JDK.java.lang.RuntimeException outOfBoundsCheckIndex(Dova.JDK.java.util.function.BiFunction arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;II)Ljava/lang/RuntimeException;", "private static")]
	public static Dova.JDK.java.lang.RuntimeException outOfBoundsCheckIndex(Dova.JDK.java.util.function.BiFunction arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;III)Ljava/lang/RuntimeException;", "private static")]
	public static Dova.JDK.java.lang.RuntimeException outOfBoundsCheckFromToIndex(Dova.JDK.java.util.function.BiFunction arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;JJJ)Ljava/lang/RuntimeException;", "private static")]
	public static Dova.JDK.java.lang.RuntimeException outOfBoundsCheckFromToIndex(Dova.JDK.java.util.function.BiFunction arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;III)Ljava/lang/RuntimeException;", "private static")]
	public static Dova.JDK.java.lang.RuntimeException outOfBoundsCheckFromIndexSize(Dova.JDK.java.util.function.BiFunction arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;JJJ)Ljava/lang/RuntimeException;", "private static")]
	public static Dova.JDK.java.lang.RuntimeException outOfBoundsCheckFromIndexSize(Dova.JDK.java.util.function.BiFunction arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/util/function/BiFunction;", "public static")]
	public static Dova.JDK.java.util.function.BiFunction outOfBoundsExceptionFormatter(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
	}
}
