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

namespace Dova.JDK.jdk.@internal.net.http;

[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent;", "")]
public partial class ResponseContent
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ResponseContent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseContent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pusher", "Ljava/net/http/HttpResponse$BodySubscriber;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentLength", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "headers", "Ljava/net/http/HttpHeaders;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onFinished", "Ljava/lang/Runnable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dbgTag", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LF", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunkedContent", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunkedContentInitialized", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_CHUNK_HEADER_SIZE", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/HttpConnection;JLjava/net/http/HttpHeaders;Ljava/net/http/HttpResponse$BodySubscriber;Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBodyParser", "(Ljava/util/function/Consumer;)Ljdk/internal/net/http/ResponseContent$BodyParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentChunked", "()Z"));
	}

	[JniSignatureAttribute("Ljava/net/http/HttpResponse$BodySubscriber;", "final")]
	public Dova.JDK.java.net.http.HttpResponse.BodySubscriber pusher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "final")]
	public long contentLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpHeaders;", "final")]
	public Dova.JDK.java.net.http.HttpHeaders headers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
	public Dova.JDK.java.lang.Runnable onFinished_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String dbgTag_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int LF_Property
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
	public static int CR_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool chunkedContent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool chunkedContentInitialized_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_CHUNK_HEADER_SIZE_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ResponseContent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpConnection;JLjava/net/http/HttpHeaders;Ljava/net/http/HttpResponse$BodySubscriber;Ljava/lang/Runnable;)V", "")]
	public ResponseContent(Dova.JDK.jdk.@internal.net.http.HttpConnection arg0, long arg1, Dova.JDK.java.net.http.HttpHeaders arg2, Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg3, Dova.JDK.java.lang.Runnable arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseContent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljdk/internal/net/http/ResponseContent$BodyParser;", "")]
	public Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser getBodyParser(Dova.JDK.java.util.function.Consumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool contentChunked()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$ChunkedBodyParser;", "")]
	public partial class ChunkedBodyParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChunkedBodyParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseContent$ChunkedBodyParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "READMORE", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onComplete", "Ljava/util/function/Consumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dbgTag", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closedExceptionally", "Ljava/lang/Throwable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "partialChunklen", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunklen", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytesremaining", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cr", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunkext", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "digits", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytesToConsume", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "Ljdk/internal/net/http/ResponseContent$ChunkState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sub", "Ljdk/internal/net/http/AbstractSubscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/net/http/ResponseContent;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/ResponseContent;Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDigit", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "currentStateMessage", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dbgString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljdk/internal/net/http/AbstractSubscription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryConsumeBytes", "(Ljava/nio/ByteBuffer;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryPushOneHunk", "(Ljava/nio/ByteBuffer;Ljava/util/List;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debugBuffer", "(Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryReadChunkLen", "(Ljava/nio/ByteBuffer;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryReadOneHunk", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;"));
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "final")]
		public Dova.JDK.java.nio.ByteBuffer READMORE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "final")]
		public Dova.JDK.java.util.function.Consumer onComplete_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/Logger;", "final")]
		public Dova.JDK.jdk.@internal.net.http.common.Logger debug_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String dbgTag_Property
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

		[JniSignatureAttribute("Ljava/lang/Throwable;", "volatile")]
		public Dova.JDK.java.lang.Throwable closedExceptionally_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "volatile")]
		public int partialChunklen_Property
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

		[JniSignatureAttribute("I", "volatile")]
		public int chunklen_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "volatile")]
		public int bytesremaining_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("Z", "volatile")]
		public bool cr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("I", "volatile")]
		public int chunkext_Property
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

		[JniSignatureAttribute("I", "volatile")]
		public int digits_Property
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

		[JniSignatureAttribute("I", "volatile")]
		public int bytesToConsume_Property
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

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$ChunkState;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState state_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/AbstractSubscription;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.AbstractSubscription sub_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent;", "final")]
		public Dova.JDK.jdk.@internal.net.http.ResponseContent this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChunkedBodyParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/ResponseContent;Ljava/util/function/Consumer;)V", "")]
		public ChunkedBodyParser(Dova.JDK.jdk.@internal.net.http.ResponseContent arg0, Dova.JDK.java.util.function.Consumer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseContent$ChunkedBodyParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
		public void accept(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void accept(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(I)I", "private")]
		public int toDigit(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String currentStateMessage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String dbgString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/AbstractSubscription;)V", "public")]
		public void onSubscribe(Dova.JDK.jdk.@internal.net.http.AbstractSubscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)I", "private")]
		public int tryConsumeBytes(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/util/List;)Z", "private")]
		public bool tryPushOneHunk(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "private")]
		public void debugBuffer(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)I", "private")]
		public int tryReadChunkLen(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "")]
		public Dova.JDK.java.nio.ByteBuffer tryReadOneHunk(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$UnknownLengthBodyParser;", "")]
	public partial class UnknownLengthBodyParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnknownLengthBodyParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseContent$UnknownLengthBodyParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onComplete", "Ljava/util/function/Consumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dbgTag", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closedExceptionally", "Ljava/lang/Throwable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sub", "Ljdk/internal/net/http/AbstractSubscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "breceived", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/net/http/ResponseContent;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/ResponseContent;Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "currentStateMessage", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dbgString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljdk/internal/net/http/AbstractSubscription;)V"));
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "final")]
		public Dova.JDK.java.util.function.Consumer onComplete_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/Logger;", "final")]
		public Dova.JDK.jdk.@internal.net.http.common.Logger debug_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String dbgTag_Property
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

		[JniSignatureAttribute("Ljava/lang/Throwable;", "volatile")]
		public Dova.JDK.java.lang.Throwable closedExceptionally_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/AbstractSubscription;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.AbstractSubscription sub_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "volatile")]
		public int breceived_Property
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

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent;", "final")]
		public Dova.JDK.jdk.@internal.net.http.ResponseContent this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnknownLengthBodyParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/ResponseContent;Ljava/util/function/Consumer;)V", "")]
		public UnknownLengthBodyParser(Dova.JDK.jdk.@internal.net.http.ResponseContent arg0, Dova.JDK.java.util.function.Consumer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseContent$UnknownLengthBodyParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
		public void accept(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void accept(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void complete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String currentStateMessage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String dbgString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/AbstractSubscription;)V", "public")]
		public void onSubscribe(Dova.JDK.jdk.@internal.net.http.AbstractSubscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$FixedLengthBodyParser;", "")]
	public partial class FixedLengthBodyParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.ResponseContent.BodyParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FixedLengthBodyParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseContent$FixedLengthBodyParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentLength", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onComplete", "Ljava/util/function/Consumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dbgTag", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "remaining", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closedExceptionally", "Ljava/lang/Throwable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sub", "Ljdk/internal/net/http/AbstractSubscription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/net/http/ResponseContent;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/ResponseContent;JLjava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "currentStateMessage", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dbgString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljdk/internal/net/http/AbstractSubscription;)V"));
		}

		[JniSignatureAttribute("J", "final")]
		public long contentLength_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Consumer;", "final")]
		public Dova.JDK.java.util.function.Consumer onComplete_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/common/Logger;", "final")]
		public Dova.JDK.jdk.@internal.net.http.common.Logger debug_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String dbgTag_Property
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

		[JniSignatureAttribute("J", "volatile")]
		public long remaining_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Throwable;", "volatile")]
		public Dova.JDK.java.lang.Throwable closedExceptionally_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/AbstractSubscription;", "volatile")]
		public Dova.JDK.jdk.@internal.net.http.AbstractSubscription sub_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.AbstractSubscription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent;", "final")]
		public Dova.JDK.jdk.@internal.net.http.ResponseContent this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FixedLengthBodyParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/ResponseContent;JLjava/util/function/Consumer;)V", "")]
		public FixedLengthBodyParser(Dova.JDK.jdk.@internal.net.http.ResponseContent arg0, long arg1, Dova.JDK.java.util.function.Consumer arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseContent$FixedLengthBodyParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
		public void accept(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void accept(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String currentStateMessage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String dbgString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/AbstractSubscription;)V", "public")]
		public void onSubscribe(Dova.JDK.jdk.@internal.net.http.AbstractSubscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$ChunkState;", "static final")]
	public partial class ChunkState
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChunkState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseContent$ChunkState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "READING_LENGTH", "Ljdk/internal/net/http/ResponseContent$ChunkState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "READING_DATA", "Ljdk/internal/net/http/ResponseContent$ChunkState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DONE", "Ljdk/internal/net/http/ResponseContent$ChunkState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/net/http/ResponseContent$ChunkState;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/net/http/ResponseContent$ChunkState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/net/http/ResponseContent$ChunkState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/net/http/ResponseContent$ChunkState;"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$ChunkState;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState READING_LENGTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$ChunkState;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState READING_DATA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$ChunkState;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState DONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/net/http/ResponseContent$ChunkState;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChunkState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ChunkState(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/ResponseContent$ChunkState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/net/http/ResponseContent$ChunkState;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/net/http/ResponseContent$ChunkState;", "public static")]
		public static Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/ResponseContent$ChunkState;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.ResponseContent.ChunkState>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/ResponseContent$BodyParser;", "abstract static interface")]
	public partial interface BodyParser
		: IJavaObject
		, Dova.JDK.java.util.function.Consumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodyParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/ResponseContent$BodyParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "currentStateMessage", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSubscribe", "(Ljdk/internal/net/http/AbstractSubscription;)V"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String currentStateMessage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/AbstractSubscription;)V", "public abstract")]
		void onSubscribe(Dova.JDK.jdk.@internal.net.http.AbstractSubscription arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
