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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/DTLSOutputRecord;", "final")]
public partial class DTLSOutputRecord
	: Dova.JDK.sun.security.ssl.OutputRecord
	, Dova.JDK.sun.security.ssl.DTLSRecord
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DTLSOutputRecord()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSOutputRecord;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fragmenter", "Lsun/security/ssl/DTLSOutputRecord$DTLSFragmenter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeEpoch", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevWriteEpoch", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevWriteAuthenticator", "Lsun/security/ssl/Authenticator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevWriteCipher", "Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isCloseWaiting", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeHash;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Lsun/security/ssl/Ciphertext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "([Ljava/nio/ByteBuffer;II[Ljava/nio/ByteBuffer;II)Lsun/security/ssl/Ciphertext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeHandshake", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initHandshaker", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeAlert", "(BB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishHandshake", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isClosed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeChangeCipherSpec", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireCiphertext", "(Ljava/nio/ByteBuffer;)Lsun/security/ssl/Ciphertext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeWriteCiphers", "(Lsun/security/ssl/SSLCipher$SSLWriteCipher;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "launchRetransmission", "()V"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSOutputRecord$DTLSFragmenter;", "private")]
	public Dova.JDK.sun.security.ssl.DTLSOutputRecord.DTLSFragmenter fragmenter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DTLSOutputRecord.DTLSFragmenter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int writeEpoch_Property
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

	[JniSignatureAttribute("I", "")]
	public int prevWriteEpoch_Property
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

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator;", "")]
	public Dova.JDK.sun.security.ssl.Authenticator prevWriteAuthenticator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "")]
	public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher prevWriteCipher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool isCloseWaiting_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DTLSOutputRecord(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeHash;)V", "")]
	public DTLSOutputRecord(Dova.JDK.sun.security.ssl.HandshakeHash arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSOutputRecord;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Lsun/security/ssl/Ciphertext;", "private")]
	public Dova.JDK.sun.security.ssl.Ciphertext encode(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2, Dova.JDK.java.nio.ByteBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Ciphertext>(ret);
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II[Ljava/nio/ByteBuffer;II)Lsun/security/ssl/Ciphertext;", "")]
	public Dova.JDK.sun.security.ssl.Ciphertext encode(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Ciphertext>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("([BII)V", "")]
	public void encodeHandshake(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "")]
	public void initHandshaker()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(BB)V", "")]
	public void encodeAlert(byte arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void finishHandshake()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isClosed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void encodeChangeCipherSpec()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Lsun/security/ssl/Ciphertext;", "private")]
	public Dova.JDK.sun.security.ssl.Ciphertext acquireCiphertext(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Ciphertext>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher$SSLWriteCipher;Z)V", "")]
	public void changeWriteCiphers(Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void launchRetransmission()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSOutputRecord$DTLSFragmenter;", "private final")]
	public partial class DTLSFragmenter
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DTLSFragmenter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSOutputRecord$DTLSFragmenter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeMemos", "Ljava/util/LinkedList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acquireIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messageSequence", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flightIsReady", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retransmits", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/security/ssl/DTLSOutputRecord;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/DTLSOutputRecord;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shrinkPacketSize", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queueUpChangeCipherSpec", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queueUpHandshake", "([BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handshakeHashing", "(Lsun/security/ssl/DTLSOutputRecord$HandshakeMemo;[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasAlert", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queueUpAlert", "(BB)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireCiphertext", "(Ljava/nio/ByteBuffer;)Lsun/security/ssl/Ciphertext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRetransmittable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRetransmission", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/LinkedList;", "private final")]
		public Dova.JDK.java.util.LinkedList handshakeMemos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int acquireIndex_Property
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

		[JniSignatureAttribute("I", "private")]
		public int messageSequence_Property
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

		[JniSignatureAttribute("Z", "private")]
		public bool flightIsReady_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int retransmits_Property
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

		[JniSignatureAttribute("Lsun/security/ssl/DTLSOutputRecord;", "final")]
		public Dova.JDK.sun.security.ssl.DTLSOutputRecord this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DTLSOutputRecord>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DTLSFragmenter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSOutputRecord;)V", "private")]
		public DTLSFragmenter(Dova.JDK.sun.security.ssl.DTLSOutputRecord arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSOutputRecord$DTLSFragmenter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void shrinkPacketSize()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()V", "")]
		public void queueUpChangeCipherSpec()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("([BII)V", "")]
		public void queueUpHandshake(JavaArray<byte> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSOutputRecord$HandshakeMemo;[B)V", "private")]
		public void handshakeHashing(Dova.JDK.sun.security.ssl.DTLSOutputRecord.HandshakeMemo arg0, JavaArray<byte> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool hasAlert()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(BB)V", "")]
		public void queueUpAlert(byte arg0, byte arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Lsun/security/ssl/Ciphertext;", "")]
		public Dova.JDK.sun.security.ssl.Ciphertext acquireCiphertext(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Ciphertext>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isRetransmittable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void setRetransmission()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSOutputRecord$HandshakeMemo;", "private static")]
	public partial class HandshakeMemo
		: Dova.JDK.sun.security.ssl.DTLSOutputRecord.RecordMemo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HandshakeMemo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSOutputRecord$HandshakeMemo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeType", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messageSequence", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acquireOffset", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("B", "")]
		public byte handshakeType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int messageSequence_Property
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

		[JniSignatureAttribute("I", "")]
		public int acquireOffset_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HandshakeMemo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public HandshakeMemo() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSOutputRecord$HandshakeMemo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSOutputRecord$RecordMemo;", "private static")]
	public partial class RecordMemo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RecordMemo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSOutputRecord$RecordMemo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentType", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "majorVersion", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minorVersion", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encodeEpoch", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encodeCipher", "Lsun/security/ssl/SSLCipher$SSLWriteCipher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fragment", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("B", "")]
		public byte contentType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte majorVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte minorVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int encodeEpoch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$SSLWriteCipher;", "")]
		public Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher encodeCipher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLWriteCipher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "")]
		public JavaArray<byte> fragment_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RecordMemo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public RecordMemo() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSOutputRecord$RecordMemo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
