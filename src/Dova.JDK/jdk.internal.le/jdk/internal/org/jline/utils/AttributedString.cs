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

[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedString;", "public")]
public partial class AttributedString
	: Dova.JDK.jdk.@internal.org.jline.utils.AttributedCharSequence
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AttributedString()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/utils/AttributedString;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "buffer", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "style", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "start", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "end", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY", "Ljdk/internal/org/jline/utils/AttributedString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEWLINE", "Ljdk/internal/org/jline/utils/AttributedString;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributedString", "([C[JII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributedString", "(Ljava/lang/CharSequence;IILjdk/internal/org/jline/utils/AttributedStyle;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributedString", "(Ljava/lang/CharSequence;Ljdk/internal/org/jline/utils/AttributedStyle;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributedString", "(Ljava/lang/CharSequence;II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributedString", "(Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "join", "(Ljdk/internal/org/jline/utils/AttributedString;[Ljdk/internal/org/jline/utils/AttributedString;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "join", "(Ljdk/internal/org/jline/utils/AttributedString;Ljava/lang/Iterable;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "offset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buffer", "()[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subSequence_0", "(II)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subSequence_1", "(II)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styleCodeAt", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styleAt", "(I)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fromAnsi", "(Ljava/lang/String;I)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fromAnsi", "(Ljava/lang/String;Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fromAnsi", "(Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "arrEq", "([C[CIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "arrEq", "([J[JIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "stripAnsi", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styleMatches", "(Ljava/util/regex/Pattern;Ljdk/internal/org/jline/utils/AttributedStyle;)Ljdk/internal/org/jline/utils/AttributedString;"));
	}

	[JniSignatureAttribute("[C", "final")]
	public JavaArray<char> buffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[J", "final")]
	public JavaArray<long> style_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "final")]
	public int start_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "final")]
	public int end_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedString;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedString EMPTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedString;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedString NEWLINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AttributedString(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([C[JII)V", "")]
	public AttributedString(JavaArray<char> arg0, JavaArray<long> arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;IILjdk/internal/org/jline/utils/AttributedStyle;)V", "public")]
	public AttributedString(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2, Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljdk/internal/org/jline/utils/AttributedStyle;)V", "public")]
	public AttributedString(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)V", "public")]
	public AttributedString(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)V", "public")]
	public AttributedString(Dova.JDK.java.lang.CharSequence arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/utils/AttributedString;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;[Ljdk/internal/org/jline/utils/AttributedString;)Ljdk/internal/org/jline/utils/AttributedString;", "public static transient")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedString join(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0, JavaArray<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;Ljava/lang/Iterable;)Ljdk/internal/org/jline/utils/AttributedString;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedString join(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0, Dova.JDK.java.lang.Iterable arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int offset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()[C", "protected")]
	public JavaArray<char> buffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/CharSequence;", "public volatile")]
	public Dova.JDK.java.lang.CharSequence subSequence_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("(II)Ljdk/internal/org/jline/utils/AttributedString;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString subSequence_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(I)J", "")]
	public long styleCodeAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/jline/utils/AttributedStyle;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle styleAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/org/jline/utils/AttributedString;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedString fromAnsi(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedString;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedString fromAnsi(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedString;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.utils.AttributedString fromAnsi(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("([C[CIII)Z", "private")]
	public bool arrEq(JavaArray<char> arg0, JavaArray<char> arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([J[JIII)Z", "private")]
	public bool arrEq(JavaArray<long> arg0, JavaArray<long> arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String stripAnsi(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern;Ljdk/internal/org/jline/utils/AttributedStyle;)Ljdk/internal/org/jline/utils/AttributedString;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString styleMatches(Dova.JDK.java.util.regex.Pattern arg0, Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}
}
