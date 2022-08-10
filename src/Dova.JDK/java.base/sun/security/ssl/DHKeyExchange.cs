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

[JniSignatureAttribute("Lsun/security/ssl/DHKeyExchange;", "final")]
public partial class DHKeyExchange
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DHKeyExchange()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DHKeyExchange;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "poGenerator", "Lsun/security/ssl/SSLPossessionGenerator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "poExportableGenerator", "Lsun/security/ssl/SSLPossessionGenerator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "kaGenerator", "Lsun/security/ssl/SSLKeyAgreementGenerator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DHKeyExchange", "()V"));
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

	[JniSignatureAttribute("Lsun/security/ssl/SSLPossessionGenerator;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLPossessionGenerator poExportableGenerator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossessionGenerator>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyAgreementGenerator;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator kaGenerator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DHKeyExchange(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public DHKeyExchange() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/DHKeyExchange;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Lsun/security/ssl/DHKeyExchange$DHEPossessionGenerator;", "private static final")]
	public partial class DHEPossessionGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLPossessionGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DHEPossessionGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DHKeyExchange$DHEPossessionGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "useSmartEphemeralDHKeys", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "useLegacyEphemeralDHKeys", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "customizedDHKeySize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exportable", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DHEPossessionGenerator", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPossession", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool useSmartEphemeralDHKeys_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool useLegacyEphemeralDHKeys_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int customizedDHKeySize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool exportable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DHEPossessionGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Z)V", "private")]
		public DHEPossessionGenerator(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DHKeyExchange$DHEPossessionGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;", "public")]
		public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/DHKeyExchange$DHEKAGenerator;", "private static final")]
	public partial class DHEKAGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DHEKAGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DHKeyExchange$DHEKAGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Lsun/security/ssl/DHKeyExchange$DHEKAGenerator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DHEKAGenerator", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/DHKeyExchange$DHEKAGenerator;", "private static final")]
		public static Dova.JDK.sun.security.ssl.DHKeyExchange.DHEKAGenerator instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DHKeyExchange.DHEKAGenerator>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DHEKAGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DHEKAGenerator() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DHKeyExchange$DHEKAGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/DHKeyExchange$DHEPossession;", "static final")]
	public partial class DHEPossession
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.NamedGroupPossession
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DHEPossession()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DHKeyExchange$DHEPossession;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "privateKey", "Ljava/security/PrivateKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "publicKey", "Ljavax/crypto/interfaces/DHPublicKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "namedGroup", "Lsun/security/ssl/NamedGroup;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DHEPossession", "(Lsun/security/ssl/DHKeyExchange$DHECredentials;Ljava/security/SecureRandom;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DHEPossession", "(ILjava/security/SecureRandom;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DHEPossession", "(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "encode", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPublicKey", "()Ljava/security/PublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrivateKey", "()Ljava/security/PrivateKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "generateDHKeyPair", "(Ljava/security/KeyPairGenerator;)Ljava/security/KeyPair;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDHPublicKeySpec", "(Ljava/security/PublicKey;)Ljavax/crypto/spec/DHPublicKeySpec;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNamedGroup", "()Lsun/security/ssl/NamedGroup;"));
		}

		[JniSignatureAttribute("Ljava/security/PrivateKey;", "final")]
		public Dova.JDK.java.security.PrivateKey privateKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/crypto/interfaces/DHPublicKey;", "final")]
		public Dova.JDK.javax.crypto.interfaces.DHPublicKey publicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.interfaces.DHPublicKey>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "final")]
		public Dova.JDK.sun.security.ssl.NamedGroup namedGroup_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DHEPossession(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/DHKeyExchange$DHECredentials;Ljava/security/SecureRandom;)V", "")]
		public DHEPossession(Dova.JDK.sun.security.ssl.DHKeyExchange.DHECredentials arg0, Dova.JDK.java.security.SecureRandom arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(ILjava/security/SecureRandom;)V", "")]
		public DHEPossession(int arg0, Dova.JDK.java.security.SecureRandom arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)V", "")]
		public DHEPossession(Dova.JDK.sun.security.ssl.NamedGroup arg0, Dova.JDK.java.security.SecureRandom arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DHKeyExchange$DHEPossession;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[B", "public")]
		public JavaArray<byte> encode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Ljava/security/PublicKey;", "public")]
		public Dova.JDK.java.security.PublicKey getPublicKey()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
		}

		[JniSignatureAttribute("()Ljava/security/PrivateKey;", "public")]
		public Dova.JDK.java.security.PrivateKey getPrivateKey()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/KeyPairGenerator;)Ljava/security/KeyPair;", "private")]
		public Dova.JDK.java.security.KeyPair generateDHKeyPair(Dova.JDK.java.security.KeyPairGenerator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyPair>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PublicKey;)Ljavax/crypto/spec/DHPublicKeySpec;", "private static")]
		public static Dova.JDK.javax.crypto.spec.DHPublicKeySpec getDHPublicKeySpec(Dova.JDK.java.security.PublicKey arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.spec.DHPublicKeySpec>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/NamedGroup;", "public")]
		public Dova.JDK.sun.security.ssl.NamedGroup getNamedGroup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/DHKeyExchange$DHECredentials;", "static final")]
	public partial class DHECredentials
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.NamedGroupCredentials
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DHECredentials()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/DHKeyExchange$DHECredentials;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "popPublicKey", "Ljavax/crypto/interfaces/DHPublicKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "namedGroup", "Lsun/security/ssl/NamedGroup;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DHECredentials", "(Ljavax/crypto/interfaces/DHPublicKey;Lsun/security/ssl/NamedGroup;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/DHKeyExchange$DHECredentials;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPublicKey", "()Ljava/security/PublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNamedGroup", "()Lsun/security/ssl/NamedGroup;"));
		}

		[JniSignatureAttribute("Ljavax/crypto/interfaces/DHPublicKey;", "final")]
		public Dova.JDK.javax.crypto.interfaces.DHPublicKey popPublicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.interfaces.DHPublicKey>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "final")]
		public Dova.JDK.sun.security.ssl.NamedGroup namedGroup_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DHECredentials(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/crypto/interfaces/DHPublicKey;Lsun/security/ssl/NamedGroup;)V", "")]
		public DHECredentials(Dova.JDK.javax.crypto.interfaces.DHPublicKey arg0, Dova.JDK.sun.security.ssl.NamedGroup arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/DHKeyExchange$DHECredentials;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/DHKeyExchange$DHECredentials;", "static")]
		public static Dova.JDK.sun.security.ssl.DHKeyExchange.DHECredentials valueOf(Dova.JDK.sun.security.ssl.NamedGroup arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.DHKeyExchange.DHECredentials>(ret);
		}

		[JniSignatureAttribute("()Ljava/security/PublicKey;", "public")]
		public Dova.JDK.java.security.PublicKey getPublicKey()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/NamedGroup;", "public")]
		public Dova.JDK.sun.security.ssl.NamedGroup getNamedGroup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
	}
}
