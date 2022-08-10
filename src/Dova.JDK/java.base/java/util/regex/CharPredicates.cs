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

namespace Dova.JDK.java.util.regex;

[JniSignatureAttribute("Ljava/util/regex/CharPredicates;", "")]
public partial class CharPredicates
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CharPredicates()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/CharPredicates;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CharPredicates", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "CONTROL", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "range", "(II)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "UPPERCASE", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "category", "(I)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ctype", "(I)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "DIGIT", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "BLANK", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ALNUM", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "GRAPH", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "WORD", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ALPHABETIC", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "JOIN_CONTROL", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "PRINT", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "LOWERCASE", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "TITLECASE", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "WHITE_SPACE", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "PUNCTUATION", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "HEX_DIGIT", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ASSIGNED", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "IDEOGRAPHIC", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "LETTER", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "NONCHARACTER_CODE_POINT", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getUnicodePredicate", "(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPosixPredicate", "(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "forUnicodeProperty", "(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "forPOSIXName", "(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "forUnicodeScript", "(Ljava/lang/String;)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "forUnicodeBlock", "(Ljava/lang/String;)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "forProperty", "(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ASCII_DIGIT", "()Ljava/util/regex/Pattern$BmpCharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ASCII_WORD", "()Ljava/util/regex/Pattern$BmpCharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ASCII_SPACE", "()Ljava/util/regex/Pattern$BmpCharPredicate;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CharPredicates(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public CharPredicates() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/regex/CharPredicates;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate CONTROL()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate range(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate UPPERCASE()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate category(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate ctype(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate DIGIT()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate BLANK()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate ALNUM()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate GRAPH()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate WORD()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate ALPHABETIC()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate JOIN_CONTROL()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate PRINT()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate LOWERCASE()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate TITLECASE()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate WHITE_SPACE()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate PUNCTUATION()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate HEX_DIGIT()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate ASSIGNED()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate IDEOGRAPHIC()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate LETTER()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate NONCHARACTER_CODE_POINT()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate getUnicodePredicate(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate getPosixPredicate(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;", "public static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate forUnicodeProperty(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;", "public static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate forPOSIXName(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate forUnicodeScript(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate forUnicodeBlock(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate forProperty(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$BmpCharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.BmpCharPredicate ASCII_DIGIT()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.BmpCharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$BmpCharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.BmpCharPredicate ASCII_WORD()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.BmpCharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$BmpCharPredicate;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.BmpCharPredicate ASCII_SPACE()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.BmpCharPredicate>(ret);
	}
}
