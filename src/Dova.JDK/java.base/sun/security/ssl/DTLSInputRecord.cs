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

[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord;", "final")]
public partial class DTLSInputRecord
	: Dova.JDK.sun.security.ssl.InputRecord
	, Dova.JDK.sun.security.ssl.DTLSRecord
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DTLSInputRecord()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSInputRecord;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reassembler", "Lsun/security/ssl/DTLSInputRecord$DTLSReassembler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readEpoch", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeHash;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "([Ljava/nio/ByteBuffer;II)[Lsun/security/ssl/Plaintext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "(Ljava/nio/ByteBuffer;)[Lsun/security/ssl/Plaintext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishHandshake", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectingFinishFlight", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquirePlaintext", "()Lsun/security/ssl/Plaintext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseHandshakeMessage", "(BBB[BIJLjava/nio/ByteBuffer;)Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bytesInCompletePacket", "([Ljava/nio/ByteBuffer;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bytesInCompletePacket", "(Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeReadCiphers", "(Lsun/security/ssl/SSLCipher$SSLReadCipher;)V"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord$DTLSReassembler;", "private")]
	public Dova.JDK.sun.security.ssl.DTLSInputRecord.DTLSReassembler reassembler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DTLSInputRecord.DTLSReassembler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int readEpoch_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DTLSInputRecord(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeHash;)V", "")]
	public DTLSInputRecord(Dova.JDK.sun.security.ssl.HandshakeHash arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSInputRecord;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)[Lsun/security/ssl/Plaintext;", "")]
	public JavaArray<Dova.JDK.sun.security.ssl.Plaintext> decode(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.Plaintext>>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)[Lsun/security/ssl/Plaintext;", "")]
	public JavaArray<Dova.JDK.sun.security.ssl.Plaintext> decode(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.Plaintext>>(ret);
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

	[JniSignatureAttribute("()V", "")]
	public void finishHandshake()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(I)I", "")]
	public int estimateFragmentSize(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void expectingFinishFlight()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()Lsun/security/ssl/Plaintext;", "")]
	public Dova.JDK.sun.security.ssl.Plaintext acquirePlaintext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
	}

	[JniSignatureAttribute("(BBB[BIJLjava/nio/ByteBuffer;)Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;", "private static")]
	public static Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFragment parseHandshakeMessage(byte arg0, byte arg1, byte arg2, JavaArray<byte> arg3, int arg4, long arg5, Dova.JDK.java.nio.ByteBuffer arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFragment>(ret);
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)I", "")]
	public int bytesInCompletePacket(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)I", "private")]
	public int bytesInCompletePacket(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher$SSLReadCipher;)V", "")]
	public void changeReadCiphers(Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord$DTLSReassembler;", "final")]
	public partial class DTLSReassembler
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DTLSReassembler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSInputRecord$DTLSReassembler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeEpoch", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferedFragments", "Ljava/util/TreeSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeFlight", "Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "precedingFlight", "Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextRecordEpoch", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextRecordSeq", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expectCCSFlight", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flightIsReady", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "needToCheckFlight", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/security/ssl/DTLSInputRecord;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/DTLSInputRecord;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectingFinishFlight", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquirePlaintext", "()Lsun/security/ssl/Plaintext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queueUpFragment", "(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queueUpChangeCipherSpec", "(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queueUpHandshake", "(Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flightIsReady", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDesirable", "(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanUpRetransmit", "(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bufferFragment", "(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetHandshakeFlight", "(Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireHandshakeMessage", "()Lsun/security/ssl/Plaintext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireCachedMessage", "()Lsun/security/ssl/Plaintext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handshakeHashing", "(Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;Lsun/security/ssl/Plaintext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasFinishedMessage", "(Ljava/util/Set;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasCompleted", "(B)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasCompleted", "(Ljava/util/Set;II)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needClientVerify", "(Ljava/util/Set;)Z"));
		}

		[JniSignatureAttribute("I", "final")]
		public int handshakeEpoch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/TreeSet;", "")]
		public Dova.JDK.java.util.TreeSet bufferedFragments_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.TreeSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;", "")]
		public Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFlight handshakeFlight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFlight>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;", "")]
		public Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFlight precedingFlight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFlight>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int nextRecordEpoch_Property
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

		[JniSignatureAttribute("J", "")]
		public long nextRecordSeq_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool expectCCSFlight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool flightIsReady_Property
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

		[JniSignatureAttribute("Z", "")]
		public bool needToCheckFlight_Property
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

		[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord;", "final")]
		public Dova.JDK.sun.security.ssl.DTLSInputRecord this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DTLSInputRecord>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DTLSReassembler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord;I)V", "")]
		public DTLSReassembler(Dova.JDK.sun.security.ssl.DTLSInputRecord arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSInputRecord$DTLSReassembler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "private")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()V", "")]
		public void expectingFinishFlight()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/Plaintext;", "")]
		public Dova.JDK.sun.security.ssl.Plaintext acquirePlaintext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)V", "")]
		public void queueUpFragment(Dova.JDK.sun.security.ssl.DTLSInputRecord.RecordFragment arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)V", "")]
		public void queueUpChangeCipherSpec(Dova.JDK.sun.security.ssl.DTLSInputRecord.RecordFragment arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;)V", "")]
		public void queueUpHandshake(Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFragment arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool flightIsReady()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)Z", "private")]
		public bool isDesirable(Dova.JDK.sun.security.ssl.DTLSInputRecord.RecordFragment arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)V", "private")]
		public void cleanUpRetransmit(Dova.JDK.sun.security.ssl.DTLSInputRecord.RecordFragment arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)V", "private")]
		public void bufferFragment(Dova.JDK.sun.security.ssl.DTLSInputRecord.RecordFragment arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;)V", "private")]
		public void resetHandshakeFlight(Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFlight arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/Plaintext;", "private")]
		public Dova.JDK.sun.security.ssl.Plaintext acquireHandshakeMessage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/Plaintext;", "private")]
		public Dova.JDK.sun.security.ssl.Plaintext acquireCachedMessage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;Lsun/security/ssl/Plaintext;)V", "private")]
		public void handshakeHashing(Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFragment arg0, Dova.JDK.sun.security.ssl.Plaintext arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Z", "private")]
		public bool hasFinishedMessage(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return ret;
		}

		[JniSignatureAttribute("(B)Z", "private")]
		public bool hasCompleted(byte arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Set;II)Z", "private")]
		public bool hasCompleted(Dova.JDK.java.util.Set arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Z", "private")]
		public bool needClientVerify(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord$RecordFragment;", "private static")]
	public partial class RecordFragment
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Comparable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RecordFragment()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSInputRecord$RecordFragment;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isCiphertext", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentType", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "majorVersion", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minorVersion", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordEpoch", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordSeq", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordEnS", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fragment", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/ByteBuffer;BBB[BIJZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BBBB[BIJZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareToSequence", "(IJ)I"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool isCiphertext_Property
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

		[JniSignatureAttribute("B", "")]
		public byte contentType_Property
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
		public byte majorVersion_Property
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

		[JniSignatureAttribute("B", "")]
		public byte minorVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int recordEpoch_Property
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

		[JniSignatureAttribute("J", "")]
		public long recordSeq_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("[B", "")]
		public JavaArray<byte> recordEnS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "")]
		public JavaArray<byte> fragment_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RecordFragment(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;BBB[BIJZ)V", "")]
		public RecordFragment(Dova.JDK.java.nio.ByteBuffer arg0, byte arg1, byte arg2, byte arg3, JavaArray<byte> arg4, int arg5, long arg6, bool arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		[JniSignatureAttribute("([BBBB[BIJZ)V", "")]
		public RecordFragment(JavaArray<byte> arg0, byte arg1, byte arg2, byte arg3, JavaArray<byte> arg4, int arg5, long arg6, bool arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSInputRecord$RecordFragment;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
		public int compareTo(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)I", "public")]
		public int compareTo(Dova.JDK.sun.security.ssl.DTLSInputRecord.RecordFragment arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(IJ)I", "")]
		public int compareToSequence(int arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;", "private static final")]
	public partial class HandshakeFragment
		: Dova.JDK.sun.security.ssl.DTLSInputRecord.RecordFragment
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HandshakeFragment()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeType", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messageSeq", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messageLength", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fragmentOffset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fragmentLength", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BBBB[BIJBIIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
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
		public int messageSeq_Property
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
		public int messageLength_Property
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

		[JniSignatureAttribute("I", "")]
		public int fragmentOffset_Property
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

		[JniSignatureAttribute("I", "")]
		public int fragmentLength_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HandshakeFragment(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([BBBB[BIJBIIII)V", "")]
		public HandshakeFragment(JavaArray<byte> arg0, byte arg1, byte arg2, byte arg3, JavaArray<byte> arg4, int arg5, long arg6, byte arg7, int arg8, int arg9, int arg10, int arg11) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSInputRecord$HandshakeFragment;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$RecordFragment;)I", "public")]
		public int compareTo(Dova.JDK.sun.security.ssl.DTLSInputRecord.RecordFragment arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
		public int compareTo(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;", "private static final")]
	public partial class HandshakeFlight
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Cloneable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HandshakeFlight()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HF_UNKNOWN", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeType", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flightEpoch", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minMessageSeq", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxMessageSeq", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxRecordEpoch", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxRecordSeq", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "holesMap", "Ljava/util/HashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messageSeqMap", "Ljava/util/HashMap;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRetransmitOf", "(Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;)Z"));
		}

		[JniSignatureAttribute("B", "static final")]
		public static byte HF_UNKNOWN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte handshakeType_Property
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

		[JniSignatureAttribute("I", "")]
		public int flightEpoch_Property
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

		[JniSignatureAttribute("I", "")]
		public int minMessageSeq_Property
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

		[JniSignatureAttribute("I", "")]
		public int maxMessageSeq_Property
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

		[JniSignatureAttribute("I", "")]
		public int maxRecordEpoch_Property
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

		[JniSignatureAttribute("J", "")]
		public long maxRecordSeq_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/HashMap;", "")]
		public Dova.JDK.java.util.HashMap holesMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/HashMap;", "")]
		public Dova.JDK.java.util.HashMap messageSeqMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HandshakeFlight(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public HandshakeFlight() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DTLSInputRecord$HandshakeFlight;)Z", "")]
		public bool isRetransmitOf(Dova.JDK.sun.security.ssl.DTLSInputRecord.HandshakeFlight arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/DTLSInputRecord$HoleDescriptor;", "private static final")]
	public partial class HoleDescriptor
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HoleDescriptor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DTLSInputRecord$HoleDescriptor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "limit", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int limit_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HoleDescriptor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(II)V", "")]
		public HoleDescriptor(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DTLSInputRecord$HoleDescriptor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
