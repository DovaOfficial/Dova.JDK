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

namespace Dova.JDK.java.util.stream;

[JniSignatureAttribute("Ljava/util/stream/StreamSupport;", "public final")]
public partial class StreamSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StreamSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/StreamSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "(Ljava/util/function/Supplier;IZ)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stream", "(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "intStream", "(Ljava/util/function/Supplier;IZ)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "intStream", "(Ljava/util/Spliterator$OfInt;Z)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longStream", "(Ljava/util/function/Supplier;IZ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longStream", "(Ljava/util/Spliterator$OfLong;Z)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubleStream", "(Ljava/util/Spliterator$OfDouble;Z)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubleStream", "(Ljava/util/function/Supplier;IZ)Ljava/util/stream/DoubleStream;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StreamSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public StreamSupport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/stream/StreamSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/function/Supplier;IZ)Ljava/util/stream/Stream;", "public static")]
	public static Dova.JDK.java.util.stream.Stream stream(Dova.JDK.java.util.function.Supplier arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;", "public static")]
	public static Dova.JDK.java.util.stream.Stream stream(Dova.JDK.java.util.Spliterator arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;IZ)Ljava/util/stream/IntStream;", "public static")]
	public static Dova.JDK.java.util.stream.IntStream intStream(Dova.JDK.java.util.function.Supplier arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;Z)Ljava/util/stream/IntStream;", "public static")]
	public static Dova.JDK.java.util.stream.IntStream intStream(Dova.JDK.java.util.Spliterator.OfInt arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;IZ)Ljava/util/stream/LongStream;", "public static")]
	public static Dova.JDK.java.util.stream.LongStream longStream(Dova.JDK.java.util.function.Supplier arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;Z)Ljava/util/stream/LongStream;", "public static")]
	public static Dova.JDK.java.util.stream.LongStream longStream(Dova.JDK.java.util.Spliterator.OfLong arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;Z)Ljava/util/stream/DoubleStream;", "public static")]
	public static Dova.JDK.java.util.stream.DoubleStream doubleStream(Dova.JDK.java.util.Spliterator.OfDouble arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;IZ)Ljava/util/stream/DoubleStream;", "public static")]
	public static Dova.JDK.java.util.stream.DoubleStream doubleStream(Dova.JDK.java.util.function.Supplier arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}
}
