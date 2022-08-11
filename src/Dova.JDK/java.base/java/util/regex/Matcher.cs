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

[JniSignatureAttribute("Ljava/util/regex/Matcher;", "public final")]
public partial class Matcher
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.util.regex.MatchResult
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Matcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Matcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parentPattern", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groups", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "from", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "to", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lookbehindTo", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/CharSequence;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENDANCHOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOANCHOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acceptMode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "first", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "oldLast", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastAppendPosition", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locals", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localsPos", "[Ljava/util/regex/IntHashSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hitEnd", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requireEnd", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transparentBounds", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anchoringBounds", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modCount", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern;Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "charAt", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceFirst", "(Ljava/util/function/Function;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceAll", "(Ljava/util/function/Function;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()Ljava/util/regex/Matcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "results", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pattern", "()Ljava/util/regex/Pattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "region", "(II)Ljava/util/regex/Matcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "groupCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMatchResult", "(Ljava/lang/String;)Ljava/util/regex/MatchResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMatchResult", "()Ljava/util/regex/MatchResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatchedGroupIndex", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubSequence", "(II)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendExpandedReplacement", "(Ljava/lang/String;Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendReplacement", "(Ljava/lang/StringBuilder;Ljava/lang/String;)Ljava/util/regex/Matcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendTail", "(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "regionStart", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "regionEnd", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hitEnd", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requireEnd", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookingAt", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasTransparentBounds", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasAnchoringBounds", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;"));
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "")]
	public Dova.JDK.java.util.regex.Pattern parentPattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> groups_Property
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

	[JniSignatureAttribute("I", "")]
	public int from_Property
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
	public int to_Property
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
	public int lookbehindTo_Property
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

	[JniSignatureAttribute("Ljava/lang/CharSequence;", "")]
	public Dova.JDK.java.lang.CharSequence text_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ENDANCHOR_Property
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
	public static int NOANCHOR_Property
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

	[JniSignatureAttribute("I", "")]
	public int acceptMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int first_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int last_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int oldLast_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int lastAppendPosition_Property
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

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> locals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/regex/IntHashSet;", "")]
	public JavaArray<Dova.JDK.java.util.regex.IntHashSet> localsPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.regex.IntHashSet>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool hitEnd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool requireEnd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool transparentBounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool anchoringBounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int modCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Matcher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Matcher() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern;Ljava/lang/CharSequence;)V", "")]
	public Matcher(Dova.JDK.java.util.regex.Pattern arg0, Dova.JDK.java.lang.CharSequence arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/regex/Matcher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String group(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String group(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String group()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)C", "")]
	public char charAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool matches()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replaceFirst(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replaceFirst(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replaceAll(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String replaceAll(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int start()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int start(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int start(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int end(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int end(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int end()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool find()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool find(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "")]
	public bool match(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher reset()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher reset(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool search(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream results()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern;", "public")]
	public Dova.JDK.java.util.regex.Pattern pattern()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher region(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int groupCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/regex/MatchResult;", "private")]
	public Dova.JDK.java.util.regex.MatchResult toMatchResult(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.MatchResult>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/MatchResult;", "public")]
	public Dova.JDK.java.util.regex.MatchResult toMatchResult()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.MatchResult>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int getTextLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "")]
	public int getMatchedGroupIndex(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/lang/CharSequence;", "")]
	public Dova.JDK.java.lang.CharSequence getSubSequence(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;", "private")]
	public Dova.JDK.java.lang.StringBuilder appendExpandedReplacement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.StringBuilder arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher appendReplacement(Dova.JDK.java.lang.StringBuffer arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/lang/String;)Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher appendReplacement(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder appendTail(Dova.JDK.java.lang.StringBuilder arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "public")]
	public Dova.JDK.java.lang.StringBuffer appendTail(Dova.JDK.java.lang.StringBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuffer>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int regionStart()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int regionEnd()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hitEnd()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool requireEnd()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher usePattern(Dova.JDK.java.util.regex.Pattern arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool lookingAt()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String quoteReplacement(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasTransparentBounds()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[43]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher useTransparentBounds(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasAnchoringBounds()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Ljava/util/regex/Matcher;", "public")]
	public Dova.JDK.java.util.regex.Matcher useAnchoringBounds(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
	}

	[JniSignatureAttribute("Ljava/util/regex/Matcher$ImmutableMatchResult;", "private static")]
	public partial class ImmutableMatchResult
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.regex.MatchResult
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImmutableMatchResult()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/regex/Matcher$ImmutableMatchResult;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "first", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "last", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groups", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(III[ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "groupCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMatch", "()V"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int first_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int last_Property
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

		[JniSignatureAttribute("[I", "private final")]
		public JavaArray<int> groups_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int groupCount_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String text_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImmutableMatchResult(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(III[ILjava/lang/String;)V", "")]
		public ImmutableMatchResult(int arg0, int arg1, int arg2, JavaArray<int> arg3, Dova.JDK.java.lang.String arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/regex/Matcher$ImmutableMatchResult;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String group(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String group()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int start()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int start(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int end()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int end(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int groupCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkMatch()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}
	}
}
