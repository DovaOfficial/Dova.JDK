/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.net.http.websocket;

[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame;", "final")]
public partial class Frame
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Frame()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/net/http/websocket/Frame;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_HEADER_SIZE_BYTES", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_CONTROL_FRAME_PAYLOAD_LENGTH", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Frame", "()V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_HEADER_SIZE_BYTES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_CONTROL_FRAME_PAYLOAD_LENGTH_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Frame(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Frame() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/Frame;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Reader;", "static final")]
	public partial class Reader
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Reader()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/net/http/websocket/Frame$Reader;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AWAITING_FIRST_BYTE", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AWAITING_SECOND_BYTE", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "READING_16_LENGTH", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "READING_64_LENGTH", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "READING_MASK", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "READING_PAYLOAD", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "accumulator", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "state", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "mask", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "remainingPayloadLength", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Reader", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "notMinimalEncoding", "(J)Ljdk/internal/net/http/websocket/FailWebSocketException;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readFrame", "(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/websocket/Frame$Consumer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "negativePayload", "(J)Ljdk/internal/net/http/websocket/FailWebSocketException;"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int AWAITING_FIRST_BYTE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int AWAITING_SECOND_BYTE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int READING_16_LENGTH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int READING_64_LENGTH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int READING_MASK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int READING_PAYLOAD_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "private final")]
		public Dova.JDK.java.nio.ByteBuffer accumulator_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int state_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool mask_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long remainingPayloadLength_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Reader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Reader() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/Frame$Reader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(J)Ljdk/internal/net/http/websocket/FailWebSocketException;", "private static")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.FailWebSocketException notMinimalEncoding(long arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.FailWebSocketException>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljdk/internal/net/http/websocket/Frame$Consumer;)V", "")]
		public void readFrame(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.jdk.@internal.net.http.websocket.Frame.Consumer arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(J)Ljdk/internal/net/http/websocket/FailWebSocketException;", "private static")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.FailWebSocketException negativePayload(long arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.FailWebSocketException>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Consumer;", "abstract static interface")]
	public partial interface Consumer
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Consumer()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/net/http/websocket/Frame$Consumer;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mask", "(Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "opcode", "(Ljdk/internal/net/http/websocket/Frame$Opcode;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fin", "(Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "payloadData", "(Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "maskingKey", "(I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "rsv3", "(Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "endFrame", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "payloadLen", "(J)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "rsv1", "(Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "rsv2", "(Z)V"));
		}

		[JniSignatureAttribute("(Z)V", "public abstract")]
		void mask(bool arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/websocket/Frame$Opcode;)V", "public abstract")]
		void opcode(Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public abstract")]
		void fin(bool arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public abstract")]
		void payloadData(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(I)V", "public abstract")]
		void maskingKey(int arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public abstract")]
		void rsv3(bool arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void endFrame()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(J)V", "public abstract")]
		void payloadLen(long arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public abstract")]
		void rsv1(bool arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public abstract")]
		void rsv2(bool arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "static final")]
	public partial class HeaderWriter
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HeaderWriter()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/net/http/websocket/Frame$HeaderWriter;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "firstChar", "C"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "payloadLen", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "maskingKey", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "mask", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "HeaderWriter", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "write", "(Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mask", "(I)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "opcode", "(Ljdk/internal/net/http/websocket/Frame$Opcode;)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fin", "(Z)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "noMask", "()Ljdk/internal/net/http/websocket/Frame$HeaderWriter;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "rsv3", "(Z)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "payloadLen", "(J)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "rsv1", "(Z)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "rsv2", "(Z)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;"));
		}

		[JniSignatureAttribute("C", "private")]
		public char firstChar_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long payloadLen_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int maskingKey_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool mask_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HeaderWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public HeaderWriter() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/Frame$HeaderWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "")]
		public void write(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter mask(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/websocket/Frame$Opcode;)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter opcode(Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter>(ret);
		}

		[JniSignatureAttribute("(Z)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter fin(bool arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter noMask()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter>(ret);
		}

		[JniSignatureAttribute("(Z)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter rsv3(bool arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter>(ret);
		}

		[JniSignatureAttribute("(J)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter payloadLen(long arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter>(ret);
		}

		[JniSignatureAttribute("(Z)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter rsv1(bool arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter>(ret);
		}

		[JniSignatureAttribute("(Z)Ljdk/internal/net/http/websocket/Frame$HeaderWriter;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter rsv2(bool arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.HeaderWriter>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Masker;", "static final")]
	public partial class Masker
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Masker()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/net/http/websocket/Frame$Masker;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "acc", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "maskBytes", "[I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "offset", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "maskLong", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Masker", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "begin", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mask", "(I)Ljdk/internal/net/http/websocket/Frame$Masker;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "loop", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "transferMasking", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljdk/internal/net/http/websocket/Frame$Masker;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "transferMasking", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;I)V"));
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "private final")]
		public Dova.JDK.java.nio.ByteBuffer acc_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[I", "private final")]
		public JavaArray<int> maskBytes_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int offset_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long maskLong_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Masker(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Masker() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/Frame$Masker;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V", "private")]
		public void end(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V", "private")]
		public void begin(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/websocket/Frame$Masker;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.Masker mask(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Masker>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V", "private")]
		public void loop(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljdk/internal/net/http/websocket/Frame$Masker;", "")]
		public Dova.JDK.jdk.@internal.net.http.websocket.Frame.Masker transferMasking(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Masker>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;I)V", "static")]
		public static void transferMasking(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "static final")]
	public partial class Opcode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Opcode()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/net/http/websocket/Frame$Opcode;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTINUATION", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TEXT", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BINARY", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NON_CONTROL_0x3", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NON_CONTROL_0x4", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NON_CONTROL_0x5", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NON_CONTROL_0x6", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NON_CONTROL_0x7", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CLOSE", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PING", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PONG", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTROL_0xB", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTROL_0xC", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTROL_0xD", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTROL_0xE", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONTROL_0xF", "Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "opcodes", "[Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "code", "B"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Opcode", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljdk/internal/net/http/websocket/Frame$Opcode;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isControl", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofCode", "(I)Ljdk/internal/net/http/websocket/Frame$Opcode;"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode CONTINUATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode TEXT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode BINARY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode NON_CONTROL_0x3_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode NON_CONTROL_0x4_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode NON_CONTROL_0x5_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode NON_CONTROL_0x6_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode NON_CONTROL_0x7_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode CLOSE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode PING_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode PONG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode CONTROL_0xB_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode CONTROL_0xC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode CONTROL_0xD_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode CONTROL_0xE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static final")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode CONTROL_0xF_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljdk/internal/net/http/websocket/Frame$Opcode;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode> opcodes_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("B", "private final")]
		public byte code_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("[Ljdk/internal/net/http/websocket/Frame$Opcode;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Opcode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public Opcode(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/Frame$Opcode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/net/http/websocket/Frame$Opcode;", "public static")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/websocket/Frame$Opcode;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isControl()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/websocket/Frame$Opcode;", "static")]
		public static Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode ofCode(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Frame.Opcode>(ret);
		}
	}
}
