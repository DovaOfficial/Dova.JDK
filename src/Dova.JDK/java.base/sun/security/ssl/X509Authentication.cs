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

[JniSignatureAttribute("Lsun/security/ssl/X509Authentication;", "final")]
public partial class X509Authentication
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.sun.security.ssl.SSLAuthentication
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static X509Authentication()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509Authentication;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RSA", "Lsun/security/ssl/X509Authentication;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RSASSA_PSS", "Lsun/security/ssl/X509Authentication;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RSA_OR_PSS", "Lsun/security/ssl/X509Authentication;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSA", "Lsun/security/ssl/X509Authentication;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EC", "Lsun/security/ssl/X509Authentication;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EDDSA", "Lsun/security/ssl/X509Authentication;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyAlgorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyTypes", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/X509Authentication;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/X509Authentication;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Lsun/security/ssl/SignatureScheme;)Lsun/security/ssl/X509Authentication;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/X509Authentication;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/X509Authentication;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createClientPossession", "(Lsun/security/ssl/ClientHandshakeContext;[Ljava/lang/String;)Lsun/security/ssl/SSLPossession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createServerPossession", "(Lsun/security/ssl/ServerHandshakeContext;[Ljava/lang/String;)Lsun/security/ssl/SSLPossession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandshakeProducers", "(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRelatedHandshakers", "(Lsun/security/ssl/HandshakeContext;)[Lsun/security/ssl/SSLHandshake;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/HandshakeContext;[Ljava/lang/String;)Lsun/security/ssl/SSLPossession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509Authentication;", "public static final")]
	public static Dova.JDK.sun.security.ssl.X509Authentication RSA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509Authentication>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509Authentication;", "public static final")]
	public static Dova.JDK.sun.security.ssl.X509Authentication RSASSA_PSS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509Authentication>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509Authentication;", "public static final")]
	public static Dova.JDK.sun.security.ssl.X509Authentication RSA_OR_PSS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509Authentication>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509Authentication;", "public static final")]
	public static Dova.JDK.sun.security.ssl.X509Authentication DSA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509Authentication>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509Authentication;", "public static final")]
	public static Dova.JDK.sun.security.ssl.X509Authentication EC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509Authentication>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509Authentication;", "public static final")]
	public static Dova.JDK.sun.security.ssl.X509Authentication EDDSA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509Authentication>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String keyAlgorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "final")]
	public JavaArray<Dova.JDK.java.lang.String> keyTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/X509Authentication;", "private static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.X509Authentication> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509Authentication>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public X509Authentication(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;[Ljava/lang/String;)V", "private transient")]
	public X509Authentication(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.String> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/X509Authentication;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lsun/security/ssl/X509Authentication;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.X509Authentication> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509Authentication>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SignatureScheme;)Lsun/security/ssl/X509Authentication;", "static")]
	public static Dova.JDK.sun.security.ssl.X509Authentication valueOf(Dova.JDK.sun.security.ssl.SignatureScheme arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509Authentication>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/X509Authentication;", "public static")]
	public static Dova.JDK.sun.security.ssl.X509Authentication valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509Authentication>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/X509Authentication;", "private static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.X509Authentication> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509Authentication>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ClientHandshakeContext;[Ljava/lang/String;)Lsun/security/ssl/SSLPossession;", "private static")]
	public static Dova.JDK.sun.security.ssl.SSLPossession createClientPossession(Dova.JDK.sun.security.ssl.ClientHandshakeContext arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;[Ljava/lang/String;)Lsun/security/ssl/SSLPossession;", "private static")]
	public static Dova.JDK.sun.security.ssl.SSLPossession createServerPossession(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;", "public")]
	public JavaArray<Dova.JDK.java.util.Map.Entry> getHandshakeProducers(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Lsun/security/ssl/SSLHandshake;", "public")]
	public JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake> getRelatedHandshakers(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;[Ljava/lang/String;)Lsun/security/ssl/SSLPossession;", "public static")]
	public static Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.HandshakeContext arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;", "public")]
	public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509Authentication$X509Possession;", "static final")]
	public partial class X509Possession
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLPossession
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static X509Possession()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509Authentication$X509Possession;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "popCerts", "[Ljava/security/cert/X509Certificate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "popPrivateKey", "Ljava/security/PrivateKey;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXECParameterSpec", "()Ljava/security/spec/NamedParameterSpec;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getECParameterSpec", "()Ljava/security/spec/ECParameterSpec;"));
		}

		[JniSignatureAttribute("[Ljava/security/cert/X509Certificate;", "final")]
		public JavaArray<Dova.JDK.java.security.cert.X509Certificate> popCerts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/PrivateKey;", "final")]
		public Dova.JDK.java.security.PrivateKey popPrivateKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public X509Possession(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;)V", "")]
		public X509Possession(Dova.JDK.java.security.PrivateKey arg0, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/X509Authentication$X509Possession;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/security/spec/NamedParameterSpec;", "")]
		public Dova.JDK.java.security.spec.NamedParameterSpec getXECParameterSpec()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.NamedParameterSpec>(ret);
		}

		[JniSignatureAttribute("()Ljava/security/spec/ECParameterSpec;", "")]
		public Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509Authentication$X509Credentials;", "static final")]
	public partial class X509Credentials
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLCredentials
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static X509Credentials()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509Authentication$X509Credentials;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "popCerts", "[Ljava/security/cert/X509Certificate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "popPublicKey", "Ljava/security/PublicKey;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/PublicKey;[Ljava/security/cert/X509Certificate;)V"));
		}

		[JniSignatureAttribute("[Ljava/security/cert/X509Certificate;", "final")]
		public JavaArray<Dova.JDK.java.security.cert.X509Certificate> popCerts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/PublicKey;", "final")]
		public Dova.JDK.java.security.PublicKey popPublicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public X509Credentials(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/PublicKey;[Ljava/security/cert/X509Certificate;)V", "")]
		public X509Credentials(Dova.JDK.java.security.PublicKey arg0, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/X509Authentication$X509Credentials;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
