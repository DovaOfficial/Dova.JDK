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

[JniSignatureAttribute("Lsun/security/ssl/XDHKeyExchange;", "final")]
public partial class XDHKeyExchange
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XDHKeyExchange()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/XDHKeyExchange;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "xdheKAGenerator", "Lsun/security/ssl/SSLKeyAgreementGenerator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XDHKeyExchange", "()V"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyAgreementGenerator;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator xdheKAGenerator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XDHKeyExchange(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public XDHKeyExchange() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/XDHKeyExchange;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Lsun/security/ssl/XDHKeyExchange$XDHEKAGenerator;", "private static final")]
	public partial class XDHEKAGenerator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XDHEKAGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/XDHKeyExchange$XDHEKAGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XDHEKAGenerator", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XDHEKAGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public XDHEKAGenerator() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/XDHKeyExchange$XDHEKAGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/XDHKeyExchange$XDHEPossession;", "static final")]
	public partial class XDHEPossession
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.NamedGroupPossession
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XDHEPossession()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/XDHKeyExchange$XDHEPossession;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "privateKey", "Ljava/security/PrivateKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "publicKey", "Ljava/security/interfaces/XECPublicKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "namedGroup", "Lsun/security/ssl/NamedGroup;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XDHEPossession", "(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "encode", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPublicKey", "()Ljava/security/PublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrivateKey", "()Ljava/security/PrivateKey;"));
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

		[JniSignatureAttribute("Ljava/security/interfaces/XECPublicKey;", "final")]
		public Dova.JDK.java.security.interfaces.XECPublicKey publicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.XECPublicKey>(ret);
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
		public XDHEPossession(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;Ljava/security/SecureRandom;)V", "")]
		public XDHEPossession(Dova.JDK.sun.security.ssl.NamedGroup arg0, Dova.JDK.java.security.SecureRandom arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/XDHKeyExchange$XDHEPossession;";
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

		[JniSignatureAttribute("()Lsun/security/ssl/NamedGroup;", "public")]
		public Dova.JDK.sun.security.ssl.NamedGroup getNamedGroup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/XDHKeyExchange$XDHECredentials;", "static final")]
	public partial class XDHECredentials
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.NamedGroupCredentials
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XDHECredentials()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/XDHKeyExchange$XDHECredentials;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "popPublicKey", "Ljava/security/interfaces/XECPublicKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "namedGroup", "Lsun/security/ssl/NamedGroup;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XDHECredentials", "(Ljava/security/interfaces/XECPublicKey;Lsun/security/ssl/NamedGroup;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/XDHKeyExchange$XDHECredentials;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPublicKey", "()Ljava/security/PublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNamedGroup", "()Lsun/security/ssl/NamedGroup;"));
		}

		[JniSignatureAttribute("Ljava/security/interfaces/XECPublicKey;", "final")]
		public Dova.JDK.java.security.interfaces.XECPublicKey popPublicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.XECPublicKey>(ret);
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
		public XDHECredentials(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/interfaces/XECPublicKey;Lsun/security/ssl/NamedGroup;)V", "")]
		public XDHECredentials(Dova.JDK.java.security.interfaces.XECPublicKey arg0, Dova.JDK.sun.security.ssl.NamedGroup arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/XDHKeyExchange$XDHECredentials;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;[B)Lsun/security/ssl/XDHKeyExchange$XDHECredentials;", "static")]
		public static Dova.JDK.sun.security.ssl.XDHKeyExchange.XDHECredentials valueOf(Dova.JDK.sun.security.ssl.NamedGroup arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.XDHKeyExchange.XDHECredentials>(ret);
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
