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

namespace Dova.JDK.jdk.@internal.icu.lang;

[JniSignatureAttribute("Ljdk/internal/icu/lang/UCharacterEnums;", "")]
public partial class UCharacterEnums
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UCharacterEnums()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/lang/UCharacterEnums;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UCharacterEnums(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public UCharacterEnums() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/icu/lang/UCharacterEnums;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljdk/internal/icu/lang/UCharacterEnums$ECharacterDirection;", "public abstract static interface")]
	public partial interface ECharacterDirection
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ECharacterDirection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/lang/UCharacterEnums$ECharacterDirection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT_TO_RIGHT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_LEFT_TO_RIGHT", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT_TO_LEFT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_RIGHT_TO_LEFT", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EUROPEAN_NUMBER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_EUROPEAN_NUMBER", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EUROPEAN_NUMBER_SEPARATOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EUROPEAN_NUMBER_TERMINATOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARABIC_NUMBER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_ARABIC_NUMBER", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMON_NUMBER_SEPARATOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_COMMON_NUMBER_SEPARATOR", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK_SEPARATOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_PARAGRAPH_SEPARATOR", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEGMENT_SEPARATOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_SEGMENT_SEPARATOR", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WHITE_SPACE_NEUTRAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_WHITESPACE", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER_NEUTRAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_OTHER_NEUTRALS", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT_TO_RIGHT_EMBEDDING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT_TO_RIGHT_OVERRIDE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT_TO_LEFT_ARABIC", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT_TO_LEFT_EMBEDDING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT_TO_LEFT_OVERRIDE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POP_DIRECTIONAL_FORMAT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_POP_DIRECTIONAL_FORMAT", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIR_NON_SPACING_MARK", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_NON_SPACING_MARK", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOUNDARY_NEUTRAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_BOUNDARY_NEUTRAL", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR_DIRECTION_COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTIONALITY_UNDEFINED", "B"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LEFT_TO_RIGHT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int RIGHT_TO_LEFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EUROPEAN_NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EUROPEAN_NUMBER_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EUROPEAN_NUMBER_TERMINATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int ARABIC_NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_ARABIC_NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int COMMON_NUMBER_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_COMMON_NUMBER_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int BLOCK_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_PARAGRAPH_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int SEGMENT_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_SEGMENT_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int WHITE_SPACE_NEUTRAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_WHITESPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[19], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_NEUTRAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_OTHER_NEUTRALS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[21], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LEFT_TO_RIGHT_EMBEDDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[23], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LEFT_TO_RIGHT_OVERRIDE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[25], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int RIGHT_TO_LEFT_ARABIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[27]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[27], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int RIGHT_TO_LEFT_EMBEDDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[29]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[29], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int RIGHT_TO_LEFT_OVERRIDE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[31]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[31], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int POP_DIRECTIONAL_FORMAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_POP_DIRECTIONAL_FORMAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[33]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[33], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int DIR_NON_SPACING_MARK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_NON_SPACING_MARK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[35]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[35], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int BOUNDARY_NEUTRAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_BOUNDARY_NEUTRAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[37]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[37], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CHAR_DIRECTION_COUNT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
			}
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_UNDEFINED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[39]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[39], value);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/lang/UCharacterEnums$ECharacterCategory;", "public abstract static interface")]
	public partial interface ECharacterCategory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ECharacterCategory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/lang/UCharacterEnums$ECharacterCategory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNASSIGNED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERAL_OTHER_TYPES", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPPERCASE_LETTER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOWERCASE_LETTER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TITLECASE_LETTER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODIFIER_LETTER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER_LETTER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NON_SPACING_MARK", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENCLOSING_MARK", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMBINING_SPACING_MARK", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECIMAL_DIGIT_NUMBER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LETTER_NUMBER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER_NUMBER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPACE_SEPARATOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINE_SEPARATOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARAGRAPH_SEPARATOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTROL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORMAT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVATE_USE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SURROGATE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DASH_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "END_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONNECTOR_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MATH_SYMBOL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CURRENCY_SYMBOL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODIFIER_SYMBOL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER_SYMBOL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIAL_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIAL_QUOTE_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINAL_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINAL_QUOTE_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR_CATEGORY_COUNT", "I"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int UNASSIGNED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int GENERAL_OTHER_TYPES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int UPPERCASE_LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LOWERCASE_LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int TITLECASE_LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MODIFIER_LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int NON_SPACING_MARK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int ENCLOSING_MARK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int COMBINING_SPACING_MARK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int DECIMAL_DIGIT_NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LETTER_NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int SPACE_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LINE_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int PARAGRAPH_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CONTROL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int FORMAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int PRIVATE_USE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int SURROGATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int DASH_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int START_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int END_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CONNECTOR_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MATH_SYMBOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CURRENCY_SYMBOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MODIFIER_SYMBOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_SYMBOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int INITIAL_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int INITIAL_QUOTE_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int FINAL_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int FINAL_QUOTE_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CHAR_CATEGORY_COUNT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
			}
		}
	}
}
