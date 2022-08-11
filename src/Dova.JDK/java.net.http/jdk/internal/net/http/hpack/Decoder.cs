/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.net.http.hpack;

[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder;", "public final")]
public partial class Decoder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Decoder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/Decoder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "logger", "Ljdk/internal/net/http/hpack/HPACK$Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECODERS_IDS", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "states", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "id", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "table", "Ljdk/internal/net/http/hpack/SimpleHeaderTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "Ljdk/internal/net/http/hpack/Decoder$State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "integerReader", "Ljdk/internal/net/http/hpack/IntegerReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stringReader", "Ljdk/internal/net/http/hpack/StringReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "intValue", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstValueRead", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstValueIndex", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameHuffmanEncoded", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueHuffmanEncoded", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "capacity", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "(Ljava/nio/ByteBuffer;ZLjdk/internal/net/http/hpack/DecodingCallback;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTable", "()Ljdk/internal/net/http/hpack/SimpleHeaderTable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMaxCapacity0", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMaxCapacity", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "proceed", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeReady", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeIndexed", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeLiteral", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeLiteralWithIndexing", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeLiteralNeverIndexed", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resumeSizeUpdate", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeaderFieldAt", "(I)Ljdk/internal/net/http/hpack/SimpleHeaderTable$HeaderField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeReading", "(Ljava/nio/ByteBuffer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanUpAfterReading", "()V"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/HPACK$Logger;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.hpack.HPACK.Logger logger_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.HPACK.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicLong DECODERS_IDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static final")]
	public static Dova.JDK.java.util.List states_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private final")]
	public long id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/SimpleHeaderTable;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.hpack.SimpleHeaderTable table_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.SimpleHeaderTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder$State;", "private")]
	public Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/IntegerReader;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.hpack.IntegerReader integerReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.IntegerReader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/StringReader;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.hpack.StringReader stringReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.StringReader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private final")]
	public Dova.JDK.java.lang.StringBuilder name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private final")]
	public Dova.JDK.java.lang.StringBuilder value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int intValue_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool firstValueRead_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool firstValueIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool nameHuffmanEncoded_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool valueHuffmanEncoded_Property
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

	[JniSignatureAttribute("I", "private")]
	public int capacity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Decoder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public Decoder(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/Decoder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;ZLjdk/internal/net/http/hpack/DecodingCallback;)V", "public")]
	public void decode(Dova.JDK.java.nio.ByteBuffer arg0, bool arg1, Dova.JDK.jdk.@internal.net.http.hpack.DecodingCallback arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/hpack/SimpleHeaderTable;", "")]
	public Dova.JDK.jdk.@internal.net.http.hpack.SimpleHeaderTable getTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.SimpleHeaderTable>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void setMaxCapacity0(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMaxCapacity(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V", "private")]
	public void proceed(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.hpack.DecodingCallback arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "private")]
	public void resumeReady(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V", "private")]
	public void resumeIndexed(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.hpack.DecodingCallback arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V", "private")]
	public void resumeLiteral(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.hpack.DecodingCallback arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V", "private")]
	public void resumeLiteralWithIndexing(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.hpack.DecodingCallback arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V", "private")]
	public void resumeLiteralNeverIndexed(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.hpack.DecodingCallback arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/hpack/DecodingCallback;)V", "private")]
	public void resumeSizeUpdate(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.hpack.DecodingCallback arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/SimpleHeaderTable$HeaderField;", "private")]
	public Dova.JDK.jdk.@internal.net.http.hpack.SimpleHeaderTable.HeaderField getHeaderFieldAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.SimpleHeaderTable.HeaderField>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Z", "private")]
	public bool completeReading(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void cleanUpAfterReading()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder$State;", "private static final")]
	public partial class State
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static State()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/Decoder$State;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "READY", "Ljdk/internal/net/http/hpack/Decoder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEXED", "Ljdk/internal/net/http/hpack/Decoder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LITERAL_NEVER_INDEXED", "Ljdk/internal/net/http/hpack/Decoder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LITERAL", "Ljdk/internal/net/http/hpack/Decoder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LITERAL_WITH_INDEXING", "Ljdk/internal/net/http/hpack/Decoder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZE_UPDATE", "Ljdk/internal/net/http/hpack/Decoder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/net/http/hpack/Decoder$State;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/net/http/hpack/Decoder$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/net/http/hpack/Decoder$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/net/http/hpack/Decoder$State;"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State READY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State INDEXED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State LITERAL_NEVER_INDEXED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State LITERAL_WITH_INDEXING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/Decoder$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State SIZE_UPDATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/net/http/hpack/Decoder$State;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public State(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public State(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/Decoder$State;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/net/http/hpack/Decoder$State;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/net/http/hpack/Decoder$State;", "public static")]
		public static Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/hpack/Decoder$State;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.Decoder.State>>(ret);
		}
	}
}
