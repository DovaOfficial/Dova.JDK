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

namespace Dova.JDK.java.util;

[JniSignatureAttribute("Ljava/util/HexFormat;", "public final")]
public partial class HexFormat
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HexFormat()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/HexFormat;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "jla", "Ljdk/internal/access/JavaLangAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPPERCASE_DIGITS", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOWERCASE_DIGITS", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIGITS", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEX_FORMAT", "Ljava/util/HexFormat;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_BYTES", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delimiter", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefix", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suffix", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "digits", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUpperCase", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "()Ljava/util/HexFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prefix", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suffix", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delimiter", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withUpperCase", "()Ljava/util/HexFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHexDigits", "(C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHexDigits", "(S)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHexDigits", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHexDigits", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHexDigits", "(B)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHexDigits", "(Ljava/lang/Appendable;B)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHexDigits", "(JI)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatHex", "([B)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatHex", "(Ljava/lang/Appendable;[B)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatHex", "(Ljava/lang/Appendable;[BII)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatHex", "([BII)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatOptDelimiter", "([BII)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMaxArraySize", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHighHexDigit", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLowHexDigit", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseHex", "(Ljava/lang/CharSequence;II)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseHex", "([CII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseHex", "(Ljava/lang/CharSequence;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseNoDelimiter", "(Ljava/lang/CharSequence;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkLiteral", "(Ljava/lang/CharSequence;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromHexDigits", "(Ljava/lang/CharSequence;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromHexDigits", "(Ljava/lang/CharSequence;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromHexDigits", "(Ljava/lang/CharSequence;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "escapeNL", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromHexDigit", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkDigitCount", "(III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromHexDigitsToLong", "(Ljava/lang/CharSequence;II)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromHexDigitsToLong", "(Ljava/lang/CharSequence;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDelimiter", "(Ljava/lang/String;)Ljava/util/HexFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDelimiter", "(Ljava/lang/String;)Ljava/util/HexFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPrefix", "(Ljava/lang/String;)Ljava/util/HexFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSuffix", "(Ljava/lang/String;)Ljava/util/HexFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLowerCase", "()Ljava/util/HexFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isHexDigit", "(I)Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangAccess;", "private static final")]
	public static Dova.JDK.jdk.@internal.access.JavaLangAccess jla_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> UPPERCASE_DIGITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> LOWERCASE_DIGITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> DIGITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HexFormat;", "private static final")]
	public static Dova.JDK.java.util.HexFormat HEX_FORMAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HexFormat>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> EMPTY_BYTES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String delimiter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String prefix_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String suffix_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> digits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HexFormat(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", "private")]
	public HexFormat(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, JavaArray<byte> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/HexFormat;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUpperCase()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/HexFormat;", "public static")]
	public static Dova.JDK.java.util.HexFormat of()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.HexFormat>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String prefix()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String suffix()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String delimiter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/HexFormat;", "public")]
	public Dova.JDK.java.util.HexFormat withUpperCase()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.HexFormat>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toHexDigits(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(S)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toHexDigits(short arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toHexDigits(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toHexDigits(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(B)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toHexDigits(byte arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Appendable;B)Ljava/lang/Appendable;", "public")]
	public Dova.JDK.java.lang.Object toHexDigits(Dova.JDK.java.lang.Object arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(JI)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toHexDigits(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatHex(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Appendable;[B)Ljava/lang/Appendable;", "public")]
	public Dova.JDK.java.lang.Object formatHex(Dova.JDK.java.lang.Object arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Appendable;[BII)Ljava/lang/Appendable;", "public")]
	public Dova.JDK.java.lang.Object formatHex(Dova.JDK.java.lang.Object arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([BII)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatHex(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([BII)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String formatOptDelimiter(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)I", "private static")]
	public static int checkMaxArraySize(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char toHighHexDigit(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char toLowHexDigit(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)[B", "public")]
	public JavaArray<byte> parseHex(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([CII)[B", "public")]
	public JavaArray<byte> parseHex(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)[B", "public")]
	public JavaArray<byte> parseHex(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)[B", "private static")]
	public static JavaArray<byte> parseNoDelimiter(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;ILjava/lang/String;)V", "private static")]
	public static void checkLiteral(Dova.JDK.java.lang.CharSequence arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;I)I", "private static")]
	public static int fromHexDigits(Dova.JDK.java.lang.CharSequence arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)I", "public static")]
	public static int fromHexDigits(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)I", "public static")]
	public static int fromHexDigits(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String escapeNL(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int fromHexDigit(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("(III)I", "private static")]
	public static int checkDigitCount(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)J", "public static")]
	public static long fromHexDigitsToLong(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)J", "public static")]
	public static long fromHexDigitsToLong(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/HexFormat;", "public static")]
	public static Dova.JDK.java.util.HexFormat ofDelimiter(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.HexFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/HexFormat;", "public")]
	public Dova.JDK.java.util.HexFormat withDelimiter(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.HexFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/HexFormat;", "public")]
	public Dova.JDK.java.util.HexFormat withPrefix(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.HexFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/HexFormat;", "public")]
	public Dova.JDK.java.util.HexFormat withSuffix(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.HexFormat>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/HexFormat;", "public")]
	public Dova.JDK.java.util.HexFormat withLowerCase()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.HexFormat>(ret);
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isHexDigit(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[42], arg0);
		return ret;
	}
}
