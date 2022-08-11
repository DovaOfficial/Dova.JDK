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

namespace Dova.JDK.jdk.@internal.org.jline.reader.impl;

[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/ReaderUtils;", "public")]
public partial class ReaderUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReaderUtils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/ReaderUtils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBoolean", "(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInt", "(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLong", "(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSet", "(Ljdk/internal/org/jline/reader/LineReader;Ljdk/internal/org/jline/reader/LineReader$Option;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "distance", "(Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getString", "(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ReaderUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ReaderUtils() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/ReaderUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;Z)Z", "public static")]
	public static bool getBoolean(Dova.JDK.jdk.@internal.org.jline.reader.LineReader arg0, Dova.JDK.java.lang.String arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;I)I", "public static")]
	public static int getInt(Dova.JDK.jdk.@internal.org.jline.reader.LineReader arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;J)J", "public static")]
	public static long getLong(Dova.JDK.jdk.@internal.org.jline.reader.LineReader arg0, Dova.JDK.java.lang.String arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader;Ljdk/internal/org/jline/reader/LineReader$Option;)Z", "public static")]
	public static bool isSet(Dova.JDK.jdk.@internal.org.jline.reader.LineReader arg0, Dova.JDK.jdk.@internal.org.jline.reader.LineReader.Option arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public static")]
	public static int distance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getString(Dova.JDK.jdk.@internal.org.jline.reader.LineReader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
