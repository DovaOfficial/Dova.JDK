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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/icu/lang/UCharacterEnums;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UCharacterEnums", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UCharacterEnums(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public UCharacterEnums() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/icu/lang/UCharacterEnums$ECharacterDirection;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LEFT_TO_RIGHT", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_LEFT_TO_RIGHT", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RIGHT_TO_LEFT", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EUROPEAN_NUMBER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_EUROPEAN_NUMBER", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EUROPEAN_NUMBER_SEPARATOR", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EUROPEAN_NUMBER_TERMINATOR", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARABIC_NUMBER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_ARABIC_NUMBER", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMMON_NUMBER_SEPARATOR", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_COMMON_NUMBER_SEPARATOR", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BLOCK_SEPARATOR", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_PARAGRAPH_SEPARATOR", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SEGMENT_SEPARATOR", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_SEGMENT_SEPARATOR", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "WHITE_SPACE_NEUTRAL", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_WHITESPACE", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_NEUTRAL", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_OTHER_NEUTRALS", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LEFT_TO_RIGHT_EMBEDDING", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LEFT_TO_RIGHT_OVERRIDE", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RIGHT_TO_LEFT_ARABIC", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RIGHT_TO_LEFT_EMBEDDING", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RIGHT_TO_LEFT_OVERRIDE", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "POP_DIRECTIONAL_FORMAT", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_POP_DIRECTIONAL_FORMAT", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIR_NON_SPACING_MARK", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_NON_SPACING_MARK", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BOUNDARY_NEUTRAL", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_BOUNDARY_NEUTRAL", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHAR_DIRECTION_COUNT", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTIONALITY_UNDEFINED", "B"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LEFT_TO_RIGHT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int RIGHT_TO_LEFT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EUROPEAN_NUMBER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EUROPEAN_NUMBER_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EUROPEAN_NUMBER_TERMINATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int ARABIC_NUMBER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_ARABIC_NUMBER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int COMMON_NUMBER_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_COMMON_NUMBER_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int BLOCK_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_PARAGRAPH_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[15], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int SEGMENT_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_SEGMENT_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int WHITE_SPACE_NEUTRAL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_WHITESPACE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[19], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_NEUTRAL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_OTHER_NEUTRALS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[21], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LEFT_TO_RIGHT_EMBEDDING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[23], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LEFT_TO_RIGHT_OVERRIDE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[25], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int RIGHT_TO_LEFT_ARABIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[27]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[27], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int RIGHT_TO_LEFT_EMBEDDING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[29]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[29], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int RIGHT_TO_LEFT_OVERRIDE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[31]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[31], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int POP_DIRECTIONAL_FORMAT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_POP_DIRECTIONAL_FORMAT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[33]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[33], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int DIR_NON_SPACING_MARK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_NON_SPACING_MARK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[35]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[35], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int BOUNDARY_NEUTRAL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_BOUNDARY_NEUTRAL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[37]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[37], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CHAR_DIRECTION_COUNT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
		}

		[JniSignatureAttribute("B", "public static final")]
		public static byte DIRECTIONALITY_UNDEFINED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[39]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[39], value);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/icu/lang/UCharacterEnums$ECharacterCategory;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UNASSIGNED", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GENERAL_OTHER_TYPES", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UPPERCASE_LETTER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LOWERCASE_LETTER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TITLECASE_LETTER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODIFIER_LETTER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_LETTER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NON_SPACING_MARK", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ENCLOSING_MARK", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "COMBINING_SPACING_MARK", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DECIMAL_DIGIT_NUMBER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LETTER_NUMBER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_NUMBER", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SPACE_SEPARATOR", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LINE_SEPARATOR", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PARAGRAPH_SEPARATOR", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTROL", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FORMAT", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PRIVATE_USE", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SURROGATE", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DASH_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "START_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "END_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONNECTOR_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MATH_SYMBOL", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CURRENCY_SYMBOL", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODIFIER_SYMBOL", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_SYMBOL", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_QUOTE_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FINAL_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FINAL_QUOTE_PUNCTUATION", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHAR_CATEGORY_COUNT", "I"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int UNASSIGNED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int GENERAL_OTHER_TYPES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int UPPERCASE_LETTER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LOWERCASE_LETTER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int TITLECASE_LETTER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MODIFIER_LETTER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_LETTER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int NON_SPACING_MARK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int ENCLOSING_MARK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int COMBINING_SPACING_MARK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int DECIMAL_DIGIT_NUMBER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LETTER_NUMBER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_NUMBER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int SPACE_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int LINE_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int PARAGRAPH_SEPARATOR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CONTROL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int FORMAT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int PRIVATE_USE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int SURROGATE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int DASH_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int START_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int END_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CONNECTOR_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MATH_SYMBOL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CURRENCY_SYMBOL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MODIFIER_SYMBOL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OTHER_SYMBOL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int INITIAL_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int INITIAL_QUOTE_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int FINAL_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int FINAL_QUOTE_PUNCTUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int CHAR_CATEGORY_COUNT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
		}
	}
}