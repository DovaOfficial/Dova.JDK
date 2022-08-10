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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/SSLExtensions;", "final")]
public partial class SSLExtensions
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLExtensions()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLExtensions;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "handshakeMessage", "Lsun/security/ssl/SSLHandshake$HandshakeMessage;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "extMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "encodedLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "logMap", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SSLExtensions", "(Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SSLExtensions", "(Lsun/security/ssl/SSLHandshake$HandshakeMessage;Ljava/nio/ByteBuffer;[Lsun/security/ssl/SSLExtension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "(Lsun/security/ssl/SSLExtension;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toString", "(I[B)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "consumeOnTrade", "(Lsun/security/ssl/HandshakeContext;[Lsun/security/ssl/SSLExtension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reproduce", "(Lsun/security/ssl/HandshakeContext;[Lsun/security/ssl/SSLExtension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "send", "(Lsun/security/ssl/HandshakeOutStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "produce", "(Lsun/security/ssl/HandshakeContext;[Lsun/security/ssl/SSLExtension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "consumeOnLoad", "(Lsun/security/ssl/HandshakeContext;[Lsun/security/ssl/SSLExtension;)V"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake$HandshakeMessage;", "private final")]
	public Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage handshakeMessage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map extMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int encodedLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map logMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLExtensions(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V", "")]
	public SSLExtensions(Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLHandshake$HandshakeMessage;Ljava/nio/ByteBuffer;[Lsun/security/ssl/SSLExtension;)V", "")]
	public SSLExtensions(Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLExtensions;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/ssl/SSLExtension;)[B", "")]
	public JavaArray<byte> get(Dova.JDK.sun.security.ssl.SSLExtension arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(I[B)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String toString(int arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;[Lsun/security/ssl/SSLExtension;)V", "")]
	public void consumeOnTrade(Dova.JDK.sun.security.ssl.HandshakeContext arg0, JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;[Lsun/security/ssl/SSLExtension;)V", "")]
	public void reproduce(Dova.JDK.sun.security.ssl.HandshakeContext arg0, JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeOutStream;)V", "")]
	public void send(Dova.JDK.sun.security.ssl.HandshakeOutStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;[Lsun/security/ssl/SSLExtension;)V", "")]
	public void produce(Dova.JDK.sun.security.ssl.HandshakeContext arg0, JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;[Lsun/security/ssl/SSLExtension;)V", "")]
	public void consumeOnLoad(Dova.JDK.sun.security.ssl.HandshakeContext arg0, JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}
}
