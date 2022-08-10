/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
public partial class AttributedStringBuilder
	: Dova.JDK.jdk.@internal.org.jline.utils.AttributedCharSequence
	, Dova.JDK.java.lang.Appendable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AttributedStringBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/utils/AttributedStringBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "buffer", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "style", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "length", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tabs", "Ljdk/internal/org/jline/utils/AttributedStringBuilder$TabStops;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastLineLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "current", "Ljdk/internal/org/jline/utils/AttributedStyle;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributedStringBuilder", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributedStringBuilder", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append", "(Ljdk/internal/org/jline/utils/AttributedString;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append", "(Ljdk/internal/org/jline/utils/AttributedCharSequence;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(C)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(C)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(Ljava/lang/CharSequence;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "append", "([Ljava/lang/CharSequence;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append", "(Ljdk/internal/org/jline/utils/AttributedString;II)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(Ljava/lang/CharSequence;II)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append", "(Ljdk/internal/org/jline/utils/AttributedCharSequence;II)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append", "(Ljava/lang/CharSequence;Ljdk/internal/org/jline/utils/AttributedStyle;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "charAt", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "offset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buffer", "()[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subSequence_0", "(II)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subSequence_1", "(II)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLength", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureCapacity", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "style", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "style", "(Ljdk/internal/org/jline/utils/AttributedStyle;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "style", "(Ljava/util/function/Function;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styleCodeAt", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styleAt", "(I)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tabs", "(I)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tabs", "(Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ansiAppend", "(Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styleMatches", "(Ljava/util/regex/Pattern;Ljdk/internal/org/jline/utils/AttributedStyle;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styleMatches", "(Ljava/util/regex/Pattern;Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styled", "(Ljdk/internal/org/jline/utils/AttributedStyle;Ljava/lang/CharSequence;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styled", "(Ljava/util/function/Function;Ljava/lang/CharSequence;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styled", "(Ljava/util/function/Function;Ljava/util/function/Consumer;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "appendAnsi", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertTab", "(Ljdk/internal/org/jline/utils/AttributedStyle;)V"));
	}

	[JniSignatureAttribute("[C", "private")]
	public JavaArray<char> buffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[J", "private")]
	public JavaArray<long> style_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int length_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStringBuilder$TabStops;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder.TabStops tabs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder.TabStops>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int lastLineLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStyle;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle current_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AttributedStringBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public AttributedStringBuilder(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AttributedStringBuilder() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/utils/AttributedStringBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder append(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedCharSequence;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder append(Dova.JDK.jdk.@internal.org.jline.utils.AttributedCharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(C)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder append_0(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/lang/Appendable;", "public volatile")]
	public Dova.JDK.java.lang.Appendable append_1(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", "public volatile")]
	public Dova.JDK.java.lang.Appendable append_0(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder append_1(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/CharSequence;)Ljdk/internal/org/jline/utils/AttributedString;", "public static transient")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedString append(JavaArray<Dova.JDK.java.lang.CharSequence> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;II)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder append(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", "public volatile")]
	public Dova.JDK.java.lang.Appendable append_0(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder append_1(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedCharSequence;II)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder append(Dova.JDK.jdk.@internal.org.jline.utils.AttributedCharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljdk/internal/org/jline/utils/AttributedStyle;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder append(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char charAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int offset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()[C", "protected")]
	public JavaArray<char> buffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(II)Ljdk/internal/org/jline/utils/AttributedString;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString subSequence_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/CharSequence;", "public volatile")]
	public Dova.JDK.java.lang.CharSequence subSequence_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setLength(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void ensureCapacity(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle style()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedStyle;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder style(Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder style(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)J", "")]
	public long styleCodeAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle styleAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder tabs(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder tabs(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder ansiAppend(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern;Ljdk/internal/org/jline/utils/AttributedStyle;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder styleMatches(Dova.JDK.java.util.regex.Pattern arg0, Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern;Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder styleMatches(Dova.JDK.java.util.regex.Pattern arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedStyle;Ljava/lang/CharSequence;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder styled(Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/lang/CharSequence;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder styled(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/function/Consumer;)Ljdk/internal/org/jline/utils/AttributedStringBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder styled(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void appendAnsi(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedStyle;)V", "protected")]
	public void insertTab(Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedStringBuilder$TabStops;", "private")]
	public partial class TabStops
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TabStops()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/utils/AttributedStringBuilder$TabStops;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tabs", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastStop", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastSize", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TabStops", "(Ljdk/internal/org/jline/utils/AttributedStringBuilder;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TabStops", "(Ljdk/internal/org/jline/utils/AttributedStringBuilder;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "spaces", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "defined", "()Z"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List tabs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int lastStop_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int lastSize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TabStops(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedStringBuilder;I)V", "public")]
		public TabStops(Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedStringBuilder;Ljava/util/List;)V", "public")]
		public TabStops(Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/utils/AttributedStringBuilder$TabStops;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)I", "")]
		public int spaces(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool defined()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
