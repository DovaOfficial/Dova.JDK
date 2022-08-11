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

namespace Dova.JDK.jdk.@internal.net.http.websocket;

[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue;", "public")]
public partial class MessageQueue
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MessageQueue()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/websocket/MessageQueue;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elements", "[Ljdk/internal/net/http/websocket/MessageQueue$Message;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tail", "Ljava/util/concurrent/atomic/AtomicInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "head", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljdk/internal/net/http/websocket/MessageQueue$Type;Ljava/util/function/Supplier;Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;ZILjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peek", "(Ljdk/internal/net/http/websocket/MessageQueue$QueueCallback;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addText", "(Ljava/nio/CharBuffer;ZLjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "effectiveCapacityOf", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBinary", "(Ljava/nio/ByteBuffer;ZLjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPing", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPong", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPong", "(Ljava/util/function/Supplier;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClose", "(ILjava/nio/CharBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V"));
	}

	[JniSignatureAttribute("[Ljdk/internal/net/http/websocket/MessageQueue$Message;", "private final")]
	public JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Message> elements_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Message>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicInteger;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicInteger tail_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private volatile")]
	public int head_Property
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

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MessageQueue(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public MessageQueue(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/MessageQueue;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/net/http/websocket/MessageQueue$Type;Ljava/util/function/Supplier;Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;ZILjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V", "private")]
	public void add(Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type arg0, Dova.JDK.java.util.function.Supplier arg1, Dova.JDK.java.nio.ByteBuffer arg2, Dova.JDK.java.nio.CharBuffer arg3, bool arg4, int arg5, Dova.JDK.java.lang.Object arg6, Dova.JDK.java.util.function.BiConsumer arg7, Dova.JDK.java.util.concurrent.CompletableFuture arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("()V", "public")]
	public void remove()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/websocket/MessageQueue$QueueCallback;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object peek(Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.QueueCallback arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/CharBuffer;ZLjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V", "public")]
	public void addText(Dova.JDK.java.nio.CharBuffer arg0, bool arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.util.function.BiConsumer arg3, Dova.JDK.java.util.concurrent.CompletableFuture arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(I)I", "protected static")]
	public static int effectiveCapacityOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;ZLjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V", "public")]
	public void addBinary(Dova.JDK.java.nio.ByteBuffer arg0, bool arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.util.function.BiConsumer arg3, Dova.JDK.java.util.concurrent.CompletableFuture arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V", "public")]
	public void addPing(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BiConsumer arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V", "public")]
	public void addPong(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BiConsumer arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V", "public")]
	public void addPong(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BiConsumer arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/nio/CharBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)V", "public")]
	public void addClose(int arg0, Dova.JDK.java.nio.CharBuffer arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.util.function.BiConsumer arg3, Dova.JDK.java.util.concurrent.CompletableFuture arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$Message;", "private static")]
	public partial class Message
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Message()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/websocket/MessageQueue$Message;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ready", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binarySupplier", "Ljava/util/function/Supplier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binary", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/nio/CharBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isLast", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "statusCode", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attachment", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "action", "Ljava/util/function/BiConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "future", "Ljava/util/concurrent/CompletableFuture;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Z", "private volatile")]
		public bool ready_Property
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

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$Type;", "private")]
		public Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Supplier;", "private")]
		public Dova.JDK.java.util.function.Supplier binarySupplier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "private")]
		public Dova.JDK.java.nio.ByteBuffer binary_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/CharBuffer;", "private")]
		public Dova.JDK.java.nio.CharBuffer text_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isLast_Property
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

		[JniSignatureAttribute("I", "private")]
		public int statusCode_Property
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

		[JniSignatureAttribute("Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object attachment_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/BiConsumer;", "private")]
		public Dova.JDK.java.util.function.BiConsumer action_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "private")]
		public Dova.JDK.java.util.concurrent.CompletableFuture future_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Message(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Message() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/MessageQueue$Message;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$Type;", "private static final")]
	public partial class Type
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Type()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/websocket/MessageQueue$Type;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEXT", "Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BINARY", "Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PING", "Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PONG", "Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLOSE", "Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/net/http/websocket/MessageQueue$Type;"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$Type;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type TEXT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$Type;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type BINARY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$Type;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type PING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$Type;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type PONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$Type;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type CLOSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/net/http/websocket/MessageQueue$Type;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Type(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Type(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/MessageQueue$Type;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/net/http/websocket/MessageQueue$Type;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/net/http/websocket/MessageQueue$Type;", "public static")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/websocket/MessageQueue$Type;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue.Type>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/MessageQueue$QueueCallback;", "public abstract static interface")]
	public partial interface QueueCallback
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static QueueCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/websocket/MessageQueue$QueueCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onClose", "(ILjava/nio/CharBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onEmpty", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onText", "(Ljava/nio/CharBuffer;ZLjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onBinary", "(Ljava/nio/ByteBuffer;ZLjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onPing", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onPong", "(Ljava/util/function/Supplier;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onPong", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(ILjava/nio/CharBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onClose(int arg0, Dova.JDK.java.nio.CharBuffer arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.util.function.BiConsumer arg3, Dova.JDK.java.util.concurrent.CompletableFuture arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onEmpty()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/CharBuffer;ZLjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onText(Dova.JDK.java.nio.CharBuffer arg0, bool arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.util.function.BiConsumer arg3, Dova.JDK.java.util.concurrent.CompletableFuture arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;ZLjava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onBinary(Dova.JDK.java.nio.ByteBuffer arg0, bool arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.util.function.BiConsumer arg3, Dova.JDK.java.util.concurrent.CompletableFuture arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onPing(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BiConsumer arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onPong(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BiConsumer arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/util/function/BiConsumer;Ljava/util/concurrent/CompletableFuture;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onPong(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BiConsumer arg2, Dova.JDK.java.util.concurrent.CompletableFuture arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
