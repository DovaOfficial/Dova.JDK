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

namespace Dova.JDK.java.lang;

[JniSignatureAttribute("Ljava/lang/StringBuilder;", "public final")]
public partial class StringBuilder
	: Dova.JDK.java.lang.AbstractStringBuilder
	, Dova.JDK.java.io.Serializable
	, Dova.JDK.java.lang.Comparable
	, Dova.JDK.java.lang.CharSequence
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StringBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/StringBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StringBuilder", "(Ljava/lang/CharSequence;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StringBuilder", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StringBuilder", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StringBuilder", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(Ljava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_2", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "([C)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "([C)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(Ljava/lang/Object;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(Ljava/lang/String;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(I)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(I)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(J)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(J)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(F)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(F)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(D)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(D)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(C)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(C)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_2", "(C)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(Z)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(Z)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "(Ljava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_2", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_0", "([CII)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "append_1", "([CII)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChars", "(II[CI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareTo", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareTo", "(Ljava/lang/StringBuilder;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "indexOf", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "indexOf", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(IF)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(IF)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(IJ)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(IJ)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(II)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(II)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(ILjava/lang/String;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(ILjava/lang/Object;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(I[C)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(I[C)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(IZ)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(IZ)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(IC)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(IC)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(ID)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(ID)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(I[CII)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(I[CII)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_0", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert_1", "(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "charAt", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "codePointAt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "codePointBefore", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "codePointCount", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "offsetByCodePoints", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lastIndexOf", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lastIndexOf", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "substring", "(II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "substring", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "replace_0", "(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "replace_1", "(IILjava/lang/String;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "codePoints", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subSequence", "(II)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "chars", "()Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "delete_0", "(II)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "delete_1", "(II)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLength", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "capacity", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureCapacity", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "trimToSize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCharAt", "(IC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "appendCodePoint_0", "(I)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "appendCodePoint_1", "(I)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deleteCharAt_0", "(I)Ljava/lang/AbstractStringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deleteCharAt_1", "(I)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reverse_0", "()Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reverse_1", "()Ljava/lang/AbstractStringBuilder;"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StringBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)V", "public")]
	public StringBuilder(Dova.JDK.java.lang.CharSequence arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public StringBuilder(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public StringBuilder(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public StringBuilder() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/StringBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public volatile")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(Dova.JDK.java.lang.StringBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(Dova.JDK.java.lang.StringBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", "public volatile")]
	public Dova.JDK.java.lang.Appendable append_1(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_2(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("([C)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("([C)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(F)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(float arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(F)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(float arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(D)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(double arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(D)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(double arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/lang/Appendable;", "public volatile")]
	public Dova.JDK.java.lang.Appendable append_1(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_2(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", "public volatile")]
	public Dova.JDK.java.lang.Appendable append_1(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_2(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("([CII)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder append_0(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("([CII)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder append_1(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(II[CI)V", "public volatile")]
	public void getChars(int arg0, int arg1, JavaArray<char> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
	public int compareTo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)I", "public")]
	public int compareTo(Dova.JDK.java.lang.StringBuilder arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int indexOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
	public int indexOf(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IF)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_0(int arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(IF)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_1(int arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(IJ)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_0(int arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(IJ)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_1(int arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_0(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_1(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_0(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_1(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_0(int arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_1(int arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_0(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_1(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(IZ)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_0(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(IZ)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_1(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(IC)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_0(int arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(IC)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_1(int arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(ID)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_0(int arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(ID)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_1(int arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(I[CII)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_0(int arg0, JavaArray<char> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(I[CII)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_1(int arg0, JavaArray<char> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder insert_0(int arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder insert_1(int arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)C", "public volatile")]
	public char charAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public volatile")]
	public int codePointAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public volatile")]
	public int codePointBefore(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public volatile")]
	public int codePointCount(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public volatile")]
	public int offsetByCodePoints(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
	public int lastIndexOf(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int lastIndexOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String substring(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String substring(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder replace_0(int arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/String;)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder replace_1(int arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
	public Dova.JDK.java.util.stream.IntStream codePoints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/CharSequence;", "public volatile")]
	public Dova.JDK.java.lang.CharSequence subSequence(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/IntStream;", "public volatile")]
	public Dova.JDK.java.util.stream.IntStream chars()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
	}

	[JniSignatureAttribute("(II)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder delete_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder delete_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)V", "public volatile")]
	public void setLength(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("()I", "public volatile")]
	public int capacity()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[79]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public volatile")]
	public void ensureCapacity(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void trimToSize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81]);
	}

	[JniSignatureAttribute("(IC)V", "public volatile")]
	public void setCharAt(int arg0, char arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder appendCodePoint_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder appendCodePoint_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder deleteCharAt_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder deleteCharAt_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/StringBuilder;", "public")]
	public Dova.JDK.java.lang.StringBuilder reverse_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/AbstractStringBuilder;", "public volatile")]
	public Dova.JDK.java.lang.AbstractStringBuilder reverse_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.AbstractStringBuilder>(ret);
	}
}
