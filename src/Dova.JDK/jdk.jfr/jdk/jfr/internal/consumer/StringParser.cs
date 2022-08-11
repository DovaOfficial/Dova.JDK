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

namespace Dova.JDK.jdk.jfr.@internal.consumer;

[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser;", "public final")]
public partial class StringParser
	: Dova.JDK.jdk.jfr.@internal.consumer.Parser
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StringParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/StringParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stringLookup", "Ljdk/jfr/internal/consumer/ConstantLookup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "charArrayParser", "Ljdk/jfr/internal/consumer/StringParser$CharArrayParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utf8parser", "Ljdk/jfr/internal/consumer/StringParser$CharsetParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "latin1parser", "Ljdk/jfr/internal/consumer/StringParser$CharsetParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "event", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jfr/internal/consumer/ConstantLookup;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ConstantLookup;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup stringLookup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$CharArrayParser;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.StringParser.CharArrayParser charArrayParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.CharArrayParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$CharsetParser;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.StringParser.CharsetParser utf8parser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.CharsetParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$CharsetParser;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.StringParser.CharsetParser latin1parser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.CharsetParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool @event_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StringParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ConstantLookup;Z)V", "public")]
	public StringParser(Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/StringParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
	public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$CharArrayParser;", "private static final")]
	public partial class CharArrayParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CharArrayParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/StringParser$CharArrayParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "[C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastSize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastString", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureSize", "(I)V"));
		}

		[JniSignatureAttribute("[C", "private")]
		public JavaArray<char> buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int lastSize_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String lastString_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CharArrayParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CharArrayParser() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/StringParser$CharArrayParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void ensureSize(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$CharsetParser;", "private static final")]
	public partial class CharsetParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CharsetParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/StringParser$CharsetParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "charset", "Ljava/nio/charset/Charset;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastSize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastString", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureSize", "(I)V"));
		}

		[JniSignatureAttribute("Ljava/nio/charset/Charset;", "private final")]
		public Dova.JDK.java.nio.charset.Charset charset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int lastSize_Property
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

		[JniSignatureAttribute("[B", "private")]
		public JavaArray<byte> buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String lastString_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CharsetParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/charset/Charset;)V", "")]
		public CharsetParser(Dova.JDK.java.nio.charset.Charset arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/StringParser$CharsetParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void ensureSize(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static final")]
	public partial class Encoding
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Encoding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/StringParser$Encoding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL", "Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_STRING", "Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_POOL", "Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UT8_BYTE_ARRAY", "Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR_ARRAY", "Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LATIN1_BYTE_ARRAY", "Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteValue", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byteValue", "()B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "is", "(B)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/jfr/internal/consumer/StringParser$Encoding;"));
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding NULL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding EMPTY_STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding CONSTANT_POOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding UT8_BYTE_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding CHAR_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding LATIN1_BYTE_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("B", "private")]
		public byte byteValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("[Ljdk/jfr/internal/consumer/StringParser$Encoding;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Encoding(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public Encoding(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/StringParser$Encoding;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static")]
		public static JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>>(ret);
		}

		[JniSignatureAttribute("()B", "public")]
		public byte byteValue()
		{
			var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jfr/internal/consumer/StringParser$Encoding;", "public static")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>(ret);
		}

		[JniSignatureAttribute("(B)Z", "public")]
		public bool @is(byte arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[Ljdk/jfr/internal/consumer/StringParser$Encoding;", "private static")]
		public static JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.StringParser.Encoding>>(ret);
		}
	}
}
