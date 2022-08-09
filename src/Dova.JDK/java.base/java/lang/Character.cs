/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.lang;

[JniSignatureAttribute("Ljava/lang/Character;", "public final")]
public partial class Character
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
	, Dova.JDK.java.lang.Comparable
	, Dova.JDK.java.lang.constant.Constable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Character()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/Character;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_RADIX", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_RADIX", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_VALUE", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_VALUE", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UNASSIGNED", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UPPERCASE_LETTER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LOWERCASE_LETTER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TITLECASE_LETTER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODIFIER_LETTER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_LETTER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NON_SPACING_MARK", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ENCLOSING_MARK", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMBINING_SPACING_MARK", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DECIMAL_DIGIT_NUMBER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LETTER_NUMBER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_NUMBER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SPACE_SEPARATOR", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LINE_SEPARATOR", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PARAGRAPH_SEPARATOR", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTROL", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FORMAT", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PRIVATE_USE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SURROGATE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DASH_PUNCTUATION", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "START_PUNCTUATION", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "END_PUNCTUATION", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONNECTOR_PUNCTUATION", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_PUNCTUATION", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MATH_SYMBOL", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CURRENCY_SYMBOL", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODIFIER_SYMBOL", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_SYMBOL", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_QUOTE_PUNCTUATION", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FINAL_QUOTE_PUNCTUATION", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ERROR", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_UNDEFINED", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_LEFT_TO_RIGHT", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_EUROPEAN_NUMBER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_ARABIC_NUMBER", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_COMMON_NUMBER_SEPARATOR", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_NONSPACING_MARK", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_BOUNDARY_NEUTRAL", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_PARAGRAPH_SEPARATOR", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_SEGMENT_SEPARATOR", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_WHITESPACE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_OTHER_NEUTRALS", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_POP_DIRECTIONAL_FORMAT", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_LEFT_TO_RIGHT_ISOLATE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_ISOLATE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_FIRST_STRONG_ISOLATE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_POP_DIRECTIONAL_ISOLATE", "B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_HIGH_SURROGATE", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_HIGH_SURROGATE", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_LOW_SURROGATE", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_LOW_SURROGATE", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_SURROGATE", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_SURROGATE", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_SUPPLEMENTARY_CODE_POINT", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_CODE_POINT", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_CODE_POINT", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "value", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SIZE", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BYTES", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Character", "(C)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isJavaIdentifierStart", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isJavaIdentifierStart", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isJavaIdentifierPart", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isJavaIdentifierPart", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toString", "(C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "hashCode", "(C)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "reverseBytes", "(C)C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compareTo", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compareTo", "(Ljava/lang/Character;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDigit", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDigit", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isLowerCase", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isLowerCase", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isUpperCase", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isUpperCase", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isWhitespace", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isWhitespace", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compare", "(CC)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "charValue", "()C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(C)Ljava/lang/Character;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toChars", "(I)[C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toChars", "(I[CI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isHighSurrogate", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isLowSurrogate", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isSurrogate", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isSupplementaryCodePoint", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "highSurrogate", "(I)C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lowSurrogate", "(I)C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toCodePoint", "(CC)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointAt", "([CI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointAt", "(Ljava/lang/CharSequence;I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointAt", "([CII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointBefore", "(Ljava/lang/CharSequence;I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointBefore", "([CI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointBefore", "([CII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointCount", "([CII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointCount", "(Ljava/lang/CharSequence;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "offsetByCodePoints", "(Ljava/lang/CharSequence;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "offsetByCodePoints", "([CIIII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toLowerCase", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toLowerCase", "(C)C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toUpperCase", "(C)C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toUpperCase", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isBmpCodePoint", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "describeConstable", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getType", "(C)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getType", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isLetter", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isLetter", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isLetterOrDigit", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isLetterOrDigit", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointAtImpl", "([CII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointBeforeImpl", "([CII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isValidCodePoint", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toSurrogates", "(I[CI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointCountImpl", "([CII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "offsetByCodePointsImpl", "([CIIII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isTitleCase", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isTitleCase", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDefined", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDefined", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isIdeographic", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isUnicodeIdentifierStart", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isUnicodeIdentifierStart", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isUnicodeIdentifierPart", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isUnicodeIdentifierPart", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isIdentifierIgnorable", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isIdentifierIgnorable", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toTitleCase", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toTitleCase", "(C)C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "digit", "(II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "digit", "(CI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getNumericValue", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getNumericValue", "(C)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isSpaceChar", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isSpaceChar", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isISOControl", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isISOControl", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getDirectionality", "(I)B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getDirectionality", "(C)B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isMirrored", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isMirrored", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toUpperCaseEx", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toUpperCaseCharArray", "(I)[C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isSurrogatePair", "(CC)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "charCount", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isJavaLetter", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isJavaLetterOrDigit", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isAlphabetic", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isSpace", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "forDigit", "(II)C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "codePointOf", "(Ljava/lang/String;)I"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MIN_RADIX_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_RADIX_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char MIN_VALUE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char MAX_VALUE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "public static final")]
	public static Dova.JDK.java.lang.Class TYPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte UNASSIGNED_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte UPPERCASE_LETTER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte LOWERCASE_LETTER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte TITLECASE_LETTER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte MODIFIER_LETTER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte OTHER_LETTER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte NON_SPACING_MARK_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ENCLOSING_MARK_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte COMBINING_SPACING_MARK_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DECIMAL_DIGIT_NUMBER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte LETTER_NUMBER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte OTHER_NUMBER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[16], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte SPACE_SEPARATOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[17], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte LINE_SEPARATOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[18], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte PARAGRAPH_SEPARATOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[19], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONTROL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[20], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte FORMAT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[21], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte PRIVATE_USE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[22], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte SURROGATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[23], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DASH_PUNCTUATION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[24], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte START_PUNCTUATION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[25], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte END_PUNCTUATION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[26], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONNECTOR_PUNCTUATION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[27], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte OTHER_PUNCTUATION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[28], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte MATH_SYMBOL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[29], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CURRENCY_SYMBOL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[30], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte MODIFIER_SYMBOL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[31], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte OTHER_SYMBOL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[32]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[32], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte INITIAL_QUOTE_PUNCTUATION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[33]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[33], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte FINAL_QUOTE_PUNCTUATION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[34]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[34], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ERROR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[35]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[35], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_UNDEFINED_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[36]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[36], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_LEFT_TO_RIGHT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[37]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[37], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_RIGHT_TO_LEFT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[38]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[38], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[39]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[39], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_EUROPEAN_NUMBER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[40]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[40], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[41]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[41], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[42]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[42], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_ARABIC_NUMBER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[43], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_COMMON_NUMBER_SEPARATOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[44]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[44], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_NONSPACING_MARK_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[45]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[45], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_BOUNDARY_NEUTRAL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[46]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[46], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_PARAGRAPH_SEPARATOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[47]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[47], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_SEGMENT_SEPARATOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[48]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[48], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_WHITESPACE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[49]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[49], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_OTHER_NEUTRALS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[50]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[50], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[51]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[51], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[52]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[52], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[53]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[53], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[54]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[54], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_POP_DIRECTIONAL_FORMAT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[55]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[55], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_LEFT_TO_RIGHT_ISOLATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[56]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[56], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_RIGHT_TO_LEFT_ISOLATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[57]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[57], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_FIRST_STRONG_ISOLATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[58]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[58], value);
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte DIRECTIONALITY_POP_DIRECTIONAL_ISOLATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[59]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[59], value);
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char MIN_HIGH_SURROGATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[60]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[60], value);
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char MAX_HIGH_SURROGATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[61]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[61], value);
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char MIN_LOW_SURROGATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[62]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[62], value);
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char MAX_LOW_SURROGATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[63]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[63], value);
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char MIN_SURROGATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[64]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[64], value);
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char MAX_SURROGATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[65]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[65], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MIN_SUPPLEMENTARY_CODE_POINT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[66]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[66], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MIN_CODE_POINT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[67]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[67], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_CODE_POINT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[68]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[68], value);
	}

	[JniSignatureAttribute("C", "private final")]
	public char value_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[69]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[69], value);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[70]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[70], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SIZE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[71]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[71], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int BYTES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[72]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[72], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[73]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[73], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Character(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(C)V", "public")]
	public Character(char arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/Character;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getName(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isJavaIdentifierStart(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isJavaIdentifierStart(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isJavaIdentifierPart(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isJavaIdentifierPart(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(C)I", "public static")]
	public static int hashCode(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(C)C", "public static")]
	public static char reverseBytes(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
	public int compareTo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Character;)I", "public")]
	public int compareTo(Dova.JDK.java.lang.Character arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isDigit(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isDigit(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isLowerCase(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isLowerCase(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isUpperCase(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isUpperCase(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isWhitespace(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isWhitespace(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(CC)I", "public static")]
	public static int compare(char arg0, char arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char charValue()
	{
		var ret = DovaJvm.Vm.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(C)Ljava/lang/Character;", "public static")]
	public static Dova.JDK.java.lang.Character valueOf(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character>(ret);
	}

	[JniSignatureAttribute("(I)[C", "public static")]
	public static JavaArray<char> toChars(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(I[CI)I", "public static")]
	public static int toChars(int arg0, JavaArray<char> arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isHighSurrogate(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isLowSurrogate(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isSurrogate(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isSupplementaryCodePoint(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public static")]
	public static char highSurrogate(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public static")]
	public static char lowSurrogate(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(CC)I", "public static")]
	public static int toCodePoint(char arg0, char arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([CI)I", "public static")]
	public static int codePointAt(JavaArray<char> arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;I)I", "public static")]
	public static int codePointAt(Dova.JDK.java.lang.CharSequence arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([CII)I", "public static")]
	public static int codePointAt(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;I)I", "public static")]
	public static int codePointBefore(Dova.JDK.java.lang.CharSequence arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([CI)I", "public static")]
	public static int codePointBefore(JavaArray<char> arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([CII)I", "public static")]
	public static int codePointBefore(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([CII)I", "public static")]
	public static int codePointCount(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)I", "public static")]
	public static int codePointCount(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)I", "public static")]
	public static int offsetByCodePoints(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([CIIII)I", "public static")]
	public static int offsetByCodePoints(JavaArray<char> arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int toLowerCase(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)C", "public static")]
	public static char toLowerCase(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[45], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)C", "public static")]
	public static char toUpperCase(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int toUpperCase(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[47], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isBmpCodePoint(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional describeConstable()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(C)I", "public static")]
	public static int getType(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[50], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int getType(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[51], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isLetter(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[52], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isLetter(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[53], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isLetterOrDigit(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[54], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isLetterOrDigit(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[55], arg0);
		return ret;
	}

	[JniSignatureAttribute("([CII)I", "static")]
	public static int codePointAtImpl(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([CII)I", "static")]
	public static int codePointBeforeImpl(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isValidCodePoint(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[58], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I[CI)V", "static")]
	public static void toSurrogates(int arg0, JavaArray<char> arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([CII)I", "static")]
	public static int codePointCountImpl(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([CIIII)I", "static")]
	public static int offsetByCodePointsImpl(JavaArray<char> arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isTitleCase(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isTitleCase(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[63], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isDefined(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isDefined(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[65], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isIdeographic(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[66], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isUnicodeIdentifierStart(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[67], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isUnicodeIdentifierStart(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[68], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isUnicodeIdentifierPart(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[69], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isUnicodeIdentifierPart(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[70], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isIdentifierIgnorable(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[71], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isIdentifierIgnorable(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[72], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int toTitleCase(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[73], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)C", "public static")]
	public static char toTitleCase(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[74], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public static")]
	public static int digit(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(CI)I", "public static")]
	public static int digit(char arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int getNumericValue(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[77], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)I", "public static")]
	public static int getNumericValue(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[78], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isSpaceChar(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[79], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isSpaceChar(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[80], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isISOControl(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[81], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isISOControl(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[82], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)B", "public static")]
	public static byte getDirectionality(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[83], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)B", "public static")]
	public static byte getDirectionality(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[84], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isMirrored(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[85], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isMirrored(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[86], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "static")]
	public static int toUpperCaseEx(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[87], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)[C", "static")]
	public static JavaArray<char> toUpperCaseCharArray(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[88], arg0);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(CC)Z", "public static")]
	public static bool isSurrogatePair(char arg0, char arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[89], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int charCount(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[90], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isJavaLetter(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[91], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isJavaLetterOrDigit(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[92], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public static")]
	public static bool isAlphabetic(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[93], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "public static")]
	public static bool isSpace(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[94], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)C", "public static")]
	public static char forDigit(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[95], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public static")]
	public static int codePointOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[96], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljava/lang/Character$CharacterCache;", "private static")]
	public partial class CharacterCache
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CharacterCache()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/Character$CharacterCache;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cache", "[Ljava/lang/Character;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "archivedCache", "[Ljava/lang/Character;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CharacterCache", "()V"));
		}

		[JniSignatureAttribute("[Ljava/lang/Character;", "static final")]
		public static JavaArray<Dova.JDK.java.lang.Character> cache_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Character>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/lang/Character;", "static")]
		public static JavaArray<Dova.JDK.java.lang.Character> archivedCache_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Character>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CharacterCache(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CharacterCache() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/Character$CharacterCache;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
	public partial class UnicodeBlock
		: Dova.JDK.java.lang.Character.Subset
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnicodeBlock()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/Character$UnicodeBlock;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NUM_ENTITIES", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "map", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BASIC_LATIN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LATIN_1_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LATIN_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LATIN_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IPA_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SPACING_MODIFIER_LETTERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMBINING_DIACRITICAL_MARKS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GREEK", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CYRILLIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARMENIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HEBREW", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARABIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEVANAGARI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BENGALI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GURMUKHI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GUJARATI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ORIYA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAMIL", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TELUGU", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KANNADA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MALAYALAM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "THAI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LAO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TIBETAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GEORGIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANGUL_JAMO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LATIN_EXTENDED_ADDITIONAL", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GREEK_EXTENDED", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GENERAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPERSCRIPTS_AND_SUBSCRIPTS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CURRENCY_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMBINING_MARKS_FOR_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LETTERLIKE_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARROWS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MISCELLANEOUS_TECHNICAL", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTROL_PICTURES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OPTICAL_CHARACTER_RECOGNITION", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ENCLOSED_ALPHANUMERICS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BOX_DRAWING", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BLOCK_ELEMENTS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GEOMETRIC_SHAPES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MISCELLANEOUS_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DINGBATS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HIRAGANA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KATAKANA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BOPOMOFO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANGUL_COMPATIBILITY_JAMO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KANBUN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ENCLOSED_CJK_LETTERS_AND_MONTHS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_COMPATIBILITY", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_UNIFIED_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANGUL_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PRIVATE_USE_AREA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_COMPATIBILITY_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ALPHABETIC_PRESENTATION_FORMS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARABIC_PRESENTATION_FORMS_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMBINING_HALF_MARKS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_COMPATIBILITY_FORMS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SMALL_FORM_VARIANTS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARABIC_PRESENTATION_FORMS_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HALFWIDTH_AND_FULLWIDTH_FORMS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SPECIALS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SURROGATES_AREA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SYRIAC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "THAANA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SINHALA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MYANMAR", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ETHIOPIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHEROKEE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OGHAM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RUNIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHMER", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MONGOLIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BRAILLE_PATTERNS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_RADICALS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KANGXI_RADICALS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IDEOGRAPHIC_DESCRIPTION_CHARACTERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BOPOMOFO_EXTENDED", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "YI_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "YI_RADICALS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CYRILLIC_SUPPLEMENTARY", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAGALOG", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANUNOO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BUHID", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAGBANWA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LIMBU", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAI_LE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHMER_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPLEMENTAL_ARROWS_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPLEMENTAL_ARROWS_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPLEMENTAL_MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MISCELLANEOUS_SYMBOLS_AND_ARROWS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KATAKANA_PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "YIJING_HEXAGRAM_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VARIATION_SELECTORS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LINEAR_B_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LINEAR_B_IDEOGRAMS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AEGEAN_NUMBERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_ITALIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GOTHIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UGARITIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DESERET", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHAVIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OSMANYA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CYPRIOT_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BYZANTINE_MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAI_XUAN_JING_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MATHEMATICAL_ALPHANUMERIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAGS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VARIATION_SELECTORS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPLEMENTARY_PRIVATE_USE_AREA_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPLEMENTARY_PRIVATE_USE_AREA_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HIGH_SURROGATES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HIGH_PRIVATE_USE_SURROGATES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LOW_SURROGATES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARABIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NKO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SAMARITAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MANDAIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ETHIOPIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS_EXTENDED", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NEW_TAI_LUE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BUGINESE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAI_THAM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BALINESE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUNDANESE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BATAK", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LEPCHA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OL_CHIKI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VEDIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PHONETIC_EXTENSIONS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMBINING_DIACRITICAL_MARKS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GLAGOLITIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LATIN_EXTENDED_C", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COPTIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GEORGIAN_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TIFINAGH", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ETHIOPIC_EXTENDED", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CYRILLIC_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPLEMENTAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_STROKES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LISU", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VAI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CYRILLIC_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BAMUM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODIFIER_TONE_LETTERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LATIN_EXTENDED_D", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SYLOTI_NAGRI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMMON_INDIC_NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PHAGS_PA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SAURASHTRA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEVANAGARI_EXTENDED", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KAYAH_LI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REJANG", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANGUL_JAMO_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JAVANESE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHAM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MYANMAR_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAI_VIET", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ETHIOPIC_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEETEI_MAYEK", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANGUL_JAMO_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VERTICAL_FORMS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ANCIENT_GREEK_NUMBERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ANCIENT_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PHAISTOS_DISC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LYCIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CARIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_PERSIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IMPERIAL_ARAMAIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PHOENICIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LYDIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHAROSHTHI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_SOUTH_ARABIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AVESTAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INSCRIPTIONAL_PARTHIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INSCRIPTIONAL_PAHLAVI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_TURKIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RUMI_NUMERAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BRAHMI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KAITHI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CUNEIFORM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CUNEIFORM_NUMBERS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EGYPTIAN_HIEROGLYPHS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BAMUM_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KANA_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ANCIENT_GREEK_MUSICAL_NOTATION", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COUNTING_ROD_NUMERALS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAHJONG_TILES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DOMINO_TILES", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PLAYING_CARDS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ENCLOSED_ALPHANUMERIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ENCLOSED_IDEOGRAPHIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MISCELLANEOUS_SYMBOLS_AND_PICTOGRAPHS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EMOTICONS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TRANSPORT_AND_MAP_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ALCHEMICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_C", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_D", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARABIC_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUNDANESE_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEETEI_MAYEK_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEROITIC_HIEROGLYPHS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEROITIC_CURSIVE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SORA_SOMPENG", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHAKMA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHARADA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAKRI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIAO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARABIC_MATHEMATICAL_ALPHABETIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMBINING_DIACRITICAL_MARKS_EXTENDED", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MYANMAR_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LATIN_EXTENDED_E", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COPTIC_EPACT_NUMBERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_PERMIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ELBASAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CAUCASIAN_ALBANIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LINEAR_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PALMYRENE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NABATAEAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_NORTH_ARABIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MANICHAEAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PSALTER_PAHLAVI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAHAJANI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SINHALA_ARCHAIC_NUMBERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHOJKI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHUDAWADI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GRANTHA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TIRHUTA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SIDDHAM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "WARANG_CITI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PAU_CIN_HAU", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MRO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BASSA_VAH", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PAHAWH_HMONG", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DUPLOYAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHORTHAND_FORMAT_CONTROLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MENDE_KIKAKUI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ORNAMENTAL_DINGBATS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GEOMETRIC_SHAPES_EXTENDED", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPLEMENTAL_ARROWS_C", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHEROKEE_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HATRAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_HUNGARIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MULTANI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AHOM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EARLY_DYNASTIC_CUNEIFORM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ANATOLIAN_HIEROGLYPHS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUTTON_SIGNWRITING", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPLEMENTAL_SYMBOLS_AND_PICTOGRAPHS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_E", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SYRIAC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CYRILLIC_EXTENDED_C", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OSAGE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NEWA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MONGOLIAN_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MARCHEN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IDEOGRAPHIC_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TANGUT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TANGUT_COMPONENTS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KANA_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GLAGOLITIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ADLAM", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MASARAM_GONDI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ZANABAZAR_SQUARE", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NUSHU", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SOYOMBO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BHAIKSUKI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_F", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GEORGIAN_EXTENDED", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANIFI_ROHINGYA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_SOGDIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SOGDIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DOGRA", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GUNJALA_GONDI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAKASAR", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEDEFAIDRIN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAYAN_NUMERALS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INDIC_SIYAQ_NUMBERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHESS_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ELYMAIC", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NANDINAGARI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAMIL_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EGYPTIAN_HIEROGLYPH_FORMAT_CONTROLS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SMALL_KANA_EXTENSION", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NYIAKENG_PUACHUE_HMONG", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "WANCHO", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTTOMAN_SIYAQ_NUMBERS", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SYMBOLS_AND_PICTOGRAPHS_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "YEZIDI", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHORASMIAN", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIVES_AKURU", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LISU_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHITAN_SMALL_SCRIPT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TANGUT_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SYMBOLS_FOR_LEGACY_COMPUTING", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_G", "Ljava/lang/Character$UnicodeBlock;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "blockStarts", "[I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "blocks", "[Ljava/lang/Character$UnicodeBlock;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnicodeBlock", "(Ljava/lang/String;[Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnicodeBlock", "(Ljava/lang/String;Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnicodeBlock", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(I)Ljava/lang/Character$UnicodeBlock;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(C)Ljava/lang/Character$UnicodeBlock;"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int NUM_ENTITIES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static")]
		public static Dova.JDK.java.util.Map map_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BASIC_LATIN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LATIN_1_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LATIN_EXTENDED_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LATIN_EXTENDED_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock IPA_EXTENSIONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SPACING_MODIFIER_LETTERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GREEK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CYRILLIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ARMENIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HEBREW_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ARABIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock DEVANAGARI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BENGALI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GURMUKHI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GUJARATI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ORIYA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAMIL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TELUGU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KANNADA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MALAYALAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock THAI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LAO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TIBETAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GEORGIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HANGUL_JAMO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LATIN_EXTENDED_ADDITIONAL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GREEK_EXTENDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GENERAL_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CURRENCY_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LETTERLIKE_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock NUMBER_FORMS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ARROWS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MATHEMATICAL_OPERATORS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MISCELLANEOUS_TECHNICAL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CONTROL_PICTURES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OPTICAL_CHARACTER_RECOGNITION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERICS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BOX_DRAWING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BLOCK_ELEMENTS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GEOMETRIC_SHAPES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock DINGBATS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HIRAGANA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KATAKANA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BOPOMOFO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HANGUL_COMPATIBILITY_JAMO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KANBUN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HANGUL_SYLLABLES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PRIVATE_USE_AREA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ALPHABETIC_PRESENTATION_FORMS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COMBINING_HALF_MARKS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_FORMS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SMALL_FORM_VARIANTS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SPECIALS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SURROGATES_AREA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SYRIAC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock THAANA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SINHALA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MYANMAR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ETHIOPIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CHEROKEE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OGHAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock RUNIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KHMER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MONGOLIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BRAILLE_PATTERNS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_RADICALS_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KANGXI_RADICALS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BOPOMOFO_EXTENDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock YI_SYLLABLES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock YI_RADICALS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CYRILLIC_SUPPLEMENTARY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAGALOG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HANUNOO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BUHID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAGBANWA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LIMBU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAI_LE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KHMER_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PHONETIC_EXTENSIONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock YIJING_HEXAGRAM_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock VARIATION_SELECTORS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LINEAR_B_SYLLABARY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LINEAR_B_IDEOGRAMS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock AEGEAN_NUMBERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OLD_ITALIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GOTHIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock UGARITIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock DESERET_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SHAVIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OSMANYA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CYPRIOT_SYLLABARY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MUSICAL_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAI_XUAN_JING_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAGS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HIGH_SURROGATES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HIGH_PRIVATE_USE_SURROGATES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LOW_SURROGATES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ARABIC_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock NKO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SAMARITAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MANDAIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ETHIOPIC_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS_EXTENDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock NEW_TAI_LUE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BUGINESE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAI_THAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BALINESE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUNDANESE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BATAK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LEPCHA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OL_CHIKI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock VEDIC_EXTENSIONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PHONETIC_EXTENSIONS_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GLAGOLITIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LATIN_EXTENDED_C_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COPTIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GEORGIAN_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TIFINAGH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ETHIOPIC_EXTENDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CYRILLIC_EXTENDED_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[151]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[151], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPPLEMENTAL_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[152]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[152], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_STROKES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[153]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[153], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LISU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[154]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[154], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock VAI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[155]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[155], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CYRILLIC_EXTENDED_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[156]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[156], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BAMUM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[157]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[157], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MODIFIER_TONE_LETTERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[158]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[158], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LATIN_EXTENDED_D_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[159]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[159], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SYLOTI_NAGRI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[160]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[160], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COMMON_INDIC_NUMBER_FORMS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[161]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[161], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PHAGS_PA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[162]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[162], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SAURASHTRA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[163]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[163], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock DEVANAGARI_EXTENDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[164]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[164], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KAYAH_LI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[165]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[165], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock REJANG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[166]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[166], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HANGUL_JAMO_EXTENDED_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[167]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[167], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock JAVANESE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[168]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[168], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CHAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[169]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[169], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MYANMAR_EXTENDED_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[170]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[170], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAI_VIET_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[171]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[171], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ETHIOPIC_EXTENDED_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[172]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[172], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MEETEI_MAYEK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[173]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[173], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HANGUL_JAMO_EXTENDED_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[174]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[174], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock VERTICAL_FORMS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[175]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[175], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ANCIENT_GREEK_NUMBERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[176]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[176], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ANCIENT_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[177]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[177], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PHAISTOS_DISC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[178]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[178], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LYCIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[179]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[179], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CARIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[180]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[180], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OLD_PERSIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[181]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[181], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock IMPERIAL_ARAMAIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[182]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[182], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PHOENICIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[183]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[183], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LYDIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[184]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[184], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KHAROSHTHI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[185]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[185], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OLD_SOUTH_ARABIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[186]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[186], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock AVESTAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[187]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[187], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock INSCRIPTIONAL_PARTHIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[188]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[188], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock INSCRIPTIONAL_PAHLAVI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[189]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[189], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OLD_TURKIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[190]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[190], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock RUMI_NUMERAL_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[191]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[191], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BRAHMI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[192]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[192], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KAITHI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[193]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[193], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CUNEIFORM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[194]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[194], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CUNEIFORM_NUMBERS_AND_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[195]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[195], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock EGYPTIAN_HIEROGLYPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[196]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[196], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BAMUM_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[197]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[197], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KANA_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[198]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[198], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ANCIENT_GREEK_MUSICAL_NOTATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[199]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[199], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COUNTING_ROD_NUMERALS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[200]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[200], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MAHJONG_TILES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[201]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[201], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock DOMINO_TILES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[202]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[202], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PLAYING_CARDS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[203]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[203], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERIC_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[204]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[204], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ENCLOSED_IDEOGRAPHIC_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[205]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[205], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_PICTOGRAPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[206]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[206], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock EMOTICONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[207]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[207], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TRANSPORT_AND_MAP_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[208]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[208], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ALCHEMICAL_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[209]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[209], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_C_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[210]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[210], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_D_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[211]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[211], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ARABIC_EXTENDED_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[212]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[212], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUNDANESE_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[213]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[213], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MEETEI_MAYEK_EXTENSIONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[214]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[214], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MEROITIC_HIEROGLYPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[215]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[215], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MEROITIC_CURSIVE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[216]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[216], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SORA_SOMPENG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[217]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[217], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CHAKMA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[218]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[218], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SHARADA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[219]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[219], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAKRI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[220]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[220], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MIAO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[221]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[221], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ARABIC_MATHEMATICAL_ALPHABETIC_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[222]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[222], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS_EXTENDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[223]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[223], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MYANMAR_EXTENDED_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[224]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[224], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LATIN_EXTENDED_E_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[225]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[225], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock COPTIC_EPACT_NUMBERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[226]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[226], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OLD_PERMIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[227]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[227], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ELBASAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[228]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[228], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CAUCASIAN_ALBANIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[229]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[229], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LINEAR_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[230]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[230], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PALMYRENE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[231]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[231], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock NABATAEAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[232]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[232], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OLD_NORTH_ARABIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[233]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[233], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MANICHAEAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[234]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[234], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PSALTER_PAHLAVI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[235]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[235], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MAHAJANI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[236]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[236], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SINHALA_ARCHAIC_NUMBERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[237]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[237], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KHOJKI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[238]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[238], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KHUDAWADI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[239]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[239], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GRANTHA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[240]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[240], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TIRHUTA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[241]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[241], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SIDDHAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[242]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[242], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MODI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[243]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[243], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock WARANG_CITI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[244]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[244], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PAU_CIN_HAU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[245]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[245], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MRO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[246]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[246], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BASSA_VAH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[247]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[247], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock PAHAWH_HMONG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[248]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[248], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock DUPLOYAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[249]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[249], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SHORTHAND_FORMAT_CONTROLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[250]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[250], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MENDE_KIKAKUI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[251]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[251], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ORNAMENTAL_DINGBATS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[252]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[252], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GEOMETRIC_SHAPES_EXTENDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[253]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[253], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_C_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[254]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[254], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CHEROKEE_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[255]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[255], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HATRAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[256]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[256], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OLD_HUNGARIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[257]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[257], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MULTANI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[258]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[258], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock AHOM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[259]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[259], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock EARLY_DYNASTIC_CUNEIFORM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[260]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[260], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ANATOLIAN_HIEROGLYPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[261]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[261], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUTTON_SIGNWRITING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[262]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[262], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SUPPLEMENTAL_SYMBOLS_AND_PICTOGRAPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[263]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[263], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_E_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[264]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[264], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SYRIAC_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[265]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[265], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CYRILLIC_EXTENDED_C_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[266]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[266], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OSAGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[267]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[267], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock NEWA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[268]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[268], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MONGOLIAN_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[269]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[269], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MARCHEN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[270]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[270], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock IDEOGRAPHIC_SYMBOLS_AND_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[271]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[271], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TANGUT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[272]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[272], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TANGUT_COMPONENTS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[273]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[273], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KANA_EXTENDED_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[274]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[274], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GLAGOLITIC_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[275]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[275], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ADLAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[276]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[276], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MASARAM_GONDI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[277]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[277], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ZANABAZAR_SQUARE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[278]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[278], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock NUSHU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[279]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[279], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SOYOMBO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[280]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[280], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock BHAIKSUKI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[281]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[281], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_F_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[282]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[282], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GEORGIAN_EXTENDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[283]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[283], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock HANIFI_ROHINGYA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[284]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[284], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OLD_SOGDIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[285]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[285], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SOGDIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[286]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[286], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock DOGRA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[287]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[287], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock GUNJALA_GONDI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[288]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[288], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MAKASAR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[289]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[289], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MEDEFAIDRIN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[290]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[290], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock MAYAN_NUMERALS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[291]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[291], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock INDIC_SIYAQ_NUMBERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[292]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[292], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CHESS_SYMBOLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[293]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[293], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock ELYMAIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[294]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[294], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock NANDINAGARI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[295]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[295], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TAMIL_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[296]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[296], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock EGYPTIAN_HIEROGLYPH_FORMAT_CONTROLS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[297]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[297], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SMALL_KANA_EXTENSION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[298]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[298], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock NYIAKENG_PUACHUE_HMONG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[299]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[299], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock WANCHO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[300]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[300], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock OTTOMAN_SIYAQ_NUMBERS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[301]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[301], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SYMBOLS_AND_PICTOGRAPHS_EXTENDED_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[302]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[302], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock YEZIDI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[303]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[303], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CHORASMIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[304]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[304], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock DIVES_AKURU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[305]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[305], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock LISU_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[306]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[306], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock KHITAN_SMALL_SCRIPT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[307]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[307], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock TANGUT_SUPPLEMENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[308]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[308], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock SYMBOLS_FOR_LEGACY_COMPUTING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[309]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[309], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_G_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[310]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[310], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[I", "private static final")]
		public static JavaArray<int> blockStarts_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[311]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[311], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/lang/Character$UnicodeBlock;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Character.UnicodeBlock> blocks_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[312]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Character.UnicodeBlock>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[312], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnicodeBlock(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)V", "private transient")]
		public UnicodeBlock(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "private")]
		public UnicodeBlock(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
		public UnicodeBlock(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/Character$UnicodeBlock;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock forName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/Character$UnicodeBlock;", "public static")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock of(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
		}

		[JniSignatureAttribute("(C)Ljava/lang/Character$UnicodeBlock;", "public static")]
		public static Dova.JDK.java.lang.Character.UnicodeBlock of(char arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeBlock>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
	public partial class UnicodeScript
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnicodeScript()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/Character$UnicodeScript;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMMON", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LATIN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GREEK", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CYRILLIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARMENIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HEBREW", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARABIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SYRIAC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "THAANA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEVANAGARI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BENGALI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GURMUKHI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GUJARATI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ORIYA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAMIL", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TELUGU", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KANNADA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MALAYALAM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SINHALA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "THAI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LAO", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TIBETAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MYANMAR", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GEORGIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANGUL", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ETHIOPIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHEROKEE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CANADIAN_ABORIGINAL", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OGHAM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RUNIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHMER", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MONGOLIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HIRAGANA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KATAKANA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BOPOMOFO", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "YI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_ITALIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GOTHIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DESERET", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INHERITED", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAGALOG", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANUNOO", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BUHID", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAGBANWA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LIMBU", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAI_LE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LINEAR_B", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UGARITIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHAVIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OSMANYA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CYPRIOT", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BRAILLE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BUGINESE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COPTIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NEW_TAI_LUE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GLAGOLITIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TIFINAGH", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SYLOTI_NAGRI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_PERSIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHAROSHTHI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BALINESE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CUNEIFORM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PHOENICIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PHAGS_PA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NKO", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUNDANESE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BATAK", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LEPCHA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OL_CHIKI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VAI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SAURASHTRA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KAYAH_LI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REJANG", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LYCIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CARIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LYDIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHAM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAI_THAM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAI_VIET", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AVESTAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EGYPTIAN_HIEROGLYPHS", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SAMARITAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MANDAIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LISU", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BAMUM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JAVANESE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEETEI_MAYEK", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IMPERIAL_ARAMAIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_SOUTH_ARABIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INSCRIPTIONAL_PARTHIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INSCRIPTIONAL_PAHLAVI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_TURKIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BRAHMI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KAITHI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEROITIC_HIEROGLYPHS", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEROITIC_CURSIVE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SORA_SOMPENG", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHAKMA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHARADA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAKRI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIAO", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CAUCASIAN_ALBANIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BASSA_VAH", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DUPLOYAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ELBASAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GRANTHA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PAHAWH_HMONG", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHOJKI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LINEAR_A", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAHAJANI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MANICHAEAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MENDE_KIKAKUI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MRO", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_NORTH_ARABIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NABATAEAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PALMYRENE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PAU_CIN_HAU", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_PERMIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PSALTER_PAHLAVI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SIDDHAM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHUDAWADI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TIRHUTA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "WARANG_CITI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AHOM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ANATOLIAN_HIEROGLYPHS", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HATRAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MULTANI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_HUNGARIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SIGNWRITING", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ADLAM", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BHAIKSUKI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MARCHEN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NEWA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OSAGE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TANGUT", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MASARAM_GONDI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NUSHU", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SOYOMBO", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ZANABAZAR_SQUARE", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANIFI_ROHINGYA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OLD_SOGDIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SOGDIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DOGRA", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GUNJALA_GONDI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAKASAR", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEDEFAIDRIN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ELYMAIC", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NANDINAGARI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NYIAKENG_PUACHUE_HMONG", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "WANCHO", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "YEZIDI", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHORASMIAN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIVES_AKURU", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KHITAN_SMALL_SCRIPT", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UNKNOWN", "Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "scriptStarts", "[I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "scripts", "[Ljava/lang/Character$UnicodeScript;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "aliases", "Ljava/util/HashMap;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/lang/Character$UnicodeScript;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnicodeScript", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeScript;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/lang/Character$UnicodeScript;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeScript;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(I)Ljava/lang/Character$UnicodeScript;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/lang/Character$UnicodeScript;"));
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript COMMON_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LATIN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript GREEK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CYRILLIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ARMENIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript HEBREW_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ARABIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SYRIAC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript THAANA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript DEVANAGARI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BENGALI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript GURMUKHI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript GUJARATI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ORIYA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TAMIL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TELUGU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KANNADA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MALAYALAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SINHALA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript THAI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LAO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TIBETAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MYANMAR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript GEORGIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript HANGUL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ETHIOPIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CHEROKEE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CANADIAN_ABORIGINAL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OGHAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript RUNIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KHMER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MONGOLIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript HIRAGANA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KATAKANA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BOPOMOFO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript HAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript YI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OLD_ITALIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript GOTHIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript DESERET_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript INHERITED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TAGALOG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript HANUNOO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BUHID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TAGBANWA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LIMBU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TAI_LE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LINEAR_B_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript UGARITIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SHAVIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OSMANYA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CYPRIOT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BRAILLE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BUGINESE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript COPTIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript NEW_TAI_LUE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript GLAGOLITIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TIFINAGH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SYLOTI_NAGRI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OLD_PERSIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KHAROSHTHI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BALINESE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CUNEIFORM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript PHOENICIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript PHAGS_PA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript NKO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SUNDANESE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BATAK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LEPCHA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OL_CHIKI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript VAI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SAURASHTRA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KAYAH_LI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript REJANG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LYCIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CARIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LYDIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CHAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TAI_THAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TAI_VIET_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript AVESTAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript EGYPTIAN_HIEROGLYPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SAMARITAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MANDAIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LISU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BAMUM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript JAVANESE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MEETEI_MAYEK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript IMPERIAL_ARAMAIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OLD_SOUTH_ARABIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript INSCRIPTIONAL_PARTHIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript INSCRIPTIONAL_PAHLAVI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OLD_TURKIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BRAHMI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KAITHI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MEROITIC_HIEROGLYPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MEROITIC_CURSIVE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SORA_SOMPENG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CHAKMA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SHARADA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TAKRI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MIAO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CAUCASIAN_ALBANIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BASSA_VAH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript DUPLOYAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ELBASAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript GRANTHA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript PAHAWH_HMONG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KHOJKI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript LINEAR_A_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MAHAJANI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MANICHAEAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MENDE_KIKAKUI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MODI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MRO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OLD_NORTH_ARABIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript NABATAEAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript PALMYRENE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript PAU_CIN_HAU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OLD_PERMIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript PSALTER_PAHLAVI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SIDDHAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KHUDAWADI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TIRHUTA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript WARANG_CITI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript AHOM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ANATOLIAN_HIEROGLYPHS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript HATRAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MULTANI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OLD_HUNGARIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SIGNWRITING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ADLAM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript BHAIKSUKI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MARCHEN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript NEWA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OSAGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript TANGUT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MASARAM_GONDI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript NUSHU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SOYOMBO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ZANABAZAR_SQUARE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript HANIFI_ROHINGYA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript OLD_SOGDIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript SOGDIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript DOGRA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript GUNJALA_GONDI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MAKASAR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript MEDEFAIDRIN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript ELYMAIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript NANDINAGARI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript NYIAKENG_PUACHUE_HMONG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript WANCHO_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[151]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[151], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript YEZIDI_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[152]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[152], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript CHORASMIAN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[153]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[153], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript DIVES_AKURU_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[154]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[154], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript KHITAN_SMALL_SCRIPT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[155]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[155], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript UNKNOWN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[156]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[156], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[I", "private static final")]
		public static JavaArray<int> scriptStarts_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[157]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[157], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/lang/Character$UnicodeScript;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Character.UnicodeScript> scripts_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[158]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Character.UnicodeScript>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[158], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
		public static Dova.JDK.java.util.HashMap aliases_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[159]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[159], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/lang/Character$UnicodeScript;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Character.UnicodeScript> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[160]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Character.UnicodeScript>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[160], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnicodeScript(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public UnicodeScript(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/Character$UnicodeScript;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Character$UnicodeScript;", "public static final")]
		public static Dova.JDK.java.lang.Character.UnicodeScript forName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/Character$UnicodeScript;", "public static")]
		public static JavaArray<Dova.JDK.java.lang.Character.UnicodeScript> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Character.UnicodeScript>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Character$UnicodeScript;", "public static")]
		public static Dova.JDK.java.lang.Character.UnicodeScript valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/Character$UnicodeScript;", "public static")]
		public static Dova.JDK.java.lang.Character.UnicodeScript of(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Character.UnicodeScript>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/Character$UnicodeScript;", "private static")]
		public static JavaArray<Dova.JDK.java.lang.Character.UnicodeScript> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Character.UnicodeScript>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Character$Subset;", "public static")]
	public partial class Subset
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Subset()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/Character$Subset;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Subset", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Subset(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
		public Subset(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/Character$Subset;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public final")]
		public int hashCode()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}
}
