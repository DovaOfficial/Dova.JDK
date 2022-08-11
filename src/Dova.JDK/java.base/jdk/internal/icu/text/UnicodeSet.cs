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

namespace Dova.JDK.jdk.@internal.icu.text;

[JniSignatureAttribute("Ljdk/internal/icu/text/UnicodeSet;", "public")]
public partial class UnicodeSet
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnicodeSet()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/UnicodeSet;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOW", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIGH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIN_VALUE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_VALUE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "len", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "list", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rangeList", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strings", "Ljava/util/TreeSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START_EXTRA", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GROW_EXTRA", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INCLUSION", "Ljdk/internal/icu/text/UnicodeSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bmpSet", "Ljdk/internal/icu/impl/BMPSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stringSpan", "Ljdk/internal/icu/impl/UnicodeSetStringSpan;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_VERSION", "Ljdk/internal/icu/util/VersionInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/icu/text/UnicodeSet;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/CharSequence;)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(I)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "([III)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "max", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljdk/internal/icu/text/UnicodeSet;)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFrozen", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureCapacity", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retainAll", "(Ljdk/internal/icu/text/UnicodeSet;)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complement", "(II)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freeze", "()Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(II)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "xor", "([III)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyPattern", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spanBack", "(Ljava/lang/CharSequence;ILjdk/internal/icu/text/UnicodeSet$SpanCondition;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkFrozen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRangeCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRangeEnd", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRangeStart", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add_unchecked", "(II)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add_unchecked", "(I)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findCodePoint", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSingleCP", "(Ljava/lang/CharSequence;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyFilter", "(Ljdk/internal/icu/text/UnicodeSet$Filter;I)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureBufferCapacity", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInclusions", "(I)Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spanCodePointsAndCount", "(Ljava/lang/CharSequence;ILjdk/internal/icu/text/UnicodeSet$SpanCondition;Ljdk/internal/icu/util/OutputInt;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spanAndCount", "(Ljava/lang/CharSequence;ILjdk/internal/icu/text/UnicodeSet$SpanCondition;Ljdk/internal/icu/util/OutputInt;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneAsThawed", "()Ljdk/internal/icu/text/UnicodeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "span", "(Ljava/lang/CharSequence;ILjdk/internal/icu/text/UnicodeSet$SpanCondition;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "span", "(Ljava/lang/CharSequence;Ljdk/internal/icu/text/UnicodeSet$SpanCondition;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retain", "([III)Ljdk/internal/icu/text/UnicodeSet;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int LOW_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int HIGH_Property
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
	public static int MIN_VALUE_Property
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
	public static int MAX_VALUE_Property
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

	[JniSignatureAttribute("I", "private")]
	public int len_Property
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

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> list_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> rangeList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> buffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/TreeSet;", "")]
	public Dova.JDK.java.util.TreeSet strings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.TreeSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int START_EXTRA_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int GROW_EXTRA_Property
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

	[JniSignatureAttribute("Ljdk/internal/icu/text/UnicodeSet;", "private static")]
	public static Dova.JDK.jdk.@internal.icu.text.UnicodeSet INCLUSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/impl/BMPSet;", "private volatile")]
	public Dova.JDK.jdk.@internal.icu.impl.BMPSet bmpSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.impl.BMPSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/impl/UnicodeSetStringSpan;", "private volatile")]
	public Dova.JDK.jdk.@internal.icu.impl.UnicodeSetStringSpan stringSpan_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.impl.UnicodeSetStringSpan>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/util/VersionInfo;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.util.VersionInfo NO_VERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.util.VersionInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnicodeSet(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public UnicodeSet(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(II)V", "public")]
	public UnicodeSet(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/UnicodeSet;)V", "private")]
	public UnicodeSet(Dova.JDK.jdk.@internal.icu.text.UnicodeSet arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public UnicodeSet() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/UnicodeSet;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljdk/internal/icu/text/UnicodeSet;", "public final")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet add(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/icu/text/UnicodeSet;", "public final")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet add(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("([III)Ljdk/internal/icu/text/UnicodeSet;", "private")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet add(JavaArray<int> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(II)I", "private static final")]
	public static int max(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/icu/text/UnicodeSet;", "public")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet clear()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool contains(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/UnicodeSet;)Ljdk/internal/icu/text/UnicodeSet;", "public")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet set(Dova.JDK.jdk.@internal.icu.text.UnicodeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFrozen()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void ensureCapacity(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/UnicodeSet;)Ljdk/internal/icu/text/UnicodeSet;", "public")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet retainAll(Dova.JDK.jdk.@internal.icu.text.UnicodeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(II)Ljdk/internal/icu/text/UnicodeSet;", "public")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet complement(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/icu/text/UnicodeSet;", "public")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet freeze()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(II)[I", "private")]
	public JavaArray<int> range(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([III)Ljdk/internal/icu/text/UnicodeSet;", "private")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet xor(JavaArray<int> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/text/ParsePosition;)Ljdk/internal/icu/text/UnicodeSet;", "private")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet applyPattern(Dova.JDK.java.lang.String arg0, Dova.JDK.java.text.ParsePosition arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;ILjdk/internal/icu/text/UnicodeSet$SpanCondition;)I", "public")]
	public int spanBack(Dova.JDK.java.lang.CharSequence arg0, int arg1, Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkFrozen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRangeCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getRangeEnd(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getRangeStart(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljdk/internal/icu/text/UnicodeSet;", "private")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet add_unchecked(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/icu/text/UnicodeSet;", "private final")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet add_unchecked(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(I)I", "private final")]
	public int findCodePoint(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)I", "private static")]
	public static int getSingleCP(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/UnicodeSet$Filter;I)Ljdk/internal/icu/text/UnicodeSet;", "private")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet applyFilter(Dova.JDK.jdk.@internal.icu.text.UnicodeSet.Filter arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void ensureBufferCapacity(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/icu/text/UnicodeSet;", "private static synchronized")]
	public static Dova.JDK.jdk.@internal.icu.text.UnicodeSet getInclusions(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;ILjdk/internal/icu/text/UnicodeSet$SpanCondition;Ljdk/internal/icu/util/OutputInt;)I", "private")]
	public int spanCodePointsAndCount(Dova.JDK.java.lang.CharSequence arg0, int arg1, Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition arg2, Dova.JDK.jdk.@internal.icu.util.OutputInt arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;ILjdk/internal/icu/text/UnicodeSet$SpanCondition;Ljdk/internal/icu/util/OutputInt;)I", "public")]
	public int spanAndCount(Dova.JDK.java.lang.CharSequence arg0, int arg1, Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition arg2, Dova.JDK.jdk.@internal.icu.util.OutputInt arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/icu/text/UnicodeSet;", "public")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet cloneAsThawed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;ILjdk/internal/icu/text/UnicodeSet$SpanCondition;)I", "public")]
	public int span(Dova.JDK.java.lang.CharSequence arg0, int arg1, Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljdk/internal/icu/text/UnicodeSet$SpanCondition;)I", "public")]
	public int span(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([III)Ljdk/internal/icu/text/UnicodeSet;", "private")]
	public Dova.JDK.jdk.@internal.icu.text.UnicodeSet retain(JavaArray<int> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/UnicodeSet$VersionFilter;", "private static")]
	public partial class VersionFilter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.icu.text.UnicodeSet.Filter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static VersionFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/UnicodeSet$VersionFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "Ljdk/internal/icu/util/VersionInfo;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/icu/util/VersionInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(I)Z"));
		}

		[JniSignatureAttribute("Ljdk/internal/icu/util/VersionInfo;", "")]
		public Dova.JDK.jdk.@internal.icu.util.VersionInfo version_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.util.VersionInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public VersionFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/icu/util/VersionInfo;)V", "")]
		public VersionFilter(Dova.JDK.jdk.@internal.icu.util.VersionInfo arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/UnicodeSet$VersionFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Z", "public")]
		public bool contains(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/UnicodeSet$Filter;", "private abstract static interface")]
	public partial interface Filter
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Filter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/UnicodeSet$Filter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(I)Z"));
		}

		[JniSignatureAttribute("(I)Z", "public abstract")]
		bool contains(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/UnicodeSet$SpanCondition;", "public static final")]
	public partial class SpanCondition
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SpanCondition()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/UnicodeSet$SpanCondition;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_CONTAINED", "Ljdk/internal/icu/text/UnicodeSet$SpanCondition;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTAINED", "Ljdk/internal/icu/text/UnicodeSet$SpanCondition;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIMPLE", "Ljdk/internal/icu/text/UnicodeSet$SpanCondition;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/icu/text/UnicodeSet$SpanCondition;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/icu/text/UnicodeSet$SpanCondition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/icu/text/UnicodeSet$SpanCondition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/icu/text/UnicodeSet$SpanCondition;"));
		}

		[JniSignatureAttribute("Ljdk/internal/icu/text/UnicodeSet$SpanCondition;", "public static final")]
		public static Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition NOT_CONTAINED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/icu/text/UnicodeSet$SpanCondition;", "public static final")]
		public static Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition CONTAINED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/icu/text/UnicodeSet$SpanCondition;", "public static final")]
		public static Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition SIMPLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/icu/text/UnicodeSet$SpanCondition;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SpanCondition(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public SpanCondition(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/UnicodeSet$SpanCondition;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/icu/text/UnicodeSet$SpanCondition;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/icu/text/UnicodeSet$SpanCondition;", "public static")]
		public static Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/icu/text/UnicodeSet$SpanCondition;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.UnicodeSet.SpanCondition>>(ret);
		}
	}
}
