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

namespace Dova.JDK.java.util.regex;

[JniSignatureAttribute("Ljava/util/regex/Pattern;", "public final")]
public partial class Pattern
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Pattern()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNIX_LINES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CASE_INSENSITIVE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMENTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MULTILINE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LITERAL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOTALL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNICODE_CASE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CANON_EQ", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNICODE_CHARACTER_CLASS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_FLAGS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pattern", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags0", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compiled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "normalizedPattern", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "root", "Ljava/util/regex/Pattern$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchRoot", "Ljava/util/regex/Pattern$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "predicate", "Ljava/util/regex/Pattern$CharPredicate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "namedGroups", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupNodes", "[Ljava/util/regex/Pattern$GroupHead;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "topClosureNodes", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localTCNCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasGroupRef", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "temp", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "capturingGroupCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cursor", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "patternLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasSupplementary", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_REPS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "accept", "Ljava/util/regex/Pattern$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "lastAccept", "Ljava/util/regex/Pattern$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clazz", "(Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flags", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClass", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "matches", "(Ljava/lang/String;Ljava/lang/CharSequence;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compile", "(Ljava/lang/String;I)Ljava/util/regex/Pattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(Ljava/lang/CharSequence;I)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "x", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "single", "(I)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "o", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ref", "(I)Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalize", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;)Ljava/util/regex/PatternSyntaxException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peek", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "u", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/util/regex/Pattern$BitClass;)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "quote", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequence", "(Ljava/util/regex/Pattern$Node;)Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "escape", "(ZZZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cursor", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unread", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ALL", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expr", "(Ljava/util/regex/Pattern$Node;)Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inRange", "(III)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "negate", "(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "and", "(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "family", "(ZZ)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pattern", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "union", "(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "union", "(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;Z)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "N", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "namedGroups", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalizeSlice", "(Ljava/lang/String;IILjava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalizeClazz", "(Ljava/lang/String;IILjava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "produceEquivalentAlternation", "(Ljava/lang/String;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countChars", "(Ljava/lang/CharSequence;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "producePermutations", "(Ljava/lang/String;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "composeOneStep", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countCodePoints", "(Ljava/lang/CharSequence;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "has", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSupplementary", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "RemoveQEQuoting", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSlice", "([IIZ)Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parsePastWhitespace", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peekPastWhitespace", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peekPastLine", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parsePastLine", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLineSeparator", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group0", "()Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCharProperty", "(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharProperty;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextEscaped", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atom", "()Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UNIXDOT", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DOT", "()Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closure", "(Ljava/util/regex/Pattern$Node;)Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "HorizWS", "()Ljava/util/regex/Pattern$BmpCharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VertWS", "()Ljava/util/regex/Pattern$BmpCharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "groupname", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SingleU", "(I)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SingleI", "(II)Ljava/util/regex/Pattern$BmpCharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SingleS", "(I)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Single", "(I)Ljava/util/regex/Pattern$BmpCharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bitsOrSingle", "(Ljava/util/regex/Pattern$BitClass;I)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CIRangeU", "(II)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CIRange", "(II)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Range", "(II)Ljava/util/regex/Pattern$CharPredicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createGroup", "(Z)Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSupplementary", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFlag", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subFlag", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "qtype", "()Ljava/util/regex/Pattern$Qtype;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "curly", "(Ljava/util/regex/Pattern$Node;I)Ljava/util/regex/Pattern$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uxxxx", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setcursor", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readEscaped", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasBaseCharacter", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPredicate", "()Ljava/util/function/Predicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asMatchPredicate", "()Ljava/util/function/Predicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splitAsStream", "(Ljava/lang/CharSequence;)Ljava/util/stream/Stream;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int UNIX_LINES_Property
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
	public static int CASE_INSENSITIVE_Property
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
	public static int COMMENTS_Property
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
	public static int MULTILINE_Property
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
	public static int LITERAL_Property
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
	public static int DOTALL_Property
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
	public static int UNICODE_CASE_Property
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
	public static int CANON_EQ_Property
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
	public static int UNICODE_CHARACTER_CLASS_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int ALL_FLAGS_Property
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

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String pattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int flags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "private transient")]
	public int flags0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Z", "private transient volatile")]
	public bool compiled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private transient")]
	public Dova.JDK.java.lang.String normalizedPattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "transient")]
	public Dova.JDK.java.util.regex.Pattern.Node root_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "transient")]
	public Dova.JDK.java.util.regex.Pattern.Node matchRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "transient")]
	public JavaArray<int> buffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$CharPredicate;", "transient")]
	public Dova.JDK.java.util.regex.Pattern.CharPredicate predicate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "transient volatile")]
	public Dova.JDK.java.util.Map namedGroups_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/regex/Pattern$GroupHead;", "transient")]
	public JavaArray<Dova.JDK.java.util.regex.Pattern.GroupHead> groupNodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.regex.Pattern.GroupHead>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "transient")]
	public Dova.JDK.java.util.List topClosureNodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "transient")]
	public int localTCNCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Z", "transient")]
	public bool hasGroupRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("[I", "private transient")]
	public JavaArray<int> temp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "transient")]
	public int capturingGroupCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "transient")]
	public int localCount_Property
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

	[JniSignatureAttribute("I", "private transient")]
	public int cursor_Property
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

	[JniSignatureAttribute("I", "private transient")]
	public int patternLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool hasSupplementary_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_REPS_Property
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

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.Node accept_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern.Node lastAccept_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Pattern(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public Pattern(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Z)Ljava/util/regex/Pattern$CharPredicate;", "private")]
	public Dova.JDK.java.util.regex.Pattern.CharPredicate clazz(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int flags()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void append(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(I)I", "private static")]
	public static int getClass(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/CharSequence;)Z", "public static")]
	public static bool matches(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/regex/Pattern;", "public static")]
	public static Dova.JDK.java.util.regex.Pattern compile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void compile()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/util/regex/Pattern;", "public static")]
	public static Dova.JDK.java.util.regex.Pattern compile(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher matcher(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> split(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;I)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> split(Dova.JDK.java.lang.CharSequence arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int next()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int x()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int c()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/util/regex/Pattern$CharPredicate;", "private")]
	public Dova.JDK.java.util.regex.Pattern.CharPredicate single(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int o()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()I", "private")]
	public int read()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "private")]
	public void accept(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node @ref(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String normalize(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void mark(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()I", "private")]
	public int skip()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/regex/PatternSyntaxException;", "private")]
	public Dova.JDK.java.util.regex.PatternSyntaxException error(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.PatternSyntaxException>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int peek()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int u()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$BitClass;)Ljava/util/regex/Pattern$CharPredicate;", "private")]
	public Dova.JDK.java.util.regex.Pattern.CharPredicate range(Dova.JDK.java.util.regex.Pattern.BitClass arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String quote(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node sequence(Dova.JDK.java.util.regex.Pattern.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("(ZZZ)I", "private")]
	public int escape(bool arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int cursor()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void unread()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32]);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate ALL()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node expr(Dova.JDK.java.util.regex.Pattern.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("(III)Z", "private static")]
	public static bool inRange(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate negate(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;Z)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate and(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0, Dova.JDK.java.util.regex.Pattern.CharPredicate arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(ZZ)Ljava/util/regex/Pattern$CharPredicate;", "private")]
	public Dova.JDK.java.util.regex.Pattern.CharPredicate family(bool arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String pattern()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;Z)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate union(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0, Dova.JDK.java.util.regex.Pattern.CharPredicate arg1, Dova.JDK.java.util.regex.Pattern.CharPredicate arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;Z)Ljava/util/regex/Pattern$CharPredicate;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate union(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0, Dova.JDK.java.util.regex.Pattern.CharPredicate arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int N()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map namedGroups()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/StringBuilder;)V", "private static")]
	public static void normalizeSlice(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.StringBuilder arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/StringBuilder;)V", "private static")]
	public static void normalizeClazz(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.StringBuilder arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Set;)V", "private static")]
	public static void produceEquivalentAlternation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)I", "private static final")]
	public static int countChars(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> producePermutations(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String composeOneStep(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)I", "private static final")]
	public static int countCodePoints(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[50], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool has(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private static final")]
	public static bool isSupplementary(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[52], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void RemoveQEQuoting()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53]);
	}

	[JniSignatureAttribute("([IIZ)Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node newSlice(JavaArray<int> arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int parsePastWhitespace(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int peekPastWhitespace(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int peekPastLine()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[57]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int parsePastLine()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[58]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool isLineSeparator(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node group0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharProperty;", "private")]
	public Dova.JDK.java.util.regex.Pattern.CharProperty newCharProperty(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharProperty>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int nextEscaped()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[62]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node atom()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate UNIXDOT()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate DOT()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node closure(Dova.JDK.java.util.regex.Pattern.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$BmpCharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.BmpCharPredicate HorizWS()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[67]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.BmpCharPredicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$BmpCharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.BmpCharPredicate VertWS()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.BmpCharPredicate>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String groupname(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate SingleU(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[70], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/regex/Pattern$BmpCharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.BmpCharPredicate SingleI(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[71], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.BmpCharPredicate>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate SingleS(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/regex/Pattern$BmpCharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.BmpCharPredicate Single(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.BmpCharPredicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$BitClass;I)Ljava/util/regex/Pattern$CharPredicate;", "private")]
	public Dova.JDK.java.util.regex.Pattern.CharPredicate bitsOrSingle(Dova.JDK.java.util.regex.Pattern.BitClass arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate CIRangeU(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate CIRange(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/regex/Pattern$CharPredicate;", "static")]
	public static Dova.JDK.java.util.regex.Pattern.CharPredicate Range(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node createGroup(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("(II)Z", "private")]
	public bool findSupplementary(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void addFlag()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void subFlag()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81]);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern$Qtype;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Qtype qtype()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;I)Ljava/util/regex/Pattern$Node;", "private")]
	public Dova.JDK.java.util.regex.Pattern.Node curly(Dova.JDK.java.util.regex.Pattern.Node arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int uxxxx()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[84]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void setcursor(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
	}

	[JniSignatureAttribute("()I", "private")]
	public int readEscaped()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[86]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "private static")]
	public static bool hasBaseCharacter(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[87], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/function/Predicate;", "public")]
	public Dova.JDK.java.util.function.Predicate asPredicate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/Predicate;", "public")]
	public Dova.JDK.java.util.function.Predicate asMatchPredicate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream splitAsStream(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Start;", "static")]
	public partial class Start
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Start()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Start;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minLength", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("I", "")]
		public int minLength_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Start(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)V", "")]
		public Start(Dova.JDK.java.util.regex.Pattern.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Start;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "static")]
	public partial class Node
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Node()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Node;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Ljava/util/regex/Pattern$Node;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Node(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Node() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Node;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$GroupHead;", "static final")]
	public partial class GroupHead
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GroupHead()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$GroupHead;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tail", "Ljava/util/regex/Pattern$GroupTail;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("I", "")]
		public int localIndex_Property
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

		[JniSignatureAttribute("Ljava/util/regex/Pattern$GroupTail;", "")]
		public Dova.JDK.java.util.regex.Pattern.GroupTail tail_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.GroupTail>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GroupHead(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public GroupHead(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$GroupHead;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Slice;", "static")]
	public partial class Slice
		: Dova.JDK.java.util.regex.Pattern.SliceNode
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Slice()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Slice;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Slice(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I)V", "")]
		public Slice(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Slice;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BnM;", "static")]
	public partial class BnM
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BnM()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BnM;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastOcc", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "optoSft", "[I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I[I[ILjava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "optimize", "(Ljava/util/regex/Pattern$Node;)Ljava/util/regex/Pattern$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> lastOcc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> optoSft_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BnM(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I[I[ILjava/util/regex/Pattern$Node;)V", "")]
		public BnM(JavaArray<int> arg0, JavaArray<int> arg1, JavaArray<int> arg2, Dova.JDK.java.util.regex.Pattern.Node arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$BnM;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)Ljava/util/regex/Pattern$Node;", "static")]
		public static Dova.JDK.java.util.regex.Pattern.Node optimize(Dova.JDK.java.util.regex.Pattern.Node arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$StartS;", "static final")]
	public partial class StartS
		: Dova.JDK.java.util.regex.Pattern.Start
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StartS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$StartS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StartS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)V", "")]
		public StartS(Dova.JDK.java.util.regex.Pattern.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$StartS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Begin;", "static final")]
	public partial class Begin
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Begin()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Begin;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Begin(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Begin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Begin;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$First;", "static final")]
	public partial class First
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static First()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$First;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "atom", "Ljava/util/regex/Pattern$Node;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node atom_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public First(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)V", "")]
		public First(Dova.JDK.java.util.regex.Pattern.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$First;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Loop;", "static")]
	public partial class Loop
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Loop()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Loop;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/util/regex/Pattern$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "countIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "beginIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmin", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmax", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "posIndex", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchInit", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int countIndex_Property
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

		[JniSignatureAttribute("I", "")]
		public int beginIndex_Property
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

		[JniSignatureAttribute("I", "")]
		public int cmin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int cmax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int posIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Loop(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(II)V", "")]
		public Loop(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Loop;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool matchInit(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BranchConn;", "static final")]
	public partial class BranchConn
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BranchConn()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BranchConn;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BranchConn(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public BranchConn() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$BranchConn;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Branch;", "static final")]
	public partial class Branch
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Branch()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Branch;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "atoms", "[Ljava/util/regex/Pattern$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "conn", "Ljava/util/regex/Pattern$Node;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;Ljava/util/regex/Pattern$Node;Ljava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("[Ljava/util/regex/Pattern$Node;", "")]
		public JavaArray<Dova.JDK.java.util.regex.Pattern.Node> atoms_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.regex.Pattern.Node>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int size_Property
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

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node conn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Branch(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;Ljava/util/regex/Pattern$Node;Ljava/util/regex/Pattern$Node;)V", "")]
		public Branch(Dova.JDK.java.util.regex.Pattern.Node arg0, Dova.JDK.java.util.regex.Pattern.Node arg1, Dova.JDK.java.util.regex.Pattern.Node arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Branch;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)V", "")]
		public void add(Dova.JDK.java.util.regex.Pattern.Node arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$NFCCharProperty;", "private static")]
	public partial class NFCCharProperty
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NFCCharProperty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$NFCCharProperty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "predicate", "Ljava/util/regex/Pattern$CharPredicate;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$CharPredicate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$CharPredicate;", "")]
		public Dova.JDK.java.util.regex.Pattern.CharPredicate predicate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NFCCharProperty(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;)V", "")]
		public NFCCharProperty(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$NFCCharProperty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$CharPredicate;", "abstract static interface")]
	public partial interface CharPredicate
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CharPredicate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$CharPredicate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "is", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "negate", "()Ljava/util/regex/Pattern$CharPredicate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "and", "(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "union", "(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "union", "(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;"));
		}

		[JniSignatureAttribute("(I)Z", "public abstract")]
		bool @is(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/regex/Pattern$CharPredicate;", "public")]
		Dova.JDK.java.util.regex.Pattern.CharPredicate negate()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;", "public")]
		Dova.JDK.java.util.regex.Pattern.CharPredicate and(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;", "public")]
		Dova.JDK.java.util.regex.Pattern.CharPredicate union(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0, Dova.JDK.java.util.regex.Pattern.CharPredicate arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;", "public")]
		Dova.JDK.java.util.regex.Pattern.CharPredicate union(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$CharProperty;", "static")]
	public partial class CharProperty
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CharProperty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$CharProperty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "predicate", "Ljava/util/regex/Pattern$CharPredicate;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$CharPredicate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$CharPredicate;", "final")]
		public Dova.JDK.java.util.regex.Pattern.CharPredicate predicate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CharProperty(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;)V", "")]
		public CharProperty(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$CharProperty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$UnixCaret;", "static final")]
	public partial class UnixCaret
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnixCaret()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$UnixCaret;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnixCaret(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public UnixCaret() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$UnixCaret;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Caret;", "static final")]
	public partial class Caret
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Caret()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Caret;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Caret(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Caret() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Caret;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$UnixDollar;", "static final")]
	public partial class UnixDollar
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnixDollar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$UnixDollar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "multiline", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool multiline_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnixDollar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Z)V", "")]
		public UnixDollar(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$UnixDollar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Dollar;", "static final")]
	public partial class Dollar
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Dollar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Dollar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "multiline", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool multiline_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Dollar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Z)V", "")]
		public Dollar(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Dollar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$CIBackRef;", "static")]
	public partial class CIBackRef
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CIBackRef()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$CIBackRef;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doUnicodeCase", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("I", "")]
		public int groupIndex_Property
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

		[JniSignatureAttribute("Z", "")]
		public bool doUnicodeCase_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CIBackRef(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IZ)V", "")]
		public CIBackRef(int arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$CIBackRef;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BackRef;", "static")]
	public partial class BackRef
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BackRef()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BackRef;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupIndex", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("I", "")]
		public int groupIndex_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BackRef(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public BackRef(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$BackRef;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Bound;", "static final")]
	public partial class Bound
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Bound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Bound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOTH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useUWORD", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWord", "(I)Z"));
		}

		[JniSignatureAttribute("I", "static")]
		public static int LEFT_Property
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

		[JniSignatureAttribute("I", "static")]
		public static int RIGHT_Property
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

		[JniSignatureAttribute("I", "static")]
		public static int BOTH_Property
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

		[JniSignatureAttribute("I", "static")]
		public static int NONE_Property
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

		[JniSignatureAttribute("I", "")]
		public int type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool useUWORD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Bound(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IZ)V", "")]
		public Bound(int arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Bound;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)I", "")]
		public int check(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(I)Z", "")]
		public bool isWord(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BmpCharPredicate;", "abstract static interface")]
	public partial interface BmpCharPredicate
		: IJavaObject
		, Dova.JDK.java.util.regex.Pattern.CharPredicate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BmpCharPredicate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BmpCharPredicate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "and", "(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "union", "(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "union", "(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;"));
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;", "public")]
		Dova.JDK.java.util.regex.Pattern.CharPredicate and(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;", "public")]
		Dova.JDK.java.util.regex.Pattern.CharPredicate union(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharPredicate;Ljava/util/regex/Pattern$CharPredicate;)Ljava/util/regex/Pattern$CharPredicate;", "public")]
		Dova.JDK.java.util.regex.Pattern.CharPredicate union(Dova.JDK.java.util.regex.Pattern.CharPredicate arg0, Dova.JDK.java.util.regex.Pattern.CharPredicate arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$LastMatch;", "static final")]
	public partial class LastMatch
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LastMatch()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$LastMatch;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LastMatch(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public LastMatch() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$LastMatch;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$LineEnding;", "static final")]
	public partial class LineEnding
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LineEnding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$LineEnding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LineEnding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public LineEnding() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$LineEnding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$XGrapheme;", "static")]
	public partial class XGrapheme
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XGrapheme()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$XGrapheme;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XGrapheme(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public XGrapheme() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$XGrapheme;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$GraphemeBound;", "static")]
	public partial class GraphemeBound
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GraphemeBound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$GraphemeBound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GraphemeBound(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public GraphemeBound() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$GraphemeBound;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$End;", "static final")]
	public partial class End
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static End()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$End;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public End(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public End() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$End;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BitClass;", "static final")]
	public partial class BitClass
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.regex.Pattern.BmpCharPredicate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BitClass()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BitClass;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bits", "[Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(II)Ljava/util/regex/Pattern$BitClass;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "is", "(I)Z"));
		}

		[JniSignatureAttribute("[Z", "final")]
		public JavaArray<bool> bits_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BitClass(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public BitClass() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$BitClass;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(II)Ljava/util/regex/Pattern$BitClass;", "")]
		public Dova.JDK.java.util.regex.Pattern.BitClass add(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.BitClass>(ret);
		}

		[JniSignatureAttribute("(I)Z", "public")]
		public bool @is(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BmpCharProperty;", "private static")]
	public partial class BmpCharProperty
		: Dova.JDK.java.util.regex.Pattern.CharProperty
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BmpCharProperty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BmpCharProperty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$BmpCharPredicate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BmpCharProperty(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$BmpCharPredicate;)V", "")]
		public BmpCharProperty(Dova.JDK.java.util.regex.Pattern.BmpCharPredicate arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$BmpCharProperty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Pos;", "static final")]
	public partial class Pos
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Pos()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Pos;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Ljava/util/regex/Pattern$Node;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Pos(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)V", "")]
		public Pos(Dova.JDK.java.util.regex.Pattern.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Pos;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Neg;", "static final")]
	public partial class Neg
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Neg()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Neg;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Ljava/util/regex/Pattern$Node;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Neg(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;)V", "")]
		public Neg(Dova.JDK.java.util.regex.Pattern.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Neg;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Ques;", "static final")]
	public partial class Ques
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Ques()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Ques;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "atom", "Ljava/util/regex/Pattern$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/util/regex/Pattern$Qtype;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;Ljava/util/regex/Pattern$Qtype;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node atom_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Qtype;", "")]
		public Dova.JDK.java.util.regex.Pattern.Qtype type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Ques(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;Ljava/util/regex/Pattern$Qtype;)V", "")]
		public Ques(Dova.JDK.java.util.regex.Pattern.Node arg0, Dova.JDK.java.util.regex.Pattern.Qtype arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Ques;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Qtype;", "static final")]
	public partial class Qtype
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Qtype()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Qtype;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GREEDY", "Ljava/util/regex/Pattern$Qtype;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAZY", "Ljava/util/regex/Pattern$Qtype;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POSSESSIVE", "Ljava/util/regex/Pattern$Qtype;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEPENDENT", "Ljava/util/regex/Pattern$Qtype;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/util/regex/Pattern$Qtype;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/util/regex/Pattern$Qtype;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/util/regex/Pattern$Qtype;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/util/regex/Pattern$Qtype;"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Qtype;", "public static final")]
		public static Dova.JDK.java.util.regex.Pattern.Qtype GREEDY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Qtype;", "public static final")]
		public static Dova.JDK.java.util.regex.Pattern.Qtype LAZY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Qtype;", "public static final")]
		public static Dova.JDK.java.util.regex.Pattern.Qtype POSSESSIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Qtype;", "public static final")]
		public static Dova.JDK.java.util.regex.Pattern.Qtype INDEPENDENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/util/regex/Pattern$Qtype;", "private static final")]
		public static JavaArray<Dova.JDK.java.util.regex.Pattern.Qtype> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.regex.Pattern.Qtype>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Qtype(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Qtype(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Qtype;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/util/regex/Pattern$Qtype;", "public static")]
		public static JavaArray<Dova.JDK.java.util.regex.Pattern.Qtype> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.regex.Pattern.Qtype>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/regex/Pattern$Qtype;", "public static")]
		public static Dova.JDK.java.util.regex.Pattern.Qtype valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
		}

		[JniSignatureAttribute("()[Ljava/util/regex/Pattern$Qtype;", "private static")]
		public static JavaArray<Dova.JDK.java.util.regex.Pattern.Qtype> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.regex.Pattern.Qtype>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$LookBehindEndNode;", "static")]
	public partial class LookBehindEndNode
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LookBehindEndNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$LookBehindEndNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljava/util/regex/Pattern$LookBehindEndNode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$LookBehindEndNode;", "static")]
		public static Dova.JDK.java.util.regex.Pattern.LookBehindEndNode INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.LookBehindEndNode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LookBehindEndNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public LookBehindEndNode() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$LookBehindEndNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$TreeInfo;", "static final")]
	public partial class TreeInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TreeInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$TreeInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minLength", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxLength", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxValid", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deterministic", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		}

		[JniSignatureAttribute("I", "")]
		public int minLength_Property
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
		public int maxLength_Property
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

		[JniSignatureAttribute("Z", "")]
		public bool maxValid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool deterministic_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TreeInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public TreeInfo() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$TreeInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BehindS;", "static final")]
	public partial class BehindS
		: Dova.JDK.java.util.regex.Pattern.Behind
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BehindS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BehindS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BehindS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;II)V", "")]
		public BehindS(Dova.JDK.java.util.regex.Pattern.Node arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$BehindS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Behind;", "static")]
	public partial class Behind
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Behind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Behind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Ljava/util/regex/Pattern$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmax", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmin", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int rmax_Property
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

		[JniSignatureAttribute("I", "")]
		public int rmin_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Behind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;II)V", "")]
		public Behind(Dova.JDK.java.util.regex.Pattern.Node arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Behind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$NotBehindS;", "static final")]
	public partial class NotBehindS
		: Dova.JDK.java.util.regex.Pattern.NotBehind
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NotBehindS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$NotBehindS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NotBehindS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;II)V", "")]
		public NotBehindS(Dova.JDK.java.util.regex.Pattern.Node arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$NotBehindS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$NotBehind;", "static")]
	public partial class NotBehind
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NotBehind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$NotBehind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Ljava/util/regex/Pattern$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmax", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmin", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int rmax_Property
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

		[JniSignatureAttribute("I", "")]
		public int rmin_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NotBehind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;II)V", "")]
		public NotBehind(Dova.JDK.java.util.regex.Pattern.Node arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$NotBehind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Curly;", "static final")]
	public partial class Curly
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Curly()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Curly;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "atom", "Ljava/util/regex/Pattern$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/util/regex/Pattern$Qtype;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmin", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmax", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;IILjava/util/regex/Pattern$Qtype;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match0", "(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match1", "(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match2", "(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node atom_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Qtype;", "")]
		public Dova.JDK.java.util.regex.Pattern.Qtype type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int cmin_Property
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

		[JniSignatureAttribute("I", "")]
		public int cmax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Curly(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;IILjava/util/regex/Pattern$Qtype;)V", "")]
		public Curly(Dova.JDK.java.util.regex.Pattern.Node arg0, int arg1, int arg2, Dova.JDK.java.util.regex.Pattern.Qtype arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Curly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z", "")]
		public bool match0(Dova.JDK.java.util.regex.Matcher arg0, int arg1, int arg2, Dova.JDK.java.lang.CharSequence arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z", "")]
		public bool match1(Dova.JDK.java.util.regex.Matcher arg0, int arg1, int arg2, Dova.JDK.java.lang.CharSequence arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z", "")]
		public bool match2(Dova.JDK.java.util.regex.Matcher arg0, int arg1, int arg2, Dova.JDK.java.lang.CharSequence arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$GroupTail;", "static final")]
	public partial class GroupTail
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GroupTail()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$GroupTail;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupIndex", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("I", "")]
		public int localIndex_Property
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
		public int groupIndex_Property
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
		public GroupTail(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(II)V", "")]
		public GroupTail(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$GroupTail;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$GroupCurly;", "static final")]
	public partial class GroupCurly
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GroupCurly()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$GroupCurly;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "atom", "Ljava/util/regex/Pattern$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/util/regex/Pattern$Qtype;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmin", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmax", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "capture", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Node;IILjava/util/regex/Pattern$Qtype;IIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match0", "(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match1", "(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match2", "(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Node;", "")]
		public Dova.JDK.java.util.regex.Pattern.Node atom_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Qtype;", "")]
		public Dova.JDK.java.util.regex.Pattern.Qtype type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Qtype>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int cmin_Property
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

		[JniSignatureAttribute("I", "")]
		public int cmax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int localIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int groupIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool capture_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GroupCurly(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Node;IILjava/util/regex/Pattern$Qtype;IIZ)V", "")]
		public GroupCurly(Dova.JDK.java.util.regex.Pattern.Node arg0, int arg1, int arg2, Dova.JDK.java.util.regex.Pattern.Qtype arg3, int arg4, int arg5, bool arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$GroupCurly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z", "")]
		public bool match0(Dova.JDK.java.util.regex.Matcher arg0, int arg1, int arg2, Dova.JDK.java.lang.CharSequence arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z", "")]
		public bool match1(Dova.JDK.java.util.regex.Matcher arg0, int arg1, int arg2, Dova.JDK.java.lang.CharSequence arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;IILjava/lang/CharSequence;)Z", "")]
		public bool match2(Dova.JDK.java.util.regex.Matcher arg0, int arg1, int arg2, Dova.JDK.java.lang.CharSequence arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$LazyLoop;", "static final")]
	public partial class LazyLoop
		: Dova.JDK.java.util.regex.Pattern.Loop
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LazyLoop()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$LazyLoop;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchInit", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LazyLoop(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(II)V", "")]
		public LazyLoop(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$LazyLoop;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool matchInit(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$Prolog;", "static final")]
	public partial class Prolog
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Prolog()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$Prolog;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loop", "Ljava/util/regex/Pattern$Loop;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$Loop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$Loop;", "")]
		public Dova.JDK.java.util.regex.Pattern.Loop loop_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.Loop>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Prolog(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$Loop;)V", "")]
		public Prolog(Dova.JDK.java.util.regex.Pattern.Loop arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$Prolog;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BmpCharPropertyGreedy;", "static final")]
	public partial class BmpCharPropertyGreedy
		: Dova.JDK.java.util.regex.Pattern.CharPropertyGreedy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BmpCharPropertyGreedy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BmpCharPropertyGreedy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$BmpCharProperty;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BmpCharPropertyGreedy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$BmpCharProperty;I)V", "")]
		public BmpCharPropertyGreedy(Dova.JDK.java.util.regex.Pattern.BmpCharProperty arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$BmpCharPropertyGreedy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$CharPropertyGreedy;", "static")]
	public partial class CharPropertyGreedy
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CharPropertyGreedy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$CharPropertyGreedy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "predicate", "Ljava/util/regex/Pattern$CharPredicate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmin", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern$CharProperty;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern$CharPredicate;", "final")]
		public Dova.JDK.java.util.regex.Pattern.CharPredicate predicate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern.CharPredicate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int cmin_Property
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
		public CharPropertyGreedy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$CharProperty;I)V", "")]
		public CharPropertyGreedy(Dova.JDK.java.util.regex.Pattern.CharProperty arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$CharPropertyGreedy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$SliceUS;", "static final")]
	public partial class SliceUS
		: Dova.JDK.java.util.regex.Pattern.SliceIS
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SliceUS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$SliceUS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLower", "(I)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SliceUS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I)V", "")]
		public SliceUS(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$SliceUS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)I", "")]
		public int toLower(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$SliceU;", "static final")]
	public partial class SliceU
		: Dova.JDK.java.util.regex.Pattern.SliceNode
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SliceU()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$SliceU;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SliceU(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I)V", "")]
		public SliceU(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$SliceU;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$SliceIS;", "static")]
	public partial class SliceIS
		: Dova.JDK.java.util.regex.Pattern.SliceNode
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SliceIS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$SliceIS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLower", "(I)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SliceIS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I)V", "")]
		public SliceIS(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$SliceIS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "")]
		public int toLower(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$SliceI;", "static")]
	public partial class SliceI
		: Dova.JDK.java.util.regex.Pattern.SliceNode
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SliceI()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$SliceI;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SliceI(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I)V", "")]
		public SliceI(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$SliceI;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$SliceS;", "static final")]
	public partial class SliceS
		: Dova.JDK.java.util.regex.Pattern.Slice
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SliceS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$SliceS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SliceS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I)V", "")]
		public SliceS(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$SliceS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$LastNode;", "static")]
	public partial class LastNode
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LastNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$LastNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LastNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public LastNode() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$LastNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$BnMS;", "static final")]
	public partial class BnMS
		: Dova.JDK.java.util.regex.Pattern.BnM
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BnMS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$BnMS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lengthInChars", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I[I[ILjava/util/regex/Pattern$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z"));
		}

		[JniSignatureAttribute("I", "")]
		public int lengthInChars_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BnMS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I[I[ILjava/util/regex/Pattern$Node;)V", "")]
		public BnMS(JavaArray<int> arg0, JavaArray<int> arg1, JavaArray<int> arg2, Dova.JDK.java.util.regex.Pattern.Node arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$BnMS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Matcher;ILjava/lang/CharSequence;)Z", "")]
		public bool match(Dova.JDK.java.util.regex.Matcher arg0, int arg1, Dova.JDK.java.lang.CharSequence arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern$SliceNode;", "static")]
	public partial class SliceNode
		: Dova.JDK.java.util.regex.Pattern.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SliceNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Pattern$SliceNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "[I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "study", "(Ljava/util/regex/Pattern$TreeInfo;)Z"));
		}

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SliceNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([I)V", "")]
		public SliceNode(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Pattern$SliceNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/regex/Pattern$TreeInfo;)Z", "")]
		public bool study(Dova.JDK.java.util.regex.Pattern.TreeInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}
}
