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

namespace Dova.JDK.java.lang;

[JniSignatureAttribute("Ljava/lang/String;", "public final")]
public partial class String
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
	, Dova.JDK.java.lang.Comparable
	, Dova.JDK.java.lang.CharSequence
	, Dova.JDK.java.lang.constant.Constable
	, Dova.JDK.java.lang.constant.ConstantDesc
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static String()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/String;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "coder", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hash", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashIsZero", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPACT_STRINGS", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialPersistentFields", "[Ljava/io/ObjectStreamField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REPL", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CASE_INSENSITIVE_ORDER", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LATIN1", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UTF16", "B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/StringBuffer;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/StringBuilder;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([CIILjava/lang/Void;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/AbstractStringBuilder;Ljava/lang/Void;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BIILjava/nio/charset/Charset;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BLjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BLjava/nio/charset/Charset;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BB)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([CII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([C)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BIILjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BI)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BIII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkIndex", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChars", "(II[CI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "indexOf", "([BBILjava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "([C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(F)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(D)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "([CII)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "coder", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rangeCheck", "([CII)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkBoundsOffCount", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookupCharset", "(Ljava/lang/String;)Ljava/nio/charset/Charset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isNotContinuation", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decode2", "(II)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decodeUTF8_UTF16", "([BII[BIZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "scale", "(IF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decodeWithDecoder", "(Ljava/nio/charset/CharsetDecoder;[C[BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newStringNoRepl1", "([BLjava/nio/charset/Charset;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newStringUTF8NoRepl", "([BII)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwMalformed", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwMalformed", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodeUTF8", "(B[BZ)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encode8859_1", "(B[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encode8859_1", "(B[BZ)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodeASCII", "(B[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodeWithEncoder", "(Ljava/nio/charset/Charset;B[BZ)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "safeTrim", "([BIZ)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encode", "(Ljava/nio/charset/Charset;B[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBytesNoRepl1", "(Ljava/lang/String;Ljava/nio/charset/Charset;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isASCII", "([B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwUnmappable", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwUnmappable", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed3", "(III)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malformed3", "([BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decode3", "(III)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed3_2", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decode4", "(IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed4", "(III)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malformed4", "([BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed4_2", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMalformed4_3", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodeUTF8_UTF16", "([BZ)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLatin1", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "charAt", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "codePointAt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "codePointBefore", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "codePointCount", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "offsetByCodePoints", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkBoundsBeginEnd", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "(Ljava/nio/charset/Charset;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "([BIB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "(II[BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "([BIIBI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentEquals", "(Ljava/lang/CharSequence;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentEquals", "(Ljava/lang/StringBuffer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nonSyncContentEquals", "(Ljava/lang/AbstractStringBuilder;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "regionMatches", "(ZILjava/lang/String;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "regionMatches", "(ILjava/lang/String;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startsWith", "(Ljava/lang/String;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startsWith", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lastIndexOf", "([BBILjava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "substring", "(II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "substring", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(CC)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(Ljava/lang/String;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(Ljava/lang/String;I)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "join", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "join", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLowerCase", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLowerCase", "(Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUpperCase", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUpperCase", "(Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trim", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "strip", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripLeading", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripTrailing", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOfNonWhitespace", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lines", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repeat", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOfNonWhitespace", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "outdent", "(Ljava/util/List;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBlank", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCharArray", "()[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveConstantDesc_0", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveConstantDesc_1", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "codePoints", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newStringNoRepl", "([BLjava/nio/charset/Charset;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBytesUTF8NoRepl", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBytesNoRepl", "(Ljava/lang/String;Ljava/nio/charset/Charset;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decodeASCII", "([BI[CII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equalsIgnoreCase", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareToIgnoreCase", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endsWith", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subSequence", "(II)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "concat", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/lang/CharSequence;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indent", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripIndent", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateEscapes", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "chars", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/util/function/Function;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatted", "([Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyValueOf", "([CII)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyValueOf", "([C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intern", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkOffset", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOfCodePoint", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describeConstable", "()Ljava/util/Optional;"));
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("B", "private final")]
	public byte coder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int hash_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool hashIsZero_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool COMPACT_STRINGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("[Ljava/io/ObjectStreamField;", "private static final")]
	public static JavaArray<Dova.JDK.java.io.ObjectStreamField> serialPersistentFields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.ObjectStreamField>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("C", "private static final")]
	public static char REPL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "public static final")]
	public static Dova.JDK.java.util.Comparator CASE_INSENSITIVE_ORDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte LATIN1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte UTF16_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public String(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;)V", "public")]
	public String(Dova.JDK.java.lang.StringBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)V", "public")]
	public String(Dova.JDK.java.lang.StringBuilder arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("([CIILjava/lang/Void;)V", "")]
	public String(JavaArray<char> arg0, int arg1, int arg2, Dova.JDK.java.lang.Void arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/AbstractStringBuilder;Ljava/lang/Void;)V", "")]
	public String(Dova.JDK.java.lang.AbstractStringBuilder arg0, Dova.JDK.java.lang.Void arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([BIILjava/nio/charset/Charset;)V", "public")]
	public String(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.java.nio.charset.Charset arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("([BLjava/lang/String;)V", "public")]
	public String(JavaArray<byte> arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([BLjava/nio/charset/Charset;)V", "public")]
	public String(JavaArray<byte> arg0, Dova.JDK.java.nio.charset.Charset arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([BII)V", "public")]
	public String(JavaArray<byte> arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public String(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[8], arg0))
	{
	}

	[JniSignatureAttribute("([BB)V", "")]
	public String(JavaArray<byte> arg0, byte arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[9], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([CII)V", "public")]
	public String(JavaArray<char> arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[10], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("([C)V", "public")]
	public String(JavaArray<char> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[11], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public String(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[12], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public String() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[13]))
	{
	}

	[JniSignatureAttribute("([BIILjava/lang/String;)V", "public")]
	public String(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[14], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("([BI)V", "public")]
	public String(JavaArray<byte> arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[15], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([BIII)V", "public")]
	public String(JavaArray<byte> arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[16], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("([III)V", "public")]
	public String(JavaArray<int> arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[17], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/String;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[B", "")]
	public JavaArray<byte> value()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)V", "static")]
	public static void checkIndex(int arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(II[CI)V", "public")]
	public void getChars(int arg0, int arg1, JavaArray<char> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
	public int compareTo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int compareTo(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("([BBILjava/lang/String;I)I", "static")]
	public static int indexOf(JavaArray<byte> arg0, byte arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int indexOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int indexOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
	public int indexOf(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int indexOf(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(bool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([C)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(char arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(F)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(float arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(D)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([CII)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String valueOf(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()B", "")]
	public byte coder()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("([CII)Ljava/lang/Void;", "private static")]
	public static Dova.JDK.java.lang.Void rangeCheck(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(III)V", "static")]
	public static void checkBoundsOffCount(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/nio/charset/Charset;", "private static")]
	public static Dova.JDK.java.nio.charset.Charset lookupCharset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
	}

	[JniSignatureAttribute("(I)Z", "private static")]
	public static bool isNotContinuation(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)C", "private static")]
	public static char decode2(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BII[BIZ)I", "private static")]
	public static int decodeUTF8_UTF16(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, bool arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(IF)I", "private static")]
	public static int scale(int arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/charset/CharsetDecoder;[C[BII)I", "private static")]
	public static int decodeWithDecoder(Dova.JDK.java.nio.charset.CharsetDecoder arg0, JavaArray<char> arg1, JavaArray<byte> arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([BLjava/nio/charset/Charset;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String newStringNoRepl1(JavaArray<byte> arg0, Dova.JDK.java.nio.charset.Charset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([BII)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String newStringUTF8NoRepl(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)V", "private static")]
	public static void throwMalformed(int arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("([B)V", "private static")]
	public static void throwMalformed(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(B[BZ)[B", "private static")]
	public static JavaArray<byte> encodeUTF8(byte arg0, JavaArray<byte> arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(B[B)[B", "private static")]
	public static JavaArray<byte> encode8859_1(byte arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(B[BZ)[B", "private static")]
	public static JavaArray<byte> encode8859_1(byte arg0, JavaArray<byte> arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(B[B)[B", "private static")]
	public static JavaArray<byte> encodeASCII(byte arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;B[BZ)[B", "private static")]
	public static JavaArray<byte> encodeWithEncoder(Dova.JDK.java.nio.charset.Charset arg0, byte arg1, JavaArray<byte> arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BIZ)[B", "private static")]
	public static JavaArray<byte> safeTrim(JavaArray<byte> arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;B[B)[B", "private static")]
	public static JavaArray<byte> encode(Dova.JDK.java.nio.charset.Charset arg0, byte arg1, JavaArray<byte> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/charset/Charset;)[B", "private static")]
	public static JavaArray<byte> getBytesNoRepl1(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.charset.Charset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)Z", "private static")]
	public static bool isASCII(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private static")]
	public static void throwUnmappable(int arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("([B)V", "private static")]
	public static void throwUnmappable(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(III)Z", "private static")]
	public static bool isMalformed3(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([BI)I", "private static")]
	public static int malformed3(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(III)C", "private static")]
	public static char decode3(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "private static")]
	public static bool isMalformed3_2(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IIII)I", "private static")]
	public static int decode4(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(III)Z", "private static")]
	public static bool isMalformed4(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([BI)I", "private static")]
	public static int malformed4(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "private static")]
	public static bool isMalformed4_2(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private static")]
	public static bool isMalformed4_3(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[55], arg0);
		return ret;
	}

	[JniSignatureAttribute("([BZ)[B", "private static")]
	public static JavaArray<byte> encodeUTF8_UTF16(JavaArray<byte> arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isLatin1()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57]);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char charAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int codePointAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int codePointBefore(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int codePointCount(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int offsetByCodePoints(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(III)V", "static")]
	public static void checkBoundsBeginEnd(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[63], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;)[B", "public")]
	public JavaArray<byte> getBytes(Dova.JDK.java.nio.charset.Charset arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "public")]
	public JavaArray<byte> getBytes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BIB)V", "")]
	public void getBytes(JavaArray<byte> arg0, int arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(II[BI)V", "public")]
	public void getBytes(int arg0, int arg1, JavaArray<byte> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([BIIBI)V", "")]
	public void getBytes(JavaArray<byte> arg0, int arg1, int arg2, byte arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getBytes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Z", "public")]
	public bool contentEquals(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;)Z", "public")]
	public bool contentEquals(Dova.JDK.java.lang.StringBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/AbstractStringBuilder;)Z", "private")]
	public bool nonSyncContentEquals(Dova.JDK.java.lang.AbstractStringBuilder arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ZILjava/lang/String;II)Z", "public")]
	public bool regionMatches(bool arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;II)Z", "public")]
	public bool regionMatches(int arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Z", "public")]
	public bool startsWith(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool startsWith(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int lastIndexOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int lastIndexOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
		return ret;
	}

	[JniSignatureAttribute("([BBILjava/lang/String;I)I", "static")]
	public static int lastIndexOf(JavaArray<byte> arg0, byte arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[79], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
	public int lastIndexOf(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int lastIndexOf(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String substring(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String substring(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[84]);
		return ret;
	}

	[JniSignatureAttribute("(CC)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replace(char arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replace(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool matches(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replaceFirst(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replaceAll(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> split(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> split(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;", "public static transient")]
	public static Dova.JDK.java.lang.String join(Dova.JDK.java.lang.CharSequence arg0, JavaArray<Dova.JDK.java.lang.CharSequence> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[92], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String join(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.lang.Iterable arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[93], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String join(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.String> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[94], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toLowerCase()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toLowerCase(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toUpperCase()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toUpperCase(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String trim()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[99]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String strip()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String stripLeading()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[101]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String stripTrailing()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int indexOfNonWhitespace()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[103]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream lines()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String repeat(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int lastIndexOfNonWhitespace()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[106]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)I", "private static")]
	public static int outdent(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[107], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isBlank()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[108]);
		return ret;
	}

	[JniSignatureAttribute("()[C", "public")]
	public JavaArray<char> toCharArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109]);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "public static transient")]
	public static Dova.JDK.java.lang.String format(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[110], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "public static transient")]
	public static Dova.JDK.java.lang.String format(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[111], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object resolveConstantDesc_0(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[112], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String resolveConstantDesc_1(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream codePoints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("([BLjava/nio/charset/Charset;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String newStringNoRepl(JavaArray<byte> arg0, Dova.JDK.java.nio.charset.Charset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[115], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "static")]
	public static JavaArray<byte> getBytesUTF8NoRepl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[116], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/charset/Charset;)[B", "static")]
	public static JavaArray<byte> getBytesNoRepl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.charset.Charset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[117], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BI[CII)I", "static")]
	public static int decodeASCII(JavaArray<byte> arg0, int arg1, JavaArray<char> arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[118], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool equalsIgnoreCase(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[119], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int compareToIgnoreCase(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[120], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool endsWith(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[121], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/lang/CharSequence;", "public")]
	public Dova.JDK.java.lang.CharSequence subSequence(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String concat(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[123], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Z", "public")]
	public bool contains(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[124], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String indent(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[125], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String stripIndent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[126]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String translateEscapes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[127]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public")]
	public Dova.JDK.java.util.stream.IntStream chars()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[128]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object transform(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[129], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/String;", "public transient")]
	public Dova.JDK.java.lang.String formatted(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[130], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([CII)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String copyValueOf(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[131], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([C)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String copyValueOf(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[132], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public native")]
	public Dova.JDK.java.lang.String intern()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[133]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)V", "static")]
	public static void checkOffset(int arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[134], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String valueOfCodePoint(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[135], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional describeConstable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[136]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/String$CaseInsensitiveComparator;", "private static")]
	public partial class CaseInsensitiveComparator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Comparator
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CaseInsensitiveComparator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/String$CaseInsensitiveComparator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/String;Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readResolve", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CaseInsensitiveComparator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CaseInsensitiveComparator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/String$CaseInsensitiveComparator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)I", "public volatile")]
		public int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
		public int compare(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object readResolve()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
