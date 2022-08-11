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

[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
public partial class AttributedStyle
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AttributedStyle()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/utils/AttributedStyle;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLACK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GREEN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "YELLOW", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLUE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAGENTA", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CYAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WHITE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRIGHT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_BOLD", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_FAINT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_ITALIC", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_UNDERLINE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_BLINK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_INVERSE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_CONCEAL", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_CROSSED_OUT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_FOREGROUND_IND", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_FOREGROUND_RGB", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_FOREGROUND", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_BACKGROUND_IND", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_BACKGROUND_RGB", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_BACKGROUND", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_HIDDEN", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FG_COLOR_EXP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BG_COLOR_EXP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FG_COLOR", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BG_COLOR", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Ljdk/internal/org/jline/utils/AttributedStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOLD", "Ljdk/internal/org/jline/utils/AttributedStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOLD_OFF", "Ljdk/internal/org/jline/utils/AttributedStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVERSE", "Ljdk/internal/org/jline/utils/AttributedStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVERSE_OFF", "Ljdk/internal/org/jline/utils/AttributedStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIDDEN", "Ljdk/internal/org/jline/utils/AttributedStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIDDEN_OFF", "Ljdk/internal/org/jline/utils/AttributedStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "style", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mask", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JJ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/jline/utils/AttributedStyle;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMask", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toAnsi", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "foregroundRgb", "(I)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backgroundRgb", "(I)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boldOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inverseOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hiddenOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boldDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "faint", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "faintOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "faintDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "italicOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "italicDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "underline", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "underlineOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "underlineDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "blink", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "blinkOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "blinkDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inverseNeg", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inverseDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "conceal", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "concealOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "concealDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "crossedOut", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "crossedOutOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "crossedOutDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "foregroundOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "foregroundDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backgroundOff", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backgroundDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hiddenDefault", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inverse", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "foreground", "(I)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "foreground", "(III)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "background", "(III)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "background", "(I)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hidden", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyle", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "italic", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bold", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int BLACK_Property
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
	public static int RED_Property
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
	public static int GREEN_Property
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
	public static int YELLOW_Property
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
	public static int BLUE_Property
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
	public static int MAGENTA_Property
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
	public static int CYAN_Property
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
	public static int WHITE_Property
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
	public static int BRIGHT_Property
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

	[JniSignatureAttribute("J", "static final")]
	public static long F_BOLD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_FAINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_ITALIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_UNDERLINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_BLINK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_INVERSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_CONCEAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_CROSSED_OUT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_FOREGROUND_IND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_FOREGROUND_RGB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_FOREGROUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_BACKGROUND_IND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_BACKGROUND_RGB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_BACKGROUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long F_HIDDEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int FG_COLOR_EXP_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int BG_COLOR_EXP_Property
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

	[JniSignatureAttribute("J", "static final")]
	public static long FG_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long BG_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle BOLD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle BOLD_OFF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle INVERSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle INVERSE_OFF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle HIDDEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle HIDDEN_OFF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "final")]
	public long style_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("J", "final")]
	public long mask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AttributedStyle(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public AttributedStyle(long arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedStyle;)V", "public")]
	public AttributedStyle(Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AttributedStyle() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/utils/AttributedStyle;";
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

	[JniSignatureAttribute("()J", "public")]
	public long getMask()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toAnsi()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle foregroundRgb(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle backgroundRgb(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle boldOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle inverseOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle hiddenOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle boldDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle faint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle faintOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle faintDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle italicOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle italicDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle underline()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle underlineOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle underlineDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle blink()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle blinkOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle blinkDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle inverseNeg()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle inverseDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle conceal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle concealOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle concealDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle crossedOut()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle crossedOutOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle crossedOutDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle foregroundOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle foregroundDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle backgroundOff()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle backgroundDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle hiddenDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle inverse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle foreground(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle foreground(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle background(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle background(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle hidden()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getStyle()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle italic()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle bold()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}
}
