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

[JniSignatureAttribute("Lsun/security/ssl/InputRecord;", "abstract")]
public partial class InputRecord
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.ssl.Record
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InputRecord()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/InputRecord;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readCipher", "Lsun/security/ssl/SSLCipher$SSLReadCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tc", "Lsun/security/ssl/TransportContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeHash", "Lsun/security/ssl/HandshakeHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isClosed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "helloVersion", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fragmentSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordLock", "Ljava/util/concurrent/locks/ReentrantLock;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeHash;Lsun/security/ssl/SSLCipher$SSLReadCipher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extract", "([Ljava/nio/ByteBuffer;III)Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "([Ljava/nio/ByteBuffer;II)[Lsun/security/ssl/Plaintext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishHandshake", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seqNumIsHuge", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHelloVersion", "(Lsun/security/ssl/ProtocolVersion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isClosed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateFragmentSize", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectingFinishFlight", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquirePlaintext", "()Lsun/security/ssl/Plaintext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bytesInCompletePacket", "([Ljava/nio/ByteBuffer;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bytesInCompletePacket", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeReadCiphers", "(Lsun/security/ssl/SSLCipher$SSLReadCipher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeFragmentSize", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReceiverStream", "(Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDeliverStream", "(Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertToClientHello", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher$SSLReadCipher;", "")]
	public Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher readCipher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/TransportContext;", "")]
	public Dova.JDK.sun.security.ssl.TransportContext tc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.TransportContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeHash;", "final")]
	public Dova.JDK.sun.security.ssl.HandshakeHash handshakeHash_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "volatile")]
	public bool isClosed_Property
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

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "")]
	public Dova.JDK.sun.security.ssl.ProtocolVersion helloVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int fragmentSize_Property
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

	[JniSignatureAttribute("Ljava/util/concurrent/locks/ReentrantLock;", "final")]
	public Dova.JDK.java.util.concurrent.locks.ReentrantLock recordLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReentrantLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InputRecord(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeHash;Lsun/security/ssl/SSLCipher$SSLReadCipher;)V", "")]
	public InputRecord(Dova.JDK.sun.security.ssl.HandshakeHash arg0, Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/InputRecord;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;III)Ljava/nio/ByteBuffer;", "static")]
	public static Dova.JDK.java.nio.ByteBuffer extract(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)[Lsun/security/ssl/Plaintext;", "abstract")]
	public JavaArray<Dova.JDK.sun.security.ssl.Plaintext> decode(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
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

	[JniSignatureAttribute("()Z", "")]
	public bool seqNumIsHuge()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)V", "")]
	public void setHelloVersion(Dova.JDK.sun.security.ssl.ProtocolVersion arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isClosed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "")]
	public int estimateFragmentSize(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void expectingFinishFlight()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Lsun/security/ssl/Plaintext;", "")]
	public Dova.JDK.sun.security.ssl.Plaintext acquirePlaintext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Plaintext>(ret);
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)I", "")]
	public int bytesInCompletePacket(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int bytesInCompletePacket()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLCipher$SSLReadCipher;)V", "")]
	public void changeReadCiphers(Dova.JDK.sun.security.ssl.SSLCipher.SSLReadCipher arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void changeFragmentSize(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)V", "")]
	public void setReceiverStream(Dova.JDK.java.io.InputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "")]
	public void setDeliverStream(Dova.JDK.java.io.OutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "static")]
	public static Dova.JDK.java.nio.ByteBuffer convertToClientHello(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}
}
