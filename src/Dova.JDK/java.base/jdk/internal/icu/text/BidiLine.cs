/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.icu.text;

[JniSignatureAttribute("Ljdk/internal/icu/text/BidiLine;", "final")]
public partial class BidiLine
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BidiLine()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiLine;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BidiLine", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getVisualMap", "(Ljdk/internal/icu/text/BidiBase;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getRuns", "(Ljdk/internal/icu/text/BidiBase;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setLine", "(Ljdk/internal/icu/text/BidiBase;Ljava/text/Bidi;Ljdk/internal/icu/text/BidiBase;II)Ljava/text/Bidi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getLevelAt", "(Ljdk/internal/icu/text/BidiBase;I)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getVisualRun", "(Ljdk/internal/icu/text/BidiBase;I)Ljdk/internal/icu/text/BidiRun;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "reorderVisual", "([B)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setTrailingWSStart", "(Ljdk/internal/icu/text/BidiBase;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSingleRun", "(Ljdk/internal/icu/text/BidiBase;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "reorderLine", "(Ljdk/internal/icu/text/BidiBase;BB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getRunFromLogicalIndex", "(Ljdk/internal/icu/text/BidiBase;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "prepareReorder", "([B[B[B)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getLevels", "(Ljdk/internal/icu/text/BidiBase;)[B"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BidiLine(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public BidiLine() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiLine;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;)[I", "static")]
	public static JavaArray<int> getVisualMap(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;)V", "static")]
	public static void getRuns(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;Ljava/text/Bidi;Ljdk/internal/icu/text/BidiBase;II)Ljava/text/Bidi;", "static")]
	public static Dova.JDK.java.text.Bidi setLine(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0, Dova.JDK.java.text.Bidi arg1, Dova.JDK.jdk.@internal.icu.text.BidiBase arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.Bidi>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;I)B", "static")]
	public static byte getLevelAt(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;I)Ljdk/internal/icu/text/BidiRun;", "static")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiRun getVisualRun(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiRun>(ret);
	}

	[JniSignatureAttribute("([B)[I", "static")]
	public static JavaArray<int> reorderVisual(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;)V", "static")]
	public static void setTrailingWSStart(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;B)V", "private static")]
	public static void getSingleRun(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0, byte arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;BB)V", "private static")]
	public static void reorderLine(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0, byte arg1, byte arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;I)I", "static")]
	public static int getRunFromLogicalIndex(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([B[B[B)[I", "static")]
	public static JavaArray<int> prepareReorder(JavaArray<byte> arg0, JavaArray<byte> arg1, JavaArray<byte> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase;)[B", "static")]
	public static JavaArray<byte> getLevels(Dova.JDK.jdk.@internal.icu.text.BidiBase arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
