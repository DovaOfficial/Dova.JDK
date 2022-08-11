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

[JniSignatureAttribute("Lsun/security/ssl/ServerHello;", "final")]
public partial class ServerHello
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ServerHello()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "handshakeConsumer", "Lsun/security/ssl/SSLConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t12HandshakeProducer", "Lsun/security/ssl/HandshakeProducer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t13HandshakeProducer", "Lsun/security/ssl/HandshakeProducer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "hrrHandshakeProducer", "Lsun/security/ssl/HandshakeProducer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "hrrReproducer", "Lsun/security/ssl/HandshakeProducer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t12HandshakeConsumer", "Lsun/security/ssl/HandshakeConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t13HandshakeConsumer", "Lsun/security/ssl/HandshakeConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "d12HandshakeConsumer", "Lsun/security/ssl/HandshakeConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "d13HandshakeConsumer", "Lsun/security/ssl/HandshakeConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "t13HrrHandshakeConsumer", "Lsun/security/ssl/HandshakeConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "d13HrrHandshakeConsumer", "Lsun/security/ssl/HandshakeConsumer;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setUpPskKD", "(Lsun/security/ssl/HandshakeContext;Ljavax/crypto/SecretKey;)V"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLConsumer;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLConsumer handshakeConsumer_Property
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

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeProducer;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeProducer t13HandshakeProducer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeProducer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeProducer;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeProducer hrrHandshakeProducer_Property
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

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeProducer;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeProducer hrrReproducer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeProducer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeConsumer;", "private static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeConsumer t12HandshakeConsumer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeConsumer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeConsumer;", "private static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeConsumer t13HandshakeConsumer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeConsumer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeConsumer;", "private static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeConsumer d12HandshakeConsumer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeConsumer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeConsumer;", "private static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeConsumer d13HandshakeConsumer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeConsumer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeConsumer;", "private static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeConsumer t13HrrHandshakeConsumer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeConsumer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeConsumer;", "private static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeConsumer d13HrrHandshakeConsumer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeConsumer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ServerHello(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public ServerHello() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Ljavax/crypto/SecretKey;)V", "private static")]
	public static void setUpPskKD(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.javax.crypto.SecretKey arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$ServerHelloConsumer;", "private static final")]
	public partial class ServerHelloConsumer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ServerHelloConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$ServerHelloConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onHelloRetryRequest", "(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/ServerHello$ServerHelloMessage;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onServerHello", "(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/ServerHello$ServerHelloMessage;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ServerHelloConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ServerHelloConsumer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$ServerHelloConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V", "public")]
		public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/ServerHello$ServerHelloMessage;)V", "private")]
		public void onHelloRetryRequest(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.sun.security.ssl.ServerHello.ServerHelloMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;Lsun/security/ssl/ServerHello$ServerHelloMessage;)V", "private")]
		public void onServerHello(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, Dova.JDK.sun.security.ssl.ServerHello.ServerHelloMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$T12ServerHelloProducer;", "private static final")]
	public partial class T12ServerHelloProducer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeProducer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12ServerHelloProducer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$T12ServerHelloProducer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "chooseCipherSuite", "(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/ClientHello$ClientHelloMessage;)Lsun/security/ssl/ServerHello$T12ServerHelloProducer$KeyExchangeProperties;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12ServerHelloProducer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T12ServerHelloProducer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$T12ServerHelloProducer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
		public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/ClientHello$ClientHelloMessage;)Lsun/security/ssl/ServerHello$T12ServerHelloProducer$KeyExchangeProperties;", "private static")]
		public static Dova.JDK.sun.security.ssl.ServerHello.T12ServerHelloProducer.KeyExchangeProperties chooseCipherSuite(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, Dova.JDK.sun.security.ssl.ClientHello.ClientHelloMessage arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ServerHello.T12ServerHelloProducer.KeyExchangeProperties>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/ServerHello$T12ServerHelloProducer$KeyExchangeProperties;", "private static final")]
		public partial class KeyExchangeProperties
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static KeyExchangeProperties()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$T12ServerHelloProducer$KeyExchangeProperties;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipherSuite", "Lsun/security/ssl/CipherSuite;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyExchange", "Lsun/security/ssl/SSLKeyExchange;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "possessions", "[Lsun/security/ssl/SSLPossession;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/CipherSuite;Lsun/security/ssl/SSLKeyExchange;[Lsun/security/ssl/SSLPossession;)V"));
			}

			[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "final")]
			public Dova.JDK.sun.security.ssl.CipherSuite cipherSuite_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "final")]
			public Dova.JDK.sun.security.ssl.SSLKeyExchange keyExchange_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lsun/security/ssl/SSLPossession;", "final")]
			public JavaArray<Dova.JDK.sun.security.ssl.SSLPossession> possessions_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLPossession>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public KeyExchangeProperties(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/CipherSuite;Lsun/security/ssl/SSLKeyExchange;[Lsun/security/ssl/SSLPossession;)V", "private")]
			public KeyExchangeProperties(Dova.JDK.sun.security.ssl.CipherSuite arg0, Dova.JDK.sun.security.ssl.SSLKeyExchange arg1, JavaArray<Dova.JDK.sun.security.ssl.SSLPossession> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$T12ServerHelloProducer$KeyExchangeProperties;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$T13ServerHelloProducer;", "private static final")]
	public partial class T13ServerHelloProducer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeProducer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13ServerHelloProducer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$T13ServerHelloProducer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "chooseCipherSuite", "(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/ClientHello$ClientHelloMessage;)Lsun/security/ssl/CipherSuite;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13ServerHelloProducer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13ServerHelloProducer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$T13ServerHelloProducer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
		public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;Lsun/security/ssl/ClientHello$ClientHelloMessage;)Lsun/security/ssl/CipherSuite;", "private static")]
		public static Dova.JDK.sun.security.ssl.CipherSuite chooseCipherSuite(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, Dova.JDK.sun.security.ssl.ClientHello.ClientHelloMessage arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$T13HelloRetryRequestProducer;", "private static final")]
	public partial class T13HelloRetryRequestProducer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeProducer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13HelloRetryRequestProducer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$T13HelloRetryRequestProducer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13HelloRetryRequestProducer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13HelloRetryRequestProducer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$T13HelloRetryRequestProducer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
		public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$T13HelloRetryRequestReproducer;", "private static final")]
	public partial class T13HelloRetryRequestReproducer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeProducer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13HelloRetryRequestReproducer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$T13HelloRetryRequestReproducer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13HelloRetryRequestReproducer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13HelloRetryRequestReproducer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$T13HelloRetryRequestReproducer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
		public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$T12ServerHelloConsumer;", "private static final")]
	public partial class T12ServerHelloConsumer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12ServerHelloConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$T12ServerHelloConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12ServerHelloConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T12ServerHelloConsumer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$T12ServerHelloConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V", "public")]
		public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$T13ServerHelloConsumer;", "private static final")]
	public partial class T13ServerHelloConsumer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13ServerHelloConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$T13ServerHelloConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13ServerHelloConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13ServerHelloConsumer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$T13ServerHelloConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V", "public")]
		public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$T13HelloRetryRequestConsumer;", "private static final")]
	public partial class T13HelloRetryRequestConsumer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13HelloRetryRequestConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$T13HelloRetryRequestConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13HelloRetryRequestConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public T13HelloRetryRequestConsumer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$T13HelloRetryRequestConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V", "public")]
		public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ServerHello$ServerHelloMessage;", "static final")]
	public partial class ServerHelloMessage
		: Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ServerHelloMessage()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHello$ServerHelloMessage;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverVersion", "Lsun/security/ssl/ProtocolVersion;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverRandom", "Lsun/security/ssl/RandomCookie;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sessionId", "Lsun/security/ssl/SessionId;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipherSuite", "Lsun/security/ssl/CipherSuite;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compressionMethod", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extensions", "Lsun/security/ssl/SSLExtensions;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientHello", "Lsun/security/ssl/ClientHello$ClientHelloMessage;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeRecord", "Ljava/nio/ByteBuffer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeContext;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SessionId;Lsun/security/ssl/CipherSuite;Lsun/security/ssl/RandomCookie;Lsun/security/ssl/ClientHello$ClientHelloMessage;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "messageLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handshakeType", "()Lsun/security/ssl/SSLHandshake;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Lsun/security/ssl/HandshakeOutStream;)V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "final")]
		public Dova.JDK.sun.security.ssl.ProtocolVersion serverVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/RandomCookie;", "final")]
		public Dova.JDK.sun.security.ssl.RandomCookie serverRandom_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.RandomCookie>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SessionId;", "final")]
		public Dova.JDK.sun.security.ssl.SessionId sessionId_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SessionId>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "final")]
		public Dova.JDK.sun.security.ssl.CipherSuite cipherSuite_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("B", "final")]
		public byte compressionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLExtensions;", "final")]
		public Dova.JDK.sun.security.ssl.SSLExtensions extensions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLExtensions>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/ClientHello$ClientHelloMessage;", "final")]
		public Dova.JDK.sun.security.ssl.ClientHello.ClientHelloMessage clientHello_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ClientHello.ClientHelloMessage>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "final")]
		public Dova.JDK.java.nio.ByteBuffer handshakeRecord_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ServerHelloMessage(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SessionId;Lsun/security/ssl/CipherSuite;Lsun/security/ssl/RandomCookie;Lsun/security/ssl/ClientHello$ClientHelloMessage;)V", "")]
		public ServerHelloMessage(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.SessionId arg2, Dova.JDK.sun.security.ssl.CipherSuite arg3, Dova.JDK.sun.security.ssl.RandomCookie arg4, Dova.JDK.sun.security.ssl.ClientHello.ClientHelloMessage arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)V", "")]
		public ServerHelloMessage(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.java.nio.ByteBuffer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHello$ServerHelloMessage;";
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
