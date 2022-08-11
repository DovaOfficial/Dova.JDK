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

[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage;", "final")]
public partial class CertificateMessage
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CertificateMessage()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CertificateMessage;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t12HandshakeConsumer", "Lsun/security/ssl/SSLConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t12HandshakeProducer", "Lsun/security/ssl/HandshakeProducer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t13HandshakeConsumer", "Lsun/security/ssl/SSLConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t13HandshakeProducer", "Lsun/security/ssl/HandshakeProducer;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLConsumer;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLConsumer t12HandshakeConsumer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLConsumer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeProducer;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeProducer t12HandshakeProducer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeProducer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLConsumer;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLConsumer t13HandshakeConsumer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLConsumer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeProducer;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeProducer t13HandshakeProducer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeProducer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CertificateMessage(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public CertificateMessage() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/CertificateMessage;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage$T12CertificateConsumer;", "static final")]
	public partial class T12CertificateConsumer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12CertificateConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CertificateMessage$T12CertificateConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onCertificate", "(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/CertificateMessage$T12CertificateMessage;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onCertificate", "(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/CertificateMessage$T12CertificateMessage;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkClientCerts", "(Lsun/security/ssl/ServerHandshakeContext;[Ljava/security/cert/X509Certificate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isIdentityEquivalent", "(Ljava/security/cert/X509Certificate;Ljava/security/cert/X509Certificate;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkServerCerts", "(Lsun/security/ssl/ClientHandshakeContext;[Ljava/security/cert/X509Certificate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSubjectAltNames", "(Ljava/util/Collection;I)Ljava/util/Collection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isEquivalent", "(Ljava/util/Collection;Ljava/util/Collection;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCertificateAlert", "(Lsun/security/ssl/ClientHandshakeContext;Ljava/security/cert/CertificateException;)Lsun/security/ssl/Alert;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12CertificateConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T12CertificateConsumer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CertificateMessage$T12CertificateConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V", "public")]
		public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/CertificateMessage$T12CertificateMessage;)V", "private")]
		public void onCertificate(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.sun.security.ssl.CertificateMessage.T12CertificateMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/CertificateMessage$T12CertificateMessage;)V", "private")]
		public void onCertificate(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, Dova.JDK.sun.security.ssl.CertificateMessage.T12CertificateMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;[Ljava/security/cert/X509Certificate;)V", "private static")]
		public static void checkClientCerts(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;Ljava/security/cert/X509Certificate;)Z", "private static")]
		public static bool isIdentityEquivalent(Dova.JDK.java.security.cert.X509Certificate arg0, Dova.JDK.java.security.cert.X509Certificate arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;[Ljava/security/cert/X509Certificate;)V", "static")]
		public static void checkServerCerts(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;I)Ljava/util/Collection;", "private static")]
		public static Dova.JDK.java.util.Collection getSubjectAltNames(Dova.JDK.java.util.Collection arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;Ljava/util/Collection;)Z", "private static")]
		public static bool isEquivalent(Dova.JDK.java.util.Collection arg0, Dova.JDK.java.util.Collection arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Ljava/security/cert/CertificateException;)Lsun/security/ssl/Alert;", "private static")]
		public static Dova.JDK.sun.security.ssl.Alert getCertificateAlert(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.java.security.cert.CertificateException arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Alert>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage$T12CertificateProducer;", "private static final")]
	public partial class T12CertificateProducer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeProducer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12CertificateProducer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CertificateMessage$T12CertificateProducer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onProduceCertificate", "(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onProduceCertificate", "(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12CertificateProducer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T12CertificateProducer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CertificateMessage$T12CertificateProducer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
		public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "private")]
		public JavaArray<byte> onProduceCertificate(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "private")]
		public JavaArray<byte> onProduceCertificate(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage$T13CertificateConsumer;", "private static final")]
	public partial class T13CertificateConsumer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13CertificateConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CertificateMessage$T13CertificateConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkClientCerts", "(Lsun/security/ssl/ServerHandshakeContext;Ljava/util/List;)[Ljava/security/cert/X509Certificate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkServerCerts", "(Lsun/security/ssl/ClientHandshakeContext;Ljava/util/List;)[Ljava/security/cert/X509Certificate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCertificateAlert", "(Lsun/security/ssl/ClientHandshakeContext;Ljava/security/cert/CertificateException;)Lsun/security/ssl/Alert;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onConsumeCertificate", "(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/CertificateMessage$T13CertificateMessage;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onConsumeCertificate", "(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/CertificateMessage$T13CertificateMessage;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13CertificateConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13CertificateConsumer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CertificateMessage$T13CertificateConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V", "public")]
		public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;Ljava/util/List;)[Ljava/security/cert/X509Certificate;", "private static")]
		public static JavaArray<Dova.JDK.java.security.cert.X509Certificate> checkClientCerts(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Ljava/util/List;)[Ljava/security/cert/X509Certificate;", "private static")]
		public static JavaArray<Dova.JDK.java.security.cert.X509Certificate> checkServerCerts(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Ljava/security/cert/CertificateException;)Lsun/security/ssl/Alert;", "private static")]
		public static Dova.JDK.sun.security.ssl.Alert getCertificateAlert(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.java.security.cert.CertificateException arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Alert>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/CertificateMessage$T13CertificateMessage;)V", "private")]
		public void onConsumeCertificate(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, Dova.JDK.sun.security.ssl.CertificateMessage.T13CertificateMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/CertificateMessage$T13CertificateMessage;)V", "private")]
		public void onConsumeCertificate(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.sun.security.ssl.CertificateMessage.T13CertificateMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage$T13CertificateProducer;", "private static final")]
	public partial class T13CertificateProducer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeProducer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13CertificateProducer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CertificateMessage$T13CertificateProducer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onProduceCertificate", "(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onProduceCertificate", "(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "choosePossession", "(Lsun/security/ssl/HandshakeContext;Lsun/security/ssl/ClientHello$ClientHelloMessage;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13CertificateProducer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13CertificateProducer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CertificateMessage$T13CertificateProducer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
		public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "private")]
		public JavaArray<byte> onProduceCertificate(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "private")]
		public JavaArray<byte> onProduceCertificate(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Lsun/security/ssl/ClientHello$ClientHelloMessage;)Lsun/security/ssl/SSLPossession;", "private static")]
		public static Dova.JDK.sun.security.ssl.SSLPossession choosePossession(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.sun.security.ssl.ClientHello.ClientHelloMessage arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage$T13CertificateMessage;", "static final")]
	public partial class T13CertificateMessage
		: Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13CertificateMessage()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CertificateMessage$T13CertificateMessage;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestContext", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "certEntries", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeContext;[BLjava/util/List;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeContext;[B[Ljava/security/cert/X509Certificate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "messageLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handshakeType", "()Lsun/security/ssl/SSLHandshake;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Lsun/security/ssl/HandshakeOutStream;)V"));
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> requestContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List certEntries_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13CertificateMessage(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)V", "")]
		public T13CertificateMessage(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.java.nio.ByteBuffer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;[BLjava/util/List;)V", "")]
		public T13CertificateMessage(Dova.JDK.sun.security.ssl.HandshakeContext arg0, JavaArray<byte> arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;[B[Ljava/security/cert/X509Certificate;)V", "")]
		public T13CertificateMessage(Dova.JDK.sun.security.ssl.HandshakeContext arg0, JavaArray<byte> arg1, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CertificateMessage$T13CertificateMessage;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int messageLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/security/ssl/SSLHandshake;", "public")]
		public Dova.JDK.sun.security.ssl.SSLHandshake handshakeType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeOutStream;)V", "public")]
		public void send(Dova.JDK.sun.security.ssl.HandshakeOutStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage$CertificateEntry;", "static final")]
	public partial class CertificateEntry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CertificateEntry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CertificateMessage$CertificateEntry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encoded", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extensions", "Lsun/security/ssl/SSLExtensions;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BLsun/security/ssl/SSLExtensions;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEncodedSize", "()I"));
		}

		[JniSignatureAttribute("[B", "final")]
		public JavaArray<byte> encoded_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLExtensions;", "private final")]
		public Dova.JDK.sun.security.ssl.SSLExtensions extensions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLExtensions>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CertificateEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([BLsun/security/ssl/SSLExtensions;)V", "")]
		public CertificateEntry(JavaArray<byte> arg0, Dova.JDK.sun.security.ssl.SSLExtensions arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CertificateMessage$CertificateEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "private")]
		public int getEncodedSize()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage$T12CertificateMessage;", "static final")]
	public partial class T12CertificateMessage
		: Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12CertificateMessage()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CertificateMessage$T12CertificateMessage;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encodedCertChain", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeContext;[Ljava/security/cert/X509Certificate;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "messageLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handshakeType", "()Lsun/security/ssl/SSLHandshake;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Lsun/security/ssl/HandshakeOutStream;)V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "final")]
		public Dova.JDK.java.util.List encodedCertChain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12CertificateMessage(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;[Ljava/security/cert/X509Certificate;)V", "")]
		public T12CertificateMessage(Dova.JDK.sun.security.ssl.HandshakeContext arg0, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)V", "")]
		public T12CertificateMessage(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.java.nio.ByteBuffer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CertificateMessage$T12CertificateMessage;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int messageLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/security/ssl/SSLHandshake;", "public")]
		public Dova.JDK.sun.security.ssl.SSLHandshake handshakeType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeOutStream;)V", "public")]
		public void send(Dova.JDK.sun.security.ssl.HandshakeOutStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}
}
