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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RegexParser;", "")]
public partial class RegexParser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RegexParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RegexParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_CHAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_EOF", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_OR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_STAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_PLUS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_QUESTION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_LPAREN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_RPAREN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_DOT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_LBRACKET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_BACKSOLIDUS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_CARET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_DOLLAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_LPAREN2", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_LOOKAHEAD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_NEGATIVELOOKAHEAD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_LOOKBEHIND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_NEGATIVELOOKBEHIND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_INDEPENDENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_SET_OPERATIONS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_POSIX_CHARCLASS_START", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_COMMENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_MODIFIERS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_CONDITION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_XMLSCHEMA_CC_SUBTRACTION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "regex", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "regexlen", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resources", "Ljava/util/ResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chardata", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nexttoken", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S_NORMAL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S_INBRACKETS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S_INXBRACKETS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parenOpened", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parennumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasBackReferences", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "references", "Ljava/util/ArrayList;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ex", "(Ljava/lang/String;I)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/ParseException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSet", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/String;I)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocale", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseTerm", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseFactor", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseAtom", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hexChar", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseRegex", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTokenForShorthand", "(I)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processCIinCharacterClass", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_pP", "(I)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEscaped", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseCharacterClass", "(Z)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addCaseInsensitiveChar", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addCaseInsensitiveCharRange", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processCaret", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDollar", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processLookahead", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processNegativelookahead", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processLookbehind", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processNegativelookbehind", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_A", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_Z", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_z", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_b", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_B", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_lt", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_gt", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processStar", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processPlus", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processQuestion", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkQuestion", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processParen", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processParen2", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processCondition", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processModifiers", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processIndependent", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_c", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_C", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_i", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_I", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_g", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBacksolidus_X", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processBackreference", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseSetOperations", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContext", "(I)V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int T_CHAR_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_EOF_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_OR_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_STAR_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_PLUS_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_QUESTION_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_LPAREN_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_RPAREN_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_DOT_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_LBRACKET_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_BACKSOLIDUS_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_CARET_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_DOLLAR_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_LPAREN2_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_LOOKAHEAD_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_NEGATIVELOOKAHEAD_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_LOOKBEHIND_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_NEGATIVELOOKBEHIND_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_INDEPENDENT_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_SET_OPERATIONS_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_POSIX_CHARCLASS_START_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_COMMENT_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_MODIFIERS_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_CONDITION_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int T_XMLSCHEMA_CC_SUBTRACTION_Property
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

	[JniSignatureAttribute("I", "")]
	public int offset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String regex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int regexlen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/ResourceBundle;", "")]
	public Dova.JDK.java.util.ResourceBundle resources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int chardata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int nexttoken_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int S_NORMAL_Property
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

	[JniSignatureAttribute("I", "protected static final")]
	public static int S_INBRACKETS_Property
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

	[JniSignatureAttribute("I", "protected static final")]
	public static int S_INXBRACKETS_Property
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

	[JniSignatureAttribute("I", "")]
	public int context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int parenOpened_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int parennumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool hasBackReferences_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "")]
	public Dova.JDK.java.util.ArrayList references_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RegexParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public RegexParser() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "public")]
	public RegexParser(Dova.JDK.java.util.Locale arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RegexParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "final")]
	public void next()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/ParseException;", "final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.ParseException ex(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.ParseException>(ret);
	}

	[JniSignatureAttribute("()I", "final")]
	public int read()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "protected final")]
	public bool isSet(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token parse(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "public")]
	public void setLocale(Dova.JDK.java.util.Locale arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token parseTerm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token parseFactor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token parseAtom()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("(I)I", "private static final")]
	public static int hexChar(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token parseRegex()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token getTokenForShorthand(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;I)I", "")]
	public int processCIinCharacterClass(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken processBacksolidus_pP(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int decodeEscaped()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken parseCharacterClass(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;I)V", "protected static final")]
	public static void addCaseInsensitiveChar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;II)V", "protected static final")]
	public static void addCaseInsensitiveCharRange(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processCaret()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processDollar()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processLookahead()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processNegativelookahead()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processLookbehind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processNegativelookbehind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_A()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_Z()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_z()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_b()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_B()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_lt()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_gt()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processStar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processPlus(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;)Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processQuestion(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool checkQuestion(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processParen()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processParen2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processCondition()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processModifiers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processIndependent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_c()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_C()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_i()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_I()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_g()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBacksolidus_X()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/Token;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token processBackreference()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RangeToken;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken parseSetOperations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex.RangeToken>(ret);
	}

	[JniSignatureAttribute("(I)V", "protected final")]
	public void setContext(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RegexParser$ReferencePosition;", "static")]
	public partial class ReferencePosition
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReferencePosition()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RegexParser$ReferencePosition;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refNumber", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "position", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int refNumber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int position_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReferencePosition(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(II)V", "")]
		public ReferencePosition(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/RegexParser$ReferencePosition;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
