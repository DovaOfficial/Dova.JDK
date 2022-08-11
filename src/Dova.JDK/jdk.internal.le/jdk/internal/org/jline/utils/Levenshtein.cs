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

namespace Dova.JDK.jdk.@internal.org.jline.utils;

[JniSignatureAttribute("Ljdk/internal/org/jline/utils/Levenshtein;", "public")]
public partial class Levenshtein
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Levenshtein()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/utils/Levenshtein;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "distance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "distance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;IIII)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Levenshtein(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Levenshtein() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/utils/Levenshtein;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "public static")]
	public static int distance(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;IIII)I", "public static")]
	public static int distance(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2, int arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}
}
