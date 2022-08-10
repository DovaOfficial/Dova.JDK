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

[JniSignatureAttribute("Lsun/security/ssl/RSAKeyExchange;", "final")]
public partial class RSAKeyExchange
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RSAKeyExchange()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/RSAKeyExchange;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "poGenerator", "Lsun/security/ssl/SSLPossessionGenerator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "kaGenerator", "Lsun/security/ssl/SSLKeyAgreementGenerator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RSAKeyExchange", "()V"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLPossessionGenerator;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLPossessionGenerator poGenerator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossessionGenerator>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyAgreementGenerator;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator kaGenerator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RSAKeyExchange(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public RSAKeyExchange() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/RSAKeyExchange;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Lsun/security/ssl/RSAKeyExchange$EphemeralRSAPossessionGenerator;", "private static final")]
	public partial class EphemeralRSAPossessionGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLPossessionGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EphemeralRSAPossessionGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/RSAKeyExchange$EphemeralRSAPossessionGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "EphemeralRSAPossessionGenerator", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPossession", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EphemeralRSAPossessionGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public EphemeralRSAPossessionGenerator() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/RSAKeyExchange$EphemeralRSAPossessionGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;", "public")]
		public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/RSAKeyExchange$RSAKAGenerator;", "private static final")]
	public partial class RSAKAGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RSAKAGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/RSAKeyExchange$RSAKAGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RSAKAGenerator", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RSAKAGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public RSAKAGenerator() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/RSAKeyExchange$RSAKAGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}

		[JniSignatureAttribute("Lsun/security/ssl/RSAKeyExchange$RSAKAGenerator$RSAKAKeyDerivation;", "private static final")]
		public partial class RSAKAKeyDerivation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.sun.security.ssl.SSLKeyDerivation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RSAKAKeyDerivation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/RSAKeyExchange$RSAKAGenerator$RSAKAKeyDerivation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "context", "Lsun/security/ssl/HandshakeContext;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "preMasterSecret", "Ljavax/crypto/SecretKey;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RSAKAKeyDerivation", "(Lsun/security/ssl/HandshakeContext;Ljavax/crypto/SecretKey;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deriveKey", "(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;"));
			}

			[JniSignatureAttribute("Lsun/security/ssl/HandshakeContext;", "private final")]
			public Dova.JDK.sun.security.ssl.HandshakeContext context_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeContext>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "private final")]
			public Dova.JDK.javax.crypto.SecretKey preMasterSecret_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RSAKAKeyDerivation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Ljavax/crypto/SecretKey;)V", "")]
			public RSAKAKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.javax.crypto.SecretKey arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/ssl/RSAKeyExchange$RSAKAGenerator$RSAKAKeyDerivation;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;", "public")]
			public Dova.JDK.javax.crypto.SecretKey deriveKey(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/RSAKeyExchange$RSAPremasterSecret;", "static final")]
	public partial class RSAPremasterSecret
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLPossession
		, Dova.JDK.sun.security.ssl.SSLCredentials
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RSAPremasterSecret()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/RSAKeyExchange$RSAPremasterSecret;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "premasterSecret", "Ljavax/crypto/SecretKey;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RSAPremasterSecret", "(Ljavax/crypto/SecretKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "decode", "(Lsun/security/ssl/ServerHandshakeContext;Ljava/security/PrivateKey;[B)Lsun/security/ssl/RSAKeyExchange$RSAPremasterSecret;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEncoded", "(Ljava/security/PublicKey;Ljava/security/SecureRandom;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createPremasterSecret", "(Lsun/security/ssl/ClientHandshakeContext;)Lsun/security/ssl/RSAKeyExchange$RSAPremasterSecret;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "safeProviderName", "(Ljavax/crypto/Cipher;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "generatePremasterSecret", "(II[BLjava/security/SecureRandom;)Ljavax/crypto/SecretKey;"));
		}

		[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "final")]
		public Dova.JDK.javax.crypto.SecretKey premasterSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RSAPremasterSecret(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/crypto/SecretKey;)V", "")]
		public RSAPremasterSecret(Dova.JDK.javax.crypto.SecretKey arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/RSAKeyExchange$RSAPremasterSecret;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;Ljava/security/PrivateKey;[B)Lsun/security/ssl/RSAKeyExchange$RSAPremasterSecret;", "static")]
		public static Dova.JDK.sun.security.ssl.RSAKeyExchange.RSAPremasterSecret decode(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, Dova.JDK.java.security.PrivateKey arg1, JavaArray<byte> arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.RSAKeyExchange.RSAPremasterSecret>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PublicKey;Ljava/security/SecureRandom;)[B", "")]
		public JavaArray<byte> getEncoded(Dova.JDK.java.security.PublicKey arg0, Dova.JDK.java.security.SecureRandom arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;)Lsun/security/ssl/RSAKeyExchange$RSAPremasterSecret;", "static")]
		public static Dova.JDK.sun.security.ssl.RSAKeyExchange.RSAPremasterSecret createPremasterSecret(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.RSAKeyExchange.RSAPremasterSecret>(ret);
		}

		[JniSignatureAttribute("(Ljavax/crypto/Cipher;)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String safeProviderName(Dova.JDK.javax.crypto.Cipher arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(II[BLjava/security/SecureRandom;)Ljavax/crypto/SecretKey;", "private static")]
		public static Dova.JDK.javax.crypto.SecretKey generatePremasterSecret(int arg0, int arg1, JavaArray<byte> arg2, Dova.JDK.java.security.SecureRandom arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/RSAKeyExchange$EphemeralRSACredentials;", "static final")]
	public partial class EphemeralRSACredentials
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCredentials
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EphemeralRSACredentials()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/RSAKeyExchange$EphemeralRSACredentials;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "popPublicKey", "Ljava/security/interfaces/RSAPublicKey;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "EphemeralRSACredentials", "(Ljava/security/interfaces/RSAPublicKey;)V"));
		}

		[JniSignatureAttribute("Ljava/security/interfaces/RSAPublicKey;", "final")]
		public Dova.JDK.java.security.interfaces.RSAPublicKey popPublicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.RSAPublicKey>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EphemeralRSACredentials(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/interfaces/RSAPublicKey;)V", "")]
		public EphemeralRSACredentials(Dova.JDK.java.security.interfaces.RSAPublicKey arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/RSAKeyExchange$EphemeralRSACredentials;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/RSAKeyExchange$EphemeralRSAPossession;", "static final")]
	public partial class EphemeralRSAPossession
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLPossession
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EphemeralRSAPossession()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/RSAKeyExchange$EphemeralRSAPossession;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "popPublicKey", "Ljava/security/interfaces/RSAPublicKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "popPrivateKey", "Ljava/security/PrivateKey;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "EphemeralRSAPossession", "(Ljava/security/PrivateKey;Ljava/security/interfaces/RSAPublicKey;)V"));
		}

		[JniSignatureAttribute("Ljava/security/interfaces/RSAPublicKey;", "final")]
		public Dova.JDK.java.security.interfaces.RSAPublicKey popPublicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.RSAPublicKey>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/security/PrivateKey;", "final")]
		public Dova.JDK.java.security.PrivateKey popPrivateKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EphemeralRSAPossession(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/PrivateKey;Ljava/security/interfaces/RSAPublicKey;)V", "")]
		public EphemeralRSAPossession(Dova.JDK.java.security.PrivateKey arg0, Dova.JDK.java.security.interfaces.RSAPublicKey arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/RSAKeyExchange$EphemeralRSAPossession;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
