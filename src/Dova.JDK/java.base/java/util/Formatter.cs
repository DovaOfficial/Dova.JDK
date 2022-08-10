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

namespace Dova.JDK.java.util;

[JniSignatureAttribute("Ljava/util/Formatter;", "public final")]
public partial class Formatter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Closeable
	, Dova.JDK.java.io.Flushable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Formatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "a", "Ljava/lang/Appendable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "l", "Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastException", "Ljava/io/IOException;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ZERO_SENTINEL", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "zero", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "formatSpecifier", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fsPattern", "Ljava/util/regex/Pattern;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/File;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/File;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/lang/String;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/OutputStream;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/OutputStream;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/File;Ljava/nio/charset/Charset;Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/nio/charset/Charset;Ljava/util/Locale;Ljava/io/File;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/util/Locale;Ljava/lang/Appendable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/OutputStream;Ljava/nio/charset/Charset;Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/io/PrintStream;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/lang/Appendable;Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Formatter", "(Ljava/lang/Appendable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flush", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "locale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "out", "()Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "zero", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toCharset", "(Ljava/lang/String;)Ljava/nio/charset/Charset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "nonNullAppendable", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ioException", "()Ljava/io/IOException;"));
	}

	[JniSignatureAttribute("Ljava/lang/Appendable;", "private")]
	public Dova.JDK.java.lang.Appendable a_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "private final")]
	public Dova.JDK.java.util.Locale l_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/IOException;", "private")]
	public Dova.JDK.java.io.IOException lastException_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("C", "private static final")]
	public static char ZERO_SENTINEL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("C", "private")]
	public char zero_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String formatSpecifier_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern fsPattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Formatter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/File;Ljava/lang/String;)V", "public")]
	public Formatter(Dova.JDK.java.io.File arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/io/File;)V", "public")]
	public Formatter(Dova.JDK.java.io.File arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/util/Locale;)V", "public")]
	public Formatter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.charset.Charset arg1, Dova.JDK.java.util.Locale arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V", "public")]
	public Formatter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Locale arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public Formatter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;Ljava/lang/String;)V", "public")]
	public Formatter(Dova.JDK.java.io.OutputStream arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "public")]
	public Formatter(Dova.JDK.java.io.OutputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[6], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V", "public")]
	public Formatter(Dova.JDK.java.io.OutputStream arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Locale arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[7], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/io/File;Ljava/nio/charset/Charset;Ljava/util/Locale;)V", "public")]
	public Formatter(Dova.JDK.java.io.File arg0, Dova.JDK.java.nio.charset.Charset arg1, Dova.JDK.java.util.Locale arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[8], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V", "public")]
	public Formatter(Dova.JDK.java.io.File arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Locale arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[9], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Formatter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[10]))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;Ljava/util/Locale;Ljava/io/File;)V", "private")]
	public Formatter(Dova.JDK.java.nio.charset.Charset arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.io.File arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[11], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Locale;Ljava/lang/Appendable;)V", "private")]
	public Formatter(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.lang.Appendable arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[12], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;Ljava/nio/charset/Charset;Ljava/util/Locale;)V", "public")]
	public Formatter(Dova.JDK.java.io.OutputStream arg0, Dova.JDK.java.nio.charset.Charset arg1, Dova.JDK.java.util.Locale arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[13], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/io/PrintStream;)V", "public")]
	public Formatter(Dova.JDK.java.io.PrintStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[14], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public Formatter(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[15], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Appendable;Ljava/util/Locale;)V", "public")]
	public Formatter(Dova.JDK.java.lang.Appendable arg0, Dova.JDK.java.util.Locale arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[16], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "public")]
	public Formatter(Dova.JDK.java.util.Locale arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[17], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Appendable;)V", "public")]
	public Formatter(Dova.JDK.java.lang.Appendable arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[18], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/Formatter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void flush()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", "public transient")]
	public Dova.JDK.java.util.Formatter format(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", "public transient")]
	public Dova.JDK.java.util.Formatter format(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
	public Dova.JDK.java.util.Locale locale()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Appendable;", "public")]
	public Dova.JDK.java.lang.Appendable @out()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()C", "private")]
	public char zero()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/nio/charset/Charset;", "private static")]
	public static Dova.JDK.java.nio.charset.Charset toCharset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List parse(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Appendable;)Ljava/lang/Appendable;", "private static final")]
	public static Dova.JDK.java.lang.Appendable nonNullAppendable(Dova.JDK.java.lang.Appendable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/IOException;", "public")]
	public Dova.JDK.java.io.IOException ioException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
	}

	[JniSignatureAttribute("Ljava/util/Formatter$FormatString;", "private abstract static interface")]
	public partial interface FormatString
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatString()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter$FormatString;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "index", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int index()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "public abstract")]
		void print(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljava/util/Formatter$FixedString;", "private")]
	public partial class FixedString
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Formatter.FormatString
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FixedString()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter$FixedString;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "s", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "start", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "end", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljava/util/Formatter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FixedString", "(Ljava/util/Formatter;Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "index", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String s_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private final")]
		public int start_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private final")]
		public int end_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Ljava/util/Formatter;", "final")]
		public Dova.JDK.java.util.Formatter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FixedString(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Formatter;Ljava/lang/String;II)V", "")]
		public FixedString(Dova.JDK.java.util.Formatter arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Formatter$FixedString;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int index()
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

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "public")]
		public void print(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljava/util/Formatter$Conversion;", "private static")]
	public partial class Conversion
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Conversion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter$Conversion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DECIMAL_INTEGER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OCTAL_INTEGER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HEXADECIMAL_INTEGER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HEXADECIMAL_INTEGER_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SCIENTIFIC", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SCIENTIFIC_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GENERAL", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GENERAL_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DECIMAL_FLOAT", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HEXADECIMAL_FLOAT", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HEXADECIMAL_FLOAT_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARACTER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARACTER_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DATE_TIME", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DATE_TIME_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BOOLEAN", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BOOLEAN_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STRING", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STRING_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HASHCODE", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HASHCODE_UPPER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LINE_SEPARATOR", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PERCENT_SIGN", "C"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Conversion", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isInteger", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isValid", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isGeneral", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isCharacter", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isFloat", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isText", "(C)Z"));
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DECIMAL_INTEGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char OCTAL_INTEGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HEXADECIMAL_INTEGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HEXADECIMAL_INTEGER_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char SCIENTIFIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char SCIENTIFIC_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char GENERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char GENERAL_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DECIMAL_FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HEXADECIMAL_FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HEXADECIMAL_FLOAT_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char CHARACTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char CHARACTER_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DATE_TIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DATE_TIME_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[15], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char BOOLEAN_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[16], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char STRING_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[18], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HASHCODE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[19], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HASHCODE_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[20], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char LINE_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[21], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char PERCENT_SIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[22], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Conversion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Conversion() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Formatter$Conversion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isInteger(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isValid(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isGeneral(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isCharacter(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isFloat(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isText(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/Formatter$FormatSpecifier;", "private")]
	public partial class FormatSpecifier
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Formatter.FormatString
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatSpecifier()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter$FormatSpecifier;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "index", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "f", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "width", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "precision", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dt", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "c", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljava/util/Formatter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FormatSpecifier", "(Ljava/util/Formatter;Ljava/lang/String;Ljava/util/regex/Matcher;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FormatSpecifier", "(Ljava/util/Formatter;C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "index", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "index", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flags", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(DLjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(FLjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/lang/String;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(ILjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(BLjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(SLjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(JLjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/math/BigInteger;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/math/BigDecimal;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/lang/StringBuilder;DLjava/util/Locale;Ljava/util/Formatter$Flags;CIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/lang/StringBuilder;Ljava/math/BigDecimal;Ljava/util/Locale;Ljava/util/Formatter$Flags;CIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/lang/StringBuilder;Ljava/util/Calendar;CLjava/util/Locale;)Ljava/lang/Appendable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/lang/StringBuilder;Ljava/time/temporal/TemporalAccessor;CLjava/util/Locale;)Ljava/lang/Appendable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/time/temporal/TemporalAccessor;CLjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljava/util/Calendar;CLjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "width", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "precision", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "conversion", "(C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkDateTime", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkGeneral", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkCharacter", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkInteger", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkFloat", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkText", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printDateTime", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printInteger", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printFloat", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printCharacter", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printBoolean", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printString", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printHashCode", "(Ljava/lang/Object;Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "failConversion", "(CLjava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "failMismatch", "(Ljava/util/Formatter$Flags;C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toUpperCaseWithLocale", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "appendJustified", "(Ljava/lang/Appendable;Ljava/lang/CharSequence;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkBadFlags", "([Ljava/util/Formatter$Flags;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkNumeric", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leadingSign", "(Ljava/lang/StringBuilder;Z)Ljava/lang/StringBuilder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "adjustWidth", "(ILjava/util/Formatter$Flags;Z)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "localizedMagnitude", "(Ljava/lang/StringBuilder;Ljava/lang/CharSequence;ILjava/util/Formatter$Flags;ILjava/util/Locale;)Ljava/lang/StringBuilder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "localizedMagnitude", "(Ljava/lang/StringBuilder;JLjava/util/Formatter$Flags;ILjava/util/Locale;)Ljava/lang/StringBuilder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "trailingSign", "(Ljava/lang/StringBuilder;Z)Ljava/lang/StringBuilder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "trailingZeros", "(Ljava/lang/StringBuilder;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addZeros", "(Ljava/lang/StringBuilder;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "localizedMagnitudeExp", "(Ljava/lang/StringBuilder;[CILjava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hexDouble", "(DI)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getZero", "(Ljava/util/Locale;)C"));
		}

		[JniSignatureAttribute("I", "private")]
		public int index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "private")]
		public Dova.JDK.java.util.Formatter.Flags f_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int width_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int precision_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool dt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("C", "private")]
		public char c_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("Ljava/util/Formatter;", "final")]
		public Dova.JDK.java.util.Formatter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FormatSpecifier(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Formatter;Ljava/lang/String;Ljava/util/regex/Matcher;)V", "")]
		public FormatSpecifier(Dova.JDK.java.util.Formatter arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.regex.Matcher arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/util/Formatter;C)V", "")]
		public FormatSpecifier(Dova.JDK.java.util.Formatter arg0, char arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Formatter$FormatSpecifier;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public void index(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()I", "public")]
		public int index()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public void flags(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(DLjava/util/Locale;)V", "private")]
		public void print(double arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(FLjava/util/Locale;)V", "private")]
		public void print(float arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)V", "private")]
		public void print(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(ILjava/util/Locale;)V", "private")]
		public void print(int arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(BLjava/util/Locale;)V", "private")]
		public void print(byte arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(SLjava/util/Locale;)V", "private")]
		public void print(short arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		}

		[JniSignatureAttribute("(JLjava/util/Locale;)V", "private")]
		public void print(long arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/math/BigInteger;Ljava/util/Locale;)V", "private")]
		public void print(Dova.JDK.java.math.BigInteger arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "public")]
		public void print(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/math/BigDecimal;Ljava/util/Locale;)V", "private")]
		public void print(Dova.JDK.java.math.BigDecimal arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;DLjava/util/Locale;Ljava/util/Formatter$Flags;CIZ)V", "private")]
		public void print(Dova.JDK.java.lang.StringBuilder arg0, double arg1, Dova.JDK.java.util.Locale arg2, Dova.JDK.java.util.Formatter.Flags arg3, char arg4, int arg5, bool arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/math/BigDecimal;Ljava/util/Locale;Ljava/util/Formatter$Flags;CIZ)V", "private")]
		public void print(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.math.BigDecimal arg1, Dova.JDK.java.util.Locale arg2, Dova.JDK.java.util.Formatter.Flags arg3, char arg4, int arg5, bool arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/util/Calendar;CLjava/util/Locale;)Ljava/lang/Appendable;", "private")]
		public Dova.JDK.java.lang.Appendable print(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.util.Calendar arg1, char arg2, Dova.JDK.java.util.Locale arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/time/temporal/TemporalAccessor;CLjava/util/Locale;)Ljava/lang/Appendable;", "private")]
		public Dova.JDK.java.lang.Appendable print(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.time.temporal.TemporalAccessor arg1, char arg2, Dova.JDK.java.util.Locale arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Appendable>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;CLjava/util/Locale;)V", "private")]
		public void print(Dova.JDK.java.time.temporal.TemporalAccessor arg0, char arg1, Dova.JDK.java.util.Locale arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/util/Calendar;CLjava/util/Locale;)V", "private")]
		public void print(Dova.JDK.java.util.Calendar arg0, char arg1, Dova.JDK.java.util.Locale arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public void width(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public void precision(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(C)V", "private")]
		public void conversion(char arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkDateTime()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkGeneral()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkCharacter()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkInteger()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkFloat()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkText()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28]);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "private")]
		public void printDateTime(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "private")]
		public void printInteger(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "private")]
		public void printFloat(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "private")]
		public void printCharacter(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "private")]
		public void printBoolean(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "private")]
		public void printString(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)V", "private")]
		public void printHashCode(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		}

		[JniSignatureAttribute("(CLjava/lang/Object;)V", "private")]
		public void failConversion(char arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/Formatter$Flags;C)V", "private")]
		public void failMismatch(Dova.JDK.java.util.Formatter.Flags arg0, char arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String toUpperCaseWithLocale(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Appendable;Ljava/lang/CharSequence;)V", "private")]
		public void appendJustified(Dova.JDK.java.lang.Appendable arg0, Dova.JDK.java.lang.CharSequence arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		}

		[JniSignatureAttribute("([Ljava/util/Formatter$Flags;)V", "private transient")]
		public void checkBadFlags(JavaArray<Dova.JDK.java.util.Formatter.Flags> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkNumeric()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41]);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;Z)Ljava/lang/StringBuilder;", "private")]
		public Dova.JDK.java.lang.StringBuilder leadingSign(Dova.JDK.java.lang.StringBuilder arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}

		[JniSignatureAttribute("(ILjava/util/Formatter$Flags;Z)I", "private")]
		public int adjustWidth(int arg0, Dova.JDK.java.util.Formatter.Flags arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/lang/CharSequence;ILjava/util/Formatter$Flags;ILjava/util/Locale;)Ljava/lang/StringBuilder;", "private")]
		public Dova.JDK.java.lang.StringBuilder localizedMagnitude(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2, Dova.JDK.java.util.Formatter.Flags arg3, int arg4, Dova.JDK.java.util.Locale arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;JLjava/util/Formatter$Flags;ILjava/util/Locale;)Ljava/lang/StringBuilder;", "private")]
		public Dova.JDK.java.lang.StringBuilder localizedMagnitude(Dova.JDK.java.lang.StringBuilder arg0, long arg1, Dova.JDK.java.util.Formatter.Flags arg2, int arg3, Dova.JDK.java.util.Locale arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;Z)Ljava/lang/StringBuilder;", "private")]
		public Dova.JDK.java.lang.StringBuilder trailingSign(Dova.JDK.java.lang.StringBuilder arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;I)V", "private")]
		public void trailingZeros(Dova.JDK.java.lang.StringBuilder arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;I)V", "private")]
		public void addZeros(Dova.JDK.java.lang.StringBuilder arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;[CILjava/util/Locale;)V", "private")]
		public void localizedMagnitudeExp(Dova.JDK.java.lang.StringBuilder arg0, JavaArray<char> arg1, int arg2, Dova.JDK.java.util.Locale arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(DI)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String hexDouble(double arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)C", "private")]
		public char getZero(Dova.JDK.java.util.Locale arg0)
		{
			var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
			return ret;
		}

		[JniSignatureAttribute("Ljava/util/Formatter$FormatSpecifier$BigDecimalLayout;", "private")]
		public partial class BigDecimalLayout
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BigDecimalLayout()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter$FormatSpecifier$BigDecimalLayout;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "mant", "Ljava/lang/StringBuilder;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exp", "Ljava/lang/StringBuilder;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dot", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "scale", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljava/util/Formatter$FormatSpecifier;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BigDecimalLayout", "(Ljava/util/Formatter$FormatSpecifier;Ljava/math/BigInteger;ILjava/util/Formatter$BigDecimalLayoutForm;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scale", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "exponent", "()Ljava/lang/StringBuilder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mantissa", "()Ljava/lang/StringBuilder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasDot", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "layout", "(Ljava/math/BigInteger;ILjava/util/Formatter$BigDecimalLayoutForm;)V"));
			}

			[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private")]
			public Dova.JDK.java.lang.StringBuilder mant_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private")]
			public Dova.JDK.java.lang.StringBuilder exp_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Z", "private")]
			public bool dot_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("I", "private")]
			public int scale_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}

			[JniSignatureAttribute("Ljava/util/Formatter$FormatSpecifier;", "final")]
			public Dova.JDK.java.util.Formatter.FormatSpecifier this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.FormatSpecifier>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BigDecimalLayout(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Formatter$FormatSpecifier;Ljava/math/BigInteger;ILjava/util/Formatter$BigDecimalLayoutForm;)V", "public")]
			public BigDecimalLayout(Dova.JDK.java.util.Formatter.FormatSpecifier arg0, Dova.JDK.java.math.BigInteger arg1, int arg2, Dova.JDK.java.util.Formatter.BigDecimalLayoutForm arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/Formatter$FormatSpecifier$BigDecimalLayout;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "public")]
			public int scale()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/StringBuilder;", "public")]
			public Dova.JDK.java.lang.StringBuilder exponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/StringBuilder;", "public")]
			public Dova.JDK.java.lang.StringBuilder mantissa()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool hasDot()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/math/BigInteger;ILjava/util/Formatter$BigDecimalLayoutForm;)V", "private")]
			public void layout(Dova.JDK.java.math.BigInteger arg0, int arg1, Dova.JDK.java.util.Formatter.BigDecimalLayoutForm arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/Formatter$DateTime;", "private static")]
	public partial class DateTime
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DateTime()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter$DateTime;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HOUR_OF_DAY_0", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HOUR_0", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HOUR_OF_DAY", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HOUR", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MINUTE", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NANOSECOND", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MILLISECOND", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MILLISECOND_SINCE_EPOCH", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "AM_PM", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SECONDS_SINCE_EPOCH", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SECOND", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TIME", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ZONE_NUMERIC", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ZONE", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME_OF_DAY_ABBREV", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME_OF_DAY", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME_OF_MONTH_ABBREV", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME_OF_MONTH", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CENTURY", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DAY_OF_MONTH_0", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DAY_OF_MONTH", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME_OF_MONTH_ABBREV_X", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DAY_OF_YEAR", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MONTH", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "YEAR_2", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "YEAR_4", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TIME_12_HOUR", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TIME_24_HOUR", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DATE_TIME", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DATE", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_STANDARD_DATE", "C"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DateTime", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isValid", "(C)Z"));
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HOUR_OF_DAY_0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HOUR_0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HOUR_OF_DAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char HOUR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char MINUTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char NANOSECOND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char MILLISECOND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char MILLISECOND_SINCE_EPOCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char AM_PM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char SECONDS_SINCE_EPOCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char SECOND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char TIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char ZONE_NUMERIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char ZONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char NAME_OF_DAY_ABBREV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char NAME_OF_DAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[15], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char NAME_OF_MONTH_ABBREV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[16], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char NAME_OF_MONTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char CENTURY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[18], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DAY_OF_MONTH_0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[19], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DAY_OF_MONTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[20], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char NAME_OF_MONTH_ABBREV_X_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[21], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DAY_OF_YEAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[22], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char MONTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[23], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char YEAR_2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[24], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char YEAR_4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[25], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char TIME_12_HOUR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[26]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[26], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char TIME_24_HOUR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[27]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[27], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DATE_TIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[28]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[28], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char DATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[29]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[29], value);
		}

		[JniSignatureAttribute("C", "static final")]
		public static char ISO_STANDARD_DATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[30]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[30], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DateTime(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DateTime() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Formatter$DateTime;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isValid(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "private static")]
	public partial class Flags
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Flags()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter$Flags;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "flags", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NONE", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LEFT_JUSTIFY", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UPPERCASE", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ALTERNATE", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PLUS", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LEADING_SPACE", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ZERO_PAD", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GROUP", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PARENTHESES", "Ljava/util/Formatter$Flags;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PREVIOUS", "Ljava/util/Formatter$Flags;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Flags", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljava/util/Formatter$Flags;)Ljava/util/Formatter$Flags;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "(Ljava/util/Formatter$Flags;)Ljava/util/Formatter$Flags;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toString", "(Ljava/util/Formatter$Flags;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "valueOf", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "contains", "(Ljava/util/Formatter$Flags;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parse", "(Ljava/lang/String;II)Ljava/util/Formatter$Flags;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parse", "(C)Ljava/util/Formatter$Flags;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dup", "()Ljava/util/Formatter$Flags;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int flags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags LEFT_JUSTIFY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags UPPERCASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags ALTERNATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags PLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags LEADING_SPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags ZERO_PAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags GROUP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags PARENTHESES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$Flags;", "static final")]
		public static Dova.JDK.java.util.Formatter.Flags PREVIOUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Flags(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "private")]
		public Flags(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Formatter$Flags;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Formatter$Flags;)Ljava/util/Formatter$Flags;", "private")]
		public Dova.JDK.java.util.Formatter.Flags add(Dova.JDK.java.util.Formatter.Flags arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Formatter$Flags;)Ljava/util/Formatter$Flags;", "public")]
		public Dova.JDK.java.util.Formatter.Flags remove(Dova.JDK.java.util.Formatter.Flags arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Formatter$Flags;)Ljava/lang/String;", "public static")]
		public static Dova.JDK.java.lang.String toString(Dova.JDK.java.util.Formatter.Flags arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int valueOf()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Formatter$Flags;)Z", "public")]
		public bool contains(Dova.JDK.java.util.Formatter.Flags arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)Ljava/util/Formatter$Flags;", "public static")]
		public static Dova.JDK.java.util.Formatter.Flags parse(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
		}

		[JniSignatureAttribute("(C)Ljava/util/Formatter$Flags;", "private static")]
		public static Dova.JDK.java.util.Formatter.Flags parse(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Formatter$Flags;", "public")]
		public Dova.JDK.java.util.Formatter.Flags dup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.Flags>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/Formatter$BigDecimalLayoutForm;", "public static final")]
	public partial class BigDecimalLayoutForm
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BigDecimalLayoutForm()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/Formatter$BigDecimalLayoutForm;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SCIENTIFIC", "Ljava/util/Formatter$BigDecimalLayoutForm;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DECIMAL_FLOAT", "Ljava/util/Formatter$BigDecimalLayoutForm;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/util/Formatter$BigDecimalLayoutForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BigDecimalLayoutForm", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/util/Formatter$BigDecimalLayoutForm;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/util/Formatter$BigDecimalLayoutForm;"));
		}

		[JniSignatureAttribute("Ljava/util/Formatter$BigDecimalLayoutForm;", "public static final")]
		public static Dova.JDK.java.util.Formatter.BigDecimalLayoutForm SCIENTIFIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Formatter$BigDecimalLayoutForm;", "public static final")]
		public static Dova.JDK.java.util.Formatter.BigDecimalLayoutForm DECIMAL_FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/util/Formatter$BigDecimalLayoutForm;", "private static final")]
		public static JavaArray<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BigDecimalLayoutForm(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public BigDecimalLayoutForm(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/Formatter$BigDecimalLayoutForm;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/util/Formatter$BigDecimalLayoutForm;", "public static")]
		public static JavaArray<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;", "public static")]
		public static Dova.JDK.java.util.Formatter.BigDecimalLayoutForm valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm>(ret);
		}

		[JniSignatureAttribute("()[Ljava/util/Formatter$BigDecimalLayoutForm;", "private static")]
		public static JavaArray<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Formatter.BigDecimalLayoutForm>>(ret);
		}
	}
}
